using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Audio_player
{

    public enum Genre
    {
        Witout_genre=0,
        Rock = 1,
        Pop,
        Indie_Rock,
        Folk,
        Soundtrack
    }


    public class Song
    {
        public int Duration;
        public string Title;
        public string Path;
        public string Lyrics;
        public  Genre Genre;
        public bool? Like=null;
        public Artist Artist;
        public Playlist Playlist;

       

        public bool? Set_Like()
        {
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
