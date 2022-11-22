using System.Data.Linq.Mapping;

namespace Lesson18_HomeWork
{
	[Table(Name = "Lessons")]
	public class Lessons
	{
		[Column(IsPrimaryKey = true, IsDbGenerated = true)]
		public int Id { get; set; }
		[Column(Name = "Name")]
		public string Name { get; set; }
	}
}

