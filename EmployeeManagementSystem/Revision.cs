using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagementSystem
{
    public class Revision
    {
        public interface IEmployee
        {
            void DisplayInfo();
            double CalculateSalary();
        }
        public abstract class BaseEmployee
        {
            private string _name;
            public void SetName(string name)
            {
                if(string.IsNullOrEmpty(name))
                {
                    Console.WriteLine("Name Cannot be Empty");
                    return;
                }
                _name = name;
            }
            public string GetName()
            {
                return _name;
            }

            public abstract void DisplayInfo();

        }
        public class Employee : BaseEmployee, IEmployee
        {
          private double _salary;
          public void SetSalary(double salary)
            {
                if (salary < 0)
                {
                    Console.WriteLine("Salary cannot be negitive");
                    return;
                }
                _salary = salary;
            }
            public double GetSalary() => _salary;
            public double CalculateSalary()
            {
                return _salary;
            }

            public override void DisplayInfo()
            {
                Console.WriteLine($"Employee:{GetName()} and Salary:{GetSalary()} and Calculate Salary {CalculateSalary()}");
            }

        }
        public class Manager : BaseEmployee, IEmployee
        {
            private double _salary;
            private int _teamSize;
            public void SetSalary(double salary)
            {
                if (salary < 0)
                {
                    Console.WriteLine("Salary cannot be negitive");
                    return;
                }
                _salary = salary;
            
            }
            public double GetSalary() => _salary;
            public void SetTeamSize(int size)
            {
                _teamSize = size;
            }
            public double CalculateSalary()
            {
                return  _salary + (_salary * 0.20);

            }
            public override void DisplayInfo()
            {
                Console.WriteLine($"Manager:{GetName()} Salary:{GetSalary()}  CalculatedSalary:{CalculateSalary()}");
            }

        }
        public class RevisionProgram
        {
            public static async Task RunRevision()
            {
                List<Employee> employees = new List<Employee>();
                Employee e1 = new Employee();
                e1.SetName("Rohith");
                e1.SetSalary(70000);
                employees.Add(e1);

                Employee e2 = new Employee();
                e2.SetName("Ramu");
                e2.SetSalary(60000);
                employees.Add(e2);

                Employee e3 = new Employee();
                e3.SetName("ASHOK");
                e3.SetSalary(45000);
                employees.Add(e3);

                Console.WriteLine("--------------SALARY ABOVE 4OK----------");
                var filtered = employees.Where(e => e.GetSalary() > 40000);
                foreach (var e in filtered)
                {
                    e.DisplayInfo();
                }
                Console.WriteLine("\n-------------Sorted by Salary----------");
                var sorted = employees.OrderByDescending(E => E.GetSalary());
                foreach (var E in sorted)
                {
                    E.DisplayInfo();

                }

                await LoadDataAsync();
                Console.WriteLine("\nWeek 1 Revision Complete ");


            }
            static async Task LoadDataAsync()
            {
                Console.WriteLine("Loading data from database...");
                await Task.Delay(2000);
                Console.WriteLine("Data loaded successfully!");
            }
        }


    }
    
}
