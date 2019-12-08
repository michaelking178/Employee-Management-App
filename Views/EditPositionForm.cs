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
    public partial class EditPositionForm : Form
    {
        Controller controller;

        public EditPositionForm(Controller _controller)
        {
            InitializeComponent();
            controller = _controller;
        }

        private void cancelCreatePosBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void editPosBtn_Click(object sender, EventArgs e)
        {
            controller.EditPosition();
        }
    }
}
