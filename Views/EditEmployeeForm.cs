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
    public partial class EditEmployeeForm : Form
    {
        private readonly Controller controller;

        public EditEmployeeForm (Controller _controller)
        {
            InitializeComponent();
            controller = _controller;
            controller.editEmployeeForm = this;

            PopulatePositionComboBox();
            controller.PopulateEmployeeEditForm();
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
    }
}
