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


namespace Day2_4
{
    #region Common
    /*************************************************************************************************************
        NAME                               ::::                    DEFAULTLINK
        AUTHOR                             ::::                    ANKIT
        DATE                               ::::                    13-07-2012
        DESCRIPTION                        ::::                    TO MAKE A CLASS DEFAULTLINK
       ************************************************************************************************************/
    public class Common
    {
       //INITIALIZATION OF SQL CONNECTION ****************************************************************************************
       public SqlConnection  Connect = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString);
    }
    #endregion Common
}
