using Spotify.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    public class Track : IEntity
    {
        public int Id { get; set; }
        [Required] [MaxLength(50)] [MinLength(3)] public string Name { get; set; }
        [Required] public TimeSpan Duration { get; set; }
        [Required] public double Rating { get; set; }
        public Album Album { get; set; }
        public int AlbumId { get; set; }
        [Required] public int CountOfListening { get; set; }
        public ICollection<Playlist> Playlists { get; set; } = new HashSet<Playlist>();
    }
}
