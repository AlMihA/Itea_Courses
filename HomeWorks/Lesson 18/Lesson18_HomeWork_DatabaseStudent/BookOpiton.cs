using System;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Linq;

namespace Lesson18_HomeWork
{
	static class BookOption
	{
		public static void StartWork()
		{
			DbConnection dbConnection = new DbConnection();
			dbConnection.OpenConnection();
			SqlConnection _sqlConnection = dbConnection.GetConnection();

			bool boolExit = false;
			do
			{
				Console.WriteLine("Choose option:");
				Console.WriteLine("1. Show all Books");
				Console.WriteLine("2. Add Book");
				Console.WriteLine("3. Give Book to Student");
				Console.WriteLine("4. Return Book from Student");
				Console.WriteLine("5. Exit");

				string chooseOption = Console.ReadLine();

				switch (chooseOption)
				{
					case "1":
						ShowBooks(_sqlConnection);
						break;
					case "2":
						AddStudent(_sqlConnection);
						break;
					case "3":
						GiveBookToStudent(_sqlConnection);
						break;
					case "4":
						ReturnBookFromStudent(_sqlConnection);
						break;
					case "5":
						boolExit = true;
						break;
				}

			} while (!boolExit);
			dbConnection.CloseConnection();
		}

		public static void ShowBooks(SqlConnection sqlConnection)
		{
			DataContext db = new DataContext(DbConnection.ConnectionString);

			Table<Books> books = db.GetTable<Books>();

			foreach (var book in books)
			{
				Console.WriteLine("{0} \t{1} \t{2}", book.Id, book.Name, book.StudentId);
			}
		}

		public static void AddStudent(SqlConnection sqlConnection)
		{
			DataContext db = new DataContext(DbConnection.ConnectionString);
			Table<Books> books = db.GetTable<Books>();
			Console.WriteLine("Enter name:");
			Books newBook = new Books();
			newBook.Name = Console.ReadLine();
			books.InsertOnSubmit(newBook);
			db.SubmitChanges();
		}

		public static void GiveBookToStudent(SqlConnection sqlConnection)
		{
			Console.WriteLine("Enter Book Id");
			int BookId = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter Student Id");
			int StudentId = Convert.ToInt32(Console.ReadLine());

			DataContext db = new DataContext(DbConnection.ConnectionString);
			Table<Books> books = db.GetTable<Books>();

			var result = from book in books
						 where book.Id == BookId && book.StudentId == 0
						 select book;

			if (result.Count() == 0)
			{
				Console.WriteLine("This book not exists or busy");
			}
			else
			{
				foreach (Books book in result)
				{
					book.StudentId = StudentId;
					db.SubmitChanges();
				}
			}
		}
		public static void ReturnBookFromStudent(SqlConnection sqlConnection)
		{
			Console.WriteLine("Enter Book Id");
			int BookId = Convert.ToInt32(Console.ReadLine());
			
			DataContext db = new DataContext(DbConnection.ConnectionString);
			Table<Books> books = db.GetTable<Books>();

			var result = from book in books
						 where book.Id == BookId && book.StudentId != 0
						 select book;

			if (result.Count() == 0)
			{
				Console.WriteLine("This book not exists or no owner now");
			}
			else
			{
				foreach (Books book in result)
				{
					book.StudentId = 0;
					db.SubmitChanges();
				}
			}
		}
	}
}
