using System;

namespace Day1_2
{
    #region Employees
    /*************************************************************************************************************
    * CLASS NAME                                   :::                     Employees                
    * AUTHOR NAME                                  :::                     ANKIT SHARMA
    * DATE                                         :::                     03/09/2012
    * DESCRIPTION                                  :::                     TO MAKE A CLASS WHICH CONTAINS THE BUTTON AND WEBUSERCONTROL
    * **********************************************************************************************************/
    public partial class Employees : System.Web.UI.Page
    {
        #region btnGetEmployees_Click
        /*************************************************************************************************************
       * FUNCTION NAME                                :::                     btnGetEmployees_Click                
       * AUTHOR NAME                                  :::                     ANKIT SHARMA
       * DATE                                         :::                     03/09/2012
       * DESCRIPTION                                  :::                     CLICK EVENT OF BUTTON GETEMPLOYEES
       * **********************************************************************************************************/
        protected void btnGetEmployees_Click(object sender, EventArgs e)
        {
            Place.Controls.Add(LoadControl(Constant.strWebGrid));               //ADD USERCONTROL GRID TO PAGE
        }
    #endregion btnGetEmployees_Click
    }
    #endregion Employees
}
