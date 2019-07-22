using System;
namespace ASP_Day1_2
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["PageClick"] = 0;            
        }

        protected void Session_Start(object sender, EventArgs e)
        {            
            Application.Lock();
            Application["PageClick"] = (int)Application["PageClick"] + 1;
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
            Application["PageClick"] = (int)Application["PageClick"] - 1;
            Application.UnLock();
        }
        protected void Application_End(object sender, EventArgs e)
        {
            Application.Lock();
            Application["PageClick"] = (int)Application["PageClick"] - 1;
            Application.UnLock();
        }
    }
}