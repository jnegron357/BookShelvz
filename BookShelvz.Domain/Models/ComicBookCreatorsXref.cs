using System;
using System.Collections.Generic;
using System.Text;

namespace BookShelvz.Domain.Models
{
    public class ComicBookCreatorsXref
    {
        public int Id { get; set; }
        public int ComicBookId { get; set; }
        public int PencilerId { get; set; }
        public int InkerId { get; set; }
        public int ColoristId { get; set; }
        public int WriterId { get; set; }

        public ComicBook ComicBook { get; set; }
        public Penciler Penciler { get; set; }
        public Inker Inker { get; set; }
        public Colorist Colorist { get; set; }
        public Writer Writer { get; set; }
    }
}
