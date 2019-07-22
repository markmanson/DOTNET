using System;

namespace Day8_9ExcerobjCultureInfose
{
    /// <summary>
    /// Name:Error
    /// Description:Error Message Display if any error occure.
    /// Author:Monal Shah
    /// created date:2010/11/19
    /// </summary>
    public partial class Error : System.Web.UI.Page
    {
        /// <summary>
        /// Name:Error
        /// Description:Error Message Display if any error occure.
        /// Author:Monal Shah
        /// created date:2010/11/19
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        { LblMsg.Text = ConstantMessage.Error; }
    }
}
