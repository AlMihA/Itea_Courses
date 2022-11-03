using System;

namespace Lesson13_HomeWork_Exception
{
    public static class Methods
    {
        public static string CalcAction;

        public static void Calc(string a, string b)
        {
	        //перевірка на корректність значень
	        if (CheckValues(a, b))
	        {
		        switch (CalcAction)
		        {
			        //вибір операції
			        case "+":
				        Add(a, b);
				        break;
			        case "-":
				        Subtract(a, b);
				        break;
			        case "*":
				        Multiplicate(a, b);
				        break;
			        default:
				        Divide(a, b);
				        break;
		        }
	        }
        }
        public static void Add(string a, string b)
        {
            Console.WriteLine("A + B = " + (Convert.ToDecimal(a) + Convert.ToDecimal(b)));
        }

        public static void Subtract(string a, string b)
        {
            Console.WriteLine("A - B = " + (Convert.ToDecimal(a) - Convert.ToDecimal(b)));
        }

        public static void Multiplicate(string a, string b)
        {
            Console.WriteLine("A * B = " + (Convert.ToDecimal(a) * Convert.ToDecimal(b)));
        }

        public static void Divide(string a, string b)
        {
            Console.WriteLine("A / B = " + (Convert.ToDecimal(a) / Convert.ToDecimal(b)));
        }

        public static bool CheckValues(string a, string b)
        {
            decimal x;
            decimal y;

            //перевірка чи знак операції вибрано корректно
            if (!(CalcAction == "+" || CalcAction == "-" || CalcAction == "*" || CalcAction == "/"))
            {
                throw new CustomExсeption("Invalid operation");
            }

            //перевірка чи А це число
            try
            {
                x = Convert.ToDecimal(a);
            }
            catch
            {
                throw new CustomExсeption("Invalid value A");
            }

            //перевірка чи В це число
            try
            {
                y = Convert.ToDecimal(b);
            }
            catch
            {
                throw new CustomExсeption("Invalid value B");
            }

            //перевірка чи числа від`ємні
            if (x < 0 & y < 0)
            {
                throw new ArgumentOutOfRangeException("A and B less 0");
            }

            //перевірка чи якесь число дорівнює 0
            if (x == 0 & y != 0 || x != 0 & y == 0)
            {
                throw new ArithmeticException("A or B equal 0");
            }

            //перевірка чи обидва числа дорівнюють 0
            if (x == 0 & y == 0)
            {
                throw new DivideByZeroException("A and B equal 0");
            }
            
            //пройдено успішно
            return true;
        }
    }
}
