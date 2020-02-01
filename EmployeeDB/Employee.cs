// TODO Add comments

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDB
{
    class Employee
    {

        // Stores the first name
        private string firstName;

        // Stores the last name
        private string lastName;

        // Stores salary
        private decimal monthlySalary = 0m;

        // Constructor for the employee class
        public Employee(string fName, string lName, decimal salary)
        {
            firstName = fName;
            lastName = lName;
            monthlySalary = salary;
        }

        // Returns the first name
        public string getFName()
        {
            return firstName;
        }

        // Returns last name
        public string getLName()
        {
            return lastName;
        }

        // Returns salary as decimal
        public decimal getMSalary()
        {
            return monthlySalary;
        }

        // Allows for the reset of the first name
        public void setFName(string fName)
        {
            firstName = fName;
        }

        // Allows for the reset of the last name
        public void setLName(string lName)
        {
            lastName = lName;
        }

        // Allows for raise or reduction of salary
        public void setMSalary(decimal salary)
        {
            if (salary >= 0)
            {
                monthlySalary = salary;
            }
        }
    }
}
