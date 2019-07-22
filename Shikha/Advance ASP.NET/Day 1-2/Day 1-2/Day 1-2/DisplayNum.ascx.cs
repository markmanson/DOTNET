using System;

namespace Day_1_2
{
    #region DisplayNum
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- DisplayNum
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- THE CLASS WHICH USE CONTROL FOR DISPLAY NUMBER INCREMENT OR DECREMENT.
    //      CREATED DATE    :- 2012/12/09
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class DisplayNum : System.Web.UI.UserControl
    {
        #region Page_Load
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- Page_Load
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- -----------
        //      CREATED DATE    :- 2012/12/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        #endregion Page_Load
        #region buttonUp_Click
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- buttonUp_Click
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- EVENT FOR INCREMENT IN VALUE  .
        //      CREATED DATE    :- 2012/12/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
       protected void buttonUp_Click(Object sender, EventArgs e)
        {
            // Increment the Value.
            this.Value += 1;

        }
        #endregion buttonUp_Click
       #region buttonDown_Click
       // ---------------------------------------------------------------------------------------------------------------------------------------------
       //      NAME            :- buttonDown_Click
       //      AUTHOR NAME     :- Shikha Malik
       //      DESCRIPTION     :- EVENT FOR DECREMENT VALUE.
       //      CREATED DATE    :- 2012/12/09
       //----------------------------------------------------------------------------------------------------------------------------------------------
        protected void buttonDown_Click(Object sender, EventArgs e)
        {
            // Decrement the Value.
            this.Value -= 1;

        }
       #endregion buttonDown_Click
        #region Value
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- Value
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- VALUE PROPERTY FOR GET SET VALUE.
        //      CREATED DATE    :- 2012/12/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        public int Value
        {
            get
            {
                // Return the Value.
                return Convert.ToInt32(ViewState[Constant.strVALUE]);
            }
            set
            {
                // Set the Value.
                ViewState[Constant.strVALUE] = value;
            }
        }
        #endregion Value
    }
    #endregion DisplayNum
}