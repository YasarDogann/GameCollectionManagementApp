using GameCollectionManagement.Models;
using GameCollectionManagement.Models.Mappers;
using GameCollectionManagement.Utilities.Database;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace GameCollectionManagement.Repositories
{
    public class ReviewRepository : BaseRepository<Review>
    {
        public override List<Review> GetAll()
        {
            string query = "select * from \"Reviews\"";
            DataTable dataTable = ExecuteQuery(query);

            List<Review> reviews = new List<Review>();

            foreach (DataRow row in dataTable.Rows)
            {
                reviews.Add(DataMappers.MapToReview(row));
            }

            return reviews;
        }

        public List<Review> GetAllByRole(string role, int userId)
        {
            if(role == "admin")
            {
                return GetAll();
            }


            string query = "select * from \"Reviews\" where \"UserId\"=@UserId";

            var parameters = new SqlParameterBuilder()
                                .AddParameter("@UserId",userId)
                                .Build();

            DataTable dataTable = ExecuteQuery(query, parameters);

            List<Review> reviews = new List<Review>();

            foreach (DataRow row in dataTable.Rows)
            {
                reviews.Add(DataMappers.MapToReview(row));
            }

            return reviews;
        }

        public override Review GetById(int id)
        {
            string query = "select * from \"Reviews\" where \"Id\"=@Id";
            //NpgsqlParameter[] parameters = new NpgsqlParameter[]
            //{
            //    new NpgsqlParameter("@Id",id)
            //};

            var parameters = new SqlParameterBuilder()
                             .AddParameter("@Id", id)
                             .Build();
            DataTable dataTable = ExecuteQuery(query, parameters);

            if (dataTable.Rows.Count == 0) return null;

            DataRow row = dataTable.Rows[0];

            return DataMappers.MapToReview(row);
        }


        public override void Add(Review entity)
        {
            string query = "insert into \"Reviews\" (\"UserId\",\"GameId\",\"Rating\",\"ReviewText\") values (@UserId,@GameId,@Rating,@ReviewText)";

            //NpgsqlParameter[] parameters = new NpgsqlParameter[]
            //{
            //    new NpgsqlParameter("@UserId",entity.UserId),
            //    new NpgsqlParameter("@GameId",entity.GameId),
            //    new NpgsqlParameter("@Rating",entity.Rating),
            //    new NpgsqlParameter("@ReviewText",entity.ReviewText)
            //};

            var parameters = new SqlParameterBuilder()
                            .AddParameter("@UserId", entity.UserId)
                            .AddParameter("@GameId", entity.GameId)
                            .AddParameter("@Rating", entity.Rating)
                            .AddParameter("@ReviewText", entity.ReviewText)
                            .Build();

            ExecuteNonQuery(query, parameters);
        }

        public override void Update(Review entity)
        {
            string query = "update \"Reviews\" Set \"UserId\"=@UserId,\"GameId\"=@GameId,\"Rating\"=@Rating,\"ReviewText\"=@ReviewText where \"Id\"=@Id";

            //NpgsqlParameter[] parameters = new NpgsqlParameter[]
            //{
            //    new NpgsqlParameter("@Id",entity.Id),
            //    new NpgsqlParameter("@UserId",entity.UserId),
            //    new NpgsqlParameter("@GameId",entity.GameId),
            //    new NpgsqlParameter("@Rating",entity.Rating),
            //    new NpgsqlParameter("@ReviewText",entity.ReviewText)
            //};

            var parameters = new SqlParameterBuilder()
                            .AddParameter("@Id", entity.Id)
                            .AddParameter("@UserId", entity.UserId)
                            .AddParameter("@GameId", entity.GameId)
                            .AddParameter("@Rating", entity.Rating)
                            .AddParameter("@ReviewText", entity.ReviewText)
                            .Build();
            ExecuteNonQuery(query, parameters);
        }


        public override void Delete(int id)
        {
            string query = "delete from \"Reviews\" where \"Id\"=@Id";
            //NpgsqlParameter[] parameters = new NpgsqlParameter[]
            //{
            //    new NpgsqlParameter("@Id",id)
            //};
            var parameters = new SqlParameterBuilder()
                             .AddParameter("@Id", id)
                             .Build();
            ExecuteNonQuery(query, parameters);
        }

        public override void Delete(Review entity)
        {
            Delete(entity.Id);
        }

        public void DeleteByRole(int reviewId, string role, int userId)
        {
            if(role != "admin")
            {
                var review = GetById(reviewId);
                if (review.UserId != userId)
                    return;

            }
            Delete(reviewId);
        }

        public List<Review> GetAllWithDetails()
        {
            string query = "select r.*, u.UserName, u.Email, u.Password, u.Role, g.Name, g.Genre, g.Platform, g.ReleaseDate, g.Platform, g.CoverImage " +
                "from \"Reviews\" r inner join \"Users\" u on r.UserId=u.Id inner join Games g on r.GameId=g.Id";

            DataTable dataTable = ExecuteQuery(query);
            List<Review> reviews = new List<Review>();

            foreach (DataRow row in dataTable.Rows)
            {
                reviews.Add(DataMappers.MapToReviewWithDetails(row));
            }
            return reviews;
        }

        public Review GetByIdWithDetails(int id)
        {
            string query = "select r.*, u.UserName, u.Email, u.Password, u.Role, g.Name, g.Genre, g.Platform, g.ReleaseDate, g.Platform, g.CoverImage " +
                "from \"Reviews\" r inner join \"Users\" u on r.UserId=u.Id inner join Games g on r.GameId=g.Id where r.Id=@Id";

            //NpgsqlParameter[] parameters = new NpgsqlParameter[]
            //{
            //    new NpgsqlParameter ("@Id",id)
            //};
            var parameters = new SqlParameterBuilder()
                             .AddParameter("@Id", id)
                             .Build();

            DataTable dataTable = ExecuteQuery(query, parameters);

            if (dataTable.Rows.Count == 0) return null;

            DataRow row = dataTable.Rows[0];
            return DataMappers.MapToReviewWithDetails(row);
        }
    }
}
