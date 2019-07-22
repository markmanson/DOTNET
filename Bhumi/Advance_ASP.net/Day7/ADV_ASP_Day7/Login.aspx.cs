using System;
using System.Web;
using System.Text;
using System.Web.Security;
/// <summary>
/// Namespace Name:ADV_ASP_Day7
/// Description:Form Authentication & Authorization
/// Author:Bhumi
/// Created On:15/7/2015
/// </summary>
namespace ADV_ASP_Day7
{
    /// <summary>
    /// Class Name:Login
    /// Description: Login With Form Authentication & Authorization
    /// Author:Bhumi
    /// Created On:15/7/2015
    /// </summary>
    public partial class Login : System.Web.UI.Page
    {
        ConstantMessages objconst;
        CommonFunction objcommon;
        #region Page Load
        protected void Page_Load(object sender, EventArgs e)
        {
            LblAccessDenied.Visible = false;
        }
        #endregion
        #region Sign In Button Click Event
        /// <summary>
        /// Method Name:BtnLogin_Click
        /// Description: Login With Form Authentication & Authorization Create Cookie,Ticket
        /// Author:Bhumi
        /// Created On:15/7/2015
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnLogin_Click(object sender, EventArgs e)
        {
            object UserName_Password_Exist;
            StringBuilder strBrSelectQuery;
            FormsAuthenticationTicket ticket1;
            HttpCookie cookie1;        
            try
            {
                objcommon = new CommonFunction();
                //Existance in Employees_Temp Table
                strBrSelectQuery = new StringBuilder("SELECT FirstName,LastName ");
                strBrSelectQuery.Append(" FROM Employees_Temp");
                strBrSelectQuery.Append(" WHERE FirstName='" + TxtUserName.Text + "' COLLATE Latin1_General_CS_AS AND LastName='" + TxtPassword.Text + "' COLLATE Latin1_General_CS_AS ;");
                UserName_Password_Exist = objcommon.ConnectionGenerate(strBrSelectQuery.ToString());
                if (UserName_Password_Exist != null)
                {
                    FormsAuthentication.SetAuthCookie(TxtUserName.Text.Trim(),false);

                    ticket1= new FormsAuthenticationTicket(1, TxtUserName.Text.Trim(), DateTime.Now, DateTime.Now.AddMinutes(10), false, TxtUserName.Text.Trim());
                    cookie1 = new HttpCookie(
                      FormsAuthentication.FormsCookieName,
                      FormsAuthentication.Encrypt(ticket1));
                    
                    Response.Cookies.Add(cookie1);
                    objconst = new ConstantMessages();
                    Response.Redirect(objconst.strmainpage, false);
                }
                else
                {
                    LblAccessDenied.Visible = true;                    
                }
            }
            catch (Exception)
            {
                objconst = new ConstantMessages();
                Response.Redirect(objconst.strErrorPage);
            }
            finally
            {
                objconst = null;
                strBrSelectQuery = null;
                objcommon = null;
            }
        }
        #endregion
    }
}