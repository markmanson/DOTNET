using System.Configuration;
using System.Data.SqlClient;

namespace Day_9
{
    #region common
    /*************************************************************************************************************
     * CLASS NAME                                   :::                     Common                
     * AUTHOR NAME                                  :::                     ANKIT SHARMA
     * DATE                                         :::                     27/08/2012
     * DESCRIPTION                                  :::                     TO MAKE THE COMMON FUNCTIONS
     * **********************************************************************************************************/
    public class Common
    {      
        public SqlConnection Connect = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString);
        #region Open_Con
        /*************************************************************************************************************
         * FUNCTION NAME                                :::                     Open_Con                
         * AUTHOR NAME                                  :::                     ANKIT SHARMA
         * DATE                                         :::                     27/08/2012
         * DESCRIPTION                                  :::                     TO OPEN THE SQL CONNECTION
         * **********************************************************************************************************/
        public void Open_Con()
        {
            Connect.Open();
        }
        #endregion Open_Con
        #region Close_Con
        /*************************************************************************************************************
         * FUNCTION NAME                                :::                     Close_Con                
         * AUTHOR NAME                                  :::                     ANKIT SHARMA
         * DATE                                         :::                     27/08/2012
         * DESCRIPTION                                  :::                     TO CLOSE THE SQL CONNECTION
         * **********************************************************************************************************/
        public void Close_Con()
        {
            if (Connect.State == System.Data.ConnectionState.Open)
            {
                Connect.Close();
            }
        }
        #endregion Close_Con
    }
        #endregion Common
}
