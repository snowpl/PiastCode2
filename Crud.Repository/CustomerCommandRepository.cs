using Crud.Data.Models;
using Crud.Data.Mappings;
using Crud.DTO;
using IData.Interfaces.Command;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Crud.Repositories
{
    public class CustomerCommandRepository : ICustomerCommandRepository
    {
        private readonly CrudDBContext _context;

        public CustomerCommandRepository(CrudDBContext context)
        {
            _context = context;
        }

        public void AddNewCustomer(Customer customer)
        {
            _context.Set<Customer>().Add(customer);
        }

        public CustomerDTO EditCustomer(Customer customer)
        {
            _context.Customer.AddOrUpdate(customer);
            return customer.Map();
        }

        public void DeleteCustomer(int id)
        {
            var entity = _context.Customer.Single(p => p.Id == id);

            _context.Set<Customer>().Remove(entity);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
