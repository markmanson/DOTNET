using System;
/// <summary>
/// Namespace Name:ADO_Day5_9
/// Description: Typed Dataset,Gridview Databinding and Its Feature & Validation
/// Author:Bhumi
/// Created On:8/6/2015
/// </summary>
namespace ADO_Day5_9
{
    /// <summary>
    /// Class Name:Error_Page
    /// Description: Redirect to this Page while error generate
    /// </summary>
    public partial class Error_Page : System.Web.UI.Page
    {
        #region Error handling
        ConstantMessages objconst;
        //Description:Whenever Error Occures in any page Execution redirect over here
        protected void Page_Load(object sender, EventArgs e)
        {
            objconst = new ConstantMessages();
            Response.Write(objconst.strerrormessage);//error message
        }
        #endregion
    }    
}