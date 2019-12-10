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
        }
    }
}
