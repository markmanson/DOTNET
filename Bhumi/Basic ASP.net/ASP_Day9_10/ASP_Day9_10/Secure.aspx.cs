using System;
namespace ASP_Day9_10
{
    /// <summary>
    /// Class Name:Secure
    /// Description:Successfully Login Indication page
    /// Author:Bhumi
    /// Created On:1/7/2015
    /// </summary>
    public partial class Secure : System.Web.UI.Page
    {
        ConstantMessages objconst;
        #region Page Load
        /// <summary>
        /// Method Name:Page_Load
        /// Description:If Successful login completed redirect to this page
        /// Author:Bhumi
        /// Created on:1/7/2015 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                LblMessage.Visible = false;
                if (Session["UserName"] != null)
                {
                    LblMessage.Visible = true;//show message
                }
                else
                {
                    objconst = new ConstantMessages();
                    Response.Redirect(objconst.strLoginpage);//Redirect to login page
                }
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