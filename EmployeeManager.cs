using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Management_Application
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
            Employee newEmployee = new Employee(GenerateId(), firstName, lastName, streetAddress, phoneNumber, position);

            Employees.Add(newEmployee);
        }

        public void RemoveEmployee(string firstName, string lastName)
        {
            // Remove Employee   
        }

        private int GenerateId()
        {
            Random rand = new Random();
            int newId = rand.Next(11111, 99999);

            for (int i = 0; i < Employees.Count; i++)
            {
                int idToCheck = Employees[i].Id;
                if (idToCheck == newId)
                {
                    newId = rand.Next(11111, 99999);
                    i = 0;
                }
            }

            return newId;
        }
    }
}
