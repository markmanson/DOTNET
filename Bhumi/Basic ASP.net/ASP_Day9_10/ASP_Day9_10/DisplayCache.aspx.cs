using System;
/// <summary>
/// NamespaceName:ASP_Day9_10
/// Description: Display the Values from Cache Object
/// Author: Bhumi
/// Created On:1/7/2015
/// </summary> 
namespace ASP_Day9_10
{
    /// <summary>
    /// Class Name:DisplayCache
    /// Description:Display the Value of Cache Object
    /// Author:Bhumi
    /// Created On:1/7/2015
    /// </summary>
    public partial class DisplayCache : System.Web.UI.Page
    {
        #region Page Load
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #endregion
        #region Display Data From Cache
        /// <summary>
        /// Method Name:BtnDisplay_Click
        /// Description:Stored information of browser in Cache Objects Display On Web Page
        /// Author:Bhumi
        /// Created on:1/7/2015 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnDisplay_Click(object sender, EventArgs e)
        {
            ConstantMessages objconst;
            try
            {
                objconst = new ConstantMessages();
                if ((Cache["Name"]as string) != null && (Cache["Version"] as string) != null)
                {
                    Response.Write(objconst.strBrowserName + " <B>" + Server.HtmlEncode(Cache["Name"] as string) + "</B><br/>");//Browser name
                    Response.Write(objconst.strBrowserVersion + " <B>" + Server.HtmlEncode(Cache["Version"] as string) + "</B><br/>");//Version                    
                }
                if ((Cache["CurrentDate"] as string) != null)
                {
                    Response.Write(objconst.strCurrentDate + " <B>" + Server.HtmlEncode(Cache["CurrentDate"] as string) + "</B>");//Date
                }
                if ((Cache["Name"] as string) == null && (Cache["Version"] as string) == null && (Cache["CurrentDate"] as string) == null)
                {
                    Response.Write(objconst.strEmptyCache);//Null Cache Objects 
                }                
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
    }
}