using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudGeneric.Models;

namespace CrudGeneric.Database
{
    public class DatabaseGenericContext<T,P> :  DbContext where T : class where P : class
    {
        public DatabaseGenericContext(DbContextOptions<DatabaseGenericContext<T,P>> options)
            : base(options)
        {

        }

        public DbSet<P> P1 { get; set; }



    }

    
}
