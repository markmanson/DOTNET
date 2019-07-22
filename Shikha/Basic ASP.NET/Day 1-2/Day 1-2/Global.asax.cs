using System;

namespace Day_1_2
{
    #region Global
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- Global
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- The Class for count the visitors, and entry in text box.
    //      CREATED DATE    :- 2012/20/06
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["OnlineCounter"] = 0;
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application.Lock();
            Application["OnlineCounter"] = (int)Application["OnlineCounter"] + 1;
            Session[Constant.strValue] = 0;
            Application.UnLock();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
           
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application.Lock();
            Application["OnlineCounter"] = (int)Application["OnlineCounter"] - 1;
            Application.UnLock();
        }

        protected void Application_End(object sender, EventArgs e)
        {
           
        }
    }
    #endregion Global
}