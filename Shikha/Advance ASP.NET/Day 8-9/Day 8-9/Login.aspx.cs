using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Day_8_9
{
    #region Login
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- Login
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- CLASS FOR JAPANIES AND ENGLISH LANGUAGE LOGIN FORM ACCORDING TO SELECTED CULTURE.
    //      CREATED DATE    :- 2012/25/09
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class Login : System.Web.UI.Page
    {
        #region Page_Load
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- Page_Load
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- METHOD FOR CULTURE IS JAPANIES OR ENGLISH .
        //      CREATED DATE    :- 2012/25/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        Common objCommon;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)                                                    //IF POST BACK IS FALSE
            {
                string strLang;                                                 //DECLARATION OF A STRING VARIABLE
                    try
                    {
                        // Get the user's preferred language.
                        strLang = Request.UserLanguages[0];
                        // Get the first two characters of language.
                        strLang = strLang.Substring(0, 2);
                        // Redirect user based on his/her culture.
                        switch (strLang)
                        {
                            case Constant.strEN:
                                //Use English method.
                                EnglishLaguage();
                                break;
                            case Constant.strJA:
                                // Use Japanies method.
                                JapaniesLanguage();
                                break;

                            default:
                                // Use US site.
                                Response.Write(Constant.strNOTSELECT);
                                break;
                        }
                    }
                    catch
                    {
                        Response.Redirect(Constant.strERRORPAGE);                       //REDIRECT  TO ERROR PAGE
                    }
                    finally
                    {
                        strLang = null;                                             //FREE MEMORY OF STRING VARIABLE
                    }
                }
        }
        #endregion Page_Load
        #region EnglishLaguage
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- EnglishLaguage()
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- METHOD FOR English LANGUAGE LOGIN FORM.
        //      CREATED DATE    :- 2012/25/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
       public void EnglishLaguage()
        {
            lblError.Text = Constant.strBLANK;                       //SET BLANK 
            txtLoginID.Text = Constant.strBLANK;                     //SET BLANK 
            txtPassword.Text = Constant.strBLANK;                    //SET BLANK 
            btnSumita.Text = CultureJapToEng.サベミト;               //SET JAPANIES TO ENGLISH FOTRMAT
            btnChange.Text = CultureJapToEng.English;                //SET BUTTON TEXT IN JAPANIES
            lblLogin.Text = CultureJapToEng.ログイン;                //SET JAPANIES TO ENGLISH FOTRMAT
            lblLoginID.Text = CultureJapToEng.ログインID;            //SET JAPANIES TO ENGLISH FOTRMAT
            lblPassword.Text = CultureJapToEng.パスワド;             //SET JAPANIES TO ENGLISH FOTRMAT
            btnCancela.Text = CultureJapToEng.ケンセル;              //SET JAPANIES TO ENGLISH FOTRMAT
        }
        #endregion EnglishLaguage
       #region JapaniesLanguage
       // ---------------------------------------------------------------------------------------------------------------------------------------------
       //      NAME            :- JapaniesLanguage()
       //      AUTHOR NAME     :- Shikha Malik
       //      DESCRIPTION     :- METHOD FOR JAPANIES LANGUAGE LOGIN FORM.
       //      CREATED DATE    :- 2012/25/09
       //----------------------------------------------------------------------------------------------------------------------------------------------
       public void JapaniesLanguage()
       {
           lblError.Text = Constant.strBLANK;                  //SET BLANK 
           txtLoginID.Text = Constant.strBLANK;                //SET BLANK 
           txtPassword.Text = Constant.strBLANK;               //SET BLANK 
           btnSumita.Text = CultureLgn.strSubmit;              //SET ENGLISH TO jAPANIES FOTRMAT
           btnChange.Text = CultureLgn.日本語;                 //SET BUTTON TEXT IN ENGLISH
           lblLogin.Text = CultureLgn.strLogin;                //SET ENGLISH TO jAPANIES FOTRMAT
           lblLoginID.Text = CultureLgn.strLoginID;            //SET ENGLISH TO jAPANIES FOTRMAT
           lblPassword.Text = CultureLgn.strPassword;          //SET ENGLISH TO jAPANIES FOTRMAT
           btnCancela.Text = CultureLgn.strCancel;             //SET ENGLISH TO jAPANIES FOTRMAT
       }
       #endregion JapaniesLanguage
       #region Changebutton
       // ---------------------------------------------------------------------------------------------------------------------------------------------
       //      NAME            :- btnChange_Click
       //      AUTHOR NAME     :- Shikha Malik
       //      DESCRIPTION     :- METHOD FOR CHENGE CULTURE AND DISPLAY FORM ACCORDING TO CULTURE .
       //      CREATED DATE    :- 2012/25/09
       //----------------------------------------------------------------------------------------------------------------------------------------------
       protected void btnChange_Click(object sender, EventArgs e)
       {
            try
            {

                if (btnChange.Text == CultureLgn.日本語)          //CHECK CONDITION FOR CURRENT PAGE IN JAPANESE OR NOT
                {
                    EnglishLaguage();                                                  // IF TRUE ,CHANGE THIS IN ENGLISH
                }
                else
                {
                    JapaniesLanguage();                          //SHOW JAPANIES PAGE

                }
            }
            catch
            {
                Response.Redirect(Constant.strERRORPAGE);              //REDIRECT TO ERROR PAGE
            }
       }
       #endregion Changebutton
       #region Submit
       // ---------------------------------------------------------------------------------------------------------------------------------------------
       //      NAME            :- btnSumita_Click
       //      AUTHOR NAME     :- Shikha Malik
       //      DESCRIPTION     :- METHOD FOR CLICK EVENT ON SUBMIT DATA AND CHECH FROM DATABASE IS VALID OR NOT.
       //      CREATED DATE    :- 2012/25/09
       //----------------------------------------------------------------------------------------------------------------------------------------------
       protected void btnSumita_Click(object sender, EventArgs e)
       {
           try
           {
               if (ValidateUser(txtLoginID.Text, txtPassword.Text))
               {
                     Session[Constant.strLOGINDETAILS] = txtLoginID.Text + Constant.strBLANK;         //STORE THE LOGIN DETAILS INTO SESSION   
　　　　　　　　　　 Response.Redirect(Constant.strWELCMPAGE, false);
               }
               else
               { // Otherwise, clear the password.
                   txtPassword.Text = Constant.strBLANK;
                   if (System.Convert.ToInt32(ViewState[Constant.strTRIES]) > 1)     // If third try, display "Access Denied" page.
                   {
                       txtLoginID.Text = Constant.strBLANK;
                       lblError.Visible = true;
                       lblError.Text = Constant.strUNAUTHORIZEDUSER;      //AUTHORIZED USER
                       txtLoginID.Attributes.Add(Constant.strREADONLY, Constant.strREADONLY);
                       txtPassword.Attributes.Add(Constant.strREADONLY, Constant.strREADONLY);
                       btnSumita.Enabled = false;
                   }
                   else
                   {
                       // Otherwise, increment number of tries.
                       ViewState[Constant.strTRIES] = System.Convert.ToInt32(ViewState[Constant.strTRIES]) + 1;
                       lblError.Visible = true;
                       lblError.Text = Constant.strNOTVALID;      //not AUTHORIZED USER
                   }
               }
           }
           catch 
           {
               Response.Redirect(Constant.strERRPGE);
           }
       }
       #endregion Submit
       #region ValidateUser
       // ---------------------------------------------------------------------------------------------------------------------------------------------
       //      NAME            :- ValidateUser
       //      AUTHOR NAME     :- Shikha Malik
       //      DESCRIPTION     :- The METHOD FOR VALIDATE USER AND RETURN USER INFO.
       //      CREATED DATE    :- 2012/21/09
       //----------------------------------------------------------------------------------------------------------------------------------------------
       private Boolean ValidateUser(String strUsername, String strPassword)
       {
           SqlDataAdapter objAdapDA;
           StringBuilder objSb; DataTable dt;
           string strQuery;
           try
           {
               //Return true if the username and password is valid, false if it isn't
               objCommon = new Common();                       //CREATE OBJECT OF COMMON CLASS
               objCommon.OpenConnection();                     //OPEN CONNECTION 
               if (txtLoginID.Text != Constant.strBLANK && txtPassword.Text != Constant.strBLANK) //CHEK CONDITION FOR EMPTY TEXTBOX OR NOT IF NOT THEN CHECK FROM DATABASE
               {
                   objSb = new StringBuilder();                   //CREATE OBJECT FOE STRINGBUILDER CLASS
                   dt = new DataTable();                          //CREATE OBJECT FOE DATA TABLE
                   objSb.Append(Constant.strSELUSRNAME);          //APPEND STRING
                   objSb.Append(Constant.strQUOT + txtLoginID.Text + Constant.strQUOT);
                   objSb.Append(Constant.strPASSWORD);
                   objSb.Append(Constant.strQUOT + txtPassword.Text + Constant.strQUOT);
                   strQuery = objSb.ToString();
                   objAdapDA = new SqlDataAdapter(strQuery, objCommon.connC);             //pass connection and query into data adapter
                   objAdapDA.Fill(dt);                                     //FILL DATA TABLE               
                   if (dt.Rows.Count == 0)                                  //data NOT THEN UNAUTHORISEDD USER                                
                   {
                       strUsername = Constant.strBLANK;
                       strPassword = Constant.strBLANK;
                   }
               }
               return ((strUsername == txtLoginID.Text) && (strPassword == txtPassword.Text));
           }
           catch
           {
               Response.Redirect(Constant.strERRPGE);
               return true;
           }
           finally
           {
               objCommon.CloseConnection();                   //CLOSE CONNECTION
               objAdapDA = null;                                //RREE MEMORY OF OBJECTS
               objSb = null; dt = null;
               strQuery = null;
           }
       }
       #endregion ValidateUser
       #region Cancel
       // ---------------------------------------------------------------------------------------------------------------------------------------------
       //      NAME            :- btnCancela_Click
       //      AUTHOR NAME     :- Shikha Malik
       //      DESCRIPTION     :- METHOD FOR CANCEL EVENT, FOR RESET FORM.
       //      CREATED DATE    :- 2012/25/09
       //----------------------------------------------------------------------------------------------------------------------------------------------
       protected void btnCancela_Click(object sender, EventArgs e)
       {
           lblError.Text = Constant.strBLANK;  
           txtLoginID.Text = Constant.strBLANK;                       //RESET TEXTBOX
           txtPassword.Text = Constant.strBLANK;                      //RESET TEXTBOX
       }
       #endregion Cancel
    }
#endregion Login
}
