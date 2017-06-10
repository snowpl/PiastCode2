using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.DTO
{
    public class OutgoingDTO : IModel
    {
        #region IEntity
        public virtual int Id { get; set; }

        public virtual DateTime? CreateDate { get; set; }
        #endregion
        
        public LocalizationDTO OutgoingLocalization { get; set; }
        public DateTime OutgoingDate { get; set; }
        public TimeSpan OutgoingTime { get; set; }
        public int AgeGroupMax { get; set; }
        public int AgeGroupMin { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public string PhotoUrl { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public int ParticipantsCount { get; set; }
        public int MaxPeople { get; set; }
        public int MinPeople { get; set; }
        public List<TagDTO> TagList { get; set; }
    }
}
