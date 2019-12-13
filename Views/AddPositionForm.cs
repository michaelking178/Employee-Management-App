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
    public partial class AddPositionForm : Form
    {
        private readonly Controller controller;

        public AddPositionForm(Controller _controller)
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
            controller.AddPosition(titleTextBox.Text, salaryTextBox.Text);
        }
    }
}
