using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI.WebControls;

namespace Day_5_9
{
    #region EditTerritories
    /**************************************************************************************************************************************
    * CLASS                                :::                         EDITTERRITORIES
    * AUTHOR                               :::                         ANKIT SHARMA
    * DATE                                 :::                         23/07/2012
    * DESCRIPTION                          :::                         TO MAKE A PAGE TO EDIT INTO THE TERRITORIES TABLE    
    *************************************************************************************************************************************/
    public partial class EditTerritories : System.Web.UI.Page
    {
        DataTable dtTerr;                                                        //DECLARATION FOR OBJECT OF DATA TABLE
        SqlDataAdapter Adpt;                                                     //DECLARATION FOR OBJECT OF SQL DATAADAPTOR
        StringBuilder strBuildA;                                                 //DECLARATION FOR OBJECT OF STRING BUILDER
        ListBox MyLstBx;                                                         //DECLARATION FOR OBJECT OF LISTBOX
        Common objCommon;                                                        //DECLARATION OF OBJECT OF CLASS COMMON
        SqlCommand objSqlCommand;                                                //DECLARATION OF OBJECT OF SQL COMMAND
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
                Common objCom = new Common();                                                //INITIALIZATION OF OBJECT OF CLASS COMMON               
                StringBuilder strBuild;                                                  //DECLARATION FOR OBJECT OF STRING BUILDER          
                //SqlDataAdapter Adpt;                                                     //DECLARATION FOR OBJECT OF SQL DATAADAPTOR
                DataSet dsEdit;                                                          //DECLARATION FOR OBJECT OF DATASET
                btnAdd.Text = "Update";                                                  //CHANGE THE TEXT OF BUTTON BTNADD
                try
                {
                    dsEdit = new DataSet();                                              //INITIALIZING THE OBJECT OF DATASET               
                    objCom.Open_Con();                                                //OPEN THE DATABASE
                    strBuild = new StringBuilder();                                      //INITIALIZATION OF STRING BUILDER
                    strBuild.Append(Constant.strSelEmp);
                    if (Session["EmployeeID"] != null)                                   //IF SESSION HAS SOME VALUES
                    {
                        strBuild.Append(Constant.strWhrEmpId + Session["EmployeeID"].ToString());//APPENDING THE STRING BUILDER                    
                    }
                    Adpt = new SqlDataAdapter(strBuild.ToString(), objCom.Connect);                    //INITIALIZATOIN OF ADAPTER
                    Adpt.Fill(dsEdit);                                                          //FILLING THE ADAPTOR INTO DATASET
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
                    objCom.Close_Con();                                                      //CLOSING THE SQL CONNECTION
                }
                catch (Exception ex)
                {
                    Response.Redirect("Error.aspx");                                             //REDIRECT TO ERROR.ASPX IF ANY EXCEPTION IS OCCURED
                }
                finally
                {
                    objCom = null;                                                  //DESTROYING THE OBJECT OF  SQL CONNECTION
                    strBuild = null;                                                 //DESTROYING THE OBJECT OF STRING BUILDER          
                    Adpt = null;                                                     //DESTROYING THE OBJECT OF SQL DATAADAPTOR
                    dsEdit = null;                                                   //DESTROYING THE OBJECT OF DATA SET                       
                }
                List();
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
                List();
            }
        }
        #endregion Show_Data
        #region List
        public void List()
        {
            //// Intilization of Local Variable And Objects that are used in Current class
            Common objCom = new Common();                       
            //SqlDataAdapter Adpt;
            listBoxValue();
            strBuildA = new StringBuilder();
            dtTerr = new DataTable();
           // objcon = new Constant_Msg();
            try
            {
                //MyLstBx = new ListBox();
                objCom.Connect.Open();
                strBuildA.Append(Constant.strSelDist);                            //APPENDING THE STRING BUILDER
                Adpt = new SqlDataAdapter(strBuildA.ToString(), objCom.Connect);  //INITIALIZE THE DATA ADAPTER
                Adpt.Fill(dtTerr);                                                // FILL DATA ADOPTER
                if (dtTerr.Rows.Count > 0)
                {
                    lstDes.DataSource = dtTerr;                 
                    lstDes.DataTextField = "TerritoryDescription";                //ASSIGN TERRITORYDESCRIPTION TO LISTBOX
                    lstDes.DataBind();                                            //BIND DATA TO LIST BOX
                    if (Session["EmployeeID"] != null)                            //CHECK IF SESSION IS NOT NULL
                    {
                        for (int i = 0; i < lstDes.Items.Count; i++)
                        {
                            for (int j = 0; j < MyLstBx.Items.Count; j++)
                            {
                                if (lstDes.Items[i].Equals(MyLstBx.Items[j]))
                                {
                                    lstDes.Items[i].Selected = true;                //TO SHOW THE SELECTED ITEM IN LIST BOX
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                objCom.Close_Con();                                 //CLOSE THE SQL CONNECTION
                Response.Redirect("Error.aspx");                    //REDIRECT TO ERROR.ASPX
            }
            finally
            {
                // ASSIGN NULL TO ALL OBJECTS USED ABOVE
                //dsEmpT = null;
                Adpt = null;
                dtTerr = null;
                strBuildA = null;
                objCom = null;
               // MyLstBx = null;
            }
        }
        #endregion List
        #region listBoxValue
        public void listBoxValue()
        {
            objCommon = new Common();                           //INITIALIZATION OF OBJECT OF CLASS COMMON
            dtTerr = new DataTable();                           //INITIALIZATION OF OBJECT OF DATATABLE
            strBuildA = new StringBuilder();                    //INITIALIZATION OF OBJECT OF STRINGBUILDER
            if (Session["EmployeeID"] != null)                      //CHECK IF SESSION IS NOT NULL
            {
                string ids = Session["EmployeeID"].ToString();      //ASSIGN SESSION["EMPLOYEEID"] TO STRING IDS
                try
                {
                    MyLstBx = new ListBox();                        //INITIALIZATION OF OBJECT OF LISTBOX                                   
                    strBuildA.Append(Constant.strTerDes);           //APPENDING THE STRING BUILDER         
                    strBuildA.Append(Session["EmployeeID"]);        //APPENDING THE STRING BUILDER                    
                    Adpt = new SqlDataAdapter(strBuildA.ToString(), objCommon.Connect);   //INITIALIZE THE OBJECT OF DATA ADAPTER
                    Adpt.Fill(dtTerr);                              //FILLING THE DATA ADOPTER
                    if (dtTerr.Rows.Count > 0)
                    {
                        MyLstBx.DataSource = dtTerr;            
                        MyLstBx.DataTextField = "territoryDescription";
                        MyLstBx.DataBind();                         //BIND THE DATA TO LIST BOX

                    }
                }
                catch (Exception)                                   //IF EXCEPTION OCCURED
                {
                    objCommon.Close_Con();                          //CLOSE THE SQL CONNECTION
                    Response.Redirect("Error.aspx");                //REDIRECT TO ERROR.ASPX  
                }
                finally
                {
                    //ASSIGN NULL TO OBJECTS USED ABOVE
                    Adpt = null;
                    dtTerr = null;
                    strBuildA = null;
                    objCommon = null;
                }
            }
        }
        #endregion listBoxValue
        #region btnAdd_Click
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            objCommon = new Common();                                   //DECLARING THE OBJECT OF CLASS COMMON                          
            objSqlCommand = new SqlCommand();                           //initialize SqlCommand
            objCommon.Open_Con();                                    //Connection open            
            objSqlCommand.Connection = objCommon.Connect;                //Define connection
            //ASSIGN TXTBOX.TEXT TO STRINGS *********************************************************************
            string LastName = txtLastName.Text.Trim();
            string FirstName = txtFirstName.Text.Trim();
            string Title = ddlTitle.SelectedValue.ToString();
            string TitleOfCourtesy = ddlTtlcrtsy.SelectedValue.ToString();
            string BirthDate =txtBirthDate.Text;
            string HireDate = txtHireDate.Text;
            //DateTime BirthDate = DateTime.Parse(txtBirthDate.Text);
            //DateTime HireDate = DateTime.Parse(txtHireDate.Text);
            string Address = txtAddress.Text.Trim();
            string City = txtCity.Text.Trim();
            string Region = txtRegion.Text.Trim();
            string PostalCode = txtPostalCode.Text.Trim();
            string Country = txtCountry.Text.Trim();
            string HomePhone = txtHomePhone.Text.Trim();
            string Extension = txtExtension.Text.Trim();
            string Notes = txtNotes.Text.Trim();
            string ReportsTO = txtReportsTo.Text.Trim();
            ArrayList myarr = new ArrayList();                              //INITIALIZE THE ARRAYLIST
             for (int i = 0; i < lstDes.Items.Count; i++)
                {
                    if (lstDes.Items[i].Selected == true)
                    {
                        strBuildA = new StringBuilder();                    //INITIALIZE THE OBJECT OF STRING BUILDER
                        dtTerr = new DataTable();                           //INITIALIZING THE OBJECT OF STRING BUILDER
                        strBuildA.Append(Constant.strWhrDes + lstDes.Items[i].Text.ToString() + "' ");
                        Adpt = new SqlDataAdapter(strBuildA.ToString(),objCommon.Connect);//initializing the data adaptor
                        Adpt.Fill(dtTerr);                                  //FILL DATA ADAPTOR
                        if (dtTerr.Rows.Count > 0)
                        {
                            myarr.Add(dtTerr.Rows[0]["TerritoryID"].ToString());    //ADD TO ARRAYLIST
                        }
                    }
                }
            SqlTransaction transaction;                                     //DECLARING THE OBJECT OF SQL TRANSACTION
            if (Session["EmployeeID"] == null)                              //IF SESSION IS NULL
            {               
                dtTerr = new DataTable();                                   //INITIALIZING THE OBJECT OF DATATABLE
                strBuildA = new StringBuilder();                            //INITIALIZING THE OBJECT OF STRINGBUILDER
                strBuildA.Append(Constant.strMax);                          //APPENDING THE STRING BUILDER
                objSqlCommand.CommandText = strBuildA.ToString();           //ASSIGN STRING BUILDER TO SQL COMMANDTEXT
                objSqlCommand.Connection = objCommon.Connect;
                objSqlCommand.CommandType = CommandType.Text;
                int EmpId = Convert .ToInt32( objSqlCommand.ExecuteScalar());
                strBuildA = null;                                           //DESTROY THE OBJECT OF STRBUILD 
                transaction = objCommon.Connect.BeginTransaction();         //BEGIN THE TRANSACTION
                try
                {
                    objSqlCommand.Transaction = transaction;                
                    strBuildA = new StringBuilder();                        //INITIALIZING THE OBJECT OF STRING BUILDER
                    strBuildA.Append(Constant.strspcl);                     //APPENDING THE STRINGBUILDER
                    strBuildA.Append(EmpId + "', ");
                    strBuildA.Append("'"+LastName + "', ");                  //APPENDING THE STRINGBUILDER
                    strBuildA.Append(" '" + FirstName + "', ");             //APPENDING THE STRINGBUILDER
                    strBuildA.Append(" '" + Title + "', ");                 //APPENDING THE STRINGBUILDER
                    strBuildA.Append(" '" + TitleOfCourtesy + "', ");       //APPENDING THE STRINGBUILDER
                    strBuildA.Append(" '" + BirthDate + "', ");             //APPENDING THE STRINGBUILDER
                    strBuildA.Append(" '" + HireDate + "',");               //APPENDING THE STRINGBUILDER
                    strBuildA.Append(" '" + Address + "',");                //APPENDING THE STRINGBUILDER
                    strBuildA.Append(" '" + City + "', ");                  //APPENDING THE STRINGBUILDER
                    strBuildA.Append(" '" + Region + "',");                 //APPENDING THE STRINGBUILDER
                    strBuildA.Append(" '" + PostalCode + "',");             //APPENDING THE STRINGBUILDER
                    strBuildA.Append(" '" + Country + "', ");               //APPENDING THE STRINGBUILDER
                    strBuildA.Append(" '" + HomePhone + "', ");             //APPENDING THE STRINGBUILDER
                    strBuildA.Append(" '" + Extension + "', ");             //APPENDING THE STRINGBUILDER
                    // strBuildA.Append(" @Photo, ");                       //APPENDING THE STRINGBUILDER
                    strBuildA.Append(" '" + Notes + "', ");                 //APPENDING THE STRINGBUILDER
                    strBuildA.Append(" '" + ReportsTO + "') ");             //APPENDING THE STRINGBUILDER
                    strBuildA.Append(" ; ");                                //APPENDING THE STRINGBUILDER
                    string s = strBuildA.ToString();                        //ASSIGN THE VALUE OF STRING BUILER TO STRING
                    strBuildA = null;                                       //ASSIGN NULL TO THE OBJECT OF STRING BUILDER
                    strBuildA = new StringBuilder();                        //INITIALIZATION OF OBJECT OF STRING BUILDER
                    for (int i = 0; i < myarr.Count; i++)
                    {
                        strBuildA.Append(Constant.strInsrtET);              //APPENDING THE STRINGBUILDER   
                        strBuildA.Append(" ('" + EmpId + "', ");            //APPENDING THE STRINGBUILDER
                        strBuildA.Append(" '" + myarr[i] + "') ");          //APPENDING THE STRINGBUILDER
                        strBuildA.Append(" ; ");                            //APPENDING THE STRINGBUILDER
                    }
                    string v = strBuildA.ToString();                        //ASSIGN THE VALUE OF STRING BUILER TO STRING               
                    objSqlCommand.CommandText = s + v;
                    int rowsAffected = objSqlCommand.ExecuteNonQuery();
                    if (rowsAffected > 1)
                    {
                        Response.Write(rowsAffected + " Rows Addated ");//Success notification
                    }
                    else
                    {
                        Response.Redirect("Error.aspx"); //Error notification
                    }
                    //object i = 1;
                    Session["Rows_T"] = rowsAffected;
                    transaction.Commit();
                    if (Session["Emp_Multi_DML"] != null)
                    {
                        Response.Redirect("Emp_MultipleDelect_DML.aspx", false);
                    }
                    else
                    {
                        Response.Redirect("EmployeeTerritories.aspx", false);
                    }
                    objCommon.Close_Con();                                  //CLOSING THE SQL CONNECTION
                }
                catch (Exception ex)                       
                {
                    objCommon.Close_Con();                          //CLOSIE THE SQL CONNECTION 
                    //transaction.Rollback();                         //if Trasection is not Successful then return back
                    Response.Redirect("Error.aspx");                //REDIRECT TO ERROR.ASPX
                }
            }
            else
            {
                btnAdd.Text = "Update";                             //CHANGE THE TEXT OF BUTTON ADD
                int EmployeeID;
                string ids = Session["EmployeeID"].ToString();      //ASSIGN SESSION TO STRING
                strBuildA = new StringBuilder();                    //INITIALIZATION OF OBJECT OF STRINGBUILDER
                strBuildA.Append(Constant.strdelterr);              //APPENDING THE STRBUILDER  
                strBuildA.Append(ids);                              //APPENDING THE STRING BUILDER
                objSqlCommand.CommandText = strBuildA.ToString();  // Set Sql Query string to Sql Command             
                objSqlCommand.Connection = objCommon.Connect;        // Set Connecton String  Sql Command
                objSqlCommand.ExecuteNonQuery();                    //EXECUTE THE SQL COMMAND
                strBuildA = null;                                   //ASSIGN NULL TO STRING BUILDER
                transaction = objCommon.Connect.BeginTransaction(); //BEGIN TRANSACTION 
                try
                {
                    EmployeeID = int.Parse(ids);                        
                    objSqlCommand = new SqlCommand();                         //initialize SqlCommand
                    strBuildA = new StringBuilder();
                    //APPENDING THE STRING BUILDER *********************************************************************
                    strBuildA.Append(" UPDATE Employees SET ");
                    strBuildA.Append(" LastName= '" + LastName + "' ,");
                    strBuildA.Append(" FirstName='" + FirstName + "', ");
                    strBuildA.Append(" Title='" + Title + "' ,");
                    strBuildA.Append(" TitleOfCourtesy='" + TitleOfCourtesy + "' ,");
                    strBuildA.Append(" BirthDate='" + BirthDate + "', ");
                    strBuildA.Append(" HireDate='" + HireDate + "', ");
                    strBuildA.Append(" Address='" + Address + "' ,");
                    strBuildA.Append(" City='" + City + "', ");
                    strBuildA.Append(" Region='" + Region + "' ,");
                    strBuildA.Append(" PostalCode='" + PostalCode + "' ,");
                    strBuildA.Append(" Country='" + Country + "', ");
                    strBuildA.Append(" HomePhone='" + HomePhone + "', ");
                    strBuildA.Append(" Extension='" + Extension + "', ");
                    strBuildA.Append(" Notes='" + Notes + "', ");
                    strBuildA.Append(" ReportsTo='" + ReportsTO + "' ");
                    strBuildA.Append(" WHERE  ");
                    strBuildA.Append(" (EmployeeID='" + EmployeeID + "' ) ");
                    //objSqlCommand.CommandText = strBuildA.ToString(); 
                    string s = strBuildA.ToString();
                    strBuildA = null;
                    strBuildA = new StringBuilder();
                    for (int i = 0; i < myarr.Count; i++)
                    {
                        strBuildA.Append(Constant.strInsrtET);
                        strBuildA.Append(" ('" + EmployeeID + "', ");
                        strBuildA.Append(" '" + myarr[i] + "') ");
                        strBuildA.Append(" ; ");
                    }
                    string v = strBuildA.ToString();
                    objSqlCommand.CommandText = s + v;
                    objSqlCommand.Connection = objCommon.Connect;
                    objSqlCommand.Transaction = transaction;
                    objSqlCommand.ExecuteNonQuery();
                    Session["Rows_U_T"] = 1;
                    transaction.Commit();
                    Response.Redirect("EmployeeTerritories.aspx", false);
                    //Response.Write("Updated Successfully");
                    objCommon.Close_Con();                                  //CLOSING THE SQL CONNECTION
                }
                catch 
                {
                    objCommon.Close_Con();                                  //CLOSING THWE SQL CONNECYTION
                    transaction.Rollback();//if Trasection is not Successful then return back
                    Response.Redirect("Error.aspx");  
                }
                finally
                {
                        objCommon.Close_Con();                              //CLOSING THE SQL CONNECTION
                        objSqlCommand = null;
                        transaction = null;
                        //objCom = null;
                        myarr = null;                    
                }                
            }
        }
        #endregion btnAdd_Click
    }
    #endregion EditTerritories
}
