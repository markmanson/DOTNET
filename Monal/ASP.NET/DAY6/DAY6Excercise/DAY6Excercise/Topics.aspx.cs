using System;
using System.Web.UI.WebControls;

namespace DAY6Excercise
{
    /// <summary>
    /// Name:Topics.aspx
    /// Description:"When user click on submit 
    ///              button navigate to Topics.aspx form and create
    ///              hyperlinks in table object for selected options only.
    ///              and when that linkbutton is clicked at that time that particular 
    ///              link is open in browser.          
    /// Author:Monal Shah
    /// Created Date:2010/10/20
    /// </summary>
    public partial class Topics : System.Web.UI.Page
    {
        Table objTable;
        TableCell objCell;
        TableRow objTableRow;
        LinkButton objLnk;
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description:Dynamic Table is created.
        /// Author:Monal Shah
        /// Created Date:2010/10/20
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            createTable();
        }
        #endregion
        #region createTable
        /// <summary>
        /// Name:Page_Load
        /// Description:Dynamic Table is created and linkbutton is created based on previous page item's selected.
        ///             And when linkbutton clicked according to postbackurl is open in browser.
        /// Author:Monal Shah
        /// Created Date:2010/10/20
        /// </summary>
        public void createTable()
        {
            try
            {
                string s = Request.QueryString["id"].ToString().TrimEnd(',');
                string[] splitvalue = s.Split(',');

                Panel1.Controls.Clear();
                objTable = new Table();
                Panel1.Controls.Add(objTable);
                for (int i = 0; i < splitvalue.Length; i++)
                {
                    objTableRow = new TableRow();
                    objTableRow.ID = "Row" + Convert.ToString(i);
                    objCell = new TableCell();
                    objCell.ID = "Row" + Convert.ToString(i) + Convert.ToString("Cell0");
                    objCell.BorderStyle = BorderStyle.Groove;
                    objLnk = new LinkButton();
                    objLnk.ID = "Lnk_" + i;
                    if (i % 2 == 0)
                    {
                        objLnk.Text = splitvalue[i];
                        objCell.Controls.Add(objLnk);
                        objLnk.PostBackUrl = splitvalue[i + 1];
                        objTableRow.Controls.Add(objCell);
                        objTable.Controls.Add(objTableRow);
                    }
                }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
            finally
            {
                objCell.Dispose();
                objTableRow.Dispose();
                objTable.Dispose();                
            }
        }
        #endregion


    }


}
