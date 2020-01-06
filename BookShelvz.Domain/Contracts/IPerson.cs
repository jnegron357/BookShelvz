﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BookShelvz.Domain.Contracts
{
    public interface IPerson
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Alias { get; set; }
        public string Email { get; set; }
    }
}
