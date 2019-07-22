using System;
using System.Web;
using System.Web.Caching;

namespace Day_9
{
    #region BrowserInfo
    /*************************************************************************************************************
       CLASS NAME                         ::::                    BrowserInfo
       AUTHOR                             ::::                    ANKIT
       DATE                               ::::                    22-07-2012
       DESCRIPTION                        ::::                    TO MAKE A CLASS FOR STORING THE BROWSER INFORMATION INTO CACHE OBJECT
      ************************************************************************************************************/
    public partial class BrowserInfo : System.Web.UI.Page
    {
        #region Page_Load
      /*************************************************************************************************************
      FUNCTION NAME                      ::::                    Page_Load
      AUTHOR                             ::::                    ANKIT
      DATE                               ::::                    22-07-2012
      DESCRIPTION                        ::::                    TO MAKE A PAGE_LOAD EVENT
     ************************************************************************************************************/
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpBrowserCapabilities br;                                 //DECLARATION THE OBJECT OF HTTPBROWSERCAPABILITIES 
            //CacheDependency Depand;
            string strBrowserInfo;                                      //DECLARATION OF A STRING
            string strDate;
            try
            {                
                strDate = DateTime.Now.Date.ToString();
                br = Request.Browser;                                   //INITIALIZATION OF THE OBJECT OF HTTPBROWSERCAPABILITIES
                strBrowserInfo = Constant.strBrwsrInfo + br.Type + Constant.strNewLine;        //ASSIGN THE VALUE OF BROWSER INFO TO STRING
                Cache.Insert(Constant.strCKeyBrws, strDate);//, null, DateTime.Now.AddSeconds(15), Cache.NoSlidingExpiration);   //ADDING THE INFORMATION TO THE CACHE OBJECT
            }
            catch(Exception ex)                                         //IF EXCEPTION IS OCCURES
            {
                Response.Write(ex.Message);                             //SHOWING THE EXCEPTION MESSEGE
            }
            finally
            {
                strBrowserInfo = null;                                  //ASSIGN NULL TO STRING OBJECT
            }
        }
        #endregion Page_Load
    }
    #endregion BrowserInfo
}
