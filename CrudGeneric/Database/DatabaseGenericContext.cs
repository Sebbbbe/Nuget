using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CrudGeneric.Models;

namespace CrudGeneric.Database
{
    public class DatabaseGeneric<T> : DbContext
    {
        public DatabaseGeneric(DbContextOptions<DatabaseGeneric<T>> options)
            : base(options)
        {

        }

        public DbSet<T> T { get; set; }



    }
}
