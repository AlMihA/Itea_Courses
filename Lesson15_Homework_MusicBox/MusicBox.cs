using System;
using System.Collections.Generic;

namespace Lesson15_Homework_MusicBox
{
    public class MusicBox
    {
        Dictionary<string, CompactDisc> colCompactDiscs = new Dictionary<string, CompactDisc>();

        private void InitCollection()
        {
            for (int i = 0; i < 2; i++)
            {
                CompactDisc cd = new();
                for (int j = 0; j < 10; j++)
                {
                    cd.SongsList.Add(new Song("Artist" + j, "Song" + i + j));
                }
                colCompactDiscs.Add("Disc " + i, cd);
            }
        }

        public void ShowCollection()
        {
            foreach (KeyValuePair<string, CompactDisc> currentCD in colCompactDiscs)
            {
                Console.WriteLine(currentCD.Key);
                currentCD.Value.ShowDisc();
            }
        }

        public void FindSongsByArtist(string artist)
        {
            foreach (KeyValuePair<string, CompactDisc> currentCD in colCompactDiscs)
            {
                for (int i = 0; i < currentCD.Value.SongsList.Count; i++)
                {
                    Song song = (Song)currentCD.Value.SongsList[i];
                    if (song.Artist == artist)
                    {
                        Console.WriteLine(currentCD.Key + " " + song.Artist+" "+song.Title);
                    }
                }

            }
        }
        public void Start()
        {
            InitCollection();
            bool showMenu = true;
            do
            {

                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Choose operation:");
                Console.WriteLine("1. Show collection");
                Console.WriteLine("2. Show disc by name");
                Console.WriteLine("3. Add disc to collection");
                Console.WriteLine("4. Remove disc from collection");
                Console.WriteLine("5. Add song to disc");
                Console.WriteLine("6. Remove song from disc by index");
                Console.WriteLine("7. Search songs by artist");
                Console.WriteLine("8. Exit");

                string operation = Console.ReadLine();
                string discName;
                string artist;
                switch (operation)
                {
                    case "1":
                        ShowCollection();
                        break;
                    case "2":
                        Console.WriteLine("Enter disc name");
                        discName = Console.ReadLine();
                        if (colCompactDiscs.ContainsKey(discName))
                        {
                            colCompactDiscs[discName].ShowDisc();
                        }
                        else
                        {
                            Console.WriteLine("Wrong disc name");
                        }
                        break;
                    case "3":
                        Console.WriteLine("Enter disc name");
                        discName = Console.ReadLine();
                        if (!colCompactDiscs.ContainsKey(discName))
                        {
                            CompactDisc cd = new();
                            colCompactDiscs.Add(discName, cd);
                        }
                        else
                        {
                            Console.WriteLine("Disc is already exists");
                        }
                        break;
                    case "4":
                        Console.WriteLine("Enter disc name");
                        discName = Console.ReadLine();
                        if (colCompactDiscs.ContainsKey(discName))
                        {
                            colCompactDiscs.Remove(discName);
                        }
                        else
                        {
                            Console.WriteLine("Wrong disc name");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Enter disc name");
                        discName = Console.ReadLine();
                        if (colCompactDiscs.ContainsKey(discName))
                        {
                            Console.WriteLine("Enter artist");
                            artist = Console.ReadLine();
                            if (!(artist == ""))
                            {
                                Console.WriteLine("Enter title");
                                string title = Console.ReadLine();
                                if (!(title == ""))
                                {
                                    colCompactDiscs[discName].SongsList.Add(new Song(artist, title));
                                }
                                else
                                {
                                    Console.WriteLine("Wrong title");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Wrong artist");
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Wrong disc name");
                        }
                        break;
                    case "6":
                        Console.WriteLine("Enter disc name");
                        discName = Console.ReadLine();
                        if (colCompactDiscs.ContainsKey(discName))
                        {
                            int countCD = colCompactDiscs[discName].SongsList.Count;
                            if (countCD == 0)
                            {
                                Console.WriteLine("No songs on disc");
                                break;
                            }
                            Console.WriteLine("Enter index from 1 to "+ countCD);
                            int songIndex;
                            try
                            {
                                songIndex = Convert.ToInt32(Console.ReadLine());
                            }
                            catch
                            {
                                Console.WriteLine("Wrong index");
                                break;
                            }
                            
                            if (songIndex > countCD)
                            {
                                Console.WriteLine("Wrong index");
                                break;
                            }

                            colCompactDiscs[discName].SongsList.RemoveAt(songIndex-1);
                            
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Wrong disc name");
                        }
                        break;
                    case "7":
                        Console.WriteLine("Enter artist");
                        artist = Console.ReadLine();
                        FindSongsByArtist(artist);
                        break;
                    case "8":
                        showMenu = false;
                        break;
                    default:
                        Console.WriteLine("Invalid operation. Try again");
                        break;
                }
            } while (showMenu);
        }



    }
}