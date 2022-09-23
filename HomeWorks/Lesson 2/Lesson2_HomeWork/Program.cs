using System;

namespace Lesson2_HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) //зробив цикл, щоб постійно не запускати програму для перевірки. Вихід через закриття консолі або Ctrl^c.
            {
                Console.WriteLine("Enter value:");
                string userValue = Console.ReadLine();

                Console.WriteLine("Enter type of value(sbyte, bool, short, ushort, int, uint, long, ulong,float,double,decimal,string):");
                string userType = Console.ReadLine();

                      
                Object finalValue;
                //dynamic finalValue;

                try
                {
                    switch (userType)
                    {
                        case "sbyte":
                            finalValue = Convert.ToSByte(userValue);
                            break;
                        case "bool":
                            finalValue = Convert.ToBoolean(userValue);
                            break;
                        case "short":
                            finalValue = Convert.ToInt16(userValue);
                            break;
                        case "ushort":
                            finalValue = Convert.ToUInt16(userValue);
                            break;
                        case "int":
                            finalValue = Convert.ToInt32(userValue);
                            break;
                        case "uint":
                            finalValue = Convert.ToUInt32(userValue);
                            break;
                        case "long":
                            finalValue = Convert.ToInt64(userValue);
                            break;
                        case "ulong":
                            finalValue = Convert.ToUInt64(userValue);
                            break;
                        case "float":
                            finalValue = Convert.ToSingle(userValue);
                            break;
                        case "double":
                            finalValue = Convert.ToDouble(userValue);
                            break;
                        case "decimal":
                            finalValue = Convert.ToDecimal(userValue);
                            break;
                        case "string":
                            finalValue = Convert.ToString(userValue);
                            break;
                        default:
                            Console.WriteLine("Uncorrect type");
                            return;
                    }
                    Console.WriteLine("Введене значения = {0}, тип значення = {1}", finalValue, finalValue.GetType());
                }
                catch
                {
                    Console.WriteLine("Input string was not in a correct format or value was either too large or too small for this type");
                }
            }

        }
    }
}
