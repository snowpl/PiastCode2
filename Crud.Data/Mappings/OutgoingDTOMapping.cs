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
            target.OutgoingTime = source.OutgoingTime;
            target.PhotoUrl = source.PhotoUrl;
            target.Price = source.Price;
            target.MinPeople = source.MinPeople;
            target.MaxPeople = source.MaxPeople;
            target.OutgoingLocalization = new LocalizationDTO();
            target.OutgoingLocalization.Latitude = source.OutgoingLocalization.Latitude;
            target.OutgoingLocalization.longitude = source.OutgoingLocalization.longitude;

            return target;
        }

        public static Outgoing Map(this OutgoingDTO source)
        {
            var target = new Outgoing();

            target.CreateDate = DateTime.Now;
            target.Id = source.Id;
            target.Name = source.Name;
            target.AgeGroupMax = source.AgeGroupMax;
            target.AgeGroupMin = source.AgeGroupMin;
            target.FirstName = source.FirstName;
            target.OutgoingDate = source.OutgoingDate;
            target.Title = source.Title;
            target.ParticipantsCount = source.ParticipantsCount;
            target.OutgoingTime = source.OutgoingTime;
            target.PhotoUrl = source.PhotoUrl;
            target.Price = source.Price;
            target.MinPeople = source.MinPeople;
            target.MaxPeople = source.MaxPeople;
            target.OutgoingLocalization = new Localization();
            target.OutgoingLocalization.Latitude = source.OutgoingLocalization.Latitude;
            target.OutgoingLocalization.longitude = source.OutgoingLocalization.longitude;

            return target;
        }
        //public static OutgoingDTO MapToOutgoingDTO(Outgoing source)
        //{
        //    var target = new OutgoingDTO();

        //    return Map(source, target);
        //}

        //public static Outgoing MapToOutgoing(OutgoingDTO source)
        //{
        //    var target = new Outgoing();

        //    return Map(source, target);
        //}
    }
}
