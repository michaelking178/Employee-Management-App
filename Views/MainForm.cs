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
    public partial class MainForm : Form
    {
        private readonly Controller controller;

        public MainForm()
        {
            InitializeComponent();
            controller = new Controller();
            controller.mainForm = this;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            controller.UpdateEmployeeListView();
        }

        // Button functions
        private void managePositionsBtn_Click(object sender, EventArgs e)
        {
            Form positionForm = new ManagePositionsForm(controller);
            positionForm.ShowDialog();
        }

        private void removeEmployeeBtn_Click(object sender, EventArgs e)
        {
            controller.RemoveEmployee(employeeListView.SelectedItems[0]);
        }

        private void editEmployeeBtn_Click(object sender, EventArgs e)
        {
            //TODO: Create 'Edit Employee' form
        }

        private void addEmployeeBtn_Click(object sender, EventArgs e)
        {
            Form addEmployeeForm = new AddEmployeeForm(controller);
            addEmployeeForm.ShowDialog();
        }
        
        private void employeeListview_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = employeeListView.Columns[e.ColumnIndex].Width;
        }
    }
}

//TODO: Sort columns by header