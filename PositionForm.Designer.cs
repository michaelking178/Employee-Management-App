namespace Employee_Management_App
{
    partial class PositionForm
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
            this.SuspendLayout();
            // 
            // positionListview
            // 
            this.positionListview.HideSelection = false;
            this.positionListview.Location = new System.Drawing.Point(12, 12);
            this.positionListview.Name = "positionListview";
            this.positionListview.Size = new System.Drawing.Size(224, 280);
            this.positionListview.TabIndex = 0;
            this.positionListview.UseCompatibleStateImageBehavior = false;
            // 
            // PositionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 304);
            this.Controls.Add(this.positionListview);
            this.Name = "PositionForm";
            this.Text = "PositionForm";
            this.Load += new System.EventHandler(this.PositionForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView positionListview;
    }
}