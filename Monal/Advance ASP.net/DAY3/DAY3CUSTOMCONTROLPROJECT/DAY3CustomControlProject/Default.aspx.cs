using System;
using System.Data;
using System.Text;

namespace DAY3CustomControlProject
{
    /// <summary>
    /// Name:Default
    /// Description:Use Custom Control and display authorised user if user is authorised.if not then display unauthorized user.
    /// Author:Monal Shah
    /// Created Date:2010/11/9
    /// </summary>
    public partial class _Default : System.Web.UI.Page
    {
        Commonlogic objcl = new Commonlogic();
        DataTable objDt;
        StringBuilder objSb;
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description:Set Focus
        /// Author:Monal Shah
        /// Created Date:2010/11/9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            ServerControl1.Focus();
        }
        #endregion
        #region BtnSubmit_Click
        /// <summary>
        /// Name:BtnSubmit_Click
        /// Description:Use Custom Control and display authorised user if user is authorised.if not then display unauthorized user.
        /// Author:Monal Shah
        /// Created Date:2010/11/9
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            objSb = new StringBuilder();

            if (ServerControl1.txtLoginID == "" || ServerControl1.txtPassword == "")
            {
                ServerControl1.Message = ConstantMessage.EnterValue;
            }
            else
            {
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
                    objSb.Append(ServerControl1.txtLoginID);
                    objSb.Append("'");
                    objSb.Append(" AND ");
                    objSb.Append("PasswordValue ");
                    objSb.Append("=");
                    objSb.Append("'");
                    objSb.Append(ServerControl1.txtPassword);
                    objSb.Append("'");
                    objcl.GetSqlStmt = objSb.ToString();
                    objDt = new DataTable();
                    objDt = objcl.DataTables();
                    if (objDt.Rows.Count > 0)
                    {
                        ServerControl1.Message = ConstantMessage.LoginWelcome;
                        ServerControl1.txtLoginID = string.Empty;
                        ServerControl1.txtPassword = string.Empty;
                    }
                    else
                    {
                        ServerControl1.Message = ConstantMessage.EnterRightValue;
                        ServerControl1.txtLoginID = string.Empty;
                        ServerControl1.txtPassword = string.Empty;
                    }
                }
                catch (Exception)
                {
                    Response.Redirect("ErrorPage.aspx", false);
                }
                finally
                {
                    objSb = null;
                    objcl = null;
                    objDt.Dispose();
                }
            }

        }
        #endregion
    }
}
