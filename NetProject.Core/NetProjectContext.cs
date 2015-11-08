using NetProject.Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetProject.Core
{
    public class NetProjectContext : DbContext
    {
        public NetProjectContext()
<<<<<<< HEAD
            : base("server=.;initial catalog=DbNetProject; Trusted_Connection=true; MultipleActiveResultSets=True")
=======
            : base("NetProjectConn")
>>>>>>> dccc99685e4292ffa4d3a031e87be19b68dfbf6b
            
            //base("server=.;initial catalog=DbNetProject; Trusted_Connection=true; MultipleActiveResultSets=True")

           
        {

            Database.SetInitializer<NetProjectContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //PluralizingTableNameConvention
            modelBuilder.Entity<Brand>();
            modelBuilder.Entity<Product>();
            //modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }

    }
}
