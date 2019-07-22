using System;
using System.Text;
using System.Web.UI;
/// <summary>
///NameSpace:ADO_Day1
/// Description://ADO.Net Day1
/// Author:bhumi
/// Created On:28/5/2015
/// </summary>
namespace ADO_Day1
{
    /// <summary>
    /// Class:Default_Page
    /// Description:"Add code to the Default.aspx to open the connection using the connection string from web.config.
                    //fetch data from table and show it on the datagridview."
    ///Author:bhumi
    ///Created on:28/5/2015
    /// </summary>
    public partial class Default_Page : System.Web.UI.Page
    {
        #region Second Exercise of Day1

        protected void Page_Load(object sender, EventArgs e)
        {
            CommonFunctions objcmnfunction;
            StringBuilder strbuilder;//string builder for query
            string strQuery;
            try
            {
                //insert SQLquery in String builder
                strbuilder = new StringBuilder("SELECT  EmployeeID,LastName,FirstName,Title,City,Region,Country");
                strbuilder.Append(" FROM");
                strbuilder.Append(" Employees;");
                //convertion from string builder to string
                strQuery = strbuilder.ToString();
                //connection generation and read the data fro reader
                objcmnfunction = new CommonFunctions();
                //objcmnfunction.QueryExecute(strQuery);
                //store data in grid view
                GridView1.DataSource = objcmnfunction.ConnectionGenerate(strQuery);
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);//Exception
                Response.Redirect("Error_Page.aspx");
            }
            finally
            {
                objcmnfunction=null;                
            }
        }
        #endregion

        protected void GridView1_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind(); //bind data
        }
    }
}