using System.Data.Entity;

namespace Crud.Data.Models
{
    public class CrudDBContext : DbContext
    {
        public CrudDBContext()
            :base("name=CrudDBContext")
        {
            Database.SetInitializer<CrudDBContext>(new DropCreateDatabaseAlways<CrudDBContext>());

            Configuration.LazyLoadingEnabled = true;
            Configuration.ProxyCreationEnabled = true;
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Outgoing> Outgoing { get; set; }
        public virtual DbSet<Localization> Localization { get; set; }
        public virtual DbSet<Tag> Tag { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(typeof(CrudDBContext).Assembly);
        }
    }
}
