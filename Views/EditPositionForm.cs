using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_App.Views
{
    public partial class EditPositionForm : Form
    {
        private readonly Controller controller;
        private readonly string titleToEdit;

        public EditPositionForm(Controller _controller, string title, string salary)
        {
            InitializeComponent();
            controller = _controller;
            controller.editPositionForm = this;

            //TODO: abstract Edit Position Form population out of the UI item.
            titleToEdit = title;
            editTitleTextBox.Text = title;
            editSalaryTextBox.Text = salary.Remove(0,2); //Removes the "$ " at the front of the salary string.
        }

        private void cancelCreatePosBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editPosBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string newTitle = editTitleTextBox.Text;
                int newSalary = int.Parse(editSalaryTextBox.Text);
                controller.EditPosition(titleToEdit, newTitle, newSalary);
            }
            catch
            {
                MessageBox.Show("Please enter only numbers in the Salary field.", "Edit Position Error");
            }
        }
    }
}
