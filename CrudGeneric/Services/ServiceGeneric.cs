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
    public class ServiceGeneric<T> : IServiceGeneric<T> where T : class
    {

        private readonly RepositoryGeneric<T> _repositoryGeneric;

        public ServiceGeneric(RepositoryGeneric<T> repositoryGeneric)
{
            _repositoryGeneric = repositoryGeneric;
        }


        public Task<List<T>> FindAllGeneric(T t)
        {
            return _repositoryGeneric.FindAllGeneric(t);
        }

        public Task<T> FindGeneric(T t)
        {
            return _repositoryGeneric.FindOneGeneric(t);
        }
    }
}
