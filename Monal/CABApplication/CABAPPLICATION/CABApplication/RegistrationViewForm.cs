using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Practices.CompositeUI.SmartParts;
using Microsoft.Practices.ObjectBuilder;

namespace CABApplication
{
    /// <summary>
    /// Name:RegistrationViewForm
    /// Description:Make Employee Registration Form With Validation
    /// Author Name:Monal Shah
    /// Created Date:2010/12/20
    /// </summary>
    [SmartPart]
    public partial class RegistrationViewForm : UserControl
    {
        private RegisterController controller;
        CommonLogic objCl = new CommonLogic();
        DataTable objDt, objDt1, objDt2;
        StringBuilder ObjSb;
        int CountryId, StateId, CityId;
        public RegistrationViewForm()
        {
            InitializeComponent();
        }

        [CreateNew]
        public RegisterController Controller
        {
            set { controller = value; }
        }
        #region BtnSubmit_Click
        /// <summary>
        /// Name:BtnSubmit_Click
        /// Description:Make Validation and then Insert into Table
        /// Author Name:Monal Shah
        /// Created Date:2010/12/20
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSubmit_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(CommonLogic.GetConnectionString);
            SqlCommand ObjCmd = new SqlCommand();
            Match rexName = Regex.Match(TxtName.Text, "^[a-zA-Z\\ ]+$");
            Match rexMail = Regex.Match(txtEmail.Text.Trim(' '), "^([0-9a-zA-Z]([-.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,4})$", RegexOptions.IgnoreCase);
            Match rexFax = Regex.Match(txtFax.Text.Trim(' '), "^[01]?[- .]?(\\([2-9]\\d{2}\\)|[2-9]\\d{2})[- .]?\\d{3}[- .]?\\d{4}$");
            try
            {
                if (TxtName.Text == string.Empty || TxtName.Text == null)
                { MessageBox.Show("Please enter Name", "Enter Name"); TxtName.Focus(); }
                else if (rexName.Success == false)
                { MessageBox.Show("Please Enter Valid Name", "Enter Valid Name"); TxtName.Focus(); }
                else if (txtEmail.Text == string.Empty)
                { MessageBox.Show("Please Enter Email Address", "Enter Email Id"); txtEmail.Focus(); }
                else if (rexMail.Success == false)
                { MessageBox.Show("Please Enter Valid Email Address", "Enter Valid Email Id"); txtEmail.Focus(); }
                else if (txtPwd.Text == string.Empty || txtPwd.Text == null)
                { MessageBox.Show("Please Enter Password", "Enter Password"); txtPwd.Focus(); }
                else if (DatePickerValue.Value > System.DateTime.Now)
                { MessageBox.Show("Please Enter Less Than Current Date Value", "Enter Date"); DatePickerValue.Focus(); }
                else if (txtFax.Text == string.Empty)
                { MessageBox.Show("Please Enter Fax no.", "Enter Fax"); txtFax.Focus(); }
                else if (rexFax.Success == false)
                { MessageBox.Show("Please Enter Valid Fax no.", "Enter Valid Fax"); txtFax.Focus(); }
                else if (ComboCountry.SelectedIndex == 0)
                { MessageBox.Show("Please Select Country", "Select Country"); ComboCountry.Focus(); }
                else if (comboState.Enabled == true)
                {
                    if (comboState.SelectedIndex == 0)
                    { MessageBox.Show("Please Select State", "Select State"); comboState.Focus(); }
                    else if (ComboCity.Enabled == true)
                    { if (ComboCity.SelectedIndex == 0) { MessageBox.Show("Please Select City", "Select City"); ComboCity.Focus(); } }
                }
                if (ComboCity.SelectedIndex > 0)
                {
                    objDt = new DataTable();
                    ObjSb = new StringBuilder();
                    ObjSb.Append("Insert ");
                    ObjSb.Append("Into ");
                    ObjSb.Append("DetailsOfEmployee ");
                    ObjSb.Append("(Name,Sex,Email,DOB,PasswordValue,FaxNo,Country_Id,State_Id,City_Id,Salary)");
                    ObjSb.Append("Values ");
                    ObjSb.Append("(");
                    ObjSb.Append("'");
                    ObjSb.Append(TxtName.Text);
                    ObjSb.Append("'");
                    ObjSb.Append(",");
                    ObjSb.Append("'");
                    if (RbtnMale.Checked)
                        ObjSb.Append(RbtnMale.Text.ToString());
                    if (RbtnFemale.Checked)
                        ObjSb.Append(RbtnFemale.Text.ToString());
                    ObjSb.Append("'");
                    ObjSb.Append(",");
                    ObjSb.Append("'");
                    ObjSb.Append(txtEmail.Text);
                    ObjSb.Append("'");
                    ObjSb.Append(",");
                    ObjSb.Append("'");
                    ObjSb.Append(DatePickerValue.Text);
                    ObjSb.Append("'");
                    ObjSb.Append(",");
                    ObjSb.Append("'");
                    ObjSb.Append(txtPwd.Text);
                    ObjSb.Append("'");
                    ObjSb.Append(",");
                    ObjSb.Append("'");
                    ObjSb.Append(txtFax.Text);
                    ObjSb.Append("'");
                    ObjSb.Append(",");
                    ObjSb.Append("'");
                    ObjSb.Append(CountryId);
                    ObjSb.Append("'");
                    ObjSb.Append(",");
                    ObjSb.Append("'");
                    if (comboState.Enabled == true)
                        ObjSb.Append(StateId);
                    ObjSb.Append("'");
                    ObjSb.Append(",");
                    ObjSb.Append("'");
                    if (ComboCity.Enabled == true)
                        ObjSb.Append(CityId);
                    ObjSb.Append("'");
                    ObjSb.Append(",");
                    ObjSb.Append("'");
                    ObjSb.Append(Convert.ToInt32(ComboSalary.SelectedValue));
                    ObjSb.Append("'");
                    ObjSb.Append(")");
                    ObjCmd.CommandType = CommandType.Text;
                    ObjCmd.Connection = con;
                    ObjCmd.CommandText = ObjSb.ToString();
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    ObjCmd.ExecuteNonQuery();
                    LblMsg.Visible = true;
                    LblMsg.Text = ConstantMessage.InsertSuccessFully;
                    ClearControls();
                }
            }
            finally
            { ObjCmd.Dispose(); con.Close(); ObjSb = null; }
        }
        #endregion
        #region EmployeeGroupBox_Enter
        /// <summary>
        /// Name:EmployeeGroupBox_Enter
        /// Description:Bind DropDown
        /// Author Name:Monal Shah
        /// Created Date:2010/12/20
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EmployeeGroupBox_Enter(object sender, EventArgs e)
        {
            TxtName.Focus();

            try
            {
                objDt = new DataTable();
                objDt = objCl.BindDropDown(ConstantMessage.EmployeeTableName, ConstantMessage.SalaryValue);
                ComboSalary.DataSource = objDt;

                objDt1 = new DataTable();
                objDt1 = objCl.BindDropDown(ConstantMessage.CountryTableName, "Country_Id", ConstantMessage.CountryNameValue);

                DataRow row = objDt1.NewRow();
                row["Label"] = "--Select--";
                row["Value"] = 0;
                objDt1.Rows.InsertAt(row, 0);
                ComboCountry.DisplayMember = "Label";
                ComboCountry.ValueMember = "Value";
                ComboCountry.DataSource = objDt1;
                ComboCountry.SelectedIndex = 0;

                objDt1 = objCl.BindDropDown(ConstantMessage.StateTableName, "State_Id", ConstantMessage.StateNameValue);
                DataRow row1 = objDt1.NewRow();
                row1["Label"] = "--Select--";
                row1["Value"] = 0;
                objDt1.Rows.InsertAt(row1, 0);
                comboState.DisplayMember = "Label";
                comboState.ValueMember = "Value";
                comboState.DataSource = objDt1;
                comboState.SelectedIndex = 0;

                objDt1 = objCl.BindDropDown(ConstantMessage.CityTableName, "City_Id", ConstantMessage.CityNameValue);
                DataRow row2 = objDt1.NewRow();
                row2["Label"] = "--Select--";
                row2["Value"] = 0;
                objDt1.Rows.InsertAt(row2, 0);
                ComboCity.DisplayMember = "Label";
                ComboCity.ValueMember = "Value";
                ComboCity.DataSource = objDt1;
                ComboCity.SelectedIndex = 0;

            }
            catch (Exception ex) { throw ex; }
            finally { objDt1 = null; objDt = null; }
        }
        #endregion
        #region ComboCountry_SelectedIndexChanged
        /// <summary>
        /// Name:ComboCountry_SelectedIndexChanged
        /// Description:Bind State DropDown Based On Selected Country
        /// Author Name:Monal Shah
        /// Created Date:2010/12/20
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboCountry_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                objDt = new DataTable();
                if (ComboCountry.SelectedIndex != 0)
                {
                    objDt = objCl.BindDropDown(ConstantMessage.CountryTableName, ConstantMessage.CountryNameValue, "Country_Id", Convert.ToInt32(ComboCountry.SelectedValue));
                    CountryId = Convert.ToInt32(objDt.Rows[0]["Country_Id"]);
                    objDt1 = new DataTable();
                    objDt1 = objCl.BindDropDown("TblState.State_Name", "TblState.State_Id", ConstantMessage.StateTableName, ConstantMessage.CountryTableName, "TblCountry.Country_Id", "TblState.Country_Id", "TblCountry.Country_Id", CountryId);

                    if (objDt1.Rows.Count > 0)
                    {
                        DataRow row1 = objDt1.NewRow();
                        row1["Label"] = "--Select--";
                        row1["Value"] = 0;
                        objDt1.Rows.InsertAt(row1, 0);
                        comboState.DisplayMember = "Label";
                        comboState.ValueMember = "Value";
                        comboState.DataSource = objDt1;
                        comboState.SelectedIndex = 0;
                        comboState.Enabled = true;
                    }
                    else
                    {
                        comboState.Enabled = false; ComboCity.Enabled = false;
                        if (comboState.SelectedIndex >= 0)
                            comboState.SelectedIndex = 0;
                        if (ComboCity.SelectedIndex >= 0)
                            ComboCity.SelectedIndex = 0;
                    }
                }
                else { comboState.SelectedIndex = -1; ComboCity.SelectedIndex = -1; comboState.Enabled = false; ComboCity.Enabled = false; }
            }
            catch (Exception ex) { throw ex; }
        }
        #endregion
        #region comboState_SelectedIndexChanged
        /// <summary>
        /// Name:comboState_SelectedIndexChanged
        /// Description:Bind City DropDown Based On Selected state
        /// Author Name:Monal Shah
        /// Created Date:2010/12/20
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboState_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                if (ComboCountry.SelectedIndex != 0)
                {
                    if (comboState.SelectedIndex != 0)
                    {
                        objDt = new DataTable();
                        objDt = objCl.BindDropDown(ConstantMessage.StateTableName, ConstantMessage.StateNameValue, "State_Id", Convert.ToInt32(comboState.SelectedValue));
                        StateId = Convert.ToInt32(objDt.Rows[0]["State_Id"]);
                        objDt1 = new DataTable();
                        objDt1 = objCl.BindDropDown("TblCity.City_Name", "TblCity.City_Id", ConstantMessage.CityTableName, ConstantMessage.StateTableName, "TblState.State_Id", "TblCity.State_Id", "TblState.State_Id", StateId);
                        if (objDt1.Rows.Count > 0)
                        {
                            DataRow row2 = objDt1.NewRow();
                            row2["Label"] = "--Select--";
                            row2["Value"] = 0;
                            objDt1.Rows.InsertAt(row2, 0);
                            ComboCity.DisplayMember = "Label";
                            ComboCity.ValueMember = "Value";
                            ComboCity.DataSource = objDt1;
                            ComboCity.SelectedIndex = 0;
                            ComboCity.Enabled = true;
                        }
                        else
                            ComboCity.Enabled = false;
                    }
                    else { comboState.SelectedIndex = 0; ComboCity.SelectedIndex = -1; ComboCity.Enabled = false; }
                }
                else { ComboCity.SelectedIndex = -1; comboState.SelectedIndex = 0; comboState.Enabled = false; ComboCity.Enabled = false; }
            }
            catch (Exception ex) { throw ex; }
        }

        #endregion
        #region btnClear_Click
        /// <summary>
        /// Name:btnClear_Click
        /// Description:Clear Contols
        /// Author Name:Monal Shah
        /// Created Date:2010/12/20
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearControls(); LblMsg.Visible = false;
        }

        #endregion
        #region ClearControls
        /// <summary>
        /// Name:btnClear_Click
        /// Description:Clear Contols
        /// Author Name:Monal Shah
        /// Created Date:2010/12/20
        /// </summary>
        private void ClearControls()
        {
            TxtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPwd.Text = string.Empty;
            txtFax.Text = string.Empty;
            RbtnMale.Checked = true;
            RbtnFemale.Checked = false;
            ComboSalary.SelectedIndex = 0;
            if (comboState.Enabled == true)
            { comboState.SelectedIndex = 0; comboState.Enabled = false; }
            if (ComboCity.Enabled == true)
            { ComboCity.SelectedIndex = 0; ComboCity.Enabled = false; }
            ComboCountry.SelectedIndex = 0;
            DatePickerValue.Text = DateTime.Now.ToShortDateString();
        }
        #endregion
        #region ComboCity_SelectedIndexChanged
        /// <summary>
        /// Name:ComboCity_SelectedIndexChanged
        /// Description:Fetch City id Of Selected City
        /// Author Name:Monal Shah
        /// Created Date:2010/12/20
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ComboCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboCountry.SelectedIndex != 0)
            {
                if (comboState.SelectedIndex != 0)
                {
                    if (ComboCity.SelectedIndex != 0)
                    {
                        objDt2 = new DataTable();
                        objDt2 = objCl.BindDropDown(ConstantMessage.CityTableName, ConstantMessage.CityNameValue, "City_Id", Convert.ToInt32(ComboCity.SelectedValue));
                        CityId = Convert.ToInt32(objDt2.Rows[0]["City_Id"]);
                    }
                }
                else
                { ComboCity.SelectedIndex = 0; ComboCity.Enabled = false; }
            }
            else
            { ComboCity.SelectedIndex = 0; ComboCity.Enabled = false; }
        }
        #endregion
        #region BtnClose_Click
        /// <summary>
        /// Name:BtnClose_Click
        /// Description:Close Page
        /// Author Name:Monal Shah
        /// Created Date:2010/12/20
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }
        #endregion

        private void RegistrationViewForm_Load(object sender, EventArgs e)
        {

        }

      

        

       
        
     
    }
}
