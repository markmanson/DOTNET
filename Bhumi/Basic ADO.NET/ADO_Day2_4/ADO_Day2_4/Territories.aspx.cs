using System;
using System.Web.UI.WebControls;
using System.Text;
/// <summary>
///NameSpace:ADO_Day2_4
/// Description://ADO.Net Day2 to Day4
/// Author:bhumi
/// Created On:29/5/2015
/// </summary>
namespace ADO_Day2_4
{    
    public partial class Territories : System.Web.UI.Page
    {
        CommonFunctions objcmnfunction;
        ConstantMessages objconstmsg;
        /// <summary>
        /// Method Name:Page_Load
        /// Description: GridView databinding with database table
        /// Author:bhumi
        /// Created on:29/5/2015
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        StringBuilder strbuilder;//string builder for query 
        #region  Data in Gridview
        /// <summary>
        /// Event Name:Page Load Event
        /// Description:Fetch the data from Database table and bind in the Gridview
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //insert SQLquery in String builder
                strbuilder = new StringBuilder("SELECT * ");
                strbuilder.Append(" FROM");
                strbuilder.Append(" Territories;");
                //connection generation and read the data fro reader
                objcmnfunction = new CommonFunctions();
                //store data in grid view
                gvTerritories.DataSource = objcmnfunction.ConnectionGenerate(strbuilder.ToString());
                gvTerritories.DataBind();
            }
            catch (Exception)
            {
                objconstmsg = new ConstantMessages();
                Response.Redirect(objconstmsg.strerrorpage);
            }
            finally
            {
                objcmnfunction = null;
                strbuilder = null;
            }
        }
        #endregion
        #region Page Index Change
        //Code for Allow paging to gridview
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvTerritories.PageIndex = e.NewPageIndex;
            gvTerritories.DataBind(); //bind data
        }
    }
        #endregion
}