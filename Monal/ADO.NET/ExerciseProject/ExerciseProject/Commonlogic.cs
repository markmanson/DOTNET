using System;
using System.Data;
using System.Data.SqlClient;

namespace ExerciseProject.Class_File
{
    public class Commonlogic
    {
        private string _getSqlStmt = string.Empty;
        SqlConnection _objCon = new SqlConnection();//create object of sqlconnection
        SqlDataAdapter _objSqlAdp;//Create object of SqldataAdapter
        DataTable _objDTable = new DataTable();//Create object of datatable
        EmployeesDataset _objEmpSet = new EmployeesDataset();//create object of EmployeeDataset
        SqlCommand _objCmd;//create object of sqlcommand
        SqlTransaction _objTransaction;
        #region GetConnectionString
        /// <summary>
        /// Name:GetConnectionString
        /// Description:In this get connectionstring from web.config file  
        /// Author:Monal shah
        /// created date:2010/09/20 
        /// </summary>
        public static string GetConnectionString
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["connection"].ToString();
            }
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
        #region TransactionExecuteNonQuery
        /// <summary>
        /// Name:TransactionExecuteNonQuery
        /// return type:bool
        /// Description:In this method Sqltransaction is used to Execute the Sql statements aginst the connection and returns the number rows affected
        /// Author:Monal shah
        /// created date:2010/09/20 
        /// </summary>
        public bool TransactionExecuteNonQuery()
        {
            _objCon.ConnectionString = GetConnectionString;//get connection string and assign into sqlconneciton object 
            _objCmd = new SqlCommand();//create the command object
            //if connection state is close then connection will be open
            if (_objCon.State == ConnectionState.Closed)
            {
                _objCon.Open();
            }
            _objTransaction = _objCon.BeginTransaction(IsolationLevel.ReadCommitted);//create the transaction object 
            _objCmd.Connection = _objCon;//connection value is assign to the command object
            _objCmd.Transaction = _objTransaction;//transaction value is assign to the command object
            _objCmd.CommandText = _getSqlStmt;//get the query statement
            _objCmd.CommandType = CommandType.Text;//Specifies how command sting is interpreted in text
            try
            {
                int intValue = _objCmd.ExecuteNonQuery();//call the executenonQuery method
                //if intvalue is 1 then return true else return false
                if (intValue > 0)
                {
                    _objTransaction.Commit();//commit the database transaction
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch (Exception exException)
            {
                _objTransaction.Rollback();//rollbck a transaction from a pending state
                throw exException;
            }
            finally
            {
                _objCmd.Dispose();
                _objCon.Close();
            }
        }
        #endregion
        #region ExecuteNonQuery
        /// <summary>
        /// Name:ExecuteNonQuery
        /// return type:bool
        /// Description:In this method Execute the Sql statements aginst the connection and returns the number rows affected
        /// Author:Monal shah
        /// created date:2010/09/20 
        /// </summary>
        public bool ExecuteNonQuery()
        {
            _objCon.ConnectionString = GetConnectionString;//get connection string and assign into sqlconneciton object 
            _objCmd = new SqlCommand();//create sqlcommand object        
            //if connection state is close then connection will be open
            if (_objCon.State== ConnectionState.Closed)
            {
                _objCon.Open();
            }
            _objCmd.Connection = _objCon;//connection value is assign to the command object
            _objCmd.CommandText = _getSqlStmt;//get the query statement
            _objCmd.CommandType = CommandType.Text;//Specifies how command sting is interpreted in text
            try
            {
                int intValue = _objCmd.ExecuteNonQuery();//call the executenonQuery method
                //if intvalue is 1 then return true else return false
                if (intValue > 0)
                { return true; }
                else
                { return false; }
            }
            catch (Exception exException)
            {throw exException;}
            finally
            {
                _objCmd.Dispose();
                _objCon.Close();
            }
        }
        #endregion
       
        #region EmpDataTables
        /// <summary>
        /// Name:EmpDataTables
        /// return type:EmployeesDataset
        /// Description:In this the adapter will be filled by EmployeesDataset.   
        /// Author:Monal shah
        /// created date:2010/09/20 
        /// </summary>
        /// <param name="strTblName"></param>
        /// <returns></returns>
        public EmployeesDataset EmpDataTables(string strTblName)
        {
            try
            {
                _objCon.ConnectionString = GetConnectionString;//get connection string and assign into sqlconneciton object 
                _objSqlAdp = new SqlDataAdapter(_getSqlStmt, GetConnectionString);//here adapetr's object created
                _objEmpSet.EnforceConstraints = false;
                _objSqlAdp.Fill(_objEmpSet, strTblName);//fill the adapter by datatable object
                return _objEmpSet;
            }
            catch (Exception exException)
            { throw exException; }
            finally
            {
                _objEmpSet.Dispose();
                _objDTable.Dispose();
                _objSqlAdp.Dispose();
           }

        }
        #endregion
        //public DataTable SelectQuery(string strTable)
        //{
        //    DataTable objDataTable = new DataTable();
        //    GetSqlStmt = "Select * From " + strTable + "";
        //    objDataTable = DataTables();
        //    return objDataTable;

        //}

        #region SelectNWhereQuery
        /// <summary>
        /// Name:SelectNWhereQuery
        /// return type:DataTable
        /// Description:in this method select statement is executed with the where clause.   
        /// Author:Monal shah
        /// created date:2010/09/20 
        /// </summary>
        /// <param name="strTable"></param>
        /// <param name="strWhereField"></param>
        /// <param name="strWhereValue"></param>
        /// <returns></returns>
        public DataTable SelectNWhereQuery(string strTable, string strWhereField, int strWhereValue)
        {
            DataTable objDataTable = new DataTable();
            GetSqlStmt = "Select * From " + strTable + " where " + strWhereField + "=" + strWhereValue + "";
            objDataTable = DataTables();
            return objDataTable;

        }
        #endregion
        #region EmpDataSet
        /// <summary>
        /// Name:EmpDataSet
        /// return type:EmployeesDataset
        /// Description:in this method select statement is executed.   
        /// Author:Monal shah
        /// created date:2010/09/20 
        /// </summary>
        /// <param name="strTable"></param>
        /// <returns></returns>
        public EmployeesDataset EmpDataSet(string strTable)
        {
            EmployeesDataset empData = new EmployeesDataset();
            GetSqlStmt = "Select * From " + strTable + "";
            empData = EmpDataTables(strTable);
            return empData;
        }
        #endregion
        #region EmpDataSet
        /// <summary>
        /// Name:EmpDataSet
        /// return type:EmployeesDataset
        /// Description:in this method get the query value and table value and call the EmpDataTables.   
        /// Author:Monal shah
        /// created date:2010/09/20 
        /// </summary>
        /// <param name="strQuery"></param>
        /// <param name="strTable"></param>
        /// <returns></returns>
        public EmployeesDataset EmpDataSet(string strQuery,string strTable)
        {
            EmployeesDataset empData = new EmployeesDataset();
            GetSqlStmt = strQuery;
            empData = EmpDataTables(strTable);
            return empData;
        }
        #endregion
    }
}