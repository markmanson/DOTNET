using System;
using System.Data;
using System.Text;
using System.Web.UI.WebControls;
using ExerciseProject.Class_File;

namespace ExerciseProject.Day5
{
    /// <summary>
    /// Name:CustomerGrid.aspx
    /// Description:Implement the Add/Edit/Delete features in the gridview control for customers.
    ///Author:monal shah
    ///Created Date:2010/09/30
    /// </summary>
    public partial class CustomerGrid : System.Web.UI.Page
    {
        Customer objCustomer = new Customer();
        Commonlogic objCl = new Commonlogic();//object of the commonlogic is created
        DataTable objDt = new DataTable();
        StringBuilder objSelect;
        ConstantMessage objConstant = new ConstantMessage();
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description:Bind the grid with Customer table and perform DML operation(Insert,Update,Delete)
        /// Author:monal shah
        /// Created Date:2010/09/30
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
                LblErrorMessage.Visible = false;
                BindGrid();   //call function           
            }
        }
        #endregion
        #region BindGrid
        /// <summary>
        /// Name:Bindgrid
        /// Description:Bind Grid with Customer details 
        /// Author:monal shah
        /// Created Date:2010/09/23
        /// </summary>
        public void BindGrid()
        {
            try
            {
                objSelect = new StringBuilder();
                objSelect.Append("SELECT ");
                objSelect.Append("CustomerID");
                objSelect.Append(",");
                objSelect.Append("CompanyName");
                objSelect.Append(",");
                objSelect.Append("ContactName");
                objSelect.Append(",");
                objSelect.Append("ContactTitle");
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
                objSelect.Append("Phone");
                objSelect.Append(",");
                objSelect.Append("Fax ");              
                objSelect.Append("From Customers");

               
                objCl.GetSqlStmt= objSelect.ToString();
                objDt = objCl.DataTables();//here EmpDataSet method is called with the table name
                if (objDt.Rows.Count==0)
                {
                    LblErrorMessage.Visible = true;
                    LblErrorMessage.Text = objConstant.NoTableRecordFound;// "Datatable Does Not Contain Any Row";
                    LnkAddNewUser.Visible = false;
                    //Response.Write(LblErrorMessage.Text);
                }
                else
                {
                  
                    this.GrdCustomer.DataSource = objDt;
                    this.GrdCustomer.DataBind();//here binding data to gridview
                }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx", false);
            }
            finally
            {
                objDt= null;
                objCl = null;
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
                string idValue = GrdCustomer.DataKeys[gvr.RowIndex].Value.ToString();//here id value of clicked linkbutton will be gat
                if (idValue != null)
                {
                    SessionMethod.CurrentSession.CustomerID = idValue;//store the id in session
                    Response.Redirect("CustomerRegister.aspx", false);
                }
                else
                {
                    LblErrorMessage.Visible = true;
                    LnkAddNewUser.Visible = false;
                    LblErrorMessage.Text = objConstant.NoIdValueFoundInControl;

                }
             
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx", false);
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
                string idValue = GrdCustomer.DataKeys[gvr.RowIndex].Value.ToString();//here id value of clicked linkbutton will be gat
                if (idValue != null)
                {
                    objCustomer.CustomerID = idValue;//set employee id value
                    objCustomer.DeleteCustomer().ToString();//Call method DeleteEmployee 
                    Response.Redirect("CustomerGrid.aspx",false);
                }
                else
                {
                    LblErrorMessage.Visible = true;
                    LnkAddNewUser.Visible = false;
                    LblErrorMessage.Text =objConstant.NoIdValueFoundInControl;

                }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx", false);
            }
           
        }
        #endregion

        protected void GrdCustomer_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }
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
            
            if (SessionMethod.CurrentSession.CustomerID != "")
            {
                SessionMethod.CurrentSession.CustomerID = "";

                Response.Redirect("CustomerRegister.aspx", false);
            }

            else
            {
                Response.Redirect("CustomerRegister.aspx", false);
            }
        }
        #endregion

        protected void GrdCustomer_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {

        }

    }
}
