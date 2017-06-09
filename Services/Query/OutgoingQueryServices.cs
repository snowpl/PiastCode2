using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crud.Data.Models;
using Crud.IServices;

namespace Services.Query
{
    public class OutgoingQueryServices : IOutgoingQueryServices
    {
        private readonly IOutgoingQueryServices _outgoingQueryServices;
        public OutgoingQueryServices(IOutgoingQueryServices outgoingQueryServices)
        {
            _outgoingQueryServices = outgoingQueryServices;
        }

        public OutgoingDTO Nazwa()
        {
            
        }
        
    }
}
