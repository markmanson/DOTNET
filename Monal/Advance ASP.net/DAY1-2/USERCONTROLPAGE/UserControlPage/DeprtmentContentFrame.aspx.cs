using System;
using System.Web.UI;

namespace UserControlPage
{
    /// <summary>
    /// Name:DeprtmentContentFrame
    /// Description:Display Department Details After Click On Button 
    ///author:Monal Shah
    ///Created Date:210/11/1
    /// </summary>
    public partial class DeprtmentContentFrame : System.Web.UI.Page
    {
        Commonlogic objCl = new Commonlogic();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #region BtnshowDepartmentdetails_Click
        /// <summary>
        /// Name:BtnshowDepartmentdetails_Click
        /// Description:Display Department Details After Click On Button 
        ///author:Monal Shah
        ///Created Date:210/11/1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnshowDepartmentdetails_Click(object sender, EventArgs e)
        {
            TableUserControl UserControls;
            try
            {
                pnl.Visible = true;
                UserControls = (TableUserControl)Page.LoadControl("TableUserControl.ascx");
                pnl.GroupingText = ConstantMessage.DepartmentPanel;
                UserControls.DATASOURCE = objCl.SelectTable("TblDepartment");
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
