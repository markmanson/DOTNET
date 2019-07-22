using System;
using System.IO;

namespace DAY9N10Excercise
{
    /// <summary>
    /// Name:ApplicationErrorEvent
    /// Description:Disable all Page_Error events created earlier.
    /// Add the event Application_Error in the application to redirect the user to the error page.
    /// Author:Monal shah   
    /// Created Date:2010/10/26
    /// </summary>
    public partial class ApplicationErrorEvent : System.Web.UI.Page
    {
        string FileName = string.Empty;
        StreamReader strmReader;
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description:Read File contents From Created File if there is exception exception is print in Label
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

    }
}
