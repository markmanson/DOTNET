using System;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;
using System.Data;
/// <summary>
/// NamespaceName:ADV_ASP_Day1_2
/// Description: Asp with User Control
/// Author: Bhumi
/// Created On:3/7/2015
/// </summary>
namespace ADV_ASP_Day1_2
{
    /// <summary>
    /// Class Name:TestControl1
    /// Description:Use of Usercontrol in ASP.NET
    /// Author:Bhumi
    /// Created On:6/7/2015
    /// </summary>
    public partial class TestControl1 : System.Web.UI.UserControl
    {
        StringBuilder strbuilder;
        DataTable dt_emp;
        ConstantMessages objconst;
        CommonFunction objcommon;
        #region Page Load
        /// <summary>
        /// Method Name:Page_Load
        /// Description:display database table in web page
        /// Author:Bhumi
        /// Created On:6/7/2015 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                objcommon = new CommonFunction();
                //Query execution
                strbuilder = new StringBuilder("SELECT EmployeeDetailID,Name");
                strbuilder.Append(" FROM EmployeeDetail ");
                gvEmployee.DataSource = objcommon.ConnectionGenerate(strbuilder.ToString());//Data table as source in gridview
                gvEmployee.DataBind();//Bind the data
            }
            catch (Exception)
            {
                objconst = new ConstantMessages();
                Response.Redirect(objconst.strErrorPage);
            }
            finally
            {                
                strbuilder = null;
                dt_emp = null;
                objconst = null;
            }
        }
        #endregion
    }
}