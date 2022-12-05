using RepositoryPattern_Factory.Models;
using RepositoryPattern_Factory.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern_Factory.Factories
{
    public interface IRepoFactory
    {
        GenericRepo<T> Create<T>() where T : class, IEntity, new();
    }
}
