using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audio_player
{
    public class Song
    {
        
        public int Duration;
        public string Title;
        public string Path;
        public string Lyrics;
        public string Genre;
        public bool? Like=null;
        public Artist Artist;
        public Playlist Playlist;

        //public List<Song> songs = new List<Song>();
        public bool? Set_Like()
        {

            //songs.Add(songs[2].Like);
            //songs.add Like= true;
            Like = true;
            return Like;
        }

        public bool? Set_DisLike()
        {
            Like = false;
            return Like;
        }
    }
}
