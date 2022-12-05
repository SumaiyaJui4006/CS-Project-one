using RepositoryPattern_Factory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern_Factory.Repositories
{
    public class GenericRepo<T> : IGenericRepo<T> where T : class, IEntity, new()
    {
        IList<T> data;
        public GenericRepo(IList<T> data)
        {
            this.data = data;
        }
        public void Add(T item)
        {
            this.data.Add(item);
        }

        public void Delete(int id)
        {
            var d = this.data.Where(x => x.Id == id).FirstOrDefault();
            if(d!= null)
            {
                var index =this.data.IndexOf(d);
                this.data.RemoveAt(index);
            }
        }

        public T Get(int id)
        {
            return this.data.Where(x => x.Id == id).FirstOrDefault();
        }

        public IList<T> GetAll()
        {
            return data;
        }

        public void Update(T item)
        {
            var d = this.data.Where(x => x.Id == item.Id).FirstOrDefault();
            if (d != null)
            {
                var index = this.data.IndexOf(d);
                this.data.RemoveAt(index);
                this.data.Insert(index, item);
            }
        }
    }
}
