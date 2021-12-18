using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР8
{
    class EmployeeWithASalary
    {
        public string Name { get; set; }
        public string Surname { get; set; } 
        public string MiddleName { get; set; } 
        public EmployeeWithASalary(string names, string surname, string MiddleNames)
        {
            Name = names;
            Surname = surname;
            MiddleName = MiddleNames;
        }
        public string InformationAboutAnEmployeeWithAWarehouse()
        {
            return $"{Surname} {Name} {MiddleName}";
        }
        public string AccrualOfSalary()
        {
            return "Начислено 15 000 рублей";
        }

        internal string ShowMaleInfo()
        {
            throw new NotImplementedException();
        }

        internal string GetReaction()
        {
            throw new NotImplementedException();
        }
        public int CompareTo(object obj) //сравнение по количеству символов
        {
            EmployeeWithASalary surnameMale = (EmployeeWithASalary)obj;
            return Surname.Length > surnameMale.Surname.Length ? 1 : Surname.Length < surnameMale.Surname.Length ? -1 : 0; //с помощью подсказок
        }
    }
}
