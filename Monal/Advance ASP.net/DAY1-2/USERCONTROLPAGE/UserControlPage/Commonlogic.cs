using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace UserControlPage
{
    public class Commonlogic
    {
        private string _getSqlStmt = string.Empty;
        SqlConnection _objCon = new SqlConnection();//create object of sqlconnection
        SqlDataAdapter _objSqlAdp;//Create object of SqldataAdapter
        DataTable _objDTable = new DataTable();//Create object of datatable      
        StringBuilder objSb;
        #region GetConnectionString
        /// <summary>
        /// Name:GetConnectionString
        /// Description:In this get connectionstring from web.config file  
        /// Author:Monal shah
        /// created date:2010/09/20 
        /// </summary>
        public static string GetConnectionString
        {
            get { return System.Configuration.ConfigurationManager.AppSettings["connection"].ToString(); }
        }
        #endregion
        #region GetSqlStmt
        /// <summary>
        /// Name:GetSqlStmt
        /// Description:In this get n set the value of the sql query.   
        /// Author:Monal shah
        /// created date:2010/09/20 
        /// </summary>
        public string GetSqlStmt
        {
            get { return _getSqlStmt; }
            set { _getSqlStmt = value; }
        }
        #endregion
        #region DataTables
        /// <summary>
        /// Name:DataTables
        /// return type:Datatable
        /// Description:In this the adapter will be filled by datatable.   
        /// Author:Monal shah
        /// created date:2010/09/20 
        /// </summary>
        public DataTable DataTables()
        {
            try
            {
                _objCon.ConnectionString = GetConnectionString;//get connection string and assign into sqlconneciton object 
                _objSqlAdp = new SqlDataAdapter(_getSqlStmt, GetConnectionString);//here adapetr's object created
                _objSqlAdp.Fill(_objDTable);//fill the adapter by datatable object
                return _objDTable;
            }
            catch (Exception exException)
            {
                throw exException;
            }
            finally
            {
                _objDTable.Dispose();
                _objSqlAdp.Dispose();

            }
        }
        #endregion
        public DataTable SelectTable(string TableName)
        {
            DataTable objd = new DataTable();
            try
            {
                objSb = new StringBuilder();
                objSb.Append("Select ");
                objSb.Append("* ");
                objSb.Append("From ");
                objSb.Append(TableName);
                GetSqlStmt = objSb.ToString();
                objd = DataTables();
                return objd;
            }
            catch (Exception exException)
            {
                throw exException;
            }
            finally
            {
                objSb = null;
                objd.Dispose();
            }
        }
    }
}