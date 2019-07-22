using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DAY12_13Export
{
    public class Commonlogic
    {
        private string _getSqlStmt = string.Empty;
        SqlConnection _objCon = new SqlConnection();//create object of sqlconnection
        SqlDataAdapter _objSqlAdp;//Create object of SqldataAdapter
        DataTable _objDTable = new DataTable();//Create object of datatable  
        StringBuilder objSelect;
        #region GetConnectionString
        /// <summary>
        /// Name:GetConnectionString
        /// Description:In this get connectionstring from web.config file  
        /// Author:Monal shah
        /// created date:2010/11/26
        /// </summary>
        public static string GetConnectionString
        { get { return System.Configuration.ConfigurationManager.AppSettings["connection"].ToString(); } }
        #endregion
        #region GetFilePath
        /// <summary>
        /// Name:GetFilePath
        /// Description:In this get Filepath from web.config file  
        /// Author:Monal shah
        /// created date:2010/11/26
        /// </summary>
        public static string GetFilePath
        { get { return System.Configuration.ConfigurationManager.AppSettings["UploadFile"].ToString(); } }
        #endregion
        #region GetSqlStmt
        /// <summary>
        /// Name:GetSqlStmt
        /// Description:In this get n set the value of the sql query.   
        /// Author:Monal shah
        /// created date:2010/11/26
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
        /// created date:2010/11/26
        /// </summary>
        public DataTable DataTables()
        {
            try
            {
                _objCon.ConnectionString = GetConnectionString;//get connection string and assign into sqlconneobjCultureInfoton object 
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
        #region SelectQuery
        /// <summary>       
        /// Name:SelectQuery
        /// Description:Fire Query and return the getsqlstmt
        /// Author:Monal shah
        /// created date:2010/11/26
        /// </summary>      
        /// <param name="strTableName"></param>
        /// <returns></returns>
        public string SelectQuery(string strTableName)
        {
            objSelect = new StringBuilder();
            try
            {
                objSelect.Append("SELECT ");               
                objSelect.Append("TitleOfCourtesy+' '+FirstName+' '+LastName As Name");
                objSelect.Append(",");
                objSelect.Append("Convert(varchar,BirthDate,111) As BirthDate");
                objSelect.Append(",");
                objSelect.Append("Address");
                objSelect.Append(",");
                objSelect.Append("PostalCode ");
                objSelect.Append("From ");
                objSelect.Append(strTableName);
                GetSqlStmt = objSelect.ToString();
                return GetSqlStmt;
            }
            catch (Exception ex)
            { throw ex; }
            finally
            { objSelect = null; }
        }
        #endregion
    }
}