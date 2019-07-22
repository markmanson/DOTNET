using System;

namespace DAY9N10Excercise
{
    /// <summary>
    /// Name:NestedNewMasterPage
    /// Description:Print the Message in Label
    /// Author:Monal shah
    /// Creted Date:2010/10/27
    /// </summary>
    public partial class NestedNewMasterPage : System.Web.UI.MasterPage
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
            LblWelcomeMsg.Text = ConstantMessage.DifferentMasterMsg;
        }
        #endregion
    }
}
