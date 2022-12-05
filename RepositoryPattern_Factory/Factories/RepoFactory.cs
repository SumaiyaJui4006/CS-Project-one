using RepositoryPattern_Factory.Models;
using RepositoryPattern_Factory.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPattern_Factory.Factories
{
    public class RepoFactory : IRepoFactory
    {
        public GenericRepo<T> Create<T>() where T : class, IEntity, new()
        {
            return Activator.CreateInstance(typeof(GenericRepo<T>), new object[] { new List<T>() }) as GenericRepo<T>;
        }
    }
}
