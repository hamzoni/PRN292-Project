using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectCSharp.Entities
{
    [Serializable]
    class Media
    {
        public int id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public bool type { get; set; }
        public Playlist playlist { get; set; }
    }
}
