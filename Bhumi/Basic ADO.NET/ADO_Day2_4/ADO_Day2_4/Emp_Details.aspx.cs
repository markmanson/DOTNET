using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Text;
using System.Web.UI.WebControls;
namespace ADO_Day2_4
{
    /// <summary>
    /// Class Name:Emp_Details
    /// Description:EDIT,DELETE,SELECT features of gridview
    /// Author:bhumi
    /// </summary>
    public partial class Emp_Details : System.Web.UI.Page
    {
        CommonFunctions objcmnfunction;
        Employees_TypedDataSet dataset;
        DataTable dtEmployees;
        ConstantMessages objconstmsg;
        object id;
        #region Page Load Event
        protected void Page_Load(object sender, EventArgs e)
        {
            lblmessage.Visible = false;
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
        /// Created On:1/6/2015
        /// </summary>       
        public void Grid_Fill()
        {
            StringBuilder strbuilder;//string builder for query        
            try
            {                
                objconstmsg = new ConstantMessages();
                //insert SQLquery in String builder
                strbuilder = new StringBuilder("SELECT EmployeeID,FirstName,LastName,TitleOfCourtesy,CONVERT(nvarchar,BirthDate,110) AS BirthDate,Address,City,Country,HomePhone");
                strbuilder.Append(" FROM");
                strbuilder.Append(" Employees;");
                //connection generation and read the data fro reader
                objcmnfunction = new CommonFunctions();
                //datatable
                dtEmployees = new DataTable();
                //dataset
                dataset = new Employees_TypedDataSet();
                dtEmployees = objcmnfunction.ConnectionGenerate(strbuilder.ToString());
                //fill the dataset
                dataset.Tables.Add(dtEmployees);
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
                //objcmnfunction = null;
            }
        
        }
        #endregion
        #region PageIndex Change
        /// <summary>
        /// method name:GridView1_PageIndexChanging
        /// Description: Page Index Change Event
        /// Author:bhumi
        /// Created On:1/6/2015
        /// </summary>
        
        protected void GridView1_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            Grid_Fill();
            gvEmployees.PageIndex = e.NewPageIndex;
            gvEmployees.DataBind();
        }
        #endregion
        #region Row Deletion
        /// <summary>
        /// method name:GridView1_RowDeleting
        /// Description: Deletion of Row
        /// Author:bhumi
        /// Created On:1/6/2015
        /// </summary>
        
        //SQL CONNECTION 
        SqlConnection sqlconn;
        SqlCommand sqlcmd;
        SqlTransaction sqltransact;
        StringBuilder strbuilder;
        protected void GridView1_RowDeleting(object sender, System.Web.UI.WebControls.GridViewDeleteEventArgs e)
        {
            string confirmValue = Request.Form["confirm_value"];
            if (confirmValue == "Yes")
            {
                lblmessage.Visible = true;
                try
                {
                    id = gvEmployees.DataKeys[e.RowIndex].Value;
                    sqlconn = new SqlConnection();
                    sqlconn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
                    if (sqlconn != null && sqlconn.State == ConnectionState.Closed)
                    {
                        sqlconn.Open();//open the connection                                
                        sqltransact = sqlconn.BeginTransaction("Transaction"); //Transaction start  
                    }
                    //Query execution
                    strbuilder = new StringBuilder("DELETE");
                    strbuilder.Append(" FROM Employees ");
                    strbuilder.Append(" WHERE EmployeeID=@EmployeeID");
                    sqlcmd = new SqlCommand(strbuilder.ToString(), sqlconn, sqltransact);
                    sqlcmd.Parameters.AddWithValue("@EmployeeID", id);
                    //ClientScript.RegisterStartupScript(this.GetType(), "msgboxconfirm", "confirm('Are You Sure??');", true);
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
                        sqlcmd = null;
                        sqltransact = null;
                        
                    }
                }                  
            }
            else
            {
                //cancle Deletion                
            }                             
        }
        #endregion
        #region Edit the rows
        /// <summary>
        /// method name:GridView1_RowEditing
        /// Description: Edit Row
        /// Author:bhumi
        /// Created On:1/6/2015
        /// </summary>        
        protected void GridView1_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {          
             gvEmployees.EditIndex = e.NewEditIndex;
             Grid_Fill();                            
        }                
        protected void GridView1_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {

                SqlCommand sqlcmd;
                SqlDataAdapter sqladapter;
                SqlDataReader sqlreader;
                DataTable datatable;
                SqlConnection sqlconn;
                StringBuilder query;
                sqlconn = new SqlConnection();
                //Get the data from gridview
                id = gvEmployees.DataKeys[e.RowIndex].Value;
                GridViewRow row = gvEmployees.Rows[e.RowIndex] as GridViewRow;
                TextBox txtlnm = row.FindControl("lname_Edit") as TextBox;
                TextBox txtfnm = row.FindControl("fname_Edit") as TextBox;
                TextBox txttitl = row.FindControl("title_Edit") as TextBox;
                TextBox txtbirthdy = row.FindControl("birthday_Edit") as TextBox;
                TextBox txtaddrs = row.FindControl("address_Edit") as TextBox;
                TextBox txtcty = row.FindControl("city_Edit") as TextBox;
                TextBox txtcntry = row.FindControl("country_Edit") as TextBox;
                TextBox txtcontactno = row.FindControl("contactno_Edit") as TextBox;
                try
                {

                    //connectionstring
                    sqlconn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
                    if (sqlconn != null && sqlconn.State == ConnectionState.Closed)
                    {
                        sqlconn.Open();//open the connection 

                    }
                    query = new StringBuilder("UPDATE Employees set ");
                    query.Append("LastName=@LastName,FirstName=@FirstName,");
                    query.Append("TitleOfCourtesy=@TitleOfCourtesy,BirthDate=@BirthDate,Address=@Address,");
                    query.Append("City=@City,Country=@Country,HomePhone=@HomePhone");
                    query.Append(" WHERE EmployeeID=@EmployeeID;");
                    sqlcmd = new SqlCommand(query.ToString(), sqlconn);
                    //Update the data
                    sqlcmd.Parameters.AddWithValue("@EmployeeID", SqlDbType.VarChar).Value = id;
                    sqlcmd.Parameters.AddWithValue("@LastName", SqlDbType.VarChar).Value = txtlnm.Text;
                    sqlcmd.Parameters.AddWithValue("@FirstName", SqlDbType.VarChar).Value = txtfnm.Text;
                    sqlcmd.Parameters.AddWithValue("@TitleOfCourtesy", SqlDbType.VarChar).Value = txttitl.Text;
                    sqlcmd.Parameters.AddWithValue("@BirthDate", SqlDbType.VarChar).Value = txtbirthdy.Text;
                    sqlcmd.Parameters.AddWithValue("@Address", txtaddrs.Text);
                    sqlcmd.Parameters.AddWithValue("@City", SqlDbType.VarChar).Value = txtcty.Text;
                    sqlcmd.Parameters.AddWithValue("@Country", SqlDbType.VarChar).Value = txtcntry.Text;
                    sqlcmd.Parameters.AddWithValue("@HomePhone", SqlDbType.VarChar).Value = txtcontactno.Text;
                    //Execute Query
                    sqladapter = new SqlDataAdapter(sqlcmd);
                    sqlcmd.ExecuteNonQuery();
                    sqlreader = sqlcmd.ExecuteReader();//Reading data
                    datatable = new DataTable();
                    datatable.Load(sqlreader);
                    gvEmployees.DataSource = datatable;

                    gvEmployees.DataBind();
                    gvEmployees.EditIndex = -1;
                    Grid_Fill();//Display Gridview
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
                    datatable = null;
                    query = null;
                }              
        }
        #endregion
        #region Cancel Edit
        /// <summary>
        /// method name:GridView1_RowCancelingEdit
        /// Description:Canceling the Row editing
        /// Author:bhumi
        /// Created On:1/6/2015
        /// </summary>       
        protected void GridView1_RowCancelingEdit(object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
            gvEmployees.EditIndex = -1;
            Grid_Fill(); 
        }
        #endregion                       
    }
}