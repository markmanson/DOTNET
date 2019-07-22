namespace Day2_4
{
    #region Constant
    /*********************************************************************************************************************************************************************************************************************************************************
         NAME                               ::::                    CONSTANT
         AUTHOR                             ::::                    ANKIT
         DATE                               ::::                    13-07-2012
         DESCRIPTION                        ::::                    TO DEFINE ALL THE CONSTANT VARIABLES
        ******************************************************************************************************************************************************************************************************************************************************/
    public class Constant
    {
        //DECLARATION OF CONSTANT STRING SELECT **************************************************************************************************************************************************************************************************************
        public const string strSel = "SELECT ";
        //DECLARATION OF CONSTANT STRING ALL *****************************************************************************************************************************************************************************************************************
        public const string strAll = "* ";
        //DECLARATION OF CONSTANT STRING from ****************************************************************************************************************************************************************************************************************
        public const string strFrom = "from ";
        //DECLARATION OF CONSTANT STRING EMPLOYEETERRITORIES *************************************************************************************************************************************************************************************************
        public const string strEmpterr = "EmployeeTerritories";
        //DECLARATION OF CONSTANT STRING TERRITORIES *********************************************************************************************************************************************************************************************************
        public const string strTerr = "Territories";
        //DECLARATION OF CONSTANT STRING EMPLOYEES ***********************************************************************************************************************************************************************************************************
        public const string strEmp = "Employees";
        //DECLARATION OF MESSEGE SORRY NO DATA FOUND *********************************************************************************************************************************************************************************************************
        public const string strSorry="Sorry! No data found";
        //DECLARING THE STRING FOR SELECTING FROM TABLE EMPLOYEES BY COLUMN NAME ***************************************************************************************************************************************************************************** 
        public const string strAllEmp = "EmployeeID,FirstName,LastName,Title,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone,Extension,Photo,Notes,ReportsTo,PhotoPath ";
        //DECLARATION OF STRNIG FOR SELECTING FIRST NAME LAST NAME IN A SINGLE COLUMN ************************************************************************************************************************************************************************
        public const string strAllEmpSpcl = "EmployeeID,(TitleOfCourtesy+FirstName+LastName) as Name,LastName,FirstName,Title,TitleOfCourtesy,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone,Extension,Notes,ReportsTo ";
        //DECLARATION OF STRING FOR WHERE CLAUSE FOR EMPLOYEE ID IN EMPLOYEES TABLE **************************************************************************************************************************************************************************
        public const string strWhrEmpId = " where EmployeeID = ";
        //DECLARATION OF STRING FOR SUPPLIERS ****************************************************************************************************************************************************************************************************************       
        public const string strSupp = " Suppliers";
        //DECLARATION OF STRING STRDELEMP ***************************************************************************************************
        public const string strDelEmp = "delete from Employees where EmployeeID= ";
    }
    #endregion Constant
}
