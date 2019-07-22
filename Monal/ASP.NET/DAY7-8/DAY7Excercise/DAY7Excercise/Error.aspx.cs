using System;

namespace DAY7Excercise
{
    /// <summary>
    /// Name:Error.aspx
    /// Description:"Error will be displayed here"
    /// Author:Monal Shah
    /// Created Date:2010/10/21
    public partial class Error : System.Web.UI.Page
    {
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description:Error will be displayed
        /// Author:Monal Shah
        /// Created Date:2010/10/21
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            LblErrorMsg.Text = ConstantMessage.ErrorMessage;
        }
        #endregion
    }
}
