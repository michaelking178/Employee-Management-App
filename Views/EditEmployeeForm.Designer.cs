namespace Employee_Management_App.Views
{
    partial class EditEmployeeForm
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
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.provinceComboBox = new System.Windows.Forms.ComboBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.editPhoneNumberLbl = new System.Windows.Forms.Label();
            this.editEmployeeBtn = new System.Windows.Forms.Button();
            this.cancelEditEmployeeBtn = new System.Windows.Forms.Button();
            this.postalCodeTextBox = new System.Windows.Forms.TextBox();
            this.editPostalCodeLbl = new System.Windows.Forms.Label();
            this.editPositionLbl = new System.Windows.Forms.Label();
            this.editProvinceLbl = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.streetAddressTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.editCityLbl = new System.Windows.Forms.Label();
            this.editStreetAddressLbl = new System.Windows.Forms.Label();
            this.editLastNameLbl = new System.Windows.Forms.Label();
            this.editFirstNameLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // positionComboBox
            // 
            this.positionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.positionComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Location = new System.Drawing.Point(94, 142);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(215, 21);
            this.positionComboBox.TabIndex = 27;
            // 
            // provinceComboBox
            // 
            this.provinceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.provinceComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.provinceComboBox.FormattingEnabled = true;
            this.provinceComboBox.Items.AddRange(new object[] {
            "Alberta",
            "British Columbia",
            "Manitoba",
            "New Brunswick",
            "Newfoundland",
            "Nova Scotia",
            "Ontario",
            "Prince Edward Island",
            "Quebec",
            "Saskatchewan",
            "Northwest Territories",
            "Nunavut",
            "Yukon Territory"});
            this.provinceComboBox.Location = new System.Drawing.Point(315, 90);
            this.provinceComboBox.Name = "provinceComboBox";
            this.provinceComboBox.Size = new System.Drawing.Size(126, 21);
            this.provinceComboBox.TabIndex = 23;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(315, 116);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(127, 20);
            this.phoneNumberTextBox.TabIndex = 25;
            // 
            // editPhoneNumberLbl
            // 
            this.editPhoneNumberLbl.AutoSize = true;
            this.editPhoneNumberLbl.Location = new System.Drawing.Point(231, 119);
            this.editPhoneNumberLbl.Name = "editPhoneNumberLbl";
            this.editPhoneNumberLbl.Size = new System.Drawing.Size(78, 13);
            this.editPhoneNumberLbl.TabIndex = 32;
            this.editPhoneNumberLbl.Text = "Phone Number";
            // 
            // editEmployeeBtn
            // 
            this.editEmployeeBtn.Location = new System.Drawing.Point(447, 12);
            this.editEmployeeBtn.Name = "editEmployeeBtn";
            this.editEmployeeBtn.Size = new System.Drawing.Size(202, 43);
            this.editEmployeeBtn.TabIndex = 28;
            this.editEmployeeBtn.Text = "Edit Employee";
            this.editEmployeeBtn.UseVisualStyleBackColor = true;
            // 
            // cancelEditEmployeeBtn
            // 
            this.cancelEditEmployeeBtn.Location = new System.Drawing.Point(448, 61);
            this.cancelEditEmployeeBtn.Name = "cancelEditEmployeeBtn";
            this.cancelEditEmployeeBtn.Size = new System.Drawing.Size(202, 43);
            this.cancelEditEmployeeBtn.TabIndex = 30;
            this.cancelEditEmployeeBtn.Text = "Cancel";
            this.cancelEditEmployeeBtn.UseVisualStyleBackColor = true;
            // 
            // postalCodeTextBox
            // 
            this.postalCodeTextBox.Location = new System.Drawing.Point(94, 116);
            this.postalCodeTextBox.Name = "postalCodeTextBox";
            this.postalCodeTextBox.Size = new System.Drawing.Size(131, 20);
            this.postalCodeTextBox.TabIndex = 24;
            // 
            // editPostalCodeLbl
            // 
            this.editPostalCodeLbl.AutoSize = true;
            this.editPostalCodeLbl.Location = new System.Drawing.Point(24, 119);
            this.editPostalCodeLbl.Name = "editPostalCodeLbl";
            this.editPostalCodeLbl.Size = new System.Drawing.Size(64, 13);
            this.editPostalCodeLbl.TabIndex = 31;
            this.editPostalCodeLbl.Text = "Postal Code";
            // 
            // editPositionLbl
            // 
            this.editPositionLbl.AutoSize = true;
            this.editPositionLbl.Location = new System.Drawing.Point(44, 145);
            this.editPositionLbl.Name = "editPositionLbl";
            this.editPositionLbl.Size = new System.Drawing.Size(44, 13);
            this.editPositionLbl.TabIndex = 29;
            this.editPositionLbl.Text = "Position";
            // 
            // editProvinceLbl
            // 
            this.editProvinceLbl.AutoSize = true;
            this.editProvinceLbl.Location = new System.Drawing.Point(260, 93);
            this.editProvinceLbl.Name = "editProvinceLbl";
            this.editProvinceLbl.Size = new System.Drawing.Size(49, 13);
            this.editProvinceLbl.TabIndex = 26;
            this.editProvinceLbl.Text = "Province";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(94, 90);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(131, 20);
            this.cityTextBox.TabIndex = 22;
            // 
            // streetAddressTextBox
            // 
            this.streetAddressTextBox.Location = new System.Drawing.Point(94, 64);
            this.streetAddressTextBox.Name = "streetAddressTextBox";
            this.streetAddressTextBox.Size = new System.Drawing.Size(347, 20);
            this.streetAddressTextBox.TabIndex = 21;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(94, 38);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(347, 20);
            this.lastNameTextBox.TabIndex = 19;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(94, 12);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(347, 20);
            this.firstNameTextBox.TabIndex = 16;
            // 
            // editCityLbl
            // 
            this.editCityLbl.AutoSize = true;
            this.editCityLbl.Location = new System.Drawing.Point(64, 93);
            this.editCityLbl.Name = "editCityLbl";
            this.editCityLbl.Size = new System.Drawing.Size(24, 13);
            this.editCityLbl.TabIndex = 18;
            this.editCityLbl.Text = "City";
            // 
            // editStreetAddressLbl
            // 
            this.editStreetAddressLbl.AutoSize = true;
            this.editStreetAddressLbl.Location = new System.Drawing.Point(12, 67);
            this.editStreetAddressLbl.Name = "editStreetAddressLbl";
            this.editStreetAddressLbl.Size = new System.Drawing.Size(76, 13);
            this.editStreetAddressLbl.TabIndex = 17;
            this.editStreetAddressLbl.Text = "Street Address";
            // 
            // editLastNameLbl
            // 
            this.editLastNameLbl.AutoSize = true;
            this.editLastNameLbl.Location = new System.Drawing.Point(30, 41);
            this.editLastNameLbl.Name = "editLastNameLbl";
            this.editLastNameLbl.Size = new System.Drawing.Size(58, 13);
            this.editLastNameLbl.TabIndex = 20;
            this.editLastNameLbl.Text = "Last Name";
            // 
            // editFirstNameLbl
            // 
            this.editFirstNameLbl.AutoSize = true;
            this.editFirstNameLbl.Location = new System.Drawing.Point(31, 15);
            this.editFirstNameLbl.Name = "editFirstNameLbl";
            this.editFirstNameLbl.Size = new System.Drawing.Size(57, 13);
            this.editFirstNameLbl.TabIndex = 15;
            this.editFirstNameLbl.Text = "First Name";
            // 
            // EditEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 175);
            this.Controls.Add(this.positionComboBox);
            this.Controls.Add(this.provinceComboBox);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.editPhoneNumberLbl);
            this.Controls.Add(this.editEmployeeBtn);
            this.Controls.Add(this.cancelEditEmployeeBtn);
            this.Controls.Add(this.postalCodeTextBox);
            this.Controls.Add(this.editPostalCodeLbl);
            this.Controls.Add(this.editPositionLbl);
            this.Controls.Add(this.editProvinceLbl);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.streetAddressTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.editCityLbl);
            this.Controls.Add(this.editStreetAddressLbl);
            this.Controls.Add(this.editLastNameLbl);
            this.Controls.Add(this.editFirstNameLbl);
            this.MaximumSize = new System.Drawing.Size(678, 214);
            this.MinimumSize = new System.Drawing.Size(678, 214);
            this.Name = "EditEmployeeForm";
            this.Text = "Edit Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ComboBox positionComboBox;
        private System.Windows.Forms.Label editPhoneNumberLbl;
        private System.Windows.Forms.Button editEmployeeBtn;
        private System.Windows.Forms.Button cancelEditEmployeeBtn;
        private System.Windows.Forms.Label editPostalCodeLbl;
        private System.Windows.Forms.Label editPositionLbl;
        private System.Windows.Forms.Label editProvinceLbl;
        private System.Windows.Forms.Label editCityLbl;
        private System.Windows.Forms.Label editStreetAddressLbl;
        private System.Windows.Forms.Label editLastNameLbl;
        private System.Windows.Forms.Label editFirstNameLbl;
        public System.Windows.Forms.ComboBox provinceComboBox;
        public System.Windows.Forms.TextBox phoneNumberTextBox;
        public System.Windows.Forms.TextBox postalCodeTextBox;
        public System.Windows.Forms.TextBox cityTextBox;
        public System.Windows.Forms.TextBox streetAddressTextBox;
        public System.Windows.Forms.TextBox lastNameTextBox;
        public System.Windows.Forms.TextBox firstNameTextBox;
    }
}