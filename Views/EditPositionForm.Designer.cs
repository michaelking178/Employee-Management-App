namespace Employee_Management_App
{
    partial class EditPositionForm
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
            this.editPosBtn = new System.Windows.Forms.Button();
            this.cancelCreatePosBtn = new System.Windows.Forms.Button();
            this.editSalaryTextBox = new System.Windows.Forms.TextBox();
            this.editTitleTextBox = new System.Windows.Forms.TextBox();
            this.editSalaryLbl = new System.Windows.Forms.Label();
            this.editTitleLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // editPosBtn
            // 
            this.editPosBtn.Location = new System.Drawing.Point(290, 9);
            this.editPosBtn.Name = "editPosBtn";
            this.editPosBtn.Size = new System.Drawing.Size(202, 43);
            this.editPosBtn.TabIndex = 11;
            this.editPosBtn.Text = "Confirm";
            this.editPosBtn.UseVisualStyleBackColor = true;
            this.editPosBtn.Click += new System.EventHandler(this.editPosBtn_Click);
            // 
            // cancelCreatePosBtn
            // 
            this.cancelCreatePosBtn.Location = new System.Drawing.Point(290, 58);
            this.cancelCreatePosBtn.Name = "cancelCreatePosBtn";
            this.cancelCreatePosBtn.Size = new System.Drawing.Size(202, 43);
            this.cancelCreatePosBtn.TabIndex = 10;
            this.cancelCreatePosBtn.Text = "Cancel";
            this.cancelCreatePosBtn.UseVisualStyleBackColor = true;
            this.cancelCreatePosBtn.Click += new System.EventHandler(this.cancelCreatePosBtn_Click);
            // 
            // editSalaryTextBox
            // 
            this.editSalaryTextBox.Location = new System.Drawing.Point(86, 36);
            this.editSalaryTextBox.MaxLength = 10;
            this.editSalaryTextBox.Name = "editSalaryTextBox";
            this.editSalaryTextBox.Size = new System.Drawing.Size(196, 20);
            this.editSalaryTextBox.TabIndex = 9;
            // 
            // editTitleTextBox
            // 
            this.editTitleTextBox.Location = new System.Drawing.Point(86, 10);
            this.editTitleTextBox.MaxLength = 20;
            this.editTitleTextBox.Name = "editTitleTextBox";
            this.editTitleTextBox.Size = new System.Drawing.Size(196, 20);
            this.editTitleTextBox.TabIndex = 8;
            // 
            // editSalaryLbl
            // 
            this.editSalaryLbl.AutoSize = true;
            this.editSalaryLbl.Location = new System.Drawing.Point(44, 39);
            this.editSalaryLbl.Name = "editSalaryLbl";
            this.editSalaryLbl.Size = new System.Drawing.Size(36, 13);
            this.editSalaryLbl.TabIndex = 7;
            this.editSalaryLbl.Text = "Salary";
            // 
            // editTitleLbl
            // 
            this.editTitleLbl.AutoSize = true;
            this.editTitleLbl.Location = new System.Drawing.Point(13, 13);
            this.editTitleLbl.Name = "editTitleLbl";
            this.editTitleLbl.Size = new System.Drawing.Size(67, 13);
            this.editTitleLbl.TabIndex = 6;
            this.editTitleLbl.Text = "Position Title";
            // 
            // EditPositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 111);
            this.Controls.Add(this.editPosBtn);
            this.Controls.Add(this.cancelCreatePosBtn);
            this.Controls.Add(this.editSalaryTextBox);
            this.Controls.Add(this.editTitleTextBox);
            this.Controls.Add(this.editSalaryLbl);
            this.Controls.Add(this.editTitleLbl);
            this.MaximumSize = new System.Drawing.Size(520, 150);
            this.MinimumSize = new System.Drawing.Size(520, 150);
            this.Name = "EditPositionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Position";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editPosBtn;
        private System.Windows.Forms.Button cancelCreatePosBtn;
        private System.Windows.Forms.TextBox editSalaryTextBox;
        private System.Windows.Forms.TextBox editTitleTextBox;
        private System.Windows.Forms.Label editSalaryLbl;
        private System.Windows.Forms.Label editTitleLbl;
    }
}