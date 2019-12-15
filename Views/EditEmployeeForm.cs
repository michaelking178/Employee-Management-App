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
    public partial class EditEmployeeForm : Form
    {
        private readonly Controller controller;

        public EditEmployeeForm (Controller _controller)
        {
            InitializeComponent();
            controller = _controller;
            controller.editEmployeeForm = this;

            PopulatePositionComboBox();
            controller.PopulateEditEmployeeForm();
        }

        private void PopulatePositionComboBox()
        {
            for (int i = 0; i < controller.positionList.Count; i++)
            {
                positionComboBox.Items.Add(controller.positionList[i].Title);
            }
        }

        private void cancelEditEmployeeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editEmployeeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                controller.EditEmployee(
                    firstNameTextBox.Text,
                    lastNameTextBox.Text,
                    streetAddressTextBox.Text,
                    cityTextBox.Text,
                    provinceComboBox.SelectedItem.ToString(),
                    postalCodeTextBox.Text,
                    phoneNumberTextBox.Text,
                    positionComboBox.SelectedItem.ToString()
                );
            }
            catch
            {
                MessageBox.Show("Cannot edit employee. Employee data is not valid.", "Edit Employee Error");
            }

        }
    }
}
