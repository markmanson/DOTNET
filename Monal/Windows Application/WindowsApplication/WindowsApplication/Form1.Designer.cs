namespace WindowsApplication
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
            this.EmployeeGroupBox = new System.Windows.Forms.GroupBox();
            this.Mainpanel = new System.Windows.Forms.Panel();
            this.LblMsg = new System.Windows.Forms.Label();
            this.Innerpanel = new System.Windows.Forms.Panel();
            this.labelCityRequ = new System.Windows.Forms.Label();
            this.labelStateRequ = new System.Windows.Forms.Label();
            this.LabelFaxRequ = new System.Windows.Forms.Label();
            this.labelCountry = new System.Windows.Forms.Label();
            this.labelSalary = new System.Windows.Forms.Label();
            this.labelDOBRequ = new System.Windows.Forms.Label();
            this.labelPasswordReq = new System.Windows.Forms.Label();
            this.LblEMailReqired = new System.Windows.Forms.Label();
            this.LblRequired = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.DatePickerValue = new System.Windows.Forms.DateTimePicker();
            this.LblFaxForat = new System.Windows.Forms.Label();
            this.BtnSubmit = new System.Windows.Forms.Button();
            this.RbtnFemale = new System.Windows.Forms.RadioButton();
            this.RbtnMale = new System.Windows.Forms.RadioButton();
            this.ComboCity = new System.Windows.Forms.ComboBox();
            this.comboState = new System.Windows.Forms.ComboBox();
            this.ComboCountry = new System.Windows.Forms.ComboBox();
            this.txtFax = new System.Windows.Forms.TextBox();
            this.ComboSalary = new System.Windows.Forms.ComboBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.LblSalary = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblState = new System.Windows.Forms.Label();
            this.LblCountry = new System.Windows.Forms.Label();
            this.LblFax = new System.Windows.Forms.Label();
            this.LblDob = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblRegister = new System.Windows.Forms.Label();
            this.EmployeeGroupBox.SuspendLayout();
            this.Mainpanel.SuspendLayout();
            this.Innerpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmployeeGroupBox
            // 
            this.EmployeeGroupBox.Controls.Add(this.Mainpanel);
            this.EmployeeGroupBox.Location = new System.Drawing.Point(13, 13);
            this.EmployeeGroupBox.Name = "EmployeeGroupBox";
            this.EmployeeGroupBox.Size = new System.Drawing.Size(755, 467);
            this.EmployeeGroupBox.TabIndex = 0;
            this.EmployeeGroupBox.TabStop = false;
            this.EmployeeGroupBox.Text = "Employee Details";
            // 
            // Mainpanel
            // 
            this.Mainpanel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Mainpanel.Controls.Add(this.LblMsg);
            this.Mainpanel.Controls.Add(this.Innerpanel);
            this.Mainpanel.Controls.Add(this.lblRegister);
            this.Mainpanel.Location = new System.Drawing.Point(7, 19);
            this.Mainpanel.Name = "Mainpanel";
            this.Mainpanel.Size = new System.Drawing.Size(742, 442);
            this.Mainpanel.TabIndex = 0;
            // 
            // LblMsg
            // 
            this.LblMsg.AutoSize = true;
            this.LblMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMsg.ForeColor = System.Drawing.Color.Red;
            this.LblMsg.Location = new System.Drawing.Point(7, 10);
            this.LblMsg.Name = "LblMsg";
            this.LblMsg.Size = new System.Drawing.Size(0, 13);
            this.LblMsg.TabIndex = 1;
            this.LblMsg.Visible = false;
            // 
            // Innerpanel
            // 
            this.Innerpanel.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Innerpanel.Controls.Add(this.labelCityRequ);
            this.Innerpanel.Controls.Add(this.labelStateRequ);
            this.Innerpanel.Controls.Add(this.LabelFaxRequ);
            this.Innerpanel.Controls.Add(this.labelCountry);
            this.Innerpanel.Controls.Add(this.labelSalary);
            this.Innerpanel.Controls.Add(this.labelDOBRequ);
            this.Innerpanel.Controls.Add(this.labelPasswordReq);
            this.Innerpanel.Controls.Add(this.LblEMailReqired);
            this.Innerpanel.Controls.Add(this.LblRequired);
            this.Innerpanel.Controls.Add(this.BtnClose);
            this.Innerpanel.Controls.Add(this.btnClear);
            this.Innerpanel.Controls.Add(this.DatePickerValue);
            this.Innerpanel.Controls.Add(this.LblFaxForat);
            this.Innerpanel.Controls.Add(this.BtnSubmit);
            this.Innerpanel.Controls.Add(this.RbtnFemale);
            this.Innerpanel.Controls.Add(this.RbtnMale);
            this.Innerpanel.Controls.Add(this.ComboCity);
            this.Innerpanel.Controls.Add(this.comboState);
            this.Innerpanel.Controls.Add(this.ComboCountry);
            this.Innerpanel.Controls.Add(this.txtFax);
            this.Innerpanel.Controls.Add(this.ComboSalary);
            this.Innerpanel.Controls.Add(this.txtPwd);
            this.Innerpanel.Controls.Add(this.txtEmail);
            this.Innerpanel.Controls.Add(this.TxtName);
            this.Innerpanel.Controls.Add(this.LblSalary);
            this.Innerpanel.Controls.Add(this.lblCity);
            this.Innerpanel.Controls.Add(this.lblState);
            this.Innerpanel.Controls.Add(this.LblCountry);
            this.Innerpanel.Controls.Add(this.LblFax);
            this.Innerpanel.Controls.Add(this.LblDob);
            this.Innerpanel.Controls.Add(this.lblPwd);
            this.Innerpanel.Controls.Add(this.lblEmail);
            this.Innerpanel.Controls.Add(this.lblSex);
            this.Innerpanel.Controls.Add(this.lblName);
            this.Innerpanel.Location = new System.Drawing.Point(3, 47);
            this.Innerpanel.Name = "Innerpanel";
            this.Innerpanel.Size = new System.Drawing.Size(736, 383);
            this.Innerpanel.TabIndex = 1;
            // 
            // labelCityRequ
            // 
            this.labelCityRequ.AutoSize = true;
            this.labelCityRequ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCityRequ.ForeColor = System.Drawing.Color.Red;
            this.labelCityRequ.Location = new System.Drawing.Point(282, 294);
            this.labelCityRequ.Name = "labelCityRequ";
            this.labelCityRequ.Size = new System.Drawing.Size(14, 17);
            this.labelCityRequ.TabIndex = 35;
            this.labelCityRequ.Text = "*";
            // 
            // labelStateRequ
            // 
            this.labelStateRequ.AutoSize = true;
            this.labelStateRequ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStateRequ.ForeColor = System.Drawing.Color.Red;
            this.labelStateRequ.Location = new System.Drawing.Point(282, 263);
            this.labelStateRequ.Name = "labelStateRequ";
            this.labelStateRequ.Size = new System.Drawing.Size(14, 17);
            this.labelStateRequ.TabIndex = 34;
            this.labelStateRequ.Text = "*";
            // 
            // LabelFaxRequ
            // 
            this.LabelFaxRequ.AutoSize = true;
            this.LabelFaxRequ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelFaxRequ.ForeColor = System.Drawing.Color.Red;
            this.LabelFaxRequ.Location = new System.Drawing.Point(282, 198);
            this.LabelFaxRequ.Name = "LabelFaxRequ";
            this.LabelFaxRequ.Size = new System.Drawing.Size(14, 17);
            this.LabelFaxRequ.TabIndex = 33;
            this.LabelFaxRequ.Text = "*";
            // 
            // labelCountry
            // 
            this.labelCountry.AutoSize = true;
            this.labelCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountry.ForeColor = System.Drawing.Color.Red;
            this.labelCountry.Location = new System.Drawing.Point(282, 235);
            this.labelCountry.Name = "labelCountry";
            this.labelCountry.Size = new System.Drawing.Size(14, 17);
            this.labelCountry.TabIndex = 32;
            this.labelCountry.Text = "*";
            // 
            // labelSalary
            // 
            this.labelSalary.AutoSize = true;
            this.labelSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalary.ForeColor = System.Drawing.Color.Red;
            this.labelSalary.Location = new System.Drawing.Point(282, 168);
            this.labelSalary.Name = "labelSalary";
            this.labelSalary.Size = new System.Drawing.Size(14, 17);
            this.labelSalary.TabIndex = 31;
            this.labelSalary.Text = "*";
            // 
            // labelDOBRequ
            // 
            this.labelDOBRequ.AutoSize = true;
            this.labelDOBRequ.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDOBRequ.ForeColor = System.Drawing.Color.Red;
            this.labelDOBRequ.Location = new System.Drawing.Point(282, 136);
            this.labelDOBRequ.Name = "labelDOBRequ";
            this.labelDOBRequ.Size = new System.Drawing.Size(14, 17);
            this.labelDOBRequ.TabIndex = 30;
            this.labelDOBRequ.Text = "*";
            // 
            // labelPasswordReq
            // 
            this.labelPasswordReq.AutoSize = true;
            this.labelPasswordReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPasswordReq.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordReq.Location = new System.Drawing.Point(282, 102);
            this.labelPasswordReq.Name = "labelPasswordReq";
            this.labelPasswordReq.Size = new System.Drawing.Size(14, 17);
            this.labelPasswordReq.TabIndex = 29;
            this.labelPasswordReq.Text = "*";
            // 
            // LblEMailReqired
            // 
            this.LblEMailReqired.AutoSize = true;
            this.LblEMailReqired.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEMailReqired.ForeColor = System.Drawing.Color.Red;
            this.LblEMailReqired.Location = new System.Drawing.Point(282, 77);
            this.LblEMailReqired.Name = "LblEMailReqired";
            this.LblEMailReqired.Size = new System.Drawing.Size(14, 17);
            this.LblEMailReqired.TabIndex = 28;
            this.LblEMailReqired.Text = "*";
            // 
            // LblRequired
            // 
            this.LblRequired.AutoSize = true;
            this.LblRequired.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRequired.ForeColor = System.Drawing.Color.Red;
            this.LblRequired.Location = new System.Drawing.Point(282, 10);
            this.LblRequired.Name = "LblRequired";
            this.LblRequired.Size = new System.Drawing.Size(14, 17);
            this.LblRequired.TabIndex = 27;
            this.LblRequired.Text = "*";
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnClose.Location = new System.Drawing.Point(188, 335);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 14;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnClear.Location = new System.Drawing.Point(98, 335);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // DatePickerValue
            // 
            this.DatePickerValue.CalendarForeColor = System.Drawing.SystemColors.Highlight;
            this.DatePickerValue.CalendarTitleBackColor = System.Drawing.SystemColors.Highlight;
            this.DatePickerValue.CalendarTitleForeColor = System.Drawing.SystemColors.HighlightText;
            this.DatePickerValue.CalendarTrailingForeColor = System.Drawing.SystemColors.Highlight;
            this.DatePickerValue.CustomFormat = "yyyy/MM/dd";
            this.DatePickerValue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DatePickerValue.Location = new System.Drawing.Point(98, 132);
            this.DatePickerValue.Name = "DatePickerValue";
            this.DatePickerValue.Size = new System.Drawing.Size(178, 20);
            this.DatePickerValue.TabIndex = 6;
            // 
            // LblFaxForat
            // 
            this.LblFaxForat.AutoSize = true;
            this.LblFaxForat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFaxForat.ForeColor = System.Drawing.Color.Red;
            this.LblFaxForat.Location = new System.Drawing.Point(296, 198);
            this.LblFaxForat.Name = "LblFaxForat";
            this.LblFaxForat.Size = new System.Drawing.Size(89, 13);
            this.LblFaxForat.TabIndex = 24;
            this.LblFaxForat.Text = "(555)222-8888";
            // 
            // BtnSubmit
            // 
            this.BtnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmit.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnSubmit.Location = new System.Drawing.Point(7, 335);
            this.BtnSubmit.Name = "BtnSubmit";
            this.BtnSubmit.Size = new System.Drawing.Size(75, 23);
            this.BtnSubmit.TabIndex = 12;
            this.BtnSubmit.Text = "Submit";
            this.BtnSubmit.UseVisualStyleBackColor = true;
            this.BtnSubmit.Click += new System.EventHandler(this.BtnSubmit_Click);
            // 
            // RbtnFemale
            // 
            this.RbtnFemale.AutoSize = true;
            this.RbtnFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtnFemale.ForeColor = System.Drawing.SystemColors.Highlight;
            this.RbtnFemale.Location = new System.Drawing.Point(139, 36);
            this.RbtnFemale.Name = "RbtnFemale";
            this.RbtnFemale.Size = new System.Drawing.Size(32, 17);
            this.RbtnFemale.TabIndex = 3;
            this.RbtnFemale.Text = "F";
            this.RbtnFemale.UseVisualStyleBackColor = true;
            // 
            // RbtnMale
            // 
            this.RbtnMale.AutoSize = true;
            this.RbtnMale.Checked = true;
            this.RbtnMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbtnMale.ForeColor = System.Drawing.SystemColors.Highlight;
            this.RbtnMale.Location = new System.Drawing.Point(98, 36);
            this.RbtnMale.Name = "RbtnMale";
            this.RbtnMale.Size = new System.Drawing.Size(35, 17);
            this.RbtnMale.TabIndex = 2;
            this.RbtnMale.TabStop = true;
            this.RbtnMale.Text = "M";
            this.RbtnMale.UseVisualStyleBackColor = true;
            // 
            // ComboCity
            // 
            this.ComboCity.Enabled = false;
            this.ComboCity.FormattingEnabled = true;
            this.ComboCity.Location = new System.Drawing.Point(98, 290);
            this.ComboCity.Name = "ComboCity";
            this.ComboCity.Size = new System.Drawing.Size(178, 21);
            this.ComboCity.TabIndex = 11;
            this.ComboCity.SelectedIndexChanged += new System.EventHandler(this.ComboCity_SelectedIndexChanged);
            // 
            // comboState
            // 
            this.comboState.Enabled = false;
            this.comboState.FormattingEnabled = true;
            this.comboState.Location = new System.Drawing.Point(98, 259);
            this.comboState.Name = "comboState";
            this.comboState.Size = new System.Drawing.Size(178, 21);
            this.comboState.TabIndex = 10;
            this.comboState.SelectedIndexChanged += new System.EventHandler(this.comboState_SelectedIndexChanged);
            // 
            // ComboCountry
            // 
            this.ComboCountry.DisplayMember = "Country_Name";
            this.ComboCountry.FormattingEnabled = true;
            this.ComboCountry.Location = new System.Drawing.Point(98, 227);
            this.ComboCountry.Name = "ComboCountry";
            this.ComboCountry.Size = new System.Drawing.Size(178, 21);
            this.ComboCountry.TabIndex = 9;
            this.ComboCountry.SelectedIndexChanged += new System.EventHandler(this.ComboCountry_SelectedIndexChanged);
            // 
            // txtFax
            // 
            this.txtFax.Location = new System.Drawing.Point(98, 195);
            this.txtFax.MaxLength = 24;
            this.txtFax.Name = "txtFax";
            this.txtFax.Size = new System.Drawing.Size(178, 20);
            this.txtFax.TabIndex = 8;
            // 
            // ComboSalary
            // 
            this.ComboSalary.DisplayMember = "Salary";
            this.ComboSalary.FormattingEnabled = true;
            this.ComboSalary.Location = new System.Drawing.Point(98, 164);
            this.ComboSalary.Name = "ComboSalary";
            this.ComboSalary.Size = new System.Drawing.Size(178, 21);
            this.ComboSalary.TabIndex = 7;
            this.ComboSalary.ValueMember = "Salary";
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(98, 99);
            this.txtPwd.MaxLength = 8;
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(178, 20);
            this.txtPwd.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(98, 70);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(178, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(98, 7);
            this.TxtName.MaxLength = 50;
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(178, 20);
            this.TxtName.TabIndex = 1;
            // 
            // LblSalary
            // 
            this.LblSalary.AutoSize = true;
            this.LblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSalary.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LblSalary.Location = new System.Drawing.Point(4, 164);
            this.LblSalary.Name = "LblSalary";
            this.LblSalary.Size = new System.Drawing.Size(42, 13);
            this.LblSalary.TabIndex = 9;
            this.LblSalary.Text = "Salary";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblCity.Location = new System.Drawing.Point(4, 290);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(28, 13);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = "City";
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblState.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblState.Location = new System.Drawing.Point(4, 259);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(37, 13);
            this.lblState.TabIndex = 7;
            this.lblState.Text = "State";
            // 
            // LblCountry
            // 
            this.LblCountry.AutoSize = true;
            this.LblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCountry.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LblCountry.Location = new System.Drawing.Point(4, 227);
            this.LblCountry.Name = "LblCountry";
            this.LblCountry.Size = new System.Drawing.Size(50, 13);
            this.LblCountry.TabIndex = 6;
            this.LblCountry.Text = "Country";
            // 
            // LblFax
            // 
            this.LblFax.AutoSize = true;
            this.LblFax.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFax.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LblFax.Location = new System.Drawing.Point(3, 196);
            this.LblFax.Name = "LblFax";
            this.LblFax.Size = new System.Drawing.Size(47, 13);
            this.LblFax.TabIndex = 5;
            this.LblFax.Text = "Fax No";
            // 
            // LblDob
            // 
            this.LblDob.AutoSize = true;
            this.LblDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDob.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LblDob.Location = new System.Drawing.Point(4, 132);
            this.LblDob.Name = "LblDob";
            this.LblDob.Size = new System.Drawing.Size(33, 13);
            this.LblDob.TabIndex = 4;
            this.LblDob.Text = "DOB";
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPwd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblPwd.Location = new System.Drawing.Point(4, 102);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(61, 13);
            this.lblPwd.TabIndex = 3;
            this.lblPwd.Text = "Password";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblEmail.Location = new System.Drawing.Point(4, 70);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(37, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblSex.Location = new System.Drawing.Point(4, 36);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(28, 13);
            this.lblSex.TabIndex = 1;
            this.lblSex.Text = "Sex";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblName.Location = new System.Drawing.Point(4, 7);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblRegister
            // 
            this.lblRegister.AutoSize = true;
            this.lblRegister.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRegister.Font = new System.Drawing.Font("Bookman Old Style", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegister.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblRegister.Location = new System.Drawing.Point(7, 27);
            this.lblRegister.Name = "lblRegister";
            this.lblRegister.Size = new System.Drawing.Size(199, 17);
            this.lblRegister.TabIndex = 0;
            this.lblRegister.Text = "Register Employee Details";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 492);
            this.Controls.Add(this.EmployeeGroupBox);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registeration Form";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.EmployeeGroupBox.ResumeLayout(false);
            this.Mainpanel.ResumeLayout(false);
            this.Mainpanel.PerformLayout();
            this.Innerpanel.ResumeLayout(false);
            this.Innerpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox EmployeeGroupBox;
        private System.Windows.Forms.Panel Mainpanel;
        private System.Windows.Forms.Label lblRegister;
        private System.Windows.Forms.Panel Innerpanel;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label LblSalary;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.Label LblCountry;
        private System.Windows.Forms.Label LblFax;
        private System.Windows.Forms.Label LblDob;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox txtFax;
        private System.Windows.Forms.ComboBox ComboSalary;
        private System.Windows.Forms.Button BtnSubmit;
        private System.Windows.Forms.RadioButton RbtnFemale;
        private System.Windows.Forms.RadioButton RbtnMale;
        private System.Windows.Forms.ComboBox ComboCity;
        private System.Windows.Forms.ComboBox comboState;
        private System.Windows.Forms.ComboBox ComboCountry;
        private System.Windows.Forms.Label LblMsg;
        private System.Windows.Forms.Label LblFaxForat;
        private System.Windows.Forms.DateTimePicker DatePickerValue;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button BtnClose;
        private System.Windows.Forms.Label labelCountry;
        private System.Windows.Forms.Label labelSalary;
        private System.Windows.Forms.Label labelDOBRequ;
        private System.Windows.Forms.Label labelPasswordReq;
        private System.Windows.Forms.Label LblEMailReqired;
        private System.Windows.Forms.Label LblRequired;
        private System.Windows.Forms.Label LabelFaxRequ;
        private System.Windows.Forms.Label labelCityRequ;
        private System.Windows.Forms.Label labelStateRequ;
    }
}

