using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
/// <summary>
///NameSpace:ADO_Day1
/// Description://ADO.Net Day1
/// Author:bhumi
/// Created On:28/5/2015
/// </summary>
namespace ADO_Day1
{
    /// <summary>
    /// Class:CommonFunctions
    /// Description:Contains Repetitively Used function
    /// </summary>
    public class CommonFunctions
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
                sqlconn.Open();//open the connection
                sqlcmd = new SqlCommand(query, sqlconn);
                sqladapter = new SqlDataAdapter(sqlcmd);
                sqlreader = sqlcmd.ExecuteReader();//Reading data
                datatable = new DataTable();
                datatable.Load(sqlreader);
                return datatable;   
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);//Exception
                return 0;                            
            }                                
            finally
            {
                 sqlconn.Close();
                 sqlconn = null;
                 sqlcmd = null;
                 sqladapter = null;
                 sqlreader = null;  
            }            
        }
        //public void QueryExecute(string query)
        //{
            
        //    strquery = query;
        //}
        #endregion
    }
}