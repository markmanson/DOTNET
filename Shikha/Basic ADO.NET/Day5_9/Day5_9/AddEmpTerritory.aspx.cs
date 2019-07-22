using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI.WebControls;

namespace Day5_9
{
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- AddEmpTerritory
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- The Class Allow user to display Record of Employee With DML Operation
    //      CREATED DATE    :- 2012/08/06
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class AddEmpTerritory : System.Web.UI.Page
    {
        Common connObj; ListBox myListBox;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Show_Data();                                          //CALL THE FUNCTION SHOWDATA
            }
        }
        
          public void Show_Data()
        {
            StringBuilder strBl;
            SqlDataAdapter adapDA;
            connObj = new Common();
            connObj.OpenConnection();  
            if (Session[Constant.strEmpid] != null)
            {
                tblemp.Visible = false;
                txtEmployeeID.Visible = false;
                btnADD.Text = "Update";  
                DataSet dsEdit;
                int id;
                try
                {
                    dsEdit = new DataSet();                                                //INITIALIZING THE OBJECT OF DATASET               
                    strBl = new StringBuilder();                                      //INITIALIZATION OF STRING BUILDER
                   if (Session[Constant.strEmpid] != null)                                   //IF SESSION HAS SOME VALUES
                    {
                        string stre = Session[Constant.strEmpid].ToString();
                        id = int.Parse(stre);
                        strBl.Append(Constant.strQryEmp);                           //APPENDING THE STRING BUILDER                    
                        strBl.Append(id);
                        adapDA = new SqlDataAdapter(strBl.ToString(), connObj.connC);                    //INITIALIZATOIN OF ADAPTER
                        adapDA.Fill(dsEdit);                                                          //FILLING THE ADAPTOR INTO DATASET
                        txtEmployeeID.Text = dsEdit.Tables[0].Rows[0][Constant.strEmpID].ToString();     //ASSIGN THE EMPLOYEEID TO ITS REGARD FIELD
                        txtFirstName.Text = dsEdit.Tables[0].Rows[0][Constant.strFstName].ToString();       //ASSIGN THE FIRSTNAME TO ITS REGARD FIELD
                        txtLastName.Text = dsEdit.Tables[0].Rows[0][Constant.strLstName].ToString();         //ASSIGN THE LASTNAME TO ITS REGARD FIELD
                        ddlTitle.SelectedValue = dsEdit.Tables[0].Rows[0][Constant.strTitle].ToString();
                        ddlTitleOfCourtesy.SelectedValue = dsEdit.Tables[0].Rows[0][Constant.strTitleOfCourtesy].ToString();
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
                  }
                }
                catch (Exception ex)
                {
                    if (connObj.connC.State == System.Data.ConnectionState.Open)
                    {
                        connObj.CloseConnection();                                                            //TO CLOSE THE DATABASE                
                    }
                    Response.Redirect(Constant.strCatcExceptn);                                             //REDIRECT TO ERROR.ASPX IF ANY EXCEPTION IS OCCURED
                }
                finally
                {
                    connObj = null;                                                  //DESTROYING THE OBJECT OF  SQL CONNECTION
                    strBl = null;                                                 //DESTROYING THE OBJECT OF STRING BUILDER          
                    //adapDA = null;                                                     //DESTROYING THE OBJECT OF SQL DATAADAPTOR
                    dsEdit = null;                                                   //DESTROYING THE OBJECT OF DATA SET                       
                }
                ListBInd();
            }
            else
            {
                btnADD.Text = "Add";
                ListBInd();
                tblemp.Visible = false;
                txtEmployeeID.Visible = false;
            }
        }
         
         protected void btnADD_Click(object sender, EventArgs e)
        {
            SqlCommand Cmd; SqlDataAdapter adapDA; DataTable dtEmpT;                                                                     //DECLARATION OF SQL COMMAND           
            StringBuilder strB1; Common connObj = new Common();
            Cmd = new SqlCommand();
           
                    connObj.OpenConnection();
                    string LastName = txtLastName.Text.Trim();
                    string FirstName = txtFirstName.Text.Trim();
                    string Title = ddlTitle.SelectedValue.ToString();
                    string TitleOfCourtesy = ddlTitleOfCourtesy.SelectedValue.ToString();
                    DateTime BirthDate = DateTime.Parse(txtBirthDate.Text);
                    DateTime HireDate = DateTime.Parse(txtHireDate.Text);
                    string Address = txtAddress.Text.Trim();
                    string City = txtCity.Text.Trim();
                    string Region = txtRegion.Text.Trim();
                    string PostalCode = txtPostalCode.Text.Trim();
                    string Country = txtCountry.Text.Trim();
                    string HomePhone = txtHomePhone.Text.Trim();
                    string Extension = txtExtension.Text.Trim();
                    string Notes = txtNotes.Text.Trim();
                    string ReportsTO = txtReportsTo.Text.Trim();
                    ArrayList myarr = new ArrayList();
                    for (int i = 0; i < lstTerritoryDescription.Items.Count; i++)
                    {
                        if (lstTerritoryDescription.Items[i].Selected)
                        {
                            strB1 = new StringBuilder();
                            dtEmpT = new DataTable();
                            string strarr = lstTerritoryDescription.Items[i].Text.Trim();
                            strB1.Append(Constant.strQueryTerID);
                            strB1.Append("'" + strarr + "'");
                            string strcmd = strB1.ToString();
                            adapDA = new SqlDataAdapter(strcmd, connObj.connC);
                            adapDA.Fill(dtEmpT);
                            if (dtEmpT.Rows.Count > 0)
                            {
                                myarr.Add(dtEmpT.Rows[0][Constant.strTerritoryID].ToString());
                            }
                        }

                    }
                    strB1 = null;
                    if (Session[Constant.strEmpid] == null)
                    {
                        dtEmpT = new DataTable();
                        strB1= new StringBuilder();
                        strB1.Append(Constant.strQuerymax);
                        Cmd.CommandText = strB1.ToString();
                        Cmd.Connection = connObj.connC;
                        Cmd.CommandType = CommandType.Text;
                        int EmpId = Convert.ToInt32(Cmd.ExecuteScalar());
                        strB1 = null;
                        try
                        {
                    strB1 = new StringBuilder();                                                            //INITIALIZATION OF STRING BUILDER
                    //strB1.Append(" (EmployeeID , ");
                    strB1.Append(" Insert INTO ");
                    strB1.Append(" [Employees] ");
                    strB1.Append(" ([LastName], ");
                    strB1.Append(" [FirstName], ");
                    strB1.Append(" [Title], ");
                    strB1.Append(" [TitleOfCourtesy], ");
                    strB1.Append(" [BirthDate], ");
                    strB1.Append(" [HireDate], ");
                    strB1.Append(" [Address], ");
                    strB1.Append(" [City], ");
                    strB1.Append(" [Region], ");
                    strB1.Append(" [PostalCode], ");
                    strB1.Append(" [Country], ");
                    strB1.Append(" [HomePhone], ");
                    strB1.Append(" [Extension], ");
                    strB1.Append(" [Notes], ");
                    strB1.Append(" [ReportsTo]) ");
                    strB1.Append(" VALUES ");
                    strB1.Append(" ('" + LastName + "', ");
                    strB1.Append(" '" + FirstName + "', ");
                    strB1.Append(" '" + Title + "', ");
                    strB1.Append(" '" + TitleOfCourtesy + "', ");
                    strB1.Append(" '" + BirthDate + "', ");
                    strB1.Append(" '" + HireDate + "',");
                    strB1.Append(" '" + Address + "',");
                    strB1.Append(" '" + City + "', ");
                    strB1.Append(" '" + Region + "',");
                    strB1.Append(" '" + PostalCode + "',");
                    strB1.Append(" '" + Country + "', ");
                    strB1.Append(" '" + HomePhone + "', ");
                    strB1.Append(" '" + Extension + "', ");
                    strB1.Append(" '" + Notes + "', ");
                    strB1.Append(" '" + ReportsTO + "') ");
                    strB1.Append(" ; ");
                    string s = strB1.ToString();
                    Cmd = new SqlCommand(s, connObj.connC);
                    Cmd.ExecuteNonQuery();
                    strB1 = null;
                    strB1 = new StringBuilder();
                    for (int i = 0; i < myarr.Count; i++)
                    {
                        strB1.Append(Constant.strQryInsertTerritory);
                        strB1.Append(" ('" + EmpId + "', ");
                        strB1.Append(" '" + myarr[i] + "') ");
                        strB1.Append(Constant.strSemicolon);
                    }
                    string v = strB1.ToString();
                    Cmd = new SqlCommand(v, connObj.connC);
                    Cmd.ExecuteNonQuery();                              //EXECUTE THE COMMAND
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
                    adapDA = null;
                    Response.Redirect(Constant.strRedirectEmpTer);
                }
            }
            else
            {
                        btnADD.Text = Constant.strUpdate;
                         int EmployeeID;
                         string ids = Session[Constant.strEmpid].ToString();
                        try
                         {
                             EmployeeID = int.Parse(ids);
                             Cmd = new SqlCommand();                         //initialize SqlCommand
                             strB1 = new StringBuilder();
                             strB1.Append(Constant.strQryUpdate);
                             strB1.Append(" LastName= '" + LastName + "' ,");
                             strB1.Append(" FirstName='" + FirstName + "', ");
                             strB1.Append(" Title='" + Title + "' ,");
                             strB1.Append(" TitleOfCourtesy='" + TitleOfCourtesy + "' ,");
                             strB1.Append(" BirthDate='" + BirthDate + "', ");
                             strB1.Append(" HireDate='" + HireDate + "', ");
                             strB1.Append(" Address='" + Address + "' ,");
                             strB1.Append(" City='" + City + "', ");
                             strB1.Append(" Region='" + Region + "' ,");
                             strB1.Append(" PostalCode='" + PostalCode + "' ,");
                             strB1.Append(" Country='" + Country + "', ");
                             strB1.Append(" HomePhone='" + HomePhone + "', ");
                             strB1.Append(" Extension='" + Extension + "', ");
                             strB1.Append(" Notes='" + Notes + "', ");
                             strB1.Append(" ReportsTo='" + ReportsTO + "' ");
                             strB1.Append(" WHERE  ");
                             strB1.Append(" (EmployeeID='" + EmployeeID + "' ) ");
                             //objSqlCommand.CommandText = strB1.ToString(); 
                             string s = strB1.ToString();
                             strB1 = null;
                             strB1 = new StringBuilder();
                             for (int i = 0; i < myarr.Count; i++)
                             {
                                 strB1.Append(Constant.strQryInsertTerritory);
                                 strB1.Append(" ('" + EmployeeID + "', ");
                                 strB1.Append(" '" + myarr[i] + "') ");
                                 strB1.Append(Constant.strSemicolon);
                             }
                             string v = strB1.ToString();
                             Cmd.CommandText = s + v;
                            Cmd.Connection = connObj.connC;
                            //objSqlCommand.Transaction = transaction;
                             Cmd.ExecuteNonQuery();
                   // Trans.Commit();
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
                    Response.Redirect(Constant.strRedirectEmpTer);
                }
               
            }
        }

      protected void btnCncl_Click(object sender, EventArgs e)
        {
     Show_Data();

        }
        public void ListBInd()
        {
            StringBuilder strB2; DataTable dtEmpT; SqlDataAdapter adNew;
            //// Intilization of Local Variable And Objects that are used in Current class
            listBoxValue();
            connObj = new Common();
            connObj.OpenConnection();  
            strB2= new StringBuilder();
            dtEmpT = new DataTable();
           try
            {
                strB2.Append(Constant.strBuil1);
                strB2.Append(Constant.strQeryTerritoryDes);
                strB2.Append(Constant.strBuil3);
                strB2.Append(Constant.strBuil7);
                adNew = new SqlDataAdapter(strB2.ToString(), connObj.connC);

                adNew.Fill(dtEmpT);                        // Fill Data Adapter
                if (dtEmpT.Rows.Count > 0)
                {
                    lstTerritoryDescription.DataSource = dtEmpT;
                    lstTerritoryDescription.DataTextField = Constant.strTerritoryDescription;
                    lstTerritoryDescription.DataBind();
                    if (Session[Constant.strEmpid] != null)
                    {
                        for (int i = 0; i < lstTerritoryDescription.Items.Count; i++)
                        {
                            for (int j = 0; j < myListBox.Items.Count; j++)
                            {
                                if (lstTerritoryDescription.Items[i].Equals(myListBox.Items[j]))
                                {
                                    lstTerritoryDescription.Items[i].Selected = true;
                                }
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                if (connObj.connC.State == System.Data.ConnectionState.Open)
                {
                    connObj.CloseConnection();                                                            //TO CLOSE THE DATABASE                
                }
                // Response.Write(ex.Message);
                Response.Redirect(Constant.strCatcExceptn);                         // Navigate Error.aspx page  
            }
            finally
            {
                adNew = null;
                dtEmpT = null;
                strB2 = null;
                connObj = null;

            }
        }

        #region listBoxValue
        public void listBoxValue()
        {
            connObj = new Common();
            connObj.OpenConnection();                          //INITIALIZATION OF OBJECT OF CLASS COMMON
            DataTable dtEmpT = new DataTable();                           //INITIALIZATION OF OBJECT OF DATATABLE
            StringBuilder strBl;                     //INITIALIZATION OF OBJECT OF STRINGBUILDER
            SqlDataAdapter Adpt;
            if (Session[Constant.strEmpid] != null)                      //CHECK IF SESSION IS NOT NULL
            {
                string ids = Session[Constant.strEmpid].ToString();      //ASSIGN SESSION["EMPLOYEEID"] TO STRING IDS
                try
                {
                    myListBox = new ListBox();                        //INITIALIZATION OF OBJECT OF LISTBOX                                   
                    strBl = new StringBuilder();
                    strBl.Append(Constant.strBuil1);
                    strBl.Append(Constant.strDistnctdister);
                    strBl.Append(Constant.strBuil3);
                    strBl.Append(Constant.strTer_T);
                    strBl.Append(Constant.strTer_Emp);
                    strBl.Append(Constant.strBui20);
                    strBl.Append(Constant.strTerIdET);
                    strBl.Append(Constant.strand);
                    strBl.Append(Constant.strETid);
                    strBl.Append(Constant.strBui22);

                    strBl.Append(ids);        //APPENDING THE STRING BUILDER                    
                    Adpt = new SqlDataAdapter(strBl.ToString(), connObj.connC);   //INITIALIZE THE OBJECT OF DATA ADAPTER
                    Adpt.Fill(dtEmpT);                              //FILLING THE DATA ADOPTER
                    if (dtEmpT.Rows.Count > 0)
                    {
                        myListBox.DataSource = dtEmpT;
                        myListBox.DataTextField = Constant.strTerritoryDescription;
                        myListBox.DataBind();                         //BIND THE DATA TO LIST BOX

                    }
                }
                catch (Exception ex)                                   //IF EXCEPTION OCCURED
                {
                    connObj.connC.Close();                        //CLOSE THE SQL CONNECTION
                    Response.Redirect(Constant.strCatcExceptn);                //REDIRECT TO ERROR.ASPX  
                }
                finally
                {
                    //ASSIGN NULL TO OBJECTS USED ABOVE
                    Adpt = null;
                    dtEmpT = null;
                    strBl = null;
                    connObj = null;
                }
            }
        }
        #endregion listBoxValue

      

    }
}
