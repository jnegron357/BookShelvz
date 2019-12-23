using Microsoft.EntityFrameworkCore;
using BookShelvz.Domain;
using System.Configuration;

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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=BookShelvzData;Trusted_Connection=True;MultipleActiveResultSets=True");
            //TODO: Figure out how to use app settings 
            //optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["default"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<SamuraiBattle>()
            //    .HasKey(s => new { s.SamuraiId, s.BattleId });
            modelBuilder.Entity<Book>().HasBaseType<Publication>();
            modelBuilder.Entity<ComicBook>().HasBaseType<Publication>();
            modelBuilder.Entity<Penciler>().HasBaseType<Person>();
            modelBuilder.Entity<Inker>().HasBaseType<Person>();
            modelBuilder.Entity<Colorist>().HasBaseType<Person>();
            modelBuilder.Entity<Writer>().HasBaseType<Person>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
