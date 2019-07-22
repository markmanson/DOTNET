using System;

namespace Day1_2
{
    #region Department
    /*************************************************************************************************************
    * CLASS NAME                                   :::                     Department                
    * AUTHOR NAME                                  :::                     ANKIT SHARMA
    * DATE                                         :::                     03/09/2012
    * DESCRIPTION                                  :::                     TO MAKE A CLASS WHICH CONTAINS THE USERWEBCONTROL
    * **********************************************************************************************************/
    public partial class Department : System.Web.UI.Page
    {
        #region btnGetDepart_Click
        /*************************************************************************************************************
        * FUNCTION NAME                                :::                     btnGetDepart_Click                
        * AUTHOR NAME                                  :::                     ANKIT SHARMA
        * DATE                                         :::                     03/09/2012
        * DESCRIPTION                                  :::                     CLICK EVENT OF BUTTON GETDEPARTMENT
        * **********************************************************************************************************/
        protected void btnGetDepart_Click(object sender, EventArgs e)
        {
            Place.Controls.Add(LoadControl(Constant.strWebGrid));               //ADD USER CONTROL GRID TO PAGE
        }
        #endregion btnGetDepart_Click
    }
    #endregion Department
}
