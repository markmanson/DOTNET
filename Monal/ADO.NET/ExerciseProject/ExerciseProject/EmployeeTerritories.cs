using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using ExerciseProject.Class_File;

namespace ExerciseProject
{
    #region EmployeeTerritories
    /// <summary>
    /// Name:EmployeeTerritories
    /// Description:Here EmployeeTerritories's table value is get and set
    /// and perform the insert upadte delete operation 
    /// Author:Monal shah
    /// created date:2010/10/01
    /// </summary>
    public class EmployeeTerritories
    {
        private int _intEmpID = 0;
        private string _strLName = string.Empty;
        private string _strFname = string.Empty;
        private string _strTitle = string.Empty;
        private string _strSalutation = string.Empty;
        private string _Bdate;
        private string _Hdate;
        private string _strAddress = string.Empty;
        private string _strCity = string.Empty;
        private string _strRegion = string.Empty;
        private string _strPostalCode = string.Empty;
        private string _strCountry = string.Empty;
        private string _strHomePhone = string.Empty;
        private string _strExtension = string.Empty;
        private string _strNotes = string.Empty;
        private int _strReportsTo = 0;
        private string _strEmpTerritoryID = string.Empty;
        private string _strTerritoryDescription = string.Empty;
      
        StringBuilder sbInsertValue, sbUpdateValue, sbDeleteValue,sbMultipleDelete;
        Commonlogic objcl = new Commonlogic();//create object of the commonlogic class      
        DataTable objDtable = new DataTable();
        public int EmpID
        {
            get { return _intEmpID; }
            set { _intEmpID = value; }
        }
        public string LName
        {
            get { return _strLName; }
            set { _strLName = value; }
        }
        public string FName
        {
            get { return _strFname; }
            set { _strFname = value; }
        }
        public string Title
        {
            get { return _strTitle; }
            set { _strTitle = value; }
        }
        public string Salutation
        {
            get { return _strSalutation; }
            set { _strSalutation = value; }
        }
        public string BirthDate
        {
            get { return _Bdate; }
            set { _Bdate = value; }
        }
        public string HireDate
        {
            get { return _Hdate; }
            set { _Hdate = value; }
        }
        public string Address
        {
            get { return _strAddress; }
            set { _strAddress = value; }
        }
        public string City
        {
            get { return _strCity; }
            set { _strCity = value; }
        }
        public string Region
        {
            get { return _strRegion; }
            set { _strRegion = value; }
        }
        public string PostalCode
        {
            get { return _strPostalCode; }
            set { _strPostalCode = value; }
        }
        public string Country
        {
            get { return _strCountry; }
            set { _strCountry = value; }
        }
        public string Homephone
        {
            get { return _strHomePhone; }
            set { _strHomePhone = value; }
        }
        public string Extension
        {
            get { return _strExtension; }
            set { _strExtension = value; }
        }
        public string Notes
        {
            get { return _strNotes; }
            set { _strNotes = value; }
        }
        public int ReportsTo
        {
            get { return _strReportsTo; }
            set { _strReportsTo = value; }
        }
       public string TerritoryID
        {
            get { return _strEmpTerritoryID; }
            set { _strEmpTerritoryID = value; }
        }
       public string TerritoryDescription
       {
           get { return _strTerritoryDescription; }
           set { _strTerritoryDescription = value; }
       }
      
        #region InsertEmployeeTerritories
        /// <summary>
        /// Name:InsertEmployeeTerritories
        /// Description:in this method fire the insert query using stringbuilder   
        /// Author:Monal shah
        /// created date:2010/10/01
        /// </summary>
        /// <returns>bool</returns>
       public bool InsertEmployeeTerritories()
       {
           sbInsertValue = new StringBuilder();
           sbInsertValue.Append("Insert ");
           sbInsertValue.Append("Into ");
           sbInsertValue.Append("Employees ");
           sbInsertValue.Append("values");
           sbInsertValue.Append("(");
           sbInsertValue.Append("'");
           sbInsertValue.Append(_strLName);
           sbInsertValue.Append("'");
           sbInsertValue.Append(",");
           sbInsertValue.Append("'");
           sbInsertValue.Append(_strFname);
           sbInsertValue.Append("'");
           sbInsertValue.Append(",");
           sbInsertValue.Append("'");
           sbInsertValue.Append(_strTitle);
           sbInsertValue.Append("'");
           sbInsertValue.Append(",");
           sbInsertValue.Append("'");
           sbInsertValue.Append(_strSalutation);
           sbInsertValue.Append("'");
           sbInsertValue.Append(",");
           sbInsertValue.Append("'");
           sbInsertValue.Append(_Bdate);
           sbInsertValue.Append("'");
           sbInsertValue.Append(",");
           sbInsertValue.Append("'");
           sbInsertValue.Append(_Hdate);
           sbInsertValue.Append("'");
           sbInsertValue.Append(",");
           sbInsertValue.Append("'");
           sbInsertValue.Append(_strAddress);
           sbInsertValue.Append("'");
           sbInsertValue.Append(",");
           sbInsertValue.Append("'");
           sbInsertValue.Append(_strCity);
           sbInsertValue.Append("'");
           sbInsertValue.Append(",");
           sbInsertValue.Append("'");
           sbInsertValue.Append(_strRegion);
           sbInsertValue.Append("'");
           sbInsertValue.Append(",");
           sbInsertValue.Append("'");
           sbInsertValue.Append(_strPostalCode);
           sbInsertValue.Append("'");
           sbInsertValue.Append(",");
           sbInsertValue.Append("'");
           sbInsertValue.Append(_strCountry);
           sbInsertValue.Append("'");
           sbInsertValue.Append(",");
           sbInsertValue.Append("'");
           sbInsertValue.Append(_strHomePhone);
           sbInsertValue.Append("'");
           sbInsertValue.Append(",");
           sbInsertValue.Append("'");
           sbInsertValue.Append(_strExtension);
           sbInsertValue.Append("'");
           sbInsertValue.Append(",");
           sbInsertValue.Append("'");
           sbInsertValue.Append("'");
           sbInsertValue.Append(",");
           sbInsertValue.Append("'");
           sbInsertValue.Append(_strNotes);
           sbInsertValue.Append("'");
           sbInsertValue.Append(",");
           sbInsertValue.Append("'");
           sbInsertValue.Append(_strReportsTo);
           sbInsertValue.Append("'");
           sbInsertValue.Append(",");
           sbInsertValue.Append("'");
           sbInsertValue.Append("'");
           sbInsertValue.Append(")");

           objcl.GetSqlStmt = sbInsertValue.ToString();
           return objcl.TransactionExecuteNonQuery();//call ExecuteNonQuery method
       }
        #endregion
        #region UpdateEmployeeTerritories
        /// <summary>
        /// Name:UpdateEmployeeTerritories
        /// Description:in this method fire the update query using stringbuilder   
        /// Author:Monal shah
        /// created date:2010/10/01
        /// </summary>
        /// <returns>bool</returns>
        public bool UpdateEmployeeTerritories()
        {
            sbUpdateValue = new StringBuilder();

            sbUpdateValue.Append("Update ");
            sbUpdateValue.Append("Employees ");
            sbUpdateValue.Append("Set ");
            sbUpdateValue.Append("LastName");
            sbUpdateValue.Append("=");
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(_strLName);
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(",");
            sbUpdateValue.Append("FirstName");
            sbUpdateValue.Append("=");
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(_strFname);
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(",");
            sbUpdateValue.Append("Title");
            sbUpdateValue.Append("=");
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(_strTitle);
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(",");
            sbUpdateValue.Append("HireDate");
            sbUpdateValue.Append("=");
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(_Hdate);
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(",");
            sbUpdateValue.Append("Address");
            sbUpdateValue.Append("=");
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(_strAddress);
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(",");
            sbUpdateValue.Append("City");
            sbUpdateValue.Append("=");
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(_strCity);
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(",");
            sbUpdateValue.Append("Region");
            sbUpdateValue.Append("=");
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(_strRegion);
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(",");
            sbUpdateValue.Append("PostalCode");
            sbUpdateValue.Append("=");
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(_strPostalCode);
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(",");
            sbUpdateValue.Append("country");
            sbUpdateValue.Append("=");
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(_strCountry);
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(",");
            sbUpdateValue.Append("HomePhone");
            sbUpdateValue.Append("=");
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(_strHomePhone);
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(",");
            sbUpdateValue.Append("Extension");
            sbUpdateValue.Append("=");
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(_strExtension);
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(",");
            sbUpdateValue.Append("Notes");
            sbUpdateValue.Append("=");
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(_strNotes);
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(",");
            sbUpdateValue.Append("ReportsTo");
            sbUpdateValue.Append("=");
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(_strReportsTo);
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(" where ");
            sbUpdateValue.Append("EmployeeID");
            sbUpdateValue.Append("=");
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(_intEmpID);
            sbUpdateValue.Append("'");

            objcl.GetSqlStmt = sbUpdateValue.ToString();
            return objcl.TransactionExecuteNonQuery();//call ExecuteNonQuery method
        }
        #endregion
        #region DeleteEmployeeTerritories
        /// <summary>
        /// Name:DeleteEmployeeTerritories
        /// Description:in this method fire the delete query using stringbuilder   
        /// Author:Monal shah
        /// created date:2010/10/01
        /// </summary>
        /// <returns>bool</returns>
        public bool DeleteEmployeeTerritories()
        {
            sbDeleteValue = new StringBuilder();
           
            sbDeleteValue.Append("DELETE ");
            sbDeleteValue.Append("FROM ");
            sbDeleteValue.Append("Employees ");
            sbDeleteValue.Append("WHERE ");
            sbDeleteValue.Append("EmployeeID");
            sbDeleteValue.Append("=");
            sbDeleteValue.Append("'");
            sbDeleteValue.Append(_intEmpID);
            sbDeleteValue.Append("'");

            sbDeleteValue.Append("DELETE ");
            sbDeleteValue.Append("FROM ");
            sbDeleteValue.Append("EmployeeTerritories ");
            sbDeleteValue.Append("WHERE ");
            sbDeleteValue.Append("EmployeeID");
            sbDeleteValue.Append("=");
            sbDeleteValue.Append("'");
            sbDeleteValue.Append(_intEmpID);
            sbDeleteValue.Append("'");

            objcl.GetSqlStmt = sbDeleteValue.ToString();
            return objcl.TransactionExecuteNonQuery();//call ExecuteNonQuery method

        }
        #endregion   
        #region DeleteEmployeeTerritories
        /// <summary>
        /// Name:DeleteEmployeeTerritories
        /// Description:in this method fire the delete query using stringbuilder   
        /// Author:Monal shah
        /// created date:2010/10/06
        /// </summary>
        /// <returns>bool</returns>
        public void DeleteMultipleRecords(StringCollection idCollection)
        {
            //Create sql Connection and Sql Command
            string IDs = string.Empty;         
        
            foreach (string id in idCollection)
            {
                IDs += id.ToString() + ",";
            }
            try
            {

                string strIDs = IDs.Substring(0, IDs.LastIndexOf(","));
                    
                    sbMultipleDelete = new StringBuilder();

                    sbMultipleDelete.Append("DELETE ");
                    sbMultipleDelete.Append("FROM ");
                    sbMultipleDelete.Append("Employees ");
                    sbMultipleDelete.Append("WHERE ");
                    sbMultipleDelete.Append("EmployeeID ");
                    sbMultipleDelete.Append("IN ");
                    sbMultipleDelete.Append("(");
                    sbMultipleDelete.Append(strIDs);
                    sbMultipleDelete.Append(")");

                    sbMultipleDelete.Append("DELETE ");
                    sbMultipleDelete.Append("FROM ");
                    sbMultipleDelete.Append("EmployeeTerritories ");
                    sbMultipleDelete.Append("WHERE ");
                    sbMultipleDelete.Append("EmployeeID ");
                    sbMultipleDelete.Append("IN ");
                    sbMultipleDelete.Append("(");                  
                    sbMultipleDelete.Append(strIDs);
                    sbMultipleDelete.Append(")");


                    objcl.GetSqlStmt = sbMultipleDelete.ToString();
                    objcl.TransactionExecuteNonQuery();//call ExecuteNonQuery method


                
            }
            catch (SqlException ex)
            {
                string errorMsg = "Error in Deletion";
                errorMsg += ex.Message;

            }
            finally
            {
                objcl = null;
                sbMultipleDelete = null;
            }
        }
        #endregion


    }
    #endregion
}
