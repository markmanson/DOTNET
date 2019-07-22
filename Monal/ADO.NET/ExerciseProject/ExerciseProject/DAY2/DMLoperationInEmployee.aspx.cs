using System;
using System.Web.UI.WebControls;
using System.Text;
using ExerciseProject.Class_File;

namespace ExerciseProject.DAY2
{
    /// <summary>
    /// Name:DMLoperationInEmployee.aspx
    /// Description:Implement the Add/Edit/Delete features in the gridview control for employees,
    ///      using the Typed Dataset.
    ///Author:monal shah
    ///Created Date:2010/09/23
    /// </summary>
    public partial class DMLoperationInEmployee : System.Web.UI.Page
    {
        EmployeeInsert objEmp = new EmployeeInsert();//create object of class EmployeeInsert
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
                if (!IsPostBack)
                {
                    BindGrid();   //call function           
                }
        }
        #endregion
        #region BindGrid
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
                               ////"Title,Convert(varchar,BirthDate,111) As BirthDate," +
                               ////"Convert(varchar,HireDate,111) As HireDate," +
                               ////"Address, City, Region, PostalCode, Country," +
                               ////"HomePhone, Extension, ReportsTo, Notes," +
                               ////"PhotoPath FROM Employees";
                objEmpDataSet = objCl.EmpDataSet(strQuery, strTable);//here EmpDataSet method is called with the table name
                this.GrdEmployee.DataSource = objEmpDataSet;
                this.GrdEmployee.DataBind();//here binding data to gridview
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx",false);
            }
            finally
            {
                objEmpDataSet = null;
                objCl = null;
            }

        }
        #endregion
        #region LnkDelete_Click
        /// <summary>
        /// Name:LnkDelete
        /// Description:In Below code get Id value of clicked linkbutton from gridview
        ///             Delete that particular row. 
        /// Author:monal shah
        /// Created Date:2010/09/23
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LnkDelete_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow gvr = ((GridViewRow)((LinkButton)sender).Parent.Parent);//here Linkbutton value find
                string idValue = GrdEmployee.DataKeys[gvr.RowIndex].Value.ToString();//here id value of clicked linkbutton will be gat
                objEmp.EmpID = Convert.ToInt32(idValue);//set employee id value
                objEmp.DeleteEmployee().ToString();//Call method DeleteEmployee 
                BindGrid();//Call bindgrid method
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx",false);
            }           
        }
        #endregion
        
        #region LnkAddNewUser_Click
        /// <summary>
        /// Name:LnkAddNewUser
        /// Description:Redirect Page for new user
        /// Author:monal shah
        /// Created Date:2010/09/23
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LnkAddNewUser_Click(object sender, EventArgs e)
        {
            if (SessionMethod.CurrentSession.EmployeeID != 0)
            {
                SessionMethod.CurrentSession.EmployeeID = 0;
                Response.Redirect("EmployeeRegister.aspx", false);

            }
            else
            {
                Response.Redirect("EmployeeRegister.aspx", false);
            }
        }
        #endregion
        #region LnkEdit_Click
        /// <summary>
        /// Name:LnkEdit
        /// Description:in below code Linkbutton id value get stores the id value in session and page will be redirected.  
        /// Author:monal shah
        /// Created Date:2010/09/23
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LnkEdit_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow gvr = ((GridViewRow)((LinkButton)sender).Parent.Parent);//here Linkbutton value find
                string idValue = GrdEmployee.DataKeys[gvr.RowIndex].Value.ToString();//here id value of clicked linkbutton will be gat
                SessionMethod.CurrentSession.EmployeeID = Convert.ToInt32(idValue);//store the id in session
                Response.Redirect("EmployeeRegister.aspx", false);
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx", false);
            }           
        }
        #endregion

        protected void GrdEmployee_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

      
    }
}
