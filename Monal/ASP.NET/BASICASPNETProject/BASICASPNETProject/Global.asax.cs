using System;

namespace BASICASPNETProject
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            Application.Add("User", 0);
        }

        protected void Session_Start(object sender, EventArgs e)
        {
            Application.Lock();
            int intI = int.Parse(Application.Get("User").ToString());
            intI++;
            Application.Set("User", intI);
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

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}