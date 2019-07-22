using System;

namespace Day8_9ExcerobjCultureInfose
{
    /// <summary>
    /// Name:Welcome
    /// Description:Welcome Message is Display According to Language.
    /// Author:Monal Shah
    /// created date:2010/11/19
    /// </summary>
    public partial class Welcome : System.Web.UI.Page
    {
        string[] splitValue;
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description:Welcome Message is Display According to Language.
        /// Author:Monal Shah
        /// created date:2010/11/19
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Form.DefaultButton = BtnBack.UniqueID;
            if (Request.QueryString["id"] != null)
            {
                splitValue = Request.QueryString["id"].ToString().Split(',');
                LblWelcomeMsg.Text += (string)GetGlobalResourceObject(splitValue[1], "LblWelcomeMsg");
                LblWelcomeMsg.Text = LblWelcomeMsg.Text + splitValue[0];
                BtnBack.Text = (string)GetGlobalResourceObject(splitValue[1], "BtnBack");
            }
        }
        #endregion
        #region BtnBack_Click
        /// <summary>
        /// Name:BtnBack_Click
        /// Description:Redirect To Login Page.
        /// Author:Monal Shah
        /// created date:2010/11/24
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnBack_Click(object sender, EventArgs e)
        { Response.Redirect("Login.aspx?id=" + splitValue[1], false); }
        #endregion
    }
}
