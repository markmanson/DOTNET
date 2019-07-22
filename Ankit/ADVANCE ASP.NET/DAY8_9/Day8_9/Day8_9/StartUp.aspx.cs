namespace Day8_9
{
    #region StartUp
    /*************************************************************************************************************
    * CLASS NAME                                   :::                     StartUp                
    * AUTHOR NAME                                  :::                     ANKIT SHARMA
    * DATE                                         :::                     18/09/2012
    * DESCRIPTION                                  :::                     TO MAKE A PAGE WHICH CHECK THE CULTURE AND REDIRECT TO LOGIN PAGE 
     *                                                                     ACCORINGLY
    * **********************************************************************************************************/
    public partial class StartUp : System.Web.UI.Page
    {
        #region Page_Load
    /*************************************************************************************************************
    * METHOD NAME                                  :::                     Page_Load                
    * AUTHOR NAME                                  :::                     ANKIT SHARMA
    * DATE                                         :::                     18/09/2012
    * DESCRIPTION                                  :::                     PAGE _LOAD EVENT OF START UP PAGE(IT FINDS THE CULTURE OF USER 
     *                                                                      AND REDIRECT TO LOGIN PAGE ACCORDINGLY)
    * **********************************************************************************************************/
        private void Page_Load(object sender, System.EventArgs e)
        {
            string strLang;                                                 //DECLARATION OF A STRING VARIABLE
            try
            {
                strLang = Request.UserLanguages[0];                         //GET THE USER PREFERRED LANGUAGE
                strLang = strLang.Substring(0, 2);                          //GET THE FIRST TWO CHARACTER OF LANGUAGE
                switch (strLang)                                            //SWITC THE LANGUAGE
                {
                    case Constant.strEn:                                    //IF LANGUAGE IS EN
                        Response.Redirect(Constant.strEnLogin,false);             //REDIRECT TO ENLOGIN.ASPX
                        break;
                    case Constant.strJa:                                    //IF LANGUAGE IS JA
                        Response.Redirect(Constant.strJapLogin,false);            //REDIRECT TO JALOGIN.ASPX
                        break;
                    default:                                                //IF ANY OTHER LANGUAGE IS SELECTED
                        Response.Write(Constant.strNotLang);   //DISPLAY ERROR MESSEGE
                        break;
                }
            }
            catch
            {
                Response.Redirect(Constant.strError);                       //REDIRECT  TO ERROR.ASPX IF ANY EXCEPTION IS OCCURRED
            }
            finally
            {
                strLang = null;                                             //ASSIGN NULL TO STRING
            }
        }
        #endregion Page_Load
    }
    #endregion StartUp
}

