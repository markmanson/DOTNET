using System;
using System.Web.UI.WebControls;
namespace Day5
{
    #region Check_Cache_Value
    /********************************************************************************************************************************************
   * CLASS NAME                                   :::                     CHECK_CACHE_VALUE                
   * AUTHOR NAME                                  :::                     ANKIT SHARMA
   * DATE                                         :::                     13/09/2012
   * DESCRIPTION                                  :::                     TO MAKE A CLASS IN WHICH WE CHECK THE VALUE OF CACHE AND USE IT IN WEBPAGE
   * ******************************************************************************************************************************************/
    public partial class Check_Cache_Value : System.Web.UI.Page
    {
        #region Page_Load
        /********************************************************************************************************************************************
       * FUNCTION NAME                                :::                     PAGE_LOAD               
       * AUTHOR NAME                                  :::                     ANKIT SHARMA
       * DATE                                         :::                     13/09/2012
       * DESCRIPTION                                  :::                     PAGE LOAD EVENT OF WEB PAGE(TO CHECK IF THE CACHE OBJECT HAS DROPDOWNLIST OR NOT)
       * ******************************************************************************************************************************************/
        protected void Page_Load(object sender, EventArgs e)
        {
            DropDownList ddlEmpCheck;                                                   //DECLARATION OF THE OBJECT OF DROPDOWNLIST
            try
            {
                if (Cache[Constant.strDDL] != null)                                               //CHECK IF CACHE IS NOT NULL
                {
                    ddlEmpCheck = new DropDownList();                                   //INITIALIZATION OF THE OBJECT OF DROPDOWNLIST
                    ddlEmpCheck = (DropDownList)Cache[Constant.strDDL];                           //ASIGN THE VALUE OF CACHE ITEM TO DDLEMPCHECK AFTER PARSING
                    PlaceHolder1.Controls.Add(ddlEmpCheck);                             //ADD DDLEMPCHECK TO THE PLACE HOLDER
                    lblMsg.Text = Constant.strCtrlCache;
                }
                else
                    lblMsg.Text = Constant.strCacheNull;
            }
            catch                                                                       //IF ANY KIND OF EXCEPTION IS OCCURES
            {
                Response.Redirect(Constant.strError);                                   //REDIRECT TO ERROR.ASPX
            }
            finally
            {
                ddlEmpCheck = null;                                                     //ASSIGN NULL TO THE OBJECT OF DROPDOWNLIST
            }
        }
        #endregion Page_Load
    }
    #endregion Check_Cache_Value
}
