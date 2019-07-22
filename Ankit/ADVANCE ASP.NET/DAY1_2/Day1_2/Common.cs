using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI.WebControls;

namespace Day1_2
{
    #region Common
    /*************************************************************************************************************
    * CLASS NAME                                   :::                     Common                
    * AUTHOR NAME                                  :::                     ANKIT SHARMA
    * DATE                                         :::                     03/09/2012
    * DESCRIPTION                                  :::                     TO MAKE A CLASS WHICH CONTAINS THE COMMON METHODS
    * **********************************************************************************************************/
    public class Common
    {
        #region Bind
        /*************************************************************************************************************
    * FUNCTION NAME                                :::                     bind                
    * AUTHOR NAME                                  :::                     ANKIT SHARMA
    * DATE                                         :::                     03/09/2012
    * DESCRIPTION                                  :::                     TO MAKE A METHOD TO BIND THE GRIDVIEW
    * **********************************************************************************************************/
        public void Bind(GridView gvdEmp)
        {
            SqlConnection Connect;                                                  //DECLARATION FOR OBJECT OF  SQL CONNECTION
            StringBuilder strBuild;                                                 //DECLARATION FOR OBJECT OF STRING BUILDER
            SqlCommand Cmd;                                                         //DECLARATION FOR OBJECT OF SQLCOMMAND
            SqlDataReader Rdr;                                                      //DECLARATION FOR OBJECT OF SQLDATAREADER   
            Connect = new SqlConnection(ConfigurationManager.ConnectionStrings[Constant.strCon_Name].ConnectionString);
            try
            {
                Connect.Open();                                                     //OPEN THE DATABASE
                strBuild = new StringBuilder();                                     //INITIALIZATION OF STRING BUILDER 
                if (Constant.BoolAlt)
                    strBuild.Append(Constant.strQuery1);
                else
                    strBuild.Append(Constant.strQuery);                                 //APPENDING THE STRING BUILDER                
                Cmd = new SqlCommand(Convert.ToString(strBuild), Connect);          //INITIALIZATION OF SQL COMMAND 
                Rdr = Cmd.ExecuteReader();                                          //TO EXECUTE THE COMMAND
                gvdEmp.DataSource = Rdr;                                            //TO SEND THE CONTENT OF TABLE INTO GRIDVIEW
                gvdEmp.DataBind();                                                  //TO BIND THE DATA OF TABLE INTO GRIDVIEW
                Connect.Close();                                                    //TO CLOSE THE DATABASE connection               
                if (Rdr == null)                                                    //IF RDR IS NULL
                {
                    Rdr.Close();                                                    //CLOSE THE SQL DATA READER
                }                
            }          
            finally
            {
                strBuild = null;                                                      //DESTROYING THE OBJECT OF STRING BUILDER
                Cmd = null;                                                           //DESTROYING THE OBJECT OF SQLCOMMAND
                Rdr = null;                                                           //ASSIGNING NULL TO SQL DATA READER
                if (Connect.State != System.Data.ConnectionState.Closed)              //CHECK IF CONNECTION IS NOT CLOSED
                    Connect.Close();                                                  //CLOSING THE SQL CONNECTION 
            }
        }
        #endregion Bind
    }
    #endregion Common
}
