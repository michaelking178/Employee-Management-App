using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employee_Management_App.Models;

namespace Employee_Management_App
{
    public class Controller
    {
        private EmployeeManager employeeManager;
        private PositionManager positionManager;

        public List<Employee> employeeList;
        public List<Position> positionList;

        public MainForm mainForm { get; set; }
        public ManagePositionsForm managePositionsForm { get; set; }
        public CreatePositionForm createPositionForm { get; set; }
        public EditPositionForm editPositionForm { get; set; }

        public Controller()
        {
            employeeManager = new EmployeeManager();
            positionManager = new PositionManager();
            employeeList = employeeManager.Employees;
            positionList = positionManager.Positions;

            // Populate the database with some initial data
            PopulatePositionList();
            PopulateEmployeeList();
        }


        // Employee Management

        public void UpdateEmployeeListView()
        {
            ListView employeeListView = mainForm.employeeListView;
            employeeListView.Items.Clear();

            foreach (Employee employee in employeeList)
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

        public void AddEmployee(string firstName, string lastName, string streetAddress, string phoneNumber, Position position)
        {
            if (!employeeManager.AddEmployee(firstName, lastName, streetAddress, phoneNumber, position))
            {
                MessageBox.Show("Failed to create employee.");
            }
            UpdateEmployeeListView();
        }

        public void EditEmployee()
        {
            //TODO: Edit Employee functionality
        }

        public void RemoveEmployee(ListViewItem employee)
        {
            DialogResult confirmResult = MessageBox.Show("Are you sure you want to remove this employee? \nThis action cannot be undone.","Confirm Employee Removal", MessageBoxButtons.YesNo);
            if(confirmResult == DialogResult.Yes)
            {
                int employeeId = int.Parse(employee.SubItems[0].Text);
                employeeManager.RemoveEmployee(employeeId);
                UpdateEmployeeListView();
            }
        }


        // Position Management

        public void UpdatePositionListView()
        {
            ListView positionListView = managePositionsForm.positionListview;
            positionListView.Items.Clear();

            foreach (Position position in positionList)
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

            foreach (Position position in positionList)
            {
                if (title == position.Title)
                {
                    MessageBox.Show("A position with that title already exists.", "Create Position Error");
                    return;
                }
            }

            if (!int.TryParse(_salary, out salary))
            {
                MessageBox.Show("Please enter only numbers in the Salary field.", "Create Position Error");
                return;
            }

            salary = int.Parse(_salary);
            positionManager.AddPosition(title, salary);
            UpdatePositionListView();
            createPositionForm.Close();
        }

        public void EditPosition()
        {
            //TODO: Edit Position functionality
            MessageBox.Show("Not yet implemented. Sorry!");
        }

        public void RemovePosition(ListViewItem _position)
        {
            DialogResult confirmResult = MessageBox.Show("Are you sure you want to remove this position? \nThis action cannot be undone.", "Confirm Position Removal", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                string titleToRemove = _position.SubItems[0].Text;
                foreach (Employee employee in employeeList)
                {
                    if (employee.Position.Title == titleToRemove)
                    {
                        MessageBox.Show("Cannot remove positions held by current employees. \nPlease remove or edit the employees before removing the position.", "Remove Position Error");
                        return;
                    }
                }

                foreach (Position position in positionList)
                {
                    if (position.Title == titleToRemove)
                    {
                        positionList.Remove(position);
                        UpdatePositionListView();
                        return;
                    }
                }
            }
        }


        // Initial data population, for testing

        private void PopulatePositionList()
        {
            positionManager.AddPosition("CEO", 350000);
            positionManager.AddPosition("Chief Sales Officer", 180000);
            positionManager.AddPosition("Marketing Manager", 120000);
            positionManager.AddPosition("Department Manager", 65000);
            positionManager.AddPosition("Assistant Manager", 40000);
            positionManager.AddPosition("Sales Clerk", 22000);
        }
        private void PopulateEmployeeList()
        {
            employeeManager.AddEmployee("John", "Eden", "45 Mulberry Dr. Winnipeg MB Canada R3L 2T1", "204-448-8235", positionManager.GetPosition("CEO"));
            employeeManager.AddEmployee("Arthur", "Morgan", "115-B LaColme Cres. Saskatoon SK Canada S6H 4G2", "306-945-7865", positionManager.GetPosition("Marketing Manager"));
            employeeManager.AddEmployee("Sandra", "Pence", "98B Terrence Rd. Gatineau QC Canada H9T 2F2", "514-354-1468", positionManager.GetPosition("Chief Sales Officer"));
            employeeManager.AddEmployee("Miles", "Davies", "5793 Haliburton St. Pembrooke ON Canada T4F 3D2", "486-451-9788", positionManager.GetPosition("Department Manager"));
        }
    }
}
