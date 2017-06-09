using System;

namespace Crud.Data.Models
{
    public interface IEntity
    {
        int Id { get; set; }

        DateTime? CreateDate { get; set; }
    }
}
