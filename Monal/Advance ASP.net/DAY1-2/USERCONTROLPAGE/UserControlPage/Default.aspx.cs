using System;

namespace UserControlPage
{
    /// <summary>
    /// Name:Default
    /// Description: Initially Text Box display the value 0 .
    ///              If Click on UP then value should increament by 1 and Click on Down then
    ///              value should decreament by  1.
    ///author:Monal Shah
    ///Created Date:210/11/1
    /// </summary>
    public partial class _Default : System.Web.UI.Page
    {
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        ///author:Monal Shah
        ///Created Date:210/11/1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }
        #endregion
        #region Page_PreRender
        /// <summary>
        /// Name:Page_PreRender
        /// Description: Initially Text Box display the value 0 .
        ///              If Click on UP then value should increament by 1 and Click on Down then
        ///              value should decreament by  1.
        ///author:Monal Shah
        ///Created Date:210/11/1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_PreRender(object sender, System.EventArgs e)
        {
            // Display the User control's value.
            TxtCounter.Text = UserControlCounter.Getcounter.ToString();
        }
        #endregion
    }
}
