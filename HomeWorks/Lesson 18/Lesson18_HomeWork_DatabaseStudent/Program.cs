using System;
using System.Linq;
using System.Data.Linq;
using System.Data.SqlClient;

namespace Lesson18_HomeWork_DatabaseStudent
{
	class Program
	{
		static void Main(string[] args)
		{
			DbConnection dbConnection = new DbConnection();
			dbConnection.OpenConnection();

			DataContext db = new DataContext(connectionString);

			// Получаем таблицу пользователей
			Table<User> users = db.GetTable<User>();

			foreach (var user in users)
			{
				Console.WriteLine("{0} \t{1} \t{2}", user.Id, user.FirstName, user.Age);
			}
		}
	}
}
