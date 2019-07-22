using System;
using System.Text;
/// <summary>
/// Namespace Name:ADV_ASP_Day5_6
/// Description:Cache Concept in ASP.NET
/// Author:Bhumi
/// Created On:13/7/2015
/// </summary>
namespace ADV_ASP_Day5_6
{
    // <summary>
    /// Class Name:Employee_Ex7
    /// Description:WebControls in Cache
    /// Author:Bhumi
    /// Created On:13/7/2015
    /// </summary>
    public partial class Employee_Ex7 : System.Web.UI.Page
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
                Cache.Insert("EmployeeName", objfunction.ConnectionGenerate(strBrSelectQuery.ToString()),
                            null, DateTime.Now.AddSeconds(15),
                            System.Web.Caching.Cache.NoSlidingExpiration);
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
                objconst = new ConstantMessages();
                Response.Redirect(objconst.strCache_Ex7Page, false);
            }
            catch (Exception)
            {
                objconst = new ConstantMessages();
                Response.Redirect(objconst.strErrorPage, false);
            }
            finally
            {                
                objconst = null;
            }
        }
        #endregion
    }
}