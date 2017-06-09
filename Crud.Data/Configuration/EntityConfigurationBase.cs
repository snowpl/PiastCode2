using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Crud.Data.Models
{
    public class EntityConfigurationBase<T> : EntityTypeConfiguration<T> where T : class, IEntity
    {
        public EntityConfigurationBase(string tableName)
        {
            SetBasicConfiguration(tableName);
        }

        private void SetBasicConfiguration(string tableName)
        {
            ToTable(tableName);

            HasKey(e => e.Id);

            Property(e => e.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(e => e.CreateDate).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Computed);
        }
    }
}
