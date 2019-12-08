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
    public partial class ManagePositionsForm : Form
    {
        private readonly Controller controller;

        public ManagePositionsForm(Controller _controller)
        {
            InitializeComponent();
            controller = _controller;
            controller.managePositionsForm = this;
        }

        private void PositionForm_Load(object sender, EventArgs e)
        {
            controller.UpdatePositionListView();
        }

        private void createPositionBtn_Click(object sender, EventArgs e)
        {
            Form createPositionForm = new CreatePositionForm(controller);
            createPositionForm.ShowDialog();
        }

        private void editPositionBtn_Click(object sender, EventArgs e)
        {
            Form editPositionForm = new EditPositionForm(controller);
            editPositionForm.ShowDialog();
        }

        private void removePositionBtn_Click(object sender, EventArgs e)
        {
            controller.RemovePosition(positionListview.SelectedItems[0]);
        }

        private void closeManagePosBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
