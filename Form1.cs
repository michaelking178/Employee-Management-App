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
    public partial class Form1 : Form
    {
        private readonly Controller controller;

        public Form1()
        {
            InitializeComponent();
            controller = new Controller();            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateEmployeeListView();
        }

        // Button functions
        private void managePositionsBtn_Click(object sender, EventArgs e)
        {
            Form positionForm = new PositionForm(controller);
            positionForm.ShowDialog();
        }

        private void removeEmployeeBtn_Click(object sender, EventArgs e)
        {
            controller.RemoveEmployee(employeeListview.SelectedItems[0]);
            UpdateEmployeeListView();
        }

        // EmployeeListview functions
        private void employeeListview_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = employeeListview.Columns[e.ColumnIndex].Width;
        }

        private void UpdateEmployeeListView()
        {
            employeeListview.Items.Clear();
            controller.UpdateEmployeeListview(employeeListview);
        }
    }
}
