using System;

namespace Day_1_2
{
    #region Department
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- Department
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- The Class Department WHICH CONTAIN DEPARTMENT INFOMATION.
    //      CREATED DATE    :- 2012/12/09
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class Department : System.Web.UI.Page
    {
        #region Page_Load
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- Page_Load
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- ----------
        //      CREATED DATE    :- 2012/12/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        protected void Page_Load(object sender, EventArgs e)
        {
            Constant.strControlstring = Constant.strSELDEPQRY;
        }
        #endregion Page_Load
        #region GETDEPARTMENT
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- btnGetDepart_Click
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- BTN CLICK EVENT WHIC USE CONTROL TO SHW DEPARTMENT TABLE.
        //      CREATED DATE    :- 2012/12/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        protected void btnGetDepart_Click(object sender, EventArgs e)
        {
          ucControl.Visible = true;
        }
        #endregion GETDEPARTMENT
    }
    #endregion Department
}
