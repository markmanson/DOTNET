using System;

namespace Day1_2
{
    #region WebUserControl2
    /*************************************************************************************************************
    * CLASS NAME                                   :::                     WebUserControl2                
    * AUTHOR NAME                                  :::                     ANKIT SHARMA
    * DATE                                         :::                     03/09/2012
    * DESCRIPTION                                  :::                     TO MAKE A WEB USER CONTROL
    * **********************************************************************************************************/
    public partial class WebUserControl2 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                Common objCommon = new Common();                                       //INITIALIZATION OF OBJCT OF CLASS COMMON             
                objCommon.Bind(gvdEmp);                                                 //CALL THE FUNCTION BIND
                gvdEmp.Visible = true;                                                  //SHOW THE GRIDVIEW
            }
        }
        #region btnDisplayGrd_Click
        /*************************************************************************************************************
        * FUNCTION NAME                                :::                     btnDisplayGrd_Click                
        * AUTHOR NAME                                  :::                     ANKIT SHARMA
        * DATE                                         :::                     03/09/2012
        * DESCRIPTION                                  :::                     CLICK EVENT OF BUTTON DISPLYRGID
        * **********************************************************************************************************/
        protected void btnDisplayGrd_Click(object sender, EventArgs e)
        {
          
        }
        #endregion btnDisplayGrd_Click
    }
    #endregion WebUserControl2
}