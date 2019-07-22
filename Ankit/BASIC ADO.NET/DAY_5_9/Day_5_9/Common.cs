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
using System.Data.SqlClient;
using System.Text;
namespace Day_5_9
{
    public class Common
    {
        //SQL CONNECTION *******************************************************************************************************//
        public SqlConnection Connect = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString);
        #region Open_Con
        //FUNCTION TO OPEN A SQL CONNECTION ***************************************************************************************
        public void Open_Con()
        {
            Connect.Open();
        }
        #endregion Open_Con
        #region Close_Con
        //FUNCTION TO CLOSE THE FUNCTION *******************************************************************************************
        public void Close_Con()
        {
            if (Connect.State == System.Data.ConnectionState.Open)
            {
                Connect.Close();
            }
        }
        #endregion Close_Con

        #region BindGridView
        //FUNCTION BINDGRIDVIEW ***************************************************************************************************************
        public void BindGridView(GridView gvEmpTerr, Label lblError)
        {
            StringBuilder strBuild;                                                         //DECLARATION FOR OBJECT OF STRING BUILDER
            Employees dsEmp;                                                                //DECLARATION FOR OBJECT OF DATASET
            SqlDataAdapter adpt;                                                            //DECLARATION FOR OBJECT OF SQLDATAADOPTER         
            try
            {
                dsEmp = new Employees();                                                    //INITIALIZATION OF DATASET
                Connect.Open();                                                             //OPEN THE DATABASE
                strBuild = new StringBuilder();                                             //INITIALIZATION OF STRING BUILDER
                strBuild.Append(Constant.strSel);                                           //APPENDING THE STRING BUILDER
                strBuild.Append(Constant.strAllEmpSpcl);                                    //APPENDING THE STRING BUILDER
                strBuild.Append(Constant.strFrom);                                          //APPENDING THE STRING BUILDER
                strBuild.Append(Constant.strEmp);                                           //APPENDING THE STRING BUILDER            
                adpt = new SqlDataAdapter(strBuild.ToString(), Connect);                    //INITIALIZING THE SQL DATA ADAPTOR
                adpt.Fill(dsEmp, "Employees1");                                              //FILL THE DATA INTO DATASET
                gvEmpTerr.DataSource = dsEmp.Employees1;                                         //TO SEND THE CONTENT OF TABLE INTO GRIDVIEW
                gvEmpTerr.DataBind();                                                //TO BIND THE DATA OF TABLE INTO GRIDVIEW                
                if (Connect.State == System.Data.ConnectionState.Open)
                {
                    Connect.Close();                                                            //TO CLOSE THE DATABASE
                }
                if (gvEmpTerr.Rows.Count == 0)                                        //CHECK IF GRIDVIEW CONTAIN DATA OR NOT
                {
                    lblError.Visible = true;                                                //SHOW LABLE WITH ERROR MESSEGE
                    lblError.Text = Constant.strSorry;
                }
            }
            catch (Exception ex)
            {
                
                //Response.Redirect("Error.aspx");                                            //REDIRECT TO ERROR.ASPX IF ANY ERROR IS OCCURED
            }
            finally
            {
                if (Connect.State == System.Data.ConnectionState.Open)
                {
                    Connect.Close();                                                                   //CLOSE THE CONNECTION
                }
                strBuild = null;                                                            //DESTROYING THE OBJECT OF STRING BUILDER                                                                  
                dsEmp = null;
                adpt = null;
            }
        }
        #endregion BindGridView

    }
}
