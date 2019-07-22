using System;

namespace ExerciseProject.Day5
{
    /// <summary>
    /// Name:Error.aspx
    /// Description:"Error will be displayed here"
    /// Author:Monal Shah
    /// Created Date:2010/09/30
    public partial class Error : System.Web.UI.Page
    {
        ConstantMessage objConstant = new ConstantMessage();
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description:Error will be displayed
        /// Author:Monal Shah
        /// Created Date:2010/09/30
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            LblErrorMessageId.Visible = true;
            LblErrorMessageId.Text = objConstant.ErrorMessage;
          //  Response.Write("Error Occured.Please contact administrator");
        }
        #endregion
    }
}
