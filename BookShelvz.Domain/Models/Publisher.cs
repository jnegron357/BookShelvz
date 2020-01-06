using System.ComponentModel.DataAnnotations;

namespace BookShelvz.Domain.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}