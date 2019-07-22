
namespace Day5_9
{
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- Constant
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- The Class Allow user to use costant
    //      CREATED DATE    :- 2012/08/06
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public class Constant
    {
        public const string strQueryTerrit = " select * from Territories ";
        public const string strQueryEmpTerr = " SELECT * FROM EmployeeTerritories WHERE EmployeeID= ";
        public const string strQueryEmpDelete = " DELETE from Employees where EmployeeID= ";
        public const string strQueryCustDelete = " DELETE from Customers where CustomerID= ";
        public const string strMsgDelete = "Data Deleted successfully ...";
        public const string strMsgUpdate = "Data updated successfully ...";
        public const string strConnStr = "NorthwindConnectionString";
        public const string strCatcExceptn = "Error.aspx";
        public const string strDefault = "Default.aspx";
        public const string strRedirect = "Add_Emp.aspx";
        public const string strUpdateTypeDS = "UpdateTypeDS.aspx";
        public const string strAddEmpterritory = "AddEmpterritory.aspx";
        public const string strAddCustomer = "AddCustomer.aspx";
        public const string strCustomer = "Customer.aspx";
        public const string strRedirectEmpTer = "EmployeeTerritories.aspx";
        public const string strQryEmp = " SELECT * FROM Employees WHERE EmployeeID= ";
        public const string strQryCustomer = " SELECT * FROM Customers WHERE CustomerID= ";
        public const string strNotFound = "Data Not Found";
        public const string strEmpid = "Empid";
        public const string strempid = "empid";
        public const string strBuil1 = " Select ";
        public const string strBuil2 = " * ";
        public const string strBuil3 = " From ";
        public const string strBuil4 = " Employees ";
        public const string strCustomers = " Customers ";
        public const string strBuil5 = "Employees";
        public const string strBuil6 = "mydataset";
        public const string strBuil7 = " Territories ";
        public const string strBuil8 = " EmployeeTerritories ";
        public const string strBuil9 = "EmployeeTerritories";
        public const string strBui20 = " WHERE ";
        public const string strBui21 = " Employees.EmployeeID ";
        public const string strBui22 = " = ";
        public const string strBui23 = " EmployeeTerritories.EmployeeID ";
        public const string strBui24 = " INNER ";
        public const string strBui25 = " JOIN ";
        public const string strBui26 = " ON ";
        public const string strBui27 = " ORDER ";
        public const string strBui28 = " BY ";
        public const string strUpdate = "Update";
        public const string strBuiALL = " ALL ";
        public const string strBuiSup = " Suppliers ";
        public const string strEmpID = "EmployeeID";
        public const string strEmpID2 = " EmployeeId ";
        public const string strIN = " in ";
        public const string strCustID = "CustomerID";
        public const string strFstName = "FirstName";
        public const string strCmpnyName = "CompanyName";
        public const string strLstName = "LastName";
        public const string strCntctName = "ContactName";
        public const string strTitle = "Title";
        public const string strCnctTitle = "ContactTitle";
        public const string strTitleOfCourtesy = "TitleOfCourtesy";
        public const string strBirthDate = "BirthDate";
        public const string strHireDate = "HireDate";
        public const string strAddress = "Address";
        public const string strCity = "City";
        public const string strRegion = "Region";
        public const string strPostalCode = "PostalCode";
        public const string strCountry = "Country";
        public const string strHomePhone = "HomePhone";
        public const string strPhone = "Phone";
        public const string strExtension = "Extension";
        public const string strPhoto = "Photo";
        public const string strNotes = "Notes";
        public const string strFax = "Fax";
        public const string strReportsTo = "ReportsTo";
        public const string strPhotoPath = "PhotoPath";
        public const string strInsertEmp = " INSERT INTO Employees ";
        public const string strInsertCustomer = " INSERT INTO Customers ";
        public const string strMsgInsert = "Data Iserted successfully ...";
        public const string strQryUpdate = " UPDATE Employees SET ";
        public const string strQryCustmrUpdt = " UPDATE Customers SET ";
        public const string strWhereEid = " WHERE EmployeeID= ";
        public const string strWhereCusID = " where CustomerID= ";
        public const string strDefltaspx = "Default.aspx";
        public const string strQuerymax = " select isnull(MaX(employeeId+1),1) as employeeid From Employees ";
        public const string strQueryTerID = " Select TerritoryID From Territories Where TerritoryDescription = ";
        public const string strTerritoryID = "TerritoryID";
        public const string strQryInsertTerritory = " Insert Into employeeterritories ( [EmployeeID] , [TerritoryID] )  Values  ";
        public const string strSemicolon = " ; ";
        public const string strTerritoryDescription = "TerritoryDescription";
        public const string strQeryTerritoryDes = " distinct territoryDescription ";
        public const string strDistnctdister = " distinct territoryDescription ";
        public const string strTer_T = " Territories t , ";
        public const string strTer_Emp =" EmployeeTerritories ET ";
        public const string strTerIdET = " t.territoryId = ET.territoryId ";
        public const string strand = " and ";
        public const string strETid = " ET.employeeid ";
        public const string strDelete = "Record Deleted";
        public const string strqryDelete = " Delete ";
        public const string strPlsDelete = "Please select at least one record for Delete ";
        public const string strEmp_ID=" Employees.EmployeeID, ";
        public const string strLastnm=" Employees.LastName, ";
        public const string strFrstnm = " Employees.FirstName, ";
        public const string strETitle =" Employees.Title, ";
        public const string strttlcur =" Employees.TitleOfCourtesy, ";
        public const string strBrthdate =" Employees.BirthDate, ";
        public const string strHaredate =" Employees.HireDate, ";
        public const string strEAddress =" Employees.Address, ";
        public const string strECity =" Employees.City, ";
        public const string strERegion = " Employees.Region, ";
        public const string strEPostlCode = " Employees.PostalCode, ";
        public const string strECountry =" Employees.Country, ";
        public const string strEHmphn =" Employees.HomePhone, ";
        public const string strEExtensn =" Employees.Extension, ";
        public const string strENotes =" Employees.Notes, ";
        public const string strEReportsTo = " Employees.ReportsTo ";
        public const string strLstTerritoryDescrip = "LstTerritoryDescription";
        public const string strchkSelectAll = "chkSelectAll";
        public const string strchkSelect = "chkSelect";


    }
}
