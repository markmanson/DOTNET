using System;
using System.Web.UI.HtmlControls;
/// <summary>
/// NamespaceName:ADV_ASP_Day1_2
/// Description: Asp with User Control
/// Author: Bhumi
/// Created On:3/7/2015
/// </summary>
namespace ADV_ASP_Day1_2
{
    /// <summary>
    /// Class Name:Frame_Ex2
    /// Description:Use of Usercontrol in WebForm with Frames
    /// Author:Bhumi
    /// Created On:3/7/2015
    /// </summary>
    public partial class Frame_Ex2 : System.Web.UI.Page
    {
        ConstantMessages objconst;
        #region Page Load
        protected void Page_Load(object sender, EventArgs e)
        {                   
        }
        #endregion
        #region Get Employee Details Click Event
        /// <summary>
        /// Method Name:BtnEmployee_Click
        /// Description:set Employee_Details Page as Source of RightFrame
        /// Author:Bhumi
        /// Created On:6/7/2015  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnEmployee_Click(object sender, EventArgs e)
        {            
            objconst=new ConstantMessages();
            HtmlControl frame3 = (HtmlControl)this.FindControl("RightFrame");//Find Control
            frame3.Attributes["src"] = objconst.strEmployee_DetailsPage;//Give the Source
        }
        #endregion
        #region Get Department Details Click Event
        /// <summary>
        /// Method Name:BtnDepartment_Click
        /// Description:set Department_Details Page as Source of RightFrame
        /// Author:Bhumi
        /// Created On:6/7/2015  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnDepartment_Click(object sender, EventArgs e)
        {
            objconst = new ConstantMessages();
            HtmlControl frame3 = (HtmlControl)this.FindControl("RightFrame");//Find Control
            frame3.Attributes["src"] = objconst.strDepartment_DetailsPage;//Give the Source
        }
        #endregion
    }
}