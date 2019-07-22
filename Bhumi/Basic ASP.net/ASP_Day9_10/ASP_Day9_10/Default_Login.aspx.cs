using System;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;
using System.Data;
/// <summary>
/// NamespaceName:ASP_Day9_10
/// Description: Authentication and state Management
/// Author: Bhumi
/// Created On:1/7/2015
/// </summary> 
namespace ASP_Day9_10
{
    /// <summary>
    /// Class Name:Default_Login
    /// Description:Authentication & State managemnet
    /// Author:Bhumi
    /// Created On:1/7/2015
    /// </summary>
    public partial class Default_Login : System.Web.UI.Page
    {
        #region Page Load
        protected void Page_Load(object sender, EventArgs e)
        {            
            LblInvalid.Visible = false;//visibility false
        }
        #endregion
        #region Submit Button Click Event
        /// <summary>
        /// Method Name:BtnSubmit_Click
        /// Description:Store Login Details in session Variables and check Authentication of user
        /// Author:Bhumi
        /// Created on:1/7/2015  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn;
            ConstantMessages objconst;            
            SqlCommand sqlcmd;
            object UserName_Password_Exist;
            sqlconn = new SqlConnection();
            StringBuilder strBrSelectQuery;
            try
            {
                //connectionstring
                sqlconn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
                if (sqlconn != null && sqlconn.State == ConnectionState.Closed)
                {
                    sqlconn.Open();//open the connection                        
                }
                //Existance in Employees_Temp Table
                strBrSelectQuery = new StringBuilder("SELECT FirstName,LastName ");
                strBrSelectQuery.Append(" FROM Employees_Temp");
                strBrSelectQuery.Append(" WHERE FirstName='" + TxtUserName.Text + "' COLLATE Latin1_General_CS_AS AND LastName='" + TxtPassword.Text + "' COLLATE Latin1_General_CS_AS ;");
                sqlcmd = new SqlCommand(strBrSelectQuery.ToString(), sqlconn);
                UserName_Password_Exist = sqlcmd.ExecuteScalar();
                if (UserName_Password_Exist != null)
                {
                    //Store Details in Sessio Variables
                    Session["UserName"] = TxtUserName.Text;                    
                    objconst = new ConstantMessages();
                    Response.Redirect(objconst.strSecurepage);
                }
                else
                {
                    LblInvalid.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                if (sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
                }
                objconst = null;
                sqlcmd = null;
                strBrSelectQuery = null;
            }
        }
        #endregion
    }
}