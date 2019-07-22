using System;
using System.Web.UI.WebControls;
/// <summary>
/// NamespaceName:ASP_Day3_4
/// Description: Basic ASP.Net study
/// Author: Bhumi
/// Created On:17/6/2015
/// </summary>    
namespace ASP_Day3_4
{
    public partial class Default_Form3 : System.Web.UI.Page
    {
        ConstantMessage objconstant;
        DropDownList objDdlCreate;
        Label LblText;                        
        #region Page Load
        /// <summary>
        /// Event Name:Page_Load
        /// Description: Initialization of web Controls
        /// Author: Bhumi
        /// Created On:17/6/2015
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>   
        string[] objArray;
        //Get the items value from Array            
        protected void Page_Load(object sender, EventArgs e)
        {
            objArray = (TxtItem.Text).Split(',');                        
            if (IsPostBack)
            {
                Dynamic_Table_Fill();                
            }                                                                              
        }
        #endregion
        #region DropDownList Index Changed
        /// <summary>
        /// Method Name:objDdlCreate_SelectedIndexChanged
        /// Decsription:Show the Selected Item on label
        /// Author:Bhumi
        /// Created On:18/6/2015
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void objDdlCreate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < TblDynamic.Rows.Count; i++)
                {
                    DropDownList Ddl = (DropDownList)sender;
                    //Identify Dropdownlist from table
                    if (TblDynamic.Rows[i].Cells[0].Controls.Contains((DropDownList)Ddl))
                    {
                        objconstant = new ConstantMessage();
                        //Derive label from table and show Label Message
                        TblDynamic.Rows[i].Cells[1].Text = objconstant.strselectedvalue + Ddl.SelectedItem;                                        
                    }
                }
            }
            catch (Exception)
            {
                objconstant = new ConstantMessage();                        
                Response.Redirect(objconstant.strerrorpage);//Error
            }
            finally
            {
                objconstant = null;
                LblText = null;
                objDdlCreate = null;
                //TxtItem.Text = "";For second dropdownlist event textbox value find blank
            }
        }
        #endregion        
        #region Generate Table Dynamically 
        /// <summary>
        /// Method Name:Dynamic_Table_Fill
        /// Description:Dynamically Generate Table & Table Rows with Dropdownlist and Labels
        /// Author:Bhumi
        /// Created On:17/6/2015        
        /// </summary>
        public void Dynamic_Table_Fill()
        {
            Array.Sort(objArray);//Sort the Array           
            TableRow tRow;
            TableCell tCell;
            try
            {
                if (TxtItem.Text != "")
                {
                    for (int i = 1; i <= objArray.Length; i++)
                    {
                        // Create new row and add it to the table.
                        tRow = new TableRow();
                        TblDynamic.Rows.Add(tRow);
                        for (int j = 1; j < 2; j++)
                        {
                            tCell = new TableCell();
                            tRow.Cells.Add(tCell);//ADD Cell
                            objDdlCreate = new DropDownList();
                            objDdlCreate.AutoPostBack = true;
                            objDdlCreate.DataSource = objArray;
                            objDdlCreate.DataBind();                            
                            objDdlCreate.SelectedIndexChanged += objDdlCreate_SelectedIndexChanged;
                            tCell.Controls.Add(objDdlCreate);//Add Dropdownlist In Cell
                            tCell = new TableCell();
                            tRow.Cells.Add(tCell);//ADD Cell
                            LblText = new Label();
                            tCell.Controls.Add(LblText);//Add Label in cell                                            
                        }
                    }
                }
                else
                {
                    objconstant = new ConstantMessage();
                    ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "alert('" + objconstant.strblankItem + "');", true);
                }            
            }
            catch (Exception)
            {
                objconstant = new ConstantMessage();                        
                Response.Redirect(objconstant.strerrorpage);//Error
            }
            finally
            {
                objDdlCreate = null;
                tRow = null;
                tCell = null;
                objconstant = null;                
            }
        }
        #endregion
    }
}