using System.ComponentModel.DataAnnotations;

namespace Crud.Models
{
    public class CustomerViewModel
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Surname { get; set; }

        public int TelephoneNumber { get; set; }

        public string Address { get; set; }
    }
}