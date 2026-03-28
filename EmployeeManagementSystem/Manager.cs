using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagementSystem
{
    public class Manager:Employee
    {
        private int _teamsize;
        public void SetTeamSize(int size)
        {
           _teamsize = size;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Team size:{_teamsize}");
        }
    }
}
