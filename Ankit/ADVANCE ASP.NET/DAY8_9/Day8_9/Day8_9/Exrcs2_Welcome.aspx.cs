using System;
namespace Day8_9
{
    #region Exrcs2_Welcome
    /*************************************************************************************************************
    * CLASS NAME                                   :::                     Exrcs2_Welcome                
    * AUTHOR NAME                                  :::                     ANKIT SHARMA
    * DATE                                         :::                     19/09/2012
    * DESCRIPTION                                  :::                     TO MAKE A WELCOME PAGE ACCORDING TO THE LANGUAGE OF USER
    * **********************************************************************************************************/
    public partial class Exrcs2_Welcome : System.Web.UI.Page
    {
        #region Page_Load
        /*************************************************************************************************************
        * CLASS NAME                                   :::                     Page_Load                
        * AUTHOR NAME                                  :::                     ANKIT SHARMA
        * DATE                                         :::                     19/09/2012
        * DESCRIPTION                                  :::                     TO MAKE A WELCOME PAGE ACCORDING TO THE LANGUAGE OF USER
        * **********************************************************************************************************/
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session[Constant.strLang] == null)                              //CHECK SESSION 
            {
                Response.Redirect(Constant.strExrcs2);                            //REDIRECT TO LOGIN PAGE IF SESSION IS NULL
            }
            else
            {
                try
                {
                    string[] strLang = new string[2];                               //INIDIALIZATION OF A STRING TYPE ARRAY
                    strLang = Session[Constant.strLang].ToString().Split(Constant.chrUndrScr);      //ASSIGN SESSION VALUE TO STRING ARRAY
                    if (strLang[0] == Constant.strJap)
                    {
                        lblWlcm.Text = Resources.MyResourceJap.strWelcome + strLang[1]; //WELCOME NOTE IN JAPANESE
                    }
                    else
                    {
                        lblWlcm.Text = Resources.MyResourceEn.strWelcome + strLang[1];  //WELCOME NOTE IN ENGLISH
                    }
                }
                catch
                {
                    Response.Redirect(Constant.strError);                           //REDIRECT TO ERROR.ASPX IF ANY EXCEPTION IS OCCURRED
                }
                finally
                {
                    Session[Constant.strLang] = null;                                          //ASSIGN NULL TO SESSION 
                }
            }
        }
        #endregion Page_Load
    }
    #endregion Exrcs2_Welcome
}
