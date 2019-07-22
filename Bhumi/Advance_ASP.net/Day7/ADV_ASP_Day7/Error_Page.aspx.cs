using System;
/// <summary>
/// Namespace Name:ADV_ASP_Day7
/// Description:Form Authentication & Authorization
/// Author:Bhumi
/// Created On:15/7/2015
/// </summary>
namespace ADV_ASP_Day7
{
    public partial class Error_Page : System.Web.UI.Page
    {
        ConstantMessages objconst;
        protected void Page_Load(object sender, EventArgs e)
        {
            objconst = new ConstantMessages();
            Response.Write(objconst.strErrorMessage);
        }
    }
}