﻿using System;
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
        private Controller controller;

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
            string streetAddress = streetAddressTextBox.Text;
            string city = cityTextBox.Text;
            string province = provinceComboBox.SelectedItem.ToString();
            string postalCode = postalCodeTextBox.Text;

            string position = positionComboBox.SelectedItem.ToString();
            string fullAddress = streetAddress + " " + city + " " + province + " " + postalCode;

            controller.AddEmployee (
                firstNameTextBox.Text,
                lastNameTextBox.Text,
                fullAddress,
                phoneNumberTextBox.Text,
                position
            );
            Close();
        }

        private void cancelAddEmployeeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
