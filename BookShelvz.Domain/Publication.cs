using System;

namespace BookShelvz.Domain
{
    public abstract class Publication
    {
        public int Id { get; set; }
        public PublicationType Type { get; set; }
        public DateTime? PublicationDate { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public Person? Author { get; set; }
        public Company Publisher { get; set; }
        public string Title { get; set; }
        public int? Pages { get; set; }

        public enum PublicationType { 
            Book,
            ComicBook,
            ComicBookCollection,
            Magazine 
        }
    }
}
