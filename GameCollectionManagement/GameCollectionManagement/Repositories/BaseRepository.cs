using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollectionManagement.Repositories
{
    // bu baseRepo'da ise temel veri tabanına bağlanma işlemlerini falan yazıyorum Soyut sınıf ve generic olmak zorunda 
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {

        //hangi vt hangi kullanıcıya vb. bağlanacağımızı yapmak için bir değişkene ihtiyacımız var
        protected string _connectionString = "Host=localhost;Port=5432;Database=GameCollectionManagement;Username=postgres;Password=admin;"; // protected kendi sınıfında ve miras alınan sınıflarda kullanır

        public abstract List<T> GetAll();
        public abstract T GetById(int id);
        public abstract void Add(T entity);
        public abstract void Update(T entity);
        public abstract void Delete(T entity);
        public abstract void Delete(int id);

        protected DataTable ExecuteQuery(string query, NpgsqlParameter[] parameters = null)  // bir query verdiğimizde bize sonucu datatable olarak döndürücek bir method 
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);
                //paramaetre var mı yok mu kontrol et
                if (parameters is not null)
                {
                    command.Parameters.AddRange(parameters);
                }
                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                return dataTable;
            }
        }

        // İşlmeleri yapmamıza yardımcı olacak method executenonquery
        protected int ExecuteNonQuery(string query, NpgsqlParameter[] parameters = null)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand(query, connection);

                //paramaetre var mı yok mu kontrol et
                if (parameters is not null)
                {
                    command.Parameters.AddRange(parameters);
                }
                return command.ExecuteNonQuery(); // etkilenen satır sayısını döndürüyor
            }

        }
    }
}
