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
    public partial class AddEmployeeForm : Form
    {
        private readonly Controller controller;

        public AddEmployeeForm(Controller _controller)
        {
            InitializeComponent();
            controller = _controller;
            controller.addEmployeeForm = this;
            PopulatePositionComboBox();
        }

        private void PopulatePositionComboBox()
        {
            for (int i = 0; i < controller.positionList.Count; i++)
            {
                positionComboBox.Items.Add(controller.positionList[i].Title);
            }
        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string position = positionComboBox.SelectedItem.ToString();

                controller.AddEmployee(
                    firstNameTextBox.Text,
                    lastNameTextBox.Text,
                    streetAddressTextBox.Text,
                    cityTextBox.Text,
                    provinceComboBox.SelectedItem.ToString(),
                    postalCodeTextBox.Text,
                    phoneNumberTextBox.Text,
                    position
                );
                Close();
            }
            catch
            {
                MessageBox.Show("Cannot add employee. Employee data is not valid.", "Add Employee Error");
            }
        }

        private void cancelAddEmployeeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
