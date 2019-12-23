﻿using System;

namespace BookShelvz.Domain
{
    public interface IPublication
    {
        public int Id { get; set; }
        public DateTime? PublicationDate { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public Publisher Publisher { get; set; }
        public string Title { get; set; }
        public int? Pages { get; set; }
    }
}
