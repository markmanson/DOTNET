using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.Caching;
namespace Day_5_6
{
    #region Exercise07
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- Exercise07
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- CLASS FOR STORE DATA TABLE IN TO CACHE AND ON CLICK BUTTON RETRIVE IN TO ANOTHER PAGE.
    //      CREATED DATE    :- 2012/19/09
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class Exercise07 : System.Web.UI.Page
    {
        #region Page_Load
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- Page_Load
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- METHOD FOR STORE DATA TABLE IN TO CACHE.
        //      CREATED DATE    :- 2012/19/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        Common objCommon; DataTable dt;                           //DECLARATION OF OBJECTS
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlDataAdapter objAdapDA; string strQuery;       //DECLARATION OF OBJECTS
                try
                {
                    objCommon = new Common();                    //INITIALIZE OBJECT OF COMMON CLASS
                    objCommon.OpenConnection();                 //OPEN THE CONNECTION
                    strQuery = Constant.strSELECTEMP;            //STORE QUERY IN TO STRING
                    objAdapDA = new SqlDataAdapter(strQuery, objCommon.connC);    //PASS CONNECTION AND QUERY INTO DATAADAPTER
                    dt = new DataTable();
                    objAdapDA.Fill(dt);
                   //ddlListEmp.Visible = true;                              //SET DROPDOWNLIST VISIBILTY TRUE
                    ddlListEmp.DataSource = dt;
                    ddlListEmp.DataBind();                                  //BIND DATA INTO DROPDOWNLIST
                    ddlListEmp.DataTextField = Constant.strFSTNAME;           //SET VALUE OF TEXTFIELD
                    ddlListEmp.DataValueField = Constant.strENAME;          //SET VALUE OF VALUEFIELD
                    ddlListEmp.DataBind();     
                    //UPADATE THE CACHE OBJECT
                    Cache.Insert(Constant.strLIST, ddlListEmp, null, DateTime.Now.AddSeconds(10), TimeSpan.Zero);
                   
                }
                catch (Exception)
                {
                    Response.Redirect(Constant.strERRPAGE);          //REDIRECT TO ERROR PAGE
                }
            finally                                                 //FREE MEMORY OF OBJECTS
                {
                    objCommon.CloseConnection();                    //CLOSE THE CONNECTION
                    objCommon = null;
                    objAdapDA = null;
                    strQuery = null;
                }
            }
        }
        #endregion Page_Load
        #region btnCache_Click
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- Exercise07
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- ON CLICK REDIRECT TO CACHEEMPLOYEE.ASPX PAGE
        //      CREATED DATE    :- 2012/19/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        protected void btnCache_Click(object sender, EventArgs e)
        {
            Response.Redirect(Constant.strCACHEREDIRECT);                //REDIRECT TO CACHEEMPLYEE.ASPX
        }
        #endregion btnCache_Click
    }
    #endregion Exercise07
}
