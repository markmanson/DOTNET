using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
/// <summary>
///NameSpace:ADO_Day2_4
/// Description://ADO.Net Day2 to Day4
/// Author:bhumi
/// Created On:29/5/2015
/// </summary>
namespace ADO_Day2_4
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
        public DataTable ConnectionGenerate(string query)
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
                if (sqlconn.State == ConnectionState.Closed)
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
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);//Exception
                return null;                            
            }
            finally
            {
                if (sqlconn.State == ConnectionState.Closed)
                {
                    sqlconn.Close();                
                }
                sqlconn = null;
                sqladapter = null;
                sqlreader = null;
            }            
        }              
        #endregion
    }
}