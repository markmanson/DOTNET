using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace Day_5
{
    public class Common
    {
        string strName, strSex, strEmail, strDOB, strPassword, strFax, strMarried, strLang;
        public string Name
        {
            get { return strName; }
            set { strName = value; }
        }
        public string Sex
        {
            get { return strSex;}
            set { strSex = value;}
        }
        public string Email
        {
            get { return strEmail; }
            set { strEmail = value; }
        }
        public string DOB
        {
            get { return strDOB; }
            set { strDOB = value; }
        }
        public string Password
        {
            get { return strPassword; }
            set { strPassword = value; }
        }
        public string Fax
        {
            get { return strFax; }
            set { strFax = value; }
        }
        public string Married
        {
            get { return strMarried; }
            set { strMarried = value; }
        }
        public string Lang
        {
            get { return strLang; }
            set { strLang = value; }
        }
    }
}
