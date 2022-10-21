using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_HomeWork_TelephoneBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Avramenko", "Oleksandr");
            Person person2 = new Person("Avramenko", "Volodymyr");
            Person person3 = new Person("Fedoriv", "Petro");
            Person person4 = new Person("Feroriv", "Oleksandr");
            Person person5 = new Person("Snow", "John");

            TelephoneBook[] telephoneBooks =
            {
                new TelephoneBook(person1,"999999999",PhoneNumberType.mobile),
                new TelephoneBook(person1,"888888888",PhoneNumberType.official),
                new TelephoneBook(person2,"777777777",PhoneNumberType.work),
                new TelephoneBook(person2,"654532168",PhoneNumberType.official),
                new TelephoneBook(person3,"546840658",PhoneNumberType.work),
                new TelephoneBook(person3,"654849849",PhoneNumberType.mobile),
                new TelephoneBook(person4,"613058145",PhoneNumberType.mobile),
                new TelephoneBook(person5,"565484984",PhoneNumberType.official),
                new TelephoneBook(person5,"358989840",PhoneNumberType.work),
            };

            foreach (TelephoneBook telephoneBook in telephoneBooks)
            {
                Console.WriteLine(telephoneBook.GetInfo());
            }
            while (true)
            {
                Console.WriteLine();

                Console.WriteLine("What do you want?");
                Console.WriteLine("1. Search by surname");
                Console.WriteLine("2. Search by name");
                Console.WriteLine("3. Search by phone number");
                Console.WriteLine("4. Search by phone type(mobile, work, official)");
                string chooseOperation = Console.ReadLine();

                Console.WriteLine("Enter value:");
                string sFind = Console.ReadLine();

                bool isResult = false;
                foreach (TelephoneBook telephoneBook in telephoneBooks)
                {
                    switch (chooseOperation)
                    {
                        case "1":
                            if (telephoneBook.FindBySurName(sFind))
                            {
                                Console.WriteLine(telephoneBook.GetInfo());
                                isResult = true;
                            }
                            break;
                        case "2":
                            if (telephoneBook.FindByName(sFind))
                            {
                                Console.WriteLine(telephoneBook.GetInfo());
                                isResult = true;
                            }
                            break;
                        case "3":
                            if (telephoneBook.FindByNumber(sFind))
                            {
                                Console.WriteLine(telephoneBook.GetInfo());
                                isResult = true;
                            }
                            break;
                        case "4":
                            if (telephoneBook.FindByType((PhoneNumberType)System.Enum.Parse(typeof(PhoneNumberType), sFind)))
                            {
                                Console.WriteLine(telephoneBook.GetInfo());
                                isResult = true;
                            }
                            break;
                        default:
                            Console.WriteLine("Incorrect choose. Try again");
                            break;
                    }
                }
                if (!isResult)
                {
                    Console.WriteLine("No results.");
                }
                Console.WriteLine("Do you want to try again? y/n");
                if (Console.ReadLine() == "y")
                {
                    Console.WriteLine();
                }
                else
                {
                    return;
                }
            }
        }

    }
}
