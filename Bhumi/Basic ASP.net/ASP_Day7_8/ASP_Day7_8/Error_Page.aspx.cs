using System;

namespace ASP_Day7_8
{
    public partial class Error_Page : System.Web.UI.Page
    {
        ConstantMessages objconstant;
        protected void Page_Load(object sender, EventArgs e)
        {
            objconstant = new ConstantMessages();
            Response.Write(objconstant.strErrormessage);
        }
    }
}