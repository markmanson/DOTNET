using System;
using System.IO;
using System.Configuration;
/// <summary>
/// Namespace Name:ADV_ASP_Day12_13
/// Description: Export Or Upload Data in ASP.NET
/// Author:Bhumi
/// Created On:22/7/2015
/// </summary>    
namespace ADV_ASP_Day12_13
{
    /// <summary>
    /// Class Name:UploadFile
    /// Description:Upload Excel File
    /// Author:bhumi
    /// Created on:22/7/2015
    /// </summary> 
    public partial class UploadFile : System.Web.UI.Page
    {
        ConstantMessages objconst;
        #region Page Load
        protected void Page_Load(object sender, EventArgs e)
        {            
        }
        #endregion
        #region Upload Button Click Event
        /// <summary>
        /// method name:BtnUpload_Click
        /// Description: Upload The Excel File and Save In Specific Path Which assign in web.config
        /// Author:bhumi
        /// Created On:21/7/2015
        /// </summary>  
        protected void BtnUpload_Click(object sender, EventArgs e)
        {
            string filePath, fileName;
            try
            {
                //check to make sure a file is selected
                if (InpFileUpload.HasFile)
                {
                    if (hdnTestValue.Value == "T")
                    {
                        //create the path to save the file to
                        filePath = ConfigurationManager.AppSettings["Path"].ToString();
                        fileName = Path.Combine(Server.MapPath(filePath), InpFileUpload.FileName);
                        //save the file to our path
                        InpFileUpload.SaveAs(fileName);
                        objconst = new ConstantMessages();
                        ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "alert('" + objconst.strFileUploadSuccessfully + "');", true);
                    }
                }
            }
            catch (Exception)
            {
                objconst = new ConstantMessages();
                Response.Redirect(objconst.strErrorPage);//Error Page
            }
            finally
            {
                objconst = null;
            }
        }
        #endregion
    }
}