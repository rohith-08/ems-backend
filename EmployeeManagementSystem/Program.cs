using EmployeeManagementSystem;
namespace EmployeeManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.SetName("Rohith");
            emp.SetSalary(30000);
            emp.DisplayInfo();
            Manager mgr = new Manager();
            mgr.SetName("Suresh");
            mgr.SetSalary(100000);
            mgr.SetTeamSize(5);
            mgr.DisplayInfo();

            Console.WriteLine("Day 2 of project Done!");
        }
    }
}
