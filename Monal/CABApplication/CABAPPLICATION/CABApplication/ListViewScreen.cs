using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Practices.ObjectBuilder;

namespace CABApplication
{
    /// <summary>
    /// Name:ListScreen
    /// Description:Bind grid With Pageination With size=5.
    /// Author:Monal shah
    /// Created Date:2010/12/20
    /// </summary>
    public partial class ListViewScreen : UserControl
    {
        private ListController controller;
        DataTable objDt;
        CommonLogic objCl = new CommonLogic();
        int CurrentPageIndex = 1;
        int PageSize;
        int PageCount, maxRec, recNo;
        public ListViewScreen()
        {
            InitializeComponent();
        }
        [CreateNew]
        public ListController Controller
        {
            set { controller = value; }
        }
        #region ListScreen_Load
        /// <summary>
        /// Name:ListScreen_Load
        /// Description:Bind Grid With 5 records
        /// Author:Monal shah
        /// Created Date:2010/12/20
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListScreen_Load(object sender, EventArgs e)
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
            // Display the content of the current page.
            LoadPage();
        }
        #endregion
        #region LoadPage
        /// <summary>
        /// Name:SearchForm_Load
        /// Description:Bind Grid With records With PageSize 5. 
        /// Author:Monal shah
        /// Created Date:2010/12/20
        /// </summary>
        private void LoadPage()
        {
            objDt = new DataTable();
            objDt = objCl.BingGrid("DetailsOfEmployee", PageSize, CurrentPageIndex);
            GrdEmployees.DataSource = objDt;
            int i, startRec, endRec;
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
        /// Created Date:2010/12/20
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
        /// Created Date:2010/12/20 
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
        /// Created Date:2010/12/20 
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
        /// Created Date:2010/12/20 
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
        /// Created Date:2010/12/20
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Dispose(true);
        }
        #endregion


    }
}
