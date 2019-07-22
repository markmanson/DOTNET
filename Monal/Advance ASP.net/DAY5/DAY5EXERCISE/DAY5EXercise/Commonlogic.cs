using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAY5EXercise
{
    public class Commonlogic
    {
        private string _getSqlStmt = string.Empty;
        SqlConnection _objCon = new SqlConnection();//create object of sqlconnection
        SqlDataAdapter _objSqlAdp;//Create object of SqldataAdapter
        DataTable _objDTable = new DataTable();//Create object of datatable   
        StringBuilder objSbSelect;
        #region GetConnectionString
        /// <summary>
        /// Name:GetConnectionString
        /// Description:In this get connectionstring from web.config file  
        /// Author:Monal shah
        /// created date:2010/11/11
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
        /// created date:2010/11/11
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
        /// created date:2010/11/11
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
            { throw exException; }
            finally
            {
                _objDTable.Dispose();
                _objSqlAdp.Dispose();
            }
        }
        #endregion
        public string SelectQuery(string TableName)
        {
            try
            {
                objSbSelect = new StringBuilder();
                objSbSelect.Append("Select ");
                objSbSelect.Append("DISTINCT ");
                objSbSelect.Append("EmpName ");
                objSbSelect.Append("From ");
                objSbSelect.Append(TableName);
                GetSqlStmt = objSbSelect.ToString();
                return GetSqlStmt;
            }
            catch (Exception exException)
            { throw exException; }
            finally
            { objSbSelect = null; }
        }
        public string SelectQuery(string TableName, string WhereClause, string Value)
        {
            try
            {
                objSbSelect = new StringBuilder();
                objSbSelect.Append("Select ");
                objSbSelect.Append("* ");
                objSbSelect.Append("From ");
                objSbSelect.Append(TableName);
                objSbSelect.Append(" Where ");
                objSbSelect.Append(WhereClause);
                objSbSelect.Append("=");
                objSbSelect.Append("'");
                objSbSelect.Append(Value);
                objSbSelect.Append("'");
                GetSqlStmt = objSbSelect.ToString();
                return GetSqlStmt;
            }
            catch (Exception exException)
            { throw exException; }
            finally
            { objSbSelect = null; }
        }
    }

}