using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Text;
using System.Web.UI.WebControls;
/// <summary>
/// Namespace Name:ADO_Day5_9
/// Description: Typed Dataset,Gridview Databinding and Its Feature & Validation
/// Author:Bhumi
/// Created On:8/6/2015
/// </summary>
namespace ADO_Day5_9
{
    public partial class Customer_Details : System.Web.UI.Page
    {
        #region Page_Load Method
        /// <summary>
        /// Method Name:Page_Load
        /// Description:Fill and bind the gvEmployees(Gridview)
        /// Author:Bhumi
        /// Created on:9/6/2015
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        CommanFunction objcmnfunction;
        DataTable dtCustomers;
        ConstantMessages objconstmsg;
        public void Page_Load(object sender, EventArgs e)
        {
            LblHDeleteEmployee.Visible = false;
            if (!IsPostBack)
            {
                Grid_Fill();
            }
        }
        #endregion
        #region Gridview Datasource & Binding
        /// <summary>
        /// method name:Grid_Fill
        /// Description: Fill and bind the Gridview
        /// Author:bhumi
        /// Created On:9/6/2015
        /// </summary>
        public void Grid_Fill()
        {
            StringBuilder strBrSelectQuery;//string builder for query        
            try
            {
                objconstmsg = new ConstantMessages();
                //insert SQLquery in String builder
                strBrSelectQuery = new StringBuilder("SELECT CustomerID,CompanyName,ContactTitle,City,PostalCode,Phone,Fax");
                strBrSelectQuery.Append(" FROM");
                strBrSelectQuery.Append(" Customers;");
                //connection generation and read the data from reader
                objcmnfunction = new CommanFunction();
                //datatable
                dtCustomers = new DataTable();
                dtCustomers = objcmnfunction.ConnectionGenerate(strBrSelectQuery.ToString());
                //store data in grid view
                gvCustomers.DataSource = dtCustomers;
                gvCustomers.DataBind();
            }
            catch (Exception)
            {
                Response.Redirect(objconstmsg.strerrorpage,false);
            }
            finally
            {
                strBrSelectQuery = null;
            }
        }
        #endregion
        #region PageIndex Changing
        /// <summary>
        /// Event Name:gvCustomers_PageIndexChanging
        /// Description:Handle the Event of Changing in Index of Page
        /// Author:Bhumi
        /// Created on:9/6/2015
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvCustomers_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvCustomers.PageIndex = e.NewPageIndex;
            Grid_Fill();
            gvCustomers.DataBind();  
        }
        #endregion        
        #region Delete Rows
        /// <summary>
        /// Event Name:gvEmployees_RowDeleting
        /// Description:Delete Operation on Rows
        /// Author:Bhumi
        /// Created on:9/6/2015
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        SqlConnection sqlconn;
        SqlCommand sqlcmd;
        SqlTransaction sqltransact;
        StringBuilder strBrDeleteQuery;
        object id;

        protected void gvCustomers_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            sqlconn = new SqlConnection();
            sqlconn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;                
            try
            {
                id = gvCustomers.DataKeys[e.RowIndex].Value;
                if (sqlconn != null && sqlconn.State == ConnectionState.Closed)
                {
                    sqlconn.Open();//open the connection                                                      
                }
                sqltransact = sqlconn.BeginTransaction("Transaction"); //Transaction start
                //Query execution
                strBrDeleteQuery = new StringBuilder("DELETE  ");
                strBrDeleteQuery.Append(" FROM Customers ");
                strBrDeleteQuery.Append(" WHERE CustomerID=@CustomerID;");
                strBrDeleteQuery.Append("DELETE FROM Orders ");
                strBrDeleteQuery.Append(" WHERE CustomerID=@CustomerID;");
                sqlcmd = new SqlCommand(strBrDeleteQuery.ToString(), sqlconn, sqltransact);
                sqlcmd.Parameters.AddWithValue("@CustomerID", id);
                sqlcmd.ExecuteNonQuery();
                LblHDeleteEmployee.Visible = true;            
                sqltransact.Commit();
                Grid_Fill();//Display Gridview                 
            }
            catch (Exception ex)
            {
                Response.Write(ex.GetType());
                Response.Write(ex.Message);
                try
                {
                    sqltransact.Rollback();//Rollback transaction
                }
                catch (Exception exc)
                {
                    Response.Write(exc.GetType());
                    Response.Write(exc.Message);
                }
            }
            finally
            {
                if (sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
                }
                sqlcmd = null;
                sqltransact = null;
                strBrDeleteQuery = null;      
            }
        }
        #endregion
        #region ADD Customer Button Click 
        /// <summary>
        /// Event Name:BtnHADD_Click
        /// Description:redirection to Add_Edit_Customer Page
        /// Author:Bhumi
        /// Created on:9/6/2015
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnHADD_Click(object sender, EventArgs e)
        {
            objconstmsg = new ConstantMessages();
            Response.Redirect(objconstmsg.strAdd_Edit_CustomerPage,false);
        }
        #endregion
    }
}