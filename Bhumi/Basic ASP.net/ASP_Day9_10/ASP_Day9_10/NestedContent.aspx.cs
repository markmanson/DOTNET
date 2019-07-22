using System;
namespace ASP_Day9_10
{
    public partial class NestedContent : System.Web.UI.Page
    {
        ConstantMessages objconst;
        protected void Page_Load(object sender, EventArgs e)
        {
            objconst=new ConstantMessages();
            Response.Write("<B>"+objconst.strnestedmaster+"</B>");
        }
    }
}