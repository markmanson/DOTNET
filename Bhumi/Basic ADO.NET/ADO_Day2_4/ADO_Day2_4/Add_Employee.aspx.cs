using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Data;
namespace ADO_Day2_4
{    
    /// <summary>
    /// Class Name:Add_Employee
    /// Description: Add Functionality in Gridview
    /// Author:Bhumi
    /// Created On:1/6/2015
    /// </summary>
    public partial class Add_Employee : System.Web.UI.Page
    {
        #region PageLoad Event
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlSalutation.Focus();//set the focus on control
        }
        #endregion
        #region ADD Button Click Event
        /// <summary>
        /// Method Name:BtnHAdd_Click
        /// Description: Click on ADD Button Method will be performed
        /// Author: bhumi
        /// Created at:2/6/2015
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
            StringBuilder strbuilder;
            //DateTime date;
            try
            {
                if (Page.IsPostBack)
                {
                    //date = Convert.ToDateTime(TextBox8_CalendarExtender.SelectedDate);
                    //connectionstring
                    sqlconn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
                    //SQLQuery 
                    if (sqlconn != null && sqlconn.State == ConnectionState.Closed)
                    {
                        sqlconn.Open();//open the connection                        
                    }
                    strbuilder = new StringBuilder("insert");
                    strbuilder.Append(" into Employees ");
                    strbuilder.Append(" (LastName,FirstName,TitleOfCourtesy,BirthDate,Address,City,Country,HomePhone)");
                    strbuilder.Append(" values");
                    strbuilder.Append(" ('" + txtLastname.Text + "','" + txtFirstname.Text + "','" + ddlSalutation.SelectedItem.Value.ToString() + "','" + txtbirthday.Text + "','" + txtaddress.Text + "','" + txtCity.Text + "','" + txtCountry.Text + "','" + txtphoneno.Text + "')");
                    sqlcmd = new SqlCommand(strbuilder.ToString(), sqlconn);
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
                    sqlcmd = null;
                    strbuilder = null;
                    Server.Transfer(objconstmsg.stremp_detailspage);
                }
            }
        }
        #endregion
    }
}