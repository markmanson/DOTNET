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
    /// Class Name:Form_Ex1
    /// Description:Use of Usercontrol in WebForm
    /// Author:Bhumi
    /// Created On:3/7/2015
    /// </summary>
    public partial class Form_Ex1 : System.Web.UI.Page
    {
        #region Page_PreRender Method
        /// <summary>
        /// Method Name:Page_PreRender
        /// Description:set Counter as 0 when first time load the page 
        /// Author:Bhumi
        /// Created On:3/7/2015  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Page_PreRender(object sender, System.EventArgs e)
        {
            TxtCounter.Text = UserControl.ValueCount.ToString();//Set textbox value            
        }
        #endregion
        #region Page Load Event
        /// <summary>
        /// Method Name:Page_PreRender
        /// Description:set Counter after Up Or Down Click 
        /// Author:Bhumi
        /// Created On:3/7/2015  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TxtCounter.Text = UserControl.ValueCount.ToString();//Set textbox value 
            }
        }
        #endregion
    }
}