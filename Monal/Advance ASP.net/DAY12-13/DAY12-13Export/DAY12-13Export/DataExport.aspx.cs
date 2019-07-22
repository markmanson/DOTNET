using System;
using System.Data;
using System.IO;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DAY12_13Export
{
    public partial class _DataExport : System.Web.UI.Page
    {
        Commonlogic objcl = new Commonlogic();
        DataTable objDt = new DataTable();
        GridView objGrid = new GridView();
        /// <summary>
        /// Name:Page_Load
        /// Description:Bind the grid if datatable is blank then it displays message in label
        /// Author:Monal Shah   
        /// created Date:2010/11/26
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        { BindGrid(); }
        #region Bindgrid
        /// <summary>
        /// Name:Bindgrid
        /// Description:Bind the grid if datatable is blank then it displays message in label
        /// Author:Monal Shah   
        /// created Date:2010/11/26
        /// </summary>
        public void BindGrid()
        {
            try
            {
                objcl.GetSqlStmt = objcl.SelectQuery("Employees");
                objDt = objcl.DataTables();
                if (objDt.Rows.Count > 0)
                {
                    EmployeeGrid.DataSource = objDt;
                    EmployeeGrid.DataBind();
                }
                else
                {
                    LblMsg.Visible = true;
                    LblMsg.Text = ConstantMessage.NoRecord;
                    EmployeeGrid.Visible = false;
                    BtnExportToExcel.Visible = false;
                    FileUpload.Enabled = false;
                    BtnFileUpload.Enabled = false;

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
        #region BtnExportToExcel_Click
        /// <summary>
        /// Name:BtnExportToExcel_Click
        /// Description:Create application that will export the data of datagrid object in MS-Excel file.
        /// Author:Monal Shah   
        /// created Date:2010/11/26
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnExportToExcel_Click(object sender, EventArgs e)
        {
            Response.Clear();
            Response.AddHeader("content-disposition", "attachment;filename=ExportedData.xls");
            Response.Charset = "";
            Response.Cache.SetCacheability(HttpCacheability.NoCache);
            Response.ContentType = "application/vnd.xls";
            StringWriter objStringWrite = new StringWriter();
            HtmlTextWriter objHtmlWrite = new HtmlTextWriter(objStringWrite);
            objGrid.DataSource = EmployeeGrid.DataSource;
            objGrid.DataBind();
            objGrid.RenderControl(objHtmlWrite);
            Response.Write(objStringWrite.ToString());
            Response.End();
        }
        #endregion
        #region BtnFileUpload_Click
        /// <summary>
        /// Name:BtnFileUpload_Click
        /// Description:Upload the excel file on server.
        ///             Task-1 Take the file upload control
        ///             Task-2 When click on upload button file should be save on specific path which is mentioned in web.config file
        /// Author:Monal Shah   
        /// created Date:2010/11/26
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnFileUpload_Click(object sender, EventArgs e)
        {
            if (FileUpload.HasFile)
            {
                string extension = Path.GetExtension(FileUpload.FileName);
                string strFilename = Path.GetFileName(FileUpload.FileName);
                if (extension == ".xls")
                {
                    FileUpload.SaveAs(Server.MapPath(Commonlogic.GetFilePath) + strFilename);
                    LblMsg.Visible = true;
                    LblMsg.Text = ConstantMessage.FileUpload;
                }
                else
                {
                    LblMsg.Visible = true;
                    LblMsg.Text = ConstantMessage.OnlyXlsFile;
                }
            }
            else
            {
                LblMsg.Visible = true;
                LblMsg.Text = ConstantMessage.NoSelected;
            }
        }
        #endregion
    }
}
