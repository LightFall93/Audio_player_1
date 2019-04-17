using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Audio_player
{
    class Program
    {

         static void Main(string[] args)
        {

            /*var song1 = new Song();
            song1.Title = "I Walk the Line";
            song1.Duration = 300;
            song1.Artist = new Artist { Name = "Johnny Cash" };

            var song2 = new Song();
            song2.Title = "Big Iron";
            song2.Duration = 300;
            song2.Artist = new Artist { Name = "Marty Robbins" };*/


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

            //CreateDefaultSong();

            string Name = "song name";
            CreateNameSong(Name);

            //CreateSong(string Name, int time, string place, string words, string type);

            //Player.Volume = 500;
            //Console.WriteLine("volume is Up " + Player.Volume);//checked
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

         private static object CreateDefaultSong()
         {
             Random rand = new Random();
            Song song_default = new Song
            {
                Duration = rand.Next(101),
                Title = "default song",
                Path = "default song",
                Lyrics = "default song",
                Genre = "default song",
                Artist = new Artist(),
                Playlist = new Playlist()
            };
            Console.WriteLine(song_default.Duration);
            return song_default;
            
        }

         private static object CreateNameSong(string Name)
         {
             Song song_name = new Song();
             CreateDefaultSong();
             song_name.Title = Name;
             Console.WriteLine(song_name.Duration+ song_name.Title);
            return song_name;
         }

         private object CreateSong(string Name,int time,string place,string words,string type)
         {
             Random rand = new Random();
            Song song_name = new Song
            {
                Duration = time,
                Title = Name,
                Path = place,
                Lyrics = words,
                Genre = type,
                Artist = new Artist(),
                Playlist = new Playlist()
            };

            return song_name;
         }

    }
}
