using System;
using System.Text;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using ExerciseProject.Class_File;


namespace ExerciseProject.DAY2
{
    ///Summary
    /// Name:Default.aspx
    /// Description:Add code to the Default.aspx to open the connection using the connection string from web.config.
    ///              Add code to fetch data from the Employees table and show it on the page in a datagridview."
    /// Author:Monal Shah
    /// Created Date:2010/09/20
    /// summary
    public partial class EmployeeNameHyperLink : System.Web.UI.Page
    {
        EmployeesDataset objEmpDataSet = new EmployeesDataset();//object of the typed dataset is created
        Commonlogic objCl = new Commonlogic();//object of the commonlogic is created
        StringBuilder objSelect;
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description:Bind the grid with emplyee table using typed dataset and perform DML operatio(Insert,Update,Delete)
        /// Author:monal shah
        /// Created Date:2010/09/23
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    //objCl.GetSqlStmt = str;
                    //objDTable = objCl.DataTables();
                    string strTable = "Employees";
                    objSelect = new StringBuilder();
                    objSelect.Append("SELECT ");
                    objSelect.Append("EmployeeID");
                    objSelect.Append(",");
                    objSelect.Append("TitleOfCourtesy+' '+FirstName+' '+LastName As Name");
                    objSelect.Append(",");
                    objSelect.Append("Title");
                    objSelect.Append(",");
                    objSelect.Append("Convert(varchar,BirthDate,111) As BirthDate");
                    objSelect.Append(",");
                    objSelect.Append("Convert(varchar,HireDate,111) As HireDate");
                    objSelect.Append(",");
                    objSelect.Append("Address");
                    objSelect.Append(",");
                    objSelect.Append("City");
                    objSelect.Append(",");
                    objSelect.Append("Region");
                    objSelect.Append(",");
                    objSelect.Append("PostalCode");
                    objSelect.Append(",");
                    objSelect.Append("Country");
                    objSelect.Append(",");
                    objSelect.Append("HomePhone");
                    objSelect.Append(",");
                    objSelect.Append("Extension");
                    objSelect.Append(",");
                    objSelect.Append("ReportsTo");
                    objSelect.Append(",");
                    objSelect.Append("Notes");
                    objSelect.Append(",");
                    objSelect.Append("PhotoPath ");
                    objSelect.Append("From Employees");
                    string strQuery = objSelect.ToString();
                     objEmpDataSet = objCl.EmpDataSet(strQuery, strTable);
                     this.GrdEmployee.DataSource = objEmpDataSet.Employees;
                    this.GrdEmployee.DataBind();//here binding data to gridview
                }
            }      
            catch (SqlException)
            {
                Response.Redirect("Error.aspx",false);
               // Response.Write("ERROR:" + exException.Message);
            }
            finally
            {
                objEmpDataSet = null;
                objCl = null;
            }
        }
        #endregion
        
        #region LnkFName_Click
        /// <summary>
        /// Name:LnkFName_Click
        /// Description:Find linkbutton id value and store id value in session
        /// Author:monal shah
        /// Created Date:2010/09/23
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LnkFName_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow gvr = (GridViewRow)((LinkButton)sender).Parent.Parent;
                string strid = GrdEmployee.DataKeys[gvr.RowIndex].Value.ToString();
                SessionMethod.CurrentSession.EmployeeID = Convert.ToInt32(strid);
                Response.Redirect("EmployeeTerritories.aspx",false);
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
        }
        #endregion
        protected void GrdEmployee_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

    }
}
