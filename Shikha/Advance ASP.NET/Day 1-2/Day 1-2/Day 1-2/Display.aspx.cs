
namespace Day_1_2
{
    #region _Default
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- _Default
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- THE CLASS WHICH USE CONTROL FOR DISPLAY NUMBER INCREMENT OR DECREMENT.
    //      CREATED DATE    :- 2012/12/09
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class _Default : System.Web.UI.Page
    {
        #region Page_PreRender
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- Page_PreRender
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- ADD CONTROL VALUE INTO TEXT BOX .
        //      CREATED DATE    :- 2012/12/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        private void Page_PreRender(object sender, System.EventArgs e)
        {
            // Display the ucControl control's value.
            textNumber.Text = ucControl.Value.ToString();
        }
        #endregion Page_PreRender
    }
    #endregion _Default
 }
