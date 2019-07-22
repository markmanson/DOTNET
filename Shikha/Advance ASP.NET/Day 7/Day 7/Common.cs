using System.Configuration;
using System.Data;
using System.Data.SqlClient;
 
namespace Day_7
{
    public class Common
    {
        public SqlConnection connC = new SqlConnection();
        public void OpenConnection()                     //Method for open connection
        {
            connC.ConnectionString = ConfigurationManager.ConnectionStrings[Constant.strCONNSTR].ConnectionString;
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
