using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    public class Album
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateOnly ReleaseDate { get; set; }
        public Genre Genre { get; set; }
        public int GenreId { get; set; }
        public double Rating => Tracks.Average(x => x.Rating);
        public int CountOfListening => Tracks.Sum(x => x.CountOfListening);
        public Artist Artist { get; set; }
        public int ArtistId { get; set; }   
        public ICollection<Track> Tracks { get; set; } = new HashSet<Track>();
    }
}
