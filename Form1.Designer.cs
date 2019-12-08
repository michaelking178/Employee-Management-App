namespace Employee_Management_App
{
    partial class Form1
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
            this.employeeListview = new System.Windows.Forms.ListView();
            this.employeeIDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StreetAddressColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneNumberColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.positionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.salaryColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addEmployeeBtn = new System.Windows.Forms.Button();
            this.removeEmployeeBtn = new System.Windows.Forms.Button();
            this.managePositionsBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeeListview
            // 
            this.employeeListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.employeeIDColumn,
            this.nameColumn,
            this.StreetAddressColumn,
            this.phoneNumberColumn,
            this.positionColumn,
            this.salaryColumn});
            this.employeeListview.FullRowSelect = true;
            this.employeeListview.GridLines = true;
            this.employeeListview.HideSelection = false;
            this.employeeListview.Location = new System.Drawing.Point(12, 12);
            this.employeeListview.MultiSelect = false;
            this.employeeListview.Name = "employeeListview";
            this.employeeListview.Size = new System.Drawing.Size(830, 560);
            this.employeeListview.TabIndex = 0;
            this.employeeListview.UseCompatibleStateImageBehavior = false;
            this.employeeListview.View = System.Windows.Forms.View.Details;
            this.employeeListview.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.employeeListview_ColumnWidthChanging);
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
            this.positionColumn.Width = 100;
            // 
            // salaryColumn
            // 
            this.salaryColumn.Tag = "salary";
            this.salaryColumn.Text = "Salary";
            this.salaryColumn.Width = 100;
            // 
            // addEmployeeBtn
            // 
            this.addEmployeeBtn.Location = new System.Drawing.Point(850, 13);
            this.addEmployeeBtn.Name = "addEmployeeBtn";
            this.addEmployeeBtn.Size = new System.Drawing.Size(199, 43);
            this.addEmployeeBtn.TabIndex = 1;
            this.addEmployeeBtn.Text = "Add Employee";
            this.addEmployeeBtn.UseVisualStyleBackColor = true;
            // 
            // removeEmployeeBtn
            // 
            this.removeEmployeeBtn.Location = new System.Drawing.Point(850, 62);
            this.removeEmployeeBtn.Name = "removeEmployeeBtn";
            this.removeEmployeeBtn.Size = new System.Drawing.Size(199, 43);
            this.removeEmployeeBtn.TabIndex = 2;
            this.removeEmployeeBtn.Text = "Remove Employee";
            this.removeEmployeeBtn.UseVisualStyleBackColor = true;
            this.removeEmployeeBtn.Click += new System.EventHandler(this.removeEmployeeBtn_Click);
            // 
            // managePositionsBtn
            // 
            this.managePositionsBtn.Location = new System.Drawing.Point(850, 529);
            this.managePositionsBtn.Name = "managePositionsBtn";
            this.managePositionsBtn.Size = new System.Drawing.Size(199, 43);
            this.managePositionsBtn.TabIndex = 3;
            this.managePositionsBtn.Text = "Manage Positions";
            this.managePositionsBtn.UseVisualStyleBackColor = true;
            this.managePositionsBtn.Click += new System.EventHandler(this.managePositionsBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 585);
            this.Controls.Add(this.managePositionsBtn);
            this.Controls.Add(this.removeEmployeeBtn);
            this.Controls.Add(this.addEmployeeBtn);
            this.Controls.Add(this.employeeListview);
            this.Name = "Form1";
            this.Text = "Employee Management Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView employeeListview;
        private System.Windows.Forms.ColumnHeader employeeIDColumn;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.ColumnHeader positionColumn;
        private System.Windows.Forms.ColumnHeader salaryColumn;
        private System.Windows.Forms.ColumnHeader StreetAddressColumn;
        private System.Windows.Forms.ColumnHeader phoneNumberColumn;
        private System.Windows.Forms.Button addEmployeeBtn;
        private System.Windows.Forms.Button removeEmployeeBtn;
        private System.Windows.Forms.Button managePositionsBtn;
    }
}

