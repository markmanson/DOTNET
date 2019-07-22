using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Text;
using System.Web.UI.WebControls;
using System.Web.UI;
/// <summary>
/// Namespace Name:ADO_Day5_9
/// Description: Typed Dataset,Gridview Databinding and Its Feature & Validation
/// Author:Bhumi
/// Created On:8/6/2015
/// </summary>
namespace ADO_Day5_9
{
    /// <summary>
    /// Class Name:EmployeeTerritories
    /// Description: EmployeeTerritories Details in gridview with all Feature and validations
    /// Author:Bhumi
    /// Created on:10/6/2015
    /// </summary>
    public partial class EmployeeTerritories : System.Web.UI.Page
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
            LblMandatoryField.Visible = false;
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
        /// Created On:10/6/2015
        /// </summary>
        public void Grid_Fill()
        {
            StringBuilder strBrSelectQuery;//string builder for query        
            try
            {
                objconstmsg = new ConstantMessages();
                //insert SQLquery in String builder
                strBrSelectQuery = new StringBuilder("SELECT EmployeeID,TerritoryID");
                strBrSelectQuery.Append(" FROM");
                strBrSelectQuery.Append(" EmployeeTerritories;");
                //connection generation and read the data from reader
                objcmnfunction = new CommanFunction();
                //datatable
                dtEmployees = new DataTable();
                dtEmployees = objcmnfunction.ConnectionGenerate(strBrSelectQuery.ToString());                
                //store data in grid view
                gvEmployeeTerritory.DataSource = dtEmployees;
                gvEmployeeTerritory.DataBind();
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
        /// Event Name:gvEmployeeTerritory_PageIndexChanging
        /// Description:Handle the Event of Changing in Index of Page
        /// Author:bhumi
        /// Created On:10/6/2015        
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvEmployeeTerritory_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvEmployeeTerritory.PageIndex = e.NewPageIndex;
            Grid_Fill();
            gvEmployeeTerritory.DataBind(); 
        }
        #endregion
        #region Cancel Edit
        /// <summary>
        /// method name:gvEmployeeTerritory_RowCancelingEdit
        /// Description:Canceling the Row editing       
        /// Author:bhumi
        /// Created On:10/6/2015        
        /// </summary>
        protected void gvEmployeeTerritory_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gvEmployeeTerritory.EditIndex = -1;
            Grid_Fill(); 
        }
        #endregion
        #region Edit Rows
        /// <summary>
        ///Event Name:gvEmployeeTerritory_RowEditing
        /// Description:Edit Rows
        /// Author:bhumi
        /// Created On:10/6/2015        
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvEmployeeTerritory_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gvEmployeeTerritory.EditIndex = e.NewEditIndex;
            Grid_Fill();
        }
        #endregion
        #region Update The Rows of gridview
        /// <summary>
        /// EventName:gvEmployeeTerritory_RowUpdating
        /// Description:Update operation on Rows
        /// Author:bhumi
        /// Created On:10/6/2015        
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvEmployeeTerritory_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            object datakeyEmployeeID, datakeyTerritoryID;
            SqlCommand sqlcmd;
            SqlCommand Check_TerritoryID;
            SqlCommand Check_EmployeeID;
            SqlCommand Check_EmployeeID_TerritoryID;
            SqlDataAdapter sqladapter;
            DataTable dtEmployeeTerritories;
            SqlConnection sqlconn;
            StringBuilder strBrUpdatequery;
            StringBuilder strBrTerritoryID;
            StringBuilder strBrEmployeeID;
            StringBuilder strBrEmp_Terr_ID;
            //SqlCommand Check_TerritoryID;
            int TerritoryID_Exist;
            int EmployeeID_Exist;
            int EmployeeID_TerritoryID_Exist;
            sqlconn = new SqlConnection();
            //Get the data from gridview
            GridViewRow gvrow = gvEmployeeTerritory.Rows[e.RowIndex] as GridViewRow;
            TextBox TxtEmployeeID = gvrow.FindControl("TxtEmployeeID") as TextBox;
            TextBox TxtTerritoryID = gvrow.FindControl("TxtTerritoryID") as TextBox;
            datakeyEmployeeID = gvEmployeeTerritory.DataKeys[e.RowIndex].Values["EmployeeID"];
            datakeyTerritoryID = gvEmployeeTerritory.DataKeys[e.RowIndex].Values["TerritoryID"];           
            try
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
                
                //Existance Checking of EmployeeID in Employees Table
                strBrEmployeeID = new StringBuilder("SELECT EmployeeID ");
                strBrEmployeeID.Append(" FROM Employees");
                strBrEmployeeID.Append(" WHERE (EmployeeID='" + TxtEmployeeID.Text + "')");
                Check_EmployeeID = new SqlCommand(strBrEmployeeID.ToString(), sqlconn);
                EmployeeID_Exist = Convert.ToInt32(Check_EmployeeID.ExecuteScalar());

                //Existance in Employeeterritories Table
                strBrEmp_Terr_ID = new StringBuilder("SELECT EmployeeID,TerritoryID ");
                strBrEmp_Terr_ID.Append(" FROM EmployeeTerritories");
                strBrEmp_Terr_ID.Append(" WHERE EmployeeID='" + TxtEmployeeID.Text + "' AND TerritoryID='" + TxtTerritoryID.Text + "';");
                Check_EmployeeID_TerritoryID = new SqlCommand(strBrEmp_Terr_ID.ToString(), sqlconn);
                EmployeeID_TerritoryID_Exist = Convert.ToInt32(Check_EmployeeID_TerritoryID.ExecuteScalar());

                if (EmployeeID_Exist <= 0)
                {
                    objconstmsg = new ConstantMessages();
                    ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "alert('" + objconstmsg.stralertmessageEmployeeID + "');", true);                    
                }
                else if (TerritoryID_Exist <= 0)
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
                    strBrUpdatequery = new StringBuilder("UPDATE EmployeeTerritories set ");
                    strBrUpdatequery.Append("EmployeeID=@EmpID,TerritoryID=@TerID ");
                    strBrUpdatequery.Append(" WHERE EmployeeID='" + datakeyEmployeeID.ToString() + "' AND TerritoryID='" + datakeyTerritoryID.ToString() + "';");
                    sqlcmd = new SqlCommand(strBrUpdatequery.ToString(), sqlconn);
                    //Update the data
                    sqlcmd.Parameters.AddWithValue("@EmpID", SqlDbType.Int).Value = TxtEmployeeID.Text;
                    sqlcmd.Parameters.AddWithValue("@TerID", SqlDbType.NVarChar).Value = TxtTerritoryID.Text;
                    sqladapter = new SqlDataAdapter(sqlcmd);
                    dtEmployeeTerritories = new DataTable();
                    sqladapter.Fill(dtEmployeeTerritories);
                    gvEmployeeTerritory.DataSource = dtEmployeeTerritories;
                    gvEmployeeTerritory.DataBind();
                    gvEmployeeTerritory.EditIndex = -1;
                    Grid_Fill();//Display Gridview
                    objconstmsg = new ConstantMessages();
                    ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "alert('" + objconstmsg.stralertmessage + "');", true);
                }                              
            }
            catch (Exception)
            {
                objconstmsg = new ConstantMessages();
                Server.Transfer(objconstmsg.strerrorpage);//Exception                
            }
            finally
            {
                if (sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();
                }
                sqlcmd = null;
                sqladapter = null;
                dtEmployeeTerritories = null;
                datakeyEmployeeID = null;
                datakeyTerritoryID = null;
                Check_TerritoryID = null;
                Check_EmployeeID = null;
                Check_EmployeeID_TerritoryID = null;
                strBrUpdatequery = null;                
                strBrTerritoryID = null;
                strBrEmployeeID = null;
                strBrEmp_Terr_ID = null;            
            }
        }
        #endregion
        #region Delete Feature
        /// <summary>
        /// Event Name:gvEmployeeTerritory_RowDeleting
        /// Description:Delete Operation on Rows
        /// Author:bhumi
        /// Created On:10/6/2015        
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        SqlConnection sqlconn;
        SqlCommand sqlcmd;
        SqlTransaction sqltransact;
        StringBuilder strBrDeleteQuery;
        object id;
        object datakeyTerritoryID;
        protected void gvEmployeeTerritory_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {            
            try
            {
                id = gvEmployeeTerritory.DataKeys[e.RowIndex].Value;
                datakeyTerritoryID = gvEmployeeTerritory.DataKeys[e.RowIndex].Values["TerritoryID"]; 
                sqlconn = new SqlConnection();
                sqlconn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
                if (sqlconn != null && sqlconn.State == ConnectionState.Closed)
                {
                    sqlconn.Open();//open the connection                                                      
                }
                sqltransact = sqlconn.BeginTransaction("Transaction"); //Transaction start
                //Query execution
                strBrDeleteQuery = new StringBuilder("DELETE");
                strBrDeleteQuery.Append(" FROM EmployeeTerritories ");
                strBrDeleteQuery.Append(" WHERE EmployeeID=@EmployeeID AND TerritoryID='" + datakeyTerritoryID.ToString() + "';");
                sqlcmd = new SqlCommand(strBrDeleteQuery.ToString(), sqlconn, sqltransact);
                sqlcmd.Parameters.AddWithValue("@EmployeeID", id);
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
            }
        }
        #endregion
        #region ADD click Event
        /// <summary>
        /// Event Name:ADD
        /// Description:New Record Add in Datatable
        /// Author:bhumi
        /// Created On:10/6/2015        
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ADD(object sender, EventArgs e)
        {
            SqlCommand sqlcmd;
            SqlCommand Check_TerritoryID;
            SqlCommand Check_EmployeeID;
            SqlCommand Check_EmployeeID_TerritoryID;            
            SqlDataAdapter sqladapter;
            DataTable dtEmployeeTerritories;
            SqlConnection sqlconn;
            Control control;
            StringBuilder strBrInsertquery;
            StringBuilder strBrTerritoryID;
            StringBuilder strBrEmployeeID;
            StringBuilder strBrEmp_Terr_ID;                            
            sqlconn = new SqlConnection();
            int TerritoryID_Exist;
            int EmployeeID_Exist;
            int EmployeeID_TerritoryID_Exist;            
            //Get the data from gridview            
            if (gvEmployeeTerritory.FooterRow != null)
            {
                control = gvEmployeeTerritory.FooterRow;
            }
            else
            {
                control = gvEmployeeTerritory.Controls[0].Controls[0];
            }
            TextBox EmployeeID = control.FindControl("TxtEmployeeID1") as TextBox;
            TextBox TerritoryID = control.FindControl("TxtTerritoryID1") as TextBox;
            EmployeeID.Enabled = true;
            TerritoryID.Enabled = true;
            try
            {
                if ((!string.IsNullOrEmpty(EmployeeID.Text)) && (!string.IsNullOrEmpty(TerritoryID.Text)))
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
                    strBrTerritoryID.Append(" WHERE (TerritoryID='" + TerritoryID.Text + "')");
                    Check_TerritoryID = new SqlCommand(strBrTerritoryID.ToString(), sqlconn);
                    TerritoryID_Exist = Convert.ToInt32(Check_TerritoryID.ExecuteScalar());

                    //Existance Checking of EmployeeID in Employees Table
                    strBrEmployeeID = new StringBuilder("SELECT EmployeeID ");
                    strBrEmployeeID.Append(" FROM Employees");
                    strBrEmployeeID.Append(" WHERE (EmployeeID='" + EmployeeID.Text + "')");
                    Check_EmployeeID = new SqlCommand(strBrEmployeeID.ToString(), sqlconn);
                    EmployeeID_Exist = Convert.ToInt32(Check_EmployeeID.ExecuteScalar());

                    //Existance in Employeeterritories Table
                    strBrEmp_Terr_ID = new StringBuilder("SELECT EmployeeID,TerritoryID ");
                    strBrEmp_Terr_ID.Append(" FROM EmployeeTerritories");
                    strBrEmp_Terr_ID.Append(" WHERE EmployeeID='" + EmployeeID.Text + "' AND TerritoryID='" + TerritoryID.Text + "';");
                    Check_EmployeeID_TerritoryID = new SqlCommand(strBrEmp_Terr_ID.ToString(), sqlconn);
                    EmployeeID_TerritoryID_Exist = Convert.ToInt32(Check_EmployeeID_TerritoryID.ExecuteScalar());

                    if (EmployeeID_Exist <= 0)
                    {
                        objconstmsg = new ConstantMessages();
                        ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "alert('" + objconstmsg.stralertmessageEmployeeID + "');", true);
                    }
                    else if (TerritoryID_Exist <= 0)
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
                        strBrInsertquery = new StringBuilder("Insert INTO EmployeeTerritories  ");
                        strBrInsertquery.Append("(EmployeeID,TerritoryID) ");
                        strBrInsertquery.Append("Values");
                        strBrInsertquery.Append("(@EmployeeID,@TerritoryID);");
                        sqlcmd = new SqlCommand(strBrInsertquery.ToString(), sqlconn);
                        //Update the data
                        sqlcmd.Parameters.AddWithValue("@EmployeeID", SqlDbType.Int).Value = EmployeeID.Text;
                        sqlcmd.Parameters.AddWithValue("@TerritoryID", SqlDbType.NVarChar).Value = TerritoryID.Text;
                        //Execute Query
                        sqladapter = new SqlDataAdapter(sqlcmd);
                        dtEmployeeTerritories = new DataTable();
                        sqladapter.Fill(dtEmployeeTerritories);
                        gvEmployeeTerritory.DataSource = dtEmployeeTerritories;
                        gvEmployeeTerritory.DataBind();
                        gvEmployeeTerritory.EditIndex = -1;
                        Grid_Fill();//Display Gridview
                        objconstmsg = new ConstantMessages();
                        ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "alert('" + objconstmsg.stralertSuccessfulInsert + "');", true);
                    }                    
                }
                else
                {
                    objconstmsg = new ConstantMessages();
                    LblMandatoryField.Visible = true;
                }
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
                dtEmployeeTerritories = null;
                dtEmployeeTerritories = null;
                Check_TerritoryID = null;
                Check_EmployeeID = null;
                Check_EmployeeID_TerritoryID = null;
                strBrInsertquery = null;                
                strBrTerritoryID = null;
                strBrEmployeeID = null;
                strBrEmp_Terr_ID = null;            
            }
        }
        #endregion
    }
}