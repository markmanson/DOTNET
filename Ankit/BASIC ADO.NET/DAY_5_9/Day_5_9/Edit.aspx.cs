using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
namespace Day_5_9
{
    #region Edit
    /**************************************************************************************************************************************
     * CLASS                                :::                         EDIT
     * AUTHOR                               :::                         ANKIT SHARMA
     * DATE                                 :::                         23/07/2012
     * DESCRIPTION                          :::                         TO MAKE A PAGE TO EDIT INTO THE EMPLOYEES TABLE    
     *************************************************************************************************************************************/
    public partial class Edit : System.Web.UI.Page
    {       
        Common objCommon;                                                         //DECLARATION OF OBJECT OF CLASS COMMON
        #region Page_Load
        //FUNCTION PAGE_LOAD  *************************************************************************************************************
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Show_Data();                                          //CALL THE FUNCTION SHOWDATA
            }
        }
        #endregion Page_Load
        #region Show_Data
        //FUNCTION SHOW_DATA  ****************************************************************************************************************
        public void Show_Data()
        {
            if (Session["EmployeeID"] != null)
            {
                objCommon = new Common();                                                //INITIALIZATION OF OBJECT OF CLASS COMMON               
                StringBuilder strBuild;                                                  //DECLARATION FOR OBJECT OF STRING BUILDER          
                SqlDataAdapter adpt;                                                     //DECLARATION FOR OBJECT OF SQL DATAADAPTOR
                DataSet dsEdit;                                                          //DECLARATION FOR OBJECT OF DATASET
                btnAdd.Text = "Update";                                                  //CHANGE THE TEXT OF BUTTON BTNADD
                try
                {
                    dsEdit = new DataSet();                                              //INITIALIZING THE OBJECT OF DATASET               
                    objCommon.Connect.Open();                                            //OPEN THE DATABASE
                    strBuild = new StringBuilder();                                      //INITIALIZATION OF STRING BUILDER
                    strBuild.Append("select * from Employees ");
                    if (Session["EmployeeID"] != null)                                   //IF SESSION HAS SOME VALUES
                    {
                        strBuild.Append(Constant.strWhrEmpId + Session["EmployeeID"].ToString());//APPENDING THE STRING BUILDER                    
                    }
                    adpt = new SqlDataAdapter(strBuild.ToString(),objCommon.Connect);                    //INITIALIZATOIN OF ADAPTER
                    adpt.Fill(dsEdit);                                                          //FILLING THE ADAPTOR INTO DATASET
                    txtEmployeeID.Text = dsEdit.Tables[0].Rows[0]["EmployeeID"].ToString();     //ASSIGN THE EMPLOYEEID TO ITS REGARD FIELD
                    txtFirstName.Text = dsEdit.Tables[0].Rows[0]["FirstName"].ToString();       //ASSIGN THE FIRSTNAME TO ITS REGARD FIELD
                    txtLastName.Text = dsEdit.Tables[0].Rows[0]["LastName"].ToString();         //ASSIGN THE LASTNAME TO ITS REGARD FIELD
                    ddlTitle.Text = dsEdit.Tables[0].Rows[0]["Title"].ToString();               //ASSIGN THE TITLE TO ITS REGARD FIELD
                    ddlTtlcrtsy.Text = dsEdit.Tables[0].Rows[0]["TitleOfCourtesy"].ToString();  //ASSIGN THE TITLEOFCOURTESY TO ITS REGARD FIELD
                    txtBirthDate.Text = dsEdit.Tables[0].Rows[0]["BirthDate"].ToString();       //ASSIGN THE BIRTHDATE TO ITS REGARD FIELD
                    txtHireDate.Text = dsEdit.Tables[0].Rows[0]["HireDate"].ToString();         //ASSIGN THE HIREDATE TO ITS REGARD FIELD
                    txtAddress.Text = dsEdit.Tables[0].Rows[0]["Address"].ToString();           //ASSIGN THE ADDRESS TO ITS REGARD FIELD
                    txtCity.Text = dsEdit.Tables[0].Rows[0]["City"].ToString();                 //ASSIGN THE CITY TO ITS REGARD FIELD           
                    txtRegion.Text = dsEdit.Tables[0].Rows[0]["Region"].ToString();             //ASSIGN THE REGION TO ITS REGARD FIELD
                    txtPostalCode.Text = dsEdit.Tables[0].Rows[0]["PostalCode"].ToString();     //ASSIGN THE POSTALCODE TO ITS REGARD FIELD
                    txtCountry.Text = dsEdit.Tables[0].Rows[0]["Country"].ToString();           //ASSIGN THE COUNTRY TO ITS REGARD FIELD
                    txtHomePhone.Text = dsEdit.Tables[0].Rows[0]["HomePhone"].ToString();       //ASSIGN THE HOMEPHONE TO ITS REGARD FIELD
                    txtExtension.Text = dsEdit.Tables[0].Rows[0]["Extension"].ToString();       //ASSIGN THE EXTENSION TO ITS REGARD FIELD
                    txtNotes.Text = dsEdit.Tables[0].Rows[0]["Notes"].ToString();               //ASSIGN THE NOTES TO ITS REGARD FIELD
                    txtReportsTo.Text = dsEdit.Tables[0].Rows[0]["ReportsTo"].ToString();       //ASSIGN THE REPORTSTO TO ITS REGARD FIELD 
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
                lblEmployeeID.Visible = false;                                              //MAKING LABEL VISIBLE FALSE 
                txtEmployeeID.Visible = false;                                              //MAKING TEXTBOX VISIBLE FALSE
                txtFirstName.Text = null;                                                   //ASSIGN NULL TO FIRSTNAME 
                txtLastName.Text = null;                                                    //ASSIGN NULL TO LASTNAME 
                ddlTitle.Text = null;                                                       //ASSIGN NULL TO TITLE  
                ddlTtlcrtsy.Text = null;                                                    //ASSIGN NULL TO TITLEOFCOURTESY 
                txtBirthDate.Text = null;                                                   //ASSIGN NULL TO BIRTHDATE 
                txtHireDate.Text = null;                                                    //ASSIGN NULL TO HIREDATE 
                txtAddress.Text = null;                                                     //ASSIGN NULL TO ADDRESS 
                txtCity.Text = null;                                                        //ASSIGN NULL TO CITY        
                txtRegion.Text = null;                                                      //ASSIGN NULL TO REGION 
                txtPostalCode.Text = null;                                                  //ASSIGN NULL TO POSTALCODE 
                txtCountry.Text = null;                                                     //ASSIGN NULL TO COUNTRY 
                txtHomePhone.Text = null;                                                   //ASSIGN NULL TO HOMEPHONE 
                txtExtension.Text = null;                                                   //ASSIGN NULL TO EXTENSION 
                txtNotes.Text = null;                                                       //ASSIGN NULL TO NOTES  
                txtReportsTo.Text = null;                                                   //ASSIGN NULL TO REPORTSTO       

            }
        }
        #endregion Show_Data
        #region btnAdd_Click
        //FUCTION BTNADD_CLICK ***************************************************************************************************************
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            if (Session["EmployeeID"] != null)
            {
                SqlTransaction Trans=null;                              //DECLARING THE OBJECT OF SQLTRANSACTION
                objCommon = new Common();                               //INITIALIZATION OF THE OBJECT OF CLASS COMMON
                StringBuilder strBuild1;                                //DECLARATION OF THE OBJECT OF STRINGBUILDER
                SqlCommand Cmd;                                         //DECLARATION OF SQL COMMAND
                try
                {                   
                    objCommon.Open_Con();                                                                       //OPEN THE SQL CONNECTION
                    Trans = objCommon.Connect.BeginTransaction();
                    strBuild1 = new StringBuilder();                                                      //INITIALIZING THE OBJECT OF STRINGBUILDER
                    //APPEND THE STRING BUILDER  *************************************************************************************************
                    strBuild1.Append("update employees set FirstName='" + txtFirstName.Text + "',LastName='" + txtLastName.Text + "',Title='" + ddlTitle.Text + "',TitleOfCourtesy='" + ddlTtlcrtsy.Text + "',BirthDate='" + txtBirthDate.Text + "',HireDate='" + txtHireDate.Text + "',Address='" + txtAddress.Text + "',City='" + txtCity.Text + "',Region='" + txtRegion.Text + "',PostalCode='" + txtPostalCode.Text + "',Country='" + txtCountry.Text + "',HomePhone='" + txtHomePhone.Text + "',Extension='" + txtExtension.Text + "',Notes='" + txtNotes.Text + "',ReportsTo='" + txtReportsTo.Text + "'");
                    strBuild1.Append(" where EmployeeID=" + Session["EmployeeID"]);             //APPENDING THE STRING BUILDER FOR WHERE CLAUSE
                    Cmd = new SqlCommand(strBuild1.ToString(), objCommon.Connect,Trans );                        //INITIALIZING THE SQL COMMAND
                    Cmd.ExecuteNonQuery();                                                      //EXECUTE THE COMMAND                                   
                    Trans.Commit();
                    lblUpdate.Visible = true;                                                   //MAKING LABEL VISIBLE
                    lblUpdate.Text = "Data updated successfully ...";                           //CHANGE THE TEXT OF LABEL     
                }
                catch (Exception )
                {
                    Trans.Rollback();
                    Response.Redirect("Error.aspx");                                            //REDIRECT TO ERROR.ASPX IF ANY EXCEPTION IS OCCURED
                }
                finally
                {
                    if (objCommon.Connect.State == System.Data.ConnectionState.Open)
                    {
                       objCommon.Connect.Close();                                                            //CLOSE THE CONNECTION
                    }
                  //  Session["EmployeeID"] = null;                                       //ASSIGN NULL TO SESSION[EMPLOYEEID]                    
                    strBuild1 = null;                                                   //ASSIGN NULL TO STRINGBUILDER
                    Cmd = null;                                                         //ASSIGN NULL TO SQL COMMAND
                    objCommon = null;
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
                    strBuild1.Append("insert into Employees (FirstName,LastName,Title,TitleOfCourtesy,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone,Extension,Notes,ReportsTo) values ('" + txtFirstName.Text + "','" + txtLastName.Text + "','" + ddlTitle.Text + "','" + ddlTtlcrtsy.Text + "','" + txtBirthDate.Text + "','" + txtHireDate.Text + "','" + txtAddress.Text + "','" + txtCity.Text + "','" + txtRegion.Text + "','" + txtPostalCode.Text + "','" + txtCountry.Text + "','" + txtHomePhone.Text + "','" + txtExtension.Text + "','"+ txtNotes.Text + "'," + txtReportsTo.Text + ")");
                  //  strBuild1.Append(" where EmployeeID=" + Session["EmployeeID"]);
                    Cmd = new SqlCommand(strBuild1.ToString(), objCmn.Connect);                //INITIALIZATION OF THE SQL COMMAND
                    Cmd.ExecuteNonQuery();                                              //EXECUTE THE SQL COMMAND
                    if (objCmn.Connect.State == System.Data.ConnectionState.Open)
                    {
                        objCmn.Connect.Close();                                                    //CLOSE THE CONNECTION
                    }
                    lblUpdate.Visible = true;                                           //MAKING LABEL VISIBLE
                    lblUpdate.Text = "Data inserted successfully...";                   //CHANGE THE TEXT OF LABEL                   
                    txtFirstName.Text = null;                                                   //ASSIGN NULL TO FIRSTNAME 
                    txtLastName.Text = null;                                                    //ASSIGN NULL TO LASTNAME 
                    ddlTitle.Text = null;                                                       //ASSIGN NULL TO TITLE  
                    ddlTtlcrtsy.Text = null;                                                    //ASSIGN NULL TO TITLEOFCOURTESY 
                    txtBirthDate.Text = null;                                                   //ASSIGN NULL TO BIRTHDATE 
                    txtHireDate.Text = null;                                                    //ASSIGN NULL TO HIREDATE 
                    txtAddress.Text = null;                                                     //ASSIGN NULL TO ADDRESS 
                    txtCity.Text = null;                                                        //ASSIGN NULL TO CITY        
                    txtRegion.Text = null;                                                      //ASSIGN NULL TO REGION 
                    txtPostalCode.Text = null;                                                  //ASSIGN NULL TO POSTALCODE 
                    txtCountry.Text = null;                                                     //ASSIGN NULL TO COUNTRY 
                    txtHomePhone.Text = null;                                                   //ASSIGN NULL TO HOMEPHONE 
                    txtExtension.Text = null;                                                   //ASSIGN NULL TO EXTENSION 
                    txtNotes.Text = null;                                                       //ASSIGN NULL TO NOTES  
                    txtReportsTo.Text = null;                                                   //ASSIGN NULL TO REPORTSTO       
                }
                catch (Exception)
                {
                    Response.Redirect("Error.aspx");                                            //REDIRECT TO ERROR.ASPX
                }
                finally
                {
                    objCommon.Close_Con();                                                     //CLOSING THE SQL CONNECTION
                    strBuild1 = null;                                                          //ASSIGN NULL TO STRING BUILDER
                    Cmd = null;                                                                //ASSIGN NULL TO SQL COMMAND
                    Session["EmployeeID"]=null;
                }
            }
        }
        #endregion btnAdd_Click
        //#region btnReset_Click
        ////FUNCTION BTNRESET_CLICK ********************************************************************************************************
        //protected void btnReset_Click(object sender, EventArgs e)
        //{
        //   Show_Data();                                       //CALL THE FUNCTION SHOW_DATA
        //}
        //#endregion btnReset_Click
        //#region btnReset_Click
        ////FUNCTION BTNBACK_CLICK  *********************************************************************************************************
        //protected void btnBack_Click(object sender, EventArgs e)
        //{
        //    Server.Transfer("Default.aspx", true);
        //    //Response.Redirect("Default.aspx",true);                          //REDIRECT TO DEFAULT.ASPX
        //}
        //#endregion btnReset_Click
    }
    #endregion Edit
}

