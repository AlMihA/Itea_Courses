using System.Collections;

namespace Lesson15_Homework_MusicBox
{
	public class CompactDisc
	{
		public ArrayList SongsList;
		public int Number;

		public CompactDisc(int number)
		{
			this.Number = number;
			SongsList = new ArrayList();
		}
	}
}