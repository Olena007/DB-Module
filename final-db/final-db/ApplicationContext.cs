using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using final_db.DbModels;

namespace final_db
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Artist> Artists { get; set; }

        public DbSet<Song> Songs { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public DbSet<Performance> Performances { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Artist>().HasData(
                new Artist
                {
                    ArtistId = 1,
                    Name = "Adele",
                    DateOfBirth = DateTime.Parse("19-07-1988 00:00:00"),
                    Phone = "+3800991234576",
                    Email = "adele@gmail.com",
                    InstagramURL = "www.instagram.com/adele/",
                },

                 new Artist
                 {
                     ArtistId = 2,
                     Name = "Avicii",
                     DateOfBirth = DateTime.Parse("15-07-1988 00:00:00"),
                     Phone = "+3800991679976",
                     Email = "avicii@gmail.com",
                     InstagramURL = "www.instagram.com/avicii/",
                 },

                  new Artist
                  {
                      ArtistId = 3,
                      Name = "Chris Martin",
                      DateOfBirth = DateTime.Parse("08-12-1981 00:00:00"),
                      Phone = "+3800951234576",
                      Email = "coldplay@gmail.com",
                      InstagramURL = "www.instagram.com/coldplay/",
                  }
                );

            modelBuilder.Entity<Genre>().HasData(
                new Genre
                {
                    GenreId = 1,
                    Title = "pop"
                },

                new Genre
                {
                    GenreId = 2,
                    Title = "alternative"
                },

                new Genre
                {
                    GenreId = 3,
                    Title = "house"
                }
                );

            modelBuilder.Entity<Song>().HasData(
                new Song
                {
                    SongId = 1,
                    Title = "Rumpr has it",
                    Duration = DateTime.Parse("00:04:00"),
                    ReleasedDate = DateTime.Parse("05-09-2011 00:00:00"),
                    GenreId = 1,

                },

                new Song
                {
                    SongId = 2,
                    Title = "Love in the dark",
                    Duration = DateTime.Parse("00:05:13"),
                    ReleasedDate = DateTime.Parse("05-09-2015 00:00:00"),
                    GenreId = 1,

                },

                new Song
                {
                    SongId = 3,
                    Title = "Wake me up",
                    Duration = DateTime.Parse("00:04:13"),
                    ReleasedDate = DateTime.Parse("05-09-1960 00:00:00"),
                    GenreId = 3,

                }
                );

            modelBuilder.Entity<Performance>().HasData(
                new Performance
                {
                    PerformanceId = 1,
                    ArtistId = 1,
                    SongId = 1,
                    DateOfPerformance = DateTime.Parse("09-09-2020 00:00:00"),
                    LocationPlatform = "Instagram",
                },

                new Performance
                {
                    PerformanceId = 2,
                    ArtistId = 2,
                    SongId = 2,
                    DateOfPerformance = null,
                    LocationPlatform = null,
                },

                new Performance
                {
                    PerformanceId = 3,
                    ArtistId = 3,
                    SongId = 3,
                    DateOfPerformance = DateTime.Parse("09-09-2021 00:00:00"),
                    LocationPlatform = "Instagram",
                }
                );
        }
    }
}
