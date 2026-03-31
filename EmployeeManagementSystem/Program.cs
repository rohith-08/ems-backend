using EmployeeManagementSystem;
namespace EmployeeManagementSystem
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            await LoadEmployeesAsync();
            await SaveEmployeesAsync();
            int count = await GetEmployeeCountAsync();
            Console.WriteLine("$Total Employees: {count}");
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
            Console.WriteLine("Saving employees from data base....");
            await Task.Delay(1000);
            Console.WriteLine("Employees saved successfully!");
        }

        static async Task<int> GetEmployeeCountAsync()
        {
            Console.WriteLine("Fetching employeee count....");
            await Task.Delay(1500);
            return 5;
        }
      }
}
