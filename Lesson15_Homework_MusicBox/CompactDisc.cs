using System;
using System.Collections;

namespace Lesson15_Homework_MusicBox
{
    public class CompactDisc
    {
        public ArrayList SongsList;

        public CompactDisc()
        {
            SongsList = new ArrayList();
        }

        public void ShowDisc()
        {
            for (int i = 0; i < SongsList.Count; i++)
            {
                Song song = (Song)SongsList[i];

                Console.WriteLine("\t" + (i + 1) + ". " + song.Artist + " " + song.Title);
            }
        }

        

    }
}