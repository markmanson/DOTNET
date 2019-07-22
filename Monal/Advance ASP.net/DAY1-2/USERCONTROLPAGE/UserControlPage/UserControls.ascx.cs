using System;

namespace UserControlPage
{
    /// <summary>
    /// Name:UserControls
    /// Description: Initially Text Box display the value 0 .
    ///              If Click on UP then value should increament by 1 and Click on Down then
    ///              value should decreament by  1.
    ///author:Monal Shah
    ///Created Date:210/11/1
    /// </summary>
    public partial class UserControls : System.Web.UI.UserControl
    {
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        ///author:Monal Shah
        ///Created Date:210/11/1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #endregion
        #region BtnUp_Click
        /// <summary>
        /// Name:BtnUp_Click
        /// Description: Initially Text Box display the value 0 .
        ///              If Click on UP then value should increament by 1.
        /// author:Monal Shah
        /// Created Date:210/11/1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnUp_Click(object sender, EventArgs e)
        {
            try
            {
                this.Getcounter = Getcounter + 1;
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx", false);
            }
        }
        #endregion
        #region BtnDown_Click
        /// <summary>
        /// Name:BtnDown_Click
        /// Description: Initially Text Box display the value 0 .
        ///              if Click on Down then
        ///              value should decreament by  1.
        /// author:Monal Shah
        /// Created Date:210/11/1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnDown_Click(object sender, EventArgs e)
        {
            try
            {
                this.Getcounter = Getcounter - 1;
                if (Getcounter == -1)
                {
                    Response.Write("<Script language=javascript>alert('Counter Cannot Be Less Than 0');</Script>");
                    this.Getcounter = 0;
                }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx", false);
            }
        }
        #endregion
        #region GetCounter
        /// <summary>
        /// Name:GetCounter
        /// Description: Get the Current Value and get set counter value
        /// /// author:Monal Shah
        /// Created Date:210/11/1
        /// </summary>
        public int Getcounter
        {
            get { return Convert.ToInt32(ViewState["GetCounterValue"]); }
            set { ViewState["GetCounterValue"] = value; }
        }
        #endregion

    }
}