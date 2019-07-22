using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DAY3Exercise
{
    /// <summary>
    /// Name:CreateDropDown.aspx
    /// Description:"Task : 1 Accpet the item in TxtItem in
    ///comma seperated values like 
    ///(Apple, Mango, Orange etc.). Store that
    ///item in array object (objArray) in acending order."
    ///"Task : 2 Create the object of the 
    ///dropdown list objDropDwon on runtime and fill its items from objArray."
    ///Task : 3 Create server side table and 
    ///add rows on runtime."
    ///"Task : 4 Add objDropDown to the 
    ///each row of the table."
    ///Task: 5 Handle Selected index changed event. Display the current selected name on screen
    /// Author:Monal Shah
    /// CreatedDate:2010/10/12
    /// </summary>
    public partial class CreateDropDown : System.Web.UI.Page
    {
        string[] ObjArray;
        DropDownList objDrpDownLstItems;
        Table objTable;
        TableCell objCell, objCell1;
        Label lbl;
        TableRow objTableRow;
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description:Create table dynamically
        /// Author:Monal Shah   
        /// CreatedDate:2010/10/12
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            TxtDropDownItems.Focus();
            Panel2.Visible = false;
            LblErrorMessageId.Text=ConstantMessage.NoteValue;
            if (TxtDropDownItems.Text != "")
            {

                if (IsPostBack)
                {
                    if (Session["ComboBox"] != null)
                    {
                        createTable();
                    }
                }
            }
        }
        #endregion

        #region BtnCreateDropDown_Click
        /// <summary>
        /// Name:BtnCreateDropDown_Click
        /// Description:"Task : 1 Accpet the item in TxtItem in
        ///                     comma seperated values like 
        ///                     (Apple, Mango, Orange etc.). Store that
        ///                    item in array object (objArray) in acending order."
        ///                   "Task : 2 Create the object of the 
        ///                     dropdown list objDropDwon on runtime and fill its items from objArray."
        ///                    Task : 3 Create server side table and 
        ///                      add rows on runtime."
        ///                     "Task : 4 Add objDropDown to the 
        ///                         each row of the table."
        ///                     Task: 5 Handle Selected index changed event. Display the current selected name on screen
        /// Author:Monal Shah
        /// CreatedDate:2010/10/12
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnCreateDropDown_Click(object sender, EventArgs e)
        {

            if (TxtDropDownItems.Text == "")
            {
                TxtDropDownItems.Text = string.Empty;
                LblErrorMessageId.Visible = true;
                LblErrorMessageId.Text = ConstantMessage.ValidValue;
                Panel2.Visible = false;

            }
            else
            {
                LblErrorMessageId.Text = ConstantMessage.NoteValue;
                Panel2.Visible = true;
                createTable();

            }

        }
        #endregion

        #region createTable
        /// <summary>
        /// Name:createTable
        /// Description:"Task : 1 Accpet the item in TxtItem in
        ///                     comma seperated values like 
        ///                     (Apple, Mango, Orange etc.). Store that
        ///                    item in array object (objArray) in acending order."
        ///                   "Task : 2 Create the object of the 
        ///                     dropdown list objDropDwon on runtime and fill its items from objArray."
        ///                    Task : 3 Create server side table and 
        ///                      add rows on runtime."
        ///                     "Task : 4 Add objDropDown to the 
        ///                         each row of the table."
        ///                     Task: 5 Handle Selected index changed event. Display the current selected name on screen
        /// Author:Monal Shah
        /// CreatedDate:2010/10/12
        /// </summary>

        public void createTable()
        {
            try
            {
                ObjArray = TxtDropDownItems.Text.Split(',');
                Array.Sort(ObjArray);

                Panel2.Controls.Clear();
                objTable = new Table();
                Panel2.Controls.Add(objTable);
                for (int i = 0; i < ObjArray.Length; i++)
                {
                    objTableRow = new TableRow();
                    objTableRow.ID = "Row" + Convert.ToString(i);
                    objCell = new TableCell();
                    objCell.ID = "Row" + Convert.ToString(i) + Convert.ToString("Cell0");
                    objCell1 = new TableCell();
                    objCell1.ID = "Row" + Convert.ToString(i) + Convert.ToString("Cell1");
                    lbl = new Label();
                    lbl.ID = "Label" + Convert.ToString(i);// +Convert.ToString("Cell1");
                    objDrpDownLstItems = new DropDownList();
                    objDrpDownLstItems.ID = "Ddl_" + i;// +Convert.ToString("Cell0");
                    objDrpDownLstItems.AutoPostBack = true;
                    objDrpDownLstItems.AppendDataBoundItems = true;
                    objDrpDownLstItems.Visible = true;
                    objDrpDownLstItems.DataSource = ObjArray;
                    objDrpDownLstItems.DataBind();
                    Session["ComboBox"] = objDrpDownLstItems;

                    objDrpDownLstItems.SelectedIndexChanged += new EventHandler(objDrpDownLstItems_SelectedIndexChanged);


                    objCell.Controls.Add(objDrpDownLstItems);
                    objCell1.Controls.Add(new LiteralControl(ConstantMessage.SelectedValue));

                    lbl.Text = objDrpDownLstItems.SelectedItem.Value.ToString();

                    objCell1.Controls.Add(lbl);
                    objTableRow.Controls.Add(objCell);
                    objTableRow.Controls.Add(objCell1);
                    objTable.Controls.Add(objTableRow);
                    Session["Table"] = objTable;
                }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
        }
        #endregion
        #region objDrpDownLstItems_SelectedIndexChanged
        /// <summary>
        /// Name:createTable
        /// Description:Task: 5 Handle Selected index changed event. Display the current selected name on screen
        /// Author:Monal Shah
        /// CreatedDate:2010/10/13
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void objDrpDownLstItems_SelectedIndexChanged(object sender, EventArgs e)
        {
            Panel2.Visible = true;
            DropDownList ComboBox = (DropDownList)sender;
            try
            {
                if (Session["ComboBox"] != null)
                {

                    string strComboId = ComboBox.ID;
                    string[] splitValue = strComboId.Split('_');

                    Table tblTable = (Table)Session["Table"];
                    TableRow tblrow = (TableRow)tblTable.FindControl("Row" + splitValue[1]);
                    TableCell tblCell = (TableCell)tblrow.FindControl("Row" + splitValue[1] + "cell1");
                    Label lbl = (Label)tblCell.FindControl("Label" + splitValue[1]);

                    lbl.Text = ComboBox.SelectedItem.ToString();

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
