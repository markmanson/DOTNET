using System;
using System.IO;
/// <summary>
/// NamespaceName:ASP_Day9_10
/// Description: Basic ASP.Net Error generation and handling
/// Author: Bhumi
/// Created On:30/6/2015
/// </summary> 
namespace ASP_Day9_10
{
    /// <summary>
    /// Class Name:Error9
    /// Description:unhandled Exception  Handling in ASP.Net
    /// Author:Bhumi
    /// Created On:30/6/2015
    /// </summary>
    public partial class Error9 : System.Web.UI.Page
    {
        #region Page Load 
        /// <summary>
        /// Method Name:Page_Load
        /// Description: show the Error message using session variable
        /// Author:Bhumi
        /// Created on:30/6/2015 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ConstantMessages objconst;
        protected void Page_Load(object sender, EventArgs e)
        {
            objconst = new ConstantMessages();
            if (Session["Error"] != null)
            {
                LblError.Text = objconst.strErrormsg +
                Session["Error"].ToString();
                // Clear the Session variable.
                Session["Error"] = null;
            }           
        }
        #endregion
        #region Read File Click Event
        /// <summary>
        /// Method Name:BtnRead_Click
        /// Description:Read File From Local disk and print data on web form
        /// Author:Bhumi
        /// Created on:30/6/2015 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnRead_Click(object sender, EventArgs e)
        {
            String line;
            StreamReader sr;
            objconst = new ConstantMessages();
            //Pass the file path
            sr = new StreamReader(Server.MapPath(objconst.strExistFile));
            //Read the  text
            line = sr.ReadToEnd();
            Response.Write("<h3>File Data:</h3><br/>" + line);
            sr.Close();  
        }
        #endregion
        #region Error Message click event
        /// <summary>
        /// Method Name:BtnError_Click
        /// Description:Error Handling Message show
        /// Author:Bhumi
        /// Created on:30/6/2015  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnError_Click(object sender, EventArgs e)
        {
            String line;
            StreamReader sr;
            objconst = new ConstantMessages();
            //Pass the file path
            sr = new StreamReader(objconst.strNotExistFile);
            //Read the  text
            line = sr.ReadToEnd();
            Response.Write(line);
            sr.Close();
        }
        #endregion
        #region Unhandled Exception Handling procedure
        /// <summary>
        /// Method Name:Page_Error
        /// Description:Exception Handling Method
        /// Author:Bhumi
        /// Created on:30/6/2015  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_Error(object sender, System.EventArgs e)
        {
            // Get the error.
            Exception ex = Server.GetLastError();
            // Store the message in a session object.
            Session["Error"] = ex.Message;
            // Clear the error message.
            Server.ClearError();
            // Redisplay this page.
            Server.Transfer(objconst.strpageEx9);
        }
        #endregion
    }
}