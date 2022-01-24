using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudGeneric.Database
{
    public class DatabaseGeneric : DbContext
    {
        public DatabaseGeneric(DbContextOptions<TemplateDBContext> options)
            : base(options)
        {
        }

        public DbSet<Tenant> Tenants { get; set; }


        public DbSet<Output> Outputs { get; set; }
    }
