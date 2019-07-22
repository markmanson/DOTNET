using System.Web;
using System;

namespace ExerciseProject.Class_File
{
    #region SessionMethod
    /// <summary>
    /// Name:SessionMethod
    /// Description:Here the session value is get and set
    /// Author:Monal shah
    /// created date:2010/09/21
    /// </summary>
    public class SessionMethod
    {

        public static SessionMethod CurrentSession
        {

            get
            {
                SessionMethod objSessionValue = (SessionMethod)
                                HttpContext.Current.Session["CurrentSession"];
                //get the session value of the current httprequest
                //if objSessionValue =null then create new object and set the value in session
                if (objSessionValue == null)
                {
                    objSessionValue = new SessionMethod();
                    HttpContext.Current.Session["CurrentSession"] = objSessionValue;
                }
                return objSessionValue;
            }      
           
        }
        public int EmployeeID
        {
            get;
            set;
        }
        public EmployeesDataset StoreTypedDataSet
        {
            get;
            set;
        }
        public string CustomerID
        {
            get;
            set;
        }
    }
    #endregion
}
