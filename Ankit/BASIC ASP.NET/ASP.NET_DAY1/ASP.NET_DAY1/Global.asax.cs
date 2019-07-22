using System;

namespace ASP.NET_DAY1
{
    #region Global
    /*************************************************************************************************************
     * CLASS NAME                                   :::                     Global                
     * AUTHOR NAME                                  :::                     ANKIT SHARMA
     * DATE                                         :::                     01/08/2012
     * DESCRIPTION                                  :::                     TO MAKE A GLOBAL CLASS
     * **********************************************************************************************************/
    public class Global : System.Web.HttpApplication
    {
        #region Application_Start
        /*************************************************************************************************************
     * FUNCTION NAME                                :::                     Application_Start                
     * AUTHOR NAME                                  :::                     ANKIT SHARMA
     * DATE                                         :::                     01/08/2012
     * DESCRIPTION                                  :::                     TO MAKE A FUNCTION APPLICATION_START
     * **********************************************************************************************************/
        protected void Application_Start(object sender, EventArgs e)
        {
            Application[Constant.strOnlineUser] = 0;                            //INITIALIZE THE COUNTER FOR ONLINE USER
        }
        #endregion Application_Start
        #region Session_Start
        /*************************************************************************************************************
     * FUNCTION NAME                                :::                     Session_Start                 
     * AUTHOR NAME                                  :::                     ANKIT SHARMA
     * DATE                                         :::                     01/08/2012
     * DESCRIPTION                                  :::                     TO MAKE A FUNCTION SESSION_START
     * **********************************************************************************************************/
        protected void Session_Start(object sender, EventArgs e)
        {
            Application.Lock();                                                     //LOCKING THE APPLICATION
            Application[Constant.strOnlineUser] = (int) Application[Constant.strOnlineUser] + 1; //INCREMENTING THE COUNTER FOR ONLINE USER
            Application.UnLock();                                                   //UNLOCKING THE APPLICATION
        }
        #endregion Session_Start
        #region Session_End
        /*************************************************************************************************************
     * FUNCTION NAME                                :::                     Session_End                 
     * AUTHOR NAME                                  :::                     ANKIT SHARMA
     * DATE                                         :::                     01/08/2012
     * DESCRIPTION                                  :::                     TO MAKE A FUNCTION SESSION_END
     * **********************************************************************************************************/
        protected void Session_End(object sender, EventArgs e)
        {
            Application.Lock();                             //LOCKING THE APPLICATION
            Application[Constant.strOnlineUser] = (int) Application[Constant.strOnlineUser] - 1;//DECREMENTING THE COUNTER FOR ONLINE USER
            Application.UnLock();                           //UNLOCKING THE APPLICATION
        }
        #endregion Session_End
        #region Application_End
        /*************************************************************************************************************
     * FUNCTION NAME                                :::                     Application_End                
     * AUTHOR NAME                                  :::                     ANKIT SHARMA
     * DATE                                         :::                     01/08/2012
     * DESCRIPTION                                  :::                     TO MAKE A FUNCTION APPLICATION_END
     * **********************************************************************************************************/
        protected void Application_End(object sender, EventArgs e)
        {
            Application[Constant.strOnlineUser] = 0;                    //INITIALIZE THE COUNTER OF ONLINE USER
        }
        #endregion Application_End
    }
    #endregion Global
}