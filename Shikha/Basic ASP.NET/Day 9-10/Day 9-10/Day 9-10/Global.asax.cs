using System;

namespace Day_9_10
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
            // Fetch Error
            Exception ex = Server.GetLastError().GetBaseException();
            // Store Error in String
            string errorInfo =
             Constant.strSOURSE+ ex.Source +
             Constant.strMESSAGE+ ex.Message +
             Constant.strSTACKTRACE + ex.StackTrace;
            // Store String Error In Session
            Application[Constant.strAPP_ERROR] = errorInfo;
            // Cleare Server Error
            System.Diagnostics.EventLog.WriteEntry(Constant.strCUSTM_ERR, errorInfo, System.Diagnostics.EventLogEntryType.Error);
            Server.ClearError();

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}