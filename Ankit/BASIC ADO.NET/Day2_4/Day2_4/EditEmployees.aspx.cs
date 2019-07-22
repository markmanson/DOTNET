using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI.WebControls;
namespace Day2_4 
{
    #region EditEmployees
    /*************************************************************************************************************
      NAME                               ::::                    EDITEMPLOYEES
      AUTHOR                             ::::                    ANKIT
      DATE                               ::::                    17-07-2012
      DESCRIPTION                        ::::                    ERROR PAGE
     ************************************************************************************************************/
    public partial class EditEmployees : System.Web.UI.Page
    {
        Common objCommon=new Common();                                                         //INITIALIZATION OF OBJECT OF CLASS COMMON
        #region Page_Load
        //FUNCTION PAGE_LOAD ********************************************************************************************************
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack )
            {
                BindGridView();                                                                         //CALL THE FUNCTION BINDGRIDVIEW
            }
        }
        #endregion Page_Load
        #region LnkEdit_Click
        //FUNCTION LNKEDIT_CLICK *******************************************************************************************************
        protected void LnkEdit_Click(object sender, EventArgs e)
        {
            int rindex = (((GridViewRow)(((LinkButton)(sender)).Parent.BindingContainer))).RowIndex;    //FINDIMG THE ROW INDEX
            //row = (GridViewRow)GridView1.Rows[rindex];
            int EmployeeID = Int32.Parse(gvEditEmployees.DataKeys[rindex].Value.ToString());            //PARSE THE VALUE OF EMPLOYEE ID
            Session["EmployeeID"] = EmployeeID;                                                         //STORE THE EMPLOYEEID INTO SESSION
            Response.Redirect("Edit.aspx", false);                                                      //REDIRECT TO EmpTerr.aspx
        }
        #endregion LnkEdit_Click
        #region btnAdd_Click
        //FUNCTION BTNADD_CLICK ***********************************************************************************
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Session["EmployeeID"] = null;                                                               //ASSIGN NULL TO SESSION[EMPLOYEEID]
            Response.Redirect("Edit.aspx",false);                                                       //REDIRECT TO PAGE EDIT.ASPX
        }
        #endregion btnAdd_Click
        #region LnkDelete_Click
        protected void LnkDelete_Click(object sender, EventArgs e)
       {
           SqlCommand Cmd;                                                                              //DECLARATION OF SQL COMMAND           
           StringBuilder strBuild;
           try
           {
               objCommon.Connect.Open();
               int rindex = (((GridViewRow)(((LinkButton)(sender)).Parent.BindingContainer))).RowIndex; //FINDIMG THE ROW INDEX         
               int EmployeeID = Int32.Parse(gvEditEmployees.DataKeys[rindex].Value.ToString());   //PARSE THE VALUE OF EMPLOYEE ID          
               strBuild = new StringBuilder();                                                    //INITIALIZATION OF STRING BUILDER
               strBuild.Append(Constant.strDelEmp + EmployeeID);                                  //APPEND THE STRING BUILDER
               Cmd = new SqlCommand(strBuild.ToString(), objCommon.Connect);                                //INITIALIZATION OF COMMAND
               Cmd.ExecuteNonQuery();                                                             //EXECUTE THE COMMAND
               if (objCommon.Connect.State == System.Data.ConnectionState.Open)
               {
                   objCommon.Connect.Close();                                                                   //CLOSE THE CONNECTION
               }
               BindGridView();                                                                    //CALLING THE FUNCTION BINDGRIDVIEW
           }
           catch (Exception)
           {
               Response.Redirect("Error.aspx");
           }
           finally
           {
               if (objCommon.Connect.State == System.Data.ConnectionState.Open)
               {
                   objCommon.Connect.Close();                                                                   //CLOSE THE CONNECTION
               }
               Cmd = null;
               strBuild = null;
           }
       }
        #endregion LnkDelete_Click
        #region BindGridView
        //FUNCTION BINDGRIDVIEW ***************************************************************************************************************
       public void BindGridView() 
       {           
           StringBuilder strBuild;                                                         //DECLARATION FOR OBJECT OF STRING BUILDER
           Employees dsEmp;                                                                //DECLARATION FOR OBJECT OF DATASET
           SqlDataAdapter adpt;                                                            //DECLARATION FOR OBJECT OF SQLDATAADOPTER         
           try
           {
               dsEmp = new Employees();                                                    //INITIALIZATION OF DATASET
               objCommon.Connect.Open();                                                             //OPEN THE DATABASE
               strBuild = new StringBuilder();                                             //INITIALIZATION OF STRING BUILDER
               strBuild.Append(Constant.strSel);                                           //APPENDING THE STRING BUILDER
               strBuild.Append(Constant.strAllEmpSpcl);                                    //APPENDING THE STRING BUILDER
               strBuild.Append(Constant.strFrom);                                          //APPENDING THE STRING BUILDER
               strBuild.Append(Constant.strEmp);                                           //APPENDING THE STRING BUILDER              
               adpt = new SqlDataAdapter(strBuild.ToString(), objCommon.Connect);                    //INITIALIZING THE SQL DATA ADAPTOR
               adpt.Fill(dsEmp, "Employees");                                              //FILL THE DATA INTO DATASET
               gvEditEmployees.DataSource = dsEmp;                                         //TO SEND THE CONTENT OF TABLE INTO GRIDVIEW
               gvEditEmployees.DataBind();                                                 //TO BIND THE DATA OF TABLE INTO GRIDVIEW
               if (objCommon.Connect.State == System.Data.ConnectionState.Open)
               {
                   objCommon.Connect.Close();                                                            //TO CLOSE THE DATABASE
               }
               if (gvEditEmployees.Rows.Count == 0)                                        //CHECK IF GRIDVIEW CONTAIN DATA OR NOT
               {
                   LblError.Visible = true;                                                //SHOW LABLE WITH ERROR MESSEGE
                   LblError.Text = Constant.strSorry;
               }
           }
           catch (Exception)    
           {
               Response.Redirect("Error.aspx");                                            //REDIRECT TO ERROR.ASPX IF ANY ERROR IS OCCURED
           }
           finally
           {
               if (objCommon.Connect.State == System.Data.ConnectionState.Open)
               {
                   objCommon.Connect.Close();                                                                   //CLOSE THE CONNECTION
               }
               strBuild = null;                                                            //DESTROYING THE OBJECT OF STRING BUILDER                                                                  
               dsEmp = null;
               adpt = null;
           }
       }
       #endregion BindGridView
    }      
        #endregion EditEmployees
}

