using Spotify.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    public class Playlist : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public int UserId { get; set; }
        public ICollection<User> Users { get; set; } = new HashSet<User>();
        public ICollection<Track> Tracks { get; set; } = new HashSet<Track>();
    }
}
