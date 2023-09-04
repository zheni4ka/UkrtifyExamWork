using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    public class UkrtifyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            string conn = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=UkrtifyDb;Integrated Security=True;Connect Timeout=30;";
            optionsBuilder.UseSqlServer(conn);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new AlbumCfg());
            modelBuilder.ApplyConfiguration(new ProducerCfg());
            modelBuilder.ApplyConfiguration(new PlaylistCfg());
            modelBuilder.ApplyConfiguration(new ArtistCfg());

            modelBuilder.SeedData();
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Album> Albums { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Artist> Artists { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
