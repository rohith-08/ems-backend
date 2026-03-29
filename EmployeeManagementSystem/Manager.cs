using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagementSystem
{
    public class Manager:BaseEmployee,IEmployee
    {
        private double _salary;
        private int _teamsize;

        public void SetSalary(double salary)
        {
            if (salary < 0)
            {
                Console.WriteLine("Salary cannot be negative");
                return;
            }
            _salary = salary;
        }
        public void SetTeamSize(int size)
        {
           _teamsize = size;
        }
        public override void DisplayInfo()
        {

            Console.WriteLine($"Employee:{GetName()},Salary:{_salary}Team size:{_teamsize}");
        }
        public double CalculateSalary()
        {
            return _salary + (_salary * 0.20);
        }
    }
}
