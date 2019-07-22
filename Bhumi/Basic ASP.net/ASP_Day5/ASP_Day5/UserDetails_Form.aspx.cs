using System;
/// <summary>
/// NamespaceName:ASP_Day5
/// Description: Basic ASP.Net study
/// Author: Bhumi
/// Created On:22/6/2015
/// </summary>    
namespace ASP_Day5
{
    /// <summary>
    /// Class Name:UserDetails_Form
    /// Description:Validation in ASP.Net
    /// Author:Bhumi
    /// Created On:22/6/2015
    /// </summary>
    public partial class UserDetails_Form : System.Web.UI.Page
    {
        string selectText = string.Empty;            
        ConstantMessages objconstant;
        protected void Page_Load(object sender, EventArgs e)
        {            
        }
        #region Submit Button Click Event
        /// <summary>
        /// Method Name:BtnSubmit_Click
        /// Description:Submit Button Click Event
        /// Author:Bhumi
        /// Created on:22/6/2015
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i <= LstLanguage.Items.Count - 1; i++)
                {
                    if (LstLanguage.Items[i].Selected)
                    {
                        selectText += LstLanguage.Items[i].Text + " ";
                    }
                }
                //passing Values in querystring
                objconstant = new ConstantMessages();
                Response.Redirect(objconstant.strinformationpage + "?Name=" + TxtName.Text + "&Sex=" + TxtSex.Text + "&Email=" + TxtEmail.Text + "&DOB=" + TxtDOB.Text + "&FaxNo=" + TxtFaxNo.Text + "&Married=" + DdlMarried.SelectedItem.Text + "&LanguageKnown=" + selectText);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                objconstant = null;
            }
        }
        #endregion        
    }
}