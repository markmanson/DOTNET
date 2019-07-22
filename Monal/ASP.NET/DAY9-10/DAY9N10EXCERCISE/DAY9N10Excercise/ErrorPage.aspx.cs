using System;

namespace DAY9N10Excercise
{
    /// <summary>
    /// Name:ErrorPage
    /// Description:If Error Occured then this page is displayed and message is print in label
    /// Author:Monal shah   
    /// Created Date:2010/10/26
    /// </summary>
    public partial class ErrorPage : System.Web.UI.Page
    {
        #region Page_Load
        /// <summary>
        /// Name:ErrorPage
        /// Description:Create an error page that shows a message "The application has encountered an error".
        /// Modify the web application so that the Page_Error event will redirect the user to this page.
        /// Remove all the Try .. Catch .. Statements (or comment them out) and run the app.  Try to simulate an error if required
        /// Author:Monal shah   
        /// Created Date:2010/10/26
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Error"] != null)
            {
                LblFileContents.Text = ConstantMessage.lblMessage +
                                        Session["Error"].ToString();
                Session["Error"] = null;
            }
            else
            {
                LblFileContents.Text = ConstantMessage.ApplicationContainError;
            }

        }
        #endregion
    }
}
