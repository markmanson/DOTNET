using System;
using System.Data;
using System.Text;
using System.Web.UI;

namespace DAY9N10Excercise
{
    /// <summary>
    /// Name:Login
    /// Description:Enter Login Details if user is authenticated then details are stored in session.and page is redirected. 
    /// Author:Monal shah
    /// Created Date:2010/10/28
    /// </summary>
    public partial class Login : System.Web.UI.Page
    {
        StringBuilder objSb;
        Commonlogic objcl = new Commonlogic();
        DataTable objDt = new DataTable();
        #region Page_Load
        /// <summary>
        /// Name:Login
        /// Description:Only set Focus on textbox and set submit button as default button.
        /// Author:Monal shah
        /// Created Date:2010/10/28
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
                Page.Form.DefaultButton = BtnSubmit.UniqueID;
                TxtUserId.Focus();           
        }
        #endregion
        #region BtnSubmit_Click
        /// <summary>
        /// Name:BtnSubmit_Click
        /// Description:Enter Login Details if user is authenticated then details are stored in session.and page is redirected. 
        /// Author:Monal shah
        /// Created Date:2010/10/28
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            objSb = new StringBuilder();
            try
            {
                objSb.Append("Select ");
                objSb.Append("* ");
                objSb.Append("From ");
                objSb.Append("TblLogin ");
                objSb.Append("Where ");
                objSb.Append("UserId");
                objSb.Append("=");
                objSb.Append("'");
                objSb.Append(TxtUserId.Text);
                objSb.Append("'");
                objSb.Append(" AND ");
                objSb.Append("PasswordValue ");
                objSb.Append("=");
                objSb.Append("'");
                objSb.Append(TxtPwd.Text);
                objSb.Append("'");
                objcl.GetSqlStmt = objSb.ToString();
                objDt = objcl.DataTables();
                if (objDt.Rows.Count > 0)
                {
                    Session["UserID"] = TxtUserId.Text;
                    Session["Password"] = TxtPwd.Text;
                    Response.Redirect("Secure.aspx",false);
                }
                else
                {
                    LblWelcome.Visible = true;
                    LblWelcome.Text = ConstantMessage.EnterRightValue;
                    TxtUserId.Text = string.Empty;
                    TxtPwd.Text = string.Empty;
                }
            }
            catch (Exception)
            {
                Response.Redirect("ErrorPage.aspx",false);
            }
            finally
            {
                objSb = null;
                objcl = null;
                objDt.Dispose();
            }
        }
        #endregion
        #region BtnReset_Click
        /// <summary>
        /// Name:BtnReset_Click
        /// Description:Reset All Controls. 
        /// Author:Monal shah
        /// Created Date:2010/10/28
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnReset_Click(object sender, EventArgs e)
        {
            LblWelcome.Visible = false;
            TxtUserId.Text = string.Empty;
            TxtPwd.Text = string.Empty;
        }
        #endregion
    }
}
