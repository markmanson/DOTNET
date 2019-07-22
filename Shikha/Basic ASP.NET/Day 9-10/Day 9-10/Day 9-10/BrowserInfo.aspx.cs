using System;
using System.Web;
using System.IO;
using System.Text;

namespace Day_9_10
{
    #region BrowserInfo
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- BrowserInfo
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- The Class For Browser information.
    //      CREATED DATE    :- 2012/06/09
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class BrowserInfo : System.Web.UI.Page
    {
        StringBuilder sb; string strFile; string strNew = "";
        #region Page_Load
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- Page_Load
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- The PageLoad Method that show browser information.
        //      CREATED DATE    :- 2012/06/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                HttpBrowserCapabilities br;                                 //DECLARATION THE OBJECT OF HTTPBROWSERCAPABILITIES 
                string strBrowserInfo;                                      //DECLARATION OF A STRING
                string strDate;
                try
                {
                    strDate = DateTime.Now.Date.ToString();
                    br = Request.Browser;                                   //INITIALIZATION OF THE OBJECT OF HTTPBROWSERCAPABILITIES
                    strBrowserInfo = Constant.strBRSRCAP + Constant.strTYPE + br.Type + Constant.strN
                        + Constant.strNAME + br.Browser + Constant.strN
                        + Constant.strVERSION+ br.Version + Constant.strN;        //ASSIGN THE VALUE OF BROWSER INFO TO STRING
                    //Cache.Insert(Constant.strBRSRINFO, strDate);                         //ADDING THE INFORMATION TO THE CACHE OBJECT
                    Cache.Insert(Constant.strBRSRINFO, strBrowserInfo, null, DateTime.Now.AddSeconds(15), System.Web.Caching.Cache.NoSlidingExpiration);
                    // Store Current Date In Cache
                    Cache.Insert(Constant.strDATE, strDate, null, DateTime.Now.AddSeconds(30), TimeSpan.Zero); 
                    // Read Text File
                    strFile = RdTxtFile();
                    Session[Constant.strVALUE] = strFile;
                   
                   // Store  File In Cache
                  Cache.Insert(Constant.strFILE, strFile, new System.Web.Caching.CacheDependency(Server.MapPath(Constant.strSAMPLEFILE)), DateTime.Now.AddSeconds(30),
                  System.Web.Caching.Cache.NoSlidingExpiration);
                }
                catch                                                        //IF EXCEPTION IS OCCURES
                {
                    Response.Redirect(Constant.strERRORPAGE);                             //SHOWING THE EXCEPTION MESSEGE
                }
                finally
                {
                    strBrowserInfo = null;                     //ASSIGN NULL TO STRING OBJECT
                    strDate = null;
                    strFile = null;
                }
            }
        }
        #endregion Page_Laod
        public string RdTxtFile()
        { // Decalration of local variable
            string strContents;
          
            try
            {
                sb = new StringBuilder();
                using (StreamReader streamReader = File.OpenText(Server.MapPath(Constant.strSAMPLEFILE)))
                {
                    strContents = streamReader.ReadLine();
                    txtFile.Text = strContents;
                    while (strContents != null)
                    {
                        sb.Append(strContents);
                        strContents = streamReader.ReadLine();
                        txtFile.Text = strContents;
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message); 
            }
            //Assign Null 
            finally 
            { 
                strContents = null;
               //Cache.Remove(Constant.strBRSRINFO);
            }
            // Return file Text
            return txtFile.Text = sb.ToString();
        }
      protected void btnClick_Click(object sender, EventArgs e)
        {
            Response.Redirect(Constant.strDISPLAY_PAGE);
        }
    protected void btnUpdate_Click(object sender, EventArgs e)
      {
          strNew= txtFile.Text;
          string strcache = Session[Constant.strVALUE].ToString();
          FileStream fs = File.Create(Server.MapPath(Constant.strSAMPLEFILE));
          StreamWriter sw = new StreamWriter(fs);
          sw.Write(strNew);
          sw.Close();
              if (strNew == strcache)
             {
                 RdTxtFile();

             }
              else
              {
              Response.Cache.SetExpires(DateTime.Now.AddSeconds(0));

              }

       }

    }
    #endregion BrowserInfo
}


