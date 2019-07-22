using System;
/// <summary>
/// Namespace Name:ADV_ASP_Day8_9
/// Description: Globalization and Localization in ASP.Net
/// Author:Bhumi
/// Created On:16/7/2015
/// </summary>
namespace ADV_ASP_Day8_9
{
    /// <summary>
    /// Class Name:Default
    /// Description: Identify Culture of your System
    /// Author:Bhumi
    /// Created On:16/7/2015
    /// </summary>    
    public partial class Default : System.Web.UI.Page
    {
        #region Page Load
        /// <summary>
        /// Method Name:Page_Load
        /// Description: Identify Culture of your System and Redirect To related Login Page
        /// Author:Bhumi
        /// Created On:16/7/2015     
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            ConstantMessages objconst;
            try
            {
                string sLang, sLang1;
                //Get The Culture Info
                sLang = System.Threading.Thread.CurrentThread.CurrentCulture.EnglishName;
                //System.Threading.Thread.CurrentThread.CurrentUICulture;
                sLang1 = sLang.Substring(0, 2);
                objconst = new ConstantMessages();
                // Redirect based on culture.
                switch (sLang1)
                {
                    case "En":
                        Response.Redirect(objconst.strLogin_en,false);
                        break;
                    case "Ja":
                        Response.Redirect(objconst.strLogin_ja,false);
                        break;
                    default:
                        Response.Redirect(objconst.strLogin_en,false);
                        break;
                }
            }
            catch (Exception)
            {
                objconst = new ConstantMessages();
                Response.Redirect(objconst.strErrorPage,false);
            }
            finally
            {
                objconst = null;
            }
        }
        #endregion
    }
}