using System;
namespace DAY12_13Export
{
    /// <summary>
    /// Name:Error
    /// Description:When error Occured then the error message is displayed.
    /// Author:Monal Shah   
    /// created Date:2010/11/26
    /// </summary>
    public partial class Error : System.Web.UI.Page
    {
        /// <summary>
        /// Name:Page_Load
        /// Description:When error Occured then the error message is displayed.
        /// Author:Monal Shah   
        /// created Date:2010/11/26
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        { LblMsg.Text = ConstantMessage.Error; }
    }
}
