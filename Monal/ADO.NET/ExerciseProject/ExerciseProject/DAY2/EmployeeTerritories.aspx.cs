using System;
using System.Data;
using ExerciseProject.Class_File;


namespace ExerciseProject.DAY2
{
    /// <summary>
    /// Name:EmployeeTerritories.aspx
    /// Description:"Add a page EmployeeTerritories.aspx to the project. 
    ///             Add a gridview control to the page and bind it to the EmployeeTerritories table of the typed dataset."
    /// Author:Monal Shah
    /// Created Date:2010/09/21
    /// </summary>
    public partial class EmployeeTerritories : System.Web.UI.Page
    {
        EmployeesDataset objEmpTerroristDataSet = new EmployeesDataset();//object of the typed dataset is created
        Commonlogic objCl = new Commonlogic();//object of the commonlogic is created
        DataTable objDTable = new DataTable();
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description:"Add a gridview control to the page and bind it to the EmployeeTerritories table of the typed dataset"
        /// Author:Monal Shah
        /// Created Date:2010/09/21
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    int intIdValue = SessionMethod.CurrentSession.EmployeeID;
                    //if session is not '0' then clicked linkbutton's record will be displayed
                    //else all the employeeterritories record will be displayed.
                    if (intIdValue != 0)
                    {
                        objDTable = objCl.SelectNWhereQuery("EmployeeTerritories", "EmployeeID", intIdValue);
                        this.GrdEmpTerritories.DataSource = objDTable;
                        this.GrdEmpTerritories.DataBind();//here binding data to gridview
                    }
                    else
                    {
                        string strTable = "EmployeeTerritories";
                        objEmpTerroristDataSet = objCl.EmpDataSet(strTable);//here EmpDataSet method is called with the table name
                        this.GrdEmpTerritories.DataSource = objEmpTerroristDataSet.EmployeeTerritories;
                        this.GrdEmpTerritories.DataBind();//here binding data to gridview
                    }
                }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx",false);
               // Response.Write("ERROR:" + exException.Message);
            }
            finally
            {
                objEmpTerroristDataSet = null;
                objCl = null;
                objDTable = null;
            }
            
        }
        #endregion
    }
}
