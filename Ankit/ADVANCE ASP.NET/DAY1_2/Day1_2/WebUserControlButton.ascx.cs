using System;

namespace Day1_2
{
    #region WebUserControl1
    /*************************************************************************************************************
     * CLASS NAME                                   :::                     WebUserControl1                
     * AUTHOR NAME                                  :::                     ANKIT SHARMA
     * DATE                                         :::                     31/08/2012
     * DESCRIPTION                                  :::                     TO MAKE A CLASS FOR USER CONTROL
     * **********************************************************************************************************/
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {       
        public int intValue
        {
            get
            {
                return (Convert.ToInt32(ViewState[Constant.strVal]));        //RETURN THE VALUE OF VIEWSTATE AFTER PARSING INTO INTEGER
            }
            set
            {
                ViewState[Constant.strVal] = value;                          //SET VALUE TO VIEWSTATE
            }
        }
        #region btnUp_Click
     /*************************************************************************************************************
     * FUNCTION NAME                                :::                     btnUp_Click                
     * AUTHOR NAME                                  :::                     ANKIT SHARMA
     * DATE                                         :::                     31/08/2012
     * DESCRIPTION                                  :::                     CLICK EVENT OF BTNUP
     * **********************************************************************************************************/
        protected void btnUp_Click(object sender, EventArgs e)
        {
            intValue ++;                                                //INCRESING THE VALUE OF INT VALUE
            Session[Constant.strVal] = intValue;                        //STORE THE VALUE OF INTVAULE INTO SESSION
            lblNot.Visible = false;                                     //MAKE LABLE VISIBLE
        }
        #endregion btnUp_Click
        #region btnDown_Click
     /*************************************************************************************************************
     * FUNCTION NAME                                :::                     btnDown_Click                
     * AUTHOR NAME                                  :::                     ANKIT SHARMA
     * DATE                                         :::                     31/08/2012
     * DESCRIPTION                                  :::                     CLICK EVENT OF BTNDOWN
     * **********************************************************************************************************/
        protected void btnDown_Click(object sender, EventArgs e)
        {
            if (intValue < 1)                                           //IF INTVALUE IS LESS THAN 1
            {
                lblNot.Visible = true;                                  //MAKE LABLE VISIBLE
                lblNot.Text = Constant.strNotConvert;                   //SHOW THAT VALUE CAN NOT BE DECRESED
            }
            else                                                        //IF VALUE IS GREATER THAN 0 
            {
                intValue--;                                             //DECRESE THE VALUE OF INTVALUE
                Session[Constant.strVal] = intValue;                    //STORE THE VALUE OF INTVALUE INTO SESSION 
                lblNot.Visible = false;                                 //MAKE LABLE VISIBLE
            }
        }
        #endregion btnDown_Click
    }
    #endregion WebUserControl1
}