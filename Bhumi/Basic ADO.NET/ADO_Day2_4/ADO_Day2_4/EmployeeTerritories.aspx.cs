using System;
using System.Data;
using System.Text;
namespace ADO_Day2_4
{    
    /// <summary>
    /// ClassName:EmployeeTerritories
    /// Description: Typed Dataset and gridview
    /// Author:bhumi
    /// </summary>
    public partial class EmployeeTerritories : System.Web.UI.Page
    {
        CommonFunctions objcmnfunction;
        Employees_TypedDataSet dataset;
        DataTable datatable;
        ConstantMessages objconstmsg;
        #region Page Load Event
        /// <summary>
        /// Event Name:Page Load Event
        /// Description:databinding with gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            StringBuilder strbuilder;//string builder for query
            try
            {
                //insert SQLquery in String builder
                strbuilder = new StringBuilder("SELECT * ");
                strbuilder.Append(" FROM");
                strbuilder.Append(" EmployeeTerritories;");
                //connection generation and read the data fro reader
                objcmnfunction = new CommonFunctions();
                //datatable
                datatable = new DataTable();
                //dataset
                dataset = new Employees_TypedDataSet();
                datatable = objcmnfunction.ConnectionGenerate(strbuilder.ToString());
                //fill the dataset
                dataset.Tables.Add(datatable);                
                //store data in grid view
                gvEmployeeTerritory.DataSource = datatable;
                gvEmployeeTerritory.DataBind();
            }
            catch (Exception)
            {
                objconstmsg = new ConstantMessages();
                Response.Redirect(objconstmsg.strerrorpage);
            }
            finally
            {
                objcmnfunction = null;
                dataset = null;
                datatable = null;
            }
        }
        #endregion
        #region Page Index Change Event
        //Code for allow paging in gridview
        protected void GridView1_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            gvEmployeeTerritory.PageIndex = e.NewPageIndex;
            gvEmployeeTerritory.DataBind(); //bind data
        }
        #endregion
    }
}