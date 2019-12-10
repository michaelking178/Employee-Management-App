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
                string streetAddress = streetAddressTextBox.Text;
                string city = cityTextBox.Text;
                string province = provinceComboBox.SelectedItem.ToString();
                string postalCode = postalCodeTextBox.Text;

                //TODO: Break up the street address in the Employee object for easier parsing later.
                string position = positionComboBox.SelectedItem.ToString();
                string fullAddress = streetAddress + " " + city + " " + province + " " + postalCode;

                controller.AddEmployee(
                    firstNameTextBox.Text,
                    lastNameTextBox.Text,
                    fullAddress,
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
