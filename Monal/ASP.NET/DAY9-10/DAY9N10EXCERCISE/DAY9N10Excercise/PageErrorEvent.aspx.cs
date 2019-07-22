using System;
using System.IO;

namespace DAY9N10Excercise
{
    /// <summary>
    /// Name:PageErrorEvent
    /// Description:If there is Error in Page then using Page_Error Event Procedure to Catch unhandled exception occurs on the page.
    /// Author:Monal shah   
    /// Created Date:2010/10/26
    /// </summary>
    public partial class PageErrorEvent : System.Web.UI.Page
    {
        string FileName = string.Empty;
        StreamReader strmReader;
        #region Page_Load
        /// <summary>
        /// Name:PageErrorEvent
        /// Description:Read the File Contents and Display contents in label
        /// Author:Monal shah   
        /// Created Date:2010/10/26
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            ReadFile();
        }
        #endregion
        #region ReadFile
        /// <summary>
        /// Name:ReadFile
        /// Description:Read File contents From Created File if there is exception exception is print in Label
        /// Author:Monal shah   
        /// Created Date:2010/10/26
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReadFile()
        {
            try
            {
                FileName = Server.MapPath(ConstantMessage.FileName);
                strmReader = File.OpenText(FileName);
                LblFileContents.Text = ConstantMessage.FileContents + strmReader.ReadToEnd();
                strmReader.Close();
            }
            finally
            {
                strmReader = null;
            }
        }
        #endregion
        #region Page_Error
        /// <summary>
        /// Name:Page_Error
        /// Description:Catch the error and stored in session, and redirect to Error page
        /// Author:Monal shah   
        /// Created Date:2010/10/26
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Page_Error(object sender, EventArgs e)
        {
            Exception objError = Server.GetLastError().GetBaseException();
            string strError = ConstantMessage.ErrorCaught +
                       ConstantMessage.ErrorIn + Request.Url.ToString() +
                       ConstantMessage.ErrorMsg + objError.Message.ToString() +
                        ConstantMessage.StackTrace + objError.StackTrace.ToString();
            Session["Error"] = strError.ToString();
            Server.ClearError();
            Server.Transfer("ErrorPage.aspx");

        }
        #endregion



    }
}
