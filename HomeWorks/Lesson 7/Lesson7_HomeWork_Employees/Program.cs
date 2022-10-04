using System;


namespace Lesson7_HomeWork_Employees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string[,] mainArray = new string[1, 2];
            string[,] subArray;
            Console.WriteLine("Hello! This is program for employee accounting!");
            while (true)
            {
                Console.WriteLine("Enter employee:");
                string employee = Console.ReadLine();

                Console.WriteLine("Enter his salary:");
                bool incorrectvalue = true;
                string stringSalary = "";

                do
                {
                    stringSalary = Console.ReadLine();
                    try 
                    {
                        double doubleSalary = Convert.ToDouble(stringSalary);
                        if (doubleSalary<=0 || doubleSalary > 1000000)
                        {
                            Console.WriteLine("Incorrect value! Try again");
                        }
                        else
                        {
                            incorrectvalue = false;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Incorrect value! Try again");
                    }

                } while (incorrectvalue);

                if (count == 0)
                {
	                mainArray[count, 0] = employee;
	                mainArray[count, 1] = stringSalary;
	                count += 1;
                }
                else
                {
	                subArray = new string[count+1, 2];
                    for (int i = 0; i < count; i++)
                        for (int j = 0; j < 2; j++)
	                        subArray[i, j] = mainArray[i, j];
                    subArray[count, 0] = employee;
                    subArray[count, 1] = stringSalary;
                    mainArray = subArray;
                    count += 1;
                }

                Console.WriteLine("Do you want to enter another employee y/n");
                if (Console.ReadKey().KeyChar == 'y')
                {
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    break;
                }
            }
            for (int i = 0; i < mainArray.GetLength(0); i++)
            {
                Console.WriteLine("Employee {0}, salary - {1}", mainArray[i, 0], mainArray[i, 1]);
            }
            Console.ReadKey();
        }
    }


}
