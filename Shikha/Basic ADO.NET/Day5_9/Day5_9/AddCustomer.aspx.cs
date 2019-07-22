using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Day5_9
{
    #region AddCustomer
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- AddCustomer
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- The Class Allow user to add or update Record of Customers
    //      CREATED DATE    :- 2012/08/06
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class AddCustomer : System.Web.UI.Page
    {
        Common connObj;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Show_Data();                                          //CALL THE FUNCTION SHOWDATA
                if (Session["cusID"] != null) 
                {
                    btnADD.Text = Constant.strUpdate;
                }
            }
        }
        #region Show_Data()
        public void Show_Data()
        {
            if (Session["cusID"] != null)
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
                    if (Session["cusID"] != null)                                   //IF SESSION HAS SOME VALUES
                    {
                        string stre = Session["cusID"].ToString();
                        //int id = int.Parse(stre);
                        strBl.Append(Constant.strQryCustomer);//APPENDING THE STRING BUILDER                    
                        strBl.Append("'"+stre+"'");

                    }
                    adapDA = new SqlDataAdapter(strBl.ToString(), connObj.connC);                    //INITIALIZATOIN OF ADAPTER
                    adapDA.Fill(dsEdit);                                                          //FILLING THE ADAPTOR INTO DATASET
                    txtCustomerID.Text = dsEdit.Tables[0].Rows[0][Constant.strCustID].ToString();     //ASSIGN THE EMPLOYEEID TO ITS REGARD FIELD
                    txtCompanyName.Text = dsEdit.Tables[0].Rows[0][Constant.strCmpnyName].ToString();       //ASSIGN THE FIRSTNAME TO ITS REGARD FIELD
                    txtContactName.Text = dsEdit.Tables[0].Rows[0][Constant.strCntctName].ToString();         //ASSIGN THE LASTNAME TO ITS REGARD FIELD
                    txtContactTitle.Text = dsEdit.Tables[0].Rows[0][Constant.strCnctTitle].ToString();               //ASSIGN THE TITLE TO ITS REGARD FIELD
                    txtAddress.Text = dsEdit.Tables[0].Rows[0][Constant.strAddress].ToString();           //ASSIGN THE ADDRESS TO ITS REGARD FIELD
                    txtCity.Text = dsEdit.Tables[0].Rows[0][Constant.strCity].ToString();                 //ASSIGN THE CITY TO ITS REGARD FIELD           
                    txtRegion.Text = dsEdit.Tables[0].Rows[0][Constant.strRegion].ToString();             //ASSIGN THE REGION TO ITS REGARD FIELD
                    txtPostalCode.Text = dsEdit.Tables[0].Rows[0][Constant.strPostalCode].ToString();     //ASSIGN THE POSTALCODE TO ITS REGARD FIELD
                    txtCountry.Text = dsEdit.Tables[0].Rows[0][Constant.strCountry].ToString();           //ASSIGN THE COUNTRY TO ITS REGARD FIELD
                    txtPhone.Text = dsEdit.Tables[0].Rows[0][Constant.strPhone].ToString();       //ASSIGN THE HOMEPHONE TO ITS REGARD FIELD
                    txtFax.Text = dsEdit.Tables[0].Rows[0][Constant.strFax].ToString();               //ASSIGN THE NOTES TO ITS REGARD FIELD
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
                txtCustomerID.Visible = true;                                                   //MAKING TEXTBOX VISIBLE FALSE
                txtCompanyName.Text = null;                                                   //ASSIGN NULL TO FIRSTNAME 
                txtContactName.Text = null;                                                          //ASSIGN NULL TO LASTNAME 
                txtContactTitle = null;                                                       //ASSIGN NULL TO TITLE  
                txtAddress.Text = null;                                                     //ASSIGN NULL TO ADDRESS 
                txtCity.Text = null;                                                        //ASSIGN NULL TO CITY        
                txtRegion.Text = null;                                                         //ASSIGN NULL TO REGION 
                txtPostalCode.Text = null;                                                  //ASSIGN NULL TO POSTALCODE 
                txtCountry.Text = null;                                                      //ASSIGN NULL TO COUNTRY 
                txtPhone.Text = null;                                                   //ASSIGN NULL TO HOMEPHONE 
                txtFax = null;

            }
        }
        #endregion

        protected void btnADD_Click(object sender, EventArgs e)
        {
              SqlCommand Cmd;                                                                              //DECLARATION OF SQL COMMAND           
            StringBuilder strB1; Common connObj = new Common();
            if (Session["cusID"] == null)
            {
                try
                {
                    connObj.OpenConnection();
                    strB1 = new StringBuilder();                                                            //INITIALIZATION OF STRING BUILDER
                    strB1.Append(Constant.strInsertCustomer);
                    strB1.Append(" (CustomerID , ");
                    strB1.Append(" CompanyName , ");
                    strB1.Append(" ContactName , ");
                    strB1.Append(" ContactTitle , ");
                    strB1.Append(" Address , ");
                    strB1.Append(" City , ");
                    strB1.Append(" Region , ");
                    strB1.Append(" PostalCode , ");
                    strB1.Append(" Country , ");
                    strB1.Append(" Phone , ");
                    strB1.Append(" Fax ) ");
                    strB1.Append(" Values( ");
                    strB1.Append(" @CustomerID , ");
                    strB1.Append(" @CompanyName , ");
                    strB1.Append(" @ContactName , ");
                    strB1.Append(" @ContactTitle , ");
                    strB1.Append(" @Address , ");
                    strB1.Append(" @City , ");
                    strB1.Append(" @Region , ");
                    strB1.Append(" @PostalCode , ");
                    strB1.Append(" @Country , ");
                    strB1.Append(" @Phone , ");
                    strB1.Append(" @Fax ) ");
                   Cmd = new SqlCommand(strB1.ToString(), connObj.connC);                                //INITIALIZATION OF COMMAND
                     Cmd.Parameters.Add("@CustomerID", SqlDbType.NVarChar, 20).Value = txtCustomerID.Text.Trim();
                     Cmd.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 40).Value = txtCompanyName.Text.Trim();
                     Cmd.Parameters.Add("@ContactName", SqlDbType.NVarChar, 30).Value = txtContactName.Text.Trim();
                     Cmd.Parameters.Add("@ContactTitle", SqlDbType.NVarChar, 30).Value = txtContactTitle.Text.Trim();
                     Cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 60).Value = txtAddress.Text.Trim();
                     Cmd.Parameters.Add("@City", SqlDbType.NVarChar, 15).Value = txtCity.Text.Trim();
                     Cmd.Parameters.Add("@Region", SqlDbType.NVarChar, 15).Value = txtRegion.Text.Trim();
                     Cmd.Parameters.Add("@PostalCode", SqlDbType.NVarChar, 10).Value = txtPostalCode.Text.Trim();
                     Cmd.Parameters.Add("@Country", SqlDbType.NVarChar, 15).Value = txtCountry.Text.Trim();
                     Cmd.Parameters.Add("@Phone", SqlDbType.NVarChar, 24).Value = txtPhone.Text.Trim();
                     Cmd.Parameters.Add("@Fax", SqlDbType.NVarChar, 24).Value = txtFax.Text.Trim();
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
                   // Response.Redirect(Constant.strCustomer);
                }
            }
            else
            {
                SqlTransaction Trans; string strA;
                try
                {
                    connObj.OpenConnection();
                    Trans = connObj.connC.BeginTransaction();
                    strA = Session["cusID"].ToString();
                    strB1 = new StringBuilder();
                    strB1.Append(Constant.strQryCustmrUpdt);
                    //strB1.Append(" CustomerID =@CustomerID, ");
                    strB1.Append(" CompanyName = @CompanyName, ");
                    strB1.Append(" ContactName = @ContactName, ");
                    strB1.Append(" ContactTitle= @ContactTitle, ");
                    strB1.Append(" Address= @Address  , ");
                    strB1.Append(" City= @City , ");
                    strB1.Append(" Region= @Region , ");
                    strB1.Append(" PostalCode= @PostalCode , ");
                    strB1.Append(" Country= @Country , ");
                    strB1.Append(" Phone= @Phone , ");
                    strB1.Append(" Fax= @Fax ");
                    strB1.Append(Constant.strWhereCusID);
                    strB1.Append("'" + strA +"'");
                   Cmd = new SqlCommand(strB1.ToString(), connObj.connC, Trans);                                //INITIALIZATION OF COMMAND
                    //Cmd.Parameters.Add("@CustomerID", SqlDbType.NVarChar, 20).Value= txtCustomerID.Text.Trim();
                    Cmd.Parameters.Add("@CompanyName", SqlDbType.NVarChar, 40).Value = txtCompanyName.Text.Trim();
                    Cmd.Parameters.Add("@ContactName", SqlDbType.NVarChar, 30).Value = txtContactName.Text.Trim();
                    Cmd.Parameters.Add("@ContactTitle", SqlDbType.NVarChar, 30).Value = txtContactTitle.Text.Trim();
                    Cmd.Parameters.Add("@Address", SqlDbType.NVarChar, 60).Value = txtAddress.Text.Trim();
                    Cmd.Parameters.Add("@City", SqlDbType.NVarChar, 15).Value = txtCity.Text.Trim();
                    Cmd.Parameters.Add("@Region", SqlDbType.NVarChar, 15).Value = txtRegion.Text.Trim();
                    Cmd.Parameters.Add("@PostalCode", SqlDbType.NVarChar, 10).Value = txtPostalCode.Text.Trim();
                    Cmd.Parameters.Add("@Country", SqlDbType.NVarChar, 15).Value = txtCountry.Text.Trim();
                    Cmd.Parameters.Add("@Phone", SqlDbType.NVarChar, 24).Value = txtPhone.Text.Trim();
                    Cmd.Parameters.Add("@Fax", SqlDbType.NVarChar, 24).Value = txtFax.Text.Trim();
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
                    //Response.Redirect(Constant.strCustomer);
                }
            }
        }
    }
    #endregion AddCustomer

}
