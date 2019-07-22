using System;
using System.Collections;
using System.Data;
using System.Text;
using System.Web.UI.WebControls;

namespace DAY7Excercise
{
    /// <summary>
    /// Name:RepeaterNDatalist
    /// Description:Bind the repeater and datalist and perform sorting and paging
    /// Author:Monal Shah   
    /// created Date:2010/10/22
    /// </summary>
    public partial class RepeaterNDatalist : System.Web.UI.Page
    {
        Commonlogic objcl = new Commonlogic();
        DataTable objDt = new DataTable();
        DataView objDv;
        StringBuilder objSbSelect;
        PagedDataSource pgitems;
        ArrayList pages;
        private static int _pgCount;
        public string ASCENDING = "ASC";
        public string DESCENDING = "DESC";
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description:set controls
        /// Author:Monal Shah   
        /// created Date:2010/10/22
        /// </summary>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                TblRepeater.Visible = false;
                BtnNext.Visible = false;
                BtnPrevious.Visible = false;
                BtnFirst.Visible = false;
                BtnLast.Visible = false;
                Page.Form.DefaultButton = BtnDisplayRecord.UniqueID;
            }
        }
        #endregion
        #region PageNumber
        /// <summary>
        /// Name:PageNumber
        /// Description:set pagenumber in viewstate
        /// Author:Monal Shah   
        /// created Date:2010/10/22
        /// </summary>
        public int PageNumber
        {
            get
            {
                if (ViewState["PageNumber"] != null)
                    return Convert.ToInt32(ViewState["PageNumber"]);
                else
                    return 0;
            }
            set
            {
                ViewState["PageNumber"] = value;
            }
        }
        #endregion
        #region pgCount
        /// <summary>
       
        /// Name:pgCount
        /// Description:set pagecount
        /// Author:Monal Shah   
        /// created Date:2010/10/26
       
        /// </summary>
        public int pgCount
        {
            get { return _pgCount; }
            set { _pgCount = value; }
        }
        #endregion
        #region Bindgrid
        /// <summary>
        /// Name:Bindgrid
        /// Description:Bind the repeater and datalist if datatable is blank then it displays message in label
        /// Author:Monal Shah   
        /// created Date:2010/10/22
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
                objDv = new DataView(objDt);
                objDv.Sort = DdlSort.SelectedItem.Value.ToString() + " " + ASCENDING;
                pgitems = new PagedDataSource();
                pgitems.DataSource = objDv;
                pgitems.AllowPaging = true;
                pgitems.PageSize = 5;
                pgitems.CurrentPageIndex = PageNumber;
                _pgCount = pgitems.PageCount;
                if (objDt.Rows.Count > 0)
                {
                    if (pgitems.PageCount > 1)
                    {
                        pages = new ArrayList();
                        for (int i = 0; i < pgitems.PageCount; i++)
                        {
                            pages.Add((i + 1).ToString());
                        }
                        LblPageNo.Text = string.Format(ConstantMessage.ViewingMsg, pgitems.CurrentPageIndex + 1, pgitems.PageCount);

                        BtnPrevious.Enabled = !pgitems.IsFirstPage;
                        BtnNext.Enabled = !pgitems.IsLastPage;

                        this.EmployeeRepeater.DataSource = pgitems;
                        this.EmployeeRepeater.DataBind();
                        this.EmployeeDataList.DataSource = pgitems;
                        this.EmployeeDataList.DataBind();
                    }

                }
                else
                {
                    LblMsg.Visible = true;
                    EmployeeRepeater.Visible = false;
                    EmployeeDataList.Visible = false;
                    TblRepeater.Visible = false;
                    LblMsg.Text = ConstantMessage.NoRecord;
                    BtnPrevious.Visible = false;
                    BtnNext.Visible = false;
                    BtnFirst.Visible = false;
                    BtnLast.Visible = false;
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
        #region BtnDisplayRecord_Click
        /// <summary>
        /// Name:BtnDisplayRecord_Click
        /// Description:Bind the repeater and datalist
        /// Author:Monal Shah   
        /// created Date:2010/10/22
        /// </summary>

        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnDisplayRecord_Click(object sender, EventArgs e)
        {
            EmployeeDataList.Visible = true;
            EmployeeRepeater.Visible = true;
            TblRepeater.Visible = true;
            BtnNext.Visible = true;
            BtnPrevious.Visible = true;
            BtnFirst.Visible = true;
            BtnLast.Visible = true;
            BindGrid();
        }
        #endregion
        #region BtnNext_Click
       /// <summary>
        /// Name:BtnNext_Click
        /// Description:go to the next page
        /// Author:Monal Shah   
        /// created Date:2010/10/22
        /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        protected void BtnNext_Click(object sender, EventArgs e)
        {
            PageNumber = PageNumber + 1;
            BindGrid();

        }
        #endregion
        #region BtnPrevious_Click
        /// <summary>
        /// Name:BtnPrevious_Click
        /// Description:go to the Previous page
        /// Author:Monal Shah   
        /// created Date:2010/10/22
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnPrevious_Click(object sender, EventArgs e)
        {

            PageNumber = PageNumber - 1;
            BindGrid();

        }
        #endregion
        #region BtnFirst_Click
        /// <summary>
        /// Name:BtnFirst_Click
        /// Description:go to the First page
        /// Author:Monal Shah   
        /// created Date:2010/10/26
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnFirst_Click(object sender, EventArgs e)
        {
            PageNumber = 0;
            BindGrid();
        }
        #endregion
        #region BtnLast_Click
        /// <summary>
        /// Name:BtnLast_Click
        /// Description:go to the Last page
        /// Author:Monal Shah   
        /// created Date:2010/10/26
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnLast_Click(object sender, EventArgs e)
        {
            PageNumber = _pgCount - 1;
            BindGrid();
        }
        #endregion




    }
}
