using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
/// <summary>
/// NamespaceName:ASP_Day3_4
/// Description: Basic ASP.Net study
/// Author: Bhumi
/// Created On:17/6/2015
/// </summary>    
namespace ASP_Day3_4
{
    public partial class Error_Page : System.Web.UI.Page
    {
        #region Redirect to this page while Error Occured
        /// <summary>    
        /// Class Name:ConstantMessages
        /// Description: Error Handler Page
        /// Author:Bhumi
        /// Created On:17/6/2015
        /// </summary>        
        ConstantMessage objconstant;
        protected void Page_Load(object sender, EventArgs e)
        {
            objconstant=new ConstantMessage();
            Response.Write(objconstant.strerrormessage);
        }
        #endregion
    }
}