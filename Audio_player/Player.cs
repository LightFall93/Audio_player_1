using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audio_player
{
    public class Player
    {

        private int volume;
        public int step;
        private bool playing;
        public   bool Locked = false;
        public const int maxVolume = 300;
        public const int minVolume = 300;
        //public  Song[] Songs;

        public int Duration;
        public string Genre;
        public string Lyrics; 
        public string Path;

        public List<Song> songs = new List<Song>();

        public string Title;
        

        bool Playing
        {
            get { return playing; }
        }

          public int Volume
         {
             get { return volume; }
             set
             {
                 if (value >300)
                 {
                    volume = 300;
                 }
                 else if(value <0)
                 {
                     volume = 1;

                 }

                 else
                 {
                     volume = value;
                 }
             }
         }

          

        public void GetInfo()
        {
            Console.WriteLine(" " + maxVolume);
        }


        public void VolumeUp()
        {
            volume += 50;
            Console.WriteLine("volume is Up " + volume);
        }

        public void VolumeDown()
        {
            volume -= 50;
            Console.WriteLine("volume is down " + volume);
        }

        public  void VolumeChange()
        {
            step = int.Parse(Console.ReadLine());
            volume += step;
            Console.WriteLine("volume changed to " + volume);

        }

        public  void Lock()
        {
            Locked = true;
            Console.WriteLine("player locked, Locked= " + Locked);
        }

        public  void Unlock()
        {
            Locked = false;
            Console.WriteLine("player unlocked, Locked= " + Locked);
        }

        public  bool  Stop()
        {
            if (Locked == false)
            {
                playing = false;

            }
            Console.WriteLine("player stopped ");
            return Playing ;
            
        }

        public bool Start()
        {
            if (Locked == false)
            {
                playing = true;

            }
            Console.WriteLine("player start playing ");

            return playing;
        }


        public List<Song> AddSongs()
        {
            songs.Add(new Song { Title = "1 eye of a tiger", Duration = 500, Genre = "rock", Lyrics = "lalalalalaalalalala" });
            songs.Add(new Song { Title = "2 smooth criminal", Duration = 500, Genre = "pop", Lyrics = "lalalalalaalalalala" });
            songs.Add(new Song { Title = "3 Kickapoo", Duration = 260, Genre = "rock", Lyrics = "lalalalalaalalalala" });
            songs.Add(new Song { Title = "4 Гладкие Криминал", Duration = 232, Genre = "k-pop", Lyrics = "Ты в порядке Саня?" });
            songs.Add(new Song { Title = "5 MACHINE", Duration = 522, Genre = "??", Lyrics = "...." });
            songs.Add(new Song { Title = "6 Cancion del mariachi ", Duration = 500, Genre = "ohno", Lyrics = "lala2" });
            songs.Add(new Song { Title = "7 San Francisco", Duration = 500, Genre = "pop4", Lyrics = "lala3" });
            songs.Add(new Song { Title = "8 Have You Ever Seen The Rain", Duration = 500, Genre = "pop5", Lyrics = "lalads3" });
            songs.Add(new Song { Title = "9 Ghost Riders In The Sky", Duration = 500, Genre = "pop6", Lyrics = "lala23" });
            songs.Add(new Song { Title = "10 the end", Duration = 500, Genre = "pop7", Lyrics = " yey" });

            foreach (Song p in songs)
            {
                Console.WriteLine(p.Title + " " + p.Duration + " " + p.Genre + " " + p.Lyrics);
            }

            return songs;
        }

        public void  Play(bool loop)// Heres Play*/////////////////////////////
        {
            AddSongs();
           
            loop = false;
            int a=0;
            if (loop == false)
            {

                 a = songs.Capacity - 1;

            }
            for (int i = 0; i < a; i++)
            {

                Console.WriteLine("Title: "+songs[i].Title+" /Lyrics: " + songs[i].Lyrics);
                System.Threading.Thread.Sleep(2000);

            }

           
        }

      

        public List<Song> Shuffle()
        {
            AddSongs();
            List<Song> songs_shuffled = new List<Song>();

            for (int j = 1; j <= songs.Capacity; j += 3)
            {
                if (j <= 9)
                {
                    songs_shuffled.Add(songs[j]);
                }
                else { break; }
            }


            for (int i = 0; i <= songs.Capacity; i += 3)
            {
                if (i <= 9)
                {
                    songs_shuffled.Add(songs[i]);
                }
                else { break; }
            }

            for (int k = 2; k <= songs.Capacity; k += 3)
            {
                if (k <= 9)
                {
                    songs_shuffled.Add(songs[k]);
                }
                else { break; }
            }

            Console.WriteLine("");
            Console.WriteLine("После сортировки");
            Console.WriteLine("");

            foreach (Song d in songs_shuffled)
            {

                Console.WriteLine(d.Title + " " + d.Duration + " " + d.Genre + " " + d.Lyrics);
            }
            return songs_shuffled;
        }
       
        public  void ShowLyr()
        {

            //Add2();

            songs.Add(new Song { Title = "eye of a tiger", Duration = 500, Genre = "rock", Lyrics = "lalalalalaalalalala" });
            songs.Add(new Song { Title = "smooth criminal", Duration = 500, Genre = "pop", Lyrics = "lalalalalaalalalala" });
            songs.Add(new Song { Title = "Kickapoo", Duration = 260, Genre = "rock", Lyrics = "lalalalalaalalalala" });
            songs.Add(new Song { Title = "rdasf", Duration = 232, Genre = "jazzpunk", Lyrics = "lalalalalaalalalala" });
            songs.Add(new Song { Title = "raaa", Duration = 522, Genre = "electro-swing", Lyrics = "lalalalalaalalalala" });

            foreach (var item in songs)
            {
                Console.WriteLine(item.Title +" " + item.Lyrics);
            }
           
        }

        public string Title2
        {
            get { return Title; }
            set { Title = value; }
        }

        /*public Player(string a)
        {
            Title = a;

        }*/

        public  void SortByTitle() 
        {
            foreach (Song o in songs)
            {
                Console.WriteLine(o.Title + " " + o.Duration + " " + o.Genre + " " + o.Lyrics);
            }
            ArrayList songssorts = new ArrayList();

            foreach (Song o in songs)
            {
                songssorts.Add(Title);
            }

        }

        



    }
}
