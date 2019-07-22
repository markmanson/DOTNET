using System;
using System.Text;
using System.Web.UI.WebControls;
using ExerciseProject.Class_File;

namespace ExerciseProject.DAY2
{
    /// <summary>
    /// Name:TransactionUpdate.aspx
    /// Description:Implement the Update data using sqltransaction in the gridview control for employees,
    ///      using the Typed Dataset.
    ///Author:monal shah
    ///Created Date:2010/09/23
    /// </summary>
    public partial class TransactionUpdate : System.Web.UI.Page
    {
        EmployeeInsert objEmp = new EmployeeInsert();//object of EmployeeInsert
        EmployeesDataset objEmpDataSet = new EmployeesDataset();//object of the typed dataset is created
        Commonlogic objCl = new Commonlogic();//object of the commonlogic is created
        StringBuilder objSelect;
        #region Page_load
        /// <summary>
        /// Name:Page_load
        /// Description:call Bind Grid function
        /// Author:monal shah
        /// Created Date:2010/09/23
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();
            }
        }
        #endregion
        #region LnkEdit_Click
        /// <summary>
        /// Name:LnkEdit_Click
        /// Description:get the id value from the clicked linkbutton and stored in session and redirecting page 
        /// Author:monal shah
        /// Created Date:2010/09/23
        /// </summary>
        protected void LnkEdit_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow gvr = ((GridViewRow)((LinkButton)sender).Parent.Parent);
                string idValue = GrdEmployee.DataKeys[gvr.RowIndex].Value.ToString();
                SessionMethod.CurrentSession.EmployeeID = Convert.ToInt32(idValue);
                Response.Redirect("TransactionUpdateForm.aspx", false);
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx", false);
            }
        }
        #endregion
        #region Bindgrid
        /// <summary>
        /// Name:Bindgrid
        /// Description:Bind Grid with employee details 
        /// Author:monal shah
        /// Created Date:2010/09/23
        /// </summary>
        public void BindGrid()
        {
            try
            {
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
                objEmpDataSet = objCl.EmpDataSet(strQuery, strTable);//here EmpDataSet method is called with the table name
                this.GrdEmployee.DataSource = objEmpDataSet;
                this.GrdEmployee.DataBind();//here binding data to gridview
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx", false);
            }
            finally
            {
                objCl = null;
                objSelect = null;
                objEmpDataSet = null;
            }
        }
        #endregion

        protected void GrdEmployee_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }
    }
}
