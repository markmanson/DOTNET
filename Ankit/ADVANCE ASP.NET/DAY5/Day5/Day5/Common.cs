using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace Day5
{
    #region Common
    /********************************************************************************************************************************************
    * CLASS NAME                                   :::                     COMMON                
    * AUTHOR NAME                                  :::                     ANKIT SHARMA
    * DATE                                         :::                     13/09/2012
    * DESCRIPTION                                  :::                     TO MAKE A CLASS WHICH HAVE THE COMMON METHODS REQUIRED IN THIS PROJECT
    * ******************************************************************************************************************************************/
    public class Common
    {
        #region Bind
        /********************************************************************************************************************************************
        * FUNCTION NAME                                :::                     BIND                
        * AUTHOR NAME                                  :::                     ANKIT SHARMA
        * DATE                                         :::                     13/09/2012
        * DESCRIPTION                                  :::                     TO MAKE A METHOD WHICH TAKES A STRING QUERY AND RETURNS A DATASET
        * ******************************************************************************************************************************************/
        public DataSet Bind(string strCmd)
        {
            SqlConnection Connect;                                                      //DECLARATION FOR OBJECT OF  SQL CONNECTION
            SqlDataAdapter Adpt;                                                        //DECLARATION FOR OBJECT OF SQLDATAREADER   
            DataSet dsEmp;                                                              //DECLARATION FOR THE OBJECT OF DATASET
            Connect = new SqlConnection(ConfigurationManager.ConnectionStrings[Constant.strCon_Name].ConnectionString); //INITIALIZATION OF SQL CONNECTION
            try
            {
                Connect.Open();                                                         //OPEN THE DATABASE
                Adpt = new SqlDataAdapter(strCmd, Connect);                             //INITIALIZE THE ADAPTER
                dsEmp = new DataSet();                                                  //INITIALIZATION THE OBJECT OF DATASET
                Adpt.Fill(dsEmp);                                                       //FILL THE DATASET WITH ADAPTER
            }
            finally
            {
                Adpt = null;                                                            //ASSIGNING NULL TO SQL DATA READER
                if (Connect.State != System.Data.ConnectionState.Closed)                //CHECK IF CONNECTION IS NOT CLOSED
                    Connect.Close();                                                    //CLOSING THE SQL CONNECTION 
                Connect = null;                                                         //ASSIGN NULL TO SQL CONNECTION 
            }
            return dsEmp;                                                               //RETURN THE DATA_SET
        }
        #endregion Bind      
    }
    #endregion Common
}
