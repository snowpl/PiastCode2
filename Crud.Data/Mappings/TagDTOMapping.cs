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
        public static TagDTO Map(Tag source)
        {
            return new TagDTO
            {
                BaseImageUrl = source.BaseImageUrl,
                Title = source.Title
            };
        }
        public static List<TagDTO> Map(List<Tag> source)
        {
            var targetsTag = new List<TagDTO>();
            foreach (var tag in source)
            {
                targetsTag.Add(new TagDTO
                {
                    BaseImageUrl = tag.BaseImageUrl,
                    Title = tag.Title
                }); 
            }
            return targetsTag;
        }
    }
}
