using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EmployeeManagementSystem
{
    public class Employee
    {
        private string _name;
        private double _salary;

        public Department Department { get; set; }

        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name Cannot be Empty");
                return;
            }
            _name = name;
        }
        public void SetSalary(double salary)
        {
            if (salary < 0)
            {
                Console.WriteLine("salary cannot be negitive");
                return;
            }
            _salary = salary;
            
        }
        public string GetName() => _name;
        public double GetSalary() => _salary;

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Employee:{_name},Salary:{_salary}");
        }
    }
}
