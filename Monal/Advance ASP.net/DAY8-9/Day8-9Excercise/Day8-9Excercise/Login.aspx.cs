using System;
using System.Data;

namespace Day8_9ExcerobjCultureInfose
{
    /// <summary>
    /// Name:Login
    /// Description:Select Language depends on selected language Login Page display.
    /// Author:Monal Shah
    /// created date:2010/11/19
    /// </summary>
    public partial class Login : System.Web.UI.Page
    {
        string QuerystringValue;
        DataTable dtUsers;       
        Commonlogic objcl = new Commonlogic();
        #region Page_Load
        /// <summary>
        /// Name:Login
        /// Description:Select Language depends on selected language Login Page display which is set from resource file.
        /// Author:Monal Shah
        /// created date:2010/11/19
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            TxtName.Focus();            
            if (Request.QueryString["id"] != null)
            {
                QuerystringValue = Request.QueryString["id"].ToString();
                LoginPanel.GroupingText = (string)GetGlobalResourceObject(QuerystringValue, "LoginPanel");
                LblHeading.Text = (string)GetGlobalResourceObject(QuerystringValue, "LblHeading");
                LblName.Text = (string)GetGlobalResourceObject(QuerystringValue, "LblName");
                LblPwd.Text = (string)GetGlobalResourceObject(QuerystringValue, "LblPwd");
                BtnSubmit.Text = (string)GetGlobalResourceObject(QuerystringValue, "BtnSubmit");
                BtnCancel.Text = (string)GetGlobalResourceObject(QuerystringValue, "BtnCancel");
            }
        }
        #endregion
        #region BtnSubmit_Click
        /// <summary>
        /// Name:BtnSubmit_Click
        /// Description:If User Id and password is correct then redirected to  welcome.aspx page.
        /// Author:Monal Shah
        /// created date:2010/11/19
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            dtUsers = new DataTable();
            try
            {
                objcl.GetSqlStmt = objcl.SelectQuery("TblLogin", "UserId", TxtName.Text, "PasswordValue", TxtPwd.Text);
                dtUsers = objcl.DataTables();
                if (dtUsers.Rows.Count > 0)
                {
                    if (dtUsers.Rows[0]["UserId"].ToString() == TxtName.Text && dtUsers.Rows[0]["PasswordValue"].ToString() == TxtPwd.Text)
                        Response.Redirect("Welcome.aspx?id=" + TxtName.Text + "," + QuerystringValue, false);
                }
                else
                {
                    LblMsg.Visible = true;
                    LblMsg.Text = (string)GetGlobalResourceObject(QuerystringValue, "LblMsg");
                }

            }
            catch (Exception)
            { Response.Redirect("Error.aspx", false); }
            finally
            {

                dtUsers.Dispose();
                objcl = null;
            }
        }
        #endregion
        #region BtnCancel_Click
        /// <summary>
        /// Name:BtnCancel_Click
        /// Description:Reset Controls
        /// Author:Monal Shah
        /// created date:2010/11/19
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            TxtName.Text = string.Empty;
            TxtPwd.Text = string.Empty;
        }
        #endregion
    }
}
