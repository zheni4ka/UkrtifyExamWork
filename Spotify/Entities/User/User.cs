using Spotify.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    public class User : IEntity
    {
        public int Id { get; set; }
        [Required] [MaxLength(100)] public string Nickname { get; set; }
        [Required] [MinLength(18)] public string Email { get; set; }
        [Required] [MaxLength(100)] public string Password { get; set; }
        public ICollection<Playlist> Playlists { get; set; } = new HashSet<Playlist>();
    }
}
