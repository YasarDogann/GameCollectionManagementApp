using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GameCollectionManagement.Repositories
{
    public interface IRepository<T> where T : class // generic t ve class vermeyen hiçbir sınıf bu interfaceyi kullanamıcak
    {
        List<T> GetAll(); // bütün veriyi çeken methıd
        T GetById(int id);  // id'ye göre çekiyor

        void Add(T entity); // ekleme geriye değer döndürmesin void
        void Update(T entity);  // update işlemi
        void Delete(T entity);
        void Delete(int id);
     }
}
