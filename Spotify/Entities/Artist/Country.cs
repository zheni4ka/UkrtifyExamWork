using Spotify.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    public class Country : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Artist> Artists { get; set; } = new HashSet<Artist>();
        public ICollection<Producer> Producers { get; set; } = new HashSet<Producer>();
    }
}
