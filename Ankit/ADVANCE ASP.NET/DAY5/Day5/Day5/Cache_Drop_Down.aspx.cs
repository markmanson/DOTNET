using System;
using System.Data;
using System.Web.Caching;
using System.Web.UI.WebControls;
namespace Day5
{
    #region Cache_Drop_Down
    /********************************************************************************************************************************************
       * CLASS NAME                                   :::                     CACHE_DROP_DOWN               
       * AUTHOR NAME                                  :::                     ANKIT SHARMA
       * DATE                                         :::                     13/09/2012
       * DESCRIPTION                                  :::                     TO MAKE A CLASS TO BIND A DROPDOWNLIST AND ASSIGN IT TO A CACHE OBJECT
       * ******************************************************************************************************************************************/
    public partial class Cache_Drop_Down : System.Web.UI.Page
    {
        #region Page_Load
        /********************************************************************************************************************************************
       * FUNCTION NAME                                :::                     PAGE_LOAD               
       * AUTHOR NAME                                  :::                     ANKIT SHARMA
       * DATE                                         :::                     13/09/2012
       * DESCRIPTION                                  :::                     PAGE LOAD EVENT OF WEB PAGE(TO STORE THE DROPDOWNLIST OF EMPLOYEE NAMES INTO CACHE OBJECT 
         *                                                                    SO THAT IN WHOLE APPLICATION IT CAN BE USED )
       * ******************************************************************************************************************************************/
        protected void Page_Load(object sender, EventArgs e)
        {
            Common objCommon;                                                           //DECLARATION OF OBJECT OF CLASS COMMON
            DataSet dsEmp;                                                              //DECLARATION OF OBJECT OF DATASET
            DropDownList ddlEmp_Name;                                                   //DECLARATION OF OBJECT OF DROPDOWNLIST
            try
            {
                objCommon = new Common();                                               //INITIALIZATION OF OBJECT OF CLASS COMMON
                dsEmp = new DataSet();                                                  //INITIALIZATION OF OBJECT OF DATASET
                ddlEmp_Name = new DropDownList();                                       //INITIALIZATION OF OBJECT OF DROPDOWNLIST
                dsEmp = objCommon.Bind(Constant.strSelQuery);                           //CALL THE METHOD BIND
                ddlEmp_Name.DataTextField = dsEmp.Tables[0].Columns[Constant.strFName].ToString();//SET THE DATATEXTFIELD OF DROP DOWN LIST
                ddlEmp_Name.DataValueField = dsEmp.Tables[0].Columns[Constant.strEmpID].ToString();//SET THE DATAVALUEFIELD OF DROP DOWN LIST
                ddlEmp_Name.DataSource = dsEmp.Tables[0];                               //SET THE DATA SOURCE OF DROPDOWNLIST
                ddlEmp_Name.DataBind();                                                 //BIND THE DROPDOWNLIST
                Cache.Add(Constant.strDDL, ddlEmp_Name, null, Cache.NoAbsoluteExpiration, System.TimeSpan.FromMinutes(5), CacheItemPriority.Default, null);//ADD DROPDOWNLIST TO CACHE OBJECT
                lblMsg.Text = Constant.strCacheMsg;
            }
            catch                                                                       //IF EXCEPTION IS OCCURES
            {
                Response.Redirect(Constant.strError);                                   //REDIRECT TO ERROR.ASPX
            }
            finally
            {
                objCommon = null;                                                       //ASSIGN NULL TO THE OBJECT OF CLASS COMMON
                dsEmp = null;                                                           //ASSIGN NULL TO THE OBJECT OF DATASET
                ddlEmp_Name = null;                                                     //ASSIGN NULL TO THE OBJECT OF DROPDOWNLIST
            }
        }
        #endregion Page_Load

        protected void btnShow_Click(object sender, EventArgs e)
        {
            Response.Redirect(Constant.strDis_Cache);
        }
    }
    #endregion Cache_Drop_Down
}
