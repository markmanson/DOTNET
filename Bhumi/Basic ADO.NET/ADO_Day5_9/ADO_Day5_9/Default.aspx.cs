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
    /// <summary>
    /// Class Name:Default
    /// Description: Employee Details in gridview with all Feature and validations
    /// Author:Bhumi
    /// Created on:8/6/2015
    /// </summary>
    public partial class Default : System.Web.UI.Page
    {
        #region Page_Load Method
        /// <summary>
        /// Method Name:Page_Load
        /// Description:Fill and bind the gvEmployees(Gridview)
        /// Author:Bhumi
        /// Created on:8/6/2015
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        CommanFunction objcmnfunction;
        DataTable dtEmployees;
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
        /// Created On:8/6/2015
        /// </summary>
        public void Grid_Fill()
        {
            StringBuilder strBrSelectQuery;//string builder for query        
            try
            {
                objconstmsg = new ConstantMessages();
                //insert SQLquery in String builder
                strBrSelectQuery = new StringBuilder("SELECT EmployeeID,TitleOfCourtesy,FirstName,LastName,");
                strBrSelectQuery.Append("CONVERT(nvarchar,BirthDate,110) AS BirthDate,City,Country,HomePhone");
                strBrSelectQuery.Append(" FROM");
                strBrSelectQuery.Append(" Employees;");
                //connection generation and read the data from reader
                objcmnfunction = new CommanFunction();
                //datatable
                dtEmployees = new DataTable();
                dtEmployees = objcmnfunction.ConnectionGenerate(strBrSelectQuery.ToString());                
                //store data in grid view
                gvEmployees.DataSource = dtEmployees;
                gvEmployees.DataBind();
            }
            catch (Exception)
            {
                Response.Redirect(objconstmsg.strerrorpage);
            }
            finally
            {
                strBrSelectQuery = null;
                dtEmployees = null;
                objconstmsg = null;
            }
        }
        #endregion
        #region PageIndex Changing
        /// <summary>
        /// Event Name:gvEmployees_PageIndexChanging
        /// Description:Handle the Event of Changing in Index of Page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvEmployees_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvEmployees.PageIndex = e.NewPageIndex;
            Grid_Fill();
            gvEmployees.DataBind();                       
        }
        #endregion
        #region Edit Feature
        /// <summary>
        /// Event Name:gvEmployees_RowEditing
        /// Description:Edit Rows         
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvEmployees_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvEmployees.EditIndex = e.NewEditIndex;
            Grid_Fill();
        }
        #endregion
        #region Update The Rows of gvEmployees
        /// <summary>
        /// EventName:gvEmployees_RowUpdating
        /// Description:Update operation on Rows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvEmployees_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            object id;
            SqlCommand sqlcmd;
            SqlDataAdapter sqladapter;
            SqlDataReader sqlreader;
            DataTable dtEmployees;
            SqlConnection sqlconn;
            StringBuilder strBrUpdatequery;
            sqlconn = new SqlConnection();
            //Get the data from gridview
            id = gvEmployees.DataKeys[e.RowIndex].Value;
            GridViewRow gvrow = gvEmployees.Rows[e.RowIndex] as GridViewRow;
            TextBox TxtSalutation = gvrow.FindControl("TxtTitleOfCourtesy1") as TextBox;
            TextBox Txtfname = gvrow.FindControl("TxtFirstName1") as TextBox;
            TextBox Txtlname = gvrow.FindControl("TxtLastName1") as TextBox;
            TextBox Txtbirthdy = gvrow.FindControl("TxtBirthDate1") as TextBox;
            TextBox Txtcity = gvrow.FindControl("TxtCity1") as TextBox;
            TextBox Txtcntry = gvrow.FindControl("TxtCountry1") as TextBox;
            TextBox Txtcontactno = gvrow.FindControl("TxtHomePhone1") as TextBox;            
            try
            {

                //connectionstring
                sqlconn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
                if (sqlconn != null && sqlconn.State == ConnectionState.Closed)
                {
                    sqlconn.Open();//open the connection 

                }
                strBrUpdatequery = new StringBuilder("UPDATE Employees set ");
                strBrUpdatequery.Append("TitleOfCourtesy=@TitleOfCourtesy,FirstName=@FirstName,LastName=@LastName,");
                strBrUpdatequery.Append("BirthDate=@BirthDate,");
                strBrUpdatequery.Append("City=@City,Country=@Country,HomePhone=@HomePhone");                
                strBrUpdatequery.Append(" WHERE EmployeeID=@EmployeeID;");
                sqlcmd = new SqlCommand(strBrUpdatequery.ToString(), sqlconn);
                //Update the data
                sqlcmd.Parameters.AddWithValue("@EmployeeID", SqlDbType.Int).Value = id;
                sqlcmd.Parameters.AddWithValue("@TitleOfCourtesy", SqlDbType.NVarChar).Value = TxtSalutation.Text;                
                sqlcmd.Parameters.AddWithValue("@FirstName", SqlDbType.NVarChar).Value = Txtfname.Text;
                sqlcmd.Parameters.AddWithValue("@LastName", SqlDbType.NVarChar).Value = Txtlname.Text;                
                sqlcmd.Parameters.AddWithValue("@BirthDate", SqlDbType.DateTime).Value = Txtbirthdy.Text;
                sqlcmd.Parameters.AddWithValue("@City", SqlDbType.NVarChar).Value = Txtcity.Text;
                sqlcmd.Parameters.AddWithValue("@Country", SqlDbType.NVarChar).Value = Txtcntry.Text;
                sqlcmd.Parameters.AddWithValue("@HomePhone", SqlDbType.NVarChar).Value = Txtcontactno.Text;                
                //Execute Query
                sqladapter = new SqlDataAdapter(sqlcmd);
                sqlcmd.ExecuteNonQuery();
                sqlreader = sqlcmd.ExecuteReader();//Reading data
                dtEmployees = new DataTable();
                dtEmployees.Load(sqlreader);
                gvEmployees.DataSource = dtEmployees;
                gvEmployees.DataBind();
                gvEmployees.EditIndex = -1;
                Grid_Fill();//Display Gridview
                objconstmsg = new ConstantMessages();
                ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "alert('" + objconstmsg.stralertmessage + "');", true);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);//Exception                
            }
            finally
            {
                if (sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
                }
                sqlcmd = null;
                sqladapter = null;
                sqlreader = null;
                dtEmployees = null;
                strBrUpdatequery = null;
            }
        }
        #endregion
        #region Delete Rows
        /// <summary>
        /// Event Name:gvEmployees_RowDeleting
        /// Description:Delete Operation on Rows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        SqlConnection sqlconn;
        SqlCommand sqlcmd;
        SqlTransaction sqltransact;
        StringBuilder strBrDeleteQuery;
        object id;
        protected void gvEmployees_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            LblHDeleteEmployee.Visible = true;
            try
            {
                id = gvEmployees.DataKeys[e.RowIndex].Value;
                sqlconn = new SqlConnection();
                sqlconn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
                if (sqlconn != null && sqlconn.State == ConnectionState.Closed)
                {
                    sqlconn.Open();//open the connection                                                      
                }
                sqltransact = sqlconn.BeginTransaction("Transaction"); //Transaction start
                //Query execution
                strBrDeleteQuery = new StringBuilder("DELETE");
                strBrDeleteQuery.Append(" FROM Employees ");
                strBrDeleteQuery.Append(" WHERE EmployeeID=@EmployeeID");
                sqlcmd = new SqlCommand(strBrDeleteQuery.ToString(), sqlconn, sqltransact);
                sqlcmd.Parameters.AddWithValue("@EmployeeID", id);
                sqlcmd.ExecuteNonQuery();
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
            }
        }
        #endregion
        #region Cancel Edit
        /// <summary>
        /// method name:gvEmployees_RowCancelingEdit
        /// Description:Canceling the Row editing       
        /// </summary>
        protected void gvEmployees_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvEmployees.EditIndex = -1;
            Grid_Fill(); 
        }
        #endregion          
    }
   
}