using System;
/// <summary>
///NameSpace:ADO_Day1
/// Description://ADO.Net Day1
/// Author:bhumi
/// Created On:28/5/2015
/// </summary>
namespace ADO_Day1
{
    public partial class Error_Page : System.Web.UI.Page
    {
        #region Error handling
        //Description:Whenever Error Occures in any page Execution redirect over here
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("Error Occured..");//error message
        }
        #endregion
    }
}