using System;
using System.Data;
using System.Web.UI;

namespace DAY5EXercise
{
    /// <summary>
    /// Name:DisplayEmployeeDetails
    /// Decription:Task 1 : In this exercise, you’ll create a Web Form that displays a list of Employees from the Employee database. Users can select a Employee from a drop-down list and click a button to view a list of related details to that Employee in a data grid.
    ///            Task 2 : Set the Cache Duration up to 60 sec. During these 60 Seconds if another request goes to server it returns the cached data
    ///            Task 3 : If request goes for another employee for Details within these 60 seconds Server returns up to Date detail of that employee
    /// Author:Monal shah
    /// Created Date:2010/11/11
    /// </summary>
    public partial class DisplayEmployeeDetails : System.Web.UI.Page
    {
        Commonlogic objcl = new Commonlogic();
        DataTable objDt;
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Decription:Bind dropdown.
        /// Author:Monal shah
        /// Created Date:2010/11/11
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Form.DefaultButton = BtnDisplay.UniqueID;
            if (!IsPostBack)
            {
                BindDropDown();
            }
        }
        #endregion
        #region BindDropDown
        /// <summary>
        /// Name:BindDropDown
        /// Decription:Bind dropdown.
        /// Author:Monal shah
        /// Created Date:2010/11/11
        /// </summary>       
        private void BindDropDown()
        {
            try
            {
                objDt = new DataTable();
                objcl.GetSqlStmt = objcl.SelectQuery(ConstantMessage.TableName);
                objDt = objcl.DataTables();
                if (objDt.Rows.Count > 0)
                {
                    this.DdlEmployee.DataSource = objDt;
                    this.DdlEmployee.DataBind();
                }
            }
            catch (Exception)
            { Response.Redirect("Error.aspx", false); }
            finally
            {
                objcl = null;
                objDt.Dispose();
            }
        }
        #endregion
        #region BtnDisplay_Click
        /// <summary>
        /// Name:BtnDisplay_Click
        /// Decription:Display record of that employee which is selected from dropdownlist.
        /// Author:Monal shah
        /// Created Date:2010/11/11
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                objDt = new DataTable();
                objcl.GetSqlStmt = objcl.SelectQuery(ConstantMessage.TableName,ConstantMessage.whereclause, DdlEmployee.SelectedItem.Text);
                objDt = objcl.DataTables();
                if (objDt.Rows.Count > 0)
                {
                    PanelGrid.Visible = true;
                    EmployeeGrid.Visible = true;
                    this.EmployeeGrid.DataSource = objDt;
                    this.EmployeeGrid.DataBind();
                }
            }
            catch (Exception)
            { Response.Redirect("Error.aspx", false); }
            finally
            {
                objcl = null;
                objDt.Dispose();
            }
        }
        #endregion
    }
}
