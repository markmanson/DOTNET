using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
namespace Day2_4
{
    #region Empterr
    /*************************************************************************************************************
         NAME                               ::::                    EMPTERR
         AUTHOR                             ::::                    ANKIT
         DATE                               ::::                    13-07-2012
         DESCRIPTION                        ::::                    CLASS Empterr
        ************************************************************************************************************/
    public partial class EmpTerr : System.Web.UI.Page
    {
        #region Page_Load
        //FUNCTION PAGE_LOAD   *************************************************************************************************
        protected void Page_Load(object sender, EventArgs e)
        {
            Common objCommon = new Common();
            if (!IsPostBack)
            {                
                StringBuilder strBuild;                                                 //DECLARATION FOR OBJECT OF STRING BUILDER               
                Employees EmpTerr;                                                      //DECLARATION FOR OBJECT OF DATSET
                SqlDataAdapter adpt;                                                    //DECLARATION FOR OBJECT OF SQL DATAADAPTOR
                DataSet objds = new DataSet();
                try
                {                    
                    EmpTerr = new Employees();                    
                    objCommon.Connect.Open();                                                     //OPEN THE DATABASE
                    strBuild = new StringBuilder();                                     //INITIALIZATION OF STRING BUILDER
                    strBuild.Append(Constant.strSel);                                   //APPENDING THE STRING BUILDER
                    strBuild.Append(Constant.strAll);                                   //APPENDING THE STRING BUILDER
                    strBuild.Append(Constant.strFrom);                                  //APPENDING THE STRING BUILDER
                    strBuild.Append(Constant.strEmpterr);                               //APPENDING THE STRING BUILDER
                    if (Session["EmployeeID"] != null)                                  //IF SESSION HAS SOME VALUES
                    {
                        strBuild.Append(Constant.strWhrEmpId + Session["EmployeeID"].ToString());//APPENDING THE STRING BUILDER                    
                    }                    
                    adpt = new SqlDataAdapter(strBuild.ToString(), objCommon.Connect);
                    adpt.Fill(EmpTerr, "EmployeeTerritories");
                    gvEmpTerr.DataSource = EmpTerr.EmployeeTerritories;                                     //TO SEND THE CONTENT OF TABLE INTO GRIDVIEW
                    gvEmpTerr.DataBind();                                               //TO BIND THE DATA OF TABLE INTO GRIDVIEW
                    if (objCommon.Connect.State == System.Data.ConnectionState.Open)
                    {
                      objCommon.Connect.Close();                                                    //TO CLOSE THE DATABASE
                    }
                }
                catch (Exception )
                {
                    Response.Redirect("Error.aspx");                                    //REDIRECT TO ERROR.ASPX IF ANY ERROR IS OCCURED
                }
                finally
                {
                    if (objCommon.Connect.State == System.Data.ConnectionState.Open)
                    {
                        objCommon.Connect.Close();                                                                   //CLOSE THE CONNECTION
                    }
                    strBuild = null;                                                   //DESTROYING THE OBJECT OF STRING BUILDER                                                                   
                    Session["EmployeeID"] = null;                                      //DESTROYING THE OBJECT OF SESSION
                    EmpTerr = null;
                    adpt = null;
                    objds = null;
                }
            }
        }
        #endregion Page_Load
    }
    #endregion Empterr
}
