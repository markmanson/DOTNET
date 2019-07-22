using System;
using System.Web.UI;

namespace UserControlPage
{
    /// <summary>
    /// Name:ContentFrame
    /// Description:Display Employee Details After Click On Button 
    ///author:Monal Shah
    ///Created Date:210/11/1
    /// </summary>
    public partial class ContentFrame : System.Web.UI.Page
    {
        Commonlogic objcl = new Commonlogic();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #region BtnShowEmployee_Click
        /// <summary>
        /// Name:BtnShowEmployee_Click
        /// Description:Display Employee Details After Click On Button 
        ///author:Monal Shah
        ///Created Date:210/11/1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnShowEmployee_Click(object sender, EventArgs e)
        {
             TableUserControl UserControls;
            try
            {
                pnl.Visible = true;
                UserControls = (TableUserControl)Page.LoadControl("TableUserControl.ascx");
                pnl.GroupingText = ConstantMessage.EmployeePanel;
                UserControls.DATASOURCE = objcl.SelectTable("TblEmpndepartdetails");
                if (UserControls.DATASOURCE.Rows.Count < 2)
                {
                    LblMsg.Visible = true;
                    LblMsg.Text = ConstantMessage.NoRecordFound;
                }
                else
                {
                    LblMsg.Visible = false;
                    pnl.Controls.Add(UserControls);
                }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx", false);
            }
            finally
            {
                UserControls = null;
            }
        }
        #endregion
    }
}
