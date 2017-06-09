using Crud.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Data.Configuration
{
    public class CustomerConfiguration : EntityConfigurationBase<Customer>
    {
        public CustomerConfiguration()
            :base("Customer")
        {
            Property(e => e.Name).HasMaxLength(255);
            Property(e => e.Surname).HasMaxLength(255);
            Property(e => e.Address).HasMaxLength(255);
            Property(e => e.TelephoneNumber);
        }
    }
}
