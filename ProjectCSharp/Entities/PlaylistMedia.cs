using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectCSharp.Entities
{
    [Serializable]
    class PlaylistMedia
    {
        public Media media { get; set; }
        public Playlist playlist { get; set; }

        public PlaylistMedia()
        {
            this.media = new Media();
            this.playlist = new Playlist();
        }
    }
}
