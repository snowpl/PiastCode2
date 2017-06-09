using Crud.DTO;
using System.Collections.Generic;

namespace IData.Interfaces.Command
{
    public interface ICustomerQueryRepository
    {
        List<CustomerDTO> GetAll();
        CustomerDTO GetCustomerById(int id);
    }
}
