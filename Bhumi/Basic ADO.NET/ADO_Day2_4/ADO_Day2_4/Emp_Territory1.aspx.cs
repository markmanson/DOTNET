using System;
using System.Data;
using System.Text;
namespace ADO_Day2_4
{
    /// <summary>
    /// Class Name: Emp_Territory1
    /// Description: Display Employee Territory Table for the selected employee
    /// Author: bhumi
    /// </summary>
    public partial class Emp_Territory1 : System.Web.UI.Page
    {
        CommonFunctions objcmnfunction;
        ConstantMessages objconstmsg;
        Employees_TypedDataSet dataset;
        DataTable table;
        #region Page Load Event
        /// <summary>
        /// Event Name:Page Load
        /// Description:databinding with the gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            StringBuilder strbuilder;//string builder for query
            int EmployeeID;
            try
            {
                EmployeeID = Convert.ToInt32(Request.QueryString[0]);                
                //insert SQLquery in String builder
                strbuilder = new StringBuilder("SELECT * ");
                strbuilder.Append(" FROM");
                strbuilder.Append(" EmployeeTerritories");
                strbuilder.Append(" where EmployeeID=" + EmployeeID);
                objcmnfunction = new CommonFunctions();
                objconstmsg = new ConstantMessages();
                //dataset
                dataset = new Employees_TypedDataSet();
                table = new DataTable();
                //fill the dataset
                table = objcmnfunction.ConnectionGenerate(strbuilder.ToString());
                if (table.Rows.Count>0)
                {
                    dataset.Tables.Add(table);
                    //store data in grid view
                    gvEmployeeTerritory.DataSource = table;
                    gvEmployeeTerritory.DataBind();                    
                }
                else
                {
                    objconstmsg = new ConstantMessages();
                    Response.Write(objconstmsg.strdata_notavailable);
                }
            }
            catch (Exception)
            {
                objconstmsg = new ConstantMessages();                
               Response.Redirect(objconstmsg.strdefault1page);
            }
            finally
            {
                objcmnfunction = null;
                dataset = null;
                table = null;
                strbuilder = null;
            }
        }
        #endregion
        #region Page Index Change event                
        /// <summary>
        /// Event Name:gvEmployeeTerritories_PageIndexChanging
        /// Description://Page Index Change Event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        protected void gvEmployeeTerritories_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            gvEmployeeTerritory.PageIndex = e.NewPageIndex;
            gvEmployeeTerritory.DataBind(); //bind data
        }
        #endregion
    }
}