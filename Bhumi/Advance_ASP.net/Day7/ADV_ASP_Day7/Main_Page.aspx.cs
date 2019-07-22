using System;
using System.Web;
using System.Web.Security;
/// <summary>
/// Namespace Name:ADV_ASP_Day7
/// Description:Form Authentication & Authorization
/// Author:Bhumi
/// Created On:15/7/2015
/// </summary>
namespace ADV_ASP_Day7
{
    public partial class Main_Page : System.Web.UI.Page
    {
        #region Page Load
        /// <summary>
        /// Method Name:Page_Load
        /// Description:Get the Values From Cookie and Ticket
        /// Author:Bhumi
        /// Created On:15/7/2015
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie authCookie = HttpContext.Current.Request.Cookies[FormsAuthentication.FormsCookieName];
            FormsAuthenticationTicket authTicket = FormsAuthentication.Decrypt(authCookie.Value);
            LblUser.Text = authTicket.UserData;            
        }
        #endregion
        #region Log Out Button Click
        /// <summary>
        /// Method Name:BtnLogOut_Click
        /// Description:Remove the Values From Cookie and Ticket
        /// Author:Bhumi
        /// Created On:15/7/2015
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnLogOut_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }
        #endregion
    }
}