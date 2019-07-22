using System;
namespace Day5
{
    #region _Default
    /********************************************************************************************************************************************
       * CLASS NAME                                   :::                     _DEFAULT               
       * AUTHOR NAME                                  :::                     ANKIT SHARMA
       * DATE                                         :::                     13/09/2012
       * DESCRIPTION                                  :::                     TO MAKE A CLASS TO CHECK THE DIFFERENCE OF SERVER SIDE AND CLIENT SIDE DATE
       * ******************************************************************************************************************************************/
    public partial class _Default : System.Web.UI.Page
    {
        #region Page_Load
        /********************************************************************************************************************************************
     * FUNCTION NAME                                :::                     PAGE_LOAD               
     * AUTHOR NAME                                  :::                     ANKIT SHARMA
     * DATE                                         :::                     13/09/2012
     * DESCRIPTION                                  :::                     PAGE LOAD EVENT OF WEB PAGE(TO SHOW THE SERVER SIDE AND CLIENT SIDE DATE_TIME)
     * ******************************************************************************************************************************************/
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write(Constant.strServrTime+DateTime.Now);                     //DISPLAY THE SERVER TIME   
        }
        #endregion Page_Load
    }
    #endregion _Default
}
