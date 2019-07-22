using System;

namespace DAY5EXercise
{
    /// <summary>
    /// Name:Error
    /// Decription:Error Display if any occured from any of page of application
    /// Author:Monal shah
    /// Created Date:2010/11/11
    /// </summary>
    public partial class Error : System.Web.UI.Page
    {
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Decription:Error Display if any occured from any of page of application
        /// Author:Monal shah
        /// Created Date:2010/11/11
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            LblMsg.Text = ConstantMessage.Error;
        }
        #endregion
    }
}
