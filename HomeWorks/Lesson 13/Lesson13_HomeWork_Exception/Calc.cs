using System;

namespace Lesson13_HomeWork_Exception
{
	internal static class Calc
	{
		public static void Start()
		{
			//Успішне виконання
			bool success = false;
			//Помилка після N спроб
			bool error = false;
			//Поточна спроба
			int attempts = 0;
			//Кількість спроб
			const int maxAttempts = 5;

			do
			{
				//введеня значень
				Console.WriteLine("Choose action(+,-,*,/)");
				Methods.CalcAction = Console.ReadLine();

				Console.WriteLine("Input A");
				string a = Console.ReadLine();

				Console.WriteLine("Input B");
				string b = Console.ReadLine();

				try
				{
					//збільшення числа спроб
					attempts++;
					//виконання операції з данними
					Methods.Calc(a, b);
					//успіх
					success = true;
				}

				//перевірка яке прийшло виключення
				catch (CustomExсeption ex)
				{
					Console.WriteLine(ex.Message);
					Console.WriteLine("Enter number and correct operation");
				}
				catch (DivideByZeroException ex)
				{
					Console.WriteLine(ex.Message);
					Console.WriteLine("Enter number not equal 0");
				}
				catch (ArgumentOutOfRangeException ex)
				{
					Console.WriteLine(ex.Message);
					Console.WriteLine("Enter number greater 0");
				}
				catch (ArithmeticException ex)
				{
					Console.WriteLine(ex.Message);
					Console.WriteLine(ex.GetType().Name == "OverflowException"
						? "Enter correct numbers"
						: "Enter number not equal 0");
				}
				//не змогли ідентифікувати помилку
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
					Console.WriteLine("Unidentified error");
				}
				finally
				{
					//кількість спроб дойшла до максимума
					if (attempts == maxAttempts)
					{
						Console.WriteLine("No more attempts");
						error = true;
					}
				}
				//закінчкення циклу у випадку вдалої спроби або після N спроби
			} while (!success & !error);

			//обробка вдалої спроби і невдалої
			Console.WriteLine(success ? "Great work!" : "Bad work");
		}
	}
}
