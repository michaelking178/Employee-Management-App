namespace Employee_Management_App.Views
{
    partial class ManagePositionsForm
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
            this.positionListview = new System.Windows.Forms.ListView();
            this.titleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.salaryColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.createPositionBtn = new System.Windows.Forms.Button();
            this.editPositionBtn = new System.Windows.Forms.Button();
            this.removePositionBtn = new System.Windows.Forms.Button();
            this.closeManagePosBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // positionListview
            // 
            this.positionListview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.titleColumn,
            this.salaryColumn});
            this.positionListview.FullRowSelect = true;
            this.positionListview.GridLines = true;
            this.positionListview.HideSelection = false;
            this.positionListview.Location = new System.Drawing.Point(12, 12);
            this.positionListview.MultiSelect = false;
            this.positionListview.Name = "positionListview";
            this.positionListview.Size = new System.Drawing.Size(209, 280);
            this.positionListview.TabIndex = 0;
            this.positionListview.UseCompatibleStateImageBehavior = false;
            this.positionListview.View = System.Windows.Forms.View.Details;
            // 
            // titleColumn
            // 
            this.titleColumn.Text = "Title";
            this.titleColumn.Width = 120;
            // 
            // salaryColumn
            // 
            this.salaryColumn.Text = "Salary";
            this.salaryColumn.Width = 80;
            // 
            // createPositionBtn
            // 
            this.createPositionBtn.Location = new System.Drawing.Point(227, 12);
            this.createPositionBtn.Name = "createPositionBtn";
            this.createPositionBtn.Size = new System.Drawing.Size(202, 43);
            this.createPositionBtn.TabIndex = 2;
            this.createPositionBtn.Text = "Create Position";
            this.createPositionBtn.UseVisualStyleBackColor = true;
            this.createPositionBtn.Click += new System.EventHandler(this.createPositionBtn_Click);
            // 
            // editPositionBtn
            // 
            this.editPositionBtn.Location = new System.Drawing.Point(226, 61);
            this.editPositionBtn.Name = "editPositionBtn";
            this.editPositionBtn.Size = new System.Drawing.Size(202, 43);
            this.editPositionBtn.TabIndex = 3;
            this.editPositionBtn.Text = "Edit Position";
            this.editPositionBtn.UseVisualStyleBackColor = true;
            this.editPositionBtn.Click += new System.EventHandler(this.editPositionBtn_Click);
            // 
            // removePositionBtn
            // 
            this.removePositionBtn.Location = new System.Drawing.Point(227, 110);
            this.removePositionBtn.Name = "removePositionBtn";
            this.removePositionBtn.Size = new System.Drawing.Size(202, 43);
            this.removePositionBtn.TabIndex = 4;
            this.removePositionBtn.Text = "Remove Position";
            this.removePositionBtn.UseVisualStyleBackColor = true;
            this.removePositionBtn.Click += new System.EventHandler(this.removePositionBtn_Click);
            // 
            // closeManagePosBtn
            // 
            this.closeManagePosBtn.Location = new System.Drawing.Point(227, 249);
            this.closeManagePosBtn.Name = "closeManagePosBtn";
            this.closeManagePosBtn.Size = new System.Drawing.Size(202, 43);
            this.closeManagePosBtn.TabIndex = 5;
            this.closeManagePosBtn.Text = "Close";
            this.closeManagePosBtn.UseVisualStyleBackColor = true;
            this.closeManagePosBtn.Click += new System.EventHandler(this.closeManagePosBtn_Click);
            // 
            // ManagePositionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 304);
            this.Controls.Add(this.closeManagePosBtn);
            this.Controls.Add(this.removePositionBtn);
            this.Controls.Add(this.editPositionBtn);
            this.Controls.Add(this.createPositionBtn);
            this.Controls.Add(this.positionListview);
            this.Name = "ManagePositionsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Positions";
            this.Load += new System.EventHandler(this.PositionForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader titleColumn;
        private System.Windows.Forms.ColumnHeader salaryColumn;
        private System.Windows.Forms.Button createPositionBtn;
        private System.Windows.Forms.Button editPositionBtn;
        private System.Windows.Forms.Button removePositionBtn;
        public System.Windows.Forms.ListView positionListview;
        private System.Windows.Forms.Button closeManagePosBtn;
    }
}