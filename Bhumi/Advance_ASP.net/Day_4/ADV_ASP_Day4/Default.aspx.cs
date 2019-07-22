using System;
/// <summary>
/// NamespaceName:ADV_ASP_Day4
/// Description: Asp with Composite Rendered Custom Control
/// Author: Bhumi
/// Created On:8/7/2015
/// </summary>
namespace ADV_ASP_Day4
{
    /// <summary>
    /// Class Name:Default
    /// Description:Use of Custom Rendered Control in WebForm
    /// Author:Bhumi
    /// Created On:8/7/2015
    /// </summary>
    public partial class Default : System.Web.UI.Page
    {
        ConstantMessages objconst;        
        #region Page Load
        /// <summary>
        /// Method Name:Page_Load
        /// Description:Set Visible False Label Controls
        /// Author:Bhumi
        /// Created On:8/7/2015
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            LblClick.Visible = false;            
        }
        #endregion
        #region Cast Your Vote Click Event
        /// <summary>
        /// Method Name:Submit_Click
        /// Description:Indicate Click Event Using Label
        /// Author:Bhumi
        /// Created On:8/7/2015
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                objconst = new ConstantMessages();
                LblClick.Visible = true;
                LblChange.Text = "";
                LblClick.Text = objconst.strClick;
                //LblChange.Visible = false;  
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                objconst = null;
            }
                      
        }
        #endregion
        #region Radio Button Checked Event
        /// <summary>
        /// Method Name:Checked_Change
        /// Description:Indicate Radio Button Checked Event Using Label
        /// Author:Bhumi
        /// Created On:8/7/2015
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Checked_Change(object sender, EventArgs e)
        {
            try
            {
                objconst = new ConstantMessages();
                LblChange.Text = objconst.strRateChange;
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                objconst = null;
            }
        }
        #endregion
    }
}