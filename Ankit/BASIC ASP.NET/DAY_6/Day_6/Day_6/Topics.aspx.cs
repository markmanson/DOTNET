using System;
using System.Web.UI.WebControls;

namespace Day_6
{
    #region Topics
    /*************************************************************************************************************
     * CLASS NAME                                   :::                     Topics                
     * AUTHOR NAME                                  :::                     ANKIT SHARMA
     * DATE                                         :::                     16/08/2012
     * DESCRIPTION                                  :::                     TO SHOW OPTIONS SELECTED BY USER ON DEFAULT PAGE 
     * **********************************************************************************************************/
    public partial class Topics : System.Web.UI.Page
    {
        #region Page_Load
        /*************************************************************************************************************
         * FUNCTION NAME                                :::                     PAGE_LOAD                
         * AUTHOR NAME                                  :::                     ANKIT SHARMA
         * DATE                                         :::                     16/08/2012
         * DESCRIPTION                                  :::                     FUNCTION PAGE LOAD
         * **********************************************************************************************************/
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string[] arrData;                                                           //DECLARATION OF A STRING TYPE ARRAY
                int intsize;                                                                //DECLARATION OF AN INTIGER VARIABLE
                string strData;                                                             //DECLARATION OF A STRING TYPE VARIABLE
                Table tblMytable;                                                           //DECLARATION OF AN OBJECT OF TABLE
                TableRow Row;                                                               //DECLARATION OF AN OBJECT OF TABLEROW
                TableCell Cell;                                                             //DECLARATION OF AN OBJECT OF TABLECELL
                LinkButton lnkMyLink;                                                       //DECLARATION OF AN OBJECT OF LINKBUTTON
                TableHeaderRow HeadRow;                                                     //DECLARATION OF THE OBJECT TABLE HEADER ROW
                TableHeaderCell HeadCell;                                                   //DECLARATION OF THE OBJECT TABLE HEADER CELL
                try
                {
                    if (Request[Constant.strText] != null)                                  //CHECK IF REQUEST OBJECT IS NULL
                    {
                        HeadCell = new TableHeaderCell();                                   //INITIALIZATION OF AN OBJECT OF TABLEHEADERCELL
                        HeadRow = new TableHeaderRow();                                     //INITIALIZATION OF AN OBJECT OF TABLEHEADREROW
                        tblMytable = new Table();                                           //INITIALIZATION OF AN OBJECT OF TABLE
                        tblMytable.ID = Constant.strTblId;                                    //ASSIGN ID TO THE TABLE OBJECT
                        tblMytable.HorizontalAlign = HorizontalAlign.Center;                  //SET HORIZONTAL ALIGN FOR TABLE
                        tblMytable.BackColor = System.Drawing.Color.BlanchedAlmond;         //SET BACK-COLOR OF TABLE
                        tblMytable.BorderWidth = 2;                                         //SET BORDER-WIDTH OF TABLE
                        tblMytable.Width = 300;                                             //SET WIDTH OF TABLE
                        tblMytable.BorderColor = System.Drawing.Color.Black;                //SET BORDER COLOR OF TABLE
                        HeadCell.Text = Constant.strMsg;                                    //ASSIGN THE MESSEGE TO HEADCELL.TEXT
                        HeadRow.Cells.Add(HeadCell);                                        //ADD HEADCELL TO HEADROW
                        tblMytable.Rows.Add(HeadRow);                                       //ADD HEADROW TO TABLE
                        strData = Request[Constant.strText].ToString();                     //STORE THE VALUE OF REQUEST TO THE STRING
                        intsize = (strData.Split(Constant.chrCmma).Length) / 2;                              //INITIALIZE AN INTEGER VARIABLE FOR SIZE OF ARRAY
                        arrData = new string[intsize * 2];                                  //INITIALIZATION OF AN OBJECT OF STRING TYPE ARRAY                                     
                        arrData = strData.Split(Constant.chrCmma);                                       //STORE THE STRING INTO AN ARRAY AFTER SPILITING BY ","
                        int j = 0;                                                          //INITIALIZE A LOCAL INTEGER VARIABLE
                        for (int i = 0; i < intsize; i++)                                   //ITERATION 
                        {
                            Row = new TableRow();                                           //INITIALIZATION OF AN OBJECT OF TABLEROW
                            Row.ID = Constant.strRow + i;                                   //ASSIGN ID TO THE OBJECT OF TABLEROW
                            Cell = new TableCell();                                         //INITIALIZATION OF AN OBJECT OF TABLECELL
                            Cell.ID = Constant.strCell + i;                                 //ASSIGN ID TO THE OBJECT OF TABLECELL
                            lnkMyLink = new LinkButton();                                   //INITIALIZATION OF AN OBJECT OF LINKBUTTON
                            lnkMyLink.ID = Constant.strLnkBtnId + i;                        //ASSIGN ID TO LINK BUTTON
                            lnkMyLink.Text = arrData[j];                                    //ASSIGN ARRAYDATA TO THE LINKBUTTON.TEXT
                            lnkMyLink.PostBackUrl = arrData[j + 1];                           //ASSIGN ARRAYDATA TO THE LINKBUTTON.POSTBACKURL
                            Cell.Controls.Add(lnkMyLink);                                   //ADD LINKBUTTON TO THE TABLECELL
                            Row.Cells.Add(Cell);                                            //ADD TABLECELL TO THE TABLE ROW
                            tblMytable.Rows.Add(Row);                                       //ADD TABLEROW TO THE TABLE
                            tblMytable.Visible = true;                                      //SET VISIBLE TRUE FOR TABLE
                            PlaceHolder.Controls.Add(tblMytable);                           //ADD TABLE TO THE PLACEHOLDER
                            j = j + 2;                                                      //INCREEMENT IN LOCAL INTEGER VARIABLE
                        }
                    }
                }
                catch                                                        //IF EXCEPTION OCCURED
                {
                    Response.Redirect(Constant.strError);                                        //REDIRECT TO ERROR.ASPX    
                }
                finally
                {
                    //ASSIGN NULL TO EACH OBJECT INITIALIZED ABOVE
                    Row = null;
                    Cell = null;
                    tblMytable = null;
                    strData = null;
                    lnkMyLink = null;
                    HeadCell = null;
                    HeadRow = null;
                }
            }
        }
        #endregion Page_Load
    }
    #endregion Topics
}
