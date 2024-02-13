namespace SkillInternationalWinFormApp
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.gBoxMain = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtParentContact = new System.Windows.Forms.TextBox();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.lblParentContact = new System.Windows.Forms.Label();
            this.txtParentNIC = new System.Windows.Forms.TextBox();
            this.lblParentNIC = new System.Windows.Forms.Label();
            this.lblParentName = new System.Windows.Forms.Label();
            this.gBoxContactDetails = new System.Windows.Forms.GroupBox();
            this.txtHome = new System.Windows.Forms.TextBox();
            this.lblHome = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.lblMobile = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.comboBoxRegNo = new System.Windows.Forms.ComboBox();
            this.gBoxBasicDetails = new System.Windows.Forms.GroupBox();
            this.radiobtnFemale = new System.Windows.Forms.RadioButton();
            this.radiobtnMale = new System.Windows.Forms.RadioButton();
            this.dateTimePickerBirth = new System.Windows.Forms.DateTimePicker();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblBirth = new System.Windows.Forms.Label();
            this.lblLname = new System.Windows.Forms.Label();
            this.lblFname = new System.Windows.Forms.Label();
            this.lblRegNo = new System.Windows.Forms.Label();
            this.Heading = new System.Windows.Forms.Label();
            this.linkLogout = new System.Windows.Forms.LinkLabel();
            this.linkExit = new System.Windows.Forms.LinkLabel();
            this.gBoxMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gBoxContactDetails.SuspendLayout();
            this.gBoxBasicDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxMain
            // 
            this.gBoxMain.Controls.Add(this.btnClear);
            this.gBoxMain.Controls.Add(this.btnDelete);
            this.gBoxMain.Controls.Add(this.btnUpdate);
            this.gBoxMain.Controls.Add(this.groupBox1);
            this.gBoxMain.Controls.Add(this.gBoxContactDetails);
            this.gBoxMain.Controls.Add(this.btnRegister);
            this.gBoxMain.Controls.Add(this.comboBoxRegNo);
            this.gBoxMain.Controls.Add(this.gBoxBasicDetails);
            this.gBoxMain.Controls.Add(this.lblRegNo);
            this.gBoxMain.Location = new System.Drawing.Point(12, 51);
            this.gBoxMain.Name = "gBoxMain";
            this.gBoxMain.Size = new System.Drawing.Size(616, 667);
            this.gBoxMain.TabIndex = 0;
            this.gBoxMain.TabStop = false;
            this.gBoxMain.Text = "Student Registration";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(429, 631);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(510, 631);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(108, 631);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtParentContact);
            this.groupBox1.Controls.Add(this.txtParentName);
            this.groupBox1.Controls.Add(this.lblParentContact);
            this.groupBox1.Controls.Add(this.txtParentNIC);
            this.groupBox1.Controls.Add(this.lblParentNIC);
            this.groupBox1.Controls.Add(this.lblParentName);
            this.groupBox1.Location = new System.Drawing.Point(27, 466);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(558, 146);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact Details";
            // 
            // txtParentContact
            // 
            this.txtParentContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParentContact.Location = new System.Drawing.Point(124, 103);
            this.txtParentContact.Name = "txtParentContact";
            this.txtParentContact.Size = new System.Drawing.Size(152, 20);
            this.txtParentContact.TabIndex = 13;
            // 
            // txtParentName
            // 
            this.txtParentName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParentName.Location = new System.Drawing.Point(124, 35);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Size = new System.Drawing.Size(408, 20);
            this.txtParentName.TabIndex = 12;
            // 
            // lblParentContact
            // 
            this.lblParentContact.AutoSize = true;
            this.lblParentContact.Location = new System.Drawing.Point(29, 110);
            this.lblParentContact.Name = "lblParentContact";
            this.lblParentContact.Size = new System.Drawing.Size(84, 13);
            this.lblParentContact.TabIndex = 8;
            this.lblParentContact.Text = "Contact Number";
            // 
            // txtParentNIC
            // 
            this.txtParentNIC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtParentNIC.Location = new System.Drawing.Point(124, 68);
            this.txtParentNIC.Name = "txtParentNIC";
            this.txtParentNIC.Size = new System.Drawing.Size(152, 20);
            this.txtParentNIC.TabIndex = 7;
            // 
            // lblParentNIC
            // 
            this.lblParentNIC.AutoSize = true;
            this.lblParentNIC.Location = new System.Drawing.Point(29, 70);
            this.lblParentNIC.Name = "lblParentNIC";
            this.lblParentNIC.Size = new System.Drawing.Size(25, 13);
            this.lblParentNIC.TabIndex = 3;
            this.lblParentNIC.Text = "NIC";
            // 
            // lblParentName
            // 
            this.lblParentName.AutoSize = true;
            this.lblParentName.Location = new System.Drawing.Point(29, 37);
            this.lblParentName.Name = "lblParentName";
            this.lblParentName.Size = new System.Drawing.Size(69, 13);
            this.lblParentName.TabIndex = 2;
            this.lblParentName.Text = "Parent Name";
            // 
            // gBoxContactDetails
            // 
            this.gBoxContactDetails.Controls.Add(this.txtHome);
            this.gBoxContactDetails.Controls.Add(this.lblHome);
            this.gBoxContactDetails.Controls.Add(this.txtMobile);
            this.gBoxContactDetails.Controls.Add(this.lblMobile);
            this.gBoxContactDetails.Controls.Add(this.txtEmail);
            this.gBoxContactDetails.Controls.Add(this.txtAddress);
            this.gBoxContactDetails.Controls.Add(this.lblEmail);
            this.gBoxContactDetails.Controls.Add(this.lblAddress);
            this.gBoxContactDetails.Location = new System.Drawing.Point(27, 267);
            this.gBoxContactDetails.Name = "gBoxContactDetails";
            this.gBoxContactDetails.Size = new System.Drawing.Size(558, 182);
            this.gBoxContactDetails.TabIndex = 11;
            this.gBoxContactDetails.TabStop = false;
            this.gBoxContactDetails.Text = "Contact Details";
            // 
            // txtHome
            // 
            this.txtHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHome.Location = new System.Drawing.Point(383, 150);
            this.txtHome.Name = "txtHome";
            this.txtHome.Size = new System.Drawing.Size(149, 20);
            this.txtHome.TabIndex = 11;
            // 
            // lblHome
            // 
            this.lblHome.AutoSize = true;
            this.lblHome.Location = new System.Drawing.Point(308, 152);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(69, 13);
            this.lblHome.TabIndex = 10;
            this.lblHome.Text = "Home Phone";
            // 
            // txtMobile
            // 
            this.txtMobile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMobile.Location = new System.Drawing.Point(124, 150);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(152, 20);
            this.txtMobile.TabIndex = 9;
            // 
            // lblMobile
            // 
            this.lblMobile.AutoSize = true;
            this.lblMobile.Location = new System.Drawing.Point(29, 152);
            this.lblMobile.Name = "lblMobile";
            this.lblMobile.Size = new System.Drawing.Size(72, 13);
            this.lblMobile.TabIndex = 8;
            this.lblMobile.Text = "Mobile Phone";
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmail.Location = new System.Drawing.Point(124, 114);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(408, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddress.Location = new System.Drawing.Point(124, 37);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(408, 64);
            this.txtAddress.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(29, 116);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(29, 37);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(27, 631);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 3;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // comboBoxRegNo
            // 
            this.comboBoxRegNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRegNo.FormattingEnabled = true;
            this.comboBoxRegNo.Location = new System.Drawing.Point(151, 35);
            this.comboBoxRegNo.Name = "comboBoxRegNo";
            this.comboBoxRegNo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxRegNo.TabIndex = 2;
            this.comboBoxRegNo.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegNo_SelectedIndexChanged);
            // 
            // gBoxBasicDetails
            // 
            this.gBoxBasicDetails.Controls.Add(this.radiobtnFemale);
            this.gBoxBasicDetails.Controls.Add(this.radiobtnMale);
            this.gBoxBasicDetails.Controls.Add(this.dateTimePickerBirth);
            this.gBoxBasicDetails.Controls.Add(this.txtLname);
            this.gBoxBasicDetails.Controls.Add(this.txtFname);
            this.gBoxBasicDetails.Controls.Add(this.lblGender);
            this.gBoxBasicDetails.Controls.Add(this.lblBirth);
            this.gBoxBasicDetails.Controls.Add(this.lblLname);
            this.gBoxBasicDetails.Controls.Add(this.lblFname);
            this.gBoxBasicDetails.Location = new System.Drawing.Point(27, 78);
            this.gBoxBasicDetails.Name = "gBoxBasicDetails";
            this.gBoxBasicDetails.Size = new System.Drawing.Size(558, 173);
            this.gBoxBasicDetails.TabIndex = 1;
            this.gBoxBasicDetails.TabStop = false;
            this.gBoxBasicDetails.Text = "Basic Details";
            // 
            // radiobtnFemale
            // 
            this.radiobtnFemale.AutoSize = true;
            this.radiobtnFemale.Location = new System.Drawing.Point(228, 132);
            this.radiobtnFemale.Name = "radiobtnFemale";
            this.radiobtnFemale.Size = new System.Drawing.Size(59, 17);
            this.radiobtnFemale.TabIndex = 10;
            this.radiobtnFemale.TabStop = true;
            this.radiobtnFemale.Text = "Female";
            this.radiobtnFemale.UseVisualStyleBackColor = true;
            // 
            // radiobtnMale
            // 
            this.radiobtnMale.AutoSize = true;
            this.radiobtnMale.Location = new System.Drawing.Point(124, 132);
            this.radiobtnMale.Name = "radiobtnMale";
            this.radiobtnMale.Size = new System.Drawing.Size(48, 17);
            this.radiobtnMale.TabIndex = 9;
            this.radiobtnMale.TabStop = true;
            this.radiobtnMale.Text = "Male";
            this.radiobtnMale.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerBirth
            // 
            this.dateTimePickerBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirth.Location = new System.Drawing.Point(124, 101);
            this.dateTimePickerBirth.Name = "dateTimePickerBirth";
            this.dateTimePickerBirth.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerBirth.TabIndex = 8;
            // 
            // txtLname
            // 
            this.txtLname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLname.Location = new System.Drawing.Point(124, 69);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(408, 20);
            this.txtLname.TabIndex = 7;
            // 
            // txtFname
            // 
            this.txtFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtFname.Location = new System.Drawing.Point(124, 37);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(408, 20);
            this.txtFname.TabIndex = 6;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(29, 134);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 5;
            this.lblGender.Text = "Gender";
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Location = new System.Drawing.Point(29, 101);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(66, 13);
            this.lblBirth.TabIndex = 4;
            this.lblBirth.Text = "Date of Birth";
            // 
            // lblLname
            // 
            this.lblLname.AutoSize = true;
            this.lblLname.Location = new System.Drawing.Point(29, 69);
            this.lblLname.Name = "lblLname";
            this.lblLname.Size = new System.Drawing.Size(58, 13);
            this.lblLname.TabIndex = 3;
            this.lblLname.Text = "Last Name";
            // 
            // lblFname
            // 
            this.lblFname.AutoSize = true;
            this.lblFname.Location = new System.Drawing.Point(29, 37);
            this.lblFname.Name = "lblFname";
            this.lblFname.Size = new System.Drawing.Size(57, 13);
            this.lblFname.TabIndex = 2;
            this.lblFname.Text = "First Name";
            // 
            // lblRegNo
            // 
            this.lblRegNo.AutoSize = true;
            this.lblRegNo.Location = new System.Drawing.Point(56, 38);
            this.lblRegNo.Name = "lblRegNo";
            this.lblRegNo.Size = new System.Drawing.Size(44, 13);
            this.lblRegNo.TabIndex = 0;
            this.lblRegNo.Text = "Reg No";
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.Location = new System.Drawing.Point(156, 9);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(339, 42);
            this.Heading.TabIndex = 1;
            this.Heading.Text = "Skills International";
            // 
            // linkLogout
            // 
            this.linkLogout.AutoSize = true;
            this.linkLogout.Location = new System.Drawing.Point(12, 9);
            this.linkLogout.Name = "linkLogout";
            this.linkLogout.Size = new System.Drawing.Size(40, 13);
            this.linkLogout.TabIndex = 2;
            this.linkLogout.TabStop = true;
            this.linkLogout.Text = "Logout";
            this.linkLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkExit
            // 
            this.linkExit.AutoSize = true;
            this.linkExit.Location = new System.Drawing.Point(604, 720);
            this.linkExit.Name = "linkExit";
            this.linkExit.Size = new System.Drawing.Size(24, 13);
            this.linkExit.TabIndex = 3;
            this.linkExit.TabStop = true;
            this.linkExit.Text = "Exit";
            this.linkExit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkExit_LinkClicked);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 742);
            this.Controls.Add(this.linkExit);
            this.Controls.Add(this.linkLogout);
            this.Controls.Add(this.Heading);
            this.Controls.Add(this.gBoxMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterForm";
            this.Text = "Student Registration - Skills International";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gBoxMain.ResumeLayout(false);
            this.gBoxMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gBoxContactDetails.ResumeLayout(false);
            this.gBoxContactDetails.PerformLayout();
            this.gBoxBasicDetails.ResumeLayout(false);
            this.gBoxBasicDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxMain;
        private System.Windows.Forms.GroupBox gBoxBasicDetails;
        private System.Windows.Forms.Label lblBirth;
        private System.Windows.Forms.Label lblLname;
        private System.Windows.Forms.Label lblFname;
        private System.Windows.Forms.Label lblRegNo;
        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirth;
        private System.Windows.Forms.RadioButton radiobtnFemale;
        private System.Windows.Forms.RadioButton radiobtnMale;
        private System.Windows.Forms.ComboBox comboBoxRegNo;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox gBoxContactDetails;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label lblMobile;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblHome;
        private System.Windows.Forms.TextBox txtHome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.Label lblParentContact;
        private System.Windows.Forms.TextBox txtParentNIC;
        private System.Windows.Forms.Label lblParentNIC;
        private System.Windows.Forms.Label lblParentName;
        private System.Windows.Forms.TextBox txtParentContact;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.LinkLabel linkLogout;
        private System.Windows.Forms.LinkLabel linkExit;
    }
}

