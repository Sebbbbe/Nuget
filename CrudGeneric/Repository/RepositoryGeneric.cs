using CrudGeneric.Database;
using CrudGeneric.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CrudGeneric.Repository
{
    public class RepositoryGeneric<T> : IRepositoryGeneric<T> where T : class
    {

        private readonly DatabaseGenericContext<T> _databaseGenericContext;
        public RepositoryGeneric(DatabaseGenericContext<T> databaseGenericContext)
        {
            _databaseGenericContext = databaseGenericContext;
        }
        public async Task<List<T>> FindAllGeneric(){

            return await _databaseGenericContext.T1.ToListAsync();
        }
    
      
    }
}
