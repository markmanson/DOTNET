using System;

namespace Day_1_2
{
    #region Details
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- Details
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- THE CLASS WHICH CONTAIN TWO BUTTONS FOR SHOW EMPLOYEE AND DEPARTMENT INFORMATION IN A FRAME.
    //      CREATED DATE    :- 2012/12/09
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class Details : System.Web.UI.Page
    {
        #region Page_Load
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- Page_Load
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- ---------
        //      CREATED DATE    :- 2012/12/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #endregion Page_Load
        #region Getbtn_Click
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- Getbtn_Click
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- THIS CLICK EVENT ADD SRC ATRRIBUTE TO IFRAME FOR EMPLOYEE PAGE.
        //      CREATED DATE    :- 2012/12/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        protected void Getbtn_Click(object sender, EventArgs e)
        {
          Frame1.Attributes[Constant.strSRC] =Constant.strEMPLOYEE;
         
        }
        #endregion Getbtn_Click
        #region btnGetDetails_Click
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- btnGetDetails_Click
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- THIS CLICK EVENT ADD SRC ATRRIBUTE TO IFRAME FOR DEPARTMENT PAGE.
        //      CREATED DATE    :- 2012/12/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        protected void btnGetDetails_Click(object sender, EventArgs e)
        {
            //string strDetails = Constant.strDETAILS;
            Frame1.Attributes[Constant.strSRC] = Constant.strDEPARTMENT;
            //Session[Constant.strEMP] = strDetails;
        }
        #endregion btnGetDetails_Click

    }
    #endregion Details
}
