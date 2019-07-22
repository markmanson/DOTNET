using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Practices.ObjectBuilder;
using System.Data.SqlClient;



namespace WindowsApplication
{
    /// <summary>
    /// Name:SearchForm
    /// Description:Bind grid With Pageination With size=5.
    /// Author:Monal shah
    /// Created Date:2010/12/8
    /// </summary>
    public partial class SearchForm : Form
    {
        DetailsOfEmployee Logic = new DetailsOfEmployee();
        DataTable objDt;
        CommonLogic objCl = new CommonLogic();
        int CurrentPageIndex = 1;
        int PageSize;
        int PageCount, maxRec, recNo;
        DataGridViewLinkColumn editLink, editLink1, deleteLink, deleteLink1;
        #region SearchForm
        /// <summary>
        /// Name:SearchForm
        /// Description:Initialize the component
        /// Author:Monal shah
        /// Created Date:2010/12/8
        /// </summary>
        public SearchForm()
        { InitializeComponent(); }
        #endregion
        #region SearchForm_Load
        /// <summary>
        /// Name:SearchForm_Load
        /// Description:Bind Grid With 5 records
        /// Author:Monal shah
        /// Created Date:2010/12/8
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchForm_Load(object sender, EventArgs e)
        {
            BtnPrevious.Enabled = false;
            BtnFirst.Enabled = false;
            maxRec = objCl.MaxRecord("DetailsOfEmployee");
            PageSize = objCl.PageSize("M_SysSetting", "SearchForm");
            PageCount = maxRec / PageSize;
            //Adjust the page number if the last page contains a partial page.
            if ((maxRec % PageSize) > 0)
                PageCount += 1;
            recNo = 0;
        }
        #endregion
        private void EmployeePersonalDetails_Enter(object sender, EventArgs e)
        {
            GrdEmployees.DataSource = objCl.BingGrid("DetailsOfEmployee", PageSize, CurrentPageIndex);
            GrdEmployees.Columns["Emp_ID"].Visible = false;
            editLink = new DataGridViewLinkColumn();
            editLink.Text = "Edit";
            editLink.Name = "lnkEdit";
            editLink.HeaderText = "Update";
            GrdEmployees.Columns.Add(editLink);
            foreach (DataGridViewRow row in GrdEmployees.Rows)
            {
                DataGridViewLinkCell Lnkbutton = (DataGridViewLinkCell)row.Cells["lnkEdit"];
                Lnkbutton.UseColumnTextForLinkValue = true;
            }
            deleteLink = new DataGridViewLinkColumn();
            deleteLink.Text = "Delete";
            deleteLink.Name = "lnkDelete";
            deleteLink.HeaderText = "Delete";

            GrdEmployees.Columns.Add(deleteLink);
            foreach (DataGridViewRow row in GrdEmployees.Rows)
            {
                DataGridViewLinkCell Lnkbutton = (DataGridViewLinkCell)row.Cells["lnkDelete"];
                Lnkbutton.UseColumnTextForLinkValue = true;
            }
        }

        #region LoadPage
        /// <summary>
        /// Name:SearchForm_Load
        /// Description:Bind Grid With records With PageSize 5. 
        /// Author:Monal shah
        /// Created Date:2010/12/8
        /// </summary>
        private void LoadPage()
        {
            int i, startRec, endRec;
            GrdEmployees.Columns.Remove("lnkEdit");
            GrdEmployees.Columns.Remove("lnkDelete");
            objDt = new DataTable();
            objDt = objCl.BingGrid("DetailsOfEmployee", PageSize, CurrentPageIndex);
            GrdEmployees.Columns["Emp_ID"].Visible = false;
            GrdEmployees.DataSource = objDt;

            editLink1 = new DataGridViewLinkColumn();
            editLink1.Name = "lnkEdit";
            editLink1.HeaderText = "Update";
            editLink1.Text = "Edit";
            GrdEmployees.Columns.Add(editLink1);
            foreach (DataGridViewRow row in GrdEmployees.Rows)
            {
                DataGridViewLinkCell Lnkbutton = (DataGridViewLinkCell)row.Cells["lnkEdit"];
                Lnkbutton.UseColumnTextForLinkValue = true;
            }
            deleteLink1 = new DataGridViewLinkColumn();
            deleteLink1.Text = "Delete";
            deleteLink1.Name = "lnkDelete";
            deleteLink1.HeaderText = "Delete";
            GrdEmployees.Columns.Add(deleteLink1);
            foreach (DataGridViewRow row in GrdEmployees.Rows)
            {
                DataGridViewLinkCell Lnkbutton = (DataGridViewLinkCell)row.Cells["lnkDelete"];
                Lnkbutton.UseColumnTextForLinkValue = true;

            }
            if (CurrentPageIndex == PageCount)
                endRec = maxRec;
            else
                endRec = PageSize * CurrentPageIndex;
            startRec = recNo;
            for (i = startRec; i < endRec; i++)
                recNo += 1;
        }
        #endregion
        #region BtnFirst_Click
        /// <summary>
        /// Name:BtnFirst_Click
        /// Description:Display First Five Records Go To First Page. 
        /// Author:Monal shah
        /// Created Date:2010/12/8
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnFirst_Click(object sender, EventArgs e)
        {
            BtnPrevious.Enabled = false;
            BtnNext.Enabled = true;
            //Check if you are already at the first page.
            if (CurrentPageIndex == 1)
            {
                MessageBox.Show("You are at the First Page!");
                BtnFirst.Enabled = false;
                return;
            }
            CurrentPageIndex = 1;
            recNo = 0;
            LoadPage();
        }
        #endregion
        #region BtnPrevious_Click
        /// <summary>
        /// Name:BtnPrevious_Click
        /// Description:Goto Previous Page Display Records. 
        /// Author:Monal shah
        /// Created Date:2010/12/8 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnPrevious_Click(object sender, EventArgs e)
        {
            BtnLast.Enabled = true;
            BtnNext.Enabled = true;
            if (CurrentPageIndex == PageCount)
                recNo = PageSize * (CurrentPageIndex - 2);
            CurrentPageIndex -= 1;
            //Check if you are already at the first page.
            if (CurrentPageIndex < 1)
            {
                MessageBox.Show("You are at the First Page!");
                CurrentPageIndex = 1;
                BtnPrevious.Enabled = false;
                return;
            }
            else
                recNo = PageSize * (CurrentPageIndex - 1);
            LoadPage();

        }
        #endregion
        #region BtnNext_Click
        /// <summary>
        /// Name:BtnNext_Click
        /// Description:Display Next Page Display Records. 
        /// Author:Monal shah
        /// Created Date:2010/12/8 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnNext_Click(object sender, EventArgs e)
        {
            BtnFirst.Enabled = true;
            BtnPrevious.Enabled = true;
            CurrentPageIndex += 1;
            if (CurrentPageIndex > PageCount)
            {
                CurrentPageIndex = PageCount;
                //Check if you are already at the last page.               
                if (recNo == maxRec)
                {
                    MessageBox.Show("You are at the Last Page!");
                    BtnNext.Enabled = false;
                    return;
                }
            }
            LoadPage();
        }
        #endregion
        #region BtnLast_Click
        /// <summary>
        /// Name:BtnLast_Click
        /// Description:Display Last Page With Records. 
        /// Author:Monal shah
        /// Created Date:2010/12/8 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnLast_Click(object sender, EventArgs e)
        {
            BtnNext.Enabled = false;
            BtnFirst.Enabled = true;
            BtnPrevious.Enabled = true;
            //Check if you are already at the last page.         
            if (recNo == maxRec)
            {
                MessageBox.Show("You are at the Last Page!");
                BtnLast.Enabled = false;
                return;
            }
            CurrentPageIndex = PageCount;
            recNo = PageSize * (CurrentPageIndex - 1);

            LoadPage();
        }
        #endregion
        #region BtnClose_Click
        /// <summary>
        /// Name:BtnClose_Click
        /// Description:Close Page
        /// Author Name:Monal Shah
        /// Created Date:2010/12/8
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClose_Click(object sender, EventArgs e)
        { Dispose(true); }
        #endregion

        private void GrdEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == GrdEmployees.Columns["lnkEdit"].Index)
            {


            }
            else if (e.ColumnIndex == GrdEmployees.Columns["lnkDelete"].Index)
            {
                //objCl.GetSqlStmt = "Exec daab_DetailsOfEmployeeDeleteDetailsOfEmployee @Emp_ID=" + GrdEmployees.Rows[e.RowIndex].Cells[0].Value;
                //objCl.ExecuteNonQuery();
                //"Delete from DetailsOfEmployee where Emp_ID=" + GrdEmployees.Rows[e.RowIndex].Cells[0].Value;              

                bool i= Logic.LoadByPrimaryKey(Convert.ToInt32(GrdEmployees.Rows[e.RowIndex].Cells[0].Value));

                Logic.MarkAsDeleted();
                Logic.Save();
                LoadPage();
            }
        }



    }
}
