using System;
using System.Data;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DAY5EXercise
{
    public partial class Excercise7 : System.Web.UI.Page
    {
        Commonlogic objcl = new Commonlogic();
        DataTable objDt;
        ListItemCollection EmployeeListItem = new ListItemCollection();

        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Decription:Bind dropdown.
        /// Author:Monal shah
        /// Created Date:2010/11/11
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Form.DefaultButton = BtnDisplay.UniqueID;
            if (!IsPostBack)
            {
                try
                {
                    if (Cache["EmployeeList"] == null)
                    { BindDropDown(); }
                    else
                    {
                        EmployeeListItem = (ListItemCollection)Cache["EmployeeList"];
                        foreach (ListItem itmEmployeetList in EmployeeListItem)
                            DdlEmployee.Items.Add(itmEmployeetList);
                    }
                }
                catch (Exception)
                { Response.Redirect("Error.aspx", false); }
                finally
                { EmployeeListItem = null; }
            }
        }
        #endregion
        #region BindDropDown
        /// <summary>
        /// Name:BindDropDown
        /// Decription:Bind dropdown.
        /// Author:Monal shah
        /// Created Date:2010/11/11
        /// </summary>       
        private void BindDropDown()
        {
            try
            {
                objDt = new DataTable();
                objcl.GetSqlStmt = objcl.SelectQuery(ConstantMessage.TableName);
                objDt = objcl.DataTables();
                if (objDt.Rows.Count > 0)
                {
                    for (int intI = 0; intI < objDt.Rows.Count; intI++)
                    { EmployeeListItem.Add(new ListItem(Convert.ToString(objDt.Rows[intI]["EmpName"]))); }
                    this.DdlEmployee.DataSource = objDt;
                    this.DdlEmployee.DataBind();
                    Cache.Add("EmployeeList", EmployeeListItem, null, Cache.NoAbsoluteExpiration, System.TimeSpan.FromSeconds(60), CacheItemPriority.High, null);
                }
            }
            catch (Exception)
            { Response.Redirect("Error.aspx", false); }
            finally
            {
                objcl = null;
                objDt.Dispose();
                EmployeeListItem = null;
            }
        }
        #endregion
        #region BtnDisplay_Click
        /// <summary>
        /// Name:BtnDisplay_Click
        /// Decription:Display record of that employee which is selected from dropdownlist.
        /// Author:Monal shah
        /// Created Date:2010/11/11
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                if (Cache[DdlEmployee.SelectedItem.Text] == null)
                { BindGrid(); }
                else
                {
                    PanelGrid.Visible = true;
                    EmployeeGrid.Visible = true;
                    objDt = (DataTable)Cache[DdlEmployee.SelectedItem.Text];
                    EmployeeGrid.DataSource = objDt;
                    EmployeeGrid.DataBind();
                }
            }
            catch (Exception)
            { Response.Redirect("Error.aspx", false); }
            finally
            { objDt.Dispose(); }

        }
        #endregion
        #region BindGrid
        /// <summary>
        /// Name:BindGrid
        /// Decription:Bind Grid.
        /// Author:Monal shah
        /// Created Date:2010/11/11
        /// </summary>  
        private void BindGrid()
        {
            try
            {
                objDt = new DataTable();
                objcl.GetSqlStmt = objcl.SelectQuery(ConstantMessage.TableName, ConstantMessage.whereclause, DdlEmployee.SelectedItem.Text);
                objDt = objcl.DataTables();
                if (objDt.Rows.Count > 0)
                {
                    PanelGrid.Visible = true;
                    EmployeeGrid.Visible = true;
                    this.EmployeeGrid.DataSource = objDt;
                    this.EmployeeGrid.DataBind();
                    Cache.Add(DdlEmployee.SelectedItem.Text, objDt, null, Cache.NoAbsoluteExpiration, System.TimeSpan.FromMinutes(5), CacheItemPriority.Default, null);
                }
            }
            catch (Exception)
            { Response.Redirect("Error.aspx", false); }
            finally
            {
                objcl = null;
                objDt.Dispose();

            }
        }
        #endregion
    }
}
