using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Audio_player
{
    class Program
    {


        static void Main(string[] args)
         {

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
            //Player player1 = new Player();
            //Player.Volume = 500;
            //Console.WriteLine("volume is Up " + Player.Volume);//checked
            //Player.Playing = false;//checked
            //CreateSong(string Name, int time, string place, string words, string type);
            //CreateDefaultSong();
            //string Name = "song name";
            //CreateNameSong(Name);
            //Player.Add("Название песни 1","Название песни 2");
            //Create();
            //AddArtist();
            //AddArtist(Name:"dam");
            //AddAlbum();
            //AddAlbum(Name:"dam",Year:'1');
            //Player.ShowLyr();

            //Player.Add2();
            //Player.Shuffle();
            //Player.Play();
            //Player.Shuffle();


            //Player.SortByTitle();
            Console.ReadKey();
        }

         private static object Create()
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

         private static object Create(string Name)
         {
             Song song_name = new Song();
             Create();
             song_name.Title = Name;
             Console.WriteLine(song_name.Duration+ song_name.Title);
            return song_name;
         }

         private object Create(string Name,int time,string place,string words,string type)
         {
             Random rand = new Random();
            Song song_name = new Song()
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


        private static void Create(ref Song song1, ref Song song2)
        {

             Random rand = new Random();
             Song[] songs = new Song[3];
            

             int MinDuration = 0, MaxDuration = 0, TotalDuration = 0;
             for (int i = 0; i < songs.Length; i++)
             {
                 var songs1 = new Song();
                 songs1.Title = "Song" + i;
                 songs1.Duration = rand.Next(501);
                 songs1.Artist = new Artist();
                 songs[i] = songs1;
                 TotalDuration += songs1.Duration;
                 MinDuration = songs1.Duration < MinDuration ? songs1.Duration : MinDuration;
                 MaxDuration = songs1.Duration > MaxDuration ? songs1.Duration : MaxDuration;
                
             }



             
        }

        private static object AddArtist(string Name = default(string))
        {
            Artist artist1 = new Artist();

            Name = "Unknown Artist";
            Console.WriteLine(Name);
            return artist1;
        }

        private static object AddAlbum(string Name = default(string), char Year = default(char))
        {
            Album album1 = new Album();

            Name = "Unknown Album";
            Year = '-';
            Console.WriteLine($""+Name +" "+ Year);
            return album1;
        }




    }
}
