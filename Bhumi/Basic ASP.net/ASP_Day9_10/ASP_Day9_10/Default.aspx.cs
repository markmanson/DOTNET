using System;
using System.Web;
using System.Web.Caching;
/// <summary>
/// NamespaceName:ASP_Day9_10
/// Description: Store the Values in Cache Object
/// Author: Bhumi
/// Created On:1/7/2015
/// </summary> 
namespace ASP_Day9_10
{
    /// <summary>
    /// Class Name:Default
    /// Description:Store the Info of Browser in Cache Object
    /// Author:Bhumi
    /// Created On:1/7/2015
    /// </summary>
    public partial class Default : System.Web.UI.Page
    {
        CacheDependency cacheDepn;
        HttpBrowserCapabilities browser;
        #region Page Load
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #endregion
        #region Store Data in Cache Button Click Event
        /// <summary>
        /// Method Name:Btnstore_Click
        /// Description:Store information of browser in Cache Objects
        /// Author:Bhumi
        /// Created on:1/7/2015 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Btnstore_Click(object sender, EventArgs e)
        {
            try
            {
                browser = Request.Browser;
                Cache["Name"] = browser.Browser;
                Cache["Version"] = browser.Version;
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                browser = null;
            }
        }
        #endregion
        #region Expire Name & Version
        /// <summary>
        /// Method Name:BtnExpire_Click
        /// Description:Expire Name & Version From Cache Objects
        /// Author:Bhumi
        /// Created on:1/7/2015 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        protected void BtnExpire_Click(object sender, EventArgs e)
        {
            try
            {
                browser = Request.Browser;
                Cache.Insert("Name", browser.Browser,
                            null, DateTime.Now.AddSeconds(15),
                            System.Web.Caching.Cache.NoSlidingExpiration);
                Cache.Insert("Version", browser.Version,
                            null, DateTime.Now.AddSeconds(15),
                            System.Web.Caching.Cache.NoSlidingExpiration);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                browser = null;
            }
        }
        #endregion
        #region Add Date in Cache
        /// <summary>
        /// Method Name:BtnDate_Click
        /// Description:Current Date Cache Object
        /// Author:Bhumi
        /// Created on:1/7/2015 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>  
        protected void BtnDate_Click(object sender, EventArgs e)
        {
            Cache["CurrentDate"] = DateTime.Now.Date.ToString("d");
        }
        #endregion
        #region Upadate Date
        /// <summary>
        /// Method Name:BrtnUpdateDate_Click
        /// Description:update Current Date Cache Object and expire other object
        /// Author:Bhumi
        /// Created on:1/7/2015 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>  
        protected void BrtnUpdateDate_Click(object sender, EventArgs e)
        {
            try
            {
                Cache.Insert("CurrentDate", DateTime.Now.Date.AddDays(1).ToString("d"));
                string[] cacheKeys = { "CurrentDate" };
                cacheDepn = new CacheDependency(null, cacheKeys);
                Cache.Insert("Name", cacheDepn);
                Cache.Insert("Version", cacheDepn);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                browser = null;
                cacheDepn = null;
            }           
        }
        #endregion
        #region Cache Dependency on file
        /// <summary>
        /// Method Name:BtnFileDepend_Click
        /// Description:Dependency of cache object on File(.txt)
        /// Author:Bhumi
        /// Created on:1/7/2015 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>          
        protected void BtnFileDepend_Click(object sender, EventArgs e)
        {
            try
            {
                cacheDepn = new CacheDependency(Server.MapPath("a.txt"));
                Cache.Insert("Name", cacheDepn);
                Cache.Insert("Version", cacheDepn);
                Cache.Insert("CurrentDate", cacheDepn);
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                browser = null;
                cacheDepn = null;
            }            
        }
        #endregion
    }
}