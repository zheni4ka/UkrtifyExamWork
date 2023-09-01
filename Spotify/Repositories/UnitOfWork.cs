using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify.Repositories
{
    public interface IUoW
    {
        Repository<Album> AlbumRepo { get; }
        Repository<Genre> GenreRepo { get; }
        Repository<Artist> ArtistRepo { get; }
        Repository<Country> CountryRepo { get; }
        Repository<Producer> ProducerRepo { get; }
        Repository<Category> CategoryRepo { get; }
        Repository<Playlist> PlaylistRepo { get; }
        Repository<Track> TrackRepo { get; }
        Repository<User> UserRepo { get; }

        void Save();
    }
    public class UnitOfWork : IUoW, IDisposable
    {
        private static UkrtifyDbContext context = new UkrtifyDbContext();
        Repository<Album> albumRepo;
        Repository<Genre> genreRepo;
        Repository<Artist> artistRepo;
        Repository<Country> countryRepo;
        Repository<Producer> producerRepo;
        Repository<Category> categoryRepo;
        Repository<Playlist> playlistRepo;
        Repository<Track> trackRepo;
        Repository<User> userRepo; 

        public Repository<Album> AlbumRepo
        {
            get
            {
                if(this.albumRepo == null)
                {
                    this.albumRepo = new Repository<Album>(context);
                }
                return albumRepo;
            }
        } 

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
