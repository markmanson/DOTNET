using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Configuration;

namespace CABApplication
{
    class CommonLogic
    {
        StringBuilder objsb;
        string Query;
        DataTable objDt;
        private string _getSqlStmt = string.Empty;
        SqlConnection _objCon = new SqlConnection();//create object of sqlconnection
        SqlDataAdapter _objSqlAdp;//Create object of SqldataAdapter
        DataTable _objDTable;//Create object of datatable      

        #region GetConnectionString
        /// <summary>
        /// Name:GetConnectionString
        /// Description:In this get connectionstring from web.config file  
        /// Author:Monal shah
        /// created date:2010/12/20
        /// </summary>
        public static string GetConnectionString
        {
            get { return ConfigurationSettings.AppSettings["connection"].ToString(); }
        }
        #endregion
        #region GetSqlStmt
        /// <summary>
        /// Name:GetSqlStmt
        /// Description:In this get n set the value of the sql query.   
        /// Author:Monal shah
        /// created date:2010/12/6
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
        /// created date:2010/12/20
        /// </summary>
        public DataTable DataTables()
        {
            try
            {
                _objDTable = new DataTable();
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
        #region BindGrid
        /// <summary>
        /// Name:BindGrid       
        /// Description:Bind Grid
        /// Author:Monal shah
        /// created date:2010/12/20
        /// </summary>
        /// <param name="TableName"></param>
        /// <param name="Value"></param>
        /// <returns>Datatable</returns>
        public DataTable BingGrid(string TableName, int PageSize, int CurrentPageIndex)
        {
            try
            {
                objDt = new DataTable();
                objsb = new StringBuilder();
                objsb.Append("SELECT TOP 5 DetailsOfEmployee.Name, DetailsOfEmployee.Sex, DetailsOfEmployee.Email,");
                objsb.Append("DetailsOfEmployee.DOB,DetailsOfEmployee.FaxNo, DetailsOfEmployee.Salary, TblCountry.Country_Name,");
                objsb.Append("TblCity.City_Name, TblState.State_Name FROM DetailsOfEmployee ");
                objsb.Append(" INNER JOIN TblCountry ON DetailsOfEmployee.Country_Id = TblCountry.Country_Id INNER JOIN TblCity ");
                objsb.Append(" ON DetailsOfEmployee.City_Id = TblCity.City_Id INNER JOIN TblState ON TblCountry.Country_Id = TblState.Country_Id ");
                objsb.Append(" AND TblCity.State_Id = TblState.State_Id WHERE(DetailsOfEmployee.Emp_ID NOT IN (SELECT TOP ");
                objsb.Append(PageSize * (CurrentPageIndex - 1));
                objsb.Append(" Emp_ID FROM DetailsOfEmployee AS DetailsOfEmployee_1 ORDER BY Emp_ID))ORDER BY DetailsOfEmployee.Emp_ID");
                GetSqlStmt = objsb.ToString();
                objDt = DataTables();
                return objDt;
            }
            catch (Exception exException) { throw exException; }
            finally { objDt = null; }
        }
        #endregion
        public int MaxRecord(string TableName)
        {
            try
            {
                objsb = new StringBuilder();
                objsb.Append("SELECT COUNT(*) FROM ");
                objsb.Append(TableName);
                SqlConnection objCon = new SqlConnection(GetConnectionString);
                if (objCon.State == ConnectionState.Closed)
                    objCon.Open();
                SqlCommand objCmd = new SqlCommand();
                objCmd.Connection = objCon;
                objCmd.CommandType = CommandType.Text;
                objCmd.CommandText = objsb.ToString();
                int intValue = System.Convert.ToInt32(objCmd.ExecuteScalar());
                return intValue;
            }
            catch (Exception ex) { throw ex; }
        }
        public int PageSize(string TableName, string ScreenName)
        {
            try
            {
                objsb = new StringBuilder();
                objsb.Append("SELECT ValueField From ");
                objsb.Append(TableName);
                objsb.Append(" Where ");
                objsb.Append(" Key1 ");
                objsb.Append("=");
                objsb.Append("'");
                objsb.Append(ScreenName);
                objsb.Append("'");
                SqlConnection objCon = new SqlConnection(GetConnectionString);
                if (objCon.State == ConnectionState.Closed)
                    objCon.Open();
                SqlCommand objCmd = new SqlCommand();
                objCmd.Connection = objCon;
                objCmd.CommandType = CommandType.Text;
                objCmd.CommandText = objsb.ToString();
                int intValue = Convert.ToInt32(objCmd.ExecuteScalar());
                return intValue;
            }
            catch (Exception ex) { throw ex; }
        }
        #region BindDropDown
        /// <summary>
        /// Name:BindDropDown       
        /// Description:Bind DropDown Value Of Salary And Country
        /// Author:Monal shah
        /// created date:2010/12/20
        /// </summary>
        /// <param name="TableName"></param>
        /// <param name="Value"></param>
        /// <returns>Datatable</returns>
        public DataTable BindDropDown(string TableName, string NameValue)
        {
            try
            {
                objsb = new StringBuilder();
                objDt = new DataTable();
                objsb.Append("Select ");
                objsb.Append("Distinct ");
                objsb.Append(NameValue);
                objsb.Append(" From ");
                objsb.Append(TableName);
                GetSqlStmt = objsb.ToString();
                objDt = DataTables();
                return objDt;
            }
            catch (Exception exException) { throw exException; }

        }
        #endregion
        #region BindDropDown
        /// <summary>
        /// Name:BindDropDown       
        /// Description:Bind DropDown Value Of Salary And Country
        /// Author:Monal shah
        /// created date:2010/12/20
        /// </summary>
        /// <param name="TableName"></param>
        /// <param name="Value"></param>
        /// <returns>Datatable</returns>
        public DataTable BindDropDown(string TableName, string IdValue, string NameValue)
        {
            try
            {
                objsb = new StringBuilder();
                objDt = new DataTable();
                objsb.Append("Select ");
                objsb.Append("Distinct ");
                objsb.Append(NameValue + " As Label");
                objsb.Append(",");
                objsb.Append(IdValue + " As Value");
                objsb.Append(" From ");
                objsb.Append(TableName);
                GetSqlStmt = objsb.ToString();
                objDt = DataTables();
                return objDt;
            }
            catch (Exception exException) { throw exException; }

        }
        #endregion
        #region BindDropDown
        /// <summary>
        /// Name:BindDropDown       
        /// Description:Select Data From The Table
        /// Author:Monal shah
        /// created date:2010/12/20
        /// </summary>
        /// <param name="TableName"></param>
        /// <param name="Value"></param>
        /// <param name="WhereText"></param>
        /// <param name="WhereValue"></param>
        /// <returns>DataTable</returns>
        public DataTable BindDropDown(string TableName, string Value, string WhereText, int WhereValue)
        {
            try
            {
                objsb = new StringBuilder();
                objDt = new DataTable();
                objsb.Append("Select ");
                objsb.Append(" * ");
                objsb.Append(" From ");
                objsb.Append(TableName);
                objsb.Append(" Where ");
                objsb.Append(WhereText);
                objsb.Append("=");
                objsb.Append("'");
                objsb.Append(WhereValue);
                objsb.Append("'");
                GetSqlStmt = objsb.ToString();
                objDt = DataTables();
                return objDt;
            }
            catch (Exception exException) { throw exException; }
        }
        #endregion
        #region BindDropDown
        /// <summary>
        /// Name:BindDropDown       
        /// Description:Select Data From The Table
        /// Author:Monal shah
        /// created date:2010/12/20
        /// </summary>
        /// <param name="Value"></param>
        /// <param name="TableName"></param>
        /// <param name="OtherTable"></param>
        /// <param name="strFirstValue"></param>
        /// <param name="strSecondValue"></param>
        /// <param name="WhereText"></param>
        /// <param name="WhereValue"></param>
        /// <returns></returns>
        public DataTable BindDropDown(string Value, string IdValue, string TableName, string OtherTable, string strFirstValue, string strSecondValue, string WhereText, int WhereValue)
        {
            try
            {
                objDt = new DataTable();
                objsb = new StringBuilder();
                objsb.Append("SELECT ");
                objsb.Append(Value + " AS Label");
                objsb.Append(" , ");
                objsb.Append(IdValue + " AS Value");
                objsb.Append(" FROM ");
                objsb.Append(TableName);
                objsb.Append(" INNER JOIN ");
                objsb.Append(OtherTable);
                objsb.Append(" ON ");
                objsb.Append(strFirstValue);
                objsb.Append("=");
                objsb.Append(strSecondValue);
                objsb.Append(" WHERE ");
                objsb.Append(WhereText);
                objsb.Append("=");
                objsb.Append("'");
                objsb.Append(WhereValue);
                objsb.Append("'");
                GetSqlStmt = objsb.ToString();
                objDt = DataTables();
                return objDt;
            }
            catch (Exception exException) { throw exException; }

        }
        #endregion
    }
}
