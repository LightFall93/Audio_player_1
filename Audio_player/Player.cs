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
        private  bool playing;
        public   bool Locked = false;
        public const int maxVolume = 300;
        public const int minVolume = 300;
        public  Song[] Songs;

        public int Duration;
        public string Genre;
        public string Lyrics; 
        public string Path;


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

        public  void Play(bool loop,ArrayList songs)
        {
            Add2();
            //все ещё не работает return
            loop = false;
            int a=0;
            if (loop == false)
            {

                 a = Songs.Length - 1;

            }
            for (int i = 0; i < a; i++)
            {

                //Console.WriteLine(songs[i].Title+ songs.Lyrics);
                System.Threading.Thread.Sleep(2000);

            }
        }

        public  void Add (params string[] songs)
        {
            /*List<Player> songs = new List<Player>();
            songs.Add(new Player { Title = "eye of a tiger", Duration = 500, Genre = "rock" });
            songs.Add(new Player { Title = "smooth criminal", Duration = 500, Genre = "pop" });
            songs.Add(new Player { Title = "ring of fire", Duration = 500, Genre = "jazz" });*/
        }
        
        public  ArrayList  Add2()
        {

            var songs = new ArrayList(); 
            songs.Add(new Player { Title = "1 eye of a tiger", Duration = 500, Genre = "rock", Lyrics="lalalalalaalalalala" });
            songs.Add(new Player { Title = "2 smooth criminal", Duration = 500, Genre = "pop", Lyrics = "lalalalalaalalalala" });
            songs.Add(new Player { Title = "3 Kickapoo", Duration = 260, Genre = "rock", Lyrics = "lalalalalaalalalala" });
            songs.Add(new Player { Title = "4 Гладкие Криминал", Duration = 232, Genre = "k-pop", Lyrics = "Ты в порядке Саня?" });
            songs.Add(new Player { Title = "5 MEME MACHINE", Duration = 522, Genre = "??", Lyrics = "...." });
            songs.Add(new Player { Title = "6 Cancion del mariachi ", Duration = 500, Genre = "ohno", Lyrics = "lala2" });
            songs.Add(new Player { Title = "7 San Francisco", Duration = 500, Genre = "pop4", Lyrics = "lala3" });
            songs.Add(new Player { Title = "8 Have You Ever Seen The Rain", Duration = 500, Genre = "pop5", Lyrics = "lalads3" });
            songs.Add(new Player { Title = "9 Ghost Riders In The Sky", Duration = 500, Genre = "pop6", Lyrics = "lala23" });
            songs.Add(new Player { Title = "10 the end", Duration = 500, Genre = "pop7", Lyrics = " yey" });

            foreach (Player p in songs)
            {
                Console.WriteLine(p.Title+" "+p.Duration + " " + p.Genre + " " + p.Lyrics);
            }
            
            return songs;
        }

        public static ArrayList Shuffle()
        {
            ArrayList songs = new ArrayList();
            songs.Add(new Player { Title = "1 eye of a tiger", Duration = 500, Genre = "rock", Lyrics = "lalalalalaalalalala" });
            songs.Add(new Player { Title = "2 smooth criminal", Duration = 500, Genre = "pop", Lyrics = "lalalalalaalalalala" });
            songs.Add(new Player { Title = "3 Kickapoo", Duration = 260, Genre = "rock", Lyrics = "lalalalalaalalalala" });
            songs.Add(new Player { Title = "4 Гладкие Криминал", Duration = 232, Genre = "k-pop", Lyrics = "Ты в порядке Саня?" });
            songs.Add(new Player { Title = "5 MEME MACHINE", Duration = 522, Genre = "??", Lyrics = "...." });
            songs.Add(new Player { Title = "6 Cancion del mariachi ", Duration = 500, Genre = "ohno", Lyrics = "lala2" });
            songs.Add(new Player { Title = "7 San Francisco", Duration = 500, Genre = "pop4", Lyrics = "lala3" });
            songs.Add(new Player { Title = "8 Have You Ever Seen The Rain", Duration = 500, Genre = "pop5", Lyrics = "lalads3" });
            songs.Add(new Player { Title = "9 Ghost Riders In The Sky", Duration = 500, Genre = "pop6", Lyrics = "lala23" });
            songs.Add(new Player { Title = "10 the end", Duration = 500, Genre = "pop7", Lyrics = " yey" });
            foreach (Player p in songs)
            {
                Console.WriteLine(p.Title + " " + p.Duration + " " + p.Genre + " " + p.Lyrics);
            }
            //Все ещё не могу сделать, чтобы методы нормально у меня возвращали результат.
            //Поэтому снова просто в самом методе  создавал  песни.
            ArrayList songs_shuffled = new ArrayList();

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

            foreach (Player d in songs_shuffled)
            {

                Console.WriteLine(d.Title + " " + d.Duration + " " + d.Genre + " " + d.Lyrics);
            }
            return songs_shuffled;

            //return songs;
            //get { return songs; }
        }
       
        public  void ShowLyr()
        {

            List<Player> songs = new List<Player>();
            //Add2();

            songs.Add(new Player { Title = "eye of a tiger", Duration = 500, Genre = "rock", Lyrics = "lalalalalaalalalala" });
            songs.Add(new Player { Title = "smooth criminal", Duration = 500, Genre = "pop", Lyrics = "lalalalalaalalalala" });
            songs.Add(new Player { Title = "Kickapoo", Duration = 260, Genre = "rock", Lyrics = "lalalalalaalalalala" });
            songs.Add(new Player { Title = "rdasf", Duration = 232, Genre = "jazzpunk", Lyrics = "lalalalalaalalalala" });
            songs.Add(new Player { Title = "raaa", Duration = 522, Genre = "electro-swing", Lyrics = "lalalalalaalalalala" });

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

            //ArrayList songs = new ArrayList();
            List<Player> songs = new List<Player>();
            songs.Add(new Player { Title2 = "m1 eye of a tiger", Duration = 500, Genre = "rock", Lyrics = "lalalalalaalalalala" });
            songs.Add(new Player { Title2 = "l2 smooth criminal", Duration = 500, Genre = "pop", Lyrics = "lalalalalaalalalala" });
            songs.Add(new Player { Title2 = "k3 Kickapoo", Duration = 260, Genre = "rock", Lyrics = "lalalalalaalalalala" });
            songs.Add(new Player { Title2 = "g4 Гладкие Криминал", Duration = 232, Genre = "k-pop", Lyrics = "Ты в порядке Саня?" });
            songs.Add(new Player { Title2 = "f5 MEME MACHINE", Duration = 522, Genre = "??", Lyrics = "...." });
            songs.Add(new Player { Title2 = "e6 Cancion del mariachi ", Duration = 500, Genre = "ohno", Lyrics = "lala2" });
            songs.Add(new Player { Title2 = "d7 San Francisco", Duration = 500, Genre = "pop4", Lyrics = "lala3" });
            songs.Add(new Player { Title2 = "c8 Have You Ever Seen The Rain", Duration = 500, Genre = "pop5", Lyrics = "lalads3" });
            songs.Add(new Player { Title2 = "b9 Ghost Riders In The Sky", Duration = 500, Genre = "pop6", Lyrics = "lala23" });
            songs.Add(new Player { Title2 = "a10 the end", Duration = 500, Genre = "pop7", Lyrics = " yey" });
            foreach (Player o in songs)
            {
                Console.WriteLine(o.Title + " " + o.Duration + " " + o.Genre + " " + o.Lyrics);
            }
            ArrayList songssorts = new ArrayList();

            foreach (Player o in songs)
            {
                songssorts.Add(Title2);
            }
            //не рабоатает
            //var t = songs.OrderBy(a => a.Title);

        }

        



    }
}
