using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Day_2_4
{
    #region Add_Emp
    // NAME              :-  Add_Emp
    // AUTHOR NAME       :-  SHIKHA MALIK
    // DECRIPTION        :-  Class for add employee information
    // CREATED DATE      :-  28/07/2012
    public partial class Add_Emp : System.Web.UI.Page
    {
        Common connObj;
        protected void Page_Load(object sender, EventArgs e)
        {

           if (!IsPostBack)
            {
                Show_Data();                                          //CALL THE FUNCTION SHOWDATA
            }
        }
        //SqlDataAdapter adapDA; DataSetEmp ds; StringBuilder strBl; string strcons;  // declaration of object
        public void Show_Data()
        {
            if (Session[Constant.strEmpid] != null)
            {
                connObj = new Common();                                           //INITIALIZATION OF OBJECT OF CLASS COMMON               
                StringBuilder strBl;                                                  //DECLARATION FOR OBJECT OF STRING BUILDER          
                SqlDataAdapter adapDA;                                                     //DECLARATION FOR OBJECT OF SQL DATAADAPTOR
                DataSet dsEdit;                                                          //DECLARATION FOR OBJECT OF DATASET
                try
                {
                    dsEdit = new DataSet();                                              //INITIALIZING THE OBJECT OF DATASET               
                    connObj.OpenConnection();                                           //OPEN THE DATABASE
                    strBl = new StringBuilder();                                      //INITIALIZATION OF STRING BUILDER
                    // strBl.Append("select * from Employees ");
                    if (Session[Constant.strEmpid] != null)                                   //IF SESSION HAS SOME VALUES
                    {
                        string stre = Session[Constant.strEmpid].ToString();
                        int id = int.Parse(stre);
                        strBl.Append(Constant.strQryEmp);//APPENDING THE STRING BUILDER                    
                        strBl.Append(id);

                    }
                    adapDA = new SqlDataAdapter(strBl.ToString(), connObj.connC);                    //INITIALIZATOIN OF ADAPTER
                    adapDA.Fill(dsEdit);                                                          //FILLING THE ADAPTOR INTO DATASET
                    txtEmployeeID.Text = dsEdit.Tables[0].Rows[0][Constant.strEmpID].ToString();     //ASSIGN THE EMPLOYEEID TO ITS REGARD FIELD
                    txtFirstName.Text = dsEdit.Tables[0].Rows[0][Constant.strFstName].ToString();       //ASSIGN THE FIRSTNAME TO ITS REGARD FIELD
                    txtLastName.Text = dsEdit.Tables[0].Rows[0][Constant.strLstName].ToString();         //ASSIGN THE LASTNAME TO ITS REGARD FIELD
                    txtTitle.Text = dsEdit.Tables[0].Rows[0][Constant.strTitle].ToString();               //ASSIGN THE TITLE TO ITS REGARD FIELD
                    txtTitleOfCourtesy.Text = dsEdit.Tables[0].Rows[0][Constant.strTitleOfCourtesy].ToString();  //ASSIGN THE TITLEOFCOURTESY TO ITS REGARD FIELD
                    txtBirthDate.Text = dsEdit.Tables[0].Rows[0][Constant.strBirthDate].ToString();       //ASSIGN THE BIRTHDATE TO ITS REGARD FIELD
                    txtHireDate.Text = dsEdit.Tables[0].Rows[0][Constant.strHireDate].ToString();         //ASSIGN THE HIREDATE TO ITS REGARD FIELD
                    txtAddress.Text = dsEdit.Tables[0].Rows[0][Constant.strAddress].ToString();           //ASSIGN THE ADDRESS TO ITS REGARD FIELD
                    txtCity.Text = dsEdit.Tables[0].Rows[0][Constant.strCity].ToString();                 //ASSIGN THE CITY TO ITS REGARD FIELD           
                    txtRegion.Text = dsEdit.Tables[0].Rows[0][Constant.strRegion].ToString();             //ASSIGN THE REGION TO ITS REGARD FIELD
                    txtPostalCode.Text = dsEdit.Tables[0].Rows[0][Constant.strPostalCode].ToString();     //ASSIGN THE POSTALCODE TO ITS REGARD FIELD
                    txtCountry.Text = dsEdit.Tables[0].Rows[0][Constant.strCountry].ToString();           //ASSIGN THE COUNTRY TO ITS REGARD FIELD
                    txtHomePhone.Text = dsEdit.Tables[0].Rows[0][Constant.strHomePhone].ToString();       //ASSIGN THE HOMEPHONE TO ITS REGARD FIELD
                    txtExtension.Text = dsEdit.Tables[0].Rows[0][Constant.strExtension].ToString();       //ASSIGN THE EXTENSION TO ITS REGARD FIELD
                    txtPhoto.Text = dsEdit.Tables[0].Rows[0][Constant.strPhoto].ToString();
                    txtNotes.Text = dsEdit.Tables[0].Rows[0][Constant.strNotes].ToString();               //ASSIGN THE NOTES TO ITS REGARD FIELD
                    txtReportsTo.Text = dsEdit.Tables[0].Rows[0][Constant.strReportsTo].ToString();       //ASSIGN THE REPORTSTO TO ITS REGARD FIELD 
                    txtPhotoPath.Text = dsEdit.Tables[0].Rows[0][Constant.strPhotoPath].ToString();
                    if (connObj.connC.State == System.Data.ConnectionState.Open)
                    {
                        connObj.CloseConnection();                                                            //TO CLOSE THE DATABASE                
                    }
                }
                catch (Exception ex)
                {
                    Response.Redirect(Constant.strCatcExceptn);                                             //REDIRECT TO ERROR.ASPX IF ANY EXCEPTION IS OCCURED
                }
                finally
                {
                    connObj = null;                                                  //DESTROYING THE OBJECT OF  SQL CONNECTION
                    strBl = null;                                                 //DESTROYING THE OBJECT OF STRING BUILDER          
                    adapDA = null;                                                     //DESTROYING THE OBJECT OF SQL DATAADAPTOR
                    dsEdit = null;                                                   //DESTROYING THE OBJECT OF DATA SET                       
                }
            }
            else
            {

                txtEmployeeID.Visible = false;                                                   //MAKING TEXTBOX VISIBLE FALSE
                txtFirstName.Text = null;                                                   //ASSIGN NULL TO FIRSTNAME 
                txtLastName.Text = null;                                                          //ASSIGN NULL TO LASTNAME 
                txtTitle.Text = null;                                                       //ASSIGN NULL TO TITLE  
                txtTitleOfCourtesy.Text = null;                                                    //ASSIGN NULL TO TITLEOFCOURTESY 
                txtBirthDate.Text = null;                                                    //ASSIGN NULL TO BIRTHDATE 
                txtHireDate.Text = null;                                                    //ASSIGN NULL TO HIREDATE 
                txtAddress.Text = null;                                                     //ASSIGN NULL TO ADDRESS 
                txtCity.Text = null;                                                        //ASSIGN NULL TO CITY        
                txtRegion.Text = null;                                                         //ASSIGN NULL TO REGION 
                txtPostalCode.Text = null;                                                  //ASSIGN NULL TO POSTALCODE 
                txtCountry.Text = null;                                                      //ASSIGN NULL TO COUNTRY 
                txtHomePhone.Text = null;                                                   //ASSIGN NULL TO HOMEPHONE 
                txtExtension.Text = null;                                                     //ASSIGN NULL TO EXTENSION 
                txtPhoto.Text = null;
                txtNotes.Text = null;                                                        //ASSIGN NULL TO NOTES  
                txtReportsTo.Text = null;                                                    //ASSIGN NULL TO REPORTSTO       
                txtPhotoPath.Text = null;

            }
        }


       
     protected void btnADD_Click(object sender, EventArgs e)
        {
            SqlCommand Cmd;                                                                              //DECLARATION OF SQL COMMAND           
            StringBuilder strB1; Common connObj = new Common();
            if (Session[Constant.strEmpid] == null)
            {
                try
                {
                    connObj.OpenConnection();
                    strB1 = new StringBuilder();                                                            //INITIALIZATION OF STRING BUILDER
                    strB1.Append(Constant.strInsertEmp);
                    // strB1.Append(" (EmployeeID , ");
                    strB1.Append(" (FirstName , ");
                    strB1.Append(" LastName , ");
                    strB1.Append(" Title , ");
                    strB1.Append(" TitleOfCourtesy , ");
                    strB1.Append(" BirthDate , ");
                    strB1.Append(" HireDate , ");
                    strB1.Append(" Address , ");
                    strB1.Append(" City , ");
                    strB1.Append(" Region , ");
                    strB1.Append(" PostalCode , ");
                    strB1.Append(" Country , ");
                    strB1.Append(" HomePhone , ");
                    strB1.Append(" Extension, ");
                    //strB1.Append(" Photo, ");
                    strB1.Append(" Notes, ");
                    strB1.Append(" ReportsTo ) ");
                    //strB1.Append(" PhotoPath ) ");
                    //strB1.Append(" (Extension, ");
                    //strB1.Append("  ");
                    strB1.Append(" Values( ");
                    //strB1.Append(".");
                    //strB1.Append(" @EmployeeID , ");
                    strB1.Append(" @FirstName , ");
                    strB1.Append(" @LastName , ");
                    strB1.Append(" @Title , ");
                    strB1.Append(" @TitleOfCourtesy , ");
                    strB1.Append(" @BirthDate , ");
                    strB1.Append(" @HireDate , ");
                    strB1.Append(" @Address , ");
                    strB1.Append(" @City , ");
                    strB1.Append(" @Region , ");
                    strB1.Append(" @PostalCode , ");
                    strB1.Append(" @Country , ");
                    strB1.Append(" @HomePhone , ");
                    strB1.Append(" @Extension, ");
                    // strB1.Append(" @Photo, ");
                    strB1.Append(" @Notes, ");
                    strB1.Append(" @ReportsTo ) ");
                    // strB1.Append(" @PhotoPath )");
                    // strB1.Append(" ') ");

                    Cmd = new SqlCommand(strB1.ToString(), connObj.connC);                                //INITIALIZATION OF COMMAND
                    //Cmd.Parameters.Add("@EmployeeID", SqlDbType.NVarChar, 20).Value= txtEmployeeID.Text.Trim();
                    Cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar, 10).Value = txtFirstName.Text.Trim();
                    Cmd.Parameters.Add("@LastName", SqlDbType.NVarChar, 20).Value = txtLastName.Text.Trim();
                    Cmd.Parameters.Add("@Title", SqlDbType.NVarChar, 30).Value = txtTitle.Text.Trim();
                    Cmd.Parameters.Add("@TitleOfCourtesy", SqlDbType.NVarChar, 25).Value = txtTitleOfCourtesy.Text.Trim();
                    Cmd.Parameters.Add("@BirthDate", SqlDbType.DateTime, 8).Value = txtBirthDate.Text.Trim();
                    Cmd.Parameters.Add("@HireDate", SqlDbType.DateTime, 8).Value = txtHireDate.Text.Trim();
                    Cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 60).Value = txtAddress.Text.Trim();
                    Cmd.Parameters.Add("@City", SqlDbType.NVarChar, 15).Value = txtCity.Text.Trim();
                    Cmd.Parameters.Add("@Region", SqlDbType.NVarChar, 15).Value = txtRegion.Text.Trim();
                    Cmd.Parameters.Add("@PostalCode", SqlDbType.NVarChar, 10).Value = txtPostalCode.Text.Trim();
                    Cmd.Parameters.Add("@Country", SqlDbType.NVarChar, 15).Value = txtCountry.Text.Trim();
                    Cmd.Parameters.Add("@HomePhone", SqlDbType.NVarChar, 24).Value = txtHomePhone.Text.Trim();
                    Cmd.Parameters.Add("@Extension", SqlDbType.NVarChar, 4).Value = txtExtension.Text.Trim();
                    // Cmd.Parameters.Add("@Photo", SqlDbType.NVarChar, 20).Value = txtPhoto.Text.Trim();
                    Cmd.Parameters.Add("@Notes", SqlDbType.NText, 16).Value = txtNotes.Text.Trim();
                    Cmd.Parameters.Add("@ReportsTo", SqlDbType.Int, 4).Value = txtReportsTo.Text.Trim();
                    //Cmd.Parameters.Add("@PhotoPath", SqlDbType.NVarChar, 255).Value= txtPhotoPath.Text.Trim();

                    Cmd.ExecuteNonQuery();                                                             //EXECUTE THE COMMAND
                    lblInsert.Visible = true;                                                   //MAKING LABEL VISIBLE
                    lblInsert.Text = Constant.strMsgInsert;
                    if (connObj.connC.State == System.Data.ConnectionState.Open)
                    {
                        connObj.connC.Close();                                                                   //CLOSE THE CONNECTION
                    }

                }
                catch (Exception ex)
                {
                    Response.Redirect(Constant.strCatcExceptn);
                }
                finally
                {
                    if (connObj.connC.State == System.Data.ConnectionState.Open)
                    {
                        connObj.connC.Close();                                                                   //CLOSE THE CONNECTION
                    }
                    Cmd = null;
                    strB1 = null;
                }
            }
            else
            {
                btnADD.Text = Constant.strUpdate;
                SqlTransaction Trans;
                try
                {
                    connObj.OpenConnection();
                    Trans = connObj.connC.BeginTransaction();
                    string strA = Session[Constant.strEmpid].ToString();
                    int id = int.Parse(strA);
                    strB1 = new StringBuilder();
                    strB1.Append(Constant.strQryUpdate);
                    //strB1.Append(" (EmployeeID , ");
                    strB1.Append(" FirstName =@FirstName, ");
                    strB1.Append(" LastName = @LastName, ");
                    strB1.Append(" Title = @Title, ");
                    strB1.Append(" TitleOfCourtesy = @TitleOfCourtesy , ");
                    strB1.Append(" BirthDate= @BirthDate , ");
                    strB1.Append(" HireDate= @HireDate , ");
                    strB1.Append(" Address= @Address  , ");
                    strB1.Append(" City= @City , ");
                    strB1.Append(" Region=@Region , ");
                    strB1.Append(" PostalCode= @PostalCode , ");
                    strB1.Append(" Country= @Country , ");
                    strB1.Append(" HomePhone= @HomePhone , ");
                    strB1.Append(" Extension= @Extension, ");
                    //strB1.Append(" Photo, ");
                    strB1.Append(" Notes= @Notes ");
                    // strB1.Append(" ReportsTo= @RepotrsTo ");
                    // strB1.Append(" PhotoPath ) ");
                    //strB1.Append(" (Extension, ");
                    strB1.Append(Constant.strWhereEid);
                    strB1.Append(id);

                    Cmd = new SqlCommand(strB1.ToString(), connObj.connC, Trans);                                //INITIALIZATION OF COMMAND
                    //Cmd.Parameters.Add("@EmployeeID", SqlDbType.NVarChar, 20).Value= txtEmployeeID.Text.Trim();
                    Cmd.Parameters.Add("@FirstName", SqlDbType.NVarChar, 10).Value = txtFirstName.Text.Trim();
                    Cmd.Parameters.Add("@LastName", SqlDbType.NVarChar, 20).Value = txtLastName.Text.Trim();
                    Cmd.Parameters.Add("@Title", SqlDbType.NVarChar, 30).Value = txtTitle.Text.Trim();
                    Cmd.Parameters.Add("@TitleOfCourtesy", SqlDbType.NVarChar, 25).Value = txtTitleOfCourtesy.Text.Trim();
                    Cmd.Parameters.Add("@BirthDate", SqlDbType.DateTime, 8).Value = txtBirthDate.Text.Trim();
                    Cmd.Parameters.Add("@HireDate", SqlDbType.DateTime, 8).Value = txtHireDate.Text.Trim();
                    Cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 60).Value = txtAddress.Text.Trim();
                    Cmd.Parameters.Add("@City", SqlDbType.NVarChar, 15).Value = txtCity.Text.Trim();
                    Cmd.Parameters.Add("@Region", SqlDbType.NVarChar, 15).Value = txtRegion.Text.Trim();
                    Cmd.Parameters.Add("@PostalCode", SqlDbType.NVarChar, 10).Value = txtPostalCode.Text.Trim();
                    Cmd.Parameters.Add("@Country", SqlDbType.NVarChar, 15).Value = txtCountry.Text.Trim();
                    Cmd.Parameters.Add("@HomePhone", SqlDbType.NVarChar, 24).Value = txtHomePhone.Text.Trim();
                    Cmd.Parameters.Add("@Extension", SqlDbType.NVarChar, 4).Value = txtExtension.Text.Trim();
                    // Cmd.Parameters.Add("@Photo", SqlDbType.NVarChar, 20).Value = txtPhoto.Text.Trim();
                    Cmd.Parameters.Add("@Notes", SqlDbType.NText, 16).Value = txtNotes.Text.Trim();
                    // Cmd.Parameters.Add("@ReportsTo", SqlDbType.Int, 4).Value = txtReportsTo.Text.Trim();
                    //Cmd.Parameters.Add("@PhotoPath", SqlDbType.NVarChar, 255).Value= txtPhotoPath.Text.Trim();

                    Cmd.ExecuteNonQuery();                                                             //EXECUTE THE COMMAND
                    Trans.Commit();
                    lblUpdate.Visible = true;                                                   //MAKING LABEL VISIBLE
                    lblUpdate.Text = Constant.strMsgUpdate;
                    if (connObj.connC.State == System.Data.ConnectionState.Open)
                    {
                        connObj.connC.Close();                                                                   //CLOSE THE CONNECTION
                    }

                }
                catch (Exception ex)
                {
                    // Trans.Rollback();
                    Response.Redirect(Constant.strCatcExceptn);
                }
                finally
                {
                    if (connObj.connC.State == System.Data.ConnectionState.Open)
                    {
                        connObj.connC.Close();                                                                   //CLOSE THE CONNECTION
                    }
                    Cmd = null;
                    strB1 = null;
                }
            }    
      }

     protected void btnCncl_Click(object sender, EventArgs e)
     {
         Show_Data();
     }
    }
    #endregion Add_Emp
}

        


      
