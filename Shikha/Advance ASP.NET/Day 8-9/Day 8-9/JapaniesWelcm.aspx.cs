using System;

namespace Day_8_9
{
    #region JapaniesWelcm
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- JapaniesWelcm
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- CLASS FOR JAPANIES WELCOME PAGE.
    //      CREATED DATE    :- 2012/25/09
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class JapaniesWelcm : System.Web.UI.Page
    {
        #region Page_Load
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- Page_Load
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- METHOD FOR RETRIEVE SESSION VALUE.
        //      CREATED DATE    :- 2012/25/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)                                                    //CHECK IF NOT POSTBACK
                {
                    if (Session[Constant.strLOGINDETAILS] == null)                  //CHECK IF SESSION IS NULL 
                        Response.Redirect(Constant.strJAPNIEPGE);                         //DISPLAY THE MESSEGE
                    else
                    {
                        lblWlcm.Text = Constant.strUNIJAPNIES + Session[Constant.strLOGINDETAILS].ToString();
                        Session[Constant.strLOGINDETAILS] = null;                   //ASSIGN NULL TO SESSION
                    }
                }
            }
            catch
            {
                Response.Redirect(Constant.strERRORPAGE);
            }
        }
        #endregion Page_Load
    }
    #endregion JapaniesWelcm
}
