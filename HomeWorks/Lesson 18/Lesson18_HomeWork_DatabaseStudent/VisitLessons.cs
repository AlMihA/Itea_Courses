using System;
using System.Data.Linq.Mapping;

namespace Lesson18_HomeWork
{
	[Table(Name = "VisitLessons")]
	public class VisitLessons
	{
		[Column(IsPrimaryKey = true, IsDbGenerated = true)]
		public int Id { get; set; }
		[Column(Name = "LessonId")]
		public int LessonId { get; set; }
		[Column(Name = "StudentId")]
		public int StudentId { get; set; }
		[Column(Name = "VisitDate")]
		public DateTime VisitDate { get; set; }
	}
}

