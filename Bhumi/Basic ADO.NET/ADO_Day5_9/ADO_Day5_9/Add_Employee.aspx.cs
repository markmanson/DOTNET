using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Data;
/// <summary>
/// Namespace Name:ADO_Day5_9
/// Description: Typed Dataset,Gridview Databinding and Its Feature & Validation
/// Author:Bhumi
/// Created On:8/6/2015
/// </summary>
namespace ADO_Day5_9
{
    /// <summary>
    /// Class Name:Add_Employee
    /// Description:Add new Employee in Employees Table
    /// Author:Bhumi
    /// Created On:9/6/2015
    /// </summary>
    public partial class Add_Employee : System.Web.UI.Page
    {
        /// <summary>
        /// Event Name: Page_Load
        /// Description: Set the all controls on page and set focus on first control
        /// Author:Bhumi
        /// Created On:9/6/2015    
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlHSalutation.Focus();
        }
        #region Click Event of ADD New Button
        /// <summary>
        /// Event Name: BtnHAdd_Click
        /// Description: ADD Button Click Event
        /// Author:Bhumi
        /// Created On:9/6/2015             
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnHAdd_Click(object sender, EventArgs e)
        {
            //SQL CONNECTION 
            SqlConnection sqlconn;
            ConstantMessages objconstmsg;
            objconstmsg = new ConstantMessages();
            SqlCommand sqlcmd;
            sqlconn = new SqlConnection();
            StringBuilder strBrInsertQuery;
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
                    strBrInsertQuery = new StringBuilder("insert");
                    strBrInsertQuery.Append(" into Employees ");
                    strBrInsertQuery.Append(" (TitleOfCourtesy,FirstName,LastName,BirthDate,City,Country,HomePhone)");
                    strBrInsertQuery.Append(" values");
                    strBrInsertQuery.Append(" ('" + ddlHSalutation.SelectedItem.Value.ToString() + "','" + TxtHFirstName.Text + "','" + TxtHLastName.Text + "','" + TxtHBirthDate.Text + "','" + TxtHCity.Text + "','" + TxtHCountry.Text + "','" + TxtHPhoneNo.Text + "')");
                    sqlcmd = new SqlCommand(strBrInsertQuery.ToString(), sqlconn);                                        
                    sqlcmd.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
                Response.Redirect(objconstmsg.strerrorpage);
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
                Server.Transfer(objconstmsg.strDefaultPage);
            }            
        }
        #endregion
    }    
}