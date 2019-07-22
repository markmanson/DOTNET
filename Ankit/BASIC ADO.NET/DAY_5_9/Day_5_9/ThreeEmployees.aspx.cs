using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace Day_5_9
{
    #region Last
    public partial class Last : System.Web.UI.Page
    {       
        SqlCommand objSqlCommand;                   //DECLARING SQL COMMAND
        //SqlConnection conn;                         //DECLARING SQL CONNECTION
        Employees dsEmpT;                           //DECLARING OBJECT OF DATASET
        DataTable dtEmpT;                           //DECLARING OBJECT OF DATATABLE
        SqlDataAdapter daEmpT;                      //DECLARING OBJECT OF SQL DATA ADOPTER
        StringBuilder strQ; string strCmd;          //DECLARATION OF STRINGBUILDER
        Common objCon = new Common();
        #region Page_Load 
        //function page_Load *****************************
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                Bind_Grid();
            }           
            Session["Emp_Multi_DML"] = 1;
        }
        #endregion Page_Load
        #region Bind_Grid
        //FUNCTION BIND_GRIDVIEW  ************************************************************************************
        public void Bind_Grid()
        {           
            try
            {
                dsEmpT = new Employees();
                dtEmpT = new DataTable();             
                strQ = new StringBuilder();                             //INITIALIZE THE STRING BUILDER
                strQ.Append(Constant.strAllEmp);               
                strCmd = strQ.ToString();                               //ASSIGN THE VALUE OF STRING BUILDER TO SQL COMMAND
                daEmpT = new SqlDataAdapter(strCmd, objCon.Connect);    // INITILIZE THE DATA ADAPTER   
                daEmpT.Fill(dtEmpT);                                    // FILLING THE DATA ADAPTER
                if (dtEmpT.Rows.Count > 0)                              //CHECK IF THERE IS SOME ROWS IN GRIDVIEW
                {
                    gvEmpT.DataSource = dtEmpT;                         //ASSIGN DATATABLE TO GRIDVIEW
                    gvEmpT.DataBind();                                  //BINDING THE GRID VIEW

                }
                else                                                     //IF GRIDVIEW DOES NOT HAVE ANY RO
                {
                    lblError.Text =Constant.strSorry;
                    lblError.Visible = true;
                }
            }
            catch (Exception ex)                                            // IF ANY EXCEPTION IS OCCURED
            {
                objCon.Close_Con();                                         //CLOSING THE CONNECTION 
                Response.Redirect("Error.aspx");                            //REDIRECT TO ERROR.ASPX  
            }
            finally
            {
                // DESRTOYING THE OBJECTS WHICH ARE INITIALIZED 
                dsEmpT = null;
                dtEmpT = null;
                daEmpT = null;
                strCmd = null;
                objCon = null;                
            }
        }
        #endregion Bind_Grid
        #region chkItem_CheckedChanged
        //FUNCTION CHKITEM_CHECKEDCHANGED  ********************************************************************************************
        protected void chkItem_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkHe = (CheckBox)gvEmpT.HeaderRow.FindControl("chkHeader");
            foreach (GridViewRow Row in gvEmpT.Rows)
            {
                if (chkHe.Checked == true)
                {
                    chkHe.Checked = false;
                }
            }
        }
        #endregion chkItem_CheckedChanged
        #region chkHeader_CheckedChanged
        //FUNCTION CHKHEADRE_CHECKEDCHANGED  ********************************************************************************************
        protected void chkHeader_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkHe = ((CheckBox)gvEmpT.HeaderRow.FindControl("chkHeader")); // Create new check box
            // Given Condition Check
            if (chkHe.Checked == true)
            {
                foreach (GridViewRow row in gvEmpT.Rows)
                {
                    CheckBox chkIT = ((CheckBox)row.FindControl("chkItem"));
                    chkIT.Checked = true;
                }
            }
            else
            {
                foreach (GridViewRow row in gvEmpT.Rows)
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
        #region gvEmpT_RowDataBound
        //FUNCTION GVEMPT_ROWDATABOUND  **************************************************************************************
        protected void gvEmpT_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            //conn = new SqlConnection(objCon.strConn); // Create New Sql Conn  
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                try
                {
                    ListBox myListBox = (ListBox)e.Row.FindControl("ListBox1");
                    dtEmpT = new DataTable();
                    strQ = new StringBuilder();
                    string EmployeeID = gvEmpT.DataKeys[e.Row.RowIndex].Value.ToString();
                    strQ.Append(Constant.strDistTerr);                    
                    strQ.Append(" '" + EmployeeID + "' ");
                    strCmd = strQ.ToString();
                    daEmpT = new SqlDataAdapter(strCmd, objCon.Connect);   // Create Data  Adapeter
                    daEmpT.Fill(dtEmpT);
                    if (dtEmpT.Rows.Count > 0)
                    {
                        myListBox.DataSource = dtEmpT;
                        myListBox.DataBind();

                    }
                }
                catch (Exception )
                {
                    objCon.Close_Con();                                 //CLOSING THE SQL CONNECTION                  
                    Response.Redirect("Error.aspx");                         // Navigate Error.aspx page  
                }
                finally
                {
                    strQ = null;
                }
            }
        }
        #endregion gvEmpT_RowDataBound
        #region deleteMulti
        //FUNCTION DELETEMULTI  **********************************************************************************
        private void deleteMulti(ArrayList myARR)
        {
            string EmpIds = "";
            string strEmpIds;
            //conn = new SqlConnection(objCon.strConn); // Create New Sql Conn  
            objSqlCommand = new SqlCommand();
            strQ = new StringBuilder();
            SqlTransaction transaction;
            objCon.Connect.Open();  //Connection open                                                         
            transaction = objCon.Connect.BeginTransaction();
            objSqlCommand.Connection = objCon.Connect;
            objSqlCommand.Transaction = transaction;                    //Define trasection   
            try
            {
                foreach (string id in myARR)// Taking the value 
                {
                    EmpIds += id.ToString() + ",";
                }
                strEmpIds = EmpIds.Substring(0, EmpIds.LastIndexOf(",")); // Remover the ',' 
                strQ.Append(Constant.strDltEmp);                
                strQ.Append(" (" + strEmpIds + ") ");
                strQ.Append(" ; ");
                strQ.Append(Constant.strDltEmpTerr);               
                strQ.Append(" (" + strEmpIds + ") ");
                objSqlCommand.CommandType = CommandType.Text;
                objSqlCommand.CommandText = strQ.ToString();       //query put in SqlCommand
                objSqlCommand.Connection = objCon.Connect;
                if (objCon.Connect.State == System.Data.ConnectionState.Closed)
                    objCon.Open_Con();                              //OPENING THE SQL CONNECTION
                int i = objSqlCommand.ExecuteNonQuery();
                if (i > 0)
                {
                    lblError.Text = "Record Deleted";
                    lblError.Visible = true;
                }
                transaction.Commit();
                objCon.Close_Con();                                             //CLOSING THE SQL CONNECTION
            }
            catch (Exception )
            {
                objCon.Close_Con();                                                 //CLOSING THE SQL CONNECTION
                Response.Redirect("Error.aspx");
            }
            finally
            {
                objCon.Close_Con();                                                 //CLOSING THE SQL CONNECTION
                objSqlCommand = null;
                strQ = null;
            }
        }
        #endregion deleteMulti
        #region Button1_Click
        //FUNCTION BUTTON1_CLICK  ***************************************************************************
        protected void Button1_Click(object sender, EventArgs e)
        {
            CheckBox chkD;
            ArrayList myArr;
            string strEmpId;
            try
            {
                myArr = new ArrayList();
                strEmpId = "";
                for (int i = 0; i < gvEmpT.Rows.Count; i++)
                {
                    chkD = (CheckBox)gvEmpT.Rows[i].Cells[0].FindControl("chkItem");
                    if (chkD != null)
                    {
                        if (chkD.Checked)
                        {
                            strEmpId = gvEmpT.Rows[i].Cells[2].Text;

                            myArr.Add(strEmpId);
                        }
                    }
                }
                if (myArr.Count == 0)
                {
                    lblError1.Text = Constant.strPlDel;
                    lblError1.Visible = true;                    
                }
                else
                {                  
                    deleteMulti(myArr);
                    Bind_Grid();
                }
            }
            catch (Exception)
            {
                objCon.Close_Con();                                     //CLOSING THE SQL CONNECTION               
                Response.Redirect("Error.aspx");                        // Navigate Error.aspx page  
            }
            finally
            {
                myArr = null;
                chkD = null;
            }
        }
        #endregion Button1_Click
        #region LinkButton1_Click
        //FUNCTION LINKBUTTON1_CLICK ************************************************************************
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            GridViewRow row;       // Intilize local Variable     
            int EmployeeId;
            int rindex = (((GridViewRow)(((LinkButton)(sender)).Parent.BindingContainer))).RowIndex;
            row = (GridViewRow)gvEmpT.Rows[rindex];
            EmployeeId = Int32.Parse(gvEmpT.DataKeys[rindex].Value.ToString());
            Session["EmployeeID"] = EmployeeId;           
            Response.Redirect("EditTerritories.aspx", false);
        }
        #endregion LinkButton1_Click
        #region lbtnAdd_Click
        //FUNCTION LBTNADD_CLICK  ***************************************************************************
        protected void lbtnAdd_Click(object sender, EventArgs e)
        {
            Session.Remove("EmployeeID");
            Response.Redirect("EditTerritories.aspx", false);
        }
        #endregion lbtnAdd_Click
    }
    #endregion Last
}
