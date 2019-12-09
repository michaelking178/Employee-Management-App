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
    public partial class CreatePositionForm : Form
    {
        private readonly Controller controller;

        public CreatePositionForm(Controller _controller)
        {
            InitializeComponent();
            controller = _controller;
            controller.createPositionForm = this;
        }

        private void cancelCreatePosBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void createPosBtn_Click(object sender, EventArgs e)
        {
            controller.CreatePosition(titleTextBox.Text, salaryTextBox.Text);
        }
    }
}
