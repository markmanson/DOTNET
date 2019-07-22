using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
/// <summary>
/// Namespace Name:ADO_Day5_9
/// Description: Typed Dataset,Gridview Databinding and Its Feature & Validation
/// Author:Bhumi
/// Created On:8/6/2015
/// </summary>
namespace ADO_Day5_9
{
    #region Static Messages
    /// <summary>    
    /// Class Name:ConstantMessages
    /// Description: Required Constant Messages through out the Whole Project
    /// Author:Bhumi
    /// Created On:8/6/2015
    /// </summary>
    public class ConstantMessages
    {
        public string strerrorpage = "Error_Page.aspx";
        public string strerrormessage = "Error Occured..";
        public string strDefaultPage = "Default.aspx";
        public string stralertmessage = "Data updated Succefully...";
        public string strselectEmpId = "Please Select Employee Id";
        public string strCustomerPage = "Customer_Details.aspx";
        public string strAdd_Edit_CustomerPage = "Add_Edit_Customer.aspx";
        public string strInvalid_TerritoryID = "Invalid TerritoryID";
        public string strBlankEmpIDTerritoryID = "Mandatory Fields:EmployeeID & TerritoryID";
        public string stralertmessageEmployeeID = "EmployeeID does not Exist";
        public string stralertmessageTerritoryID = "TerritoryID does not Exist";
        public string stralertmessageEmp_Terr_ID = "EmployeeID & TerritoryID already Exist";
        public string stralertCustomerID = "Details already available for this Customer";
        public string stralertSuccessfulInsert = "Data Inserted Succefully...";
        public string strcheckboxunchecked = "Please Checked at least one checkbox";        
    }
    #endregion
}