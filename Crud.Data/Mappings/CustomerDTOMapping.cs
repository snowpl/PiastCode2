using Crud.DTO;
using Crud.Data.Models;
using System;

namespace Crud.Data.Mappings
{
    public static class CustomerDTOMappings
    {
        public static CustomerDTO Map(this Customer source)
        {
            var target = new CustomerDTO();

            target.Address = source.Address;
            target.CreateDate = DateTime.Now;
            target.Id = source.Id;
            target.Name = source.Name;
            target.Surname = source.Surname;
            target.TelephoneNumber = source.TelephoneNumber;

            return target;
        }

        public static Customer Map(this CustomerDTO source)
        {
            var target = new Customer();
            target.Address = source.Address;
            target.CreateDate = DateTime.Now;
            target.Id = source.Id;
            target.Name = source.Name;
            target.Surname = source.Surname;
            target.TelephoneNumber = source.TelephoneNumber;

            return target;
        }
    }
}
