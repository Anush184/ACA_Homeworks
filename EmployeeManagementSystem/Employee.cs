using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public class Employee: IEnumerable<Employee>
    {
        private Employee[] _employees;
        private int _id;
        private string _name;

        [SalaryValidation(500, 5000)]
        private  double _salary;
        public Employee() {}

        public Employee(int id, string name, double salary)
        {
            _id = id;
            _name = name;
            _salary = salary;
            _employees = Array.Empty<Employee>();
        }

        public int Id { 
            get { return _id; }
            set { _id = value; }
        }
        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }

        public double Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public IEnumerator<Employee> GetEnumerator()
        {
            return ((IEnumerable<Employee>)_employees).GetEnumerator();
        }

        public override string ToString()
        {
            return $"Employee data -  Id: {Id}, Name: {Name}, Salary: {Salary} ";
        }
        public void AddEmployee(Employee employee)
        {
            if (employee == null)
            {
                throw new ArgumentNullException(nameof(employee), "Employee is null.");
            }
            else
            {
                if (!_employees.Any(e => e.Equals(employee)) && !Equals(employee))
                {
                    _employees = _employees.Append(employee).ToArray();
                }
            }
        }

        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }

            Employee otherEmployee = (Employee)obj;
            return Id == otherEmployee.Id;

        }
        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
