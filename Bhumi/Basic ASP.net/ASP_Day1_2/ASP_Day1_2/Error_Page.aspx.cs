using System;
/// <summary>
/// NamespaceName:ASP_Day1_2
/// Description:Webform controls and their states
/// Author: Bhumi
/// Created On:16/6/2015
/// </summary>    
namespace ASP_Day1_2
{
    public partial class Error_Page : System.Web.UI.Page
    {
        #region Redirect to this page while Error Occured
        /// <summary>    
        /// Class Name:ConstantMessages
        /// Description: Error Handler Page
        /// Author:Bhumi
        /// Created On:18/6/2015
        /// </summary>        
        ConstantMessages objconstant;
        protected void Page_Load(object sender, EventArgs e)
        {
            objconstant=new ConstantMessages();
            Response.Write(objconstant.strerrormessage);
        }
        #endregion
    }
}