namespace Day7
{
    #region Constant
    /*************************************************************************************************************
     * CLASS NAME                                   :::                     Constant                
     * AUTHOR NAME                                  :::                     ANKIT SHARMA
     * DATE                                         :::                     17/09/2012
     * DESCRIPTION                                  :::                     TO Declare all the constant strings
     * **********************************************************************************************************/
    public class Constant
    {
        //DECLARATION OF MESSEGE IF USER NEITHER ENTERED USERNAME NOR PASSWORD*********************************** 
        public const string strBothBlnk = " You Must Enter User Name And Password";
        //DECLARATION OF MESSEGE IF USER DIDN'T ENTER USER NAME ************************************************* 
        public const string strUserEmpty = " You must enter User Name ";
        //DECLARATION OF MESSEGE IF USER DIDN'T ENTER PASSWORD ************************************************** 
        public const string strPassEmpty = " You must enter Password ";
        //DECLARATION OF MESSEGE IF USER ENTERED RIGHT USER NAME AND PASSWORD ***********************************
        public const string strWelcome = " Welcome ";
        //DECLARATION OF MESSEGE IF USER ENTERED WRONG USER NAME ************************************************* 
        public const string strUserInval = "User name is not valid";
        //DECLARATION OF MESSEGE IF USER ENTERED WRONG USER NAME ************************************************* 
        public const string strPassInval = "Password is not valid";
        //DECLARATION OF QUERY_STRING FOR SELECT USER NAME FROM TABLE DETAILS  ***********************************
        public const string strSelUser = "Select UserName from Details";
        //DECLARATION OF QUERY_STRING FOR SELECT PASSWORD WHERE USER_NAME IS GIVEN *******************************
        public const string strSelPassWhr = "Select Pass from Details where UserName = '";
        //DECLARATION OF STRING SINGLE QUOTE *********************************************************************
        public const string strQuote = "'";
        //DECLARATION OF STRING ERROR.ASPX  **********************************************************************
        public const string strError = "Error.aspx";
        //DECLARATION OF empty STRING   **************************************************************************
        public const string strEmpty = "";
        //DECLARATION OF STRING LOGIN.ASPX  **********************************************************************
        public const string strLogin = "Login.aspx";
        //DECLARATION OF STRING CONNECTION NAME  *****************************************************************
        public const string strConnect = "SQLConnection";
    }
    #endregion Constant
}
