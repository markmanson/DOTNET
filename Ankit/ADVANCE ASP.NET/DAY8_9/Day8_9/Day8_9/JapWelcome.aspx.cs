using System;
namespace Day8_9
{
    #region EnWelcome
    /*************************************************************************************************************
    * CLASS NAME                                   :::                     EnWelcome                
    * AUTHOR NAME                                  :::                     ANKIT SHARMA
    * DATE                                         :::                     18/09/2012
    * DESCRIPTION                                  :::                     TO MAKE A WELCOME PAGE FOR ENGLISH CULTURE 
    * **********************************************************************************************************/
    public partial class JapWelcome : System.Web.UI.Page
    {
        #region Page_Load
        /*************************************************************************************************************
    * METHOD NAME                                  :::                      PAGE_LOAD                
    * AUTHOR NAME                                  :::                     ANKIT SHARMA
    * DATE                                         :::                     18/09/2012
    * DESCRIPTION                                  :::                     TO MAKE A WELCOME PAGE FOR ENGLISH CULTURE 
    * **********************************************************************************************************/
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session[Constant.strJap] != null)                                     //CHECK IF SESSION IS NULL
                lblWlcm.Text += Session[Constant.strJap].ToString();                  //DISPLAY THE WELCOME MESSEGE 
            else
                Response.Redirect(Constant.strJapLogin);                              //REDIRECT TO LOGIN PAGE
        }
        #endregion Page_Load
    }
    #endregion EnWelcome
}
