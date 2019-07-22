using System;

namespace DAY9N10Excercise
{
    /// <summary>
    /// Name:DisplayCache
    /// Description:get the browser information by cache.
    /// Author:Monal shah
    /// Created date:2010/10/27
    /// </summary>
    public partial class DisplayCache : System.Web.UI.Page
    {
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description:get the browser information by cache.
        /// Author:Monal shah
        /// Created date:2010/10/27
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowValue();
        }
        #endregion
        #region ShowValue
        /// <summary>
        /// Name:ShowValue
        /// Description:get the browser information by cache.
        /// Author:Monal shah
        /// Created date:2010/10/27
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowValue()
        {
            if (Cache["StoreCacheValue"] != null)
            {
                lblCacheMsg.Text = Convert.ToString(Cache["StoreCacheValue"]);
            }
            else
            {
                lblCacheMsg.Text = ConstantMessage.CacheMsg;
            }
        }
        #endregion
        #region BtnAddCache_Click
        /// <summary>
        /// Name:BtnAddCache_Click
        /// Description:On clicking this button the current date should be updated in the cache.
        ///             Verify if the browser info stored in the cash expires on clicking the button.
        /// Author:Monal shah
        /// Created date:2010/10/27
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnAddCache_Click(object sender, EventArgs e)
        {
            if (Cache["Date"] != null)
            {
                string UpdateDate = DateTime.Today.AddDays(1).ToString();
                Cache.Insert("Date", UpdateDate, null, DateTime.Now.AddMinutes(5), TimeSpan.Zero);
                LblDate.Text =ConstantMessage.UpdatedDate+UpdateDate.ToString();
                ShowValue();              
            }
        }
        #endregion
    }
}
