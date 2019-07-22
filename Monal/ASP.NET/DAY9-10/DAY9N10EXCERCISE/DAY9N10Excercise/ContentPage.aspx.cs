using System;

namespace DAY9N10Excercise
{
    /// <summary>
    /// Name:ContentPage
    /// Description:Print the Message in Label
    /// Author:Monal shah
    /// Creted Date:2010/10/27
    /// </summary>
    public partial class ContentPage : System.Web.UI.Page
    {
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description:Print the Message in Label
        /// Author:Monal shah
        /// Creted Date:2010/10/27
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            lblContentMsg.Text = ConstantMessage.ContentMsg;
        }
        #endregion
    }
}
