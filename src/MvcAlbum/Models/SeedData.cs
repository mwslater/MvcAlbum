using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcAlbum.Data;
using System;
using System.Linq;

namespace MvcAlbum.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ApplicationDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
            {
                // Look for any Albums.
                if (context.Album.Any())
                {
                    return;   // DB has been seeded
                }

                context.Album.AddRange(
                     new Album
                     {
                         Title = "The Boy is MIne",
                         ReleaseDate = DateTime.Parse("7-14-1998"),
                         Genre = "R&B",
                         Artist = "Monica",
                         Rating = ""
                     },

                     new Album
                     {
                         Title = "CrazySexyCool",
                         ReleaseDate = DateTime.Parse("11-15-1994"),
                         Genre = "R&B",
                         Artist = "TLC",
                         Rating = ""
                     },

                     new Album
                     {
                         Title = "Mr. Smith",
                         ReleaseDate = DateTime.Parse("11-21-1995"),
                         Genre = "Rap",
                         Artist = "LL Cool J",
                         Rating = "Parental Advisory"
                     },

                   new Album
                   {
                       Title = "Never SAY Never",
                       ReleaseDate = DateTime.Parse("6-9-1998"),
                       Genre = "R&B",
                       Artist = "Brandy",
                       Rating = ""
                   }
                );
                context.SaveChanges();
            }
        }
    }
}
