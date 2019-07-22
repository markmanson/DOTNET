using System;
using System.Collections;
using System.Drawing;
namespace Day3
{
    #region _Default
    /*************************************************************************************************************
     * CLASS NAME                                   :::                     _Default                
     * AUTHOR NAME                                  :::                     ANKIT SHARMA
     * DATE                                         :::                     07/09/2012
     * DESCRIPTION                                  :::                     TO USE THE LOGIN FORM CREATED BY WEBCUSTOM CONTROL
     * **********************************************************************************************************/
    public partial class _Default : System.Web.UI.Page
    {
        #region btnSubmit_Click
        /*************************************************************************************************************
        * CLASS NAME                                   :::                     btnSubmit_Click                
        * AUTHOR NAME                                  :::                     ANKIT SHARMA
        * DATE                                         :::                     07/09/2012
        * DESCRIPTION                                  :::                     CLICK EVENT OF SUBMIT BUTTON(TO CHECK IF USER NAME AND PASSWORD IS CORRECT) 
        * **********************************************************************************************************/
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ArrayList arrlstVal;                                                            //DECLARATION OF THE OBJECT OF ARRAYLIST
            Common objCommon;                                                               //DECLARATION OF AN OBJECT OF CLASS COMMON
            string strUserName, strPass;                                                    //DECLARATION OF STRING VARIABLE 
            string strMsg;                                                                  //DECLARATION OF STRING VARIABLE 
            bool BoolValid;                                                                 //DECLARATION OF BOOLEAN VARIABLE 
            try
            {
                if (log1.txtId_Text == "" && log1.txtPass_Text == "")                       //CHECK IF USER NAME AND PASSWORD BOTH ARE EMPTY 
                {
                    log1.lblColor = Color.Red;                                              //DISPLAY ERROR MESSEGE 
                    log1.lblText =Constant.strBothBlnk ;
                }
                else if (log1.txtId_Text == "")                                             //CHECK IF USERNAME IS EMPTY
                {
                    log1.lblColor = Color.Red;                                              //DISPLAY ERROR MESSEGE
                    log1.lblText = Constant.strUserEmpty;
                }
                else if (log1.txtPass_Text == "")                                           //CHECK IF PASSWORD IS EMPTY
                {
                    log1.lblColor = Color.Red;                                              //DISPLAY ERROR MESSEGE
                    log1.lblText = Constant.strPassEmpty;
                }
                else                                                                        //IF USER NAME AND PASSWORD BOTH HAVE SOME VALUES
                {
                    objCommon=new Common();                                                 //INITIALIZATION OF AN OBJECT OF CLASS COMMON
                    arrlstVal = new ArrayList();                                            //INITIALIZATION OF AN OBJECT OF ARRAYLIST                   
                    strUserName = log1.txtId_Text;                                          //ASSIGN THE VALUE OF TXTID TO STRING USERNAME
                    strPass = log1.txtPass_Text;                                            //ASSIGN THE VALUE OF TXTPASS TO STRING PASSWORD 
                    arrlstVal = objCommon.Log(strUserName, strPass);                        //CALL THE METHOD LOG
                    strMsg =Convert.ToString(arrlstVal[0]);                                 //ASSIGN THE VALUE OF ARRLSTMYLIST[0] TO STRMSG
                    BoolValid = Convert.ToBoolean(arrlstVal[1]);                            //ASSIGN THE VALUE OF ARRLSTMYLIST[0] TO BOOLVALID
                    if (BoolValid)                                                          //IF BOOLVALID IS TRUE                                                                             
                    {
                        log1.lblColor = Color.Blue;                                         //SET LABEL COLOR BLUE
                        log1.lblText = strMsg+strUserName;                                              //DISPLAY WELCOME MESSEGE
                        log1.txtId_Text = "";                                               //MAKE USERNAME BLANK
                    }
                    else                                                                    //BOOLVALID IS FALSE
                    {
                        log1.lblColor = Color.Red;                                          //SET LABEL COLOR RED 
                        log1.lblText = strMsg;                                              //DISPLAY ERROR MESSEGE
                    }
                }
            }
            catch(Exception EX)                                                                           //IF EXCEPTION OCCURED
            {
                Response.Redirect("Error.aspx");                                            //REDIRECT TO ERROR.ASPX
            }
            finally
            {
                strUserName = null;                                                         //ASSIGN NULL TO THE OBJECT OF STRING USER NAME
                strPass = null;                                                             //ASSIGN NULL TO THE OBJECT OF STRING PASSWORD
                arrlstVal = null;                                                           //ASSIGN NULL TO THE OBJECT OF ARRAYLIST
                objCommon = null;                                                           //ASSIGN NULL TO THE OBJECT OF CLASS COMMON
                strMsg = null;                                                              //ASSIGN NULL TO THE OBJECT OF STRING STRMSG
            }
        }
    }
    #endregion _Default
    #endregion btnSubmit_Click
}
