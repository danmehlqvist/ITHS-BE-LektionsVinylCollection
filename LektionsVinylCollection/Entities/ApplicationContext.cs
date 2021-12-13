using Microsoft.EntityFrameworkCore;
using System;

namespace LektionsVinylCollection.Entities
{
    // dotnet ef migrations add XXXXXXX
    // dotnet ef database update​


    public class ApplicationContext : DbContext
    {
        public DbSet<Vinyl> Vinyls { get; set; }
        public DbSet<Artist> Artists { get; set; }

        private string _connectionString = "server=localhost; database=vinylCollection; user=dan; password=dan1234.";

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseMySql(
                _connectionString,
                ServerVersion.AutoDetect(_connectionString));
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Artist>().HasData(
                new Artist
                {
                    Id = 1,
                    Name = "Artist 1",
                    Created = DateTime.Now,
                    FavoriteCar = "Car 1",
                },
                new Artist
                {
                    Id = 2,
                    Name = "Artist 2",
                    Created = DateTime.Now,
                    FavoriteCar = "Car 2",
                },
                new Artist
                {
                    Id = 3,
                    Name = "Artist 3",
                    Created = DateTime.Now,
                    FavoriteCar = "Car 3",
                });

            builder.Entity<Vinyl>().HasData(
                new Vinyl
                {
                    Id=1,
                    Created = DateTime.Now,
                    Title = "Title 1",
                    ArtistID=1
                },
                new Vinyl
                {
                    Id = 2,
                    Created = DateTime.Now,
                    Title = "Title 2",
                    ArtistID = 2
                },
                new Vinyl
                {
                    Id = 3,
                    Created = DateTime.Now,
                    Title = "Title 3",
                    ArtistID = 2
                },
                new Vinyl
                {
                    Id = 4,
                    Created = DateTime.Now,
                    Title = "Title 4",
                    ArtistID = 3
                },
                new Vinyl
                {
                    Id = 5,
                    Created = DateTime.Now,
                    Title = "Title 5",
                    ArtistID = 3
                },
                new Vinyl
                {
                    Id = 6,
                    Created = DateTime.Now,
                    Title = "Title 6",
                    ArtistID = 3
                });
        }

    }
}
