using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplicationCrystalReport
{
    /// <summary>
    /// Name:EmployeeCrystalReport
    /// Description:Search By Field And Display Report according to searching criteria 
    /// Author:Monal shah
    /// Created Date:2010/12/13
    /// </summary>
    public partial class EmployeeCrystalReport : Form
    {
        SqlConnection con = new SqlConnection(System.Configuration.ConfigurationSettings.AppSettings["connection"].ToString());
        SqlDataAdapter objAdp, objAdp1;
        DataTable objdt1;
        public EmployeeCrystalReport()
        { InitializeComponent(); }
        #region EmployeeCrystalReport_Load
        /// <summary>
        /// Name:EmployeeCrystalReport_Load
        /// Description:Bind ComboBox
        /// Author:Monal shah
        /// Created Date:2010/12/13
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmployeeCrystalReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwind_MonalDataSet.DetailsOfEmployee' table. You can move, or remove it, as needed.        
            EmployeesCrystalReport objemp = new EmployeesCrystalReport();
            DataTable objdt = new DataTable();
            try
            {
                crystalReportViewer1.ReportSource = objemp;
                comboSalary.Enabled = false;
                datePickerCombo.Enabled = false;

                string query = ConstantMessage.SalaryBindQuery;
                objAdp = new SqlDataAdapter(query, con);
                objAdp.Fill(objdt);
                comboSalary.DataSource = objdt;
                comboSalary.DisplayMember = "Salary";
                comboSalary.ValueMember = "Salary";
                textBox1.Enabled = true;

                string query1 = ConstantMessage.FieldBindQuery;
                objAdp1 = new SqlDataAdapter(query1, con);
                objdt1 = new DataTable();
                objAdp1.Fill(objdt1);
                comboField.DataSource = objdt1;
                comboField.DisplayMember = "COLUMN_NAME";
                comboField.ValueMember = "COLUMN_NAME";
            }
            finally { objdt1 = null; objAdp1 = null; objdt = null; objAdp = null; con = null; }
        }
        #endregion
        #region BtnSerach_Click
        /// <summary>
        /// Name:BtnSerach_Click
        /// Description:Search By Field And Display Report according to searching criteria 
        /// Author:Monal shah
        /// Created Date:2010/12/13
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSerach_Click(object sender, EventArgs e)
        {
            Searchemployee obj = new Searchemployee();
            SalaryDOBCrystalReport objDob = new SalaryDOBCrystalReport();
            SalaryCrystalReport objSalary = new SalaryCrystalReport();
            crystalReportViewer2.Visible = true;
            obj.SetParameterValue("Field", comboField.SelectedValue.ToString());
            objDob.SetParameterValue("Field", comboField.SelectedValue.ToString());
            objSalary.SetParameterValue("Field", comboField.SelectedValue.ToString());
            if (textBox1.Text != string.Empty && datePickerCombo.Enabled == false && comboSalary.Enabled == false)
            {
                obj.SetParameterValue("Value", textBox1.Text.ToString() + "%");
                crystalReportViewer2.ReportSource = obj;
            }
            else if (comboSalary.SelectedIndex >= 0 && comboSalary.Enabled == true)
            {
                objSalary.SetParameterValue("Equator", comboEquator.SelectedItem.ToString());
                objSalary.SetParameterValue("Values", comboSalary.SelectedValue.ToString());
                crystalReportViewer2.ReportSource = objSalary;
            }
            else if (datePickerCombo.Enabled == true)
            {
                objDob.SetParameterValue("Equator", comboEquator.SelectedItem.ToString());
                objDob.SetParameterValue("Values", datePickerCombo.Value.Date.ToShortDateString());
                crystalReportViewer2.ReportSource = objDob;
            }
        }
        #endregion      
        #region comboField_SelectedIndexChanged
        /// <summary>
        /// Name:comboField_SelectedIndexChanged
        /// Description:Select Searching criteria 
        /// Author:Monal shah
        /// Created Date:2010/12/13
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboField_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboEquator.Enabled = true;
            comboEquator.Items.Remove("Like");
            if (comboField.SelectedValue.ToString() == "Name" || comboField.SelectedValue.ToString() == "Sex" || comboField.SelectedValue.ToString() == "Email" || comboField.SelectedValue.ToString() == "Country_Name" || comboField.SelectedValue.ToString() == "State_Name" || comboField.SelectedValue.ToString() == "City_Name")
            {
                comboEquator.Items.Add("Like");
                comboEquator.SelectedItem = "Like";
                comboEquator.Enabled = false;
                textBox1.Enabled = true;
                comboSalary.Enabled = false;
                datePickerCombo.Enabled = false;
            }
            if (comboField.SelectedValue.ToString() == "Salary")
            {               
                textBox1.Text = string.Empty;
                textBox1.Enabled = false;
                comboSalary.Enabled = true;
                comboSalary.SelectedIndex = 0;
                datePickerCombo.Enabled = false;
            }
            if (comboField.SelectedValue.ToString() == "DOB")
            {                
                textBox1.Text = string.Empty;
                textBox1.Enabled = false;
                comboSalary.SelectedIndex = 0;
                comboSalary.Enabled = false;
                datePickerCombo.Enabled = true;
            }
        }
        #endregion
        #region Btnclose_Click
        /// <summary>
        /// Name:Btnclose_Click
        /// Description:Close form
        /// Author:Monal shah
        /// Created Date:2010/12/13
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>      
        private void Btnclose_Click(object sender, EventArgs e)
        {
            this.Hide();
            DatasetForm dsform = new DatasetForm();
            dsform.Show();
        }
        #endregion

    }
}
