using Crud.Data.Models;
using Crud.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IData.Interfaces.Command
{
    public interface IOutgoingCommandRepository
    {
        void AddEditOutgoing(OutgoingDTO outgoing);
        void DeleteOutgoing(int id);
        void IncrementPeopleGoing(int outgoingId);
    }
}
