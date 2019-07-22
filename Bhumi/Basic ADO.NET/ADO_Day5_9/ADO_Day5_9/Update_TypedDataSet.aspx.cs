using System;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;
using System.Data;
namespace ADO_Day5_9
{
    /// <summary>
    /// Class Name:Update_TypedDataSet
    /// Description:Handle Update in Typed Dataset
    /// Author:Bhumi
    /// Created On:8/6/2015
    /// </summary>
    public partial class Update_TypedDataSet : System.Web.UI.Page
    {
        #region Update Typed DataSet
        protected void Page_Load(object sender, EventArgs e)
        {
            LblEmployeeID.Visible = false;
            if (!IsPostBack)
            {
                DdlHEmployeeID.Focus();//set focus on EmployeeID   
                EmployeeID_Fill();
            }            
        }
        #endregion
        #region Databind in dropdownlist
        /// <summary>
        /// Method Name:EmployeeID_Fill
        /// Description: Get the data from table bind with control
        /// </summary>
        public void EmployeeID_Fill()
        {
            ConstantMessages objconst;
            //DdlHEmployeeID.Items.Clear();
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
                DdlHEmployeeID.DataSource = dttable;
                DdlHEmployeeID.DataTextField = "EmployeeID";
                DdlHEmployeeID.DataValueField = "EmployeeID";
                DdlHEmployeeID.DataBind();
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
        #endregion
        #region index change of dropdownlist control
        /// <summary>
        /// Method Name:DdlHEmployeeID_SelectedIndexChanged
        /// Description: According to selection of Dropdownlist Textboxes text set
        /// Author:Bhumi
        /// Created On:8/6/2015    
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void DdlHEmployeeID_SelectedIndexChanged(object sender, EventArgs e)
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
                if (DdlHEmployeeID.SelectedValue != "0")
                {
                    sqlconn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
                    if (sqlconn.State == ConnectionState.Closed)
                    {
                        sqlconn.Open();//open the connection                
                    }
                    //insert SQLquery in String builder
                    strbuider = new StringBuilder("SELECT EmployeeID,FirstName,LastName,HomePhone,City,PostalCode ");
                    strbuider.Append(" FROM");
                    strbuider.Append(" Employees");
                    strbuider.Append(" Where EmployeeID='" + DdlHEmployeeID.SelectedItem.Value.ToString() + "'");
                    sqlcmd = new SqlCommand(strbuider.ToString(), sqlconn);
                    sqladapter = new SqlDataAdapter(sqlcmd);
                    sqlreader = sqlcmd.ExecuteReader();//Reading data
                    while (sqlreader.Read())
                    {
                        //store the dat in textbox from sql reader
                        TxtHFirstName.Text = sqlreader[1].ToString();
                        TxtHLastName.Text = sqlreader[2].ToString();
                        TxtHHomePhone.Text = sqlreader[3].ToString();
                        TxtHCity.Text = sqlreader[4].ToString();
                        TxtHPostalCode.Text = sqlreader[5].ToString();
                    }
                    sqlreader = null;
                }
                else
                {
                    TxtHFirstName.Text = "";
                    TxtHLastName.Text = "";
                    TxtHHomePhone.Text = "";
                    TxtHCity.Text = "";
                    TxtHPostalCode.Text = "";
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
        #region Update Button click event
        /// <summary>
        /// Method Name:BtnHUpdate_Click
        /// Description: Click Event Of Update Button
        /// Author:Bhumi
        /// Created On:8/6/2015
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnHUpdate_Click(object sender, EventArgs e)
        {
            ConstantMessages objconstmsg;
            Employee_Dataset dsEmployees;
            //Sql Objects
            SqlConnection sqlconn;
            SqlCommand sqlcmd;
            SqlDataAdapter sqladapter;
            SqlTransaction sqltransact;
            sqlconn = new SqlConnection();
            StringBuilder strBrUpdateQuery;
            if (DdlHEmployeeID.SelectedValue != "0")
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
                    strBrUpdateQuery = new StringBuilder("UPDATE Employees");
                    strBrUpdateQuery.Append(" SET ");
                    strBrUpdateQuery.Append(" FirstName='" + TxtHFirstName.Text + "',LastName='" + TxtHLastName.Text + "' ,HomePhone='" + TxtHHomePhone.Text + "' ,City='" + TxtHCity.Text + "' ,PostalCode='" + TxtHPostalCode.Text + "'");
                    strBrUpdateQuery.Append(" Where EmployeeID='" + DdlHEmployeeID.SelectedItem.Value.ToString() + "'");
                    sqlcmd = new SqlCommand(strBrUpdateQuery.ToString(), sqlconn, sqltransact);
                    sqladapter = new SqlDataAdapter(sqlcmd);
                    dsEmployees = new Employee_Dataset();
                    sqladapter.Fill(dsEmployees,"Employees");
                    sqladapter = new SqlDataAdapter(sqlcmd);                    
                    sqlcmd.ExecuteNonQuery();
                    sqltransact.Commit();//Commit
                    //Alert Message after data updation
                    DdlHEmployeeID.SelectedValue = "0";
                    TxtHFirstName.Text = "";
                    TxtHLastName.Text = "";
                    TxtHHomePhone.Text = "";
                    TxtHCity.Text = "";
                    TxtHPostalCode.Text = "";
                    objconstmsg = new ConstantMessages();
                    ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "alert('" + objconstmsg.stralertSuccessfulInsert + "');", true);                  
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
                    strBrUpdateQuery = null;
                }
            }
            else
            {
                //objconst = new ConstantMessages();
                //Response.Write(objconst.strselectEmpId);
                LblEmployeeID.Visible = true;
            }
        }
        #endregion
    }
   
}