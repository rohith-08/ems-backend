
namespace EmployeeManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Employee e1 = new Employee();
            e1.SetName("Rohith");
            e1.SetSalary(30000);
            e1.SetDepartmentName("IT");
            employees.Add(e1);

            Employee e2 = new Employee();
            e2.SetName("Suresh");
            e2.SetSalary(60000);
            e2.SetDepartmentName("HR");
            employees.Add(e2);

            Employee e3 = new Employee();
            e3.SetName("Priya");
            e3.SetSalary(45000);
            e3.SetDepartmentName("IT");
            employees.Add(e3);

            Employee e4 = new Employee();
            e4.SetName("Kiran");
            e4.SetSalary(75000);
            e4.SetDepartmentName("Finance");
            employees.Add(e4);

            Employee e5 = new Employee();
            e5.SetName("Anjali");
            e5.SetSalary(35000);
            e5.SetDepartmentName("HR");
            employees.Add(e5);

            var result = from e in employees where e.GetSalary() > 40000 select e;
            Console.WriteLine("\n-- Employees with Salary above 40000 --");

            foreach (var e in result)
            {
                e.DisplayInfo();
            }
            Console.WriteLine("Day 4 of project Done!");


            var result1 = from e in employees orderby e.GetSalary() descending select e;
            Console.WriteLine("\n-- Employees Sorted by Salary --");
            foreach(var e in result1)
            {
                e.DisplayInfo();
            }

            var result2 = employees.Select(e => e.GetName());
            Console.WriteLine("\n-- Employees Sorted by Names --");
            foreach (var e in result2)
            {
                Console.WriteLine(e);
            }
            //var result3 = from e in employees
            //              where e.GetSalary() > 40000
            //              select e;
            var count = employees.Count(e => e.GetSalary() > 40000);
            Console.WriteLine($"Employees with salary above 40000: {count}");

            Console.WriteLine("Departments are arreanged by groupby");
            var groupby = employees.GroupBy(e => e.GetDepartmentName());
            foreach (var group in groupby)
            {
                Console.WriteLine($"Department {group.Key}:-Count: ");
                foreach(var e in group)
                {
                    e.DisplayInfo();
                }

            }


            Console.WriteLine("Day 4 of project Done!");




        }
    }
}
