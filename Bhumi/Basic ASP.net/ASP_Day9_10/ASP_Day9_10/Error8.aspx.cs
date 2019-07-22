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
    /// Class Name:Error8
    /// Description:Error Handling in ASP.Net
    /// Author:Bhumi
    /// Created On:30/6/2015
    /// </summary>
    public partial class Error8 : System.Web.UI.Page
    {
        #region Page Load        
        protected void Page_Load(object sender, EventArgs e)
        {            
        }
        #endregion
        #region Read File Button click event
        /// <summary>
        /// Method Name:BtnRead_Click
        /// Description:Read File From Local disk and print data on web form
        /// Author:Bhumi
        /// Created on:30/6/2015 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ConstantMessages objconst;
        protected void BtnRead_Click(object sender, EventArgs e)
        {
            String line;
            StreamReader sr;
            try
            {                
                objconst = new ConstantMessages();
                //Pass the file path
                sr = new StreamReader(Server.MapPath(objconst.strExistFile));
                //Read the  text
                line = sr.ReadToEnd();
                Response.Write("<h3>File Data:</h3><br/>" + line);
                sr.Close();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                objconst = null;
            }
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
            try
            {
                objconst = new ConstantMessages();
                //Pass the file path
                sr = new StreamReader(objconst.strNotExistFile);
                //Read the  text
                line = sr.ReadToEnd();
                Response.Write(line);
                sr.Close();
            }
            catch (FileNotFoundException exe)
            {
                Response.Write(exe.Message);//Error Message
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);//Error Message
            }
            finally
            {
                objconst = null;
            }
        }
        #endregion
    }
}