using Crud.Data.Models;
using Crud.DTO;

namespace IData.Interfaces.Command
{
    public interface ICustomerCommandRepository
    {
        void AddNewCustomer(Customer customer);
        CustomerDTO EditCustomer(Customer customer);
        void DeleteCustomer(int id);
        void Save();
    }
}
