using System;
using System.Text;
/// <summary>
/// Namespace Name:ADV_ASP_Day8_9[Ja Folder]
/// Description: Globalization and Localization in ASP.Net
/// Author:Bhumi
/// Created On:16/7/2015
/// </summary>
namespace ADV_ASP_Day8_9.ja
{
    /// <summary>
    /// Class Name:Login
    /// Description: Login Form For Japanese Language
    /// Author:Bhumi
    /// Created On:16/7/2015
    /// </summary>    
    public partial class Login : System.Web.UI.Page
    {
        object UserName_Password_Exist;
        StringBuilder strBrSelectQuery;
        CommonFunction objcommon;
        ConstantMessages objconst;
        #region Page Load
        protected void Page_Load(object sender, EventArgs e)
        {
            LblInvalid.Visible = false;
        }
        #endregion
        #region Submit Button Click
        /// <summary>
        /// Method Name:BtnSubmit_Click
        /// Description: Redirection to the welcome page for authenticate user
        /// Author:Bhumi
        /// Created On:16/7/2015        
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                objcommon = new CommonFunction();
                //Existance in Employees_Temp Table
                strBrSelectQuery = new StringBuilder("SELECT FirstName,LastName ");
                strBrSelectQuery.Append(" FROM Employees_Temp");
                strBrSelectQuery.Append(" WHERE FirstName='" + TxtLoginID.Text + "' COLLATE Latin1_General_CS_AS AND LastName='" + TxtPassword.Text + "' COLLATE Latin1_General_CS_AS ;");
                UserName_Password_Exist = objcommon.ConnectionGenerate(strBrSelectQuery.ToString());
                if (UserName_Password_Exist != null)
                {
                    Session["LoginID"] = TxtLoginID.Text;
                    objconst = new ConstantMessages();
                    Response.Redirect(objconst.strwelcomepage_ja, false);//Redirection
                }
                else
                {
                    LblInvalid.Visible = true;//Invalid User
                }
            }
            catch (Exception)
            {
                objconst = new ConstantMessages();
                Response.Redirect(objconst.strErrorPage);
            }
            finally
            {
                strBrSelectQuery = null;
                objcommon = null;
                objconst = null;
            }
        }
        #endregion
        #region Cancel Button Click Event
        //Cause Validation False Remove text From Control        
        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            TxtLoginID.Text = "";
            TxtPassword.Text = "";
            LblInvalid.Visible = false;
        }
        #endregion
    }
}