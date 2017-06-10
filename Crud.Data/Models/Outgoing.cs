using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crud.DTO;

namespace Crud.Data.Models
{
    public class Outgoing:IEntity
    {
        #region IEntity
        public virtual int Id { get; set; }
        public virtual DateTime? CreateDate { get; set; }
#endregion IEntity
        public virtual Localization OutgoingLocalization { get; set; }
        public virtual DateTime OutgoingDate { get; set; }
        public virtual TimeSpan OutgoingTime { get; set; }
        public virtual int AgeGroupMax { get; set; }
        public virtual int AgeGroupMin { get; set; }
        public virtual string Title { get; set; }
        public virtual decimal Price { get; set; }
        public virtual string PhotoUrl { get; set; }
        public virtual string Name { get; set; }
        public virtual string FirstName { get; set; }
        public virtual int ParticipantsCount { get; set; }
        public virtual List<Tag> TagList { get; set; }
    }
}
