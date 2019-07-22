using System;
using System.Web.UI.WebControls;


namespace Day_3_4
{
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- _Default
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- The Class for CREATE DYNAMICALLY DROPDOWNLIST.
    //      CREATED DATE    :- 2012/22/06
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class Exercise03 : System.Web.UI.Page
    {
        string[] StrArr;
        string strValue;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                if (Session[Constant.strSsnddlList] != null)              //CHECK CONDITION FOR DROOP_DOWNLIST
                {
                    CreateDynamicTable();                                // CALL CreateDynamicTable METHOD
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            CreateDynamicTable();                                         //CALL CreateDynamicTable METHOD ON BUTTON CLICK
        }
        private void CreateDynamicTable()
        {
            DropDownList ddlList;                                      //DECLARATION FOR OBJECTS
            Table objTable;                                                
            TableRow tr;                                              
            TableCell tc, tc1;                                        
            Label lblSelect;
           try
            {
                if (TextBox1.Text != Constant.strBlank)                 //CHECK IF TEXTBOX HAS SOME VALUES
                {
                    strValue = TextBox1.Text;                             //ASSIGN TEXTVALUE INTO STRVALUE
                    StrArr = strValue.Split(',');                         //SPLIT VALUE AND  STORE
                    Array.Sort(StrArr);                                           //SORTING ARRAY                      
                    objTable = new Table();                                      //INITIALIZING TABLE
                    objTable.BorderColor = System.Drawing.Color.DarkKhaki;      //GIVING BORDER COLOR TO TABLE
                    objTable.BorderWidth = 2;                                  //SET THE BORDER-WIDTH OF TABLE
                                      
                    for (int i = 0; i < StrArr.Length; i++)                   //LOOPING
                    {
                        tr = new TableRow();                                    //INITIALIZING TABLEROW
                        tr.ID = Constant.strTr + i;
                        tc = new TableCell();                                                //INITIALIZING TABLECELL
                        tc.ID = Constant.strTc + i;                                                //SET ID FOR TABLECELL
                        tc1 = new TableCell();                                  //INITIALIZING  TABLE-CELL
                        tc1.ID = Constant.strTc1 + i;                             //SET THE ID FOR TABLE-CELL
                        ddlList = new DropDownList();                           //INITIALIZATION OF DROPDOWNLIST
                        ddlList.ID = Constant.strDdlList+ i;                                    //DECLARE THE ID OF DROPDOWN LIST
                        ddlList.BorderWidth = 1;                                      //DECLARE THE BORDERWIDTH OF DROPDOWN LIST
                        ddlList.DataSource = StrArr;                          //ASSIGN THE ARRAY TO DROP-DOWN-LIST
                        ddlList.DataBind();                                     //BINDING THE DATA TO DROP-DOWN-LIST
                        tc.Controls.Add(ddlList);                                       //ADD DROP-DOWN-LIST TO TABLE-CELL
                        tr.Cells.Add(tc);                                                 //ADD TABLE-CELL TO TABLE-ROW
                        ddlList.SelectedIndex = i;                                        
                        lblSelect = new Label();                                     //INITIALIZE LABEL 
                        lblSelect.ID = Constant.strLblSelect + i; 
                        lblSelect.Text = Constant.strSelectedItem + ddlList.SelectedValue;
                        tc1.Controls.Add(lblSelect);
                        tr.Cells.Add(tc1);                                                          //ADD THE LABEL TO TABLE-ROW
                        objTable.Rows.Add(tr);                                                          //ADD TABLE-ROW TO TABLE
                        PlaceHolder1.Controls.Add(objTable);                                            //ADD TABLE TO PLACE HOLDER
                        ddlList.AutoPostBack = true;                                               //SET AUTO_POST_BACK TRUE FOR DROPDOWNLIST
                        ddlList.SelectedIndexChanged += new EventHandler(ddlList_SelectedIndexChanged);   //CREATE AN EVENT SELECTED_INDEX_CHANGED OF DROPDOWNLIST
                        Session[Constant.strSsnddlList] = ddlList;                                          //ASSIGN DROP_DOWN_LIST TO A SESSION                        
                    }
                    Session[Constant.strTable1] = objTable;                                            //ASSIGN TABEL TO SESSION                                              
                }
                ViewState[Constant.strDynamictable] = true;
            }
            catch (Exception)                                                               //IF ANY EXCEPTION IS OCCURED
            {
                Response.Redirect(Constant.strErrorPage);                                       //REDIRECT TO ERROR.ASPX
            }
            finally                                                                         //REALOCATE MEMORY
            {
                  ddlList = null;                                                             
                  objTable = null;                                                                    
                  tc = null;                                             
                  tc1 = null;                                            
                  tr = null;                                            
                  lblSelect = null;
            }
        }

        protected void ddlList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Table tblNew1;                                                                //DECLARATION OF THE OBJECTS       
            TableRow tRow;                                                   
            TableCell tCell;                                                                 
            DropDownList ddl;                                               
            Label lbl;
          
            try
            {
                ddl = (DropDownList)sender;                                                      //ASSIGN THE SENDER TO DROP-DOWN-LIST AFTER PARSING
                if (Session[Constant.strTable1] != null)                                             //CHECK IF SESSION IS NULL
                {
                    tblNew1 = (Table)Session[Constant.strTable1];                               //ASSIGN THE SESSION TO TABLE AFTER PARSING
                    StrArr = ddl.ID.Split('_');                                                      //SPILITING THE ID AND STORING IT INTO ARRAY
                    tRow = (TableRow)tblNew1.FindControl(Constant.strTr + StrArr[1]);                        //FINDING THE ROW ON WHICH THE EVENT IS FIRED
                    tCell = (TableCell)tblNew1.FindControl(Constant.strTc1 + StrArr[1]);                       //FINDING THE CELL ON WHICH THE EVENT IS FIRED
                    lbl = (Label)tblNew1.Rows[1].Cells[1].FindControl(Constant.strLblSelect + StrArr[1]);
                    lbl.Text = Constant.strSelectedItem + ddl.SelectedValue;
                }
            }
            catch (Exception ex)
            {
                Response.Redirect(Constant.strErrorPage);                                       //REDIRECT TO ERROR.ASPX
            }
            finally                                                                              //REALLOCATE MEMORY                                           
            {
                tblNew1 = null;
                tRow=null;
                tCell=null;
                ddl = null;
                lbl = null;
            }


        }
        protected override void LoadViewState(object earlierState)
        {
            base.LoadViewState(earlierState);
            if (ViewState[Constant.strDynamictable] == null)
                CreateDynamicTable();
        }
    }
}
