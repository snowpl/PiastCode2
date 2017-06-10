using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crud.Data.Models;
using Crud.DTO;

namespace Crud.Data.Mappings
{
   public static class LocalizationDTOMapping
    {
        public static LocalizationDTO Map (Localization source)
        {
            return new LocalizationDTO
            {
                Latitude = source.Latitude,
                longitude = source.longitude
            };
        }

        public static Localization Map(LocalizationDTO source)
        {
            return new Localization
            {
                Latitude = source.Latitude,
                longitude = source.longitude
            };
        }
    }
}
