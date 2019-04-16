using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Audio_player
{
    class Program
    {

         static void Main(string[] args)
        {
            



            var song1 = new Song();
            song1.Title = "I Walk the Line";
            song1.Duration = 300;
            song1.Artist = new Artist { Name = "Johnny Cash" };

            var song2 = new Song();
            song2.Title = "Big Iron";
            song2.Duration = 300;
            song2.Artist = new Artist { Name = "Marty Robbins" };







            Player player1 = new Player();
            /*while (true)
             {
                 switch (Console.ReadLine())
                 {
                     case "up":
                     {
                         Player.VolumeUp();
                     }
                         break;

                     case "down":
                     {
                         Player.VolumeDown();
                     }
                         break;

                     case "s":
                     {
                         Player.Start();
                     }
                         break;
                 }
                 }*/


            Player.Volume = 500;
            Console.WriteLine("volume is Up " + Player.Volume);
            //Player.Playing = false;//checked

            //Player.GetInfo();
            //Player.Play();
            //Player.Stop();
            //Player.Start();
            //Player.Lock();
            //Player.Unlock();
            //Player.VolumeChange();
            //Player.Start();
            //Player.VolumeUp();
            //Player.VolumeDown();





            Console.ReadKey();
        }
    }
}
