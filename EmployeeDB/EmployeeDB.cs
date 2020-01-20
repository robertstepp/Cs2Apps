// Robert Stepp
// TINFO 200
// Cs2Apps / EmployeeDB
///////////////////////////////
// Change History
// Date     Developer   Description
// 01202020  rstepp     File creation and initial implementation of the application
//
// References Used

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDB
{
    class EmployeeDB
    {
        private static decimal Raise(decimal salary)
        {
            decimal newSalary = salary * 1.1m;
            return Decimal.Round(newSalary, 2);
        }

        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Robert", "Stepp", 6216.92m);
            Employee employee2 = new Employee("Anniyah", "Mill", 5358.65m);
            Employee employee3 = new Employee("Savanna", "Nichols", 4317.25m);

            Console.WriteLine("Pre-Raise: ");
            Console.WriteLine($"{employee1.getFName()} {employee1.getLName()} makes ${employee1.getMSalary() * 12} a year.");

            Console.WriteLine($"{employee2.getFName()} {employee2.getLName()} makes ${employee2.getMSalary() * 12} a year.");

            Console.WriteLine($"{employee3.getFName()} {employee3.getLName()} makes ${employee3.getMSalary() * 12} a year.");

            employee1.setMSalary(Raise(employee1.getMSalary()));

            employee2.setMSalary(Raise(employee2.getMSalary()));

            employee3.setMSalary(Raise(employee3.getMSalary()));

            Console.WriteLine("\nPost-Raise: ");

            Console.WriteLine($"{employee1.getFName()} {employee1.getLName()} makes ${employee1.getMSalary() * 12} a year.");

            Console.WriteLine($"{employee2.getFName()} {employee2.getLName()} makes ${employee2.getMSalary() * 12} a year.");

            Console.WriteLine($"{employee3.getFName()} {employee3.getLName()} makes ${employee3.getMSalary() * 12} a year.");
        }
    }
}
