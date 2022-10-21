using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson12_HomeWork_TelephoneBook
{
    public struct TelephoneBook
    {
        private Person person;
        private string phoneNumber;
        private PhoneNumberType phoneNumberType;

        public TelephoneBook(Person person, string phoneNumber, PhoneNumberType phoneNumberType)
        {
            this.person = person;
            this.phoneNumber = phoneNumber;
            this.phoneNumberType = phoneNumberType;
        }
        public string GetInfo()
        {
            return $"Abonent: {person.GetInfo()}, {phoneNumberType} phone - {phoneNumber}";
        }
        public bool FindBySurName(string sFind)
        {
            return person.FindBySurName(sFind);
        }
        public bool FindByName(string sFind)
        {
            return person.FindByName(sFind);
        }
        public bool FindByNumber(string sFind)
        {
            return phoneNumber.ToLower().Contains(sFind.ToLower());
        }
        public bool FindByType(PhoneNumberType _phoneNumberType)
        {
            return phoneNumberType == _phoneNumberType;
        }
    }
}
