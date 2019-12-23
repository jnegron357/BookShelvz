using System;
using System.Collections.Generic;

namespace BookShelvz.Domain
{
    public class ComicBook: Publication
    {
        public int Volume { get; set; }
        public int Issue { get; set; }
        public string Series { get; set; }
        public string Genre { get; set; }
        public string SubGenre { get; set; }
        public bool OneShot { get; set; }
        public List<Person> Pencilers { get; set; }
        public List<Person> Writers { get; set; }
        public List<Person> Inkers { get; set; }
        public List<Person> Colorists { get; set; }
    }
}
