using System;

namespace Rate_Article
{
    /*************************************************************************************************************
       * CLASS NAME                                   :::                     _Default                
       * AUTHOR NAME                                  :::                     ANKIT SHARMA
       * DATE                                         :::                     11/09/2012
       * DESCRIPTION                                  :::                     TO IMPLEMENT THE RATING TOOL GENERATED AS A RENDER CONTROL
       * **********************************************************************************************************/
    public partial class _Default : System.Web.UI.Page
    {
        /*************************************************************************************************************
       * FUNCTION NAME                                :::                     Page_Load                
       * AUTHOR NAME                                  :::                     ANKIT SHARMA
       * DATE                                         :::                     11/09/2012
       * DESCRIPTION                                  :::                     PAGE LOAD EVENT 
       * **********************************************************************************************************/
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                lblArtical.Text = Constant.strMttr;                                       //SET THE TEXT PROPERTY OF LABEL
            }
            catch
            {
                Response.Redirect(Constant.strError);
            }
        }
        /*************************************************************************************************************
       * FUNCTION NAME                                :::                     btnVote_Click                
       * AUTHOR NAME                                  :::                     ANKIT SHARMA
       * DATE                                         :::                     11/09/2012
       * DESCRIPTION                                  :::                     CLICK EVENT OF BTNVOTE
       * **********************************************************************************************************/
        public void btnVote_Click(object sender, EventArgs e)
        {
            try
            {
                Rate.lblClick.Visible = true;
                Rate.lblClick.Text = Constant.strLblClck;                           //SET THE TEXT PROPERTY OF LABEL
                Rate.lblRate.Visible = false;
            }
            catch
            {
                Response.Redirect(Constant.strError);                               //REDIRECT TO ERROR.ASPX IF ANY EXCEPTION IS OCCURED
            }
        }
        /*************************************************************************************************************
       * FUNCTION NAME                                :::                     RblGrade_SelectedIndexChanged                
       * AUTHOR NAME                                  :::                     ANKIT SHARMA
       * DATE                                         :::                     11/09/2012
       * DESCRIPTION                                  :::                     SELECTED_INDEX_CHANGED EVENT OF RADIO_BUTTON_LIST
       * **********************************************************************************************************/
        public void RblGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Rate.lblRate.Visible = true;
                Rate.lblRate.Text = Constant.strLblRate;                            //SET THE TEXT PROPERTY OF LABEL      
                Rate.lblClick.Visible = false;
            }
            catch
            {
                Response.Redirect(Constant.strError);                               //REDIRECT TO ERROR.ASPX IF ANY ERROR IS OCCURED
            }
        }
    }
}
