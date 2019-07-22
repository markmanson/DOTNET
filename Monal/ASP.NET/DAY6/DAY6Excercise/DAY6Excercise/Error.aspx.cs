using System;

namespace DAY6Excercise
{
    /// <summary>
    /// Name:Error.aspx
    /// Description:"Error will be displayed here"
    /// Author:Monal Shah
    /// Created Date:2010/10/20
    public partial class Error : System.Web.UI.Page
    {
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description:Error will be displayed
        /// Author:Monal Shah
        /// Created Date:2010/10/20
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            LblErroMessage.Text = ConstantMessage.ErrorMessage;
        }
        #endregion
    }
}
