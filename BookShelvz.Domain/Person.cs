﻿namespace BookShelvz.Domain
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string Alias { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }
}
