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
    public class RepositoryGeneric<T,P> : IRepositoryGeneric<T,P> where T : class where P : class
    {

        private readonly DatabaseGenericContext<T,P> _databaseGenericContext;
        public RepositoryGeneric(DatabaseGenericContext<T,P> databaseGenericContext)
        {
            _databaseGenericContext = databaseGenericContext;
        }
        public async Task<List<P>> FindAllGeneric(){

            return await _databaseGenericContext.P1.ToListAsync();
        }
    
      
    }
}
