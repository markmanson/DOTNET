using System;
/// <summary>
/// NamespaceName:ASP_Day6
/// Description: Basic ASP.Net study
/// Author: Bhumi
/// Created On:22/6/2015
/// </summary>
namespace ASP_Day6
{
    /// <summary>
    /// Class Name:Choice
    /// Description:CheckBoxlist & Button
    /// Author:Bhumi
    /// Created On:22/6/2015
    /// </summary>        
    public partial class Choice : System.Web.UI.Page
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
                for (int i = 0; i <= CblItems.Items.Count - 1; i++)
                {
                    if (CblItems.Items[i].Selected)
                    {
                        selectText += CblItems.Items[i].Text + ",";//Get the value of checked checkboxes
                    }
                }
                if (selectText == "")
                {
                    objconstant = new ConstantMessages();
                    ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "alert('" + objconstant.stralertitemnotselected + "');", true);
                }
                else
                {
                    //passing Values in querystring
                    objconstant = new ConstantMessages();
                    Response.Redirect(objconstant.strtopicspage + "?Selected=" + selectText);
                }
            }
            catch (Exception)
            {
                //objconstant = new ConstantMessages();
                //Response.Redirect(objconstant.strErrorPage);//Error
            }
            finally
            {
                objconstant = null;
            }
        }
        #endregion
    }
}