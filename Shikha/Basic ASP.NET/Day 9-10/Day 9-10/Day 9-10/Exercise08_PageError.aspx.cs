using System;
using System.IO;
namespace Day_9_10
{
    public partial class Exercise08_PageError : System.Web.UI.Page
    {
        #region Page_Load
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- Page_Load
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- The PageLoad Method For display file cintent on web page.
        //      CREATED DATE    :- 2012/06/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        //string strErrmsg = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            {
                if (!Page.IsPostBack)
                    RdTxtFile();
            }
        }
        #endregion Page_Load
        #region ReadFile
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- RdTxtFile()
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- The RdTxtFile() Method For display file cintent on web page.
        //      CREATED DATE    :- 2012/06/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        void RdTxtFile()
        {
            // Decalration of local variable
            string strContents;
            // Open File And Read It
            using (StreamReader streamReader = File.OpenText(Server.MapPath("ShikhaMalik.txt")))
            {
                // Read File Line By Line
                strContents = streamReader.ReadLine();
                while (strContents != null)
                {
                    // Display File 
                    lblFile.Text += strContents + Constant.strREPLACEB;
                    strContents = streamReader.ReadLine();
                }
            }
        }
        #endregion ReadFile
        #region Page_Error
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- Page_Error
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- The Page_Error Method For Navigate error page.
        //      CREATED DATE    :- 2012/06/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        public void Page_Error(Object sender, EventArgs e)
        {
            // Fetch Error
            Exception ex = Server.GetLastError();
            // Store Error In Session
            Session[Constant.strPAGE_ERROR] = ex.Message;
            // Clear Error
            Server.ClearError();
            // Navigate Error Page
            Response.Redirect(Constant.strERROR_MSG);
        }
        #endregion Page_Error
    }
}
