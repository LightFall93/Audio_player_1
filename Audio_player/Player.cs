using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audio_player
{
   class Player
    {
        private static int volume;
        public int step;
        private  bool playing;
        public  bool Locked = false;
        public const int maxVolume = 300;
        public const int minVolume = 300;
        public  Song[] Songs;

         bool Playing
        {
            get { return playing; }
        }

          public  int Volume
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

        public  void VolumeDown()
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

        public  bool Start()
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

    }
}
