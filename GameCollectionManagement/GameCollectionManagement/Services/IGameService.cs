using GameCollectionManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollectionManagement.Services
{
    public interface IGameService
    {
        List<Game> GetAll();
        Game GetById(int id);

        void Update(Game game);
        void Delete(int id);
        void Add(Game game);

        List<Game> Search(string searchTerm); 
        List<Game> GetByGenre(string genre);

        int GetTotalCount();

        List<string> GetGenres();
    }
}
