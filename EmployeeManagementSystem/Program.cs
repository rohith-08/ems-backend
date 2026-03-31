namespace EmployeeManagementSystem
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            // Day 2 - OOP
            Employee emp = new Employee();
            emp.SetName("Rohith");
            emp.SetSalary(30000);
            emp.DisplayInfo();

            Manager mgr = new Manager();
            mgr.SetName("Suresh");
            mgr.SetSalary(100000);
            mgr.SetTeamSize(5);
            mgr.DisplayInfo();

            // Day 5 - Async
            await LoadEmployeesAsync();
            await SaveEmployeesAsync();

            int count = await GetEmployeeCountAsync();
            Console.WriteLine($"Total Employees: {count}");

            Console.WriteLine("\n Day 5 Completed!!!");
        }

        static async Task LoadEmployeesAsync()
        {
            Console.WriteLine("Loading employee from database...");
            await Task.Delay(2000);
            Console.WriteLine("Employee loaded successfully!");
        }

        static async Task SaveEmployeesAsync()
        {
            Console.WriteLine("Saving employees...");
            await Task.Delay(1000);
            Console.WriteLine("Employees saved successfully!");
        }

        static async Task<int> GetEmployeeCountAsync()
        {
            Console.WriteLine("Fetching employee count...");
            await Task.Delay(1500);
            return 5;
        }
    }
}