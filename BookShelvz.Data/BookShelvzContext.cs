using Microsoft.EntityFrameworkCore;
using BookShelvz.Domain.Models;

namespace BookShelvz.Data
{
    public class BookShelvzContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Penciler> Pencilers { get; set; }
        public DbSet<Inker> Inkers { get; set; }
        public DbSet<Colorist> Colorists { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<ComicBook> ComicBooks { get; set; }

        public BookShelvzContext(DbContextOptions<BookShelvzContext> options):base(options)
        {  }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BookShelvzData;Trusted_Connection=True;MultipleActiveResultSets=True");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
