
namespace EmployeeManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee emp = new Employee();
            //emp.SetSalary(30000);
            //emp.DisplayInfo();
            //emp.CalculateSalary();
            //Manager mgr = new Manager();
            //mgr.SetName("Suresh");
            //mgr.SetSalary(100000);
            //mgr.SetTeamSize(5);
            //mgr.DisplayInfo();
            IEmployee emp = new Employee();
            ((Employee)emp).SetName("Rohith");
            ((Employee)emp).SetSalary(50000);
            ((Employee)emp).CalculateSalary();
            emp.DisplayInfo();
            Console.WriteLine($"The Calculated Salary for Employee is : {((Employee)emp).CalculateSalary()}");
            
            IEmployee mgr = new Manager();
            ((Manager)mgr).SetName("Suresh");
            ((Manager)mgr).SetSalary(80000);
            ((Manager)mgr).CalculateSalary();
            ((Manager)mgr).SetTeamSize(5);

            mgr.DisplayInfo();

            Console.WriteLine($"The Calculated Salary for Employee is : {((Manager)mgr).CalculateSalary()}");




            Console.WriteLine("Day 3 of project Done!");
        }
    }
}
