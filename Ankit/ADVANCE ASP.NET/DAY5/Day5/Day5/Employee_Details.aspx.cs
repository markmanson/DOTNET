using System;
using System.Data;
namespace Day5
{
    #region Employee_Details
    /********************************************************************************************************************************************
   * CLASS NAME                                   :::                     EMPLOYEE_DETAILS                
   * AUTHOR NAME                                  :::                     ANKIT SHARMA
   * DATE                                         :::                     13/09/2012
   * DESCRIPTION                                  :::                     TO MAKE A CLASS TO SHOW THW EMPLOYEE DETAILS SELECTED BY USER FROM A GIVEN DROP DOWN LIST
   * ******************************************************************************************************************************************/
    public partial class Employee_Details : System.Web.UI.Page
    {
        static string strName=string.Empty;                                                     //DECLARATION OF STATING STRING
        #region Page_Load
        /********************************************************************************************************************************************
       * FUNCTION NAME                                :::                     PAGE_LOAD               
       * AUTHOR NAME                                  :::                     ANKIT SHARMA
       * DATE                                         :::                     13/09/2012
       * DESCRIPTION                                  :::                     PAGE LOAD EVENT OF WEB PAGE(TO SHOW THE LIST OF EMPLOYEE NAMES AND A BUTTON)
       * ******************************************************************************************************************************************/
        protected void Page_Load(object sender, EventArgs e)
        {            
            if (!IsPostBack)                                                                    //CHECK IF POSTBACK IS FALSE 
            {
                Common objCommon;                                                               //DECLARATION OF THE OBJECT OF CLASS COMMON
                DataSet dsEmpName;                                                              //DECLARATION OF THE OBJECT OF DATASET
                try
                {
                    objCommon = new Common();                                                   //INITIALIZATION OF THE OBJECT OF CLASS COMMON
                    dsEmpName = new DataSet();                                                  //INITIALIZATION OF THE OBJECT OF DATASET
                    dsEmpName=objCommon.Bind(Constant.strSelQuery);                             //CALL THE METHOD BIND
                    ddlEmpName.DataTextField = dsEmpName.Tables[0].Columns[Constant.strFName].ToString(); //INITIALIZE THE DATATEXTFIELD OF DROPDOWNLIST
                    ddlEmpName.DataValueField = dsEmpName.Tables[0].Columns[Constant.strEmpID].ToString();//INITIALIZE THE DATAVALUEFIELD OF DROPDOWNLIST
                    ddlEmpName.DataSource = dsEmpName.Tables[0];                                //SET DATASOURCE OF DROPDOWNLIST TO DATA_SET 
                    ddlEmpName.DataBind();                                                      //BIND THE DATASET TO DROPDOWNLIST
                }
                catch
                {
                    Response.Redirect(Constant.strError);                                       //REDIRECT TO ERROR.ASPX IF ANY EXCEPTION IS OCCURED
                }
                finally
                {
                    objCommon = null;                                                           //ASSIGN NULL TO THE OBJECT OF CLASS COMMON
                    dsEmpName = null;                                                           //ASSIGN NULL TO THE OBJECT OF DATASET
                }
            }
        }
        #endregion Page_Load
        #region btnDetails_Click
        /********************************************************************************************************************************************
       * FUNCTION NAME                                :::                     BTNDETAILS_CLICK               
       * AUTHOR NAME                                  :::                     ANKIT SHARMA
       * DATE                                         :::                     13/09/2012
       * DESCRIPTION                                  :::                     CLICK EVENT OF BUTTON(SHOWS THE EMPLOYEE'S DETAILS WHICH IS SELECTED FROM DROPDOWNLIST)
       * ******************************************************************************************************************************************/
        protected void btnDetails_Click(object sender, EventArgs e)
        {
            Common objCommon;                                                                   //DECLARATION OF OBJECT OF CLASS COMMON
            string strCmd;                                                                      //DECLARATION OF OBJECT OF STRING
            DataSet dsEmpDetail;                                                                //DECLARATION OF OBJECT OF DATASET 
            try
            {
                objCommon = new Common();                                                       //INITIALIZATION OF OBJECT OF CLASS COMMON 
                dsEmpDetail = new DataSet();                                                    //INITIALIZATION OF OBJECT OF DATASET
                strCmd = Constant.strQuery_Where + ddlEmpName.SelectedValue + Constant.strQuote;//INITIALIZATION OF OBJECT OF STRING 
                if (strName == ddlEmpName.SelectedValue)                                        //CHECK IF STRNAME IS EQUAL TO SELECTED VALUE OF DROP_DOWN_LIST
                {
                    if (Cache[Constant.strDetails] != null)                                               //CHECK IF CACHE IS NULL
                    {
                        lblMsg.Text=Constant.strFrm_Cache;
                        gdvEmployee.DataSource = (DataSet)Cache[Constant.strDetails];                     //SET DATA SOURCE CACHE
                    }
                    else
                    {
                        dsEmpDetail = objCommon.Bind(strCmd);                                           //CALL THE METHOD BIND
                        Cache.Insert(Constant.strDetails, dsEmpDetail, null, DateTime.Now.AddSeconds(60), TimeSpan.Zero);//INSERT THE DATA SET INTO CACHE OBJECT 
                        lblMsg.Text = Constant.strFrmDB;
                        gdvEmployee.DataSource = dsEmpDetail;                                   //SET DATA SOURCE OF GRIDVIEW
                    }
                }
                else                                                                             //IF STRNAME IS NOT EQUAL TO SELECTED VALUE OF DROP_DOWN_LIST
                {
                    lblMsg.Text = Constant.strFrmDB;
                    dsEmpDetail = objCommon.Bind(strCmd);                                           //CALL THE METHOD BIND
                    Cache.Insert(Constant.strDetails, dsEmpDetail, null, DateTime.Now.AddSeconds(60), TimeSpan.Zero); //INITIALIZE THE CACHE OBJECT AND ASSIGN IT THE DATASET
                    strName = ddlEmpName.SelectedValue;                                         //ASSIGN THE VALUE OF SELECTED VALUE OF DROPDOWNLIST TO STRNAME
                    gdvEmployee.DataSource = dsEmpDetail;                                       //SET DATASOURECE OF GRIDVIEW 
                }
                gdvEmployee.DataBind();                                                         //BIND THE GRIDVIEW
                gdvEmployee.Visible = true;                                                     //SET VISIBLE TRUE OF GRID VIEW
            }
            catch
            {
                Response.Redirect(Constant.strError);                                           //REDIRECT TO ERROR.ASPX IF ANY ERROR IS OCCURES
            }
            finally
            {
                objCommon = null;                                                               //ASSIGN NULL TO THE OBJECT OF CLASS COMMON
                dsEmpDetail = null;                                                             //ASSIGN NULL TO THE OBJECT OF DATA SET 
            }
        }
        #endregion btnDetails_Click
    }
    #endregion Employee_Details
}
