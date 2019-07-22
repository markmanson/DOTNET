using System;
using System.Web.UI;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;
using System.Data;
/// <summary>
/// Namespace Name:ADO_Day5_9
/// Description: Typed Dataset,Gridview Databinding and Its Feature & Validation
/// Author:Bhumi
/// Created On:8/6/2015
/// </summary>
namespace ADO_Day5_9
{
    public partial class Add_Edit_Customer : System.Web.UI.Page
    {
        ConstantMessages objconst;
        string customerid;                                            
        #region Page Load
        /// <summary>
        /// Event Name:Page_Load
        /// Description:Fetch the querystring values
        /// Author:Bhumi
        /// Created On:9/6/2015
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                TxtCustomerID.Focus();
                SqlConnection sqlconn;
                SqlCommand sqlcmd;
                SqlDataAdapter sqladapter;
                SqlDataReader sqlreader;
                sqlconn = new SqlConnection();
                StringBuilder strBrSelectQuery;
                try
                {
                    if (string.IsNullOrEmpty(Request.QueryString["CustomerID"]))
                    {
                        BtnHAdd.Visible = true;
                    }
                    else
                    {
                        customerid = Request.QueryString["CustomerID"];
                        TxtCustomerID.Text = customerid;
                        TxtCustomerID.Enabled = false;
                        BtnHUpdate.Visible = true;
                        BtnHCancel.Visible = true;                        
                        try
                        {
                            sqlconn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
                            if (sqlconn.State == ConnectionState.Closed)
                            {
                                sqlconn.Open();//open the connection                
                            }
                            //insert SQLquery in String builder
                            strBrSelectQuery = new StringBuilder("SELECT CustomerID,CompanyName,ContactTitle,City,PostalCode,Phone,Fax");
                            strBrSelectQuery.Append(" FROM");
                            strBrSelectQuery.Append(" Customers");
                            strBrSelectQuery.Append(" Where CustomerID='" + customerid + "'");
                            sqlcmd = new SqlCommand(strBrSelectQuery.ToString(), sqlconn);
                            sqladapter = new SqlDataAdapter(sqlcmd);
                            sqlreader = sqlcmd.ExecuteReader();//Reading data
                            while (sqlreader.Read())
                            {
                                //store the dat in textbox from sql reader
                                TxtCompanyName.Text = sqlreader[1].ToString();
                                TxtContactTitle.Text = sqlreader[2].ToString();
                                TxtCity.Text = sqlreader[3].ToString();
                                TxtPostalCode.Text = sqlreader[4].ToString();
                                TxtPhoneNo.Text = sqlreader[5].ToString();
                                TxtFax.Text = sqlreader[6].ToString();
                            }
                            sqlreader = null;
                        }
                        catch (Exception)
                        {
                            Server.Transfer(objconst.strerrorpage);
                        }
                    }                    
                }
                catch (Exception)
                {
                    objconst = new ConstantMessages();
                    Server.Transfer(objconst.strerrorpage);
                }
                finally
                {
                    if (sqlconn.State == ConnectionState.Open)
                    {
                        sqlconn.Close();
                    }
                    sqlconn = null;   
                    sqlcmd = null;
                    sqladapter = null;
                    sqlreader = null;
                    strBrSelectQuery = null;
                }
            }             
        }
        #endregion
        #region ADD button Click Event
        /// <summary>
        /// Event Name:BtnHAdd_Click
        /// Description:ADD the Customer Details
        /// Author:Bhumi
        /// Created on:9/6/2015
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnHAdd_Click(object sender, EventArgs e)
        {
            //SQL CONNECTION 
            SqlConnection sqlconn;
            objconst = new ConstantMessages();
            SqlCommand sqlcmd;
            SqlCommand Check_CustomerID;
            sqlconn = new SqlConnection();
            StringBuilder strBrInsertQuery;
            StringBuilder strBrCustomerID;
            object CustomerID_Exist;            
            try
            {
                if (Page.IsPostBack)
                {
                    //connectionstring
                    sqlconn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
                   if (sqlconn != null && sqlconn.State == ConnectionState.Closed)
                    {
                        sqlconn.Open();//open the connection                        
                    }
                   strBrCustomerID = new StringBuilder("SELECT CustomerID ");
                   strBrCustomerID.Append(" FROM Customers");
                   strBrCustomerID.Append(" WHERE (CustomerID='" + TxtCustomerID.Text + "')");
                   Check_CustomerID = new SqlCommand(strBrCustomerID.ToString(), sqlconn);
                   CustomerID_Exist = Check_CustomerID.ExecuteScalar();
                   if (CustomerID_Exist != null)
                   {
                       objconst = new ConstantMessages();
                       ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "alert('" + objconst.stralertCustomerID + "');", true);
                   }
                   else
                   {
                    strBrInsertQuery = new StringBuilder("insert");
                    strBrInsertQuery.Append(" into Customers ");
                    strBrInsertQuery.Append(" (CustomerID,CompanyName,ContactTitle,City,PostalCode,Phone,Fax)");
                    strBrInsertQuery.Append(" values");
                    strBrInsertQuery.Append(" ('" + TxtCustomerID.Text + "','" + TxtCompanyName.Text + "','" + TxtContactTitle.Text + "','" + TxtCity.Text + "','" + TxtPostalCode.Text + "','" + TxtPhoneNo.Text + "','" + TxtFax.Text + "')");
                    sqlcmd = new SqlCommand(strBrInsertQuery.ToString(), sqlconn);
                    sqlcmd.ExecuteNonQuery();                    
                   }                    
                }
            }
            catch (Exception)
            {
                Response.Redirect(objconst.strerrorpage);
            }
            finally
            {
                if (sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
                }
                sqlconn = null;
                sqlcmd = null;
                strBrInsertQuery = null;
                objconst = new ConstantMessages();
                Response.Redirect(objconst.strCustomerPage);
            }
        }
        #endregion
        #region Upadate Button Click Event
        /// <summary>
        /// Event Name:BtnHUpdate_Click
        /// Description:Update the Customer Details
        /// Author:Bhumi
        /// Created on:9/6/2015
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnHUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn;
            SqlCommand sqlcmd;
            SqlDataAdapter sqladapter;
            SqlTransaction sqltransact;
            sqlconn = new SqlConnection();
            StringBuilder strBrUpdateQuery;
            sqlconn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
            if (sqlconn.State == ConnectionState.Closed)
            {
                sqlconn.Open();//open the connection            
            }
            sqltransact = sqlconn.BeginTransaction("Transaction"); //Begin Transaction 
            try
            {
                customerid = Request.QueryString["CustomerID"];
                //insert SQLquery in String builder
                strBrUpdateQuery = new StringBuilder("UPDATE Customers");
                strBrUpdateQuery.Append(" SET ");
                strBrUpdateQuery.Append("CompanyName ='" + TxtCompanyName.Text + "',ContactTitle='" + TxtContactTitle.Text + "' ,City='" + TxtCity.Text + "' ,PostalCode='" + TxtPostalCode.Text + "',Phone='" + TxtPhoneNo.Text + "',Fax='" + TxtFax.Text + "'");
                strBrUpdateQuery.Append(" Where CustomerID='" + customerid + "'");
                sqlcmd = new SqlCommand(strBrUpdateQuery.ToString(), sqlconn, sqltransact);
                sqladapter = new SqlDataAdapter(sqlcmd);
                sqlcmd.ExecuteNonQuery();
                sqltransact.Commit();//Commit
                objconst = new ConstantMessages();
                Response.Redirect(objconst.strCustomerPage, false);
                TxtCustomerID.Text = "";
                TxtCompanyName.Text = "";
                TxtContactTitle.Text = "";
                TxtCity.Text = "";
                TxtPostalCode.Text = "";
                TxtPhoneNo.Text = "";
                TxtFax.Text = "";                
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
                sqltransact.Rollback();//Roll back transaction
            }
            finally
            {
                if (sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
                }
                sqlconn = null;
                sqlcmd = null;
                sqladapter = null;
                sqltransact = null;
                strBrUpdateQuery = null;                
            }
        }
        #endregion
        #region Cancel Button Click Event
        /// <summary>
        /// Event Name:BtnHCancel_Click
        /// Description:Cancel the updation
        /// Author:Bhumi
        /// Created on:9/6/2015
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnHCancel_Click(object sender, EventArgs e)
        {
            objconst = new ConstantMessages();
            Response.Redirect(objconst.strCustomerPage,false);
        }
        #endregion
    }
}