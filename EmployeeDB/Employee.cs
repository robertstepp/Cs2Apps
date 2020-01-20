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
    class Employee
    {

        private string firstName;

        private string lastName;

        private decimal monthlySalary = 0m;

        public Employee(string fName, string lName, decimal salary)
        {
            firstName = fName;
            lastName = lName;
            monthlySalary = salary;
        }

        public string getFName()
        {
            return firstName;
        }

        public string getLName()
        {
            return lastName;
        }

        public decimal getMSalary()
        {
            return monthlySalary;
        }

        public void setFName(string fName)
        {
            firstName = fName;
        }

        public void setLName(string lName)
        {
            lastName = lName;
        }

        public void setMSalary(decimal salary)
        {
            if (salary >= 0)
            {
                monthlySalary = salary;
            }
        }
    }
}
