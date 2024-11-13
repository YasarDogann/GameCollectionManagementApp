using GameCollectionManagement.Models;
using GameCollectionManagement.Models.Mappers;
using GameCollectionManagement.Utilities.Database;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollectionManagement.Repositories
{
    public class UserRepository : BaseRepository<User>
    {
        public override List<User> GetAll()
        {
            string query = "select * from \"Users\"";

            DataTable dataTable = ExecuteQuery(query);

            List<User> users = new List<User>();

            foreach (DataRow row in dataTable.Rows)
            {
                users.Add(DataMappers.MapToUser(row));
            }
            return users;
        }

        public override User GetById(int id)
        {
            string query = "Select * from \"Users\" where \"Id\"=@Id";
            //NpgsqlParameter[] sqlParameters = new NpgsqlParameter[] {
            //    new NpgsqlParameter("@Id",id)
            //};

            var parameters = new SqlParameterBuilder()
                             .AddParameter("@Id", id)
                             .Build();  
            DataTable dataTable = ExecuteQuery(query, parameters);

            if (dataTable.Rows.Count == 0)
                return null;

            DataRow row = dataTable.Rows[0];

           return DataMappers.MapToUser(row);
        }

        // Add
        public override void Add(User entity)
        {
            string query = "insert into \"Users\"(\"UserName\",\"Email\",\"Password\",\"Role\") values (@UserName,@Email,@Password,@Role)";

            //NpgsqlParameter[] parameters = new NpgsqlParameter[] {
            //    new NpgsqlParameter("@UserName", entity.UserName),
            //    new NpgsqlParameter("@Email", entity.Email),
            //    new NpgsqlParameter("@Password", entity.Password),
            //    new NpgsqlParameter("@Role", entity.Role)
            //};

            var parameters = new SqlParameterBuilder()
                              .AddParameter("@UserName", entity.UserName)
                              .AddParameter("@Email", entity.Email)
                              .AddParameter("@Password", entity.Password)
                              .AddParameter("@Role", entity.Role)
                              .Build();
            ExecuteNonQuery(query, parameters);
        }

        // Update
        public override void Update(User entity)
        {
            string query = "Update \"Users\" set \"UserName\"=@UserName,\"Email\"=@Email,\"Password\"=@Password,\"Role\"=@Role where \"Id\"=@Id";

            //NpgsqlParameter[] parameters = new NpgsqlParameter[]
            //{
            //    new NpgsqlParameter("@Id",entity.Id),
            //    new NpgsqlParameter("@UserName", entity.UserName),
            //    new NpgsqlParameter("@Email", entity.Email),
            //    new NpgsqlParameter("@Password", entity.Password),
            //    new NpgsqlParameter("@Role", entity.Role)
            //};

            var parameters = new SqlParameterBuilder()
                               .AddParameter("@Id", entity.Id)
                              .AddParameter("@UserName", entity.UserName)
                              .AddParameter("@Email", entity.Email)
                              .AddParameter("@Password", entity.Password)
                              .AddParameter("@Role", entity.Role)
                              .Build();
            ExecuteNonQuery(query, parameters); 
        }

        //Delete
        public override void Delete(int id)
        {
            string query = "delete from \"Users\" where \"Id\"=@Id";
            //NpgsqlParameter[] parameters = new NpgsqlParameter[]
            //{
            //    new NpgsqlParameter("@Id",id)
            //};
            var parameters = new SqlParameterBuilder()
                             .AddParameter("@Id", id)
                             .Build();
            ExecuteNonQuery(query, parameters);
        }

        public override void Delete(User entity)
        {
            Delete(entity.Id);
        }

        public (bool,int?) Login(string userName, string password)
        {
            string query = "select \"Id\" from \"Users\" where \"UserName\"=@UserName and \"Password\"=@Password";
            //NpgsqlParameter[] parameters = new NpgsqlParameter[]
            //{
            //    new NpgsqlParameter("@UserName", userName),
            //    new NpgsqlParameter("@Password", password),
            //};

            var parameters = new SqlParameterBuilder()
                               .AddParameter("@UserName", userName)
                               .AddParameter("@Password", password)
                               .Build();

            var dataTable = ExecuteQuery(query, parameters);

            if(dataTable.Rows.Count == 0)
            {
                return (false, null);
            }

            int id = (int)dataTable.Rows[0]["Id"];
            return (true, id);

        }
    }
}