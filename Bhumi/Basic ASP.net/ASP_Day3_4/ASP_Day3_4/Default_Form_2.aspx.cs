using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;
/// <summary>
/// NamespaceName:ASP_Day3_4
/// Description: Basic ASP.Net study
/// Author: Bhumi
/// Created On:17/6/2015
/// </summary>    
namespace ASP_Day3_4
{
    public partial class Default_Form_2 : System.Web.UI.Page
    {
        ConstantMessage objconstant;            
        #region Page Load
        /// <summary>
        /// Event Name:Page_Load
        /// Description: Initialization of web Controls
        /// Author: Bhumi
        /// Created On:17/6/2015
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            LblInsert.Visible = false;
        }
        #endregion
        #region ADD LIST Click Event
        /// <summary>
        /// Method Name:BtnAddlist_Click
        /// Description: ADD the Items From TextBox to ListBox1
        /// Author:Bhumi
        /// Created On:17/6/2015
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnAddlist_Click(object sender, EventArgs e)
        {
            //Add the value of Textbox in ListBox1
            if ((TxtItem.Text).Trim() != "")
            {
                LstItem1.Items.Add(((TextBox)TxtItem).Text);
                TxtItem.Text = "";
                LblInsert.Visible = true;
            }
            else
            {
                objconstant = new ConstantMessage();
                ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "alert('" + objconstant.strblankItem + "');", true);
            }            
        }
        #endregion
        #region Move data from one ListBox to Other
        /// <summary>
        /// Method Name:BtnLeftToRight_Click
        /// Description: Move the Data from ListBox1 to ListBox2
        /// Author:Bhumi
        /// Created On:17/6/2015
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnLeftToRight_Click(object sender, EventArgs e)
        {
            List<ListItem> Selected_Items;                        
            try
            {
                if (LstItem1.Items.Count > 0)
                {
                    if (LstItem1.SelectedIndex != -1)
                    {
                        Selected_Items = new List<ListItem>();
                        foreach (ListItem item in LstItem1.Items)
                        {
                            if (item.Selected)
                            {
                                Selected_Items.Add(item);
                            }
                        }
                        foreach (ListItem item in Selected_Items)
                        {
                            LstItem2.Items.Add(item);
                            LstItem1.Items.Remove(item);
                        }
                        objconstant = new ConstantMessage();
                        ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "alert('" + objconstant.stritemshift + "');", true);
                    }
                    else
                    {
                        //Index Not Selected
                        objconstant = new ConstantMessage();
                        ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "alert('" + objconstant.stralertitem1notselected + "');", true);
                    }                                            
                }
                else
                {
                    //Empty ListBox
                    objconstant = new ConstantMessage();
                    ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "alert('" + objconstant.stralertEmptyListbox1 + "');", true);
                }
            }
            catch (Exception)
            {
                objconstant = new ConstantMessage();
                Response.Redirect(objconstant.strerrorpage);
            }
            finally
            {
                objconstant = null;
                Selected_Items = null;
                LstItem1.ClearSelection();
                LstItem2.ClearSelection();
            }                                                             
        }
        #endregion
        #region Move data from one ListBox to Other
        /// <summary>
        /// Method Name:BtnLeftToRight_Click
        /// Description: Move the Data from ListBox2 to ListBox1
        /// Author:Bhumi
        /// Created On:17/6/2015
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        protected void BtnRightToLeft_Click(object sender, EventArgs e)
        {
            List<ListItem> Selected_Items;            
            try
            {
                if (LstItem2.Items.Count > 0)
                {
                    if (LstItem2.SelectedIndex != -1)
                    {
                        Selected_Items = new List<ListItem>();
                        foreach (ListItem item in LstItem2.Items)
                        {
                            if (item.Selected)
                            {
                                Selected_Items.Add(item);
                            }
                        }
                        foreach (ListItem item in Selected_Items)
                        {
                            LstItem1.Items.Add(item);
                            LstItem2.Items.Remove(item);
                        }
                        objconstant = new ConstantMessage();
                        ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "alert('" + objconstant.stritemshift + "');", true);
                    }
                    else
                    {
                        //Index Not Selected
                        objconstant = new ConstantMessage();
                        ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "alert('" + objconstant.stralertitem2notselected + "');", true);
                    }
                }
                else
                {
                    //ListBox Empty
                    objconstant = new ConstantMessage();
                    ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "alert('" + objconstant.stralertEmptyListbox2 + "');", true);
                }
            }
            catch (Exception)
            {
                objconstant = new ConstantMessage();
                Response.Redirect(objconstant.strerrorpage);
            }
            finally
            {
                objconstant = null;
                Selected_Items = null;
                LstItem1.ClearSelection();
                LstItem2.ClearSelection();
            }               
        }
        #endregion
        #region Remove Items Button Click Event
        /// <summary>
        /// Method Name:BtnRemove_Click
        /// Description: Remove or Clear the Data from ListBox1
        /// Author:Bhumi
        /// Created On:17/6/2015
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>                
        protected void BtnRemove_Click(object sender, EventArgs e)
        {
            List<ListItem> DeletedItems;
            try
            {
                if (LstItem1.Items.Count > 0)
                {
                    if (LstItem1.SelectedIndex != -1)
                    {
                        DeletedItems = new List<ListItem>();
                        foreach (ListItem item in LstItem1.Items)
                        {
                            if (item.Selected)
                            {
                                DeletedItems.Add(item);
                            }
                        }
                        foreach (ListItem item in DeletedItems)
                        {
                            LstItem1.Items.Remove(item);
                        }
                        objconstant = new ConstantMessage();
                        ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "alert('" + objconstant.stritemdelete + "');", true);
                    }
                    else
                    {
                        //Index Not Selected
                        objconstant = new ConstantMessage();
                        ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "alert('" + objconstant.stralertitem1notselected + "');", true);
                    }
                }
                else
                {
                    //Empty ListBox
                    objconstant = new ConstantMessage();
                    ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "alert('" + objconstant.stralertEmptyListbox1 + "');", true);
                }
            }
            catch (Exception)
            {
                objconstant = new ConstantMessage();
                Response.Redirect(objconstant.strerrorpage);
            }
            finally
            {
                objconstant = null;
                LstItem1.ClearSelection();
                LstItem2.ClearSelection();
            }            
        }
        #endregion
    }
}