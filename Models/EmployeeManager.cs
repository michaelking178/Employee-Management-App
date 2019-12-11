using System;
using System.Collections.Generic;

namespace Employee_Management_App.Models
{
    class EmployeeManager
    {
        public List<Employee> Employees { get; set; }

        public EmployeeManager()
        {
            Employees = new List<Employee>();
        }

        public bool AddEmployee(string firstName, string lastName, string streetAddress, string city, string province, string postalCode, string phoneNumber, Position position)
        {
            int newId = GenerateId();
            if(newId != 0)
            {
                Employee newEmployee = new Employee(GenerateId(), firstName, lastName, streetAddress, city, province, postalCode, phoneNumber, position);
                Employees.Add(newEmployee);
                return true;
            }
            return false;
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
                    return 0;
                }
            }
            return newId;
        }
    }
}
