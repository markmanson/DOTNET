using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Web.Caching;
namespace Day_5_6
{
    #region CacheEmployee
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- CacheEmployee
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- THE CLASS CACHE EMPLOYEE SHOW EMPLOYEE EMFORMATION WITHIN CACHE TIME.
    //      CREATED DATE    :- 2012/19/09
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class CacheEmployee : System.Web.UI.Page
    {
        #region Page_Load
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- Page_Load
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- The PAGE LOAD SHOE DROPDOWNLIST WITH EMPLOYEE INFORMATIO IF CACHE IS NOT NULL OTHERVISE SHOW LBLMEASSAGE.
        //      CREATED DATE    :- 2012/19/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        Common objCommon; DataTable dt; DropDownList ddlListEmpCache; static string strDdle="";                             //DECLARATION OF OBJECTS
        protected void Page_Load(object sender, EventArgs e)
        {
           if (!IsPostBack)
            {
                ddlListEmpCache = new DropDownList();
                try
                {
                   if (Cache[Constant.strLIST] == null)                       //CHECK CONDITION FOR CACHE IS NULL OR NOT
                    {                                                           //IF NULL
                        ddlListEmpCache.Visible = false;                             //SET DROPDOWNLIST VISIBLE FALSE
                        lblCache.Visible = true;                                //SET LABEL CACHE TRUE
                        lblCache.Text = Constant.strCACHENULL;                  //SET TEXT OF LABELMSG
                        btnDetails.Visible = false;                             //SET BUTTON VISIBALITY FALSE
                        gvEmp.Visible = false;                                  //SET GRIDVIEW VISIBLTY FALSE
                    }
                    else
                    {                                                           //IF NOT NULL
                        ddlListEmpCache = (DropDownList)Cache[Constant.strLIST];                                                  //BIND DATA INTO DROPDOWNLIST
                        
                        ddlListEmpCache.Visible = true;
                        PlaceHolderList.Controls.Add(ddlListEmpCache);
                        ddlListEmpCache.SelectedValue = strDdle;
                    }
                }
                catch
                {
                    Response.Redirect(Constant.strERRPAGE);                     //REDIRECT TO ERROR PAGE
                }
            }
        }
        #endregion Page_Load
        #region Details
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- btnDetails_Click
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- THE CLICK EVENT SHOW SELECTED EMPLOYEE INFORMATION.
        //      CREATED DATE    :- 2012/19/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        protected void btnDetails_Click(object sender, EventArgs e)
        {
            string strQuery; SqlDataAdapter objAdapDA;                  //DECLARATION OF OBJECTS
            try
            {
                objCommon = new Common();                                   //INITIALIZATION OF COMMON CLASS
                objCommon.OpenConnection();                                 //OPEN CONNECTION
                if (Cache[Constant.strLIST] != null)
                {
                    ddlListEmpCache = (DropDownList)Cache[Constant.strLIST];
                    ddlListEmpCache.Visible = true;
                    PlaceHolderList.Controls.Add(ddlListEmpCache);
                    strQuery = Constant.strSELEMPDDL + ddlListEmpCache.SelectedValue;  //STORE QUERY INTO STRING
                    objAdapDA = new SqlDataAdapter(strQuery, objCommon.connC);   //INITIALIZE DATAADAPTER AND PASS QUERY 
                    dt = new DataTable();                                        //INITIALIZATION OF DATA TABLE
                    objAdapDA.Fill(dt);                                          //FILL DATA INTO DATA TABLE
                    gvEmp.DataSource = dt;                                       //STORE IN DATA SOURCE OF GRIDVIEW
                    gvEmp.DataBind();                                            //BIND DATA INTO GRIDVIEW
                }
                else
                {
                    lblCache.Visible = true;                                //SET LABEL CACHE TRUE
                    lblCache.Text = Constant.strCACHENULL;
                    btnDetails.Visible = false;                             //SET BUTTON VISIBALITY FALSE
                    gvEmp.Visible = false;   
                }
            }
            catch
            {
                Response.Redirect(Constant.strERRPAGE);                     //REDIRECT TO ERROR PAGE
            }
            finally
            {                                                         //FREE MOMORY OF OBJECTS    
                objCommon.CloseConnection();                          //CLOSE THE CONNECTION
                objCommon = null;
                objAdapDA = null;
                strQuery = null;                       
            }
        }
        #endregion Details
    }
    #endregion CacheEmployee
}
