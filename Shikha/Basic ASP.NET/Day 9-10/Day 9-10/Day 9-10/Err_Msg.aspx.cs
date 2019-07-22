using System;
using System.Web.UI;

namespace Day_9_10
{
    public partial class Err_Msg : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                // If Page Error Is ocuured
                if (Session[Constant.strPAGE_ERROR] != null)
                {
                    //Display Page Error Msg
                    lblError_Msg.Text = Session[Constant.strPAGE_ERROR].ToString();
                }
                // If Application Error Is Ocurred
                if (Application[Constant.strAPP_ERROR] != null)
                {
                    // Display Applicatlion Msg
                    lblError_Msg.Text = Application[Constant.strAPP_ERROR].ToString();
                }
            }
        }
    }
}
