using System;

namespace Day_9
{
    #region Secure
    /*************************************************************************************************************
         * CLASS NAME                                   :::                     SECURE                
         * AUTHOR NAME                                  :::                     ANKIT SHARMA
         * DATE                                         :::                     27/08/2012
         * DESCRIPTION                                  :::                     CLASS TO MAKE SECURE PAGE 
    * **********************************************************************************************************/
    public partial class Secure : System.Web.UI.Page
    {
        #region Page_Load
        /*************************************************************************************************************
         * FUNCTION NAME                                :::                     Page_Load                
         * AUTHOR NAME                                  :::                     ANKIT SHARMA
         * DATE                                         :::                     27/08/2012
         * DESCRIPTION                                  :::                     PAGE LOAD EVENT 
         * **********************************************************************************************************/
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)                                                    //CHECK IF NOT POSTBACK
            {
                if (Session[Constant.strLoginDeatils] == null)                  //CHECK IF SESSION IS NULL 
                    Response.Redirect(Constant.strDef);                         //DISPLAY THE MESSEGE
                else
                {
                    Response.Write(Constant.strWlcm + Session[Constant.strLoginDeatils].ToString() + Constant.strSecMsg);   //DISPLAY THE WELCOME MESSEGE 
                    Session[Constant.strLoginDeatils] = null;                   //ASSIGN NULL TO SESSION
                }
            }
        }
        #endregion Page_load
    }
    #endregion Secure
}
