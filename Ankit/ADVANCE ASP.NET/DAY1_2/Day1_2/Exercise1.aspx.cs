using System;

namespace Day1_2
{
    #region _Default
    /*************************************************************************************************************
    * CLASS NAME                                   :::                     _Default                
    * AUTHOR NAME                                  :::                     ANKIT SHARMA
    * DATE                                         :::                     31/08/2012
    * DESCRIPTION                                  :::                     TO MAKE A CLASS TO INCRESE AN DECRESE THE VALUE OF TEXT BOX
    * **********************************************************************************************************/
    public partial class _Default : System.Web.UI.Page
    {
        #region Page_Load
        /*************************************************************************************************************
      * FUNCTION NAME                                :::                     Page_Load                
      * AUTHOR NAME                                  :::                     ANKIT SHARMA
      * DATE                                         :::                     31/08/2012
      * DESCRIPTION                                  :::                     PAGE LOAD EVENT
      * **********************************************************************************************************/
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Session[Constant.strVal] = 0;                                       //ASSIGN NULL TO SESSION                
            }
        }
        #endregion Page_Load
        #region Page_PreRender
        /*************************************************************************************************************
        * FUNCTION NAME                                :::                     Page_PreRender                
        * AUTHOR NAME                                  :::                     ANKIT SHARMA
        * DATE                                         :::                     31/08/2012
        * DESCRIPTION                                  :::                     PAGE PRE-RENDER EVENT
        * **********************************************************************************************************/
        private void Page_PreRender(object sender, System.EventArgs e)
        {
            if (Session[Constant.strVal] == null)                                   //CHECK IF SESSION IS NULL 
                txtValue.Text =Constant.strInit ;                                   //ASSIGN ZERO TO TEXTBOX
            else                                                                    //IF SESSION IS NOT EQUAL TO NULL
                txtValue.Text = Session[Constant.strVal].ToString();                //ASSIGN SESSION VALUE TO TEXTBOX
        }
        #endregion Page_PreRender
    }
    #endregion _Default
}
