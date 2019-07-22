using System;

namespace UserControlPage
{
    /// <summary>
    /// Name:Frames
    /// Description:Master Page display With two Buttons and buttons are redirected to particular Page
    ///author:Monal Shah
    ///Created Date:210/11/1
    /// </summary>
    public partial class Frames : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #region BtnEmployeeDetails_Click
        /// <summary>
        /// Name:BtnEmployeeDetails_Click
        /// Description: Redirected to ContentFrame Page
        ///author:Monal Shah
        ///Created Date:210/11/1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnEmployeeDetails_Click(object sender, EventArgs e)
        {
            Response.Redirect("ContentFrame.aspx");
        }
        #endregion
        #region BtnDepartmentDetails_Click
        /// <summary>
        /// Name:BtnDepartmentDetails_Click
        /// Description: Redirected to DeprtmentContentFrame Page
        ///author:Monal Shah
        ///Created Date:210/11/1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnDepartmentDetails_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeprtmentContentFrame.aspx");
        }
        #endregion
    }
}
