namespace WindowsFormsApplicationCrystalReport
{
    partial class EmployeeCrystalReport
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.LblSearch = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.BtnSerach = new System.Windows.Forms.Button();
            this.crystalReportViewer2 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboSalary = new System.Windows.Forms.ComboBox();
            this.LblSalary = new System.Windows.Forms.Label();
            this.datePickerCombo = new System.Windows.Forms.DateTimePicker();
            this.LblDate = new System.Windows.Forms.Label();
            this.comboEquator = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboField = new System.Windows.Forms.ComboBox();
            this.employeesCrystalReport1 = new WindowsFormsApplicationCrystalReport.EmployeesCrystalReport();
            this.Btnclose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Location = new System.Drawing.Point(3, 238);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.SelectionFormula = "";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1277, 311);
            this.crystalReportViewer1.TabIndex = 6;
            this.crystalReportViewer1.ViewTimeSelectionFormula = "";
            // 
            // LblSearch
            // 
            this.LblSearch.AutoSize = true;
            this.LblSearch.Font = new System.Drawing.Font("Times New Roman", 12.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.LblSearch.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LblSearch.Location = new System.Drawing.Point(12, 9);
            this.LblSearch.Name = "LblSearch";
            this.LblSearch.Size = new System.Drawing.Size(193, 19);
            this.LblSearch.TabIndex = 1;
            this.LblSearch.Text = "Search Employee Details";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelName.Location = new System.Drawing.Point(12, 52);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(74, 13);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "FieldName :";
            // 
            // BtnSerach
            // 
            this.BtnSerach.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.BtnSerach.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnSerach.Location = new System.Drawing.Point(28, 209);
            this.BtnSerach.Name = "BtnSerach";
            this.BtnSerach.Size = new System.Drawing.Size(75, 23);
            this.BtnSerach.TabIndex = 5;
            this.BtnSerach.Text = "Search";
            this.BtnSerach.UseVisualStyleBackColor = true;
            this.BtnSerach.Click += new System.EventHandler(this.BtnSerach_Click);
            // 
            // crystalReportViewer2
            // 
            this.crystalReportViewer2.ActiveViewIndex = -1;
            this.crystalReportViewer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer2.Location = new System.Drawing.Point(282, -1);
            this.crystalReportViewer2.Name = "crystalReportViewer2";
            this.crystalReportViewer2.SelectionFormula = "";
            this.crystalReportViewer2.Size = new System.Drawing.Size(998, 233);
            this.crystalReportViewer2.TabIndex = 7;
            this.crystalReportViewer2.ViewTimeSelectionFormula = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(0, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ValueName :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(86, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 20);
            this.textBox1.TabIndex = 2;
            // 
            // comboSalary
            // 
            this.comboSalary.FormattingEnabled = true;
            this.comboSalary.Location = new System.Drawing.Point(86, 149);
            this.comboSalary.Name = "comboSalary";
            this.comboSalary.Size = new System.Drawing.Size(109, 21);
            this.comboSalary.TabIndex = 3;
            // 
            // LblSalary
            // 
            this.LblSalary.AutoSize = true;
            this.LblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.LblSalary.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LblSalary.Location = new System.Drawing.Point(12, 154);
            this.LblSalary.Name = "LblSalary";
            this.LblSalary.Size = new System.Drawing.Size(50, 13);
            this.LblSalary.TabIndex = 9;
            this.LblSalary.Text = "Salary :";
            // 
            // datePickerCombo
            // 
            this.datePickerCombo.CustomFormat = "yyyy/MM/dd";
            this.datePickerCombo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePickerCombo.Location = new System.Drawing.Point(86, 183);
            this.datePickerCombo.Name = "datePickerCombo";
            this.datePickerCombo.Size = new System.Drawing.Size(109, 20);
            this.datePickerCombo.TabIndex = 4;
            // 
            // LblDate
            // 
            this.LblDate.AutoSize = true;
            this.LblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.LblDate.ForeColor = System.Drawing.SystemColors.Highlight;
            this.LblDate.Location = new System.Drawing.Point(12, 189);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(42, 13);
            this.LblDate.TabIndex = 11;
            this.LblDate.Text = "Date :";
            // 
            // comboEquator
            // 
            this.comboEquator.FormattingEnabled = true;
            this.comboEquator.Items.AddRange(new object[] {
            "!=",
            "<",
            "<=",
            "=",
            ">",
            ">="});
            this.comboEquator.Location = new System.Drawing.Point(86, 85);
            this.comboEquator.Name = "comboEquator";
            this.comboEquator.Size = new System.Drawing.Size(57, 21);
            this.comboEquator.Sorted = true;
            this.comboEquator.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(16, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Equator :";
            // 
            // comboField
            // 
            this.comboField.DisplayMember = "--Select--";
            this.comboField.FormattingEnabled = true;
            this.comboField.Location = new System.Drawing.Point(86, 52);
            this.comboField.Name = "comboField";
            this.comboField.Size = new System.Drawing.Size(109, 21);
            this.comboField.TabIndex = 0;
            this.comboField.SelectedIndexChanged += new System.EventHandler(this.comboField_SelectedIndexChanged);
            // 
            // Btnclose
            // 
            this.Btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnclose.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Btnclose.Location = new System.Drawing.Point(109, 209);
            this.Btnclose.Name = "Btnclose";
            this.Btnclose.Size = new System.Drawing.Size(75, 23);
            this.Btnclose.TabIndex = 14;
            this.Btnclose.Text = "Close";
            this.Btnclose.UseVisualStyleBackColor = true;
            this.Btnclose.Click += new System.EventHandler(this.Btnclose_Click);
            // 
            // EmployeeCrystalReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 569);
            this.Controls.Add(this.Btnclose);
            this.Controls.Add(this.comboField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboEquator);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.datePickerCombo);
            this.Controls.Add(this.LblSalary);
            this.Controls.Add(this.comboSalary);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.crystalReportViewer2);
            this.Controls.Add(this.BtnSerach);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.LblSearch);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "EmployeeCrystalReport";
            this.Text = "Employee Report";
            this.Load += new System.EventHandler(this.EmployeeCrystalReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label LblSearch;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button BtnSerach;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer2;
        private EmployeesCrystalReport employeesCrystalReport1;
     
        private System.Windows.Forms.BindingSource detailsOfEmployeeBindingSource;
        
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboSalary;
        private System.Windows.Forms.Label LblSalary;
        private System.Windows.Forms.DateTimePicker datePickerCombo;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.ComboBox comboEquator;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboField;
        private System.Windows.Forms.Button Btnclose;
    }
}

