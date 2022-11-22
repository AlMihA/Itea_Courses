﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace Lesson18_HomeWork_DatabaseStudent
{
	public class DbConnection
	{
		private const string ConnectionString = @"Data Source=(local);Initial Catalog=Lesson18_HomeWork;User Id = sa; Password = sa123";
		private SqlConnection _sqlConnection = new SqlConnection(ConnectionString);

		public void OpenConnection()
		{
			if (_sqlConnection.State == ConnectionState.Closed)
			{
				_sqlConnection.Open();
				Console.WriteLine("Success!");
			}
		}

		public void CloseConnection()
		{
			if (_sqlConnection.State == ConnectionState.Open)
			{
				_sqlConnection.Open();
			}
		}

		public SqlConnection GetConnection()
		{
			return _sqlConnection;
		}
	}
}
