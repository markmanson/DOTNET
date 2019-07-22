using System.Configuration;
using System.Data;
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
    #endregion Common
}










        
   

