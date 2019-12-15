using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employee_Management_App.Models;
using Employee_Management_App.Views;

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
        public AddPositionForm createPositionForm { get; set; }
        public EditPositionForm editPositionForm { get; set; }
        public AddEmployeeForm addEmployeeForm { get; set; }
        public EditEmployeeForm editEmployeeForm { get; set; }

        private int employeeToEditId;
        private string positionToEditTitle;

        private int currentEmployeeSortIndex;
        private bool employeeIsAscending = false;

        private int currentPositionSortIndex;
        private bool positionIsAscending = false;

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


        // Miscellaneous Utilities

        public void SortColumn(ListView listView, int columnIndex)
        {
            if (listView == mainForm.employeeListView)
            {
                SortEmployeeColumn(columnIndex);
                currentEmployeeSortIndex = columnIndex;
            }
            else if (listView == managePositionsForm.positionListView)
            {
                SortPositionColumn(columnIndex);
                currentPositionSortIndex = columnIndex;
            }

        }


        // Employee Management

        public void UpdateEmployeeListView()
        {
            ListView employeeListView = mainForm.employeeListView;
            employeeListView.Items.Clear();

            foreach (Employee employee in employeeList)
            {
                string employeeFullAddress = employee.StreetAddress + " " + employee.City + " " + employee.Province + " " + employee.PostalCode;
                string employeeFullName = employee.LastName + ", " + employee.FirstName;
                employeeListView.Items.Add(new ListViewItem(new string[] {
                    employee.Id.ToString(),
                    employeeFullName,
                    employeeFullAddress,
                    employee.PhoneNumber,
                    employee.Position.Title,
                    "$ " + employee.Position.Salary.ToString()
                }));
            }
        }

        public void AddEmployee(string firstName, string lastName, string streetAddress, string city, string province, string postalCode, string phoneNumber, string positionTitle)
        {
            Position position = positionList.Find(Position => Position.Title == positionTitle);

            if (!employeeManager.AddEmployee(firstName, lastName, streetAddress, city, province, postalCode, phoneNumber, position))
            {
                MessageBox.Show("Failed to create employee.");
            }
            UpdateEmployeeListView();
        }

        public void SetEmployeeToEdit(ListViewItem employee)
        {
            employeeToEditId = int.Parse(employee.SubItems[0].Text);
        }

        public void EditEmployee(string firstName, string lastName, string streetAddress, string city, string province, string postalCode, string phoneNumber, string positionTitle)
        {
            Employee employeeToEdit = employeeList.Find(Employee => Employee.Id == employeeToEditId);
            Position newPosition = positionList.Find(Position => Position.Title == positionTitle);

            employeeToEdit.FirstName = firstName;
            employeeToEdit.LastName = lastName;
            employeeToEdit.StreetAddress = streetAddress;
            employeeToEdit.City = city;
            employeeToEdit.Province = province;
            employeeToEdit.PostalCode = postalCode;
            employeeToEdit.PhoneNumber = phoneNumber;
            employeeToEdit.Position = newPosition;

            UpdateEmployeeListView();
            editEmployeeForm.Close();
        }

        public void RemoveEmployee(ListViewItem employee)
        {
            DialogResult confirmResult = MessageBox.Show("Are you sure you want to remove this employee? \nThis action cannot be undone.", "Confirm Employee Removal", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                int employeeId = int.Parse(employee.SubItems[0].Text);
                employeeManager.RemoveEmployee(employeeId);
                UpdateEmployeeListView();
            }
        }

        public void PopulateEditEmployeeForm()
        {
            Employee employeeToEdit = employeeList.Find(Employee => Employee.Id == employeeToEditId);
            editEmployeeForm.firstNameTextBox.Text = employeeToEdit.FirstName;
            editEmployeeForm.lastNameTextBox.Text = employeeToEdit.LastName;
            editEmployeeForm.streetAddressTextBox.Text = employeeToEdit.StreetAddress;
            editEmployeeForm.cityTextBox.Text = employeeToEdit.City;
            editEmployeeForm.provinceComboBox.SelectedItem = employeeToEdit.Province;
            editEmployeeForm.postalCodeTextBox.Text = employeeToEdit.PostalCode;
            editEmployeeForm.phoneNumberTextBox.Text = employeeToEdit.PhoneNumber;
            editEmployeeForm.positionComboBox.SelectedItem = employeeToEdit.Position.Title;
        }

        private void SortEmployeeColumn(int columnIndex)
        {
            // Toggle ascending/descending
            if (columnIndex == currentEmployeeSortIndex)
            {
                employeeIsAscending = !employeeIsAscending;
            }

            if (employeeIsAscending)
            {
                employeeList = SortEmployeesAscending(columnIndex);
            }
            else
            {
                employeeList = SortEmployeesDescending(columnIndex);
            }
            UpdateEmployeeListView();
        }

        private List<Employee> SortEmployeesAscending(int columnIndex)
        {
            switch (columnIndex)
            {
                case 0:
                    return employeeList.OrderBy(employee => employee.Id).ToList();
                case 1:
                    return employeeList.OrderBy(employee => employee.LastName).ToList();
                case 2:
                    return employeeList.OrderBy(employee => employee.StreetAddress).ToList();
                case 3:
                    return employeeList.OrderBy(employee => employee.PhoneNumber).ToList();
                case 4:
                    return employeeList.OrderBy(employee => employee.Position.Title).ToList();
                case 5:
                    return employeeList.OrderBy(employee => employee.Position.Salary).ToList();
                default:
                    MessageBox.Show("Error sorting column.", "Sort Column Error");
                    return employeeList;
            }
        }

        private List<Employee> SortEmployeesDescending(int columnIndex)
        {
            switch (columnIndex)
            {
                case 0:
                    return employeeList.OrderByDescending(employee => employee.Id).ToList();
                case 1:
                    return employeeList.OrderByDescending(employee => employee.LastName).ToList();
                case 2:
                    return employeeList.OrderByDescending(employee => employee.StreetAddress).ToList();
                case 3:
                    return employeeList.OrderByDescending(employee => employee.PhoneNumber).ToList();
                case 4:
                    return employeeList.OrderByDescending(employee => employee.Position.Title).ToList();
                case 5:
                    return employeeList.OrderByDescending(employee => employee.Position.Salary).ToList();
                default:
                    MessageBox.Show("Cannot sort employee list.", "Sort Column Error");
                    return employeeList;
            }
        }

        // Position Management

        public void UpdatePositionListView()
        {
            ListView positionListView = managePositionsForm.positionListView;
            positionListView.Items.Clear();

            foreach (Position position in positionList)
            {
                positionListView.Items.Add(new ListViewItem(new string[]
                {
                    position.Title,
                    "$ " + position.Salary.ToString()
                }));
            }
        }

        public void AddPosition(string title, string _salary)
        {
            foreach (Position position in positionList)
            {
                if (title.ToLower() == position.Title.ToLower())
                {
                    MessageBox.Show("A position with that title already exists.", "Create Position Error");
                    return;
                }
            }

            if (!int.TryParse(_salary, out _))
            {
                MessageBox.Show("Please enter only numbers in the Salary field.", "Create Position Error");
                return;
            }

            int salary = int.Parse(_salary);
            positionManager.AddPosition(title, salary);
            UpdatePositionListView();
            createPositionForm.Close();
        }

        public void SetPositionToEdit(ListViewItem position)
        {
            positionToEditTitle = position.SubItems[0].Text;
        }

        public void EditPosition(string newTitle, string newSalary)
        {
            Position positionToEdit = positionList.Find(Position => Position.Title == positionToEditTitle);

            if (!int.TryParse(newSalary, out _))
            {
                MessageBox.Show("Please enter only numbers in the Salary field.");
                return;
            }

            positionToEdit.Title = newTitle;
            positionToEdit.Salary = int.Parse(newSalary);

            UpdatePositionListView();
            editPositionForm.Close();
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

        public void PopulateEditPositionForm()
        {
            Position positionToEdit = positionList.Find(Position => Position.Title == positionToEditTitle);
            editPositionForm.editTitleTextBox.Text = positionToEdit.Title;
            editPositionForm.editSalaryTextBox.Text = positionToEdit.Salary.ToString();
        }

        private void SortPositionColumn(int columnIndex)
        {
            if (columnIndex == currentPositionSortIndex)
            {
                positionIsAscending = !positionIsAscending;
            }
            if (positionIsAscending)
            {
                positionList = SortPositionsAscending(columnIndex);
            }
            else
            {
                positionList = SortPositionsDescending(columnIndex);
            }
            UpdatePositionListView();
        }

        private List<Position> SortPositionsAscending(int columnIndex)
        {
            switch (columnIndex)
            {
                case 0:
                    return positionList.OrderBy(Position => Position.Title).ToList();
                case 1:
                    return positionList.OrderBy(Position => Position.Salary).ToList();
                 default:
                    MessageBox.Show("Error sorting column.", "Sort Column Error");
                    return positionList;
            }
        }

        private List<Position> SortPositionsDescending(int columnIndex)
        {
            switch (columnIndex)
            {
                case 0:
                    return positionList.OrderByDescending(Position => Position.Title).ToList();
                case 1:
                    return positionList.OrderByDescending(Position => Position.Salary).ToList();
                default:
                    MessageBox.Show("Error sorting column.", "Sort Column Error");
                    return positionList;
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
            employeeManager.AddEmployee("John", "Eden", "45 Mulberry Dr.", "Winnipeg", "Manitoba", "R3L 2T1", "204-448-8235", positionManager.GetPosition("CEO"));
            employeeManager.AddEmployee("Arthur", "Morgan", "115-B LaColme Cres.", "Saskatoon", "Saskatchewan", "S6H 4G2", "306-945-7865", positionManager.GetPosition("Marketing Manager"));
            employeeManager.AddEmployee("Sandra", "Pence", "98B Terrence Rd.", "Gatineau", "Quebec", "H9T 2F2", "514-354-1468", positionManager.GetPosition("Chief Sales Officer"));
            employeeManager.AddEmployee("Miles", "Davies", "5793 Haliburton St.", "Pembrooke", "Ontario", "T4F 3D2", "486-451-9788", positionManager.GetPosition("Department Manager"));
            employeeManager.AddEmployee("John", "Eden", "45 Mulberry Dr.", "Winnipeg", "Manitoba", "R3L 2T1", "204-448-8235", positionManager.GetPosition("CEO"));
            employeeManager.AddEmployee("Arthur", "Morgan", "115-B LaColme Cres.", "Saskatoon", "Saskatchewan", "S6H 4G2", "306-945-7865", positionManager.GetPosition("Marketing Manager"));
            employeeManager.AddEmployee("Sandra", "Pence", "98B Terrence Rd.", "Gatineau", "Quebec", "H9T 2F2", "514-354-1468", positionManager.GetPosition("Chief Sales Officer"));
            employeeManager.AddEmployee("Miles", "Davies", "5793 Haliburton St.", "Pembrooke", "Ontario", "T4F 3D2", "486-451-9788", positionManager.GetPosition("Department Manager"));
            employeeManager.AddEmployee("John", "Eden", "45 Mulberry Dr.", "Winnipeg", "Manitoba", "R3L 2T1", "204-448-8235", positionManager.GetPosition("CEO"));
            employeeManager.AddEmployee("Arthur", "Morgan", "115-B LaColme Cres.", "Saskatoon", "Saskatchewan", "S6H 4G2", "306-945-7865", positionManager.GetPosition("Marketing Manager"));
            employeeManager.AddEmployee("Sandra", "Pence", "98B Terrence Rd.", "Gatineau", "Quebec", "H9T 2F2", "514-354-1468", positionManager.GetPosition("Chief Sales Officer"));
            employeeManager.AddEmployee("Miles", "Davies", "5793 Haliburton St.", "Pembrooke", "Ontario", "T4F 3D2", "486-451-9788", positionManager.GetPosition("Department Manager"));
            employeeManager.AddEmployee("John", "Eden", "45 Mulberry Dr.", "Winnipeg", "Manitoba", "R3L 2T1", "204-448-8235", positionManager.GetPosition("CEO"));
            employeeManager.AddEmployee("Arthur", "Morgan", "115-B LaColme Cres.", "Saskatoon", "Saskatchewan", "S6H 4G2", "306-945-7865", positionManager.GetPosition("Marketing Manager"));
            employeeManager.AddEmployee("Sandra", "Pence", "98B Terrence Rd.", "Gatineau", "Quebec", "H9T 2F2", "514-354-1468", positionManager.GetPosition("Chief Sales Officer"));
            employeeManager.AddEmployee("Miles", "Davies", "5793 Haliburton St.", "Pembrooke", "Ontario", "T4F 3D2", "486-451-9788", positionManager.GetPosition("Department Manager"));
            employeeManager.AddEmployee("John", "Eden", "45 Mulberry Dr.", "Winnipeg", "Manitoba", "R3L 2T1", "204-448-8235", positionManager.GetPosition("CEO"));
            employeeManager.AddEmployee("Arthur", "Morgan", "115-B LaColme Cres.", "Saskatoon", "Saskatchewan", "S6H 4G2", "306-945-7865", positionManager.GetPosition("Marketing Manager"));
            employeeManager.AddEmployee("Sandra", "Pence", "98B Terrence Rd.", "Gatineau", "Quebec", "H9T 2F2", "514-354-1468", positionManager.GetPosition("Chief Sales Officer"));
            employeeManager.AddEmployee("Miles", "Davies", "5793 Haliburton St.", "Pembrooke", "Ontario", "T4F 3D2", "486-451-9788", positionManager.GetPosition("Department Manager"));
            employeeManager.AddEmployee("John", "Eden", "45 Mulberry Dr.", "Winnipeg", "Manitoba", "R3L 2T1", "204-448-8235", positionManager.GetPosition("CEO"));
            employeeManager.AddEmployee("Arthur", "Morgan", "115-B LaColme Cres.", "Saskatoon", "Saskatchewan", "S6H 4G2", "306-945-7865", positionManager.GetPosition("Marketing Manager"));
            employeeManager.AddEmployee("Sandra", "Pence", "98B Terrence Rd.", "Gatineau", "Quebec", "H9T 2F2", "514-354-1468", positionManager.GetPosition("Chief Sales Officer"));
            employeeManager.AddEmployee("Miles", "Davies", "5793 Haliburton St.", "Pembrooke", "Ontario", "T4F 3D2", "486-451-9788", positionManager.GetPosition("Department Manager"));
            employeeManager.AddEmployee("John", "Eden", "45 Mulberry Dr.", "Winnipeg", "Manitoba", "R3L 2T1", "204-448-8235", positionManager.GetPosition("CEO"));
            employeeManager.AddEmployee("Arthur", "Morgan", "115-B LaColme Cres.", "Saskatoon", "Saskatchewan", "S6H 4G2", "306-945-7865", positionManager.GetPosition("Marketing Manager"));
            employeeManager.AddEmployee("Sandra", "Pence", "98B Terrence Rd.", "Gatineau", "Quebec", "H9T 2F2", "514-354-1468", positionManager.GetPosition("Chief Sales Officer"));
            employeeManager.AddEmployee("Miles", "Davies", "5793 Haliburton St.", "Pembrooke", "Ontario", "T4F 3D2", "486-451-9788", positionManager.GetPosition("Department Manager"));
            employeeManager.AddEmployee("John", "Eden", "45 Mulberry Dr.", "Winnipeg", "Manitoba", "R3L 2T1", "204-448-8235", positionManager.GetPosition("CEO"));
            employeeManager.AddEmployee("Arthur", "Morgan", "115-B LaColme Cres.", "Saskatoon", "Saskatchewan", "S6H 4G2", "306-945-7865", positionManager.GetPosition("Marketing Manager"));
            employeeManager.AddEmployee("Sandra", "Pence", "98B Terrence Rd.", "Gatineau", "Quebec", "H9T 2F2", "514-354-1468", positionManager.GetPosition("Chief Sales Officer"));
            employeeManager.AddEmployee("Miles", "Davies", "5793 Haliburton St.", "Pembrooke", "Ontario", "T4F 3D2", "486-451-9788", positionManager.GetPosition("Department Manager"));
            employeeManager.AddEmployee("John", "Eden", "45 Mulberry Dr.", "Winnipeg", "Manitoba", "R3L 2T1", "204-448-8235", positionManager.GetPosition("CEO"));
            employeeManager.AddEmployee("Arthur", "Morgan", "115-B LaColme Cres.", "Saskatoon", "Saskatchewan", "S6H 4G2", "306-945-7865", positionManager.GetPosition("Marketing Manager"));
            employeeManager.AddEmployee("Sandra", "Pence", "98B Terrence Rd.", "Gatineau", "Quebec", "H9T 2F2", "514-354-1468", positionManager.GetPosition("Chief Sales Officer"));
            employeeManager.AddEmployee("Miles", "Davies", "5793 Haliburton St.", "Pembrooke", "Ontario", "T4F 3D2", "486-451-9788", positionManager.GetPosition("Department Manager"));
            employeeManager.AddEmployee("John", "Eden", "45 Mulberry Dr.", "Winnipeg", "Manitoba", "R3L 2T1", "204-448-8235", positionManager.GetPosition("CEO"));
            employeeManager.AddEmployee("Arthur", "Morgan", "115-B LaColme Cres.", "Saskatoon", "Saskatchewan", "S6H 4G2", "306-945-7865", positionManager.GetPosition("Marketing Manager"));
            employeeManager.AddEmployee("Sandra", "Pence", "98B Terrence Rd.", "Gatineau", "Quebec", "H9T 2F2", "514-354-1468", positionManager.GetPosition("Chief Sales Officer"));
            employeeManager.AddEmployee("Miles", "Davies", "5793 Haliburton St.", "Pembrooke", "Ontario", "T4F 3D2", "486-451-9788", positionManager.GetPosition("Department Manager"));

        }
    }
}
