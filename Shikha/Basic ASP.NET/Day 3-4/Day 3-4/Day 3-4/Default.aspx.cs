using System;
using System.Web.UI.WebControls;

namespace Day_3_4
{
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- _Default
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- The Class for ADD OR REMOVE VALUE FROM TEXTBOX.
    //      CREATED DATE    :- 2012/22/06
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddItem_Click(object sender, EventArgs e)          //GENRATE ON BUTTON CLICK
        {
            string strItem;                                                 //DECLARATION OF OBJECTS
            ListItem lstV;
            try
            {
                strItem = txtTextBox1.Text;                             //ASSIGN VALUE OF TEXTBOX INTO STRITEM                                   
                lstV = new ListItem(strItem);                           //INTILIAZATION OF LISTBOX   
                listLeft.Items.Add(lstV);                               //ADD ITEM INTO LEFTLIST
                txtTextBox1.Text = string.Empty;                        //EMPTY TEXTBOX1
            }
            catch (Exception ex)
            {
                Response.Redirect(Constant.strErrorPage);            //REDIRECT TO ERROR PAGE
            }
            finally
            {                                                         //REALLOCATE MEMORY
                strItem = null;
                lstV = null;
            }
        }

        protected void btnMoveRight_Click(object sender, EventArgs e)      //GENRATE ON BUTTON CLICK
        {
            ListItem lstLi;                                                //DECLARATION OF OBJECTS
            try
            {
                if (listLeft.SelectedItem != null)                       //CHECK CONDITION FOR SELECTED ITEM
                {
                    lstLi = listLeft.SelectedItem;
                    listLeft.Items.Remove(lstLi);                        //REMOVE SELECTED ITEM
                    lstLi.Selected = false;
                    listRight.Items.Add(lstLi);                          //ADD INTO RIGHT LISTBOX
                }
            }
            catch (Exception ex)
            {
                Response.Redirect(Constant.strErrorPage);               //REDIRECT TO ERROR PAGE
            }
            finally
            {
                lstLi=null;                                           //REALLOCATE MEMORY
            }

        }

        protected void btnMoveLeft_Click(object sender, EventArgs e)        //GENRATE ON BUTTON CLICK
        {
            ListItem lstLi;                                                 //DECLARATION OF OBJECTS
            try
            {
                if (listRight.SelectedItem != null)                         //CHECK CONDITION FOR SELECTED ITEM
                {
                    lstLi = listRight.SelectedItem;                       //ASSIGN SELECTED VALUE 
                    listRight.Items.Remove(lstLi);                        //REMOVE SELECTED VALUE
                    lstLi.Selected = false;
                    listLeft.Items.Add(lstLi);                           //ADD INTO LEFT LISTBOX  
                }
            }
            catch (Exception ex)
            {
                Response.Redirect(Constant.strErrorPage);                 //REDIRECT TO ERROR PAGE          
            }
            finally
            {
                lstLi = null;                                             //REALLOCATE MEMORY
            }
        }

        protected void btnRemove_Click(object sender, EventArgs e)        //GENRATE ON BUTTON CLICK
        {
            ListItem lstLi;                                                //DECLARATION OF OBJECTS
            try
            {
                lstLi = listLeft.SelectedItem;                            //ASSIGN SELECTED VALUE
                listLeft.Items.Remove(lstLi);                             //REMOVE SELECTED VALUE
            }
            catch (Exception ex)
            {
                Response.Redirect(Constant.strErrorPage);                 //REDIRECT TO ERROR PAGE
            }
            finally
            {
                lstLi = null;                                              //REALLOCATE MEMORY
            }
        }

        
    }
}