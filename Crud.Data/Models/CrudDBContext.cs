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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(typeof(CrudDBContext).Assembly);
        }
    }
}
