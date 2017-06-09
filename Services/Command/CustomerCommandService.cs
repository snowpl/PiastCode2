using Crud.IServices.Command;
using IData.Interfaces.Command;
using Crud.Data.Models;
using Crud.DTO;
using Crud.Data.Mappings;

namespace Services.Command
{
    public class CustomerCommandService : ICustomerCommandService
    {
        private readonly ICustomerCommandRepository _customerCommandRepository;

        public CustomerCommandService(ICustomerCommandRepository customerCommandRepository)
        {
            _customerCommandRepository = customerCommandRepository;
        }

        public void AddNewCustomer(CustomerDTO customer)
        {
            var customerDto = customer.Map();
            _customerCommandRepository.AddNewCustomer(customerDto);
            _customerCommandRepository.Save();
        }

        public void DeleteCustomer(int id)
        {
            _customerCommandRepository.DeleteCustomer(id);
            _customerCommandRepository.Save();
        }

        public CustomerDTO EditCustomer(CustomerDTO customer)
        {
            var result = _customerCommandRepository.EditCustomer(customer.Map());
            _customerCommandRepository.Save();

            return result;
        }
    }
}
