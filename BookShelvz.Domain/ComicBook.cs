using System;
using System.Collections.Generic;

namespace BookShelvz.Domain
{
    public class ComicBook
    {
        public int Volume { get; set; }
        public int Issue { get; set; }
        public string Series { get; set; }
        public string Genre { get; set; }
        public string SubGenre { get; set; }
        public bool OneShot { get; set; }
        public List<Penciler> Pencilers { get; set; }
        public List<Writer> Writers { get; set; }
        public List<Inker> Inkers { get; set; }
        public List<Colorist> Colorists { get; set; }

    }
}
