using System;
namespace Day8_9
{
    /*************************************************************************************************************
    * CLASS NAME                                   :::                     EnWelcome                
    * AUTHOR NAME                                  :::                     ANKIT SHARMA
    * DATE                                         :::                     18/09/2012
    * DESCRIPTION                                  :::                     TO MAKE A WELCOME PAGE FOR ENGLISH CULTURE 
    * **********************************************************************************************************/
    public partial class JapLogin : System.Web.UI.Page
    {
        #region btnSignIn_Click
     /*************************************************************************************************************
    * METHOD NAME                                  :::                     btnSignIn_Click                
    * AUTHOR NAME                                  :::                     ANKIT SHARMA
    * DATE                                         :::                     18/09/2012
    * DESCRIPTION                                  :::                     CLICK EVENT OF BTNSIGNIN(VALIDATE THE USER) 
    * **********************************************************************************************************/
        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            Common objCommon;
            try
            {
                objCommon = new Common();
                int flag;
                flag = objCommon.Jap_Login(txtUser.Text, txtPass.Text);
                if (flag == 0)
                    lblError.Text = Constant.strUserInval;                      //DISPLAY MESSEGE USER IS INVALID 
                else if (flag == -1)
                    lblError.Text = Constant.strPassInval;                      //DISPLAY MESSEGE PASSWORD IS INVALID
                else
                {
                    Response.Redirect(Constant.strExrcs2_Wel, false);            //REDIRECT TO JAPWELCOME.ASPX
                    Session[Constant.strLang] = Constant.strJapanese + txtUser.Text;
                }
            }
            catch
            {
                Response.Redirect(Constant.strError);                           //REDIRECT TO ERROR.ASPX IF ANY EXCEPTION IS OCCURED
            }
            finally
            {
                objCommon = null;                                              //ASSIGN NULL TO THE OBJECT OF common class
            }
        }
        #endregion btnSignIn_Click
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtUser.Text = string.Empty;
            txtPass.Text = string.Empty;
        }
    }
}
