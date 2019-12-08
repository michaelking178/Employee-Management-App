using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_App
{
    public class Controller
    {
        private EmployeeManager _EmployeeManager;
        private PositionManager _PositionManager;

        public List<Employee> EmployeeList;
        public List<Position> PositionList;

        public MainForm mainForm { get; set; }
        public ManagePositionsForm managePositionsForm { get; set; }
        public CreatePositionForm createPositionForm { get; set; }

        public Controller()
        {
            _EmployeeManager = new EmployeeManager();
            _PositionManager = new PositionManager();
            EmployeeList = _EmployeeManager.Employees;
            PositionList = _PositionManager.Positions;

            // Populate the database with some initial data
            PopulatePositionList();
            PopulateEmployeeList();
        }


        // Employee Management

        public void UpdateEmployeeListView()
        {
            ListView employeeListView = mainForm.employeeListView;
            employeeListView.Items.Clear();

            foreach (Employee employee in EmployeeList)
            {
                employeeListView.Items.Add(new ListViewItem(new string[] {
                    employee.Id.ToString(),
                    employee.FullName,
                    employee.StreetAddress,
                    employee.PhoneNumber,
                    employee.Position.Title,
                    "$ " + employee.Position.Salary.ToString()
                }));
            }
        }

        public void RemoveEmployee(ListViewItem employee)
        {
            int employeeId = int.Parse(employee.SubItems[0].Text);
            _EmployeeManager.RemoveEmployee(employeeId);
        }

        public void AddEmployee()
        {
            //TODO: Add Employee functionality
        }

        public void EditEmployee()
        {
            //TODO: Edit Employee functionality
        }


        // Position Management

        public void UpdatePositionListView()
        {
            ListView positionListView = managePositionsForm.positionListview;
            positionListView.Items.Clear();

            foreach (Position position in PositionList)
            {
                positionListView.Items.Add(new ListViewItem(new string[]
                {
                    position.Title,
                    "$ " + position.Salary.ToString()
                })); ;
            }
        }

        public void CreatePosition(string _title, string _salary)
        {
            string title = _title;
            int salary;

            foreach (Position position in PositionList)
            {
                if (title == position.Title)
                {
                    MessageBox.Show("A position with that title already exists.");
                    return;
                }
            }

            if (!int.TryParse(_salary, out salary))
            {
                MessageBox.Show("Please enter only numbers in the Salary field.");
                return;
            }

            salary = int.Parse(_salary);
            _PositionManager.AddPosition(title, salary);
            UpdatePositionListView();
            createPositionForm.Close();
        }


        // Initial data population, for testing

        private void PopulatePositionList()
        {
            _PositionManager.AddPosition("CEO", 350000);
            _PositionManager.AddPosition("Chief Sales Officer", 180000);
            _PositionManager.AddPosition("Marketing Manager", 120000);
            _PositionManager.AddPosition("Department Manager", 65000);
            _PositionManager.AddPosition("Assistant Manager", 40000);
            _PositionManager.AddPosition("Sales Clerk", 22000);
        }
        private void PopulateEmployeeList()
        {
            _EmployeeManager.AddEmployee("John", "Eden", "45 Mulberry Dr. Winnipeg MB Canada R3L 2T1", "204-448-8235", _PositionManager.GetPosition("CEO"));
            _EmployeeManager.AddEmployee("Arthur", "Morgan", "115-B LaColme Cres. Saskatoon SK Canada S6H 4G2", "306-945-7865", _PositionManager.GetPosition("Marketing Manager"));
            _EmployeeManager.AddEmployee("Sandra", "Pence", "98B Terrence Rd. Gatineau QC Canada H9T 2F2", "514-354-1468", _PositionManager.GetPosition("Chief Sales Officer"));
            _EmployeeManager.AddEmployee("Miles", "Davies", "5793 Haliburton St. Pembrooke ON Canada T4F 3D2", "486-451-9788", _PositionManager.GetPosition("Department Manager"));
        }
    }
}
