using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crud.Data.Models;

namespace Crud.Data.Configuration
{
    public class OutgoingConfiguration : EntityConfigurationBase<Outgoing>
    {
        public OutgoingConfiguration() : base("Outgoing")
        {
            Property(e => e.Name).HasMaxLength(255);
            Property(e => e.AgeGroupMax);
            Property(e => e.AgeGroupMin);
            Property(e => e.ParticipantsCount);
            Property(e => e.PhotoUrl);
            Property(e => e.Price);
            Property(e => e.Title);
            Property(e => e.OutgoingDate);
            Property(e => e.OutgoingTime);
        }
    }
}
