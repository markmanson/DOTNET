using System;
using System.Data;
using System.Text;

namespace SearchApplication
{
    /// <summary>
    /// Name:Default
    /// Description:Serching criteria set
    /// Author Name:Monal shah
    /// Created Date:2010/11/2
    /// </summary>
    public partial class _Default : System.Web.UI.Page
    {
        Commonlogic objCl = new Commonlogic();
        DataTable objDt = new DataTable();
        StringBuilder objSb;
        string strRemove;
        string strGetProperValue;
        string[] splitValue;
        #region Page_Load
        /// <summary>
        /// Description:Serching criteria set
        /// Author Name:Monal shah
        /// Created Date:2010/11/2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #endregion
        #region BtnSearch_Click
        /// <summary>
        /// Name:BtnSearch_Click
        /// Description:Serching criteria set
        /// Author Name:Monal shah
        /// Created Date:2010/11/2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnSearch_Click(object sender, EventArgs e)
        {
            PnlGrid.Visible = true;
            objSb = new StringBuilder();
            try
            {
                objSb.Append("Select ");
                objSb.Append("* ");
                objSb.Append("From ");
                objSb.Append("EmployeeTable ");
                objSb.Append("Where ");
                if (TxtFirstName.Text != null && TxtFirstName.Text != "")
                {
                    objSb.Append("FirstName ");
                    objSb.Append("LIKE ");
                    objSb.Append("'");
                    objSb.Append(TxtFirstName.Text);
                    objSb.Append("%");
                    objSb.Append("'");
                    objSb.Append(" AND ");
                }
                if (TxtLastName.Text != null && TxtLastName.Text != "")
                {
                    objSb.Append("LastName ");
                    objSb.Append("LIKE ");
                    objSb.Append("'");
                    objSb.Append(TxtLastName.Text);
                    objSb.Append("%");
                    objSb.Append("'");
                    objSb.Append(" AND ");
                }
                if (TxtAge.Text != null && TxtAge.Text != "")
                {
                    objSb.Append("age");
                    objSb.Append("=");
                    objSb.Append("'");
                    objSb.Append(TxtAge.Text);
                    objSb.Append("'");
                    objSb.Append(" AND ");
                }
                if (RdbtnSex.SelectedIndex > -1 && RdbtnSex.SelectedItem.Selected)
                {
                    objSb.Append("Sex");
                    objSb.Append("=");
                    objSb.Append("'");
                    objSb.Append(RdbtnSex.SelectedValue);
                    objSb.Append("'");
                    objSb.Append(" AND ");
                }
                if (DdlEducation.SelectedIndex > -1 && DdlEducation.SelectedItem.Text != ConstantMessage.EducationSelect)
                {
                    objSb.Append("Education");
                    objSb.Append("=");
                    objSb.Append("'");
                    objSb.Append(DdlEducation.SelectedItem.Value);
                    objSb.Append("'");
                    objSb.Append(" AND ");
                }
                if (DdlExperience.SelectedIndex > -1 && DdlExperience.SelectedItem.Text != ConstantMessage.ExperienceSelect)
                {
                    objSb.Append("Experience");
                    objSb.Append("=");
                    objSb.Append("'");
                    objSb.Append(DdlExperience.SelectedItem.Value);
                    objSb.Append("'");
                    objSb.Append(" AND ");
                }
                if (DdlSalary.SelectedIndex > -1 && DdlSalary.SelectedItem.Text != ConstantMessage.SalarySelect)
                {
                    splitValue = DdlSalary.SelectedItem.Value.Split('-');
                    objSb.Append("Salary");
                    objSb.Append(">=");
                    objSb.Append(splitValue[0].ToString());
                    objSb.Append(" And ");
                    objSb.Append("Salary");
                    objSb.Append("<");
                    objSb.Append(splitValue[1].ToString());
                    objSb.Append(" AND ");
                }
                strRemove = Convert.ToString(objSb);
                strGetProperValue = strRemove.Substring(0, strRemove.Length - 4);
                objCl.GetSqlStmt = strGetProperValue.ToString();
                objDt = objCl.DataTables();
                if (objDt.Rows.Count > 0)
                {
                    EmployeeGrid.Visible = true;
                    EmployeeGrid.DataSource = objDt;
                    EmployeeGrid.DataBind();
                    LblNoRecord.Visible = false;
                }
                else
                {
                    LblNoRecord.Visible = true;
                    LblNoRecord.Text = ConstantMessage.NoRecord;
                    EmployeeGrid.Visible = false;
                }
               
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx", false);
            }
            finally
            {
                objCl = null;
                objSb = null;
                objDt.Dispose();
            }
        }
        #endregion
        #region BtnReset_Click
        /// <summary>
        /// Name:BtnReset_Click
        /// Description:Reset Controls
        /// Author Name:Monal shah
        /// Created Date:2010/11/2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnReset_Click(object sender, EventArgs e)
        {
            LblNoRecord.Visible = false;
            TxtFirstName.Text = string.Empty;
            TxtLastName.Text = string.Empty;
            TxtAge.Text = string.Empty;
            RdbtnSex.SelectedIndex = -1;
            DdlEducation.SelectedValue = ConstantMessage.EducationSelect;
            DdlExperience.SelectedValue = ConstantMessage.ExperienceSelect;
            DdlSalary.SelectedValue = ConstantMessage.SalarySelect;           
        }
        #endregion
    }
}
