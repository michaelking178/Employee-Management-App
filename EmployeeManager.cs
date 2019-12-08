using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Management_App
{
    class EmployeeManager
    {
        public List<Employee> Employees { get; set; }

        public EmployeeManager()
        {
            Employees = new List<Employee>();
        }

        public void AddEmployee(string firstName, string lastName, string streetAddress, string phoneNumber, Position position)
        {
            int newId = GenerateId();
            if(newId != 0)
            {
                Employee newEmployee = new Employee(GenerateId(), firstName, lastName, streetAddress, phoneNumber, position);
                Employees.Add(newEmployee);
                return;
            }
            //TODO: show message, failed to create Employee.
        }

        public void RemoveEmployee(int employeeID)
        {
            Employee employeeToRemove = Employees.Find(employee => employee.Id == employeeID);
            Employees.Remove(employeeToRemove);
        }

        private int GenerateId()
        {
            Random rand = new Random();
            int newId = rand.Next(11111, 99999);

            for (int i = 0; i < Employees.Count; i++)
            {
                int attempts = 0;

                int idToCheck = Employees[i].Id;
                if (idToCheck == newId)
                {
                    newId = rand.Next(11111, 99999);
                    i = 0;
                    attempts++;
                }
                if(attempts >= 5)
                {
                    //TODO: message that max attempts reached without success.
                    break;
                }
            }

            return newId;
        }
    }
}
