using System;
using System.Web.UI.WebControls;

namespace Day_3_4
{
    #region DrpDwn
    /*************************************************************************************************************
     * CLASS NAME                                   :::                     DrpDwn                
     * AUTHOR NAME                                  :::                     ANKIT SHARMA
     * DATE                                         :::                     08/08/2012
     * DESCRIPTION                                  :::                     TO MAKE A DYNAMIC TABLE AND DROPDOWNLIST
     * **********************************************************************************************************/
    public partial class DrpDwn : System.Web.UI.Page
    {
        string[] strArr;                                                         //DECLARATION OF A STRING TYPE ARRAY
        string strTxt;                                                           //DECLARATION OF STRING VARIABLE
        #region Page_Load
     /*************************************************************************************************************
     * FUNCTION NAME                                :::                     PAGE_LOAD                
     * AUTHOR NAME                                  :::                     ANKIT SHARMA
     * DATE                                         :::                     08/08/2012
     * DESCRIPTION                                  :::                     FUNCTION PAFE_LOAD
     * **********************************************************************************************************/
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)                                                 //CHECK IF POST BACK
            {
                if (Session[Constant.strDrpDwnLst] != null)                 //CHECK IF SESSION IS NULL
                {
                    CreateDynamicTable();                                   //CALL FUNCTON CREATEDYNAMICTABLE
                }
            }
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
           // if(IsPostBack)
            if (Session[Constant.strDrpDwnLst] == null)                     //CHECK IF SESSION IS NULL 
            CreateDynamicTable();                                           //CALL THE FUNCTION CREATEDYNAMICTABLE
        }        
        #endregion btnAdd_Click
        #region CreateDynamicTable
        /*************************************************************************************************************
         * FUNCTION NAME                                :::                     CreateDynamicTable                
         * AUTHOR NAME                                  :::                     ANKIT SHARMA
         * DATE                                         :::                     08/08/2012
         * DESCRIPTION                                  :::                     FUNCTION TO CEATE A TABLE WITH DROP_DOWN_LIST DYNAMICALLY
         * **********************************************************************************************************/
        void CreateDynamicTable()
        {
            DropDownList drpdwnMyList;                                      //DECLARATION FOR OBJECT OF DROPDOWN LIST
            Table objTable;                                                 //DECLARATION OF THE OBJECT OF TABLE
            TableRow newRow;                                                //DECLARATION OF THE OBJECT OF TABLEROW
            TableCell newCell, newCell1;                                    //DECLARATION OF THE OBJECT OF TABLECELL
            int intSize;                                                    //DECLARATION OF INTEGER VARIABLE               
            try
            {
                if (txtItem.Text != "")                                     //CHECK IF TEXTBOX HAS SOME VALUES
                {
                    strTxt = txtItem.Text;                                  //ASSIGN THE VALUE OF TXTITEM.TEXT TO STRING STRTEXT                
                    intSize = strTxt.Split(',').Length;                     //FINDING THE TOTAL ITEMS IN TEXTBOX
                    strArr = new string[intSize];                           //INITIALIZATION OF STRING TYPE ARRAY
                    strArr = strTxt.Split(',');                             //SPILITING THE STRING                         
                    Array.Sort(strArr);                                     //SORTING THE ARRAY                      
                    objTable = new Table();                                 //INITIALIZING THE OBJECT OF TABLE
                    objTable.ID = Constant.strTblId;                        //GIVING ID TO TABLE
                    objTable.BorderColor = System.Drawing.Color.Black;      //GIVING BORDER COLOR TO TABLE
                    objTable.BorderWidth = 1;                               //SET THE BORDER-WIDTH OF TABLE
                    objTable.HorizontalAlign = HorizontalAlign.Center;      //SET HORIZONTAL ALIGN OF TABLE                    
                    for (int i = 0; i < intSize; i++)
                    {
                        newRow = new TableRow();                            //INITIALIZING THE OBJECT OF TABLEROW
                        newRow.ID = Constant.strRow + i;                    //SET ID FOR TABLE-ROW
                        newCell = new TableCell();                          //INITIALIZING THE OBJECT OF TABLECELL
                        newCell.ID = Constant.strCol + i;                   //SET ID FOR TABLECELL
                        newCell1 = new TableCell();                         //INITIALIZING THE OBJECT OF TABLE-CELL
                        newCell1.ID = Constant.strCol1 + i;                 //SET THE ID FOR TABLE-CELL
                        newCell.Width = 300;                                //SET THE WIDTH OF TABLE-CELL
                        newCell1.Width = 300;                               //SET THE WIDTH OF TABLE-CELL
                        drpdwnMyList = new DropDownList();                  //INITIALIZATION FOR OBJECT OF DROPDOWNLIST
                        drpdwnMyList.ID = Constant.strDrpId + i;            //DECLARE THE ID OF DROPDOWN LIST
                        drpdwnMyList.BorderWidth = 1;                       //DECLARE THE BORDERWIDTH OF DROPDOWN LIST
                        drpdwnMyList.Width = 300;                           //DECLARE THE WIDTH OF DROPDOWNLIST
                        drpdwnMyList.DataSource = strArr;                   //ASSIGN THE ARRAY TO DROP-DOWN-LIST
                        drpdwnMyList.DataBind();                            //BINDING THE DATA TO DROP-DOWN-LIST
                        newCell.Controls.Add(drpdwnMyList);                 //ADD DROP-DOWN-LIST TO TABLE-CELL
                        newRow.Cells.Add(newCell);                          //ADD TABLE-CELL TO TABLE-ROW
                        drpdwnMyList.SelectedIndex = i;
                        newCell1.Text = Constant.strUSel + drpdwnMyList.SelectedValue;   //PRINT THE MESSEGE TO TABLE-CELL
                        newRow.Cells.Add(newCell1);                         //ADD THE TABLE-CELL TO TABLE-ROW
                        objTable.Rows.Add(newRow);                          //ADD TABLE-ROW TO TABLE
                        PlaceHolder.Controls.Add(objTable);                 //ADD TABLE TO PLACE HOLDER
                        drpdwnMyList.AutoPostBack = true;                   //SET AUTO_POST_BACK TRUE FOR DROPDOWNLIST
                        drpdwnMyList.SelectedIndexChanged += new EventHandler(drpdwnMyList_SelectedIndexChanged);   //CREATE AN EVENT SELECTED_INDEX_CHANGED OF DROPDOWNLIST
                        Session[Constant.strDrpDwnLst] = drpdwnMyList;                      //ASSIGN DROP_DOWN_LIST TO A SESSION                        
                    }                   
                    Session[Constant.strTbl] = objTable;                                    //ASSIGN TABLE TO A SESSION
                }
            }
            catch (Exception)                                                               //IF ANY EXCEPTION IS OCCURED
            {
                Response.Redirect(Constant.strError);                                       //REDIRECT TO ERROR.ASPX
            }
            finally
            {
                
                strArr = null;                                              //ASIGN NULL TO ARRAY
                drpdwnMyList = null;                                        //DESTROY THE OBJECT OF DROPDOWN LIST
                strTxt = null;                                              //ASSIGN NULL TO STRING
                objTable = null;                                            //DESTROY THE OBJECT OF TABLE
                newCell = null;                                             //DESTROY THE OBJECT OF TABLE-CELL
                newCell1 = null;                                            //DESTROYING THE OBJECT OF TABLE-CELL
                newRow = null;                                              //DESTROYING THE OBJECT OF TABLE-ROW
            }
        }
        #endregion CreateDynamicTable
        #region drpdwnMyList_SelectedIndexChanged
        /*************************************************************************************************************
         * FUNCTION NAME                                :::                     drpdwnMyList_SelectedIndexChanged                
         * AUTHOR NAME                                  :::                     ANKIT SHARMA
         * DATE                                         :::                     08/08/2012
         * DESCRIPTION                                  :::                     FUNCTION drpdwnMyList_SelectedIndexChanged
         * **********************************************************************************************************/
        void drpdwnMyList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Table tblNewTable;                                              //DECLARATION OF THE OBJECT IF TABLE        
            TableRow Row;                                                   //DECLARATION OF THE OBJECT OF TABLE-ROW
            TableCell Cell;                                                 //DECLARATION OF THE OBJECT OF TABLE-CELL
            DropDownList ddl;                                               //DECLARATION OF THE OBJECT OF DROP-DOWN-LIST
            try
            {
                ddl = (DropDownList)sender;                                         //ASSIGN THE SENDER TO DROP-DOWN-LIST AFTER PARSING
                if (Session[Constant.strTbl] != null)                               //CHECK IF SESSION IS NULL
                {
                    tblNewTable = (Table)Session[Constant.strTbl];                  //ASSIGN THE SESSION TO TABLE AFTER PARSING
                    strArr = ddl.ID.Split('_');                                     //SPILITING THE ID AND STORING IT INTO ARRAY
                    Row = (TableRow)tblNewTable.FindControl(Constant.strRow + strArr[1]);     //FINDING THE ROW ON WHICH THE EVENT IS FIRED
                    Cell = (TableCell)tblNewTable.FindControl(Constant.strCol1 + strArr[1]);  //FINDING THE CELL ON WHICH THE EVENT IS FIRED
                    Cell.Text = Constant.strUSel + ddl.SelectedValue;             //SHOW THE MESSEGE IN THE CELL OF TABLE
                }
            }
            catch (Exception)                                                    //IF ANY EXCEPTION IS OCCURED
            {
                Response.Redirect(Constant.strError);                            //REDIRECT TO ERROR.ASPX 
            }
            finally
            {
                tblNewTable = null;                                         //DESTROY THE OBJECT OF TABLE
                Row = null;                                                 //DESTROY THE OBJECT OF TABLE-ROW
                Cell = null;                                                //DESTROY THE OBJECT OF TABLE-CELL
                ddl = null;                                                 //DESTROY THE OBJECT OF DROPDOWN LIST
                strArr = null;                                              //ASIGN NULL TO ARRAY
            }
        }
        #endregion drpdwnMyList_SelectedIndexChanged
    }
    #endregion DrpDwn
}
