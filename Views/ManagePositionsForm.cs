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
            if (positionListview.SelectedItems.Count != 0)
            {
                string positionTitle = positionListview.SelectedItems[0].SubItems[0].Text;
                string positionSalary = positionListview.SelectedItems[0].SubItems[1].Text;

                Form editPositionForm = new EditPositionForm(controller, positionTitle, positionSalary);
                editPositionForm.ShowDialog();
            }
        }

        private void removePositionBtn_Click(object sender, EventArgs e)
        {
            if (positionListview.SelectedItems.Count != 0)
            {
                controller.RemovePosition(positionListview.SelectedItems[0]);
            }
        }

        private void closeManagePosBtn_Click(object sender, EventArgs e)
        {
            controller.UpdateEmployeeListView();
            Close();
        }

        private void positionListview_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.Cancel = true;
            e.NewWidth = positionListview.Columns[e.ColumnIndex].Width;
        }

        private void positionListview_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            //TODO: Implement column sorting
        }
    }
}
