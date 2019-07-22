using System;

namespace Day_1_2
{
    #region Employee
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- Employee
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- THE CLASS FOR SHOW EMPLOYEE INFORMATION USING CONTROL.
    //      CREATED DATE    :- 2012/12/09
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class Employee : System.Web.UI.Page
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
          Constant.strControlstring = Constant.strSELEMPQRY;
        }
        #endregion Page_Load
        #region btnShwEmp_Click
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- btnShwEmp_Click
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- EVENT FOR MAKE CONTROL VISIBLE .
        //      CREATED DATE    :- 2012/12/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        protected void btnShwEmp_Click(object sender, EventArgs e)
        {
          ucControl.Visible = true;
        }
        #endregion btnShwEmp_Click

    }
    #endregion Employee
}
