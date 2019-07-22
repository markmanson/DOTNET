namespace ExerciseProject
{
    #region Suppliers
    /// <summary>
    /// Name:Suppliers.cs
    /// Description:Here Suppliers table value is get and set
    /// Author:Monal shah
    /// created date:2010/09/23
    /// </summary>
    public class Suppliers
    {
        private int _intSupplierID = 0;
        private string _strCompanyName = string.Empty;
        private string _strContactname = string.Empty;
        private string _strContactTitle = string.Empty;
        private string _strAddress = string.Empty;
        private string _strCity = string.Empty;
        private string _strRegion = string.Empty;
        private string _strPostalCode = string.Empty;
        private string _strCountry = string.Empty;
        private string _strPhone = string.Empty;
        private string _strFax = string.Empty;
        private string _strHomePage = string.Empty;
        public int SupplierID
        {
            get { return _intSupplierID; }
            set { _intSupplierID = value; }
        }
        public string CompanyName
        {
            get { return _strCompanyName; }
            set { _strCompanyName = value; }
        }
        public string ContactName
        {
            get { return _strContactname; }
            set { _strContactname = value; }
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
        public string HomePage
        {
            get { return _strHomePage; }
            set { _strHomePage = value; }
        }
    }
    #endregion
}
