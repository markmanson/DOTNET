using System;
using System.Collections;
namespace Day8_9
{
    #region Exercise2
    /*************************************************************************************************************
    * CLASS NAME                                   :::                     Exercise2                
    * AUTHOR NAME                                  :::                     ANKIT SHARMA
    * DATE                                         :::                     19/09/2012
    * DESCRIPTION                                  :::                     TO MAKE A LOGIN PAGE ACCORDING TO USER'S CULTURE
     *                                                                     USER CAN ALSO CHANGE THE LANGUAGE
    * **********************************************************************************************************/
    public partial class Exercise2 : System.Web.UI.Page
    {
        #region Page_Load
     /*************************************************************************************************************
    * METHOD NAME                                  :::                     Page_Load                
    * AUTHOR NAME                                  :::                     ANKIT SHARMA
    * DATE                                         :::                     19/09/2012
    * DESCRIPTION                                  :::                     TO MAKE A LOGIN PAGE ACCORDING TO USER'S CULTURE
     *                                                                     USER CAN ALSO CHANGE THE LANGUAGE
    * **********************************************************************************************************/
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)                                                    //IF POST BACK IS FALSE
            {
                string strLang;                                                 //DECLARATION OF A STRING VARIABLE
                try
                {
                    strLang = Request.UserLanguages[0];                         //GET THE USER PREFERRED LANGUAGE
                    strLang = strLang.Substring(0, 2);                          //GET THE FIRST TWO CHARACTER OF LANGUAGE
                    switch (strLang)                                            //SWITC THE LANGUAGE
                    {
                        case Constant.strEn:                                    //IF LANGUAGE IS EN
                            Lang_En();
                            break;
                        case Constant.strJa:                                    //IF LANGUAGE IS JA
                            Lang_Jap();
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
        }
        #endregion Page_Load
        #region btnLang_Click
     /*************************************************************************************************************
    * METHOD NAME                                  :::                     btnLang_Click                
    * AUTHOR NAME                                  :::                     ANKIT SHARMA
    * DATE                                         :::                     19/09/2012
    * DESCRIPTION                                  :::                     CLICK EVENT OF BUTTONLANG (TO CHANGE THE LANGUAGE OF LOGIN PAGE)
    * **********************************************************************************************************/
        protected void btnLang_Click(object sender, EventArgs e)
        {
            if (btnLang.Text == Resources.MyResourceEn.strbtnLang)          //IF CURRENT PAGE IN JAPANESE
            {
                Lang_En();                                                  //CHANGE TO ENGLISH
            }
            else                                                        
            {
                Lang_Jap();                                                 //CHANGE TO JAPANESE
            }
        }
        #endregion btnLang_Click
        #region Lang_En
    /*************************************************************************************************************
    * METHOD NAME                                  :::                     Lang_En                
    * AUTHOR NAME                                  :::                     ANKIT SHARMA
    * DATE                                         :::                     19/09/2012
    * DESCRIPTION                                  :::                     METHOD TO CHANGING THE LANGUAGE TO ENGLISH
    * **********************************************************************************************************/
        public void Lang_En()
        {
            //CHANGE THE LANGUAGE OF EACH CONTROL EXISTS ON PAGE************************************
            btnLang.Text = Resources.MyResourceJap.strbtnLang;
            lblHeader.Text = Resources.MyResourceEn.strLogin;
            lblUser.Text = Resources.MyResourceEn.strUser;
            lblPass.Text = Resources.MyResourceEn.strPass;
            btnCancel.Text = Resources.MyResourceEn.strbtnCancel;
            btnSignIn.Text = Resources.MyResourceEn.strbtnSign;
        }
        #endregion Lang_En
        #region Lang_Jap
    /*************************************************************************************************************
    * METHOD NAME                                  :::                     Lang_Jap                
    * AUTHOR NAME                                  :::                     ANKIT SHARMA
    * DATE                                         :::                     19/09/2012
    * DESCRIPTION                                  :::                     METHOD TO CHANGING THE LANGUAGE TO JAPANESE
    * **********************************************************************************************************/
        public void Lang_Jap()
        {
            //CHANGE THE LANGUAGE OF EACH CONTROL EXISTS ON PAGE************************************
            btnLang.Text = Resources.MyResourceEn.strbtnLang;
            lblHeader.Text = Resources.MyResourceJap.strLogin;
            lblUser.Text = Resources.MyResourceJap.strUser;
            lblPass.Text = Resources.MyResourceJap.strPass;
            btnCancel.Text = Resources.MyResourceJap.strbtnCancel;
            btnSignIn.Text = Resources.MyResourceJap.strbtnSign;
        }
        #endregion Lang_Jap
        #region btnSignIn_Click
        /*************************************************************************************************************
         * METHOD NAME                                  :::                     btnSignIn_Click                
         * AUTHOR NAME                                  :::                     ANKIT SHARMA
         * DATE                                         :::                     19/09/2012
         * DESCRIPTION                                  :::                     CLICK EVENT OF BTNSIGNIN (VALIDATING THE USER 
         *                                                                  AND REDIRECT TO WELCOME PAGE ACCORDING TO LANGUAGE OF USER)
       * **********************************************************************************************************/
        protected void btnSignIn_Click(object sender, EventArgs e)
        {
            Common objCommon;                                                               //DECLARATION OF THE OBJECT OF CLASS COMMON
            if (btnLang.Text == Resources.MyResourceJap.strbtnLang)
            {
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
                        Response.Redirect(Constant.strExrcs2_Wel, false);                              //REDIRECT TO ENWELCOME.ASPX
                        Session[Constant.strLang] = Constant.strEng + txtUser.Text;
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
            else
            {               
                try
                {
                    objCommon=new Common();
                    int flag;
                    flag = objCommon.Jap_Login(txtUser.Text, txtPass.Text);
                    if (flag == 0)
                        lblError.Text = Constant.strUserInval;                      //DISPLAY MESSEGE USER IS INVALID 
                    else if (flag == -1)
                        lblError.Text = Constant.strPassInval;                      //DISPLAY MESSEGE PASSWORD IS INVALID
                    else
                    {
                        Response.Redirect(Constant.strExrcs2_Wel, false);            //REDIRECT TO JAPWELCOME.ASPX
                        Session[Constant.strLang] = Constant.strJapanese+txtUser.Text;
                    }
                }
                catch
                {
                    Response.Redirect(Constant.strError);                           //REDIRECT TO ERROR.ASPX IF ANY EXCEPTION IS OCCURED
                }
                finally
                {
                    objCommon=null;                                              //ASSIGN NULL TO THE OBJECT OF common class
                }
            }
        }
        #endregion btnSignIn_Click
        #region btnCancel_Click
        /*************************************************************************************************************
         * METHOD NAME                                  :::                     btnCancel_Click                
         * AUTHOR NAME                                  :::                     ANKIT SHARMA
         * DATE                                         :::                     19/09/2012
         * DESCRIPTION                                  :::                     CLICK EVENT OF BTNCANCEL (TO CLEAR THE TEXTBOXES)
       * **********************************************************************************************************/
        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtUser.Text = string.Empty;                                            //CLEAR THE USER ID
            txtPass.Text = string.Empty;                                            //CLEAR THE PASSWORD
        }
        #endregion btnCancel_Click
    }
    #endregion Exercise2
}
