using System;

namespace BookShelvz.Domain
{
    public class Book
    {
        public BookType Type { get; set; }
        public DateTime? PublicationDate { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public string Name { get; set; }
        

        public enum BookType { 
            Book,
            ComicBook,
            ComicBookCollection,
            Magazine 
        }

    }
}
