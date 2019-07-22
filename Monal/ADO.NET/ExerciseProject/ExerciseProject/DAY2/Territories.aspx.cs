using System;
using System.Data;
using ExerciseProject.Class_File;

namespace ExerciseProject.DAY2
{
    /// <summary>
    /// Name:Territories.aspx
    /// Description:Create a page Territories.aspx to display information on territories.
    /// Author:Monal Shah
    /// Created Date:2010/09/21
    /// </summary>
    public partial class Territories : System.Web.UI.Page
    {
        DataTable objDTable = new DataTable();//odbDtable is object of DataTable
        Commonlogic objCl = new Commonlogic();//ObjCl is object of commonlogic
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description:"Add code to fetch data from the Territories table and show it on the page in a datagridview."
        /// Author:Monal Shah
        /// Created Date:2010/09/21
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    objCl.GetSqlStmt = "Select * From Territories";
                    objDTable = objCl.DataTables();//through the common logic object datatable function is call and assign vale to the datatable object
                    //string strTableName = "Territories";
                    //objDTable = objCl.DataTables();// SelectQuery(strTableName);//SelectQuery Method is called with tableName
                    this.GrdTerritories.DataSource = objDTable;
                    this.GrdTerritories.DataBind();//binding grid
                }
                catch (Exception)
                {
                    Response.Redirect("Error.aspx",false);
                }
                finally
                {
                    objDTable = null;
                    objCl = null;
                }
            }
        }
        #endregion
    }
}
