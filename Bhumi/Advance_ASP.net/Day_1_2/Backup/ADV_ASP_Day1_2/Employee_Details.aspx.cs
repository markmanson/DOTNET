using System;
using System.Web.UI;
/// <summary>
/// NamespaceName:ADV_ASP_Day1_2
/// Description: Asp with User Control
/// Author: Bhumi
/// Created On:3/7/2015
/// </summary>
namespace ADV_ASP_Day1_2
{
    /// <summary>
    /// Class Name:Employee_Details
    /// Description:Use of Usercontrol in WebForm
    /// Author:Bhumi
    /// Created On:3/7/2015
    /// </summary>
    public partial class Employee_Details : System.Web.UI.Page
    {
        #region Page Load
        protected void Page_Load(object sender, EventArgs e)
        {
            UserControl.Visible = false;//Make Visible false UserControl
        }
        #endregion
        #region Show Employee Details Click Event
        protected void BtnEmp_Click(object sender, EventArgs e)
        {
            UserControl.Visible = true;//Make Visible true UserControl
        }
        #endregion
    }
}