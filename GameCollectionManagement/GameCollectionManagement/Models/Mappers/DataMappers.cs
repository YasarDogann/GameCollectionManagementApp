using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollectionManagement.Models.Mappers
{
    public class DataMappers
    {
        public static Review MapToReview(DataRow row)
        {
            return new Review
            {
                Id = Convert.ToInt32(row["Id"]),
                GameId = Convert.ToInt32(row["GameId"]),
                Rating = Convert.ToInt32(row["Rating"]),
                UserId = Convert.ToInt32(row["UserId"]),
                ReviewText = row["ReviewText"].ToString()
            };
        }

        public static Review MapToReviewWithDetails(DataRow row)
        {
            return new Review
            {
                Id = Convert.ToInt32(row["Id"]),
                GameId = Convert.ToInt32(row["GameId"]),
                Rating = Convert.ToInt32(row["Rating"]),
                UserId = Convert.ToInt32(row["UserId"]),
                ReviewText = row["ReviewText"].ToString(),
                Game = new Game
                {
                    Id = Convert.ToInt32(row["GameId"]),
                    CoverImage = row["CoverImage"] as byte[],
                    Genre = row["Genre"].ToString(),
                    Name = row["Name"].ToString(),
                    Platform = row["Platform"].ToString(),
                    PlayTime = Convert.ToInt32(row["PlayTime"]),
                    ReleaseDate = Convert.ToDateTime(row["ReleaseDate"])
                },
                User = new User
                {
                    Id = Convert.ToInt32(row["UserId"]),
                    Email = row["Email"].ToString(),
                    Password = row["Password"].ToString(),
                    Role = row["Role"].ToString(),
                    UserName = row["UserName"].ToString(),
                }
            };
        }

        public static Game MapToGame(DataRow row)
        {
            Game game = new Game();

            game.Id = Convert.ToInt32(row["Id"]);
            game.Name = row["Name"].ToString();
            game.Genre = row["Genre"].ToString();
            game.Platform = row["Platform"].ToString();
            game.ReleaseDate = Convert.ToDateTime(row["ReleaseDate"]);
            game.PlayTime = Convert.ToInt32(row["PlayTime"]);
            game.CoverImage = row["CoverImage"] as byte[];

            return game;
        }

        public static User MapToUser(DataRow row)
        {
            return new User
            {
                Id = Convert.ToInt32(row["Id"]),
                Email = row["Email"].ToString(),
                Password = row["Password"].ToString(),
                Role = row["Role"].ToString(),
                UserName = row["UserName"].ToString()
            };
        }

    }
}
