using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    public class Artist
    {
        public int Id { get; set; }
        public string Nickname { get; set; }
        public Country Country { get; set; }
        public DateTime BirthDate { get; set; }
        public int CountryId { get; set; }
        public double OverallRating { get; set; }
        public int ProducerId { get; set; }
        public Producer Producer { get; set; }
        public ICollection<Album> Albums { get; set; } = new HashSet<Album>();
    }
}
