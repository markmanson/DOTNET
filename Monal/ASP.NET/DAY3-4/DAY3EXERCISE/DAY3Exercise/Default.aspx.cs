using System;

namespace DAY3Exercise
{
    /// <summary>
    /// Name:Default.aspx
    /// Description:"Task 1 : When user click on AddList 
    ///              button add item from the TxtItem textbox in LstAddItem."
    ///              "Task 2 : When user click on > button 
    ///              move item from LstAddItem to  LstAddListItems and 
    ///              remove it from LstAddItem and viceversa for < button."
    ///              "Task : 3 When user click on remove items remove the item from LstAddItem."
    /// Author:Monal Shah
    /// CreatedDate:2010/10/12
    /// </summary>
    public partial class _Default : System.Web.UI.Page
    {
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// CreatedDate:2010/10/12
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            TxtAddList.Focus();
        }
        #endregion
        #region BtnAddlistItem_Click
        /// <summary>
        /// Name:BtnAddlistItem_Click
        /// Description:"Task 1 : When user click on AddList 
        ///              button add item from the TxtItem textbox in LstAddItem."
        /// Author:Monal Shah
        /// CreatedDate:2010/10/12
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnAddlistItem_Click(object sender, EventArgs e)
        {
            LstAddItem.Items.Add(TxtAddList.Text);
            TxtAddList.Text = string.Empty;
            TxtAddList.Focus();
        }
        #endregion
        #region BtnAdd_Click
        /// <summary>
        /// Name:BtnAdd_Click
        /// Description: "Task 2 : When user click on > button 
        ///              move item from LstAddItem to  LstAddListItems and 
        ///              remove it from LstAddItem"
        /// Author:Monal Shah
        /// CreatedDate:2010/10/12
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < LstAddItem.Items.Count; i++)
                {
                    if (LstAddItem.Items[i].Selected == true)
                    {
                        LstAddListItems.Items.Add(LstAddItem.Items[i].Value);
                        LstAddItem.Items.Remove(LstAddItem.Items[i].Value);
                        i = i - 1;
                    }
                }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
        }
        #endregion
        #region BtnDisplay_Click
        /// <summary>
        /// Name:BtnDisplay_Click
        /// Description:"Task 2 : When user click on  < button  
        ///              move item from  LstAddListItems to LstAddItem and 
        ///              remove it from  LstAddListItems"
        /// Author:Monal Shah
        /// CreatedDate:2010/10/12
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < LstAddListItems.Items.Count; i++)
                {
                    if (LstAddListItems.Items[i].Selected == true)
                    {
                        LstAddItem.Items.Add(LstAddListItems.Items[i].Value);
                        LstAddListItems.Items.Remove(LstAddListItems.Items[i].Value);
                        i = i - 1;
                    }
                }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
        }
        #endregion
        #region BtnRemoveItem_Click
        /// <summary>
        /// Name:BtnRemoveItem_Click
        /// Description:"Task : 3 When user click on remove items remove the item from LstAddItem."
        /// Author:Monal Shah
        /// CreatedDate:2010/10/12
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnRemoveItem_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = LstAddItem.Items.Count; i > 0; i--)
                {
                    LstAddItem.Items.RemoveAt(i - 1);
                }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
        }
        #endregion
    }
}
