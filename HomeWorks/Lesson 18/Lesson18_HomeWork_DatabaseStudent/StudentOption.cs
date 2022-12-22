using System;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;

namespace Lesson18_HomeWork
{
	static class StudentOption
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
				Console.WriteLine("1. Show all Students");
				Console.WriteLine("2. Add Student");
				Console.WriteLine("3. Delete Student");
				Console.WriteLine("4. Exit");

				string chooseOption = Console.ReadLine();

				switch (chooseOption)
				{
					case "1":
						ShowStudents(_sqlConnection);
						break;
					case "2":
						AddStudent(_sqlConnection);
						break;
					case "3":
						DeleteStudent(_sqlConnection);
						break;
					case "4":
						boolExit = true;
						break;
				}

			} while (!boolExit);
			dbConnection.CloseConnection();
		}

		public static void ShowStudents(SqlConnection sqlConnection)
		{
			DataContext db = new DataContext(DbConnection.ConnectionString);

			Table<Students> students = db.GetTable<Students>();
			Console.WriteLine();
			foreach (var student in students)
			{
				Console.WriteLine("{0} \t{1}", student.Id, student.Name);
			}
		}

		public static void AddStudent(SqlConnection sqlConnection)
		{
			DataContext db = new DataContext(DbConnection.ConnectionString);
			Table<Students> students = db.GetTable<Students>();
			Console.WriteLine("Enter name:");
			Students newStudent = new Students();
			newStudent.Name = Console.ReadLine();
			students.InsertOnSubmit(newStudent);
			db.SubmitChanges();
		}

		public static void DeleteStudent(SqlConnection sqlConnection)
		{
			Console.WriteLine("Enter Id");
			int Id = Convert.ToInt32(Console.ReadLine());
			DataContext db = new DataContext(DbConnection.ConnectionString);
			Table<Students> students = db.GetTable<Students>();

			var result = from student in students
						 where student.Id == Id
						 select student;
			foreach (Students student in result)
			{
				if (student != null)
				{
					db.GetTable<Students>().DeleteOnSubmit(student);
					db.SubmitChanges();
				}
			}
		}
	}
}
