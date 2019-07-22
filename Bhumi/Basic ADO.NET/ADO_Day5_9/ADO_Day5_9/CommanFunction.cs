using System;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
/// <summary>
/// Namespace Name:ADO_Day5_9
/// Description: Typed Dataset,Gridview Databinding and Its Feature & Validation
/// Author:Bhumi
/// Created On:8/6/2015
/// </summary>
namespace ADO_Day5_9
{
    /// <summary>
    /// Class Name:CommanFunction
    /// Description:Contains CommanFunction which is used in Project
    /// Author:Bhumi
    /// Created on:8/6/2015
    /// </summary>
    #region Repetitively used Function 
    public class CommanFunction
    {
        DataTable dttable;
        public DataTable ConnectionGenerate(string query)
        {
            //Objects for SQL CONNECTION 
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
                dttable = new DataTable();
                dttable.Load(sqlreader);//load the data in datatable
                return dttable;
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
                sqlcmd = null;
                sqladapter = null;
                sqlreader = null;
            }
        }
    }
    #endregion
}