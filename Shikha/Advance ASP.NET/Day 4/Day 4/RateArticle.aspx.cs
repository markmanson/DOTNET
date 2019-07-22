using System;

namespace Day_4
{
    #region RateArticle
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- _Default
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- THE CLASS FOR ARTICLE RATING.
    //      CREATED DATE    :- 2012/18/09
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class _Default : System.Web.UI.Page
    {
        #region ButtonVoteClick
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- btnVote_Click
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- EVENT FOR ON BUTTON CLICK PROCESS.
        //      CREATED DATE    :- 2012/18/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
       public void btnVote_Click(object sender, EventArgs e)
        {
            try
            {
                lblClick.Visible = true;                                        //SET LABEL VISIBALITY IS TRUE
                lblClick.Text = Constant.strBTNCLICK;                           //TEXT FOR LABEL 
                lblChanged.Visible = false;                                    //SET LABEL VISIBALITY IS FALSE
            }
            catch
            {
                Response.Redirect(Constant.strERRPAGE);                               //REDIRECT TO ERROR PAGE
            }
        }
        #endregion ButtonVoteClick
       #region RateradioList
       // ---------------------------------------------------------------------------------------------------------------------------------------------
       //      NAME            :- RblRate_SelectedIndexChanged
       //      AUTHOR NAME     :- Shikha Malik
       //      DESCRIPTION     :- EVENT FOR INDEX CHANGED OF RADIO BUTTON.
       //      CREATED DATE    :- 2012/18/09
       //----------------------------------------------------------------------------------------------------------------------------------------------
        public void RblRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (RtArt.RblRate.SelectedItem.Text == Constant.strFIVE)                                      //CHECK CONDITION FOR RADIO SELECTED BUTTON IS 5 OR NOT
                {
                    RtArt.lblRateArt.Text = Constant.strRATETHISARTICLE + RtArt.RblRate.SelectedItem.Text + Constant.strISHIGHEST;        //IF 5 THEN ITS RATING IS HEIGH
                }
                else
                {
                    RtArt.lblRateArt.Text = Constant.strRATETHISARTICLEIS + RtArt.RblRate.SelectedItem.Text;                                //ELSE SHOW SELECTED RATING
                }
                lblChanged.Visible = true;
                lblChanged.Text = Constant.strRATECHANGE + RtArt.RblRate.SelectedItem.Text;                            //TEXT FOR LABEL       
                lblClick.Visible = false;
            }
            catch
            {
                Response.Redirect(Constant.strERRPAGE);                               //REDIRECT TO  ERROR PAGE
            }
        }
       #endregion RateradioList

    }
    #endregion RateArticle
}
