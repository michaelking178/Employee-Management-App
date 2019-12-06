using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Management_Application
{
    public class Position
    {
        public string Title { get; set; }
        public int Salary { get; set; }

        public Position(string title, int salary)
        {
            Title = title;
            Salary = salary;
        }
    }
}
