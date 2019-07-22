using System;
using System.Data.SqlClient;
using System.Text;
namespace Day2_4
{
    #region _Default
    /*************************************************************************************************************
        NAME                               ::::                    _Default
        AUTHOR                             ::::                    ANKIT
        DATE                               ::::                    13-07-2012
        DESCRIPTION                        ::::                    TO MAKE A CLASS DEFAULT
       ************************************************************************************************************/
    public partial class _Default : System.Web.UI.Page
    {
        Common objCommon;                                                                     //DECLARATION OF OBJECT OF CLASS COMMON
        #region Page_Load
        //FUNCTION PAGE_LOAD *************************************************************************************************************
        protected void Page_Load(object sender, EventArgs e)
        {
            objCommon = new Common();                                                         //INITIALIZATION OF OBJECT OF CLASS COMMON
            if (!IsPostBack)
            {                
                StringBuilder strBuild;                                                         //DECLARATION FOR OBJECT OF STRING BUILDER
                Employees dsEmp;                                                                //DECLARATION FOR OBJECT OF DATASET
                SqlDataAdapter adpt;                                                            //DECLARATION FOR OBJECT OF SQLDATAADOPTER         
                try
                {                  
                    dsEmp = new Employees();                                                    //INITIALIZATION OF DATASET
                    Session["Employees"] = dsEmp;
                    //INITIALIZATION OF SQLCONNECTION ********************************************************************************
                    objCommon.Connect.Open();                                                             //OPEN THE DATABASE
                    strBuild = new StringBuilder();                                             //INITIALIZATION OF STRING BUILDER
                    strBuild.Append(Constant.strSel);                                           //APPENDING THE STRING BUILDER
                    strBuild.Append(Constant.strAll);                                           //APPENDING THE STRING BUILDER
                    strBuild.Append(Constant.strFrom);                                          //APPENDING THE STRING BUILDER
                    strBuild.Append(Constant.strEmp);                                           //APPENDING THE STRING BUILDER
                    adpt = new SqlDataAdapter(strBuild.ToString(),objCommon.Connect);
                    adpt.Fill(dsEmp, "Employees");
                    gvdEmployeeTerritories.DataSource = dsEmp;                                  //TO SEND THE CONTENT OF TABLE INTO GRIDVIEW
                    gvdEmployeeTerritories.DataBind();                                          //TO BIND THE DATA OF TABLE INTO GRIDVIEW
                    if (objCommon.Connect.State == System.Data.ConnectionState.Open)
                    {
                        objCommon.Connect.Close();                                                            //TO CLOSE THE DATABASE
                    }
                    if (gvdEmployeeTerritories.Rows.Count == 0)                                 //CHECK IF GRIDVIEW CONTAIN DATA OR NOT
                    {
                        LblError.Visible = true;                                                //SHOW LABLE WITH ERROR MESSEGE
                        LblError.Text = Constant.strSorry;
                    }
                }
                catch (Exception)
                {
                    Response.Redirect("Error.aspx");                                            //REDIRECT TO ERROR.ASPX IF ANY ERROR IS OCCURED
                }
                finally
                {
                    if (objCommon.Connect.State == System.Data.ConnectionState.Open)
                    {
                        objCommon.Connect.Close();                                                            //TO CLOSE THE DATABASE
                    }
                    objCommon= null;                                                             //DESTROYING THE OBJECT OF  SQL CONNECTION
                    strBuild = null;                                                            //DESTROYING THE OBJECT OF STRING BUILDER                                                                   
                }
            }
        }
        #endregion Page_Load
    }
    #endregion _Default
}

