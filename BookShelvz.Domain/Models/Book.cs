using System;
using System.Collections.Generic;
using System.Text;

namespace BookShelvz.Domain.Models
{
    public class Book : IPublication
    {
        public int Id { get; set; }
        public DateTime? PublicationDate { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public Person Author { get; set; }
        public Publisher Publisher { get; set; }
        public string Title { get; set; }
        public int? Pages { get; set; }
    }
}
