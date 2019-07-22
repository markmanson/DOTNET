using System;
using System.Collections;
using System.Web;
using System.Web.Security;
namespace Day7
{
    /*************************************************************************************************************
     * CLASS NAME                                   :::                     Login                
     * AUTHOR NAME                                  :::                     ANKIT SHARMA
     * DATE                                         :::                     17/09/2012
     * DESCRIPTION                                  :::                     TO MAKE AN AUTHENTICATION FORM BU USING DATA BASE AUTHENTICATION
     * **********************************************************************************************************/
    public partial class _Default : System.Web.UI.Page
    {
        /*************************************************************************************************************
       * METHOD NAME                                  :::                     btnSignIn_Click                
       * AUTHOR NAME                                  :::                     ANKIT SHARMA
       * DATE                                         :::                     17/09/2012
       * DESCRIPTION                                  :::                     CLICK EVENT OF BTN SIGN IN (IF USER NAME AND PASSWORD ARE CORRECT
         *                                                                    REDIRECT TO MAIN.ASPX OTHER-WISE DISPLAY ERROR MESSEGE ACCORDINGLY)
       * **********************************************************************************************************/
        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            ArrayList arrlstVal;                                                            //DECLARATION OF THE OBJECT OF ARRAYLIST
            Common objCommon;                                                               //DECLARATION OF AN OBJECT OF CLASS COMMON
            string strUserName, strPass;                                                    //DECLARATION OF STRING VARIABLE 
            string strMsg;                                                                  //DECLARATION OF STRING VARIABLE 
            bool BoolValid;                                                                 //DECLARATION OF BOOLEAN VARIABLE 
            try
            {
                if (txtUser.Text == Constant.strEmpty && txtPass.Text == Constant.strEmpty)                               //CHECK IF USER NAME AND PASSWORD BOTH ARE EMPTY 
                {
                    lblError.Visible = true;                                                //DISPLAY ERROR MESSEGE 
                    lblError.Text = Constant.strBothBlnk;
                }
                else if (txtUser.Text == Constant.strEmpty)                                                //CHECK IF USERNAME IS EMPTY
                {
                    lblError.Visible =true;                                                 //DISPLAY ERROR MESSEGE
                    lblError.Text = Constant.strUserEmpty;
                }
                else if (txtPass.Text == Constant.strEmpty)                                                 //CHECK IF PASSWORD IS EMPTY
                {
                    lblError.Visible = true;                                                //DISPLAY ERROR MESSEGE
                    lblError.Text = Constant.strPassEmpty;
                }
                else                                                                        //IF USER NAME AND PASSWORD BOTH HAVE SOME VALUES
                {
                    objCommon = new Common();                                                //INITIALIZATION OF AN OBJECT OF CLASS COMMON
                    arrlstVal = new ArrayList();                                             //INITIALIZATION OF AN OBJECT OF ARRAYLIST                   
                    strUserName = txtUser.Text;                                              //ASSIGN THE VALUE OF TXTID TO STRING USERNAME
                    strPass = txtPass.Text;                                                  //ASSIGN THE VALUE OF TXTPASS TO STRING PASSWORD 
                    arrlstVal = objCommon.Log(strUserName, strPass);                         //CALL THE METHOD LOG
                    strMsg = Convert.ToString(arrlstVal[0]);                                 //ASSIGN THE VALUE OF ARRLSTMYLIST[0] TO STRMSG
                    BoolValid = Convert.ToBoolean(arrlstVal[1]);                             //ASSIGN THE VALUE OF ARRLSTMYLIST[0] TO BOOLVALID
                    if (BoolValid)                                                           //IF BOOLVALID IS TRUE                                                                             
                    {                        
                        //CREATE FORM AUTHENTICATION TICKET
                        FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(1, txtUser.Text, DateTime.Now, DateTime.Now.AddMinutes(20), true, "User", FormsAuthentication.FormsCookiePath);                        
                        //FOR SECURITY REASONS WE HASH THE COOKIES
                        string hashCookies = FormsAuthentication.Encrypt(ticket);
                        HttpCookie cookie = new HttpCookie(FormsAuthentication.FormsCookieName, hashCookies);
                        // ADD THE COOKIE TO USER BROWSER
                        Response.Cookies.Add(cookie);
                        //REDIRECT TO MAIN.ASPX
                        FormsAuthentication.RedirectFromLoginPage(txtUser.Text, true);
                    }
                    else                                                                    //BOOLVALID IS FALSE
                    {
                        lblError.Visible = true;                                            //DISPLAY THE ERROR MESSEGE
                        lblError.Text=strMsg;
                    }
                }
            }
            catch                                                                            //IF EXCEPTION OCCURED
            {
                Response.Redirect(Constant.strError);                                             //REDIRECT TO ERROR.ASPX
            }
            finally
            {
                strUserName = null;                                                         //ASSIGN NULL TO THE OBJECT OF STRING USER NAME
                strPass = null;                                                             //ASSIGN NULL TO THE OBJECT OF STRING PASSWORD
                arrlstVal = null;                                                           //ASSIGN NULL TO THE OBJECT OF ARRAYLIST
                objCommon = null;                                                           //ASSIGN NULL TO THE OBJECT OF CLASS COMMON
                strMsg = null;                                                              //ASSIGN NULL TO THE OBJECT OF STRING STRMSG
            }
        }       
    }
}
