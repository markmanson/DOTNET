using System;
using System.Collections;

namespace DAY5Exercise
{
    /// <summary>
    /// Name:Information
    /// Description:get all form control value's from session and display in Label's.
    /// Author Name:Monal Shah
    /// Created Date:2010/10/18
    /// </summary>
    public partial class Information : System.Web.UI.Page
    {
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description: get all form control value's from session and display in Label's.
        /// Author Name:Monal Shah
        /// Created Date:2010/10/18
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["FormValues"] != null)
                {
                    ArrayList aryValue = (ArrayList)Session["FormValues"];
                    LblName.Text = "Name : " + Convert.ToString(aryValue[0]);
                    LblDOB.Text = "Birth Date:" + Convert.ToString(aryValue[3]);
                    LblEmailId.Text = "Email-ID:" + Convert.ToString(aryValue[2]);
                    LblFax.Text = "Fax : " + Convert.ToString(aryValue[6]);
                    LblMarried.Text = "Married : " + Convert.ToString(aryValue[5]);
                    LblMFValue.Text = "Sex : " + Convert.ToString(aryValue[1]);
                    LblPwd.Text = "Password : " + Convert.ToString(aryValue[4]);
                    LblLanguage.Text = "Language Known : " + (Convert.ToString
                   (aryValue[7]).TrimEnd(','));
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
