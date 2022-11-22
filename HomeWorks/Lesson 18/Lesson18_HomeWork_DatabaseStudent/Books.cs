using System.Data.Linq.Mapping;

namespace Lesson18_HomeWork
{
	[Table(Name = "Books")]
	public class Books
	{
		[Column(IsPrimaryKey = true, IsDbGenerated = true)]
		public int Id { get; set; }
		[Column(Name = "Name")]
		public string Name { get; set; }
		[Column(Name = "StudentId")]
		public int StudentId { get; set; }
	}
}