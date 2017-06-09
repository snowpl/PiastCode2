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
    }
}
