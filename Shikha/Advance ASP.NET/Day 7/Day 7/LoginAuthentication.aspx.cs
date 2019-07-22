using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web;
using System.Web.Security;
namespace Day_7
{
    #region LOGIN
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- _Default
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- The Class For LOGIN USER DATA.
    //      CREATED DATE    :- 2012/21/09
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class _Default : System.Web.UI.Page
    {
        #region Page_Load
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- Page_Load
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- ......
        //      CREATED DATE    :- 2012/21/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        Common objCommon;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (IsPostBack)
            //{
            //   IsChildControlStateCleared;
            //}

        }
        #endregion Page_Load
        #region SignonButton
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- btnSignon_Click
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- The Class FOR LOGIN USER INFO WITH TICKET AND COKKIES.
        //      CREATED DATE    :- 2012/21/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        protected void btnSignon_Click(object sender, EventArgs e)
        {
            FormsAuthenticationTicket objFat;
            try
            {
                if (ValidateUser(txtUsername.Text, txtPassword.Text))
                {
                    FormsAuthentication.Initialize();                   //The AddMinutes determines how long the user will be logged in after leaving
                    objFat = new FormsAuthenticationTicket(1,
                       txtUsername.Text, DateTime.Now,
                       DateTime.Now.AddMinutes(5), false, FormsAuthentication.FormsCookiePath);           //the site if he doesn't log off.
                    Response.Cookies.Add(new HttpCookie(FormsAuthentication.FormsCookieName,
                        FormsAuthentication.Encrypt(objFat)));
                    Response.Cookies[Constant.strUSERNAME].Value = txtUsername.Text;
                    Response.Cookies[Constant.strUSERNAME].Expires = DateTime.Now.AddSeconds(10);
                    //Response.Redirect(FormsAuthentication.GetRedirectUrl(txtUsername.Text, false));
                    FormsAuthentication.RedirectFromLoginPage(txtUsername.Text, true);
                }
              else
                {
                    // Otherwise, clear the password.
                    txtPassword.Text = Constant.strBLANK;
                  if (System.Convert.ToInt32(ViewState[Constant.strTRIES]) > 1)     // If third try, display "Access Denied" page.
                    {
                        txtUsername.Text = Constant.strBLANK;
                        lblError.Visible = true;
                        lblError.Text = Constant.strUNAUTHORIZEDUSER;      //AUTHORIZED USER
                        txtUsername.Attributes.Add(Constant.strREADONLY, Constant.strREADONLY);
                        txtPassword.Attributes.Add(Constant.strREADONLY, Constant.strREADONLY);
                        btnSignon.Enabled = false;
                        // Response.Redirect("Denied.aspx", false);
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
                objFat=null;
            }
        }
        #endregion SignonButton
        #region ValidateUser
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :-  ValidateUser
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
                if (txtUsername.Text != Constant.strBLANK && txtPassword.Text != Constant.strBLANK) //CHEK CONDITION FOR EMPTY TEXTBOX OR NOT IF NOT THEN CHECK FROM DATABASE
                {
                    objSb = new StringBuilder();                   //CREATE OBJECT FOE STRINGBUILDER CLASS
                    dt = new DataTable();                          //CREATE OBJECT FOE DATA TABLE
                    objSb.Append(Constant.strSELUSRNAME);          //APPEND STRING
                    objSb.Append(Constant.strQUOT + txtUsername.Text + Constant.strQUOT);
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
                return ((strUsername == txtUsername.Text) && (strPassword == txtPassword.Text));
            }
            catch
            {
                Response.Redirect(Constant.strERRPGE);
                return true;
            }
            finally
            {
                 objCommon.CloseConnection();                   //CLOSE CONNECTION
                 objAdapDA=null;                                //RREE MEMORY OF OBJECTS
                 objSb = null; dt = null;
                 strQuery = null;
            }
       }
#endregion ValidateUser
   
    }
    #endregion LOGIN
}
