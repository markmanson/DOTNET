using System.Configuration;
using System.Data.SqlClient;


namespace Day7_8
{
    #region Common
    /*************************************************************************************************************
        CLASS NAME                         ::::                    COMMON
        AUTHOR                             ::::                    ANKIT
        DATE                               ::::                    18-07-2012
        DESCRIPTION                        ::::                    TO MAKE A COMMON CLASS 
       ************************************************************************************************************/
    public class Common
    {
        //INITIALIZATION OF SQL CONNECTION ****************************************************************************************
        public SqlConnection Connect = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString);
        #region Con_Open
        /*************************************************************************************************************
       FUNCTION NAME                      ::::                    Con_Open
       AUTHOR                             ::::                    ANKIT
       DATE                               ::::                    18-07-2012
       DESCRIPTION                        ::::                    FUNCTION TO OPEN A SQL CONNECTION 
      ************************************************************************************************************/
        public void Con_Open()
        {
            if (Connect.State == System.Data.ConnectionState.Closed)        //CHECK IF CONNECTION IS CLOSE
            {
                Connect.Open();                                             //OPEN THE SQL CONNECTION
            }
        }
        #endregion Con_Open
        #region Con_Close
        /*************************************************************************************************************
      FUNCTION NAME                      ::::                    Con_Close
      AUTHOR                             ::::                    ANKIT
      DATE                               ::::                    18-07-2012
      DESCRIPTION                        ::::                    FUNCTION TO CLOSE A SQL CONNECTION 
     ************************************************************************************************************/
        public void Con_Close()
        {
            if (Connect.State == System.Data.ConnectionState.Open)      //CHECKIF CONNECTION IS OPEN
            {
                Connect.Close();                                        //CLOSE THE SQL CONNECTION
            }
        }
        #endregion Con_Close
    }
    #endregion Common
}
