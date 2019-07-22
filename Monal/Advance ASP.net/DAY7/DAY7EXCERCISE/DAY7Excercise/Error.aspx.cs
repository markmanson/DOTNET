using System;

namespace DAY7Excercise
{
    public partial class Error : System.Web.UI.Page
    {
        /// <summary>
        /// Name:Page_Load
        /// Description:Error Display when error occured in any page of application
        /// Author:Monal shah
        /// Created Date:2010/11/16
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            LblMsg.Text = ConstantMessage.Error;
        }
    }
}
