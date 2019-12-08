namespace Employee_Management_App
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.employeeListView = new System.Windows.Forms.ListView();
            this.employeeIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StreetAddressColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneNumberColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.positionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.salaryColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addEmployeeBtn = new System.Windows.Forms.Button();
            this.removeEmployeeBtn = new System.Windows.Forms.Button();
            this.managePositionsBtn = new System.Windows.Forms.Button();
            this.editEmployeeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeeListView
            // 
            this.employeeListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.employeeIDColumn,
            this.nameColumn,
            this.StreetAddressColumn,
            this.phoneNumberColumn,
            this.positionColumn,
            this.salaryColumn});
            this.employeeListView.FullRowSelect = true;
            this.employeeListView.GridLines = true;
            this.employeeListView.HideSelection = false;
            this.employeeListView.Location = new System.Drawing.Point(12, 12);
            this.employeeListView.MultiSelect = false;
            this.employeeListView.Name = "employeeListView";
            this.employeeListView.Size = new System.Drawing.Size(830, 560);
            this.employeeListView.TabIndex = 0;
            this.employeeListView.UseCompatibleStateImageBehavior = false;
            this.employeeListView.View = System.Windows.Forms.View.Details;
            this.employeeListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.employeeListview_ColumnWidthChanging);
            // 
            // employeeIDColumn
            // 
            this.employeeIDColumn.Tag = "employeeID";
            this.employeeIDColumn.Text = "Employee ID";
            this.employeeIDColumn.Width = 75;
            // 
            // nameColumn
            // 
            this.nameColumn.Tag = "name";
            this.nameColumn.Text = "Name";
            this.nameColumn.Width = 150;
            // 
            // StreetAddressColumn
            // 
            this.StreetAddressColumn.Tag = "streetAddress";
            this.StreetAddressColumn.Text = "Street Address";
            this.StreetAddressColumn.Width = 300;
            // 
            // phoneNumberColumn
            // 
            this.phoneNumberColumn.Tag = "phoneNumber";
            this.phoneNumberColumn.Text = "Phone Number";
            this.phoneNumberColumn.Width = 100;
            // 
            // positionColumn
            // 
            this.positionColumn.Tag = "position";
            this.positionColumn.Text = "Position";
            this.positionColumn.Width = 120;
            // 
            // salaryColumn
            // 
            this.salaryColumn.Tag = "salary";
            this.salaryColumn.Text = "Salary";
            this.salaryColumn.Width = 80;
            // 
            // addEmployeeBtn
            // 
            this.addEmployeeBtn.Location = new System.Drawing.Point(850, 13);
            this.addEmployeeBtn.Name = "addEmployeeBtn";
            this.addEmployeeBtn.Size = new System.Drawing.Size(202, 43);
            this.addEmployeeBtn.TabIndex = 1;
            this.addEmployeeBtn.Text = "Add Employee";
            this.addEmployeeBtn.UseVisualStyleBackColor = true;
            this.addEmployeeBtn.Click += new System.EventHandler(this.addEmployeeBtn_Click);
            // 
            // removeEmployeeBtn
            // 
            this.removeEmployeeBtn.Location = new System.Drawing.Point(850, 111);
            this.removeEmployeeBtn.Name = "removeEmployeeBtn";
            this.removeEmployeeBtn.Size = new System.Drawing.Size(202, 43);
            this.removeEmployeeBtn.TabIndex = 2;
            this.removeEmployeeBtn.Text = "Remove Employee";
            this.removeEmployeeBtn.UseVisualStyleBackColor = true;
            this.removeEmployeeBtn.Click += new System.EventHandler(this.removeEmployeeBtn_Click);
            // 
            // managePositionsBtn
            // 
            this.managePositionsBtn.Location = new System.Drawing.Point(850, 529);
            this.managePositionsBtn.Name = "managePositionsBtn";
            this.managePositionsBtn.Size = new System.Drawing.Size(202, 43);
            this.managePositionsBtn.TabIndex = 3;
            this.managePositionsBtn.Text = "Manage Positions";
            this.managePositionsBtn.UseVisualStyleBackColor = true;
            this.managePositionsBtn.Click += new System.EventHandler(this.managePositionsBtn_Click);
            // 
            // editEmployeeBtn
            // 
            this.editEmployeeBtn.Location = new System.Drawing.Point(850, 62);
            this.editEmployeeBtn.Name = "editEmployeeBtn";
            this.editEmployeeBtn.Size = new System.Drawing.Size(202, 43);
            this.editEmployeeBtn.TabIndex = 4;
            this.editEmployeeBtn.Text = "Edit Employee";
            this.editEmployeeBtn.UseVisualStyleBackColor = true;
            this.editEmployeeBtn.Click += new System.EventHandler(this.editEmployeeBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 585);
            this.Controls.Add(this.editEmployeeBtn);
            this.Controls.Add(this.managePositionsBtn);
            this.Controls.Add(this.removeEmployeeBtn);
            this.Controls.Add(this.addEmployeeBtn);
            this.Controls.Add(this.employeeListView);
            this.MaximumSize = new System.Drawing.Size(1080, 624);
            this.MinimumSize = new System.Drawing.Size(1080, 624);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Management Application";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader employeeIDColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader positionColumn;
        private System.Windows.Forms.ColumnHeader salaryColumn;
        private System.Windows.Forms.ColumnHeader StreetAddressColumn;
        private System.Windows.Forms.ColumnHeader phoneNumberColumn;
        private System.Windows.Forms.Button addEmployeeBtn;
        private System.Windows.Forms.Button removeEmployeeBtn;
        private System.Windows.Forms.Button managePositionsBtn;
        private System.Windows.Forms.Button editEmployeeBtn;
        public System.Windows.Forms.ListView employeeListView;
    }
}

