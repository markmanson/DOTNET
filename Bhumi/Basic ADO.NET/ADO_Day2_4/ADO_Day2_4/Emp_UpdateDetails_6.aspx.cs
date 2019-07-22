using System;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;
using System.Data;
namespace ADO_Day2_4
{   
    /// <summary>
    /// Class Name:Emp_UpdateDetails_6
    /// Description: Update query and rollback or commit transaction
    /// Author:bhumi
    /// </summary>
    public partial class Emp_UpdateDetails_6 : System.Web.UI.Page
    {
        #region Pageload Event
        protected void Page_Load(object sender, EventArgs e)
        {
            //load page
            ddlId.Focus();
        }
        #endregion
        #region Index Change of Dropdownlist
        /// <summary>
        /// Method Name:DropDownList1_SelectedIndexChanged
        /// Description: According to selection of Dropdownlist Textboxes text set
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            //SQL objects
            SqlConnection sqlconn;
            SqlCommand sqlcmd;
            SqlDataAdapter sqladapter;
            SqlDataReader sqlreader;
            sqlconn = new SqlConnection();
            StringBuilder strbuider;
            ConstantMessages objconstmsg;
            try
            {
                if (ddlId.SelectedValue != "0")
                {
                sqlconn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
                if (sqlconn.State == ConnectionState.Closed)
                {
                    sqlconn.Open();//open the connection                
                }
                //insert SQLquery in String builder
                strbuider = new StringBuilder("SELECT EmployeeID,FirstName,LastName,City,Country ");
                strbuider.Append(" FROM");
                strbuider.Append(" Employees");
                strbuider.Append(" Where EmployeeID='" + ddlId.SelectedItem.Value.ToString() + "'");
                sqlcmd = new SqlCommand(strbuider.ToString(), sqlconn);
                sqladapter = new SqlDataAdapter(sqlcmd);
                sqlreader = sqlcmd.ExecuteReader();//Reading data
                while (sqlreader.Read())
                {
                    //store the dat in textbox from sql reader
                    txtName.Text = sqlreader[1].ToString();
                    txtLastname.Text = sqlreader[2].ToString();
                    txtCity.Text = sqlreader[3].ToString();
                    txtCountry.Text = sqlreader[4].ToString();
                }
                sqlreader = null;
                }
            }
            
            catch (Exception)
            {
                objconstmsg = new ConstantMessages();
                Server.Transfer(objconstmsg.strerrorpage);
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
                 strbuider = null;
            }
        }
        #endregion
        #region Update Button Click Event
        /// <summary>
        /// Method Name:Button1_Click()
        /// Description: Update operation while clicking update button
        /// Author:bhumi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            ConstantMessages objconst;
            //Sql Objects
            SqlConnection sqlconn;
            SqlCommand sqlcmd;
            SqlDataAdapter sqladapter;
            SqlTransaction sqltransact;            
            sqlconn = new SqlConnection();
            StringBuilder strbuider;
            if (ddlId.SelectedValue != "0")
            {
                sqlconn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
                if (sqlconn.State == ConnectionState.Closed)
                {
                    sqlconn.Open();//open the connection            
                }
                sqltransact = sqlconn.BeginTransaction("Transaction"); //Begin Transaction               
                try
                {
                    //insert SQLquery in String builder
                    strbuider = new StringBuilder("UPDATE Employees");
                    strbuider.Append(" SET ");
                    strbuider.Append(" FirstName='" + txtName.Text + "',LastName='" + txtLastname.Text + "' ,City='" + txtCity.Text + "' ,Country='" + txtCountry.Text + "'");
                    strbuider.Append(" Where EmployeeID='" + ddlId.SelectedItem.Value.ToString() + "'");
                    sqlcmd = new SqlCommand(strbuider.ToString(), sqlconn, sqltransact);
                    sqladapter = new SqlDataAdapter(sqlcmd);
                    sqlcmd.ExecuteNonQuery();
                    sqltransact.Commit();//Commit
                    //Alert Message after data updation
                    objconst = new ConstantMessages();
                    ClientScript.RegisterStartupScript(this.GetType(), "msgbox", objconst.stralertmessage, true);
                    ddlId.SelectedValue = "0";
                    txtName.Text = "";
                    txtLastname.Text = "";
                    txtCity.Text = "";
                    txtCountry.Text = "";
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
                    sqlcmd = null;
                    sqladapter = null;
                    sqltransact = null;
                    strbuider = null;                    
                }
            }
            else
            {
                objconst = new ConstantMessages();
                Response.Write(objconst.strselectEmpId);
            }
        }
        #endregion
    }
}