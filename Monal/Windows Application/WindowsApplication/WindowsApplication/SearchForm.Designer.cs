namespace WindowsApplication
{
    partial class SearchForm
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
            this.EmployeePersonalDetails = new System.Windows.Forms.GroupBox();
            this.PnlEmployee = new System.Windows.Forms.Panel();
            this.BtnClose = new System.Windows.Forms.Button();
            this.BtnLast = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.BtnFirst = new System.Windows.Forms.Button();
            this.GrdEmployees = new System.Windows.Forms.DataGridView();
            this.EmployeePersonalDetails.SuspendLayout();
            this.PnlEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrdEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeePersonalDetails
            // 
            this.EmployeePersonalDetails.Controls.Add(this.PnlEmployee);
            this.EmployeePersonalDetails.Location = new System.Drawing.Point(12, 12);
            this.EmployeePersonalDetails.Name = "EmployeePersonalDetails";
            this.EmployeePersonalDetails.Size = new System.Drawing.Size(1005, 257);
            this.EmployeePersonalDetails.TabIndex = 0;
            this.EmployeePersonalDetails.TabStop = false;
            this.EmployeePersonalDetails.Text = "Employee List";
            this.EmployeePersonalDetails.Enter += new System.EventHandler(this.EmployeePersonalDetails_Enter);
            // 
            // PnlEmployee
            // 
            this.PnlEmployee.Controls.Add(this.BtnClose);
            this.PnlEmployee.Controls.Add(this.BtnLast);
            this.PnlEmployee.Controls.Add(this.BtnNext);
            this.PnlEmployee.Controls.Add(this.BtnPrevious);
            this.PnlEmployee.Controls.Add(this.BtnFirst);
            this.PnlEmployee.Controls.Add(this.GrdEmployees);
            this.PnlEmployee.Location = new System.Drawing.Point(7, 20);
            this.PnlEmployee.Name = "PnlEmployee";
            this.PnlEmployee.Size = new System.Drawing.Size(993, 215);
            this.PnlEmployee.TabIndex = 0;
            // 
            // BtnClose
            // 
            this.BtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnClose.Location = new System.Drawing.Point(617, 180);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(75, 23);
            this.BtnClose.TabIndex = 5;
            this.BtnClose.Text = "Close";
            this.BtnClose.UseVisualStyleBackColor = true;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BtnLast
            // 
            this.BtnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLast.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnLast.Location = new System.Drawing.Point(535, 181);
            this.BtnLast.Name = "BtnLast";
            this.BtnLast.Size = new System.Drawing.Size(75, 23);
            this.BtnLast.TabIndex = 4;
            this.BtnLast.Text = "Last >|";
            this.BtnLast.UseVisualStyleBackColor = true;
            this.BtnLast.Click += new System.EventHandler(this.BtnLast_Click);
            // 
            // BtnNext
            // 
            this.BtnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNext.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnNext.Location = new System.Drawing.Point(453, 181);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(75, 23);
            this.BtnNext.TabIndex = 3;
            this.BtnNext.Text = "Next >";
            this.BtnNext.UseVisualStyleBackColor = true;
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrevious.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnPrevious.Location = new System.Drawing.Point(372, 181);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(75, 23);
            this.BtnPrevious.TabIndex = 2;
            this.BtnPrevious.Text = "Previous <";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            this.BtnPrevious.Click += new System.EventHandler(this.BtnPrevious_Click);
            // 
            // BtnFirst
            // 
            this.BtnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFirst.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BtnFirst.Location = new System.Drawing.Point(290, 181);
            this.BtnFirst.Name = "BtnFirst";
            this.BtnFirst.Size = new System.Drawing.Size(75, 23);
            this.BtnFirst.TabIndex = 1;
            this.BtnFirst.Text = "First |<";
            this.BtnFirst.UseVisualStyleBackColor = true;
            this.BtnFirst.Click += new System.EventHandler(this.BtnFirst_Click);
            // 
            // GrdEmployees
            // 
            this.GrdEmployees.BackgroundColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.GrdEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrdEmployees.GridColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.GrdEmployees.Location = new System.Drawing.Point(4, 4);
            this.GrdEmployees.Name = "GrdEmployees";
            this.GrdEmployees.ReadOnly = true;
            this.GrdEmployees.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.GrdEmployees.Size = new System.Drawing.Size(980, 171);
            this.GrdEmployees.TabIndex = 0;
            this.GrdEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GrdEmployees_CellContentClick);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 281);
            this.Controls.Add(this.EmployeePersonalDetails);
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Of Employees";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.EmployeePersonalDetails.ResumeLayout(false);
            this.PnlEmployee.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrdEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
       
        private System.Windows.Forms.GroupBox EmployeePersonalDetails;
        private System.Windows.Forms.Panel PnlEmployee;
        private System.Windows.Forms.DataGridView GrdEmployees;
        private System.Windows.Forms.Button BtnLast;
        private System.Windows.Forms.Button BtnNext;
        private System.Windows.Forms.Button BtnPrevious;
        private System.Windows.Forms.Button BtnFirst;
        private System.Windows.Forms.Button BtnClose;
    }
}