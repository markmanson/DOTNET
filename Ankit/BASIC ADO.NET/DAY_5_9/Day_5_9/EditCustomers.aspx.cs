using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
namespace Day_5_9
{
    #region EditCustomers
    /**************************************************************************************************************************************
    * CLASS                                :::                         EDITCUSTOMERS
    * AUTHOR                               :::                         ANKIT SHARMA
    * DATE                                 :::                         23/07/2012
    * DESCRIPTION                          :::                         TO MAKE A PAGE TO EDIT INTO THE CUSTOMERS TABLE    
    *************************************************************************************************************************************/
    public partial class EditCustomers : System.Web.UI.Page
    {
        #region Page_Load
        //FUNCTION PAGE_LOAD   ***********************************************************
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Show_Data();                                          //CALL THE FUNCTION SHOWDATA
            }
        }
        #endregion Page_Load
        #region btnAdd_Click
        //FUNCTION BTN_ADD_CLICK * *******************************************************************
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (Session["CustomerID"] != null)
            {
                SqlTransaction Trans = null;                                    //DECLARATION OF SQL TRANSACTION
                Common objCommon ;          
                StringBuilder strBuild1;
                SqlCommand Cmd;
                try
                {
                    objCommon = new Common();
                    objCommon.Open_Con();                                                                       //OPEN THE SQL CONNECTION
                    Trans = objCommon.Connect.BeginTransaction();
                    strBuild1 = new StringBuilder();                                                      //INITIALIZING THE OBJECT OF STRINGBUILDER
                    //APPEND THE STRING BUILDER  *************************************************************************************************
                    strBuild1.Append("update Customers set CompanyName='" + txtCompanyName.Text + "',ContactName='" + txtContactName.Text + "',ContactTitle='" + txtContactTitle.Text + "',Address='" + txtAddress.Text + "',City='" + txtCity.Text + "',Region='" + txtRegion.Text + "',PostalCode='" + txtPostalCode.Text + "',Country='" + txtCountry.Text + "',Phone='" + txtPhone.Text + "',Fax='" + txtFax.Text +  "'");
                    strBuild1.Append(" where CustomerID= '" + Session["CustomerID"]+"'");             //APPENDING THE STRING BUILDER FOR WHERE CLAUSE
                    Cmd = new SqlCommand(strBuild1.ToString(), objCommon.Connect, Trans);                        //INITIALIZING THE SQL COMMAND
                    Cmd.ExecuteNonQuery();                                                      //EXECUTE THE COMMAND                                       

                    Trans.Commit();
                    lblUpdate.Visible = true;                                                   //MAKING LABEL VISIBLE
                    lblUpdate.Text =Constant.strUpdtSccs;                           //CHANGE THE TEXT OF LABEL   
                   
                }
                catch (Exception)
                {
                    Trans.Rollback();
                    Response.Redirect("Error.aspx");                                            //REDIRECT TO ERROR.ASPX IF ANY EXCEPTION IS OCCURED
                }
                finally
                {
                   // objCommon.Close_Con();                                    
                    strBuild1 = null;                                                   //ASSIGN NULL TO STRINGBUILDER
                    Cmd = null;                                                         //ASSIGN NULL TO SQL COMMAND
                    objCommon = null;
                    Response.Redirect("Add_Customers.aspx");
                }
            }
            else
            {
                StringBuilder strBuild1;                                                //DECLARATION FOR OBJECT OF STRINGBUILDER
                SqlCommand Cmd;                                                         //DECLARATION OF SQL COMMAND
                try
                {
                    Common objCmn = new Common();
                    objCmn.Connect.Open();                                                     //OPEN THE SQL CONNECTION
                    strBuild1 = new StringBuilder();                                    //INITIALIZATION OF STRING BUILDER
                    //APPENDING THE STRING BUILDER ***********************************************************************************
                    strBuild1.Append(Constant.strInsrt + txtCustomerID.Text + "','" + txtCompanyName.Text + "','" + txtContactName.Text + "','" + txtContactTitle.Text + "','" + txtAddress.Text + "','" + txtCity.Text + "','" + txtRegion.Text + "'," + txtPostalCode.Text + ",'" + txtCountry.Text + "'," + txtPhone.Text + "," + txtFax.Text + ")");
                    //  strBuild1.Append(" where EmployeeID=" + Session["EmployeeID"]);
                    Cmd = new SqlCommand(strBuild1.ToString(), objCmn.Connect);                //INITIALIZATION OF THE SQL COMMAND
                    Cmd.ExecuteNonQuery();                                              //EXECUTE THE SQL COMMAND
                    objCmn.Close_Con();                                                     //CLOSE THE SQL CONNECTION
                    lblUpdate.Visible = true;                                                   //MAKING LABEL VISIBLE
                    lblUpdate.Text = Constant.strInsrtSccs;                           //CHANGE THE TEXT OF LABEL                   
                    txtCompanyName.Text = null;                                                   //ASSIGN NULL TO FIRSTNAME 
                    txtContactName.Text = null;                                                    //ASSIGN NULL TO LASTNAME 
                    txtContactTitle.Text = null;                                                       //ASSIGN NULL TO TITLE  
                    txtAddress.Text = null;                                                    //ASSIGN NULL TO TITLEOFCOURTESY 
                    txtCity.Text = null;                                                   //ASSIGN NULL TO BIRTHDATE 
                    txtRegion.Text = null;                                                    //ASSIGN NULL TO HIREDATE 
                    txtPostalCode.Text = null;                                                     //ASSIGN NULL TO ADDRESS 
                    txtCountry.Text = null;                                                        //ASSIGN NULL TO CITY        
                    txtPhone.Text = null;                                                      //ASSIGN NULL TO REGION 
                    txtFax.Text = null;                                                  //ASSIGN NULL TO POSTALCODE                        
                }
                catch (Exception)
                {
                    Response.Redirect("Error.aspx");                                            //REDIRECT TO ERROR.ASPX
                }
                finally
                {
                    //if (objCommon.Connect.State == System.Data.ConnectionState.Open)
                    //{
                    //    objCommon.Connect.Close();                                           //TO CLOSE THE DATABASE
                    //}
                    strBuild1 = null;                                                          //ASSIGN NULL TO STRING BUILDER
                    Cmd = null;                                                                //ASSIGN NULL TO SQL COMMAND
                    Session["EmployeeID"] = null;
                }
            }
        }
        #endregion btnAdd_Click
        #region Show_Data
        //FUNCTION SHOW_DATA  ****************************************************************************************************************
        public void Show_Data()
        {
            if (Session["CustomerID"] != null)
            {
                Common objCommon;
                StringBuilder strBuild;                                                  //DECLARATION FOR OBJECT OF STRING BUILDER          
                SqlDataAdapter adpt;                                                     //DECLARATION FOR OBJECT OF SQL DATAADAPTOR
                DataSet dsEdit;                                                          //DECLARATION FOR OBJECT OF DATASET
                btnAdd.Text = "Update";                                                  //CHANGE THE TEXT OF BUTTON BTNADD
                try
                {
                    objCommon = new Common();                                                //INITIALIZATION OF OBJECT OF CLASS COMMON               
                    dsEdit = new DataSet();                                              //INITIALIZING THE OBJECT OF DATASET               
                    objCommon.Connect.Open();                                            //OPEN THE DATABASE
                    strBuild = new StringBuilder();                                      //INITIALIZATION OF STRING BUILDER
                    strBuild.Append(Constant.strSelAllCust);
                    if (Session["CustomerID"] != null)                                   //IF SESSION HAS SOME VALUES
                    {
                        strBuild.Append(Constant.strWhrCustId +"'" +Session["CustomerID"].ToString()+"'");//APPENDING THE STRING BUILDER                    
                    }
                    adpt = new SqlDataAdapter(strBuild.ToString(), objCommon.Connect);                    //INITIALIZATOIN OF ADAPTER
                    adpt.Fill(dsEdit);                                                          //FILLING THE ADAPTOR INTO DATASET
                    txtCustomerID.Text = dsEdit.Tables[0].Rows[0]["CustomerID"].ToString();     //ASSIGN THE EMPLOYEEID TO ITS REGARD FIELD
                    txtCompanyName.Text = dsEdit.Tables[0].Rows[0]["CompanyName"].ToString();       //ASSIGN THE FIRSTNAME TO ITS REGARD FIELD
                    txtContactName.Text = dsEdit.Tables[0].Rows[0]["ContactName"].ToString();         //ASSIGN THE LASTNAME TO ITS REGARD FIELD
                    txtContactTitle.Text = dsEdit.Tables[0].Rows[0]["ContactTitle"].ToString();               //ASSIGN THE TITLE TO ITS REGARD FIELD
                    txtAddress.Text = dsEdit.Tables[0].Rows[0]["Address"].ToString();  //ASSIGN THE TITLEOFCOURTESY TO ITS REGARD FIELD
                    txtCity.Text = dsEdit.Tables[0].Rows[0]["City"].ToString();       //ASSIGN THE BIRTHDATE TO ITS REGARD FIELD
                    txtRegion.Text = dsEdit.Tables[0].Rows[0]["Region"].ToString();         //ASSIGN THE HIREDATE TO ITS REGARD FIELD
                    txtPostalCode.Text = dsEdit.Tables[0].Rows[0]["PostalCode"].ToString();           //ASSIGN THE ADDRESS TO ITS REGARD FIELD
                    txtCountry.Text = dsEdit.Tables[0].Rows[0]["Country"].ToString();                 //ASSIGN THE CITY TO ITS REGARD FIELD           
                    txtPhone.Text = dsEdit.Tables[0].Rows[0]["Phone"].ToString();             //ASSIGN THE REGION TO ITS REGARD FIELD
                    txtFax.Text = dsEdit.Tables[0].Rows[0]["Fax"].ToString();     //ASSIGN THE POSTALCODE TO ITS REGARD FIELD                   
                    if (objCommon.Connect.State == System.Data.ConnectionState.Open)
                    {
                        objCommon.Connect.Close();                                                            //TO CLOSE THE DATABASE                
                    }
                }
                catch (Exception)
                {
                    Response.Redirect("Error.aspx");                                             //REDIRECT TO ERROR.ASPX IF ANY EXCEPTION IS OCCURED
                }
                finally
                {
                    objCommon = null;                                                  //DESTROYING THE OBJECT OF  SQL CONNECTION
                    strBuild = null;                                                 //DESTROYING THE OBJECT OF STRING BUILDER          
                    adpt = null;                                                     //DESTROYING THE OBJECT OF SQL DATAADAPTOR
                    dsEdit = null;                                                   //DESTROYING THE OBJECT OF DATA SET                       
                }
            }
            else
            {
                //lblCustomerId.Visible = false;                                              //MAKING LABEL VISIBLE FALSE 
                //txtCustomerID.Visible = false;                                              //MAKING TEXTBOX VISIBLE FALSE
                txtCompanyName.Text = null;                                                   //ASSIGN NULL TO FIRSTNAME 
                txtContactName.Text = null;                                                    //ASSIGN NULL TO LASTNAME 
                txtContactTitle.Text = null;                                                       //ASSIGN NULL TO TITLE  
                txtAddress.Text = null;                                                     //ASSIGN NULL TO ADDRESS 
                txtCity.Text = null;                                                        //ASSIGN NULL TO CITY        
                txtRegion.Text = null;                                                      //ASSIGN NULL TO REGION 
                txtPostalCode.Text = null;                                                  //ASSIGN NULL TO POSTALCODE 
                txtCountry.Text = null;                                                     //ASSIGN NULL TO COUNTRY 
                txtFax.Text = null;
                txtPhone.Text = null;
            }
        }
        #endregion Show_Data
        #region btnReset_Click
        //FUNCTION BTNBACK_CLICK  *********************************************************************************************************
        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("Add_Customers.aspx");                          //REDIRECT TO DEFAULT.ASPX
        }
        #endregion btnReset_Click
    }
    #endregion EditCustomers
}
