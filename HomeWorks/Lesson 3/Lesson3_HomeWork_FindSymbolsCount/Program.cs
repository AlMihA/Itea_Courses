using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Lesson3_HomeWork_FindSymbolsCount
{
    internal class Program
    {
        static void FirstVersion(string textForFind)
        {
            while (textForFind.Length > 0)
            {
                string symbolFind = textForFind[0].ToString();
                int countTimes = 0;
                for (int i = 0; i < textForFind.Length; i++)
                {
                    if (textForFind[i].ToString() == symbolFind)
                    {
                        countTimes++;
                    }
                }
                Console.WriteLine("Symbol {0} - {1} times", symbolFind, countTimes);
                textForFind = textForFind.Replace(symbolFind, "");
            }
        }
        static void SecondVersion(string textForFind)
        {
            while (textForFind.Length > 0)
            {
                string symbolFind = textForFind[0].ToString();
                int countTimes = Regex.Matches(textForFind, symbolFind).Count;
                Console.WriteLine("Symbol {0} - {1} times", symbolFind, countTimes);
                textForFind = Regex.Replace(textForFind, symbolFind, "");
            }
        }

        static void ThirdVersion(string textForFind)
        {
            while (textForFind.Length > 0)
            {
                string symbolFind = textForFind[0].ToString();
                int lengthBefore = textForFind.Length;
                textForFind = textForFind.Replace(symbolFind, "");
                int lengthAfter = textForFind.Length;
                Console.WriteLine("Symbol {0} - {1} times", symbolFind, lengthBefore - lengthAfter);
            }
        }

        static void FourthVersion(string textForFind)
        {
            List<char> alphabet = new List<char>();
            for (int i = 65; i < 91; i++)
            {
                alphabet.Add((char)i);
            }
           
            for (int i = 0; i < alphabet.Count; i++)
            {
                int countTimes = 0;
                for (int y = 0; y < textForFind.Length; y++)
                {
                    if (textForFind[y] == alphabet[i])
                    {
                        countTimes++;
                    }
                }
                Console.WriteLine("Symbol {0} - {1} times", alphabet[i], countTimes);
            }
        }


        static void Main(string[] args)
        {
            string textForFind = "DFASDKAJD;LKJASD;LAFD;`LAGJF;`DKJA;@AVM;]LK;ALFIJELIJAS;LFJAS;LFAWHFEKAUWHFYULHAEUHFFKLD~SPFLDSFLFDASPFDLSPFLAKEWIFJLEIFJ;LESFJSEF";
            FirstVersion(textForFind);
            Console.WriteLine("---------------------------------");
            SecondVersion(textForFind);
            Console.WriteLine("---------------------------------");
            ThirdVersion(textForFind);
            Console.WriteLine("---------------------------------");
            FourthVersion(textForFind);
        }
    }
}
