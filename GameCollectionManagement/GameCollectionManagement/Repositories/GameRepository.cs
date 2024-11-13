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
    /*
     BaseRepository'den miras aldı ve game nesneleri için özel sorguları ve işlemleri yazmış olduk
     */
    public class GameRepository : BaseRepository<Game>  // game sınıfını kullanıyoruz
    {

        public override List<Game> GetAll()
        {
            string query = "select * from \"Games\"";
            DataTable dataTable = ExecuteQuery(query);  // daha önceden tanımlamıştık
                                                        // 

            List<Game> games = new List<Game>();

            foreach (DataRow row in dataTable.Rows)
            {
                games.Add(DataMappers.MapToGame(row)); 
            }
            return games;
        }

        public List<Game> GetList()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                NpgsqlCommand command = new NpgsqlCommand("Select * From \"Games\"", connection);

                NpgsqlDataReader dataReader = command.ExecuteReader();

                List<Game> games = new List<Game>();
                while (dataReader.Read())  
                {
                    Game game = new Game();
                    game.Id = Convert.ToInt32(dataReader["Id"]);
                    game.Name = dataReader["Name"].ToString();
                    game.Genre = dataReader["Genre"].ToString();
                    game.Platform = dataReader["Platform"].ToString();
                    game.ReleaseDate = Convert.ToDateTime(dataReader["ReleaseDate"]);
                    game.PlayTime = Convert.ToInt32(dataReader["PlayTime"]);
                    game.CoverImage = dataReader["CoverImage"] as byte[];

                    games.Add(game);
                }
                dataReader.Close();
                return games;
            }
        }

        public override Game GetById(int id)
        {
            string query = "Select * from \"Games\" where \"Id\"=@Id";

            var parameters = new SqlParameterBuilder()
                             .AddParameter("@Id", id)
                             .Build();

            DataTable dataTable = ExecuteQuery(query, parameters);

            DataRow row = dataTable.Rows[0];

            return DataMappers.MapToGame(row);
        }

        // Oyun eklemesi
        public override void Add(Game entity)
        {
            string query =  "INSERT INTO \"Games\" (\"Name\", \"Genre\", \"Platform\", \"ReleaseDate\", \"PlayTime\", \"CoverImage\") VALUES (@Name, @Genre, @Platform, @ReleaseDate, @PlayTime, @CoverImage)";
            ;

            //NpgsqlParameter[] parameters = new NpgsqlParameter[]
            //{
            //    new NpgsqlParameter("@Name", entity.Name),
            //    new NpgsqlParameter("@Genre", entity.Genre),
            //    new NpgsqlParameter("@Platform", entity.Platform),
            //    new NpgsqlParameter("@ReleaseDate", entity.ReleaseDate),
            //    new NpgsqlParameter("@PlayTime", entity.PlayTime),
            //    new NpgsqlParameter("@CoverImage", entity.CoverImage),
            //};

            var parameters = new SqlParameterBuilder()
                             .AddParameter("@Name", entity.Name)
                             .AddParameter("@Genre", entity.Genre)
                             .AddParameter("@Platform", entity.Platform)
                             .AddParameter("@ReleaseDate", entity.ReleaseDate)
                             .AddParameter("@PlayTime", entity.PlayTime)
                             .AddParameterWithValue("@CoverImage", entity.CoverImage, SqlDbType.VarBinary)
                             .Build();

            ExecuteNonQuery(query, parameters); 
        }

        //Update methodu
        public override void Update(Game entity)
        {
            // ıd vermeyi unutursan bütün veriler update olur
            string query = "update \"Games\" Set \"Name\"=@Name,\"Genre\"=@Genre,\"Platform\"=@Platform,\"ReleaseDate\"=@ReleaseDate,\"PlayTime\"=@PlayTime,\"CoverImage\"=@CoverImage where \"Id\"=@Id";

            // NpgsqlParameter[] parameters = new NpgsqlParameter[]
            //{
            //    new NpgsqlParameter("@Id",entity.Id),
            //     new NpgsqlParameter("@Name", entity.Name),
            //     new NpgsqlParameter("@Genre", entity.Genre),
            //     new NpgsqlParameter("@Platform", entity.Platform),
            //     new NpgsqlParameter("@ReleaseDate", entity.ReleaseDate),
            //     new NpgsqlParameter("@PlayTime", entity.PlayTime),
            //     new NpgsqlParameter("@CoverImage", entity.CoverImage)
            //};


            var parameters = new SqlParameterBuilder()
                             .AddParameter("@Id", entity.Id)
                             .AddParameter("@Name", entity.Name)
                             .AddParameter("@Genre", entity.Genre)
                             .AddParameter("@Platform", entity.Platform)
                             .AddParameter("@ReleaseDate", entity.ReleaseDate)
                             .AddParameter("@PlayTime", entity.PlayTime)
                             .AddParameterWithValue("@CoverImage", entity.CoverImage, SqlDbType.VarBinary)
                             .Build();
            ExecuteNonQuery(query, parameters);
        }

        //Delete
        public override void Delete(int id)
        {
            string query = "delete from \"Games\" where \"Id\"=@Id";
            //NpgsqlParameter[] parameters = new NpgsqlParameter[]
            //{
            //    new NpgsqlParameter ("@Id",id)
            //};

            var parameters = new SqlParameterBuilder()
                             .AddParameter("@Id", id)
                             .Build();
            ExecuteNonQuery(query, parameters);
        }

        public override void Delete(Game entity)
        {
            Delete(entity.Id);
        }

        public List<string> GetGenres()
        {
            var games = GetAll();

            List<string> genres = new List<string>();

            foreach(var game in games)
            {
                if(!genres.Contains(game.Genre))
                    genres.Add(game.Genre);
            }

            return genres;
        }
    }
}
