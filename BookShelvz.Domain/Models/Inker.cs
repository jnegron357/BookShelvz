using BookShelvz.Domain.Contracts;
using System.ComponentModel.DataAnnotations;

namespace BookShelvz.Domain.Models
{
    public class Inker : IPerson
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Alias { get; set; }
        public string Email { get; set; }
    }
}
