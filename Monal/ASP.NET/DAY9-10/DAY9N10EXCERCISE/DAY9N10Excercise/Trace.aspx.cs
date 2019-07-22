using System;
using System.IO;

namespace DAY9N10Excercise
{
    /// <summary>
    /// Name:Trace
    /// Description:Trace Erro Log
    /// Author:Monal shah   
    /// Created Date:2010/10/27
    /// </summary>
    public partial class Trace : System.Web.UI.Page
    {
        string FileName = string.Empty;
        StreamReader strmReader;
        private static string log = string.Empty;
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description:Read File contents From Created File if there is exception exception is print in Label
        /// Author:Monal shah   
        /// Created Date:2010/10/27
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
        /// Created Date:2010/10/27
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
        /// Description:Display Trace Application Log
        /// Author:Monal shah   
        /// Created Date:2010/10/27
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_Error(object sender, System.EventArgs e)
        {
            if (Trace.IsEnabled)
            {
                Trace.Warn(ConstantMessage.Error, "", Server.GetLastError());
                Server.ClearError();
                Response.Write(TraceLog);
            }
        }
        #endregion
        #region TraceLog
        /// <summary>
        /// Name:TraceLog
        /// Description:Display Trace Application Log
        /// Author:Monal shah   
        /// Created Date:2010/10/27
        /// </summary>
        public string TraceLog
        {
            get
            {
                return log = "<a href=\"Trace.axd \"style=font-size=14px\">View Trace Log</a>";
            }
            set
            {
                Trace.IsEnabled = true;
            }

        }
        #endregion

    }
}
