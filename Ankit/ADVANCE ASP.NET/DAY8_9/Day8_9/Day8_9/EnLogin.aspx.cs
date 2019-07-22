using System;
using System.Collections;
namespace Day8_9
{
    /*************************************************************************************************************
    * CLASS NAME                                   :::                     EnLogin                
    * AUTHOR NAME                                  :::                     ANKIT SHARMA
    * DATE                                         :::                     18/09/2012
    * DESCRIPTION                                  :::                     TO MAKE A LOGIN PAGE FOR ENGLISH 
    * **********************************************************************************************************/
    public partial class _Default : System.Web.UI.Page
    {
        #region btnSignIn_Click
        /*************************************************************************************************************
    * METHOD NAME                                  :::                     btnSignIn_Click                
    * AUTHOR NAME                                  :::                     ANKIT SHARMA
    * DATE                                         :::                     18/09/2012
    * DESCRIPTION                                  :::                     CLICK EVENT OF BTN SIGNIN(VALIDATE THE USER ACCORDING TO TABLE
         *                                                                  DETAILS)
    * **********************************************************************************************************/
        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            Common objCommon;                                                               //DECLARATION OF THE OBJECT OF CLASS COMMON
            ArrayList arrlstMyList;                                                         //DECLARATION OF THE OBJECT OF ARRALIST
            string strMsg;                                                                  //DECLARATION OF STRING 
            bool BoolValid;                                                                 //DECLARATION OF BOOL
            try
            {
                objCommon = new Common();                                                   //INITIALIZATION  OF THE OBJECT OF CLASS COMMON
                arrlstMyList = new ArrayList();                                             //INITIALIZATION OF ARRAYLIST
                arrlstMyList = objCommon.Log(txtUser.Text, txtPass.Text);                   //CALL THE METHOD LOG
                strMsg = Convert.ToString(arrlstMyList[0]);                                 //ASSIGN THE VALUE OF ARRLSTMYLIST[0] TO STRMSG
                BoolValid = Convert.ToBoolean(arrlstMyList[1]);                             //ASSIGN THE VALUE OF ARRLSTMYLIST[0] TO BOOLVALID
                if (BoolValid)                                                              //IF BOOLVALID IS TRUE                                                                             
                {
                    Response.Redirect(Constant.strEnWelcome, false);                              //REDIRECT TO ENWELCOME.ASPX
                    Session[Constant.strUser] = txtUser.Text;                                         //STORE THE USER NAME INTO SESSION
                }
                else                                                                    //BOOLVALID IS FALSE
                {
                    lblError.Visible = true;                                            //DISPLAY THE ERROR MESSEGE
                    lblError.Text = strMsg;
                }
            }
            catch
            {
                Response.Redirect(Constant.strError);                                        //REDIRECT TO ERROR.ASPX IF EXCEPTION IS OCCURRED
            }
            finally
            {
                objCommon = null;                   //ASSIGN NULL TO THE OBJECT OF CLASS COMMON
                arrlstMyList = null;                //ASSIGN NULL TO THE ARRAYLIST 
                strMsg = null;                      //ASSIGN NULL TO THE STRING
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
