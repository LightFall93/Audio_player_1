using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audio_player
{
   class Player
    {

        private static  int volume;
        public int step;
        private static  bool playing;
        public static  bool Locked = false;
        public const int maxVolume = 300;
        public const int minVolume = 300;
        public  Song[] Songs;

        public int Duration;
        public string Title;
        public string Path;
        public string Lyrics;
        public string Genre;

        bool Playing
        {
            get { return playing; }
        }

          public static int Volume
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


        public static  void VolumeUp()
        {
            volume += 50;
            Console.WriteLine("volume is Up " + volume);
        }

        public static  void VolumeDown()
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

        public static  bool Start()
        {
            if (Locked == false)
            {
                playing = true;

            }
            Console.WriteLine("player start playing ");

            return playing;
        }

        public  void Play()
        {

            for (int i = 0; i < Songs.Length; i++)
            {
                Console.WriteLine(Songs[i].Title);
                System.Threading.Thread.Sleep(2000);
            }
        }

        public static void Add (params string[] songs)
        {

          
            

            /*List<Player> songs = new List<Player>();
            songs.Add(new Player { Title = "eye of a tiger", Duration = 500, Genre = "rock" });
            songs.Add(new Player { Title = "smooth criminal", Duration = 500, Genre = "pop" });
            songs.Add(new Player { Title = "ring of fire", Duration = 500, Genre = "jazz" });*/

        }

        

    }
}
