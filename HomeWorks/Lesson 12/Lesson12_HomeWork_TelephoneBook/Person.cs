using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_HomeWork_TelephoneBook
{
    public class Person
    {
        private string surName;
        private string name;
        public Person(string surName, string name)
        {
            this.surName = surName;
            this.name = name;
        }   
        public string GetInfo()
        {
            return $"{ surName} {name}";
        }
        public bool FindBySurName(string sFind)
        {
            return surName.ToLower().Contains(sFind.ToLower());
        }
        public bool FindByName(string sFind)
        {
            return name.ToLower().Contains(sFind.ToLower());
        }
    }
}
