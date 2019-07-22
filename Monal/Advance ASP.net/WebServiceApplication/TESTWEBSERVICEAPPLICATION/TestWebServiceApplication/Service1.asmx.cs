using System;
using System.ComponentModel;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace TestWebServiceApplication
{
    /// <summary>   
    /// Name:Service1
    /// Description: Simple Add,Subtract,Multiplication and Division of Two nos. WebMethods Created.
    /// Author:Monal shah
    /// Created Date:2010/12/2  
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {
        #region Add       
        /// <summary>
        /// Name:Add
        /// Description:Add Two Values.
        /// Author:Monal shah
        /// Created Date:2010/12/2       
        /// </summary>
        /// <param name="intA"></param>
        /// <param name="intB"></param>
        /// <returns>int</returns>
        [WebMethod]      
       
        public int Add(int intA, int intB)
        {
            return (intA + intB);
        }
        #endregion
        #region Subtract
        /// <summary>
        /// Name:Subtract
        /// Description:Subtract Two Values.
        /// Author:Monal shah
        /// Created Date:2010/12/2
        /// </summary>
        /// <param name="valueA"></param>
        /// <param name="valueB"></param>
        /// <returns>Single</returns>
        [WebMethod]
        public Single Subtract(Single valueA, Single valueB)
        {
            return(valueA-valueB);
        }
        #endregion
        #region Multiply
        /// <summary>
        /// Name:Multiply
        /// Description:Multiply Two Values.
        /// Author:Monal shah
        /// Created Date:2010/12/2
        /// </summary>
        /// <param name="valueA"></param>
        /// <param name="valueB"></param>
        /// <returns>Single</returns>
        [WebMethod]
        public Single Multiply(Single valueA, Single valueB)
        {
            return (valueA * valueB);
        }
        #endregion
        #region Divide
        /// <summary>
        /// Name:Divide
        /// Description:Divide Two Values.
        /// Author:Monal shah
        /// Created Date:2010/12/2
        /// </summary>
        /// <param name="valueA"></param>
        /// <param name="valueB"></param>
        /// <returns>Single</returns>
        [WebMethod]
        public Single Divide(Single valueA, Single valueB)
        {
            if (valueB == 0)
                return -1;
            return Convert.ToSingle(valueA / valueB);
        }
        #endregion      
        [WebMethod]
        public DataTable DispalyTable()
        {
            DataTable objDt = new DataTable();           
            StringBuilder objSb = new StringBuilder();
            objSb.Append("Select ");
            objSb.Append("* ");
            objSb.Append("From ");
            objSb.Append("TblEmployee");
            string Query = objSb.ToString();
            SqlConnection con = new SqlConnection(System.Configuration.ConfigurationManager.AppSettings["connection"].ToString());
            SqlDataAdapter objAdp = new SqlDataAdapter(Query, con);
            objAdp.Fill(objDt);
            objDt.TableName = "Employee";
            return objDt;
        }
    }
}
