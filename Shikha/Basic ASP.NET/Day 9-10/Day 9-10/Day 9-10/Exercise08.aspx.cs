using System;
using System.IO;

namespace Day_9_10
{
    #region Exercise08
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- _Default
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- The Class For Show File content on web page.
    //      CREATED DATE    :- 2012/06/09
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class _Default : System.Web.UI.Page
    {
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- Page_Load
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- The PageLoad Method For display file cintent on web page.
        //      CREATED DATE    :- 2012/06/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        #region Page_Load
        //string strErrmsg="";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                RdTxtFile();
            }

        }
        #endregion Page_Load
        void RdTxtFile()
        {
            // Decalration of local variable
            string strContents;
           try
            {
               // Open File And Read It
                using (StreamReader streamReader = File.OpenText(Server.MapPath(Constant.strTXTFILENAME)))
                {
                    // Read File Line By Line
                    strContents = streamReader.ReadLine();
                    while (strContents != null)
                    {
                        // Display File Content In Label
                        lblFile.Text += strContents + Constant.strREPLACEB;
                        strContents = streamReader.ReadLine();
                    }
                }
            }
           
            catch (FileNotFoundException ex)
            {
                //If File Was Not Found 
                lblErr.Visible = true;
                //Display Error
                lblErr.Text = ex.Message;
            }

            catch (FileLoadException ex)
            {
                lblErr.Visible = true;
                lblErr.Text = ex.Message;   
            }
           
            finally
            {
                                                //REALLOCATE MEMORY
              strContents=null;
            }
        }
        
    }
    #endregion Exercise08
}
