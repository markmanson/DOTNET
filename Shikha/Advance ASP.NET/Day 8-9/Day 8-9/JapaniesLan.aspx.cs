using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Day_8_9
{
    #region JapaniesLan
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- JapaniesLan
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- CLASS FOR JAPANIES LANGUAGE LOGIN FORM.
    //      CREATED DATE    :- 2012/25/09
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class JapaniesLan : System.Web.UI.Page
    {
        #region Page_Load
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- Page_Load
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- .......
        //      CREATED DATE    :- 2012/25/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        Common objCommon;
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #endregion Page_Load
        #region Submit
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- btnSumita_Click
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- METHOD FOR SUBMIT EVENT WHICH CHECK FOR VALID DATA.
        //      CREATED DATE    :- 2012/25/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        protected void btnSumita_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateUser(txtLoginID.Text, txtPassword.Text))
                {
                    Session[Constant.strLOGINDETAILS] = txtLoginID.Text + Constant.strBLANK;         //STORE THE LOGIN DETAILS INTO SESSION   

                    Response.Redirect(Constant.strJAPWELPGE, false);
                }

                else
                {
                    // Otherwise, clear the password.
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
                        ViewState[Constant.strTRIES] = System.Convert.ToInt32(ViewState[Constant.strTRIES])
                          + 1;
                        lblError.Visible = true;
                        lblError.Text = Constant.strNOTVALID;      //not AUTHORIZED USER
                    }
                }
            }
            catch
            {
                Response.Redirect(Constant.strERRPGE);
            }
            finally
            {

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
        //      DESCRIPTION     :- The METHOD FOR RESET LOGIN FORM.
        //      CREATED DATE    :- 2012/21/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        protected void btnCancela_Click(object sender, EventArgs e)
        {
            lblError.Text = Constant.strBLANK;
            txtLoginID.Text = Constant.strBLANK;
            txtPassword.Text = Constant.strBLANK;
        }
        #endregion Cancel
    }
    #endregion JapaniesLan
}
