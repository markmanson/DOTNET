//using System;
//using System.Collections;
//using System.Configuration;
//using System.Data;
//using System.Linq;
//using System.Web;
//using System.Web.Security;
//using System.Web.UI;
//using System.Web.UI.HtmlControls;
//using System.Web.UI.WebControls;
//using System.Web.UI.WebControls.WebParts;
//using System.Xml.Linq;
//using System.Data.SqlClient;
//using System.Text;
//namespace ADO.NET.Day2
//{
//    public partial class Terdst : System.Web.UI.Page
//    {
//        protected void Page_Load(object sender, EventArgs e)
//        {

//            SqlConnection Connect;                                                  //DECLARATION FOR OBJECT OF  SQL CONNECTION
//            StringBuilder strBuild;                                                 //DECLARATION FOR OBJECT OF STRING BUILDER
//            SqlCommand Cmd;                                                         //DECLARATION FOR OBJECT OF SQLCOMMAND
//            SqlDataReader Rdr;                                                      //DECLARATION FOR OBJECT OF SQLDATAREADER
//            EmployeesTerritories dsEmpTerr;
//            SqlDataAdapter adpt;

//            DataSet objds = new DataSet();
//            try
//            {
//                // Connect = new SqlConnection(conn);
//                // string con=ConfigurationSettings.AppSettings;//("MyConnection");
//                dsEmpTerr = new EmployeesTerritories();
//                Connect = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString);
//                Connect.Open();                                                     //OPEN THE DATABASE
//                strBuild = new StringBuilder();                                     //INITIALIZATION OF STRING BUILDER
//                strBuild.Append(Constant.strSelect);                                //APPENDING THE STRING BUILDER
//                strBuild.Append(Constant.strAll);                                   //APPENDING THE STRING BUILDER
//                strBuild.Append(Constant.strFrom);                                  //APPENDING THE STRING BUILDER
//                strBuild.Append("EmployeeTerritories");                             //APPENDING THE STRING BUILDER
//                string str = "Select * from EmployeeTerritories";
//                //adpt = new SqlDataAdapter(strBuild.ToString(), Connect);
//                adpt = new SqlDataAdapter(str, Connect);
//                adpt.Fill(dsEmpTerr, "EmployeeTerritories");
//                gvdEmployeeTerritories.DataSource = dsEmpTerr;                      //TO SEND THE CONTENT OF TABLE INTO GRIDVIEW
//                gvdEmployeeTerritories.DataBind();                                  //TO BIND THE DATA OF TABLE INTO GRIDVIEW
//                Connect.Close();                                                    //TO CLOSE THE DATABASE
//            }
//            catch (Exception ex)
//            {
//                Response.Redirect("Error.aspx");                                    //REDIRECT TO ERROR.ASPX IF ANY ERROR IS OCCURED
//            }
//            finally
//            {
//                Connect = null;                                                       //DESTROYING THE OBJECT OF  SQL CONNECTION
//                strBuild = null;                                                     //DESTROYING THE OBJECT OF STRING BUILDER                                                                   
//            }
//        }
//    }
//}
