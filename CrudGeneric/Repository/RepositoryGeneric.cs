using CrudGeneric.Database;
using CrudGeneric.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudGeneric.Repository
{
    internal class RepositoryGeneric<T> : IRepositoryGeneric<T> where T : class
    {

        private readonly DatabaseGenericContext<T> _databaseGenericContext;
        public RepositoryGeneric(DatabaseGenericContext<T> databaseGenericContext)
        {
            _databaseGenericContext = databaseGenericContext;
        }
        public Task<List<T>> FindAllGeneric(T t)
        {
          return  _databaseGenericContext.T.ToList();
        }

        public Task<T> FindOneGeneric(T t)
        {
            throw new NotImplementedException();
        }
    }
}
