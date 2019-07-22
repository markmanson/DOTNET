using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace Day_2_4
{
    public class Constant
    {
        public const string strQueryTerrit = " select * from Territories ";
        public const string strQueryEmpTerr = " SELECT * FROM EmployeeTerritories WHERE EmployeeID= ";
        public const string strQueryEmpDelete = " DELETE from Employees where EmployeeID= ";
        public const string strMsgDelete = "Data Deleted successfully ...";
        public const string strMsgUpdate = "Data updated successfully ...";
        public const string strConnStr = "NorthwindConnectionString";
        public const string strCatcExceptn = "Error.aspx";
        public const string strRedirect = "Add_Emp.aspx";
        public const string strRedirectEmpTer = "EmployeeTerritories.aspx";
        public const string strQryEmp = " SELECT * FROM Employees WHERE EmployeeID= ";
        public const string strNotFound = "Data Not Found";
        public const string strEmpid = "Empid";
        public const string strempid = "empid";
        public const string strBuil1 =" Select ";
        public const string strBuil2 = " * ";
        public const string strBuil3 = " From ";
        public const string strBuil4 = " Employees ";
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
        public const string strFstName = "FirstName";
        public const string strLstName = "LastName";
        public const string strTitle = "Title";
        public const string strTitleOfCourtesy = "TitleOfCourtesy";
        public const string strBirthDate = "BirthDate";
        public const string strHireDate = "HireDate";
        public const string strAddress= "Address";
        public const string strCity = "City";
        public const string strRegion = "Region";
        public const string strPostalCode = "PostalCode";
        public const string strCountry = "Country";
        public const string strHomePhone = "HomePhone";
        public const string strExtension = "Extension";
        public const string strPhoto = "Photo";
        public const string strNotes = "Notes";
        public const string strReportsTo = "ReportsTo";
        public const string strPhotoPath = "PhotoPath";
        public const string strInsertEmp = " INSERT INTO Employees ";
        public const string strMsgInsert = "Data Iserted successfully ...";
        public const string strQryUpdate = " UPDATE Employees SET ";
        public const string strWhereEid = " WHERE EmployeeID= ";
    }
}
