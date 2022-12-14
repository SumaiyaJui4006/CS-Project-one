using RepositoryPattern_Factory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern_Factory.Repositories
{
    public interface IGenericRepo<T> where T : class, IEntity, new()
    {
        IList<T> GetAll();
        T Get(int id);
        void Add(T item);
        void Update(T item);
        void Delete(int id);
    }
}
