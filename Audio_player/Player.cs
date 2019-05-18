using System;
using System.IO;
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

        public List<Song> songs = new List<Song>();

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

        public void Load()
        {
            string file_place;
            Console.WriteLine("Enter your file destination");
            file_place = Console.ReadLine();

            var directoryInfo = new DirectoryInfo(file_place);
            // "E://C#//wav"
            var file_mas = directoryInfo.GetFiles();

            foreach (var item in file_mas)
            {
                Console.WriteLine(item.FullName + item.CreationTime + item.Length);
            }

        }

        public void Clear()
        {
        

        }

        public List<Song> AddSongs()
        {
            songs.Add(new Song { Title = "eye of a tiger (1)", Duration = 500, Genre = Genre.Rock, Lyrics = "lalalalalaalalalala", Like = null});
            songs.Add(new Song { Title = "smooth criminal (2)", Duration = 500, Genre = Genre.Pop, Lyrics = "lalalalalaalalalala", Like = null });
            songs.Add(new Song { Title = "Kickapoo (3)", Duration = 260, Genre = Genre.Rock, Lyrics = "lalalalalaalalalala", Like = null });
            songs.Add(new Song { Title = "Help (4)", Duration = 232, Genre = Genre.Soundtrack,Lyrics = "Help, i need somebody", Like = null });
            songs.Add(new Song { Title = "MACHINE (5)", Duration = 522, Genre = Genre.Soundtrack, Lyrics = "01010000100010101101", Like = null });
            songs.Add(new Song { Title = "Cancion del mariachi (6)", Duration = 500, Genre = Genre.Indie_Rock, Lyrics = "lalalalalaalalalala2", Like = null });
            songs.Add(new Song { Title = "San Francisco (7)", Duration = 500, Genre = Genre.Pop, Lyrics = "lalalalalaalalalala", Like = null });
            songs.Add(new Song { Title = "BFG Division (8)", Duration = 500, Genre = Genre.Soundtrack, Lyrics = "...lalalalalaalalalala", Like = null });
            songs.Add(new Song { Title = "Ghost Riders In The Sky (9)", Duration = 500, Genre = Genre.Rock, Lyrics = "lalalalalaalalalala", Like = null });
            songs.Add(new Song { Title = "the end 10 (10)", Duration = 500, Genre = Genre.Folk, Lyrics = " lalalalalaalalalala", Like = null });
            

            songs[1].Set_Like();
            songs[3].Set_DisLike();
            songs[6].Set_Like();
            songs[8].Set_Like();
            songs[9].Set_DisLike();

            foreach (Song p in songs)
            {
                if (p.Like==false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(p.Title + " " + p.Duration + " " + p.Genre + " " + p.Lyrics+p.Genre);
                    Console.ResetColor();
                }
                else if (p.Like == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(p.Title + " " + p.Duration + " " + p.Genre + " " + p.Lyrics);
                    Console.ResetColor();
                }

                else
                {
                    Console.WriteLine(p.Title + " " + p.Duration + " " + p.Genre + " " + p.Lyrics);
                }


            }
            Console.WriteLine(" ");
            return songs;
        }

        public void  Play(bool loop)// Heres Plays metod*/////////////////////////////
        {
            
            if (loop == false)
            {
                for (int i = 0; i < songs.Count; i++)
                {
                    Console.WriteLine("Песня (Title): " + songs[i].Title);
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine("Слова песни(Lyrics): " + songs[i].Lyrics);
                    System.Threading.Thread.Sleep(2000);
                    Console.WriteLine(" ");
                }
            }

            else
            {
                int z = 0;
                do
                {
                    
                 for (int i = 0; i < songs.Count; i++)
                  {
                      Console.WriteLine("Песня (Title): " + songs[i].Title);
                      System.Threading.Thread.Sleep(2000);
                      Console.WriteLine("Слова песни(Lyrics): " + songs[i].Lyrics);
                      System.Threading.Thread.Sleep(2000);
                      Console.WriteLine(" ");
                    }
                 Console.WriteLine("Плэйлист проигрывается ещё раз  ");
                 z++;
                } while (z<5);

            }
        }

        public void Shuffle()
        {
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

           /* Console.WriteLine("");
            Console.WriteLine("После сортировки");
            Console.WriteLine("");

            foreach (Song d in songs_shuffled)
            {

                Console.WriteLine(d.Title + " " + d.Duration + " " + d.Genre + " " + d.Lyrics);
            }*/

            songs = songs_shuffled;

        }


        public  void SortByTitle() 
        {
            List<string> title_list = new List<string>();

            for (int i = 0; i < songs.Count; i++)
            {
                title_list.Add(songs[i].Title);

            }

            title_list.Sort();

            foreach (string d in title_list)
            {
                //Console.WriteLine(d);
            }

            List<Song> songs_sorted = new List<Song>();

            for (int i = 0; i < songs.Count; i++)
            {

            for (int j = 0; j < songs.Count; j++)
            {
                if (title_list[i] == songs[j].Title)
                {
                    songs_sorted.Add(songs[j]);
                    break;
                }
                else { }
            }

            }

            songs = songs_sorted;
        }

        
        public void FilterByGenre(Genre genre)
        {
            List<Song> songs_filtered = new List<Song>();


            for (int j = 0; j < songs.Count; j++)
            {
                if (songs[j].Genre == genre)
                {
                    songs_filtered.Add(songs[j]);

                }
            }




            Console.WriteLine("");
             Console.WriteLine("zzAfter genre filtering by "+genre);
             Console.WriteLine("");

             foreach (Song d in songs_filtered)
             {
                 Console.WriteLine(d.Title + " " + d.Duration + " " + d.Genre + " " + d.Lyrics);
             }

             songs = songs_filtered;
        }
    }
}
