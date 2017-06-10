using Crud.Data.Models;
using IData.Interfaces.Command;
using System.Linq;
using System;
using IData.Interfaces.Query;
using Crud.Data.Mappings;
using Crud.DTO;

namespace Crud.Repository
{
    public class OutgoingCommandRepository: IOutgoingCommandRepository
    {
        private readonly CrudDBContext _context;
        private readonly IOutgoingQueryRepository _outgoingRepository;
        
        public OutgoingCommandRepository(CrudDBContext context,
            IOutgoingQueryRepository outgoingRepostiory)
        {
            _context = context;
            _outgoingRepository = outgoingRepostiory;
        }

        public void AddEditOutgoing(OutgoingDTO outgoingdto)
        {
            var outgoing = outgoingdto.Map();
            if (outgoing.Id > 0)
            {
                var current = _context.Set<Outgoing>().FirstOrDefault(x => x.Id == outgoing.Id);
                if (current != null)
                {
                    current.OutgoingLocalization = outgoing.OutgoingLocalization;
                    current.OutgoingTime = outgoing.OutgoingTime;
                    current.ParticipantsCount = outgoing.ParticipantsCount;
                    current.PhotoUrl = outgoing.PhotoUrl;
                    current.Price = outgoing.Price;
                    current.TagList = outgoing.TagList;
                    current.AgeGroupMax = outgoing.AgeGroupMax;
                    current.AgeGroupMin = outgoing.AgeGroupMin;
                    current.Title = outgoing.Title;
                    current.FirstName = outgoing.FirstName;
                    current.Name = outgoing.Name;
                    current.OutgoingDate = outgoing.OutgoingDate;
                    current.CreateDate = outgoing.CreateDate;
                }

            }
            else
            {
                _context.Set<Outgoing>().Add(outgoing);
            }
            _context.SaveChanges();

        }

        public void DeleteOutgoing(int id)
        {
            var current = _context.Set<Outgoing>().FirstOrDefault(x => x.Id == id);
            if (current != null)
            {
                _context.Set<Outgoing>().Remove(current);
                _context.SaveChanges();
            }
        }

        public void IncrementPeopleGoing(int outgoingId)
        {
            var outgoing = _outgoingRepository.GetOutgoingById(outgoingId);
            outgoing.ParticipantsCount++;
            AddEditOutgoing(outgoing);
        }
    }
}
