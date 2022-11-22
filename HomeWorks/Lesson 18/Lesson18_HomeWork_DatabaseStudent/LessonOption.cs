using System;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;

namespace Lesson18_HomeWork
{
	static class LessonOption
	{
		public static void StartWork()
		{
			DbConnection dbConnection = new DbConnection();
			dbConnection.OpenConnection();
			SqlConnection _sqlConnection = dbConnection.GetConnection();

			bool boolExit = false;
			do
			{
				Console.WriteLine();
				Console.WriteLine("Choose option:");
				Console.WriteLine("1. Show all Lessons");
				Console.WriteLine("2. Add Lesson");
				Console.WriteLine("3. Student visit Lesson");
				Console.WriteLine("4. Show all visits by Student");
				Console.WriteLine("5. Exit");

				string chooseOption = Console.ReadLine();

				switch (chooseOption)
				{
					case "1":
						ShowLessons(_sqlConnection);
						break;
					case "2":
						AddLesson(_sqlConnection);
						break;
					case "3":
						StudentVisitLesson(_sqlConnection);
						break;
					case "4":
						ShowVisitByStudent(_sqlConnection);
						break;
					case "5":
						boolExit = true;
						break;
				}

			} while (!boolExit);
			dbConnection.CloseConnection();
		}

		public static void ShowLessons(SqlConnection sqlConnection)
		{
			DataContext db = new DataContext(DbConnection.ConnectionString);

			Table<Lessons> lessons = db.GetTable<Lessons>();
			Console.WriteLine();
			foreach (var lesson in lessons)
			{
				Console.WriteLine("{0} \t{1}", lesson.Id, lesson.Name);
			}
		}

		public static void AddLesson(SqlConnection sqlConnection)
		{
			DataContext db = new DataContext(DbConnection.ConnectionString);
			Table<Lessons> lessons = db.GetTable<Lessons>();
			Console.WriteLine("Enter name:");
			Lessons newLesson = new Lessons();
			newLesson.Name = Console.ReadLine();
			lessons.InsertOnSubmit(newLesson);
			db.SubmitChanges();
		}

		public static void StudentVisitLesson(SqlConnection sqlConnection)
		{
			Console.WriteLine("Enter Student Id");
			int StudentId = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter Lesson Id");
			int LessonId = Convert.ToInt32(Console.ReadLine());

			DataContext db = new DataContext(DbConnection.ConnectionString);
			Table<VisitLessons> visitLessons = db.GetTable<VisitLessons>();

			VisitLessons newVisit = new VisitLessons();
			newVisit.LessonId = LessonId;
			newVisit.StudentId = StudentId;
			newVisit.VisitDate = DateTime.Now;
			visitLessons.InsertOnSubmit(newVisit);
			db.SubmitChanges();
		}
		public static void ShowVisitByStudent(SqlConnection sqlConnection)
		{
			Console.WriteLine("Enter Student Id");
			int StudentId = Convert.ToInt32(Console.ReadLine());

			DataContext db = new DataContext(DbConnection.ConnectionString);
			Table<VisitLessons> visitLessons = db.GetTable<VisitLessons>();

			var result = from visit in visitLessons
						 where visit.StudentId == StudentId
						 select visit;
			Console.WriteLine();
			if (result.Count() == 0)
			{
				Console.WriteLine("No visits");
			}
			else
			{
				foreach (VisitLessons visit in result)
				{
					Console.WriteLine("{0} on {1} at {2}", visit.StudentId, visit.LessonId, visit.VisitDate.ToShortDateString());
				}
			}
		}
	}
}
