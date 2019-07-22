using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
/// <summary>
/// NamespaceName:ADV_ASP_Day3
/// Description: Asp with Composite Custom Control
/// Author: Bhumi
/// Created On:7/7/2015
/// </summary>
namespace ADV_ASP_Day3
{
    public class CommonFunction
    {
        #region CommonFunctions
        /// <summary>
        /// Class Name:ConnectionGenerate
        /// Description:Return the Datatable For the Query Given in Parameter
        /// Author:Bhumi
        /// Created On:13/7/2015
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>  
        public object ConnectionGenerate(string query)
        {
            //SQL CONNECTION 
            SqlConnection sqlconn;
            SqlCommand sqlcmd;
            SqlDataAdapter sqladapter;            
            sqlconn = new SqlConnection();
            object UserName_Password_Exist;
            try
            {
                //connectionstring
                sqlconn.ConnectionString = ConfigurationManager.ConnectionStrings["connectionstring"].ConnectionString;
                if (sqlconn != null && sqlconn.State == ConnectionState.Closed)
                {
                    sqlconn.Open();//open the connection                        
                }
                sqlcmd = new SqlCommand(query, sqlconn);
                sqladapter = new SqlDataAdapter(sqlcmd);
                UserName_Password_Exist = sqlcmd.ExecuteScalar();
                return UserName_Password_Exist;
            }
            catch (Exception)
            {                
                return 0;
            }
            finally
            {
                if (sqlconn.State == ConnectionState.Open)
                {
                    sqlconn.Close();//open the connection                        
                }
                sqlcmd = null;
                sqladapter = null;                
            }
        }
        #endregion
    }
}