using System;
/// <summary>
/// Namespace Name:ADV_ASP_Day8_9
/// Description: Globalization and Localization in ASP.Net
/// Author:Bhumi
/// Created On:16/7/2015
/// </summary>
namespace ADV_ASP_Day8_9.en
{
    /// <summary>
    /// Class Name:Welcome
    /// Description:Redirect to this page after Successful Login
    /// Author:Bhumi
    /// Created On:16/7/2015  
    /// </summary>
    public partial class Welcome : System.Web.UI.Page
    {
        ConstantMessages objconst;
        #region Page Load
        /// <summary>
        /// Method Name:Page_Load
        /// Description: Get the name of user From session and Display on Web page
        /// Author:Bhumi
        /// Created On:16/7/2015                
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["LoginID"] != null)
                {
                    objconst = new ConstantMessages();
                    LblLoginID.Text = objconst.strwelcomemsg_en + " <font color=blue>" + Session["LoginID"] + "</font>";
                }
                else
                {
                    objconst = new ConstantMessages();
                    Response.Redirect(objconst.strLogin_en, false);
                }
            }
            catch (Exception)
            {
                objconst = new ConstantMessages();
                Response.Redirect(objconst.strErrorPage);
            }
            finally
            {
                objconst = null;
            }
        }
        #endregion
    }
}