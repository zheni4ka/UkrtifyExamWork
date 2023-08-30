using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Genre() {Id = 4, Name = "Jazz"}
            });

            modelBuilder.Entity<Country>().HasData(new[]
            {
                new Country() {Id = 1, Name = "USA"},
                new Country() {Id = 2, Name = "Ukraine"},
                new Country() {Id = 3, Name = "Germany"},
                new Country() {Id = 4, Name = "UK"},
                new Country() {Id = 5, Name = "Poland"},
                new Country() {Id = 6, Name = "Japan"},
                new Country() {Id = 7, Name = "Sounth Korea"}
            });

            modelBuilder.Entity<Category>().HasData(new[]
            {
                new Category() {Id = 1, Name = "Chill"},
                new Category() {Id = 2, Name = "Vibe"},
                new Category() {Id = 3, Name = "Sport"},
                new Category() {Id = 4, Name = "Work"}
            });
        }
    }
}
