using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Data.Models
{
    
    public class Customer : IEntity
    {

        #region IEntity
        public virtual int Id { get; set; }
               
        public virtual DateTime? CreateDate { get; set; }
        #endregion
               
        public virtual string Name { get; set; }
               
        public virtual string Surname { get; set; }
               
        public virtual int TelephoneNumber { get; set; }
               
        public virtual string Address { get; set; }

    }
}
