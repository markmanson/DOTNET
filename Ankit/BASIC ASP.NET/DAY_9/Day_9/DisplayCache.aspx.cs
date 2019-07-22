using System;
using System.Web.Caching;
namespace Day_9
{
    #region DisplayCache
    /*************************************************************************************************************
       CLASS NAME                         ::::                    DisplayCache
       AUTHOR                             ::::                    ANKIT
       DATE                               ::::                    22-07-2012
       DESCRIPTION                        ::::                    TO MAKE A CLASS FOR SHOWING THE CACHE OBJECT
      ************************************************************************************************************/
    public partial class DisplayCache : System.Web.UI.Page
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
            Show();
        }
        #endregion Page_Load
        protected void btnCache_Click(object sender, EventArgs e)
        {            
            Show();
            Cache.Insert(Constant.strCKeyBrws,DateTime.Now.Date.ToString(), null, DateTime.Now.AddSeconds(15), Cache.NoSlidingExpiration);   //ADDING THE INFORMATION TO THE CACHE OBJECT
        }
        public void Show()
        {
            try
            {
                if (Cache[Constant.strCKeyBrws] == null)                                    //CHECK IF CACHE IS NULL
                    lblCache.Text = Constant.strCEmptyMsg;                                  //SHOW MESSEGE THAT CACHE IS EMPTY
                else                                                                        //IF CACHE IS NOT NULL
                    lblCache.Text = Cache[Constant.strCKeyBrws].ToString();                 //SHOW THE VALUE OF CACHE INTO A LABEL
            }
            catch                                                                           //IF EXCEPTION OCCURES
            {
                Response.Redirect(Constant.strError);                                       //REDIRECT TO ERROR.ASPX
            }         
        }
    }
    #endregion DisplayCache
}
