using System;
using System.Text;
using System.Web.UI.WebControls;
using System.Web;
using System.Web.UI;
using System.IO;
/// <summary>
/// Namespace Name:ADV_ASP_Day12_13
/// Description: Export Or Upload Data in ASP.NET
/// Author:Bhumi
/// Created On:21/7/2015
/// </summary>    
namespace ADV_ASP_Day12_13
{
    /// <summary>
    /// Class Name:DataExport
    /// Description:Export Data In Excel File From gridview
    /// Author:bhumi
    /// Created on:21/7/2015
    /// </summary>    
    public partial class DataExport : System.Web.UI.Page
    {
        CommonFunction objcmnfunction;
        ConstantMessages objconstmsg;
        #region Page Load Event
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Grid_Fill();
            }
        }
        #endregion
        #region Gridview Datasource & Binding
        /// <summary>
        /// method name:Grid_Fill
        /// Description: Fill and bind the Gridview
        /// Author:bhumi
        /// Created On:21/7/2015
        /// </summary>       
        public void Grid_Fill()
        {
            StringBuilder strbuilder;//string builder for query        
            try
            {
                objconstmsg = new ConstantMessages();
                //insert SQLquery in String builder
                strbuilder = new StringBuilder("SELECT EmployeeID,FirstName,LastName,TitleOfCourtesy,CONVERT(nvarchar,BirthDate,110) AS BirthDate,Address,City,Country,HomePhone");
                strbuilder.Append(" FROM");
                strbuilder.Append(" Employees;");
                //connection generation and read the data fro reader
                objcmnfunction = new CommonFunction();
                //store data in grid view
                gvEmployees.DataSource = objcmnfunction.ConnectionGenerate(strbuilder.ToString());
                gvEmployees.DataBind();
            }
            catch (Exception)
            {
                objconstmsg = new ConstantMessages();                
                Response.Redirect(objconstmsg.strErrorPage);
            }
            finally
            {
                objcmnfunction = null;
                strbuilder = null;
            }
        }
        #endregion
        #region Export Details Click Event
        /// <summary>
        /// method name:BtnExport_Click
        /// Description: Export Data In Excel From Gridview
        /// Author:bhumi
        /// Created On:21/7/2015      
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnExport_Click(object sender, EventArgs e)
        {
            StringWriter strwritter;
            HtmlTextWriter htmltextwrtter;
            string FileName;
            try
            {
                Response.Clear();
                Response.Buffer = true;
                Response.ClearContent();
                Response.ClearHeaders();
                Response.Charset = "";
                FileName = "Employee" + DateTime.Now + ".xls";
                strwritter = new StringWriter();
                htmltextwrtter = new HtmlTextWriter(strwritter);
                Response.Cache.SetCacheability(HttpCacheability.NoCache);
                Response.ContentType = "application/vnd.ms-excel";
                Response.AddHeader("Content-Disposition", "attachment;filename=" + FileName);
                gvEmployees.GridLines = GridLines.Both;
                gvEmployees.HeaderStyle.Font.Bold = true;
                gvEmployees.RenderControl(htmltextwrtter);
                Response.Write(strwritter.ToString());                                                
            }
            catch (Exception)
            {                
                objconstmsg = new ConstantMessages();                
                Response.Redirect(objconstmsg.strErrorPage,false);
            }
            finally
            {
                Response.End();
                objcmnfunction = null;
                strwritter = null;
                htmltextwrtter = null;
            }      
        }
        #endregion
        #region while Rendering Control Exception Handling Method
        public override void VerifyRenderingInServerForm(Control control)
        {
            /* Confirms that an HtmlForm control is rendered for the specified ASP.NET
               server control at run time. */
        }
        #endregion
    }
}