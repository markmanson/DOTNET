using System;
using System.Text;
/// <summary>
/// Namespace Name:ADV_ASP_Day5_6
/// Description:Cache Concept in ASP.NET
/// Author:Bhumi
/// Created On:9/7/2015
/// </summary>
namespace ADV_ASP_Day5_6
{
    /// <summary>
    /// Class Name:Employee_Ex6
    /// Description:WebControls in Cache
    /// Author:Bhumi
    /// Created On:10/7/2015
    /// </summary>
    public partial class Employee_Ex6 : System.Web.UI.Page
    {
        StringBuilder strBrSelectQuery;
        CommonFunction objfunction;
        ConstantMessages objconst;
        #region Page Load
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }            
        }
        #endregion
        #region BindData in DropDownlist
        /// <summary>
        /// Method Name:BindData
        /// Description:Fill the Data in Dropdownlist from Database table
        /// Author:Bhumi
        /// Created On:10/7/2015
        /// </summary>
        public void BindData()
        {
            try
            {
                strBrSelectQuery = new StringBuilder("SELECT Name ");
                strBrSelectQuery.Append(" FROM EmployeeDetail");
                objfunction = new CommonFunction();
                DdlEmployee.DataSource = objfunction.ConnectionGenerate(strBrSelectQuery.ToString());
                DdlEmployee.DataValueField = "Name";
                DdlEmployee.DataTextField = "Name";
                DdlEmployee.DataBind();
            }
            catch (Exception)
            {
                objconst = new ConstantMessages();
                Response.Redirect(objconst.strErrorPage, false);
            }
            finally
            {
                strBrSelectQuery = null;
                objfunction = null;
            }
        }
        #endregion
        #region Details Button Click Event
        /// <summary>
        /// Method Name:BtnDetails_Click
        /// Description:Show the Data in Grid control while clicking Details Button
        /// Author:Bhumi
        /// Created On:10/7/2015
        /// </summary>
        protected void BtnDetails_Click(object sender, EventArgs e)
        {            
            try
            {
                if (DdlEmployee.SelectedValue == "0")
                {
                    objconst = new ConstantMessages();
                    ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "alert('" + objconst.strAlertEmployeeName + "');", true);
                }
                else
                {
                    strBrSelectQuery = new StringBuilder("SELECT EmployeeDetailID,Address,Email,Salary ");
                    strBrSelectQuery.Append(" FROM EmployeeDetail");
                    strBrSelectQuery.Append(" WHERE Name= '" + DdlEmployee.SelectedValue + "'");
                    objfunction = new CommonFunction();
                    gvEmployee.DataSource = objfunction.ConnectionGenerate(strBrSelectQuery.ToString());
                    gvEmployee.DataBind();
                }                
            }
            catch (Exception)
            {
                objconst = new ConstantMessages();
                Response.Redirect(objconst.strErrorPage, false);
            }
            finally
            {
                strBrSelectQuery = null;
                objfunction = null;
            }
        }
        #endregion
    }
}