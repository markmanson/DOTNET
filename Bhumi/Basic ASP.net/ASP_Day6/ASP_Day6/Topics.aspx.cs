using System;
using System.Web.UI.WebControls;
/// <summary>
/// NamespaceName:ASP_Day6
/// Description: Basic ASP.Net study
/// Author: Bhumi
/// Created On:22/6/2015
/// </summary>
namespace ASP_Day6
{
    /// <summary>
    /// Class Name:Topics
    /// Description:QueryString & Dynamic Hyperlinks
    /// Author:Bhumi
    /// Created On:22/6/2015
    /// </summary>        
    public partial class Topics : System.Web.UI.Page
    {
        ConstantMessages objconstant;
        string QuerystringVal;
        string[] splitVal;
        LinkButton Lnkbtn;
        TableRow tRow;
        TableCell tCell;
        #region Dynamic Table Creation and adding Hyperlinks in that Table
        /// <summary>
        /// Method Name:Page_Load
        /// Description:Get the Value From Querystring and store into dynamic hyperlinks
        /// Author:Bhumi
        /// Created On:22/6/2015
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                objconstant = new ConstantMessages();
                QuerystringVal = Request.QueryString["Selected"];
                splitVal = QuerystringVal.Split(',');//Split using delimeter
                for (int i = 0; i < splitVal.Length; i++)
                {
                    // Create new row and add it to the table.
                    tRow = new TableRow();
                    TblDynamic.Rows.Add(tRow);
                    tCell = new TableCell();
                    tRow.Cells.Add(tCell);//ADD Cell                            
                    Lnkbtn = new LinkButton();
                    Lnkbtn.Text = splitVal[i];
                    Lnkbtn.OnClientClick = "window.open('"+objconstant.strChoicepage+"')";
                    tCell.Controls.Add(Lnkbtn);//Add Hyperlink in cell 
                }
            }
            catch (Exception)
            {
                objconstant = new ConstantMessages();
                Response.Redirect(objconstant.strchoicepage);
            }
            finally
            {
                objconstant = null;
                Lnkbtn = null;
                tRow = null;
                tCell = null;
            }
        }
        #endregion
    }
}