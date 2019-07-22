using System;

namespace Day8_9ExcerobjCultureInfose
{
    /// <summary>
    /// Name:LanguageSelection
    /// Description:Select Language.
    /// Author:Monal Shah
    /// created date:2010/11/19
    /// </summary>
    public partial class LanguageSelection : System.Web.UI.Page
    {
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description:Select Language.
        /// Author:Monal Shah
        /// created date:2010/11/19
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < RbtnLst.Items.Count; i++)
            {
                if (RbtnLst.Items[i].Selected)
                    Response.Redirect("Login.aspx?id=" + RbtnLst.SelectedItem.Value, false);
            }
        }
        #endregion
    }
}
