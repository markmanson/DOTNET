using System;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI.WebControls;
namespace Day_5_9
{
    #region Add_Customers
    /**************************************************************************************************************************************
     * CLASS                                :::                         ADD_CUSTOMERS
     * AUTHOR                               :::                         ANKIT SHARMA
     * DATE                                 :::                         23/07/2012
     * DESCRIPTION                          :::                         TO SHOW AND EDIT INTO THE CUSTOMERS TABLE    
     *************************************************************************************************************************************/
    public partial class Add_Customers : System.Web.UI.Page
    {
        Common objCommon;
        #region Page_Load
        //FUNCTION PAGE_LOAD  *********************************************************************************
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                objCommon = new Common();                                       //INITIALIZING THE OBJECT OF CLASS COMMON
                StringBuilder strBuild;                                         //DECLARING THE OBJET OF STRINGBUILDER
                SqlCommand Cmd;                                                 //DECLARING THE OBJECT OF SQLCOMMAND
                try
                {
                    objCommon.Open_Con();                                   //OPEN THE SQL CONNECTION 
                    strBuild = new StringBuilder();                             //INITIALIZATION OF STRING BUILDER
                    strBuild.Append(Constant.strSelAllCust);                    //APPENDING THE STRING BUILDER
                    Cmd = new SqlCommand(strBuild.ToString(), objCommon.Connect); //INITIALIZING THE SQL COMMAND
                    Cmd.ExecuteNonQuery();                                                                           //EXECUTE THE COMMAND
                    objCommon.Close_Con();                                          //CLOSE THE SQL CONNECTION
                    BindGridView();                                                 //CALL THE FUNCTION GRIDVIEW        
                }
                catch (Exception)
                {
                    Response.Redirect("Error.aspx");                                //REDIRECT TO ERROR.ASPX
                }
            }
        }
        #endregion Page_Load
        #region BindGridView
        //FUNCTION BINDGRIDVIEW  ************************************************************************************
        public void BindGridView() 
        {           
           StringBuilder strBuild;                                                         //DECLARATION FOR OBJECT OF STRING BUILDER
           Employees dsEmp;                                                                //DECLARATION FOR OBJECT OF DATASET
           SqlDataAdapter adpt;                                                            //DECLARATION FOR OBJECT OF SQLDATAADOPTER         
           objCommon = new Common();
           try
           {
               dsEmp = new Employees();                                                    //INITIALIZATION OF DATASET
               objCommon.Connect.Open();                                                             //OPEN THE DATABASE
               strBuild = new StringBuilder();                                             //INITIALIZATION OF STRING BUILDER
               strBuild.Append(Constant.strSel);                                           //APPENDING THE STRING BUILDER
               strBuild.Append(Constant.strAll);                                            //APPENDING THE STRING BUILDER
               strBuild.Append(Constant.strFrom);                                          //APPENDING THE STRING BUILDER
               strBuild.Append(Constant.strCustomers);                                           //APPENDING THE STRING BUILDER              
               adpt = new SqlDataAdapter(strBuild.ToString(), objCommon.Connect);                    //INITIALIZING THE SQL DATA ADAPTOR
               adpt.Fill(dsEmp, "Customers");                                              //FILL THE DATA INTO DATASET
               gvCustomer.DataSource = dsEmp;                                         //TO SEND THE CONTENT OF TABLE INTO GRIDVIEW
               gvCustomer.DataBind();                                                 //TO BIND THE DATA OF TABLE INTO GRIDVIEW             
               objCommon.Close_Con();                                                            //TO CLOSE THE DATABASE              
               if (gvCustomer.Rows.Count == 0)                                        //CHECK IF GRIDVIEW CONTAIN DATA OR NOT
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
               objCommon.Close_Con();                                                            //TO CLOSE THE DATABASE  
               strBuild = null;                                                            //DESTROYING THE OBJECT OF STRING BUILDER                                                                  
               dsEmp = null;
               adpt = null;
           }
       }
       #endregion BindGridView
        #region lnkEdit_Click
        //FUNCTION LNKEDIT_CLICK  *************************************************************************
        protected void lnkEdit_Click(object sender, EventArgs e)
        {
            int rindex = (((GridViewRow)(((LinkButton)(sender)).Parent.BindingContainer))).RowIndex;    //FINDIMG THE ROW INDEX
            //row = (GridViewRow)GridView1.Rows[rindex];
            string CustomerID = Convert.ToString(gvCustomer.DataKeys[rindex].Value.ToString());            //PARSE THE VALUE OF EMPLOYEE ID
            Session["CustomerID"] = CustomerID;                                                         //STORE THE EMPLOYEEID INTO SESSION
            Response.Redirect("EditCustomers.aspx", false);                                                      //REDIRECT TO EmpTerr.aspx
        }
        #endregion lnkEdit_Click
        #region AddDetails_Click
        //FUNCTION ADDDETAILS_CLICK  **********************************************************************
        protected void AddDetails_Click(object sender, EventArgs e)
        {
            Session["CustomerID"] = null;                                                               //ASSIGN NULL TO SESSION[EMPLOYEEID]
            Response.Redirect("EditCustomers.aspx", false);                                                       //REDIRECT TO PAGE EDIT.ASPX
        }
        #endregion AddDetails_Click
        #region lnkDelete_Click
        //FUNCTION LNKDELETE_CLICK *************************************************************************
        protected void lnkDelete_Click(object sender, EventArgs e)
        {
            SqlCommand Cmd;                                                                              //DECLARATION OF SQL COMMAND           
            StringBuilder strBuild;
            Common objCmn;
            try
            {
                objCmn = new Common();
                objCmn.Open_Con();
                int rindex = (((GridViewRow)(((LinkButton)(sender)).Parent.BindingContainer))).RowIndex; //FINDIMG THE ROW INDEX         
                string CustomerID = Convert.ToString(gvCustomer.DataKeys[rindex].Value.ToString());   //PARSE THE VALUE OF EMPLOYEE ID          
                strBuild = new StringBuilder();                                                    //INITIALIZATION OF STRING BUILDER
                strBuild.Append(Constant.strDelCust+"'"+CustomerID+"'");                                  //APPEND THE STRING BUILDER
                Cmd = new SqlCommand(strBuild.ToString(), objCmn.Connect);                                //INITIALIZATION OF COMMAND
                Cmd.ExecuteNonQuery();                                                             //EXECUTE THE COMMAND
                objCmn.Close_Con();                                                            //TO CLOSE THE DATABASE  
                BindGridView();                                                                    //CALLING THE FUNCTION BINDGRIDVIEW
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");                                                //REDIRECT TO ERROR.ASPX IF ANY EXCEPTION IS OCCURED
            }
            finally
            {
               // objCmn.Close_Con();                                                             //TO CLOSE THE DATABASE  
                Cmd = null;                                                                     //DESTROYING  THE OBJECT OF SQL COMMAND
                strBuild = null;                                                                //DESTROYING THE OBJECT OF STRING BUILDER
                objCmn = null;                                                                  //DESTROYING THE OBJECT OF COMMON
            }
        }
        #endregion lnkDelete_Click
    }
    #endregion Add_Customers
}
