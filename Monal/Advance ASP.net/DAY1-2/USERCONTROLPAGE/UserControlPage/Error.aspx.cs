using System;

namespace UserControlPage
{
    /// <summary>
    /// Name:Error
    /// Description:Error Message Display.
    ///author:Monal Shah
    ///Created Date:210/11/1
    /// </summary>
    public partial class Error : System.Web.UI.Page
    {
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description:Error Message Display
        ///author:Monal Shah
        ///Created Date:210/11/1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            LblErrorMsg.Text = ConstantMessage.Error;
        }
        #endregion
    }
}
