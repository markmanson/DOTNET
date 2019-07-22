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
    /// <summary>
    /// Class Name:ADD_EmployeeTerritories
    /// Description:Add new records in EmployeeTerritories Table
    /// </summary>
    public partial class ADD_EmployeeTerritories : System.Web.UI.Page
    {
        #region Page Load
        /// <summary>
        /// Event Name:Page_Load
        /// Description:Set focus on Control and initialize the webcontrols
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>             
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                ConstantMessages objconst;
                StringBuilder strBrInsert;
                SqlConnection sqlconn;
                sqlconn = new SqlConnection();
                SqlCommand sqlcmd;
                SqlDataAdapter sqladapter;
                DataTable dttable;
                strBrInsert = new StringBuilder("SELECT EmployeeID");
                strBrInsert.Append(" FROM Employees");
                try
                {
                    sqlconn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
                    sqlconn.Open();
                    sqlcmd = new SqlCommand(strBrInsert.ToString(), sqlconn);
                    sqladapter = new SqlDataAdapter(sqlcmd);
                    dttable = new DataTable();
                    sqladapter.Fill(dttable);
                    DdlEmployeeID.DataSource = dttable;
                    DdlEmployeeID.DataTextField = "EmployeeID";
                    DdlEmployeeID.DataValueField = "EmployeeID";
                    DdlEmployeeID.DataBind();
                }
                catch (Exception)
                {
                    objconst = new ConstantMessages();
                    Response.Redirect(objconst.strerrorpage);

                }
                finally
                {
                    if (sqlconn.State == ConnectionState.Open)
                    {
                        sqlconn.Close();
                    }
                    objconst = null;
                    strBrInsert = null;
                    sqlconn = null;
                    sqlcmd = null;
                    sqladapter = null;
                    dttable = null;
                }
            }            
        }
        #endregion
        #region Insert Button Click
        /// <summary>
        /// Event Name:BtnInsert_Click
        /// Description:Insert the data in EmployeeTerritories Table
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnInsert_Click(object sender, EventArgs e)
        {
            //SQL CONNECTION 
            SqlConnection sqlconn;
            ConstantMessages objconstmsg;
            objconstmsg = new ConstantMessages();
            SqlCommand sqlcmd;
            SqlCommand Check_TerritoryID;
            SqlCommand Check_EmployeeID_TerritoryID;
            StringBuilder strBrTerritoryID;
            StringBuilder strBrEmp_Terr_ID;
            int TerritoryID_Exist;
            int EmployeeID_TerritoryID_Exist;                                                              
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
                    //Existance checking of TerritoryID in Territory Table
                    strBrTerritoryID = new StringBuilder("SELECT TerritoryID ");
                    strBrTerritoryID.Append(" FROM Territories");
                    strBrTerritoryID.Append(" WHERE (TerritoryID='" + TxtTerritoryID.Text + "')");
                    Check_TerritoryID = new SqlCommand(strBrTerritoryID.ToString(), sqlconn);
                    TerritoryID_Exist = Convert.ToInt32(Check_TerritoryID.ExecuteScalar());

                    //Existance in Employeeterritories Table
                    strBrEmp_Terr_ID = new StringBuilder("SELECT EmployeeID,TerritoryID ");
                    strBrEmp_Terr_ID.Append(" FROM EmployeeTerritories");
                    strBrEmp_Terr_ID.Append(" WHERE EmployeeID='" + DdlEmployeeID.SelectedValue + "' AND TerritoryID='" + TxtTerritoryID.Text + "';");
                    Check_EmployeeID_TerritoryID = new SqlCommand(strBrEmp_Terr_ID.ToString(), sqlconn);
                    EmployeeID_TerritoryID_Exist = Convert.ToInt32(Check_EmployeeID_TerritoryID.ExecuteScalar());

                    if (TerritoryID_Exist <= 0)
                    {
                        objconstmsg = new ConstantMessages();
                        ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "alert('" + objconstmsg.stralertmessageTerritoryID + "');", true);
                    }

                    else if (EmployeeID_TerritoryID_Exist > 0)
                    {
                        objconstmsg = new ConstantMessages();
                        ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "alert('" + objconstmsg.stralertmessageEmp_Terr_ID + "');", true);
                    }
                    else
                    {
                        strBrInsertQuery = new StringBuilder("insert");
                        strBrInsertQuery.Append(" into EmployeeTerritories ");
                        strBrInsertQuery.Append(" (EmployeeID,TerritoryID)");
                        strBrInsertQuery.Append(" values");
                        strBrInsertQuery.Append(" ('" + DdlEmployeeID.SelectedItem.Value.ToString() + "','" + TxtTerritoryID.Text + "')");
                        sqlcmd = new SqlCommand(strBrInsertQuery.ToString(), sqlconn);
                        sqlcmd.ExecuteNonQuery();
                        objconstmsg = new ConstantMessages();
                        ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "alert('" + objconstmsg.stralertSuccessfulInsert + "');", true);
                    }
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
                sqlcmd = null;
                strBrInsertQuery = null;
                objconstmsg = null;
                strBrInsertQuery = null;
                Check_TerritoryID = null;
                Check_EmployeeID_TerritoryID = null;
                strBrTerritoryID = null;
                strBrEmp_Terr_ID = null;
                TxtTerritoryID.Text = "";
            }            
        }
        #endregion
    }
}