using System;
using System.IO;
using System.Web.UI;

namespace Day_9_10
{
    public partial class Trace : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                RdTxtFile();
            }
        }
        void RdTxtFile()
        { // Decalration of local variable
            string strContents;
           using (StreamReader streamReader = File.OpenText(Server.MapPath("ShikhMalik.txt")))
            {
                strContents = streamReader.ReadLine();
                while (strContents != null)
                {
                    lblFile.Text += strContents + Constant.strREPLACEB;
                    strContents = streamReader.ReadLine();
                }
            }

        }
        public void Page_Error(Object sender, EventArgs e)
        {
            if (Trace.IsEnabled)
            {
                Trace.Warn(Constant.strERRORK, Constant.strBLANK, Server.GetLastError());
                Response.Write(TraceLink);
            }

        }
        public string TraceLink
        {
            get
            {
                if (Trace.IsEnabled)
                    return Constant.strERR_HRF;
                else
                    return Constant.strBLANK;
            }
        }
    }
}
