using System;

namespace BASICASPNETProject
{
    
    /// <summary>
    /// Name:Error.aspx
    /// Description:"Error will be displayed here"
    /// Author:Monal Shah
    /// Created Date:2010/10/11
    public partial class Error : System.Web.UI.Page
    {
        ConstantMessage objConst = new ConstantMessage();
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description:Error will be displayed
        /// Author:Monal Shah
        /// Created Date:2010/10/11
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            LblErrorMessageId.Visible = true;
            LblErrorMessageId.Text = objConst.ErrorMessage;
        }
        #endregion
    }
}
