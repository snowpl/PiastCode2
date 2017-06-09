using Crud.Data.Models;
using IData.Interfaces.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.Repository
{
    public class OutgoingCommandRepository: IOutGoingCommandRepository
    {
        private readonly CrudDBContext _context;

        public OutgoingCommandRepository(CrudDBContext context)
        {
            _context = context;
        }

        public void AddNewOutgoing()
        {
            
        }
    }
}
