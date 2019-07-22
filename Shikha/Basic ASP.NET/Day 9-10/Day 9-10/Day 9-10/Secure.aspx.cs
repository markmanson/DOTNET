using System;

namespace Day_9_10
{
    #region Secure
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- Secure
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- The Class Retrive Session value and Show lable .
    //      CREATED DATE    :- 2012/07/09
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class Secure : System.Web.UI.Page
    {
        #region Page_Load
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- Page_Load
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- On PageLoad if session is not null is show information on lable.
        //      CREATED DATE    :- 2012/07/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)                                                    //CHECK IF NOT POSTBACK
                {
                    if (Session[Constant.strLOGINDETAILS] == null)                  //CHECK IF SESSION IS NULL 
                        Response.Redirect(Constant.strLOGINPAGE);                         //DISPLAY THE MESSEGE
                    else
                    {
                        lblSecure.Text = Constant.strWELCOME + Session[Constant.strLOGINDETAILS].ToString() + Constant.strTHIS_SECURE;
                        // Response.Write("Welcome" + Session[Constant.strLoginDeatils].ToString() + "This is Secure");   //DISPLAY THE WELCOME MESSEGE 
                        Session[Constant.strLOGINDETAILS] = null;                   //ASSIGN NULL TO SESSION
                    }
                }
            }
            catch
            {
                Response.Redirect(Constant.strERRORPAGE);
            }
        }
#endregion Page_laod
    }
#endregion Secure
}
