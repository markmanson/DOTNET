using System.Text;
using ExerciseProject.Class_File;

namespace ExerciseProject
{
    #region Customer
    /// <summary>
    /// Name:Customer.cs
    /// Description:Here Customer table value is get and set
    /// Author:Monal shah
    /// created date:2010/09/30
    /// </summary>
    public class Customer
    {
        private string _strCustomerID = string.Empty;
        private string _strCompanyName = string.Empty;
        private string _strContactName = string.Empty;
        private string _strContactTitle = string.Empty;
        private string _strAddress = string.Empty;
        private string _strCity = string.Empty;
        private string _strRegion = string.Empty;
        private string _strPostalCode = string.Empty;
        private string _strCountry = string.Empty;
        private string _strPhone = string.Empty;
        private string _strFax = string.Empty;
        StringBuilder sbInsertValue, sbUpdateValue, sbDeleteValue;
        Commonlogic objcl = new Commonlogic();//create object of the commonlogic class
             
        public string CustomerID
        {
            get { return _strCustomerID; }
            set { _strCustomerID = value; }
        }
        public string CompanyName
        {
            get { return _strCompanyName; }
            set { _strCompanyName = value; }
        }
        public string ContactName
        {
            get { return _strContactName; }
            set { _strContactName = value; }
        }
        public string ContactTitle
        {
            get { return _strContactTitle; }
            set { _strContactTitle = value; }
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
        public string phone
        {
            get { return _strPhone; }
            set { _strPhone = value; }
        }
        public string Fax
        {
            get { return _strFax; }
            set { _strFax = value; }
        }
        #region InsertCustomer
        /// <summary>
        /// Name:InsertCustomer
        /// Description:in this method fire the insert query using stringbuilder   
        /// Author:Monal shah
        /// created date:2010/09/30
        /// </summary>
        /// <returns>bool</returns>
        public bool InsertCustomer()
        {
            sbInsertValue = new StringBuilder();
            sbInsertValue.Append("Insert ");
            sbInsertValue.Append("Into ");
            sbInsertValue.Append("Customers ");
            sbInsertValue.Append("values");
            sbInsertValue.Append("(");
            sbInsertValue.Append("'");
            sbInsertValue.Append(_strCustomerID);
            sbInsertValue.Append("'");
            sbInsertValue.Append(",");
            sbInsertValue.Append("'");
            sbInsertValue.Append(_strCompanyName);
            sbInsertValue.Append("'");
            sbInsertValue.Append(",");
            sbInsertValue.Append("'");
            sbInsertValue.Append(_strContactName);
            sbInsertValue.Append("'");
            sbInsertValue.Append(",");
            sbInsertValue.Append("'");
            sbInsertValue.Append(_strContactTitle);
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
            sbInsertValue.Append(_strPhone);
            sbInsertValue.Append("'");
            sbInsertValue.Append(",");
            sbInsertValue.Append("'");
            sbInsertValue.Append(_strFax);
            sbInsertValue.Append("'");
            sbInsertValue.Append(")");

            objcl.GetSqlStmt = sbInsertValue.ToString();
            return objcl.ExecuteNonQuery();//call ExecuteNonQuery method
        }
        #endregion
        #region UpdateCustomer
        /// <summary>
        /// Name:UpdateCustomer
        /// Description:in this method fire the update query using stringbuilder   
        /// Author:Monal shah
        /// created date:2010/09/30
        /// </summary>
        /// <returns>bool</returns>
        public bool UpdateCustomer()
        {
            sbUpdateValue = new StringBuilder();
            sbUpdateValue.Append("Update ");
            sbUpdateValue.Append("Customers ");
            sbUpdateValue.Append("Set ");
            sbUpdateValue.Append("CustomerID");
            sbUpdateValue.Append("=");
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(_strCustomerID);
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(",");
            sbUpdateValue.Append("CompanyName");
            sbUpdateValue.Append("=");
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(_strCompanyName);
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(",");
            sbUpdateValue.Append("ContactName");
            sbUpdateValue.Append("=");
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(_strContactName);
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(",");
            sbUpdateValue.Append("ContactTitle");
            sbUpdateValue.Append("=");
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(_strContactTitle);
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
            sbUpdateValue.Append("Phone");
            sbUpdateValue.Append("=");
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(_strPhone);
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(",");
            sbUpdateValue.Append("Fax");
            sbUpdateValue.Append("=");
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(_strFax);
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(" where ");
            sbUpdateValue.Append("CustomerID");
            sbUpdateValue.Append("=");
            sbUpdateValue.Append("'");
            sbUpdateValue.Append(_strCustomerID);
            sbUpdateValue.Append("'");

            objcl.GetSqlStmt = sbUpdateValue.ToString();
            return objcl.ExecuteNonQuery();//call ExecuteNonQuery method
        }
        #endregion
        #region DeleteCustomer
        /// <summary>
        /// Name:DeleteCustomer
        /// Description:in this method fire the delete query using stringbuilder   
        /// Author:Monal shah
        /// created date:2010/09/23
        /// </summary>
        /// <returns>bool</returns>
        public bool DeleteCustomer()
        {
            sbDeleteValue = new StringBuilder();
            sbDeleteValue.Append("DELETE ");
            sbDeleteValue.Append("FROM ");
            sbDeleteValue.Append("Customers ");
            sbDeleteValue.Append("WHERE ");
            sbDeleteValue.Append("CustomerID");
            sbDeleteValue.Append("=");
            sbDeleteValue.Append("'");
            sbDeleteValue.Append(_strCustomerID);
            sbDeleteValue.Append("'");

            objcl.GetSqlStmt = sbDeleteValue.ToString();
            return objcl.ExecuteNonQuery();//call ExecuteNonQuery method

        }
        #endregion
        
    }
    #endregion
}
