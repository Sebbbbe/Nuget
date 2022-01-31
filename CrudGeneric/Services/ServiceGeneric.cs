using CrudGeneric.Database;
using CrudGeneric.Repository;
using CrudGeneric.Repository.IRepository;
using CrudGeneric.Services.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudGeneric.Services
{
    public class ServiceGeneric<T, P> : IServiceGeneric<T,P> where T : class where P :class
    {

        private readonly RepositoryGeneric<T,P> _repositoryGeneric;

        public ServiceGeneric(RepositoryGeneric<T,P> repositoryGeneric)
{
            _repositoryGeneric = repositoryGeneric;
        }


        public Task<List<P>> FindAllGeneric()
        {
            return _repositoryGeneric.FindAllGeneric();
        }

     
    }
}
