
namespace Day_5_9
{
    public class Constant
    {
        //DECLARATION OF STRING STRDELEMP ***************************************************************************************************
        public const string strDelEmp = "delete from Employees where EmployeeID= ";
        //DECLARATION OF CONSTANT STRING SELECT **************************************************************************************************************************************************************************************************************
        public const string strSel = "SELECT ";
        //DECLARATION OF CONSTANT STRING FOR SELECTING ALL COLUMNS FROM A TABLE ******************************************************************************************************************************************************************************
        public const string strAll = "* ";
        //DECLARATION OF CONSTANT STRING CUSTOMERS  ******************************************************************************************
        public const string strCustomers = " Customers";
        //DECLARATION OF STRNIG FOR SELECTING FIRST NAME LAST NAME IN A SINGLE COLUMN ************************************************************************************************************************************************************************
        public const string strAllEmpSpcl = "EmployeeID,(TitleOfCourtesy+FirstName+LastName) as Name,LastName,FirstName,Title,TitleOfCourtesy,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone,Extension,Notes,ReportsTo ";
        //DECLARATION OF CONSTANT STRING from ****************************************************************************************************************************************************************************************************************
        public const string strFrom = "from ";
        //DECLARATION OF CONSTANT STRING EMPLOYEES ***********************************************************************************************************************************************************************************************************
        public const string strEmp = "Employees";
        //DECLARATION OF MESSEGE SORRY NO DATA FOUND *********************************************************************************************************************************************************************************************************
        public const string strSorry = "Sorry! No data found";
        //DECLARATION OF STRING FOR WHERE CLAUSE FOR EMPLOYEE ID IN EMPLOYEES TABLE **************************************************************************************************************************************************************************
        public const string strWhrEmpId = " where EmployeeID = ";
        //DECLARATION OF STRING FOR WHERE CLAUSE FOR Customer ID IN Customers TABLE **************************************************************************************************************************************************************************
        public const string strWhrCustId = " where CustomerID = ";
        //DECLARATION OF STRING STRDELCUST ***************************************************************************************************
        public const string strDelCust = "delete from Customers where CustomerID= ";
        //DECLARATION OF STRING FOR SELECTING ALL COULMNS FOR CUSTOMERS TABLE ******************************
        public const string strSelAllCust = "Select * from Customers";
        //DECLARING THE STRING FOR EMPLOYEETERRITORIES  ****************************************************
        public const string strEmpTerr = " EmployeeTerritories ";
        //DECLARING A CONSTANT STRING TO SELECT DISTINCT TERRITORYDESCRIPTION FROM TABLE EMPLOYEETERRITORIES ************************************* 
        public const string strSelDes = "select distinct territoryDescription from Territories t , EmployeeTerritories ET where  t.territoryId = ET.territoryId and  ET.employeeid = ";
        //CONSTANT STRING **************************************************************************************************
        public const string strAllEmp = "Select  Employees.EmployeeID,  Employees.LastName,  Employees.FirstName,  Employees.Title,  Employees.TitleOfCourtesy,  Employees.BirthDate,  Employees.HireDate,  Employees.Address,  Employees.City,   Employees.Region,  Employees.PostalCode,  Employees.Country,  Employees.HomePhone,  Employees.Extension,  Employees.Notes,  Employees.ReportsTo  FROM   Employees";
        public const string strAllEmp1 = "Delete E From Employees E  Where  E.EmployeeId  =  ";
        public const string strdelterr = "Delete  EmployeeTerritories  From EmployeeTerritories et Where  et.EmployeeId  =  ";
        //MESSEGE TO SHOW "RECORD DELETED" **********************************************************************************
        public const string strDelRec = "Record Deleted";
        public const string strDistTerr = "select distinct territoryDescription from territories t, employeeterritories et where t.territoryid=et.territoryid and et.employeeid=  ";
        public const string strDltEmp = "delete e from employees e where e.employeeid in ";
        public const string strDltEmpTerr = " delete employeeterritories from employeeterritories et where et.employeeid in ";
        public const string strInsrt = "insert into Customers (CustomerID,CompanyName,ContactName,ContactTitle,Address,City,Region,PostalCode,Country,Phone,Fax) values ('";
        //DECLARATION OD STRING DATA INSERTED SUCCESSFULLY ******************************************************************
        public const string strInsrtSccs = "Data inserted successfully...";
        //STRING DATA UPDATED SUCCESSFULLY   ******************************************************************************
        public const string strUpdtSccs = "Data updated successfully ...";
        public const string strSelEmp = "select * from employees";
        //DECLARATION OF STRING SELECT * FROM    ****************************************************************************
        public const string strSelDist = " Select  distinct TerritoryDescription from Territories ";
        public const string strTerDes = "select territorydescription from territories t,employeeterritories et where t.territoryid=et.territoryid and et.employeeid= ";
        public const string strWhrDes = " Select TerritoryID From Territories Where TerritoryDescription = '";
        //DECLARING STRING " select isnull(MaX(employeeId+1),1) as employeeid From Employees "
        public const string strMax = " select isnull(MaX(employeeId+1),1) as employeeid From Employees ";
        public const string strspcl=" Insert INTO  [Employees]  ([EmployeeID],  [LastName],  [FirstName],  [Title],  [TitleOfCourtesy],  [BirthDate],  [HireDate],  [Address],  [City],  [Region],  [PostalCode],  [Country],  [HomePhone],  [Extension],  [Notes],  [ReportsTo])  VALUES  ('";
        public const string strInsrtET = " Insert Into employeeterritories ( [EmployeeID] , [TerritoryID] )  Values  ";
        public const string strPlDel = "Please select at least one record for Delete ";
    }
}
