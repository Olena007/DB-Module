using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using final_db.;


namespace final_db
{
    public sealed class Program
    {
        internal static void Main(string[] args)
        {
            using (ApplicationContext context = new ApplicationContextFactory().CreateDbContext(Array.Empty<string>()))
            {
                var first = from song in context.Songs
                            join artist in context.Performances on song.SongId equals artist.SongId
                            join name in context.Artists on artist.ArtistId equals name.ArtistId
                            join g in context.Genres on song.GenreId equals g.GenreId
                            select new
                            {
                                name = song.Title,
                                artistname = name.Name,
                                genre = g.Title
                            };

                var theYoungest = context.Artists.Select(d => (DateTime.Now - d.DateOfBirth).TotalDays).Min();
                var songs = context.Songs.Select(s => (DateTime.Now - s.ReleasedDate).TotalDays).ToList(); 
                 

                foreach (var song in songs)
                {
                    if (song > theYoungest)
                    {
                        var n = from na in context.Songs
                                where (DateTime.Now - na.ReleasedDate).TotalDays == song
                                select na.Title;

                        Console.WriteLine(n);
                    }
                }
            }

            Console.WriteLine("done");
        }
    }
}
