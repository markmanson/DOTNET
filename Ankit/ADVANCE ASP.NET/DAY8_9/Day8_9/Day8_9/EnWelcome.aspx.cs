using System;
namespace Day8_9
{
    /*************************************************************************************************************
    * CLASS NAME                                   :::                     EnWelcome                
    * AUTHOR NAME                                  :::                     ANKIT SHARMA
    * DATE                                         :::                     18/09/2012
    * DESCRIPTION                                  :::                     TO MAKE A WELCOME PAGE FOR ENGLISH CULTURE 
    * **********************************************************************************************************/
    public partial class EnWelcome : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session[Constant.strUser] != null)                          //CHECK IF SESSION IS NOT NULL
                lblWlcm.Text += Session[Constant.strUser].ToString();       //DISPLAY THE ERROR MESSEGE
            else
                Response.Redirect(Constant.strEnLogin);                     //REDIRECT TO ENLOGIN.ASPX IF SESSION IS NULL
        }
    }
}
