using System;

namespace Day_8_9
{
    #region Welcome
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- Welcome
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- CLASS FOR WELCOME PAGE OF LOGIN FORM ACCORDING TO SELECTED CULTURE.
    //      CREATED DATE    :- 2012/25/09
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class Welcome : System.Web.UI.Page
    {
        #region Page_Load
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- Page_Load
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- METHOD FOR WELCOME PAGE ACCORDING USER NAME CULTURE.
        //      CREATED DATE    :- 2012/25/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session[Constant.strLOGINDETAILS] != null)              //CHECK SESSION VALUE IS NULL OR NOT
            {                                                           //IF NULL
                string strLang, strlastCharacter;                       //DECLARATION OF STRING VARIABLE                                             
                try
                {
                   strLang = Session[Constant.strLOGINDETAILS].ToString();   //RETRIEVE VALUE OF SESSION IN STRING VARIABLE
                   strlastCharacter = strLang.Substring(strLang.Length - 2); //GET LAST TWO CHARACTER OF STRING
                   if (strlastCharacter == Constant.strJAPSAN)               //CHECK CONDITION FOR USER NAME IN JAPANIES OR NOT
                    {
                        lblWlcm.Text = CultureLgn.strWel + Constant.strBLANK + Session[Constant.strLOGINDETAILS].ToString();  //SET VALUE ON LABEL TEXT
                    }
                    else
                    {
                        lblWlcm.Text = CultureJapToEng.Unikaihatsuへようこそ + Constant.strBLANK + Session[Constant.strLOGINDETAILS].ToString();   //SET VALUE ON LABEL TEXT
                    }

　　   　　　　 }
               catch
                {
                    Response.Redirect(Constant.strERRORPAGE);           //REDIRECT TO ERROR PAGE
                }
            }
            else
            {
                Response.Redirect(Constant.strLOGINPAGE);               //IF SESSION IS NUL REDIRECT TO LOGIN PAGE
            }
        }
        #endregion Page_Load
    }
    #endregion Welcome
}
  