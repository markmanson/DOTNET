using System;

namespace ExerciseProject.DAY2
{
    /// <summary>
    /// Name:Error.aspx
    /// Description:"Error will be displayed here"
    /// Author:Monal Shah
    /// Created Date:2010/09/21
    public partial class Error : System.Web.UI.Page
    {
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description:Error will be displayed
        /// Author:Monal Shah
        /// Created Date:2010/09/21
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Error Occured.Please contact administrator");
        }
        #endregion
    }
}
