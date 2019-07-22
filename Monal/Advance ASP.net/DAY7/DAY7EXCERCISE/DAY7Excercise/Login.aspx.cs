using System;
using System.Data;
using System.Text;
using System.Web;
using System.Web.Security;

namespace DAY7Excercise
{
    /// <summary>
    /// Name:Login
    /// Description:Create Login form and generate cookie and ticket if user is authenticate.
    /// Author:Monal Shah
    /// Created Date:2010/11/16
    /// </summary>
    public partial class Login : System.Web.UI.Page
    {
        DataTable dtUsers;
        StringBuilder objSb;
        Commonlogic objcl = new Commonlogic();
        FormsAuthenticationTicket Ticket;
        HttpCookie authCookie;
        #region Page_Load
        /// <summary>
        /// Name:Login
        /// Description:Create Login form and generate cookie and ticket if user is authenticate.
        /// Author:Monal Shah
        /// Created Date:2010/11/16
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        { TxtName.Focus(); }
        #endregion
        #region BtnSignOn_Click
        /// <summary>
        /// Name:BtnSignOn_Click
        /// Description:Create Login form and generate cookie and ticket if user is authenticate.
        /// Author:Monal Shah
        /// Created Date:2010/11/16
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnSignOn_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserExists(TxtName.Text, TxtPwd.Text))
                {
                    Ticket = new FormsAuthenticationTicket(1, TxtName.Text, DateTime.Now, DateTime.Now.AddSeconds(60), false, "User");
                    string EncryptTicket = FormsAuthentication.Encrypt(Ticket);
                    authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, EncryptTicket);
                    authCookie.Expires = Ticket.Expiration;
                    Response.Cookies.Add(authCookie);
                    FormsAuthentication.RedirectFromLoginPage(TxtName.Text, true);
                }
                else
                {
                    LblMsg.Visible = true;
                    LblMsg.Text = ConstantMessage.EnterValidValue;
                }
            }
            catch (Exception)
            { Response.Redirect("Error.aspx", false); }
            finally
            {
                authCookie = null;
                Ticket = null;
            }
        }
        #endregion
        #region UserExists
        /// <summary>
        /// Name:UserExists
        /// Description:Check for valid and authenticatte user.
        /// Author:Monal Shah
        /// Created Date:2010/11/16
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="Passwordvalue"></param>
        /// <returns>bool</returns>
        private bool UserExists(string UserName, string Passwordvalue)
        {
            dtUsers = new DataTable();
            objSb = new StringBuilder();
            try
            {
                objSb.Append("Select ");
                objSb.Append("* ");
                objSb.Append("From ");
                objSb.Append("TblLogin ");
                objSb.Append("Where ");
                objSb.Append("UserId");
                objSb.Append("=");
                objSb.Append("'");
                objSb.Append(TxtName.Text);
                objSb.Append("'");
                objSb.Append(" AND ");
                objSb.Append("PasswordValue ");
                objSb.Append("=");
                objSb.Append("'");
                objSb.Append(TxtPwd.Text);
                objSb.Append("'");
                objcl.GetSqlStmt = objSb.ToString();
                dtUsers = objcl.DataTables();
                if (dtUsers.Rows.Count > 0)
                {
                    if (dtUsers.Rows[0]["UserId"].ToString() == UserName && dtUsers.Rows[0]["PasswordValue"].ToString() == Passwordvalue)
                        return true;
                }
            }
            catch (Exception)
            { Response.Redirect("Error.aspx", false); }
            finally
            {
                objSb = null;
                dtUsers.Dispose();
            }
            return false;
        }
        #endregion
    }
}
