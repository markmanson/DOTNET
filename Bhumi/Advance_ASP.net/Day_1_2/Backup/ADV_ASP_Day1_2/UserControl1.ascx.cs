using System;
/// <summary>
/// NamespaceName:ADV_ASP_Day1_2
/// Description: Asp with User Control
/// Author: Bhumi
/// Created On:3/7/2015
/// </summary>
namespace ADV_ASP_Day1_2
{
    /// <summary>
    /// Class Name:UserControl1
    /// Description:Use of Usercontrol in ASP.NET
    /// Author:Bhumi
    /// Created On:3/7/2015
    /// </summary>
    public partial class UserControl1 : System.Web.UI.UserControl
    {
        ConstantMessages objconstant;
        #region Property For Counter
        //Set & Get Incremented Or Decremented Values Of Counter
        public int ValueCount
        {            
            get
            {
                // Return the Value.
                return Convert.ToInt32(ViewState["Value"]);
            }
            set
            {
                // Set the Value.
                ViewState["Value"] = value;
            }
        }
        #endregion
        #region Page Load
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #endregion
        #region UP Button Click Event
        /// <summary>
        /// Method Name:BtnUp_Click
        /// Description:Increment Counter By 1 
        /// Author:Bhumi
        /// Created On:3/7/2015 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BtnUp_Click(object sender, EventArgs e)
        {
            // Increment the Value.
            ValueCount += 1;            
        }
        #endregion
        #region Down Click Event
        /// <summary>
        /// Method Name:BtnDown_Click
        /// Description:Decrement Counter By 1 
        /// Author:Bhumi
        /// Created On:3/7/2015          
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void BtnDown_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValueCount > 0)
                {
                    // Decrement the Value.
                    ValueCount -= 1;
                }
                else
                {
                    objconstant = new ConstantMessages();
                    Page.ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "alert('" + objconstant.strDownAlert + "');", true);
                }
            }
            catch (Exception)
            {
                objconstant = new ConstantMessages();
                Response.Redirect(objconstant.strErrorPage, false);
            }
            finally
            {
                objconstant = null;
            }
        }
        #endregion
    }
}