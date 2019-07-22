namespace Day5
{
    #region Constant
    /********************************************************************************************************************************************
       * CLASS NAME                                   :::                     CONSTANT               
       * AUTHOR NAME                                  :::                     ANKIT SHARMA
       * DATE                                         :::                     13/09/2012
       * DESCRIPTION                                  :::                     TO DECLARE ALL THE CONSTANT STRINGS USED IN THIS PROJECT
       * ******************************************************************************************************************************************/
    public class Constant
    {
        //DECLARATION OF CONSTANT STRING STRSERVER TIME ****************************************************************
        public const string strServrTime = "Date of server side ";
        //CONSTANT STRING FOR SQL CONNECTION NAME  *********************************************************************
        public const string strCon_Name = "SQLConnection";
        //DECLARATION OF CONSTANT STRING ERROR.ASPX ********************************************************************
        public const string strError = "Error.aspx";
        //DECLARATION OF THE CONSTANT STRING DETAILS  ******************************************************************
        public const string strDetails = "Details";
        //DECLARATION OF CONSTANT STRING FOR SELECT QUERY **************************************************************
        public const string strSelQuery = "Select * From Employees";
        //DECLARATION OF CONSTANT STRING QUERY WHERE ENAME IS GIVEN ****************************************************
        public const string strQuery_Where = "Select FirstName,City,Country,HomePhone from Employees where EmployeeID='";
        //DECLARATION OF CONSTANT STRING ENAME ************************************************************************
        public const string strFName = "FirstName";
        //DECLARATION OF CONSTANT STRING "'" ***************************************************************************
        public const string strQuote = "'";
        //DECLARATION OF STRING MESSEGE FOR CACHE **********************************************************************
        public const string strCacheMsg = "This page is use to store the drop down list into cache.. To see click the button";
        //DECLARATION OF STRING DDL  ***********************************************************************************
        public const string strDDL = "DDL";
        //DECLARATION OF MESSEGE TO SHOW THAT DATA IS COMMING FROM CACHE  **********************************************
        public const string strFrm_Cache = "Data is comming from CACHE";
        //DECLARATION OF MESSEGE TO SHOW THAT DATA IS COMMING FROM DATA-BASE  ******************************************
        public const string strFrmDB = "Data is comming from DATA-BASE";
        //DECLARATION OF STRING EMPLOYEEID  ****************************************************************************
        public const string strEmpID = "EmployeeID";
        //DECLARATION OF STRING Check_Cache_Value.aspx *****************************************************************
        public const string strDis_Cache = "Check_Cache_Value.aspx";
        //DECLARATION OF MESSEGE TO SHOW THAT CONTROL IS COMMING FROM CACHE  *******************************************
        public const string strCtrlCache = "This is the control from cache";
        //DECLARATION OF MESSEGE TO SHOW THAT CACHE IS NULL  ***********************************************************
        public const string strCacheNull = "Cache is null";
    }
    #endregion Constant
}
