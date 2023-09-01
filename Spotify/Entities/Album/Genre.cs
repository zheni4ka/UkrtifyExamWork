using Spotify.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    public class Genre : IEntity
    {
        public int Id { get; set; }
        [Required] [MaxLength(50)] [MinLength(3)] public string Name { get; set; }
        public ICollection<Album> Albums { get; set; } = new HashSet<Album>();
    }
}
