using System;

namespace DAY6Excercise
{
    /// <summary>
    /// Name:Default.aspx
    /// Description:"Task : 1 When user click on submit 
    ///              button navigate to Topics.aspx form and create
    ///              hyperlinks in table object for selected options only.
    ///              (Use ""Request"" object for this task)"
    ///              "Task : 2 When no option is selected and user click 
    ///              on submit button display alter message from javascript "
    ///              "Please select atleast one option."""
    /// Author:Monal Shah
    /// Created Date:2010/10/20
    /// </summary>
    public partial class _Default : System.Web.UI.Page
    {
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Author:Monal Shah
        /// Created Date:2010/10/20
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Form.DefaultButton = BtnSubmit.UniqueID;
        }
        #endregion
        #region BtnSubmit_Click
        /// <summary>
        /// Name:BtnSubmit_Click
        /// Description:"Task : 1 When user click on submit 
        ///              button navigate to Topics.aspx form and create
        ///              hyperlinks in table object for selected options only.
        ///              (Use ""Request"" object for this task)"
        /// Author:Monal Shah
        /// Created Date:2010/10/20
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string strS = null;
                for (int i = 0; i < ChkLstValue.Items.Count; i++)
                {
                    if (ChkLstValue.Items[i].Selected)
                    {
                        strS = strS + ChkLstValue.Items[i].Text + "," + ChkLstValue.Items[i].Value + ",";
                    }
                }
                if (strS != null)
                {
                    Response.Redirect("Topics.aspx?id=" + strS,false);
                }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }

        }
        #endregion
    }
}
