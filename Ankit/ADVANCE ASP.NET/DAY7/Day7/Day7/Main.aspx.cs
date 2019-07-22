using System;
using System.Web;
using System.Web.Security;
namespace Day7
{
    /*************************************************************************************************************
     * CLASS NAME                                   :::                     HomePage                
     * AUTHOR NAME                                  :::                     ANKIT SHARMA
     * DATE                                         :::                     17/09/2012
     * DESCRIPTION                                  :::                     TO MAKE A PAGE WHICH WILL OPEN IF USER LOGIN SUCCESSFULLY
     * **********************************************************************************************************/
    public partial class HomePage : System.Web.UI.Page
    {
        /*************************************************************************************************************
     * METHOD NAME                                  :::                     Page_Load                
     * AUTHOR NAME                                  :::                     ANKIT SHARMA
     * DATE                                         :::                     17/09/2012
     * DESCRIPTION                                  :::                     PAGE LOAD EVENT OF PAGE (IF USER LOGIN
         *                                                                  SUCCESSFULLY IT WILL SHOWS SIGNOUT BUTTON 
         *                                                                  ELSE IT WILL REDIRECT TO LOGIN.ASPX)
     * **********************************************************************************************************/
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (HttpContext.Current.User != null)                               //CHECK IF COOKIE IS NOT NULL
                {
                    
                    btnOut.Visible = true;                                          //SET VISIBLE TRUE FOR BUTTON
                    lblLogin.Visible = true;
                }
                else
                    Response.Redirect(Constant.strLogin);                                 //IF COOKIE IS NULL REDIRECT TO ERROR.ASPX
            }
            catch
            {
                Response.Redirect(Constant.strError);
            }
        }
        /*************************************************************************************************************
       * METHOD NAME                                  :::                     btnOut_Click                
       * AUTHOR NAME                                  :::                     ANKIT SHARMA
       * DATE                                         :::                     17/09/2012
       * DESCRIPTION                                  :::                     CLICK EVENT OF BUTTON (IF CLICK IT WILL DELETE THE COOKIES)
       * **********************************************************************************************************/
        protected void btnOut_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();                                      //REMOVE AUTHENTICATION COOKIE
            Response.Redirect(Constant.strLogin);                                    //REDIRECT TO LOGIN.ASPX                                    
        }
    }
}
