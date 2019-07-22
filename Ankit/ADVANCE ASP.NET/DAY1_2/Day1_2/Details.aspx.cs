using System;

namespace Day1_2
{
    #region WebForm1
    /*************************************************************************************************************
    * CLASS NAME                                   :::                     WebForm1                
    * AUTHOR NAME                                  :::                     ANKIT SHARMA
    * DATE                                         :::                     03/09/2012
    * DESCRIPTION                                  :::                     TO MAKE A CLASS TO CONTAINS THE DESIGN VIEW OF EXERCISE 2
    * **********************************************************************************************************/
    public partial class WebForm1 : System.Web.UI.Page
    {
        #region btnGetDetails_Click
        /*************************************************************************************************************
      * FUNCTION NAME                                :::                     btnGetDetails_Click                
      * AUTHOR NAME                                  :::                     ANKIT SHARMA
      * DATE                                         :::                     03/09/2012
      * DESCRIPTION                                  :::                     CLICK EVENT OF BUTTON GETTDETAILS
      * **********************************************************************************************************/
        protected void btnGetDetails_Click(object sender, EventArgs e)
        {
            Frame1.Attributes[Constant.strSrc] = Constant.strDepart;
            Constant.BoolAlt = true;
        }
        #endregion btnGetDetails_Click
        #region btnGetDetails_Click
        /*************************************************************************************************************
      * FUNCTION NAME                                :::                     Getbtn_Click                
      * AUTHOR NAME                                  :::                     ANKIT SHARMA
      * DATE                                         :::                     03/09/2012
      * DESCRIPTION                                  :::                     CLICK EVENT OF BUTTON GETBTN
      * **********************************************************************************************************/
        protected void Getbtn_Click(object sender, EventArgs e)
        {
            Frame1.Attributes[Constant.strSrc] = Constant.strEmp;
            Constant.BoolAlt = false;
        }
        #endregion btnGetDetails_Click        
    }
    #endregion WebForm1
}
