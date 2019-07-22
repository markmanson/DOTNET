using System;
using System.Web.UI.WebControls;

namespace Day_6
{
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- _Default
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- The Class For store Checked item and display another page  .
    //      CREATED DATE    :- 2012/29/08
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String itemSelected;                    //DECLARATION OF VARIABLE
            try
            {
                itemSelected = String.Empty;
                if (cblSelect.SelectedIndex >= 0)
                {
                    foreach (ListItem item in cblSelect.Items)       //LOOPIN FOR CHECKBOXLIST ITEM
                    { //CHECK CONDITION FOR CHECKED ITEM
                        if (item.Selected)
                        {
                            //STORE CHEKED ITEM AND THEIR VALUE IN ITEMSELECTED STRING
                            itemSelected = itemSelected + item.Text + Constant.strComma + item.Value + Constant.strComma;
                        }
                       
                    }
                    //REMOVE COMMA FROM LAST OF STRING
                    itemSelected = itemSelected.Remove(itemSelected.ToString().LastIndexOf(Constant.strComma), 1);
                    //REDIRECT PAGE TO TOPICS.ASPX PAGE
                    Response.Redirect(Constant.strToPicsRedirect + itemSelected, false);
                }
            }
            catch (Exception ex)
            {
                Response.Redirect(Constant.strErrorPage);      //REDIRECT TO ERROR PAGE
            }
            finally
            {
                itemSelected = null;                          //REALLOCATE MEMORY
            }
        }

        
    }
}
