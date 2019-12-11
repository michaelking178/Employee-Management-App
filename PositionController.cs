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
    class PositionController : IController
    {
        private PositionManager positionManager;
        public List<Position> positionList;

        public MainForm mainForm { get; set; }

        public PositionController()
        {
            positionManager = new PositionManager();
            positionList = positionManager.Positions;

            // Populate the database with some initial data
            PopulatePositionList();
        }


        public void UpdateListView()
        {
            ListView positionListView = managePositionsForm.positionListview;
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

        public void Add(string _title, string _salary)
        {
            string title = _title;

            foreach (Position position in positionList)
            {
                if (title == position.Title)
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

        public void SetItemToEdit(ListViewItem position)
        {
            positionToEditTitle = position.SubItems[0].Text;
        }

        public void Edit(string newTitle, int newSalary)
        {
            Position positionToEdit = positionList.Find(Position => Position.Title == positionToEditTitle);
            positionToEdit.Title = newTitle;
            positionToEdit.Salary = newSalary;

            UpdatePositionListView();
            editPositionForm.Close();
        }

        public void Remove(ListViewItem _position)
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

        public void PopulateEditForm()
        {
            Position positionToEdit = positionList.Find(Position => Position.Title == positionToEditTitle);
            editPositionForm.editTitleTextBox.Text = positionToEdit.Title;
            editPositionForm.editSalaryTextBox.Text = positionToEdit.Salary.ToString();
        }

        // Populate some dummy data
        private void PopulatePositionList()
        {
            positionManager.AddPosition("CEO", 350000);
            positionManager.AddPosition("Chief Sales Officer", 180000);
            positionManager.AddPosition("Marketing Manager", 120000);
            positionManager.AddPosition("Department Manager", 65000);
            positionManager.AddPosition("Assistant Manager", 40000);
            positionManager.AddPosition("Sales Clerk", 22000);
        }
    }
}
