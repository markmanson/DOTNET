using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
/// <summary>
///NameSpace:ADV_ASP_Day12_13
/// Description:Export Data In ASP.NET
/// Author:bhumi
/// Created On:21/7/2015
/// </summary>
namespace ADV_ASP_Day12_13
{
    /// <summary>
    /// Class:CommonFunction
    /// Description:Contains Repetitively Used function
    /// </summary>    
    public class CommonFunction
    {
        #region CommonFunctions
        DataTable datatable;
        //string strquery;//variable to store query            
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