using System;
using System.Web.Security;

namespace DAY7Excercise
{
    /// <summary>
    /// Name:Main
    /// Description:When User Logout then cookie is deleted.
    /// Author:Monal Shah
    /// Created Date:2010/11/16
    /// </summary>
    public partial class Main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #region LnkBtnLogout_Click
        /// <summary>
        /// Name:LnkBtnLogout_Click
        /// Description:When User Logout then cookie is deleted.
        /// Author:Monal Shah
        /// Created Date:2010/11/16
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void LnkBtnLogout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            Response.Redirect("Login.aspx",false);
        }
        #endregion
    }
}
