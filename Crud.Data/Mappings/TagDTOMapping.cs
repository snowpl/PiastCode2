using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crud.Data.Models;
using Crud.DTO;

namespace Crud.Data.Mappings
{
    public static class TagDTOMapping
    {
        public static TagDTO Map(this Tag source)
        {
            return new TagDTO
            {
                BaseImageUrl = source.BaseImageUrl,
                Title = source.Title
            };
        }
    }
}
