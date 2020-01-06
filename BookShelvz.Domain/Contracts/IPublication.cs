using BookShelvz.Domain.Models;
using System;

namespace BookShelvz.Domain.Contracts
{
    public interface IPublication
    {
        public int Id { get; set; }
        public int PublisherId { get; set; }
        public DateTime? PublicationDate { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public string Title { get; set; }
        public int? Pages { get; set; }

        public Publisher Publisher { get; set; }
    }
}
