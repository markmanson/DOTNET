using System;
/// <summary>
/// NamespaceName:ASP_Day5
/// Description: Basic ASP.Net study
/// Author: Bhumi
/// Created On:22/6/2015
/// </summary>
namespace ASP_Day5
{
    /// <summary>
    /// Class Name:Information
    /// Description:Display Value of QueryString
    /// Author:Bhumi
    /// Created On:22/6/2015
    /// </summary>    
    public partial class Information : System.Web.UI.Page
    {
        ConstantMessages objconstant;
        string QuerystringVal;
        string[] splitVal;
        #region Page Load Event
        /// <summary>
        /// Method Name:Page_Load
        /// Description:Get the Value From Querystring and store into textboxes
        /// Author:Bhumi
        /// Created On:22/6/2015
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //get the value from querystring
                TxtName.Text = Request.QueryString["Name"];
                TxtSex.Text = Request.QueryString["Sex"];
                TxtEmail.Text = Request.QueryString["Email"];
                TxtDOB.Text = Request.QueryString["DOB"];
                TxtFaxNo.Text = Request.QueryString["FaxNo"];
                TxtMarried.Text = Request.QueryString["Married"];
                QuerystringVal = Request.QueryString["LanguageKnown"];
                splitVal = QuerystringVal.Split(',');//Split using delimeter
                TxtLanguage.Text = string.Join(",", splitVal);
            }
            catch (Exception)
            {
                objconstant = new ConstantMessages();
                Response.Redirect(objconstant.strUserDetailspage);
            }
            finally
            {
                objconstant = null;
                splitVal = null;
            }
        }
        #endregion
    }
}