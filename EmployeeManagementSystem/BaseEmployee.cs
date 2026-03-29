using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeManagementSystem
{
   public  abstract class BaseEmployee
    {
        private string _name;
        public void SetName(string name)
        {
            if (string.IsNullOrEmpty(name))
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
}
