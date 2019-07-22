using System;
/// <summary>
///NameSpace:ADO_Day2_4
/// Description://ADO.Net Day2 to Day4
/// Author:bhumi
/// Created On:29/5/2015
/// </summary>
namespace ADO_Day2_4
{
    public partial class Error_Page : System.Web.UI.Page
    {
        #region Error handling
        //Description:Whenever Error Occures in any page Execution redirect over here
        ConstantMessages objconstmsg;
        protected void Page_Load(object sender, EventArgs e)
        {
            objconstmsg = new ConstantMessages();
            Response.Write(objconstmsg.strerrormessage);//error message
        }
        #endregion
    }
}