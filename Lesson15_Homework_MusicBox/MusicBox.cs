using System;
using System.Collections.Generic;

namespace Lesson15_Homework_MusicBox
{
	public class MusicBox
	{
		Dictionary<int, CompactDisc> colCompactDiscs = new Dictionary<int, CompactDisc>();

		private void InitCollection()
		{
			for (int i = 0; i < 10; i++)
			{
				CompactDisc cd = new(i);
				for (int j = 0; j < 15; j++)
				{
					cd.SongsList.Add(new Song("Artist" + j, "Song" + j));
				}
				colCompactDiscs.Add(i, cd);
			}
		}

		public void Start()
		{
			InitCollection();
			Console.WriteLine("Choose operation:");
		}



	}
}