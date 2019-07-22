using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI.WebControls;
namespace Day2_4
{
    #region DefaultLink
    /*************************************************************************************************************
        NAME                               ::::                    DEFAULTLINK
        AUTHOR                             ::::                    ANKIT
        DATE                               ::::                    13-07-2012
        DESCRIPTION                        ::::                    TO MAKE A CLASS DEFAULTLINK
       ************************************************************************************************************/
    public partial class DefaultLink : System.Web.UI.Page
    {
        Common objCommon;                                                                          //DECLARATION FOR OBJECT OF CLASS COMMON
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                objCommon = new Common();                                                           //INITIALIZATION OF OBJECT OF CLASS COMMON                
                StringBuilder strBuild;                                                             //DECLARATION FOR OBJECT OF STRING BUILDER
                Employees dsEmpTerr;
                SqlDataAdapter adpt;
                DataTable dt;
                try
                {                    
                    dsEmpTerr = new Employees();                    
                    objCommon.Connect.Open();                                                     //OPEN THE DATABASE
                    strBuild = new StringBuilder();                                     //INITIALIZATION OF STRING BUILDER
                    strBuild.Append(Constant.strSel);                                   //APPENDING THE STRING BUILDER
                    strBuild.Append(Constant.strAllEmpSpcl);                            //APPENDING THE STRING BUILDER
                    strBuild.Append(Constant.strFrom);                                  //APPENDING THE STRING BUILDER
                    strBuild.Append(Constant.strEmp);                                   //APPENDING THE STRING BUILDER
                    adpt = new SqlDataAdapter(strBuild.ToString(), objCommon.Connect);
                    dt = dsEmpTerr._Employees;
                    adpt.Fill(dt);                   
                    gvDefaultLink.DataSource = dt;                                        //TO SEND THE CONTENT OF TABLE INTO GRIDVIEW
                    gvDefaultLink.DataBind();                                             //TO BIND THE DATA OF TABLE INTO GRIDVIEW
                    if (objCommon.Connect.State == System.Data.ConnectionState.Open)
                    {
                        objCommon.Connect.Close();                                                      //TO CLOSE THE DATABASE
                    }
                    if (gvDefaultLink.Rows.Count == 0)
                    {
                        lblError.Visible = true;
                        lblError.Text = Constant.strSorry;
                    }
                }
                catch (Exception)
                {
                    Response.Redirect("Error.aspx");                                      //REDIRECT TO ERROR.ASPX IF ANY ERROR IS OCCURED
                }
                finally
                {
                    if (objCommon.Connect.State == System.Data.ConnectionState.Open)
                    {
                        objCommon.Connect.Close();                                                            //TO CLOSE THE DATABASE
                    }
                    objCommon.Connect = null;                                                       //DESTROYING THE OBJECT OF  SQL CONNECTION
                    strBuild = null;                                                      //DESTROYING THE OBJECT OF STRING BUILDER                   
                }
            }
        }
        #region Name_Click
        //FUNCITON NAME_CLICK  ***************************************************************************************
        protected void Name_Click(object sender, EventArgs e)
        {
           int rindex = (((GridViewRow)(((LinkButton)(sender)).Parent.BindingContainer))).RowIndex; //FINDIMG THE ROW INDEX           
           int EmployeeID = Int32.Parse(gvDefaultLink.DataKeys[rindex].Value.ToString());   //PARSE THE VALUE OF EMPLOYEE ID
           Session["EmployeeID"] = EmployeeID;                                              //STORE THE EMPLOYEEID INTO SESSION
           Response.Redirect("EmpTerr.aspx", false);                                        //REDIRECT TO EmpTerr.aspx
        }
        #endregion Name_Click
    }
    #endregion DefaultLink
}
