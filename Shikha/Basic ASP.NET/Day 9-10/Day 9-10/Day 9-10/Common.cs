using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Day_9_10
{
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- Common
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- The Class For Common Method in Project.
    //      CREATED DATE    :- 2012/05/09
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public class Common
    {
        public SqlConnection connC = new SqlConnection();
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- OpenConnection()
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- The Method For Open Connection in Project.
        //      CREATED DATE    :- 2012/06/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        public void OpenConnection()                     //Method for open connection
        {
            connC.ConnectionString = ConfigurationManager.ConnectionStrings[Constant.strCONNSTR].ConnectionString;
            if (connC.State == ConnectionState.Closed)
                connC.Open();
        }
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- CloseConnection()
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- The Method For Close Connection in Project.
        //      CREATED DATE    :- 2012/06/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        public void CloseConnection()                  //Method for close connection
        {
            if (connC.State == ConnectionState.Open)
                connC.Close();
        }
    }
}
