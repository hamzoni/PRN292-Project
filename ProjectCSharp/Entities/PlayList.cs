using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectCSharp.Entities
{
    class Playlist
    {
        public int id { get; set; }
        public string name { get; set; }
        public Account user { get; set; }
        public int count { get; set; }
        public List<Media> medias { get; set; }
    }
}
