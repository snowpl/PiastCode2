using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crud.Data.Models;

namespace Crud.Data.Configuration
{
    public class OutgoingConfiguration:EntityConfigurationBase<Outgoing>
    {
        public OutgoingConfiguration() : base("Outgoing")
        {
            
        }
    }
}
