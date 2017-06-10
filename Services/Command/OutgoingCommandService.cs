using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crud.DTO;
using Crud.IServices.Command;
using IData.Interfaces.Command;
using IData.Interfaces.Query;

namespace Services.Command
{
    public class OutgoingCommandService : IOutgoingCommandService
    {
        private readonly IOutgoingCommandRepository _outgoingCommandRepository;
        private readonly IOutgoingQueryRepository _outgoingQueryRepository;

        public OutgoingCommandService(IOutgoingCommandRepository outgoingCommandRepository,
            IOutgoingQueryRepository outgoingQueryRepository)
        {
            _outgoingCommandRepository = outgoingCommandRepository;
            _outgoingQueryRepository = outgoingQueryRepository;
        }

        public bool JoinOutgoing(int outgoingId)
        {
            var outgoing = _outgoingQueryRepository.GetOutgoingById(outgoingId);
            if(outgoing.ParticipantsCount++ < outgoing.MaxPeople)
            {
                _outgoingCommandRepository.IncrementPeopleGoing(outgoingId);
                return true;
            }
            return false;
        }

        void IOutgoingCommandService.AddEditOutgoing(OutgoingDTO dto)
        {
            _outgoingCommandRepository.AddEditOutgoing(dto);
        }
    }
}
