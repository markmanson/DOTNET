using System;
using System.IO;

namespace DAY9N10Excercise
{
    /// <summary>
    /// Name:Default
    /// Description:Read File contents From Created File if there is exception exception is print in Label
    /// Author:Monal shah   
    /// Created Date:2010/10/26
    /// </summary>
    public partial class _Default : System.Web.UI.Page
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
            Page.Form.DefaultButton = BtnError.UniqueID;
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
                LblFileContents.Text = ConstantMessage.FileContents+strmReader.ReadToEnd();
                strmReader.Close();
            }
            catch (FileNotFoundException fxException)
            {
                LblFileContents.Text = fxException.Message.ToString();
            }
            finally
            {
                strmReader = null;
            }
        }
        #endregion
        #region BtnError_Click
        /// <summary>
        /// Name:BtnError_Click
        /// Description:Call Method ReadFile
        /// Author:Monal shah   
        /// Created Date:2010/10/26
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnError_Click(object sender, EventArgs e)
        {
            ReadFile();
        }
        #endregion
    }
}
