using System;
using System.Web;
using System.Web.Caching;

namespace DAY9N10Excercise
{
    /// <summary>
    /// Name:CachePage
    /// Description:get the browser information and stored in cache.
    /// Author:Monal shah
    /// Created date:2010/10/27
    /// </summary>
    public partial class CachePage : System.Web.UI.Page
    {
        HttpBrowserCapabilities browser;
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description:get the browser information,Date And File Contents and stored in cache.
        /// Author:Monal shah
        /// Created date:2010/10/27
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                browser = Request.Browser;
                string s = "Browser Capabilities<br>"
                + "Type = " + browser.Type + "<br>"
                + "Name = " + browser.Browser + "<br>"
                + "Version = " + browser.Version + "<br>";
                lblCacheMsg.Text = ConstantMessage.CacheStoreMsg;
                Cache.Insert("StoreCacheValue", s, null, DateTime.Now.AddSeconds(15), TimeSpan.Zero);
                Cache.Insert("Date", DateTime.Today.ToShortDateString(), null, DateTime.Now.AddSeconds(15), TimeSpan.Zero, CacheItemPriority.Default, MyItemRemovedCallBack);
                Cache.Insert("Text", s, new CacheDependency(Server.MapPath("Sample.txt")), DateTime.Now.AddSeconds(5), TimeSpan.Zero);
            }
            finally
            {
                browser = null;
            }
        }
        #endregion
        #region MyItemRemovedCallBack
        /// <summary>
        /// Name:MyItemRemovedCallBack
        /// Description:Remove item from cache
        /// Author:Monal shah
        /// Created date:2010/10/27
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <param name="reason"></param>
        private void MyItemRemovedCallBack(string key, object value, CacheItemRemovedReason reason)
        {
            if (key == "Date")
                Cache.Remove("StoreCacheValue");
        }
        #endregion
    }
}
