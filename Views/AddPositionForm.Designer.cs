namespace Employee_Management_App.Views
{
    partial class AddPositionForm
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.salaryLbl = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.salaryTextBox = new System.Windows.Forms.TextBox();
            this.cancelCreatePosBtn = new System.Windows.Forms.Button();
            this.createPosBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.Location = new System.Drawing.Point(13, 13);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(67, 13);
            this.titleLbl.TabIndex = 0;
            this.titleLbl.Text = "Position Title";
            // 
            // salaryLbl
            // 
            this.salaryLbl.AutoSize = true;
            this.salaryLbl.Location = new System.Drawing.Point(44, 39);
            this.salaryLbl.Name = "salaryLbl";
            this.salaryLbl.Size = new System.Drawing.Size(36, 13);
            this.salaryLbl.TabIndex = 1;
            this.salaryLbl.Text = "Salary";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(86, 10);
            this.titleTextBox.MaxLength = 20;
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(196, 20);
            this.titleTextBox.TabIndex = 2;
            // 
            // salaryTextBox
            // 
            this.salaryTextBox.Location = new System.Drawing.Point(86, 36);
            this.salaryTextBox.MaxLength = 10;
            this.salaryTextBox.Name = "salaryTextBox";
            this.salaryTextBox.Size = new System.Drawing.Size(196, 20);
            this.salaryTextBox.TabIndex = 3;
            // 
            // cancelCreatePosBtn
            // 
            this.cancelCreatePosBtn.Location = new System.Drawing.Point(290, 58);
            this.cancelCreatePosBtn.Name = "cancelCreatePosBtn";
            this.cancelCreatePosBtn.Size = new System.Drawing.Size(202, 43);
            this.cancelCreatePosBtn.TabIndex = 4;
            this.cancelCreatePosBtn.Text = "Cancel";
            this.cancelCreatePosBtn.UseVisualStyleBackColor = true;
            this.cancelCreatePosBtn.Click += new System.EventHandler(this.cancelCreatePosBtn_Click);
            // 
            // createPosBtn
            // 
            this.createPosBtn.Location = new System.Drawing.Point(290, 9);
            this.createPosBtn.Name = "createPosBtn";
            this.createPosBtn.Size = new System.Drawing.Size(202, 43);
            this.createPosBtn.TabIndex = 5;
            this.createPosBtn.Text = "Create";
            this.createPosBtn.UseVisualStyleBackColor = true;
            this.createPosBtn.Click += new System.EventHandler(this.createPosBtn_Click);
            // 
            // CreatePositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 111);
            this.Controls.Add(this.createPosBtn);
            this.Controls.Add(this.cancelCreatePosBtn);
            this.Controls.Add(this.salaryTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.salaryLbl);
            this.Controls.Add(this.titleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(520, 150);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(520, 150);
            this.Name = "CreatePositionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Position";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label salaryLbl;
        private System.Windows.Forms.Button cancelCreatePosBtn;
        private System.Windows.Forms.Button createPosBtn;
        public System.Windows.Forms.TextBox titleTextBox;
        public System.Windows.Forms.TextBox salaryTextBox;
    }
}