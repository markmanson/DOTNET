using System;

namespace ASP_Day6
{
    public partial class Error : System.Web.UI.Page
    {
        ConstantMessages objconstant;
        protected void Page_Load(object sender, EventArgs e)
        {
            objconstant=new ConstantMessages();
            Response.Write(objconstant.strErrormessage);
        }
    }
}