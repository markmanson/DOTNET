using System;

namespace DAY4RadioButtoncontrol
{
    /// <summary>
    /// Name:Default
    /// Description:When Any Radio Button Value is clicked then in label "rate is changed" message display
    ///             When Button is clicked then in label "Button is Clicked" message display
    /// Author:Monal shah
    /// Created Date:2010/11/10
    /// </summary>
    public partial class _Default : System.Web.UI.Page
    {
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description:When Any Radio Button Value is clicked then in label "rate is changed" message display
        ///             When Button is clicked then in label "Button is Clicked" message display
        /// Author:Monal shah
        /// Created Date:2010/11/10
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            LblTextMsg.Text = ConstantMessage.LblTextMsg;
        }
        #endregion
        #region BtnCastVote_Click
        /// <summary>
        /// Name:BtnCastVote_Click
        /// Description:When Button is clicked then in label "Button is Clicked" message display
        /// Author:Monal shah
        /// Created Date:2010/11/10
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnCastVote_Click(object sender, EventArgs e)
        {          
            RadioRenderControl.CheckUncheckRadioList = -1;        
            LblClick.Visible = true;
            LblChange.Visible = false;
            LblClick.Text = ConstantMessage.LblClick;
        }
        #endregion
        #region RadioBtnLst_SelectedIndexChanged
        /// <summary>
        /// Name:RadioBtnLst_SelectedIndexChanged
        /// Description:When Any Radio Button Value is clicked then in label "rate is changed" message display
        /// Author:Monal shah
        /// Created Date:2010/11/10
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void RadioBtnLst_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblClick.Visible = false;
            LblChange.Visible = true;
            LblChange.Text = ConstantMessage.LblChange;
        }
        #endregion
    }
}
