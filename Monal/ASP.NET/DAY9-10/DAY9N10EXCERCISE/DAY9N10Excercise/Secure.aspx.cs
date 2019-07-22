using System;

namespace DAY9N10Excercise
{
    /// <summary>
    /// Name:Secure
    /// Description:if Session is not null then it display the message otherwise redirect to the page
    /// Author:Monal shah
    /// Created Date:2010/10/28
    /// </summary>
    public partial class Secure : System.Web.UI.Page
    {
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description:if Session is not null then it display the message otherwise redirect to the page
        /// Author:Monal shah
        /// Created Date:2010/10/28
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            LblSecure.Visible = false;
            try
            {
                if (Session["UserID"] != null && Session["Password"] != null)
                {
                    LblSecure.Visible = true;
                    LblSecure.Text = ConstantMessage.SecureMsg+ConstantMessage.WelcomeUserName+Session["UserID"];
                }
                else
                {
                    Response.Redirect("Login.aspx",false);
                }
            }
            catch (Exception)
            {
                Response.Redirect("ErrorPage.aspx", false);
            }
            finally 
            {
                Session.Clear();
            }

        }
        #endregion
    }
}
