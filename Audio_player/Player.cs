using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audio_player
{
    class Player
    {
        public static int Volume;
        public static int step;
        public static bool playing;
        public static bool Locked = false;
        private const int maxVolume = 100;
        private const int minVolume = 100;



        public void GetInfo()
        {
            Console.WriteLine(" " + maxVolume);
        }


        public static void VolumeUp()
        {
            Volume += 1;
            Console.WriteLine("Volume is Up " + Volume);
        }

        public static void VolumeDown()
        {
            Volume -= 1;
            Console.WriteLine("Volume is down " + Volume);
        }

        public static void VolumeChange()
        {
            step = int.Parse(Console.ReadLine());
            Volume += step;
            Console.WriteLine("Volume changed to " + Volume);

        }

        public static void Start()
        {
            playing = true;
            Console.WriteLine("start  playing =" + playing);
        }

        public static void Lock()
        {
            Locked = true;
            Console.WriteLine("player locked, Locked= " + Locked);
        }

        public static void Unlock()
        {
            Locked = false;
            Console.WriteLine("player unlocked, Locked= " + Locked);
        }
    }
}
