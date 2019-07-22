using System;

namespace Day_3_4
{
    #region _Default
    /*************************************************************************************************************
     * CLASS NAME                                   :::                     _Default                
     * AUTHOR NAME                                  :::                     ANKIT SHARMA
     * DATE                                         :::                     08/08/2012
     * DESCRIPTION                                  :::                     TO SHOW THE FLOW OF THE DATA INLISTBOX 
     * **********************************************************************************************************/
    public partial class _Default : System.Web.UI.Page
    {
        #region Page_Load
        /*************************************************************************************************************
         * FUNCTION NAME                                :::                     Page_Load                
         * AUTHOR NAME                                  :::                     ANKIT SHARMA
         * DATE                                         :::                     08/08/2012
         * DESCRIPTION                                  :::                     FUNCTION Page_Load
         * **********************************************************************************************************/
        protected void Page_Load(object sender, EventArgs e)
        {
            txtItem.Focus();                                            //SET FOCUS TO TEXTBOX
        }
        #endregion Page_Load
        #region btnAdd_Click
        /*************************************************************************************************************
         * FUNCTION NAME                                :::                     btnAdd_Click                
         * AUTHOR NAME                                  :::                     ANKIT SHARMA
         * DATE                                         :::                     08/08/2012
         * DESCRIPTION                                  :::                     FUNCTION btnAdd_Click
         * **********************************************************************************************************/
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtItem.Text != "")                                 //CHECK IF TEXTBOX IS EMPTY
                {
                    lstFrst.Items.Add(txtItem.Text);                    //ADD TEXTBOS.TEXT TO LIST BOX
                    txtItem.Text = "";                                  //ASSIGN NULL TO TEXTBOX
                    txtItem.Focus();                                    //SET FOCUS ON TEXTBOX
                }
            }
            catch(Exception)                                            //IF ANY EXCEPTION IS OCCURED
            {
                Response.Redirect(Constant.strError);                   //REDIRECT TO ERROR.ASPX
            }
        }
        #endregion btnAdd_Click
        #region BtnLft_Click
        /*************************************************************************************************************
         * FUNCTION NAME                                :::                     BtnLft_Click                
         * AUTHOR NAME                                  :::                     ANKIT SHARMA
         * DATE                                         :::                     08/08/2012
         * DESCRIPTION                                  :::                     FUNCTION BtnLft_Click
         * **********************************************************************************************************/
        protected void BtnLft_Click(object sender, EventArgs e)
        {
            string strItem;                                             //DECLARE A STRING
            try
            {                
                if (lstScnd.SelectedValue != "")                        //CHECK IF USER SELECTED ANY VALUE
                {
                    strItem = lstScnd.SelectedValue;                    //ASSIGN THE SELECTED VALUE TO STRING
                    lstScnd.Items.Remove(strItem);                      //REMOVE THE SELECTED ITEM FROM LIST 
                    lstFrst.Items.Add(strItem);                         //ADD SELECTED ITEM OF LIST SECOND TO LIST FIRST
                }
            }
            catch (Exception)                                           //IF ANY EXCEPTION IS OCCURED
            {
                Response.Redirect(Constant.strError);                   //REDIRECT TO ERROR.ASPX
            }
            finally
            {
                strItem = null;                                         //ASSIGN NULL TO STRING
            }
        }
        #endregion BtnLft_Click
        #region BtnRight_Click
        /*************************************************************************************************************
         * FUNCTION NAME                                :::                     BtnRight_Click                
         * AUTHOR NAME                                  :::                     ANKIT SHARMA
         * DATE                                         :::                     08/08/2012
         * DESCRIPTION                                  :::                     FUNCTION BtnRight_Click
         * **********************************************************************************************************/
        protected void BtnRight_Click(object sender, EventArgs e)
        {
            string strItem;                                             //DECLARE A STRING
            try
            {
                if (lstFrst.SelectedValue != "")                        //CHECK IF USER SELECTED ANY VALUE
                {
                    strItem = lstFrst.SelectedValue;                    //ASSIGN THE SELECTED VALUE TO STRING
                    lstFrst.Items.Remove(strItem);                      //REMOVE THE SELECTED ITEM FROM LIST 
                    lstScnd.Items.Add(strItem);                         //ADD SELECTED ITEM OF LIST FIRST TO LIST SECOND
                }
            }
            catch (Exception)                                           //IF EXCEPTION IS OCCURED
            {
                Response.Redirect(Constant.strError);                   //REDIRECT TO ERROR.ASPX
            }
            finally
            {
                strItem = null;                                         //ASSIGN NULL TO STRING
            }
        }
        #endregion BtnRight_Click
        #region BtnRemove_Click
        /*************************************************************************************************************
         * FUNCTION NAME                                :::                     BtnRemove_Click                
         * AUTHOR NAME                                  :::                     ANKIT SHARMA
         * DATE                                         :::                     08/08/2012
         * DESCRIPTION                                  :::                     FUNCTION BtnRemove_Click
         * **********************************************************************************************************/
        protected void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                lstFrst.Items.Remove(lstFrst.SelectedValue);            //REMOVE THE SELECTED VALUE FROM LISTFIRST
            }
            catch (Exception)                                           //IF ANY EXCEPTION IS OCCURED
            {
                Response.Redirect(Constant.strError);                   //REDIRECT TO ERROR.ASPX
            }
        }
        #endregion BtnRemove_Click
    }
    #endregion _Default
}
