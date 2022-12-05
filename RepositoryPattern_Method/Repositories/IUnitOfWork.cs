using RepositoryPattern_Method.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern_Method.Repositories
{
    public interface IUnitOfWork
    {
        IGenericRepo<T> Get<T>() where T : class, IEntity, new();
    }
}
