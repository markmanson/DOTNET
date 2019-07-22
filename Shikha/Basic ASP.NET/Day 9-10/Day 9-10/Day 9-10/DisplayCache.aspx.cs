using System;
using System.Web.Caching;

namespace Day_9_10
{
    #region DisplayCache
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- DisplayCache
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- The Class For DisplayCache.
    //      CREATED DATE    :- 2012/06/09
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class DisplayCache : System.Web.UI.Page
    {
       #region Page_Load
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- Page_Load
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- The Page_Load For show() that display Browser info on label  .
        //      CREATED DATE    :- 2012/06/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        protected void Page_Load(object sender, EventArgs e)
        {
            Show();
        }
        #endregion Page_Load
        #region Show
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- Show()
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- The Show method for show browser information on lable.
        //      CREATED DATE    :- 2012/06/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        public void Show()
        {
            try
            {
                if (Cache[Constant.strBRSRINFO] == null)                               //CHECK IF CACHE IS NULL
                    lblCache.Text = Constant.strCACHE_EMPTY;                           //SHOW MESSEGE THAT CACHE IS EMPTY
                else                                                                  //IF CACHE IS NOT NULL
                    lblCache.Text = Cache[Constant.strBRSRINFO].ToString();                 //SHOW THE VALUE OF CACHE INTO A LABEL
                if (Cache[Constant.strFILE] == null)

                    lblFile.Text = Constant.strCACHE_EMPTY;                      // Display Cache is empty
                else

                    lblFile.Text = Cache[Constant.strFILE].ToString();                      // Display Data
            }
            catch                                                                           //IF EXCEPTION OCCURES
            {
                Response.Redirect(Constant.strERRORPAGE);                                       //REDIRECT TO ERROR.ASPX
            }
        }

        #endregion Show
        #region btnCache_Click
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- btnCache_Click
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- The On btnCache click insert cache information.
        //      CREATED DATE    :- 2012/06/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        protected void btnCache_Click(object sender, EventArgs e)
        {
            if (Cache[Constant.strDATE] != null)
            {
                string startDate = DateTime.Now.AddDays(1).ToString();       //Update Current Date   
                Cache.Insert(Constant.strDATE, startDate);                  // Add Date Into Cache Object
                lblDate.Text = startDate;                                    // Display Current Updated Date
                Show();

            }
        } 
        #endregion btnCache_Click
       
    }
    #endregion DisplayCache
}
