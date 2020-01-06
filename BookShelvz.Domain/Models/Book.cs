using BookShelvz.Domain.Contracts;
using System;

namespace BookShelvz.Domain.Models
{
    public class Book : IPublication
    {
        public int Id { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
        public DateTime? PublicationDate { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public string Title { get; set; }
        public int? Pages { get; set; }
        public Person Author { get; set; }
        public Publisher Publisher { get; set; }
    }
}
