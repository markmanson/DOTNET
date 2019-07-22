using System;
using System.Collections;

namespace DAY5Exercise
{
    /// <summary>
    /// Name:Default.aspx
    /// Description:Create Page With Asp.net Server Validation control And send all form value to another page.
    /// Author Name:Monal Shah
    /// Created Date:2010/10/18
    /// </summary>
    public partial class _Default : System.Web.UI.Page
    {
        ArrayList ary;
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description:on page_Load BirthDate's RangeValidator Maximum and minimum Value get and set the property.
        /// Author Name:Monal Shah
        /// Created Date:2010/10/18
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                TxtName.Focus();
                RvDOB.MaximumValue = DateTime.Today.ToShortDateString();
                RvDOB.MinimumValue = DateTime.MinValue.ToShortDateString();
                Page.Form.DefaultButton = BtnSubmit.UniqueID;
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }

           
        }
        #endregion
        #region BtnSubmit_Click
        /// <summary>
        /// Name:BtnSubmit_Click
        /// Description:on All Form Control's Value Add in arrayList and add ary to session and redirecting to another page.
        /// Author Name:Monal Shah
        /// Created Date:2010/10/18
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string sLang = null;
                ary = new ArrayList();
                ary.Add(TxtName.Text);
                ary.Add(TxtMF.Text);
                ary.Add(TxtEmail.Text);
                ary.Add(TxtDob.Text);
                ary.Add(TxtPwd.Text);
                ary.Add(DdlMarried.SelectedItem.Text);
                ary.Add(TxtFax.Text);
                for (int i = 0; i < LstLanguage.Items.Count; i++)
                {
                    if (LstLanguage.Items[i].Selected == true)
                    {
                        sLang = sLang + LstLanguage.Items[i].Value + ",";
                    }
                }
                ary.Add(sLang);
                Session["FormValues"] = ary;
                Response.Redirect("Information.aspx");
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
        }
        #endregion

        protected void BtnReset_Click(object sender, EventArgs e)
        {
            TxtName.Text = string.Empty;
            TxtMF.Text = string.Empty;
            TxtEmail.Text = string.Empty;
            TxtDob.Text = string.Empty;
            TxtPwd.Text = string.Empty;
            DdlMarried.SelectedItem.Text = "---Select---";
            TxtFax.Text = string.Empty;
            for (int i = 0; i < LstLanguage.Items.Count; i++)
            {
                if (LstLanguage.Items[i].Selected == true)
                {
                    LstLanguage.Items[i].Selected = false;
                }
            }
           
        }
    }
}
