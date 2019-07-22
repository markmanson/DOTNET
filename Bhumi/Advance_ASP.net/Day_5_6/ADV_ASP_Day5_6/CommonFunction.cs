using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
/// <summary>
/// Namespace Name:ADV_ASP_Day5_6
/// Description:Cache Concept in ASP.NET
/// Author:Bhumi
/// Created On:9/7/2015
/// </summary>
namespace ADV_ASP_Day5_6
{
    /// <summary>
    /// Class Name:CommonFunction
    /// Description:Common function to perform Database Related Task
    /// Author:Bhumi
    /// Created On:10/7/2015
    /// </summary>
    public class CommonFunction
    {
        #region CommonFunctions
        DataTable datatable;            
        //string strquery;//variable to store query  
        /// <summary>
        /// Class Name:ConnectionGenerate
        /// Description:Return the Datatable For the Query Given in Parameter
        /// Author:Bhumi
        /// Created On:10/7/2015
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>  
        public object ConnectionGenerate(string query)
        {
            //SQL CONNECTION 
            SqlConnection sqlconn;
            SqlCommand sqlcmd;
            SqlDataAdapter sqladapter;
            SqlDataReader sqlreader;
            sqlconn = new SqlConnection();
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
                sqlreader = sqlcmd.ExecuteReader();//Reading data
                datatable = new DataTable();
                datatable.Load(sqlreader);
                return datatable;
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
                sqlreader = null;
            }
        }
        #endregion
    }
}