using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    public static class DbExtension

    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Genre>().HasData(new[]
            {
                new Genre() {Id = 1, Name = "Hip-hop"},
                new Genre() {Id = 2, Name = "Rock"},
                new Genre() {Id = 3, Name = "Pop"},
                new Genre() {Id = 4, Name = "Jazz"},
                new Genre() {Id = 5, Name = "R&B"},
                new Genre() {Id = 6, Name = "Country"},
                new Genre() {Id = 7, Name = "Reggae"},
                new Genre() {Id = 8, Name = "Metal"},
                new Genre() {Id = 9, Name = "Blues"},
                new Genre() {Id = 10, Name = "Folk"},
                new Genre() {Id = 11, Name = "Electronic"},
                new Genre() {Id = 12, Name = "Soul"},
                new Genre() {Id = 13, Name = "Funk"},
                new Genre() {Id = 14, Name = "Punk"},
                new Genre() {Id = 15, Name = "Classical"}
            });

            modelBuilder.Entity<Country>().HasData(new[]
            {
                new Country() {Id = 1, Name = "USA"},
                new Country() {Id = 2, Name = "Ukraine"},
                new Country() {Id = 3, Name = "Germany"},
                new Country() {Id = 4, Name = "UK"},
                new Country() {Id = 5, Name = "Poland"},
                new Country() {Id = 6, Name = "Japan"},
                new Country() {Id = 7, Name = "South Korea"},
                new Country() {Id = 8, Name = "China"},
                new Country() {Id = 9, Name = "India"},
                new Country() {Id = 10, Name = "Russia"},
                new Country() {Id = 11, Name = "France"},
                new Country() {Id = 12, Name = "Italy"},
                new Country() {Id = 13, Name = "Spain"},
                new Country() {Id = 14, Name = "Canada"},
                new Country() {Id = 15, Name = "Brazil"},
                new Country() {Id = 16, Name = "Mexico"},
                new Country() {Id = 17, Name = "Australia"},
                new Country() {Id = 18, Name = "New Zealand"},
                new Country() {Id = 19, Name = "Egypt"},
                new Country() {Id = 20, Name = "South Africa"},
                new Country() {Id = 21, Name = "Nigeria"},
                new Country() {Id = 22, Name = "Kenya"},
                new Country() {Id = 23, Name = "Turkey"},
                new Country() {Id = 24, Name = "Iran"},
                new Country() {Id = 25, Name = "Iraq"},
                new Country() {Id = 26, Name = "Saudi Arabia"},
                new Country() {Id = 27, Name = "Israel"},
                new Country() {Id = 28, Name = "Sweden"},
                new Country() {Id = 29, Name = "Norway"},
                new Country() {Id = 30, Name = "Finland"}
            });

            modelBuilder.Entity<Category>().HasData(new[]
            {
                new Category() {Id = 1, Name = "Relaxing"},
                new Category() {Id = 2, Name = "Energetic"},
                new Category() {Id = 3, Name = "Motivational"},
                new Category() {Id = 4, Name = "Productive"},
                new Category() {Id = 5, Name = "Romantic"},
                new Category() {Id = 6, Name = "Sad"},
                new Category() {Id = 7, Name = "Happy"},
                new Category() {Id = 8, Name = "Party"},
                new Category() {Id = 9, Name = "Meditative"},
                new Category() {Id = 10, Name = "Classical"}
            });

            modelBuilder.Entity<Producer>().HasData(new[] {
                new Producer() {Id = 1, Name = "Dr. Dre", CountryId = 1}, //USA
                new Producer() {Id = 2, Name = "Rick Rubin", CountryId = 1}, //USA
                new Producer() {Id = 3, Name = "Max Martin", CountryId = 3}, //Germany
                new Producer() {Id = 4, Name = "Quincy Jones", CountryId = 1}, //USA
                new Producer() {Id = 5, Name = "George Martin", CountryId = 4}, //UK
                new Producer() {Id = 6, Name = "Timbaland", CountryId = 1}, //USA
                new Producer() {Id = 7, Name = "The Alchemist", CountryId = 1}, //USA
                new Producer() {Id = 8, Name = "DJ Premier", CountryId = 1}, //USA
                new Producer() {Id = 9, Name = "Pharrell Williams", CountryId = 1}, //USA
                new Producer() {Id = 10, Name = "Kanye West", CountryId = 1}, //USA
                new Producer() {Id = 11, Name = "Travis Scott", CountryId = 1} //USA
            });

            modelBuilder.Entity<Artist>().HasData(new[]
            {
                new Artist() {Id = 1, Nickname = "Eminem", ProducerId = 1, BirthDate = new DateTime(1972, 10, 17), OverallRating = 10, CountryId = 1},
                new Artist() {Id = 2, Nickname = "Beyoncé", ProducerId = 9, BirthDate = new DateTime(1981, 9, 4), OverallRating = 9, CountryId = 1},
                new Artist() {Id = 3, Nickname = "Taylor Swift", ProducerId = 3, BirthDate = new DateTime(1989, 12, 13), OverallRating = 8, CountryId = 1},
                new Artist() {Id = 4, Nickname = "Michael Jackson", ProducerId = 4, BirthDate = new DateTime(1958, 8, 29), OverallRating = 10, CountryId = 1},
                new Artist() {Id = 5, Nickname = "The Beatles", ProducerId = 5, BirthDate = new DateTime(1960, 1, 1), OverallRating = 10, CountryId = 4},
                new Artist() {Id = 6, Nickname = "Justin Timberlake", ProducerId = 6, BirthDate = new DateTime(1981, 1, 31), OverallRating = 8, CountryId = 1},
                new Artist() {Id = 7, Nickname = "Action Bronson", ProducerId = 7, BirthDate = new DateTime(1983, 12, 2), OverallRating = 7, CountryId = 1},
                new Artist() {Id = 8, Nickname = "Nas", ProducerId = 8, BirthDate = new DateTime(1973, 9, 14), OverallRating = 9, CountryId = 1},
            });

            modelBuilder.Entity<Album>().HasData(new[] 
            { new Album() { Id = 1, ArtistId = 1, Description = "The Marshall Mathers LP is the third studio album by American rapper Eminem, released on May 23, 2000, by Aftermath Entertainment and Interscope Records.", Name = "The Marshall Mathers LP", GenreId = 1, ReleaseDate = new DateTime(2000, 5, 23), Rating = 9, CountOfListening = 1000000 }, 
              new Album() { Id = 2, ArtistId = 2, Description = "Lemonade is the sixth solo studio album by American singer Beyoncé.It was released on April 23, 2016 by Parkwood Entertainment and Columbia Records.", Name = "Lemonade", GenreId = 5, ReleaseDate = new DateTime(2016, 4, 23), Rating = 8, CountOfListening = 800000 }, 
              new Album() { Id = 3, ArtistId = 3, Description = "1989 is the fifth studio album by American singer - songwriter Taylor Swift.It was released on October 27, 2014, through Big Machine Records.", Name = "1989", GenreId = 3, ReleaseDate = new DateTime(2014, 10, 27), Rating = 7, CountOfListening = 700000 }, 
              new Album() { Id = 4, ArtistId = 4, Description = "Thriller is the sixth studio album by American singer Michael Jackson.It was released on November 30, 1982 by Epic Records.", Name = "Thriller", GenreId = 3, ReleaseDate = new DateTime(1982, 11, 30), Rating = 10, CountOfListening = 1500000 }, 
              new Album() { Id = 5, ArtistId = 5, Description = "Abbey Road is the eleventh studio album by the English rock band the Beatles.It was released on September 26, 1969 by Apple Records.", Name = "Abbey Road", GenreId = 2, ReleaseDate = new DateTime(1969, 9, 26), Rating = 9, CountOfListening = 900000 } 
            });


            modelBuilder.Entity<User>().HasData(new[]
            {
                new User() {Id = 1, Nickname = "Zhenya", Email = "zhenya24@gmail.com", Password = "998vcf25A" },
                new User() {Id = 2, Nickname = "Viktor", Email = "viktor1433@gmail.com", Password = "EEag435" }
            });
        }
    }
}
