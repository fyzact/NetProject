﻿using NetProject.Domain;
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
<<<<<<< HEAD
        public NetProjectContext():
        base("server=.;initial catalog=DbNetProject; Trusted_Connection=true; MultipleActiveResultSets=True")
            //: base("NetProjectConn")
            
            
=======
        public NetProjectContext()
<<<<<<< HEAD
<<<<<<< HEAD
            : base("server=.;initial catalog=DbNetProject; Trusted_Connection=true; MultipleActiveResultSets=True")
=======
            : base("NetProjectConn")
>>>>>>> dccc99685e4292ffa4d3a031e87be19b68dfbf6b
=======
            : base("NetProjectConn")
>>>>>>> parent of eae2cc6... Imlemented Castle windsor
            
            //base("server=.;initial catalog=DbNetProject; Trusted_Connection=true; MultipleActiveResultSets=True")
>>>>>>> origin/master

           
        {

            Database.SetInitializer<NetProjectContext>(null);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //PluralizingTableNameConvention
<<<<<<< HEAD
            modelBuilder.Entity<BrandEntity>();
            modelBuilder.Entity<ProductEntity>();
=======
            modelBuilder.Entity<Brand>();
            modelBuilder.Entity<Product>();
>>>>>>> origin/master
            //modelBuilder.Conventions.Remove<IncludeMetadataConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

            base.OnModelCreating(modelBuilder);
        }

    }
}
