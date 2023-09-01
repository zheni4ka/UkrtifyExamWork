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

        public Repository<Genre> GenreRepo
        {
            get
            {
                if (this.genreRepo == null)
                {
                    this.genreRepo = new Repository<Genre>(context);
                }
                return genreRepo;
            }
        }

        public Repository<Artist> ArtistRepo
        {
            get
            {
                if (this.artistRepo == null)
                {
                    this.artistRepo = new Repository<Artist>(context);
                }
                return artistRepo;
            }
        }

        public Repository<Country> CountryRepo
        {
            get
            {
                if (this.countryRepo == null)
                {
                    this.countryRepo = new Repository<Country>(context);
                }
                return countryRepo;
            }
        }

        public Repository<Producer> ProducerRepo
        {
            get
            {
                if (this.producerRepo == null)
                {
                    this.producerRepo = new Repository<Producer>(context);
                }
                return producerRepo;
            }
        }

        public Repository<Category> CategoryRepo
        {
            get
            {
                if (this.categoryRepo == null)
                {
                    this.categoryRepo = new Repository<Category>(context);
                }
                return categoryRepo;
            }
        }

        public Repository<Playlist> PlaylistRepo
        {
            get
            {
                if (this.playlistRepo == null)
                {
                    this.playlistRepo = new Repository<Playlist>(context);
                }
                return playlistRepo;
            }
        }

        public Repository<Track> TrackRepo
        {
            get
            {
                if (this.trackRepo == null)
                {
                    this.trackRepo = new Repository<Track>(context);
                }
                return trackRepo;
            }
        }

        public Repository<User> UserRepo
        {
            get
            {
                if (this.userRepo == null)
                {
                    this.userRepo = new Repository<User>(context);
                }
                return userRepo;
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
