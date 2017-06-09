<<<<<<< HEAD
﻿using System;
=======
﻿using Crud.Data.Models;
using IData.Interfaces.Command;
using System;
>>>>>>> dcf4e080205b36ed6b17562fc2664c46ada88e66
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
using Crud.Data.Models;
using IData.Interfaces.Command;

namespace Crud.Repository
{
    public class OutgoingCommandRepository : IOutgoingCommandRepository
    {
        private CrudDBContext _context;
=======

namespace Crud.Repository
{
    public class OutgoingCommandRepository: IOutGoingCommandRepository
    {
        private readonly CrudDBContext _context;

>>>>>>> dcf4e080205b36ed6b17562fc2664c46ada88e66
        public OutgoingCommandRepository(CrudDBContext context)
        {
            _context = context;
        }
<<<<<<< HEAD
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
=======

        public void AddNewOutgoing()
        {
            
>>>>>>> dcf4e080205b36ed6b17562fc2664c46ada88e66
        }
    }
}
