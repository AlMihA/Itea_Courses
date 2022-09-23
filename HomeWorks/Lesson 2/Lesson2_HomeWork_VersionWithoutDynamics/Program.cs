using System;

namespace Lesson2_HomeWork_VersionWithoutDynamics
{
    internal class Program
    {
        public static void WriteInConsole(object outputValue)
        {
            Console.WriteLine("Введене значения = {0}, тип значення = {1}", outputValue, outputValue.GetType());
        }
        static void Main(string[] args)
        {
            while (true) //зробив цикл, щоб постійно не запускати програму для перевірки. Вихід через закриття консолі або Ctrl^c.
            {
                Console.WriteLine("Enter value:");
                string userValue = Console.ReadLine();

                Console.WriteLine("Enter type of value(sbyte, bool, short, ushort, int, uint, long, ulong,float,double,decimal,string):");
                string userType = Console.ReadLine();

                try
                {
                    switch (userType)
                    {
                        case "sbyte":
                            sbyte sb = Convert.ToSByte(userValue);
                            WriteInConsole(sb);
                            break;
                        case "bool":
                            bool b = Convert.ToBoolean(userValue);
                            WriteInConsole(b);
                            break; 
                        case "short":
                            short sh = Convert.ToInt16(userValue);
                            WriteInConsole(sh);
                            break;
                        case "ushort":
                            ushort ush = Convert.ToUInt16(userValue);
                            WriteInConsole(ush);
                            break;
                        case "int":
                            int i = Convert.ToInt32(userValue);
                            WriteInConsole(i);
                            break;
                        case "uint":
                            uint ui = Convert.ToUInt32(userValue);
                            WriteInConsole(ui);
                            break;
                        case "long":
                            long l = Convert.ToInt64(userValue);
                            WriteInConsole(l);
                            break;
                        case "ulong":
                            ulong ul = Convert.ToUInt64(userValue);
                            WriteInConsole(ul);
                            break;
                        case "float":
                            float fl = Convert.ToSingle(userValue);
                            WriteInConsole(fl);
                            break;
                        case "double":
                            double d = Convert.ToDouble(userValue);
                            WriteInConsole(d);
                            break;
                        case "decimal":
                            decimal dec = Convert.ToDecimal(userValue);
                            WriteInConsole(dec);
                            break;
                        case "string":
                            string s = Convert.ToString(userValue);
                            WriteInConsole(s);
                            break;
                        default:
                            Console.WriteLine("Uncorrect type");
                            return;
                    }
                }
                catch
                {
                    Console.WriteLine("Input string was not in a correct format or value was either too large or too small for this type");
                }
            }
        }
    }
}
