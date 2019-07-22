using System;

namespace DAY3CustomControlProject
{
    /// <summary>
    /// Name:Error
    /// Description:if Error occured then the error essage display.
    /// Author:Monal Shah
    /// Created Date:2010/11/9
    /// </summary>
    public partial class Error : System.Web.UI.Page
    {
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description:if Error occured then the error essage display.
        /// Author:Monal Shah
        /// Created Date:2010/11/9
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            LblMsg.Text = ConstantMessage.Error;
        }
        #endregion
    }
}
