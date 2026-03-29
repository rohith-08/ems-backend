using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace EmployeeManagementSystem
{
    public class Employee: BaseEmployee, IEmployee
    {
        private double _salary;
        public void SetSalary(double salary)
        {
            if (salary < 0)
            {
                Console.WriteLine("salary cannot be negitive");
                return;
            }
            _salary = salary;
            
        }      
        public double GetSalary() => _salary;

        public override void DisplayInfo()
        {
            Console.WriteLine($"Employee:{GetName()},Salary:{_salary}");
        }

       public double CalculateSalary()
        {
            return _salary;
        }


    }
}
