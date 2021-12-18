using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР8
{
    class EmployeeWithHourlyPay : EmployeeWithASalary
    {
        public EmployeeWithHourlyPay(string nemes, string surname, string miiiiiidleNamesASS) : base(nemes, surname, miiiiiidleNamesASS)
        {
            Name = nemes;
            Surname = surname;
            MiddleName = miiiiiidleNamesASS;
        }
        public int ComparisonBySurname(object obj) 
        {
            EmployeeWithHourlyPay surnameMale = (EmployeeWithHourlyPay)obj;
            return Surname.Length > surnameMale.Surname.Length ? 1 : Surname.Length < surnameMale.Surname.Length ? -1 : 0; 
        }

        public EmployeeWithHourlyPay smallClone()
        {
            return (EmployeeWithHourlyPay)MemberwiseClone();
        }

        public object Clonirovanie()
        {
            return new EmployeeWithHourlyPay(Name, Surname, MiddleName); 
        }

        public string InformationInspection()
        {
            return InformationAboutAnEmployeeWithAWarehouse();
        }

        internal string ShowInfo()
        {
            throw new NotImplementedException();
        }

    }
}
