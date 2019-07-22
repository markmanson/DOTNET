using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day_5_9
{
    #region ChkEmpTerr
    /**************************************************************************************************************************************
     * CLASS                                :::                         ChkEmpTerr
     * AUTHOR                               :::                         ANKIT SHARMA
     * DATE                                 :::                         23/07/2012
     * DESCRIPTION                          :::                         TO DELETE THE RECORDS FROM EMPLOYEETERRITORIES BY CHECKBOXES    
     *************************************************************************************************************************************/
    public partial class ChkEmpTerr : System.Web.UI.Page
    {       
        SqlCommand objSqlCommand;                                   //DECLARATION OF OBJECT OF SQL COMMAND
        SqlTransaction transaction;                                 //DECLARATION OF OBJECT OF SQL TRANSACTION
        SqlConnection conn;                                         ////DECLARATION OF OBJECT OF SQLCONNECTION 
        Employees dsEmpT;                                           //DECLARATION OF OBJECT OF DATATABLE
        DataTable dtEmpT;                                           //DECLARATION OF OBJECT OF DATATABLE
        SqlDataAdapter daEmpT;                                      //DECLARATION OF OBJECT OF SQL DATA ADAPTOR
        StringBuilder strQ;                                         //DECLARATION OF OBJECT OF STRING BUILDER
        string strCmd;                                              ////DECLARATION OF STRING
       // Constant_Msg objcons;
        Common objCon = new Common();                               //INITIALIZATION OF OBJECT OF CLASS COMMON       
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                Bind_Grid();                                        //CALL THE FUNCTION BINDGRID
            }
        }
        #region Bind_Grid
        //FUNCTION BIND_GRID *******************************************************************************************************
        public void Bind_Grid()
        {            
            try
            {
                dsEmpT = new Employees();                               //INITIALIZING THE OBJECT OF DATASET EMPLOYEES
                dtEmpT = new DataTable();                               //INITIALIZING THE OBJECT OF DATATABLE
                strQ = new StringBuilder();                             //INITIALIZING THE OBJECT OF STRING BUILDER
                strQ.Append(Constant.strAllEmp);                        //APPENDING THE STRINGBUILDER
               // strQ.Append(Constant.strEmp);                           //APPENDING THE STRINGBUILDER
                strCmd = strQ.ToString();                               //ASSIGN THE VALUE OF STRINGBUILDER TO SQL COMMAND
                daEmpT = new SqlDataAdapter(strCmd, objCon.Connect);                            //INITIALIZING THE OBJECT OF DATA ADAPTOR  
                daEmpT.Fill(dtEmpT);                                                            //FILL THE DATA ADAPTOR
                if (dtEmpT.Rows.Count > 0)                              //IF THERE IS NO ROW IN GRIDVIW
                {
                    gvChk.DataSource = dtEmpT;                          //ASSIGNING THE DATATABLE TO GRIDVIEW
                    gvChk.DataBind();                                   //BINDING THE DATA IN GRID VIEW
                }
                else                                                    //IF NO ROW IN GRIDVIEW
                {
                    lblError1.Text = Constant.strSorry;                 //DISPLAY THE MESSEGE DATA NOT FOUND
                    lblError1.Visible = true;                           //MAKE LABLE VISIBLE
                }
            }
            catch (Exception )                                            //IF ANY EXCEPTION OCCURED
            {
                objCon.Close_Con();                                       //CLOSING THE CONNECTION
                Response.Redirect("Error.aspx");                          //REDIRECT T ERROR.ASPX                          
            }
            finally
            {
                //DSTROYING  THE OBJECTS WHICH ARE USED 
                dsEmpT = null;
                dtEmpT = null;
                daEmpT = null;
                strCmd = null;
                objCon = null;                
            }
        }
        #endregion Bind_Grid
        #region chkItem_CheckedChanged
        //FUNCTION CHKITEM_CHECKEDCHANGED  ********************************************************************************
        protected void chkItem_CheckedChanged(object sender, EventArgs e)
        {         
            CheckBox chkHe = (CheckBox)gvChk.HeaderRow.FindControl("chkHeader");
            foreach (GridViewRow Row in gvChk.Rows)
            {
                if (chkHe.Checked == true)                                  //CHECK IF CHECKBOX IS CHECKED OR NOT
                {
                    chkHe.Checked = false;                                  //CHANGE IT TO UNCHECKED
                }
            }
        }
        #endregion chkItem_CheckedChanged
        #region chkHeader_CheckedChanged
        //FUNCTION CHKHEADER_CHECKCHANGED **********************************************************************
        protected void chkHeader_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkHe = ((CheckBox)gvChk.HeaderRow.FindControl("chkHeader"));
            if (chkHe.Checked==true)
            {
                foreach (GridViewRow row in gvChk.Rows)
                {                  
                    CheckBox chkIT = ((CheckBox)row.FindControl("chkItem")); //FINDING THE CHECK ITEM IN CHECKBOX IN EACH ROW OF GERIDVIEW
                    chkIT.Checked = true;          
                }
            }
            else
            {
                foreach (GridViewRow row in gvChk.Rows)
                {
                    CheckBox chkIT = (CheckBox)row.FindControl("chkItem");
                    chkIT.Checked = false;
                }
            }
        }
        #endregion chkHeader_CheckedChanged
        protected void gvEmpT_DataBound(object sender, EventArgs e)
        {

        }

        protected void gvEmpT_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //conn = new SqlConnection(objCon.strConn); // Create New Sql Conn  
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                try
                {
                    ListBox myListBox = (ListBox)e.Row.FindControl("ListBox1");
                    //objcons = new Constant_Msg();
                    dtEmpT = new DataTable();                                           //INITIALIZING THE OBJECT OF DATATABLE
                    strQ = new StringBuilder();                                         //INITIALIZING THE OBJECT OF STRINGBUILDER
                    string EmployeeID = gvChk.DataKeys[e.Row.RowIndex].Value.ToString();//ASSIGN  DATA KEY TO EMPLOYEEID
                    strQ.Append(Constant.strDistTerr);                                  //APPENDING THE STRINGBUILDER
                    strQ.Append(" '" + EmployeeID + "' ");                              //APPENDING THE STRINGBUILDER
                    strCmd = strQ.ToString();                                           //ASSIGN STRINGBUILDER TO SQL COMMAND
                    daEmpT = new SqlDataAdapter(strCmd, conn);                          //INITILIZING THE DATA ADAPTOR
                    daEmpT.Fill(dtEmpT);                                                //FILLING THE ADAPTOR
                    if (dtEmpT.Rows.Count > 0)                                          //IF THERE IS SOME ROWS IN GRIDVIEW
                    {
                        myListBox.DataSource = dtEmpT;
                        myListBox.DataBind();                                           //BIND THE DATA TO LISTBOX
                    }
                }
                catch (Exception )
                {
                    objCon.Close_Con();                                                 //CLOSING THE SQL CONNECTION
                    Response.Redirect("Error.aspx");                                    //REDIRECT TO ERROR.ASPX 
                }
                finally
                {
                    objCon.Close_Con();                                                 //CLOSING THE SQL CONNECTION
                    strQ = null;                                                        //DESTROYING THE OBJECT OF STRING BUILDER
                }
            }
        }
        #region deleteMulti
        //FUNCTION DELETEMULTI  ******************************************************************************************
        private void deleteMulti(ArrayList myARR)
        {
            string EmpIds = "";                                 //DECLARING AN EMPTY STRING
            string strEmpIds;                                   //DECLARING A STRING
            try
            {
                objSqlCommand = new SqlCommand();               //INITIALIZING THE SQL COMMAND
                strQ = new StringBuilder();                     //INITIALIZING THE STRING BUILDER
                SqlTransaction transaction;                     //DECLARING THE SQL TRANSACTION
                conn.Open();                                    //OPEN THE SQL CONNECTION                                                          
                transaction = conn.BeginTransaction();          //INITIALIZING THE TRANSACTION 
                objSqlCommand.Connection = conn;                
                objSqlCommand.Transaction = transaction;        //INITIALIZATION OF SQL TRANSACTION 
                foreach (string id in myARR  )                  // TAKING VAULE OF ID INTO AN ARRAYLIST
                {
                    EmpIds += id.ToString() + ",";              
                }
                strEmpIds = EmpIds.Substring(0, EmpIds.LastIndexOf(","));       // REMOVING COMMA FROM ID
                strQ.Append(Constant.strDltEmp);                //APPENDING THE STRNIG BUILDER
                strQ.Append(" (" + strEmpIds + ")  ;");         //APPENDING THE STRING BUILDER
                strQ.Append(Constant.strDltEmpTerr);            //APPENDING THE STRING BUILDER            
                strQ.Append(" (" + strEmpIds + ") ");           //APPENDING THE STRING BUILDER
                objSqlCommand.CommandType = CommandType.Text;   
                objSqlCommand.CommandText = strQ.ToString();       //ASSIGN THE STRING BUILDER TO SQL COMMAND
                objSqlCommand.Connection = conn;                   //ASSIGN THE CONNECTION TO SQLCOMMAND.CONNECTION 
                objCon.Close_Con();                                //CLOSING THE CONNECTION 
                objSqlCommand.ExecuteNonQuery();                   //EXECUTING THE SQLCOMMAND
                transaction.Commit();                              //COMMITING THE TRANSACTION 
                objCon.Close_Con();                                //CLOSING THE CONNECTION      
                //lblError.Text = "Record Deleted";
                //lblError.Visible = true;
            }
            catch (Exception)
            {
                    objCon.Close_Con();                             //CLOSING THE SQL CONNECTION
                    transaction.Rollback();                         //ROLLBACK THE TRANSACTION IF EXCEPTION OCCURED
                    Response.Redirect("Error.aspx");                //REDIRECT TO ERROR.ASPX                
            }
            finally
            {
                objCon.Close_Con();                                 //CLOSING THE SQL CONNECTION               
                objSqlCommand = null;                               //ASSIGN NULL TO SQL COMMAND
                strQ = null;                                        //ASSIGN NULL TO STRING BUILDER
                
            }
        }
        #endregion deleteMulti
        #region Button1_Click
        //FUNCTION BUTTON1_CLICK  *************************************************************************************************
        protected void Button1_Click(object sender, EventArgs e)
        {
            CheckBox chkD;                                      //DECLARING THE OBJECT OF CHECKBOX
            ArrayList myArr;                                    //DECLARING THE OBJECT OF ARRAYLIST
            string strEmpId;                                    //DECLARING A STRING TYPE VARIABLES
            try
            {
                myArr = new ArrayList();                        //INITIALIZATION OF ARRAYLIST
                strEmpId = "";
                for (int i = 0;i < gvChk.Rows.Count ;i++)
                {
                    chkD = (CheckBox)gvChk.Rows[i].Cells[0].FindControl("chkItem");
                    if (chkD != null)
                    {
                        if (chkD.Checked)
                        {
                            strEmpId = gvChk.Rows[i].Cells[1].Text;     //ASSIGN DATAKEY TO STRING 
                            myArr.Add(strEmpId);                        //ADD TO ARRAYLIST
                        }
                    }                   
                 }
                if (myArr.Count == 0)
                {
                    lblError1.Text = "Please select at least one record for Delete "; //IF USER DOES NOT SELECT ANY CHECK BOX
                    lblError1.Visible = true;                       //MAKE LABEL VISIBLE
                }
                else
                {
                    deleteMulti(myArr);                             //CALLING THE FUNCTION DELETEMULTI
                    Bind_Grid();                                    //CALL THE FUNCTION BIND_GRID
                }
            }
            catch (Exception ex)
            {
                objCon.Close_Con();                                         //CLOSING THE SQL CONNECTION
                Response.Redirect("Error.aspx");                            //REDIRECT TO ERROR.ASPX             
            }
        }
        #endregion Button1_Click
    }
    #endregion ChkEmpTerr
}

