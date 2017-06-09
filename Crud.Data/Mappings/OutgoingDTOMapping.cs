using Crud.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crud.DTO;

namespace Crud.Data.Mappings
{
    public static class OutgoingDTOMapping
    {
        public static OutgoingDTO Map(this Outgoing source)
        {
            var target = new OutgoingDTO();
            
            target.CreateDate = DateTime.Now;
            target.Id = source.Id;
            target.Name = source.Name;
            target.AgeGroupMax = source.AgeGroupMax;
            target.AgeGroupMin = source.AgeGroupMin;
            target.FirstName = source.FirstName;
            target.OutgoingDate = source.OutgoingDate;
            target.Title = source.Title;
            target.ParticipantsCount = source.ParticipantsCount;
            target.OutgoingLocalization = source.OutgoingLocalization;
            target.OutgoingTime = source.OutgoingTime;
            target.PhotoUrl = source.PhotoUrl;
            target.Price = source.Price;
            target.TagList = source.TagList;


            return target;
        }
    }
}
