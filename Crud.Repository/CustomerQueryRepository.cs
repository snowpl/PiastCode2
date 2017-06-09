using System.Linq;
using System.Collections.Generic;
using IData.Interfaces.Command;
using Crud.Data.Models;
using Crud.Data.Mappings;
using Crud.DTO;

namespace Crud.Repositories
{
    public class CustomerQueryRepository : ICustomerQueryRepository
    {
        private readonly CrudDBContext _dbContext;
        public CustomerQueryRepository(CrudDBContext dbcontext)
        {
            _dbContext = dbcontext;
        }

        public List<CustomerDTO> GetAll()
        {
            var entity = _dbContext.Customer.Select(x => x);
            var result = new List<CustomerDTO>();
            foreach (var customer in entity)
            {
                result.Add(customer.Map());
            }
            return result;
        }

        public CustomerDTO GetCustomerById(int Id)
        {
            var entity = _dbContext.Customer.FirstOrDefault(x => x.Id == Id);
            var result = entity.Map();
            return result;
        }
    }
}
