using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using AngularFiltering.DAL.Mappings;
using AngularFiltering.DAL.Models;

namespace AngularFiltering.DAL
{
    public class AngularDbContext : DbContext
    {
        public AngularDbContext() : base("name=AngularDbContext")
        {
            this.Configuration.ProxyCreationEnabled = false;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Map();
        }

        public DbSet<Product> Products { get; set; }
    }
}
