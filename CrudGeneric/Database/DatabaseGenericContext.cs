using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudGeneric.Models;

namespace CrudGeneric.Database
{
    public class DatabaseGenericContext<T> :  DbContext where T : class 
    {
        public DatabaseGenericContext(DbContextOptions<DatabaseGenericContext<T>> options)
            : base(options)
        {

        }

        public DbSet<T> T1 { get; set; }



    }

    
}
