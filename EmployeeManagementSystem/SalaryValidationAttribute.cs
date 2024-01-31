using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = true)]
    public class SalaryValidationAttribute:ValidationAttribute
    {
        public SalaryValidationAttribute(double minSalary, double maxSalary)
        {

            MinSalary = minSalary;
            MaxSalary = maxSalary;
        }
        public double MinSalary { get; set; }
        public double MaxSalary { get; set; }

        public override bool IsValid(object? value)
        {
            if (value == null)
            {
                throw new ArgumentNullException("value", message:"Value is null");
            }
            else if (value is double salary)
            {
                return salary >= MinSalary && salary <= MaxSalary;
            }
            return false;
           
        }
    }
}
