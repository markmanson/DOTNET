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
using System.Data.SqlClient;

namespace Day1
{
    #region Common
    // NAME              :-  Common
    // AUTHOR NAME       :-  SHIKHA MALIK
    // DECRIPTION        :-  Class for all Common logic
    // CREATED DATE      :-  25/07/2012

  public class Common
    {
        //SqlConnection connSql = new SqlConnection(ConfigurationManager.ConnectionStrings[Constant.strConnStr].ConnectionString);

        public SqlConnection connC = new SqlConnection();

        public void OpenConnection()
        {
            connC.ConnectionString = ConfigurationManager.ConnectionStrings[Constant.strConnStr].ConnectionString;
            if (connC.State == ConnectionState.Closed)
                connC.Open();
        }

        public void CloseConnection()
        {
            if (connC.State == ConnectionState.Open)
                connC.Close();
        }

    }
    #endregion Common
}










        //bool openCon()
        //{
        //    connSql.Open();
        //    return true;
        //}
        //bool closeCon()
        //{
        //    if (cn != null)
        //    {
        //        connSql.Close();
        //    }
        //    else
        //    { return false; }
        //}
   

