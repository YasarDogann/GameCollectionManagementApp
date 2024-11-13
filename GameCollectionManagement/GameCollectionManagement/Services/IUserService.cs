using GameCollectionManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollectionManagement.Services
{
    public interface IUserService
    {
        List<User> GetAll();
        User GetById(int id);
        void Update (User user);
        void Delete (int id);
        void Add(User user);
        (bool isAuthenticated, int? userId) Login(string username, string password);
        List<User> Search(string searchTerm);
    }
}
