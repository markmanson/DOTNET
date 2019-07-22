using System;

namespace Day_7
{
    public partial class Error : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies[Constant.strUSERNAME] == null)
            {
                Response.Redirect(Constant.strLOGINAUTH);
            }
        }
    }
}
