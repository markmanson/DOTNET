using System;
using System.Text;
using ExerciseProject.Class_File;

namespace ExerciseProject
{
    #region EmployeeInsert
    /// <summary>
    /// Name:EmployeeInsert
    /// Description:Here Employee's table value is get and set
    /// and perform the insert upadte delete operation and also perform update with the Sqltransaction
    /// Author:Monal shah
    /// created date:2010/09/23
    /// </summary>
    public class EmployeeInsert
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
        private int _strReportsTo =0;
        StringBuilder sbInsertValue,sbUpdateValue,sbDeleteValue;
        Commonlogic objcl = new Commonlogic();//create object of the commonlogic class
        EmployeesDataset objEmpDataSet = new EmployeesDataset();//object of the typed dataset is created
        
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
            set { _Bdate= value; }
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
            set { _strCity= value; }
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
        #region InsertEmployee
        /// <summary>
        /// Name:InsertEmployeebool
        /// Description:in this method fire the insert query using stringbuilder   
        /// Author:Monal shah
        /// created date:2010/09/23
        /// </summary>
        /// <returns>bool</returns>
        public bool InsertEmployee()
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
            return objcl.ExecuteNonQuery();//call ExecuteNonQuery method
        }
        #endregion
        #region UpdateEmployee
        /// <summary>
        /// Name:UpdateEmployee
        /// Description:in this method fire the update query using stringbuilder   
        /// Author:Monal shah
        /// created date:2010/09/23
        /// </summary>
        /// <returns>bool</returns>
        public bool UpdateEmployee()
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
            return objcl.ExecuteNonQuery();//call ExecuteNonQuery method
        }
        #endregion
        #region DeleteEmployee
        /// <summary>
        /// Name:DeleteEmployee
        /// Description:in this method fire the delete query using stringbuilder   
        /// Author:Monal shah
        /// created date:2010/09/23
        /// </summary>
        /// <returns>bool</returns>
        public bool DeleteEmployee()
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

            objcl.GetSqlStmt = sbDeleteValue.ToString();
            return objcl.ExecuteNonQuery();//call ExecuteNonQuery method
          
        }
        #endregion
        
        
    }
    #endregion
}
