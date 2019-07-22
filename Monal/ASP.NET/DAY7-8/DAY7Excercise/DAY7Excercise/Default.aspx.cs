using System;
using System.Configuration;
using System.Data;
using System.Text;
using System.Web.UI.WebControls;

namespace DAY7Excercise
{
    /// <summary>
    /// Name:Default.aspx
    /// Description:create connection and bind data in gridview 
    /// and when user clicks on grid header text value then grid's
    /// column values are sorted in ascending and descending order.
    /// Author:Monal Shah   
    /// created Date:2010/10/21
    /// </summary>
    public partial class _Default : System.Web.UI.Page
    {
        Commonlogic objcl = new Commonlogic();
        DataTable objDt = new DataTable();
        DataTable objDt1;
        DataView objDv;
        StringBuilder objSbSelect;
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description:Bind the grid
        /// Author:Monal Shah   
        /// created Date:2010/10/21
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Page.Form.DefaultButton = BtnDisplayGrid.UniqueID;
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx", false);
            }
        }
        #endregion

        #region GridViewSortExpression
        private string GridViewSortExpression
        {
            get { return ViewState["SortExpression"] as string ?? string.Empty; }
            set { ViewState["SortExpression"] = value; }
        }
        #endregion

        #region EmployeeGrid_Sorting
        /// <summary>
        /// Name:Page_Load
        /// Description:when user clicks on grid header text value then grid's
        /// column values are sorted in ascending and descending order.
        /// Author:Monal Shah   
        /// created Date:2010/10/21
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void EmployeeGrid_Sorting(object sender, System.Web.UI.WebControls.GridViewSortEventArgs e)
        {
            try
            {
                GridViewSortExpression = e.SortExpression;
                ViewState["SortExpression"] = e.SortExpression;
                objDt1 = new DataTable();
                objSbSelect = new StringBuilder();
                objSbSelect.Append("Select ");
                objSbSelect.Append("* ");
                objSbSelect.Append("From ");
                objSbSelect.Append("TblEmployee");
                objcl.GetSqlStmt = objSbSelect.ToString();
                objDt1 = objcl.DataTables();
                objDv = new DataView(objDt1);
                string direction = GetSortDirection();
                objDv.Sort = GridViewSortExpression + " " + direction;
                this.EmployeeGrid.DataSource = objDv;
                this.EmployeeGrid.DataBind();
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx", false);
            }
        }
        #endregion
        #region GetSortDirection
        private string GetSortDirection()
        {
            switch (GridViewSortDirection)
            {
                case "ASC":
                    GridViewSortDirection = "DESC";
                    break;
                case "DESC":
                    GridViewSortDirection = "ASC";
                    break;
            }
            return GridViewSortDirection;
        }

        #endregion

        #region GridViewSortDirection
        /// <summary>
        /// GridViewSortDirection
        /// </summary>
        private string GridViewSortDirection
        {
            get { return ViewState["SortDirection"] as string ?? "ASC"; }

            set { ViewState["SortDirection"] = value; }

        }
        #endregion

        #region Bindgrid
        /// <summary>
        /// Name:Bindgrid
        /// Description:Bind the grid if datatable is blank then it displays message in label
        /// Author:Monal Shah   
        /// created Date:2010/10/21
        /// </summary>
        public void BindGrid()
        {
            try
            {
                objSbSelect = new StringBuilder();
                objSbSelect.Append("Select ");
                objSbSelect.Append("* ");
                objSbSelect.Append("From ");
                objSbSelect.Append("TblEmployee");
                objcl.GetSqlStmt = objSbSelect.ToString();
                objDt = objcl.DataTables();
                if (objDt.Rows.Count > 0)
                {
                    objDv = new DataView(objDt);
                    this.EmployeeGrid.DataSource = objDv;
                    this.EmployeeGrid.DataBind();
                    ViewState["dt"] = objDt;
                }
                else
                {
                    LblMsg.Visible = true;
                    BtnDisplayGrid.Visible = false;
                    EmployeeGrid.Visible = false;
                    LblMsg.Text = ConstantMessage.NoRecord;

                }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx", false);
            }
            finally
            {
                objSbSelect = null;
                objcl = null;
                objDt.Dispose();
            }
        }
        #endregion


        #region AddSortImage
        /// <summary>
        /// Name:AddSortImage
        /// Description:Here images set if order is ascending then 
        /// ascending image is displayed if it is descending then
        /// it is displayes descending image
        /// Author:Monal Shah   
        /// created Date:2010/10/21
        /// </summary>
        /// <param name="columnIndex"></param>
        /// <param name="headerRow"></param>
        public void AddSortImage(int columnIndex, GridViewRow headerRow)
        {
            // Create the sorting image based on the sort direction.
            Image sortImage = new Image();
            try
            {
                if (GridViewSortDirection == "ASC")
                {
                    sortImage.ImageUrl = "~/" + ConfigurationManager.AppSettings["Images"]
                                         + "/bullet_arrow_up.PNG";
                    sortImage.AlternateText = "Ascending Order";
                    sortImage.CssClass = "whiteFont";
                }
                else
                {
                    sortImage.ImageUrl = "~/" + ConfigurationManager.AppSettings["Images"] +
                                         "/bullet_arrow_down.PNG";
                    sortImage.AlternateText = "Descending Order";
                    sortImage.CssClass = "whiteFont";
                }
                // Add the image to the appropriate header cell.

                headerRow.Cells[columnIndex].Controls.Add(sortImage);
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx", false);
            }
        }
        #endregion

        #region GetSortColumnIndex
        /// <summary>
        /// Name:GetSortColumnIndex
        /// Description:grid's column index is set
        /// Author:Monal Shah   
        /// created Date:2010/10/21
        /// </summary>
        /// <returns>int</returns>
        public int GetSortColumnIndex()
        {
            foreach (DataControlField field in EmployeeGrid.Columns)
            {
                if (field.SortExpression == (string)ViewState["SortExpression"])
                {
                    return EmployeeGrid.Columns.IndexOf(field);
                }
            }
            return -1;
        }
        #endregion

        #region SortDataTable

        /// <summary>
        /// Name:SortDataTable
        /// Description:create sorted datatable
        /// Author:Monal Shah   
        /// created Date:2010/10/21
        /// </summary>
        /// <param name="isPageIndexChanging"></param>
        /// <returns></returns>

        protected DataView SortDataTable(bool isPageIndexChanging)
        {

            DataTable dataTable = (DataTable)ViewState["dt"];
            if (dataTable != null)
            {
                DataView dataView = new DataView(dataTable);
                if (GridViewSortExpression != string.Empty)
                {
                    if (isPageIndexChanging)
                    {
                        dataView.Sort = string.Format("{0} {1}", GridViewSortExpression, GridViewSortDirection);
                    }
                    else
                    {
                        dataView.Sort = string.Format("{0} {1}", GridViewSortExpression, GetSortDirection());
                    }
                }
                return dataView;
            }
            else
            {
                return new DataView();
            }

        }
        #endregion


        #region EmployeeGrid_RowCreated
        /// <summary>
        /// Name:EmployeeGrid_RowCreated
        /// Description:here sortingcolumn index is set and based on sortimage is set
        /// Author:Monal Shah   
        /// created Date:2010/10/21
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void EmployeeGrid_RowCreated(object sender, System.Web.UI.WebControls.GridViewRowEventArgs e)
        {

            try
            {
                if (e.Row.RowType == DataControlRowType.Header)
                {
                    int sortColumnIndex = GetSortColumnIndex();
                    if (sortColumnIndex != -1)
                    {
                        AddSortImage(sortColumnIndex, e.Row);
                    }
                }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx", false);

            }
        }
        #endregion
        #region EmployeeGrid_PageIndexChanging
        /// <summary>
        /// Name:EmployeeGrid_PageIndexChanging
        /// Description:here pageindex is set and data is bind the grid
        /// Author:Monal Shah   
        /// created Date:2010/10/21
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void EmployeeGrid_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            EmployeeGrid.PageIndex = e.NewPageIndex;
            objDv = SortDataTable(true);
            EmployeeGrid.DataSource = objDv;
            EmployeeGrid.DataBind();
        }
        #endregion
        #region BtnDisplayGrid_Click
        /// <summary>
        /// Name:BtnDisplayGrid_Click
        /// Description:here bind the grid when button is clicked
        /// Author:Monal Shah   
        /// created Date:2010/10/21
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnDisplayGrid_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeGrid.Visible = true;
                BtnDisplayGrid.Visible = false;
                BindGrid();
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx", false);
            }

        }
        #endregion
    }

}
