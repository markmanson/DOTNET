using System;

namespace Day_8_9
{
    #region _Default
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- _Default
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- CLASS FOR JAPANIES AND ENGLISH LANGUAGE LOGIN FORM ACCORDING TO SELECTED CULTURE.
    //      CREATED DATE    :- 2012/25/09
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class _Default : System.Web.UI.Page
    {
        #region Page_Load
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- Page_Load
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- METHOD FOR JAPANIES AND ENGLISH LANGUAGE LOGIN FORM ACCORDING TO SELECTED CULTURE.
        //      CREATED DATE    :- 2012/25/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        protected void Page_Load(object sender, EventArgs e)
        {
            string strLang;                                                 //DECLARATION OF A STRING VARIABLE
            try
            {
                // Get the user's preferred language.
                strLang = Request.UserLanguages[0];
                // Get the first two characters of language.
                strLang = strLang.Substring(0, 2);
                // Redirect user based on his/her culture.
                switch (strLang)
                {
                    case Constant.strEN:
                        // Use ENGLISH site.
                        Response.Redirect(Constant.strENGLENPGE, false);
                        break;
                    case Constant.strJA:
                        // Use JAPANIES site.
                        Response.Redirect(Constant.strJAPNIEPGE, false);
                        break;

                    default:
                        // default.
                        Response.Write(Constant.strNOTSELECT);
                        break;
                }
            }
            catch
            {
                Response.Redirect(Constant.strERRORPAGE);                       //REDIRECT  TO ERROR PAGE
            }
            finally
            {
                strLang = null;                                             //FREE MEMORY OF STRING VARIABLE
            }
        }
        #endregion Page_Load
    }
    #endregion _Default
}
