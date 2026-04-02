using System;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    internal class Program:Revision
    {
        static async Task Main(string[] args)
        {
            await RevisionProgram.RunRevision();
        }

    }
}
