using System;
using System.Diagnostics;

namespace DAY9N10Excercise
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception objError = Server.GetLastError().GetBaseException();
            string strError = ConstantMessage.ErrorCaught +
              ConstantMessage.ErrorIn + Request.Url.ToString() +
              ConstantMessage.ErrorMsg + objError.Message.ToString() +
              ConstantMessage.StackTrace + objError.StackTrace.ToString();
            EventLog.WriteEntry("CustomError", strError, EventLogEntryType.Error);
        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}