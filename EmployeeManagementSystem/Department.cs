using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagementSystem
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }
        public string Location { get; set; }
        public void DisplayInfo()
        {
            Console.WriteLine($"Department:{DepartmentName}, Location:{Location}");
        }

    }
}
