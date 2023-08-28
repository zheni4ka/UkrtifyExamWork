﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spotify
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Playlist> Playlists { get; set; } = new HashSet<Playlist>();
    }
}
