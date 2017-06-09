using Crud.Data.Models;
using Crud.DTO;

namespace Crud.IServices.Command
{
    public interface ICustomerCommandService
    {
        void AddNewCustomer(CustomerDTO customer);
        CustomerDTO EditCustomer(CustomerDTO customer);
        void DeleteCustomer(int id);
    }
}
