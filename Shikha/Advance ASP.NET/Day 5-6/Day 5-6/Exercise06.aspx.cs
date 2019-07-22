using System;
using System.Data;
using System.Data.SqlClient;

namespace Day_5_6
{
    #region Exercise06
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- Exercise06
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- CLASS FOR SHOW EMPLYEE INFORMATION FROM THE DATA BASE AND FROM CACHE.
    //      CREATED DATE    :- 2012/19/09
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class Exercise06 : System.Web.UI.Page
    {
        #region Page_Load
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- Page_Load
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- THIS METHOD SHOW DROPDOWNLIST WITH FIELD ENAME OF EMPLOYEE TABLE
        //      CREATED DATE    :- 2012/19/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        Common objCommon; DataTable dt; static string strList = ""; 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlDataAdapter objAdapDA; string strQuery;                // DECLARATION OF OBJECTS
                try
                {
                    objCommon = new Common();                             //INITIALIZE THE OBJECT OF COMMON CLASS
                    objCommon.OpenConnection();                           //OPEN THE CONNECTION
                    strQuery = Constant.strSELECTEMP;                      //STORE QUERY IN TO STRING
                    objAdapDA = new SqlDataAdapter(strQuery, objCommon.connC);         //PASS CONNECTION AND QUERY INTO DATA ADAPTER
                    dt = new DataTable();                                 //INITIALAZATION OF TABLE
                    objAdapDA.Fill(dt);                                   //FILL DATA IN TO TABLE
                    ddlListEmp.DataSource = dt;                           //PASS INTO DATASOURCE OF DROPDOWNLIST
                    ddlListEmp.DataBind();                                //BIND DATA IN TO DROPDOWNLIST
                    ddlListEmp.DataTextField = Constant.strFSTNAME;         //SET VALUE OF TEXTFIELD
                    ddlListEmp.DataValueField = Constant.strENAME;        //SET VALUE OF VALUEFIELD
                    ddlListEmp.DataBind();                                //BIMD DATA INTO DROPDOWNLIST
                }
                catch (Exception)
                {
                    Response.Redirect(Constant.strERRPAGE);               //REDIRECT TO ERROR PAGE
                }
            finally                                                       //FREE MEMORY OF OBJECTS
                {
                    objCommon.CloseConnection();                         //CLOSE THE CONNECTION
                    objCommon = null;
                    objAdapDA = null;
                    strQuery = null;
                }
            }
        }
        #endregion Page_Load
        #region Details
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- btnDetails_Click
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- THIS EVENT SHOW DETAILS OF SELECTED EMPLOYEE AND INSET IT INTO CACHE , WHEN CACHE IS NULL
        //      CREATED DATE    :- 2012/19/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        protected void btnDetails_Click(object sender, EventArgs e)
        {
            string strQuery; SqlDataAdapter objAdapDA;                    //DECLARATION OF OBJECTS
         
            try
            {
                objCommon = new Common();                              //INITIALIZE OBJECT OF COMMON CLASS
                objCommon.OpenConnection();                            //OPEN THE CONNECTION
               // ddlListEmp.SelectedValue = strListddl;
                if (strList==ddlListEmp.SelectedValue)
                {
                    if (Cache[Constant.strUSERS] == null)                      //CHACK CONDITION FOR CACHE IS NULL OR NOT
                    {                                                          //IF NULL
                        strQuery = Constant.strSELEMPDDL + ddlListEmp.SelectedValue;  //STORE QUERY INTO STRING
                        objAdapDA = new SqlDataAdapter(strQuery, objCommon.connC);        //PASS QUERY AND CONNECTION IN TO DATAADAPTER
                        dt = new DataTable();                                    //INITIALIZE DATA TABLE
                        objAdapDA.Fill(dt);                                      //FILL DATA INTO DATA TABLE
                        //UPADATE THE CACHE OBJECT
                        Cache.Insert(Constant.strUSERS, dt, new System.Web.Caching.CacheDependency(
                        Server.MapPath(Constant.strMASTERXML)), DateTime.Now.AddSeconds(60), TimeSpan.Zero);
                        lblMsg.Visible = true;                                   //SET LABEL MESSAGE TRUE
                        lblMsg.Text = Constant.strLBLMSGDATABASE;                //SET TEXT FOR LABEL
                    }
                    else
                    {                                                            //IF NOT NULL
                        lblMsg.Visible = true;                                   //SET LABEL MSG TRUE
                        lblMsg.Text = Constant.strLBLMSGCACHE;                   //SET TEXT FOR LABEL
                        dt = (DataTable)Cache[Constant.strUSERS];                //RETRIVE VALUE OF CACHE INTO DATA TABLE
                    }
                }
                else
                {
                    strQuery = Constant.strSELEMPDDL + ddlListEmp.SelectedValue ;  //STORE QUERY INTO STRING
                    objAdapDA = new SqlDataAdapter(strQuery, objCommon.connC);        //PASS QUERY AND CONNECTION IN TO DATAADAPTER
                    dt = new DataTable();                                    //INITIALIZE DATA TABLE
                    objAdapDA.Fill(dt);                                      //FILL DATA INTO DATA TABLE
                    //UPADATE THE CACHE OBJECT
                    Cache.Insert(Constant.strUSERS, dt, new System.Web.Caching.CacheDependency(
                    Server.MapPath(Constant.strMASTERXML)), DateTime.Now.AddSeconds(10), TimeSpan.Zero);
                    strList=ddlListEmp.SelectedValue;
                   // Session["List"] = strList;
                    lblMsg.Visible = true;                                   //SET LABEL MESSAGE TRUE
                    lblMsg.Text = Constant.strLBLMSGDATABASE;  
                }
                gvEmp.DataSource = dt;                                       //PASS DATA INTO SOURCE OF GRIDVIEW
                gvEmp.DataBind();                                            //BIND DATA INTO GRIDVIEW
                gvEmp.Visible = true;
            }

            catch
            {
                Response.Redirect(Constant.strERRPAGE);               //REDIRECT TO ERROR PAGE
            }
            finally                                                   //FREE MEMORY OF OBJECTS
            {
                objCommon.CloseConnection();                          //CLOSE THE CONNECTION
                strQuery=null;  objAdapDA=null;
                objCommon = null;
            }
        }
        #endregion Details
    }
    #endregion Exercise06
}

