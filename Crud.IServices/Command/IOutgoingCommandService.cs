using Crud.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud.IServices.Command
{
    public interface IOutgoingCommandService
    {
        void AddEditOutgoing(OutgoingDTO dto);
        bool JoinOutgoing(int outgoingId);
    }
}
