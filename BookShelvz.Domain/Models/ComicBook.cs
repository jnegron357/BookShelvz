using BookShelvz.Domain.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookShelvz.Domain.Models
{
    public class ComicBook : IPublication
    {
        public int Id { get; set; }
        [ForeignKey("Publisher")]
        public int PublisherId { get; set; }
        [Required]
        public DateTime? PublicationDate { get; set; }
        public DateTime? PurchaseDate { get; set; }
        [Required]
        public string Title { get; set; }
        public int? Pages { get; set; }
        
        public Publisher Publisher { get; set; }
        public ICollection<ComicBookCreatorsXref> Creators { get; set; }
    }
}
