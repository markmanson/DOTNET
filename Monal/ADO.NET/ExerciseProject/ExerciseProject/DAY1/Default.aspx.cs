using System;
using System.Data;
using System.Data.SqlClient;
using ExerciseProject.Class_File;

namespace ExerciseProject
{
    /// <summary>
    /// Name:Default.aspx
    /// Description:Add code to the Default.aspx to open the connection using the connection string from web.config.
    ///              Add code to fetch data from the Employees table and show it on the page in a datagridview."
    /// Author:Monal Shah
    /// Created Date:2010/09/20
    /// </summary>
    public partial class _Default : System.Web.UI.Page
    {
        DataTable objDTable = new DataTable();//odbDtable is object of DataTable
        Commonlogic objCl = new Commonlogic();//ObjCl is object of commonlogic
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description:"Add code to fetch data from the Employees table and show it on the page in a datagridview."
        /// Author:Monal Shah
        /// Created Date:2010/09/20
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {if (!IsPostBack)
                {   //string strTableName = "Employees";
                    // objDTable = objCl.SelectQuery(strTableName);
                    objCl.GetSqlStmt = "SELECT EmployeeID,"+
                        "TitleOfCourtesy+' '+FirstName+' '+LastName As Name,"+ 
                        "Title,Convert(varchar,BirthDate,111)As BirthDate,"+
                        "Convert(varchar,HireDate,111) As HireDate," +
                        "Address, City, Region, PostalCode, Country, HomePhone,"+
                        "Extension, Photo, ReportsTo, Notes," +
                        "PhotoPath FROM Employees";
                    objDTable = objCl.DataTables();
                    this.GrdEmployee.DataSource = objDTable;
                    this.GrdEmployee.DataBind();//Binding grid
                }
            }
            catch (Exception exException)
            {
                Response.Redirect("Error.aspx");
               // Response.Write("ERROR:" + exException.Message);
            }
            finally
            {
                objDTable = null;
                objCl = null;
            }
        }
        #endregion     
    }
}
