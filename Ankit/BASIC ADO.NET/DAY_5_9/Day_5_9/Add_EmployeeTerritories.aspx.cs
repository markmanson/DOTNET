using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI.WebControls;

namespace Day_5_9
{
    #region Add_EmployeeTerritories
    /**************************************************************************************************************************************
     * CLASS                                :::                         Add_EmployeeTerritories
     * AUTHOR                               :::                         ANKIT SHARMA
     * DATE                                 :::                         23/07/2012
     * DESCRIPTION                          :::                         TO MAKE A PAGE TO SHOW THE DETAILS OF EMPLOYEETERRITORIES    
     *************************************************************************************************************************************/
    public partial class Add_EmployeeTerritories : System.Web.UI.Page
    {
        Common objCommon = new Common();                                                         //INITIALIZATION OF OBJECT OF CLASS COMMON
        #region Page_Load
        //FUNCTION PAGE_LOAD ********************************************************************************************************
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)                             
            {
                objCommon.BindGridView(gvEmpTerr,lblError);       //CALLING THE FUNCTION BINDGRIDVIEW                                                                      //CALL THE FUNCTION BINDGRIDVIEW
            }
        }
        #endregion Page_Load
        #region BtnAddTerr_Click
        //FUNCTION FOR BTNADDTERR_CLICK ****************************************************************************************************
        protected void BtnAddTerr_Click(object sender, EventArgs e)
        {
            Session.Remove("EmployeeID");                                           //REMOVING THE SESSION[EMPLOYEEID]
            Response.Redirect("EditTerritories.aspx", false);                       //REDIRECT TO PAGE EDITTERRITORIES
        }
        #endregion BtnAddTerr_Click
        //protected void lnkDelete_Click(object sender, EventArgs e)
        //{
        //    //Response.Redirect("EditTerritories.aspx");
        //}
        #region lnkEdit_Click
        //FUNCTION LNKEDIT_CLICK  **************************************************************************************************************
        protected void lnkEdit_Click(object sender, EventArgs e)
        {           
            GridViewRow row;                                                        //DECLARING THE OBJECT OF GRIDVIEW ROW     
            int EmployeeId;                                                         //DECLARING THE INTEGER
            int rindex = (((GridViewRow)(((LinkButton)(sender)).Parent.BindingContainer))).RowIndex;  //FINDING THE ROW INDEX
            row = (GridViewRow)gvEmpTerr.Rows[rindex];                                
            EmployeeId = Int32.Parse(gvEmpTerr.DataKeys[rindex].Value.ToString());  //TAKING THE VALUE OF EMPLOYEEID
            Session["EmployeeID"] = EmployeeId;                                     //ASSIGN EMPLOYEEID TO SESSION
            Response.Redirect("EditTerritories.aspx", false);                       //REDIRECT TO EDITTERRITORIES
        }
        #endregion lnkEdit_Click
        #region gvEmpTerr_RowDataBound
        //FUNCTION GVEMPTERR_ROWDATABOUND *************************************************************************************************
        protected void gvEmpTerr_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Common objCom;
                StringBuilder strBuild2;                                                         //DECLARATION FOR OBJECT OF STRING BUILDER
                Employees dsEmp1;                                                                //DECLARATION FOR OBJECT OF DATASET
                SqlDataAdapter adpt1;                                                            //DECLARATION FOR OBJECT OF SQLDATAADOPTER
                DataTable dt;
                try
                {
                    dt = new DataTable();                                           //INITIALIZING THE OBJECT OF DATA TABLE
                    strBuild2 = new StringBuilder();                                //INITIALIZING THE OBJECT OF STRINGBUILDER
                    objCom = new Common();                                          //INITIALIZING THE OBJECT OF COMMON
                    dsEmp1 = new Employees();                                       //INITIALIZING THE OBJECT OF DATASET EMPLOYEES
                    ListBox Mylist = (ListBox)e.Row.FindControl("lstDec");          //INITIALIZING THE OBJECT OF LISTBOX
                    string strEmpID = Convert.ToString(gvEmpTerr.DataKeys[e.Row.RowIndex].Value);//ASSIGN THE VALUE OF DATAKEY TO STREMPID
                    strBuild2.Append(Constant.strSelDes);                           //APPEND  THE STRING BUILDER
                    strBuild2.Append(strEmpID);                                     //APPENDING THE STRING BUILDER
                    adpt1 = new SqlDataAdapter(strBuild2.ToString(), objCom.Connect);                    //INITIALIZING THE SQL DATA ADAPTOR
                    adpt1.Fill(dt);                                                     //FILL THE DATA INTO DATASET
                    //gvEmpTerr.DataSource = dt;                                        //TO SEND THE CONTENT OF TABLE INTO GRIDVIEW
                    if (dt.Rows.Count > 0)
                    {
                        Mylist.DataSource = dt;
                        Mylist.DataBind();                          //BINDING THE DATALIST

                    }                                 
                }
                catch (Exception ex)                                //IF ANY EXCEPTION IS OCCURED
                {
                    Response.Redirect("Error.aspx");                //REDIRECT TO ERROR.ASPX IF ANY EXCEPTION IS OCCURES
                }
            }
        }
        #endregion gvEmpTerr_RowDataBound
        protected void gvEmpTerr_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #region gvEmpTerr_RowDeleting
        //FUNCTION GVEMPTERR_ROWDELETING  *************************************************************************************************************
        protected void gvEmpTerr_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            SqlCommand objSqlCommand;
            StringBuilder strQ;
            SqlTransaction transaction;
            string EmployeeID = gvEmpTerr.DataKeys[e.RowIndex].Value.ToString();
            // conn = new SqlConnection(objCon.strConn);
            objCommon.Open_Con();                                        //Connection open              
            objSqlCommand = new SqlCommand();
            transaction = objCommon.Connect.BeginTransaction();              //initialize object of SqlTrasection
            objSqlCommand.Connection = objCommon.Connect;                    //Define connection
            objSqlCommand.Transaction = transaction;            //Define trasection   
            try
            {
                strQ = new StringBuilder();                                 //INITIALIZE THE OBJECT OF STRING BUILDER
                strQ.Append(Constant.strAllEmp1);                           //APPANDING THE STRINGBUILDER
                strQ.Append(" '" + EmployeeID + "' ;");                     //APPANDING THE STRINGBUILDER
                strQ.Append(Constant.strdelterr);                           //APPANDING THE STRINGBUILDER
                strQ.Append(" '" + EmployeeID + "' ");                      //APPANDING THE STRINGBUILDER
                objSqlCommand.CommandText = strQ.ToString();                // Set Sql Query string to Sql Command
                objSqlCommand.Connection = objCommon.Connect;               // Set Connecton String  Sql Command
                int i = objSqlCommand.ExecuteNonQuery();                    // Execute Query
                if (i > 0)                                                  //CHECK IF ANY ROW AFFACTED
                {
                    lblError.Text = Constant.strDelRec;                       //DISPLAY THE MESSEGE 
                    lblError.Visible = true;
                }
                transaction.Commit();
                objCommon.BindGridView(gvEmpTerr,lblError);                 //CALLING THE FUNCTION BINDGRIDVIEW
                objCommon.Close_Con();                                      //CLOSING THE SQL CONNECTION                 
            }
            catch (SqlException ex)
            {
                objCommon.Close_Con();                                   //CLOSING THE FUNCTION
                transaction.Rollback();                                  //ROLLBACK IF TRANSACTION IS NOT SUCCESSFULL
                Response.Redirect("Error.aspx");                         //REDIRECT TO ERROR.ASPX
            }
            finally
            {
                // Assign Null to all the object that are used in above class
                objCommon.Close_Con();                                  //CLOSING THE SQL CONNECTION 
                strQ = null;                                            //ASSIGN NULL TO STRINGBUILDER
                objSqlCommand = null;                                   //ASSIGN NULL TO SQLCOMMAND
            }
        }
        #endregion gvEmpTerr_RowDeleting
    }
    #endregion Add_EmployeeTerritories
}
