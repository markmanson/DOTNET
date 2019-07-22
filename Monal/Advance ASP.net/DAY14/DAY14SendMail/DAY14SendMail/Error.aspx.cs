using System;

namespace DAY14SendMail
{
    /// <summary>
    /// Name:Error
    /// Description:When Error Occured into any page then this page is display.
    /// Author:Monal Shah
    /// Created date:2010/11/29
    /// </summary>
    public partial class Error : System.Web.UI.Page
    { 
        /// <summary>
        /// Name:Page_Load
        /// Description:When Error Occured into any page then this page is display.
        /// Author:Monal Shah
        /// Created date:2010/11/29       
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>      
        protected void Page_Load(object sender, EventArgs e)
        { LblMsg.Text = ConstantMessage.Error; }
    }
}
