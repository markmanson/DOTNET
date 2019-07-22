using System;
using System.Web;
using System.Web.Security;

namespace Day_7
{
    #region Main
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- Main
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- The Class For display user DATA.
    //      CREATED DATE    :- 2012/21/09
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class Main : System.Web.UI.Page
    {
        #region Page_Load
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- Main
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- The Class For display user DATA.
        //      CREATED DATE    :- 2012/21/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies[Constant.strUSERNAME] != null)              //CHECK COOKIES VALUE NULL OR NOT
            {
                lblUser.Text = Constant.strWELCM + Server.HtmlEncode(Request.Cookies[Constant.strUSERNAME].Value) + Constant.strHVANICEDAY;  //SET VALUE ON LABEL TEXT
            }
            else
            {
                Response.Redirect(Constant.strLOGINAUTH);
            }
        }
        #endregion Page_Load
        #region lnkBtnLog_Click
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- lnkBtnLog_Click
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- The METHOD FOR SIGNOUT FROM ACCOUNT.
        //      CREATED DATE    :- 2012/21/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        protected void lnkBtnLog_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            //Response.Write("<script language='javascript'> window.alert('Successfully Removed'); </script>");   
            Response.Cookies[Constant.strUSERNAME].Expires = DateTime.Now.AddSeconds(10);
            FormsAuthentication.SignOut();                 //SIGNOUT FROM USER ACCOUNT
            Response.Redirect(Request.UrlReferrer.ToString());
        }
        #endregion lnkBtnLog_ClickS
     
    }
    #endregion Main
}
