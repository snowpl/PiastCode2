using System;
﻿using Crud.Data.Models;
using IData.Interfaces.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crud.Data.Models;
using IData.Interfaces.Command;

namespace Crud.Repository
{
    public class OutgoingCommandRepository: IOutGoingCommandRepository
    {
        private readonly CrudDBContext _context;
        
        public OutgoingCommandRepository(CrudDBContext context)
        {
            _context = context;
        }

        public void AddEditOutgoing(Outgoing outgoing)
        {
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

    }
}
