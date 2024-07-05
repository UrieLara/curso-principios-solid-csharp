using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenClose
{
    public abstract class Employee : IEmployee
    {
        public string Fullname { get; set; }
        public int HoursWorked { get; set; }

        public abstract decimal CalculateSalaryMonthly();

        public decimal CalculateSalaryYearly()
        {
            decimal salaryYear = CalculateSalaryMonthly()*12;
            return salaryYear;   
        }
    }

    
}