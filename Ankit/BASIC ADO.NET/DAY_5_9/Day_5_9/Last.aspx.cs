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

        //// Initilization All all the Objects and Varibles that are used in Current Class

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
        public void Bind_Grid()
        {
            //conn = new SqlConnection(objCon.Connect); // Create New Sql Conn 
            try
            {
                dsEmpT = new Employees();
                dtEmpT = new DataTable();
               // objcons = new Constant_Msg();
                strQ = new StringBuilder();                             //INITIALIZE THE STRING BUILDER
                strQ.Append(Constant.strAllEmp);
                //strQ.Append(" Employees.EmployeeID, ");                     //APPANDING THE STRINGBUILDER
                //strQ.Append(" Employees.LastName, ");
                //strQ.Append(" Employees.FirstName, ");
                //strQ.Append(" Employees.Title, ");
                //strQ.Append(" Employees.TitleOfCourtesy, ");
                //strQ.Append(" Employees.BirthDate, ");
                //strQ.Append(" Employees.HireDate, ");
                //strQ.Append(" Employees.Address, ");
                //strQ.Append(" Employees.City, ");
                //strQ.Append(" Employees.Region, ");
                //strQ.Append(" Employees.PostalCode, ");
                //strQ.Append(" Employees.Country, ");
                //strQ.Append(" Employees.HomePhone, ");
                //strQ.Append(" Employees.Extension, ");
                //strQ.Append(" Employees.Notes, ");
                //strQ.Append(" Employees.ReportsTo ");
                //strQ.Append(" FROM  ");
                //strQ.Append("  Employees ");
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
                if (objCon.Connect.State == System.Data.ConnectionState.Open)      //if SqlConnection is not null then set object to null
                { 
                    objCon.Connect.Close();                                       //CONNECTION CLOSING
                }                
                Response.Redirect("Error.aspx");                         // Navigate Error.aspx page  
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
                    strQ.Append(" Select ");
                    strQ.Append(" Distinct territoryDescription ");
                    strQ.Append(" from ");
                    strQ.Append(" Territories t , ");
                    strQ.Append(" EmployeeTerritories ET ");
                    strQ.Append(" where ");
                    strQ.Append(" t.territoryId = ET.territoryId ");
                    strQ.Append(" and ");
                    strQ.Append(" ET.employeeid ");
                    strQ.Append(" = ");
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
                catch (Exception ex)
                {
                    if (objCon.Connect.State == System.Data.ConnectionState.Open)//if SqlConnection is not null then set object to null
                    { objCon.Connect.Close(); }//}connection close
                    // Response.Write(ex.Message);
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

                strQ.Append(" Delete ");
                strQ.Append(" E ");
                strQ.Append(" From ");
                strQ.Append(" Employees E ");
                strQ.Append(" Where ");
                strQ.Append(" E.EmployeeId ");
                strQ.Append(" in ");
                strQ.Append(" (" + strEmpIds + ") ");
                strQ.Append(" ; ");

                strQ.Append(" Delete ");
                strQ.Append(" EmployeeTerritories  ");
                strQ.Append(" From ");
                strQ.Append(" EmployeeTerritories ET ");
                strQ.Append(" Where ");
                strQ.Append(" ET.EmployeeId ");
                strQ.Append(" in ");
                strQ.Append(" (" + strEmpIds + ") ");

                objSqlCommand.CommandType = CommandType.Text;
                objSqlCommand.CommandText = strQ.ToString();       //query put in SqlCommand
                objSqlCommand.Connection = objCon.Connect;
                if (objCon.Connect.State == System.Data.ConnectionState.Closed)
                    objCon.Connect.Open();
                int i = objSqlCommand.ExecuteNonQuery();
                if (i > 0)
                {
                    lblError.Text = "Record Deleted";
                    lblError.Visible = true;

                }
                transaction.Commit();
                if (objCon.Connect.State == System.Data.ConnectionState.Open)//if SqlConnection is not null 
                { objCon.Connect.Close(); }


            }
            catch (Exception ex)
            {
                if (objCon.Connect.State == System.Data.ConnectionState.Open)//if SqlConnection is not null then set object to null
                { objCon.Connect.Close(); }//}connection close
                transaction.Rollback();//if Trasection is not Successful then return back
                Response.Redirect("Error.aspx");

            }


            finally
            {
                if (objCon.Connect.State == System.Data.ConnectionState.Open)//if SqlConnection is not null then set object to null
                { objCon.Connect.Close(); }

                objSqlCommand = null;
                strQ = null;

            }
        }
        #endregion deleteMulti
        #region Button1_Click
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
                    lblError1.Text = "Please select at least one record for Delete ";
                    lblError1.Visible = true;                    
                }
                else
                {                  
                    deleteMulti(myArr);
                    Bind_Grid();
                }
            }
            catch (Exception ex)
            {
                if (objCon.Connect.State == System.Data.ConnectionState.Open)//if SqlConnection is not null then set object to null
                { objCon.Connect.Close(); }//}connection close
                // Response.Write(ex.Message);
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
        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            GridViewRow row;       // Intilize local Variable     
            int EmployeeId;
            int rindex = (((GridViewRow)(((LinkButton)(sender)).Parent.BindingContainer))).RowIndex;

            row = (GridViewRow)gvEmpT.Rows[rindex];
            EmployeeId = Int32.Parse(gvEmpT.DataKeys[rindex].Value.ToString());

            Session["EmployeeId111"] = EmployeeId;
            //Response.Write(EmployeeId);
            Response.Redirect("EditTerritories.aspx", false);

        }
        #endregion LinkButton1_Click
        #region lbtnAdd_Click
        protected void lbtnAdd_Click(object sender, EventArgs e)
        {
            Session.Remove("EmployeeId111");
            Response.Redirect("EditTerritories.aspx", false);
        }
        #endregion lbtnAdd_Click
    }
    #endregion Last
}
