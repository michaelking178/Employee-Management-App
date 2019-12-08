using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management_App
{
    public partial class PositionForm : Form
    {
        private readonly Controller controller;

        public PositionForm(Controller control)
        {
            InitializeComponent();
            controller = control;
        }

        private void PositionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
