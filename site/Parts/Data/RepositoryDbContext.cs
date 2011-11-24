using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Boilerplate.DAL;

namespace Site.Parts.Data {
    public class RepositoryDbContext : DbContext, IDbContext
    {
        ILogger _logger;

        public RepositoryDbContext(ILogger logger)
            : base("Repository")
        {
            _logger = logger;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>();
            modelBuilder.Entity<CustomerDemographic>();
            modelBuilder.Entity<Customer>();
            modelBuilder.Entity<OrderDetail>();
            modelBuilder.Entity<Product>();
            modelBuilder.Entity<Region>();
            modelBuilder.Entity<Shipper>();
            modelBuilder.Entity<Supplier>();
            modelBuilder.Entity<Territory>();
        }

        public new IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public new void SaveChanges()
        {
            _logger.Write("Saving changes...");
            base.SaveChanges();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            _logger.Write("Data context disposed.");
        }
    }
}
