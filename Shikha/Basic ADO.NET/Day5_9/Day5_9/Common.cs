using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Day5_9
{
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- Common
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- The Class Allow user to use common function
    //      CREATED DATE    :- 2012/08/06
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public class Common
    {
        public SqlConnection connC = new SqlConnection();
        public void OpenConnection()                     //Method for open connection
        {
            connC.ConnectionString = ConfigurationManager.ConnectionStrings[Constant.strConnStr].ConnectionString;
            if (connC.State == ConnectionState.Closed)
                connC.Open();
        }
        public void CloseConnection()                  //Method for close connection
        {
            if (connC.State == ConnectionState.Open)
                connC.Close();
        }
    }
}
