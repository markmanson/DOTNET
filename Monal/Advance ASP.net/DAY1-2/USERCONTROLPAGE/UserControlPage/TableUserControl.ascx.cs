using System;
using System.Data;
using System.Web.UI.WebControls;

namespace UserControlPage
{

    /// <summary>
    /// Name:TableUserControl
    /// Description:Create Dynamic Table
    /// Author:Monal Shah
    /// Created Date:2010/11/3
    /// </summary>
    public partial class TableUserControl : System.Web.UI.UserControl
    {
        Table objTable;
        TableCell objTableCell;
        TableRow objTableRow;
        Label lblFirst;
        public DataTable objDt;
        Commonlogic objCl = new Commonlogic();
        TableHeaderRow objHeader;
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description:Create Dynamic Table
        /// Author:Monal Shah
        /// Created Date:2010/11/3
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            CreateTable();
        }
        #endregion
        #region DATASOURCE
        /// <summary>
        /// Name:DATASOURCE
        /// Description:Get Set Prorperty 
        /// Author:Monal Shah
        /// Created Date:2010/11/3
        /// </summary>
        public DataTable DATASOURCE
        {
            get { return objDt; }
            set { objDt = value; }
        }
        #endregion
        #region CreateTable
        /// <summary>
        /// Name:CreateTable
        /// Description:Create Dynamic Table
        /// Author:Monal Shah
        /// Created Date:2010/11/3
        /// </summary>
        private void CreateTable()
        {
            try
            {
                Panel1.Controls.Clear();
                objTable = new Table();
                objTable.CssClass = "Dynamictable";
                objHeader = new TableHeaderRow();
                LblMsg.Visible = false;
                for (int i = 0; i < DATASOURCE.Columns.Count; i++)
                {
                    objTableCell = new TableCell();
                    objTableCell.CssClass = "HeaderTd";
                    objTableCell.Text = DATASOURCE.Columns[i].ColumnName;
                    objTableCell.Font.Bold = true;
                    objHeader.Cells.Add(objTableCell);
                }
                objTable.Rows.Add(objHeader);

                Panel1.Controls.Add(objTable);

                for (int i = 0; i < DATASOURCE.Rows.Count; i++)
                {
                    objTableRow = new TableRow();
                    objTableRow.ID = "Row" + Convert.ToString(i);
                    objTableRow.CssClass = "Bodytd";
                    for (int j = 0; j < DATASOURCE.Columns.Count; j++)
                    {
                        objTableCell = new TableCell();
                        objTableCell.ID = "Row" + Convert.ToString(i) + Convert.ToString(j);
                        objTableCell.CssClass = "Bodytd";
                        lblFirst = new Label();
                        lblFirst.Text = objDt.Rows[i][j].ToString();
                        objTableCell.Controls.Add(lblFirst);
                        objTableRow.Controls.Add(objTableCell);
                        objTableRow.Controls.Add(objTableCell);
                        objTable.Controls.Add(objTableRow);
                    }
                }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx", false);
            }
            finally
            {
                objTableCell = null;
                objHeader = null;
                objTableRow = null;
                objTable = null;
                objDt.Dispose();
                objCl = null;
            }
        }
        #endregion
    }
}