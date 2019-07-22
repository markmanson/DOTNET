using System;

namespace SearchApplication
{
    /// <summary>
    /// Name:Error
    /// Description:If any Error Occured Page is displyed error Message
    /// Author Name:Monal shah
    /// Created Date:2010/11/2
    /// </summary>
    public partial class Error : System.Web.UI.Page
    {
        #region Page_Load
        /// <summary>
        /// Name:Error
        /// Description:If any Error Occured Page is displyed error Message
        /// Author Name:Monal shah
        /// Created Date:2010/11/2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            LblErrorMsg.Text = ConstantMessage.lblErrorMessage;
        }
        #endregion
    }
}
