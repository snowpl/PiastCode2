using System;

namespace Crud.DTO
{
    public class CustomerDTO : IModel
    {
        #region IEntity
        public virtual int Id { get; set; }

        public virtual DateTime? CreateDate { get; set; }
        #endregion

        public string Name { get; set; }

        public string Surname { get; set; }

        public int TelephoneNumber { get; set; }

        public string Address { get; set; }
    }

}
