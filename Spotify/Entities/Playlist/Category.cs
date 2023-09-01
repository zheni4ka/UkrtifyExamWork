using Spotify.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        [Required][MaxLength(50)][MinLength(3)] public string Name { get; set; }
        public ICollection<Playlist> Playlists { get; set; } = new HashSet<Playlist>();
    }
}
