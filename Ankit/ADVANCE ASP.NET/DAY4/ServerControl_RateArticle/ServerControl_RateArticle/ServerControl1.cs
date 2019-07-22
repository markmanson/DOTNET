using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerControl_RateArticle
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:ServerControl1 runat=server></{0}:ServerControl1>")]
    /*************************************************************************************************************
        * CLASS NAME                                   :::                     ServerControl1                
        * AUTHOR NAME                                  :::                     ANKIT SHARMA
        * DATE                                         :::                     11/09/2012
        * DESCRIPTION                                  :::                     TO CREATE THE RATING FORM
        * **********************************************************************************************************/
    public class ServerControl1 : WebControl,INamingContainer
    {
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        RadioButtonList RblGrade;                                               //DECLARATION OF THE OBJECT OF RADIOBUTTONLIST
        Button btnVote;                                                         //DECLARATION OF THE OBJECT OF BUTTON
        Table newTable;                                                         //DECLARATION OF THE OBJECT OF TABLE
        TableRow newTableRow;                                                   //DECLARATION OF THE OBJECT OF TABLEROW
        TableRow newTableRow2;                                                  //DECLARATION OF THE OBJECT OF TABLEROW
        TableRow newTableRow3;                                                  //DECLARATION OF THE OBJECT OF TABLEROW
        TableCell newTableCell;                                                 //DECLARATION OF THE OBJECT OF TABLECELL
        TableCell newTableCell1;                                                //DECLARATION OF THE OBJECT OF TABLECELL
        TableCell newTableCell2;                                                //DECLARATION OF THE OBJECT OF TABLECELL
        TableCell newTableCell3;                                                //DECLARATION OF THE OBJECT OF TABLECELL
        public event EventHandler Click;                                        //DECLARATION OF EVENT CLICK
        public event EventHandler SelectedIndexChanged;                         //DECLARATION OF EVENT SELECTED INDEX CHANGED
        public  Label lblClick;                                                 //DECLARATION OF THE OBJECT OF LABEL
        public Label lblRate;                                                   //DECLARATION OF THE OBJECT OF LABEL
        /*****************************************PROPERTY FOR ID **************************************************************************/
        public string Text
        {
            get
            {
                String s = (String)ViewState["Text"];
                return ((s == null) ? "[" + this.ID + "]" : s);
            }

            set
            {
                ViewState["Text"] = value;
            }
        }        
         #region CreateChildControls
        /*************************************************************************************************************
        * FUNCTION NAME                                :::                     CreateChildControls                
        * AUTHOR NAME                                  :::                     ANKIT SHARMA
        * DATE                                         :::                     11/09/2012
        * DESCRIPTION                                  :::                     TO CREATE THE RATING FORM
        * **********************************************************************************************************/
        protected override void CreateChildControls()
        {
            try
            {
                newTable = new Table();                                                 //INITIALIZATION OF THE OBJECT OF TABLE
                newTableRow = new TableRow();                                           //INITIALIZATION OF THE OBJECT OF TABLEROW
                newTableRow2 = new TableRow();                                          //INITIALIZATION OF THE OBJECT OF TABLEROW
                newTableRow3 = new TableRow();                                          //INITIALIZATION OF THE OBJECT OF TABLEROW
                newTableCell2 = new TableCell();                                        //INITIALIZATION OF THE OBJECT OF TABLECELL
                newTableCell3 = new TableCell();                                        //INITIALIZATION OF THE OBJECT OF TABLECELL
                newTableCell = new TableCell();                                         //INITIALIZATION OF THE OBJECT OF TABLECELL
                newTableCell1 = new TableCell();                                        //INITIALIZATION OF THE OBJECT OF TABLECELL
                RblGrade = new RadioButtonList();                                       //INITIALIZATION OF THE OBJECT OF RADIOBUTTONLIST
                lblClick = new Label();                                                 //INITIALIZATION OF THE OBJECT OF LABEL
                lblRate = new Label();                                                  //INITIALIZATION OF THE OBJECT OF LABEL
                btnVote = new Button();                                                 //INITIALIZATION OF THE OBJECT OF BUTTON
                RblGrade.AutoPostBack = true;                                           //SET AUTO POST BACK TRUE
                RblGrade.RepeatDirection = RepeatDirection.Horizontal;                  //SET REPEAT DIRECTION HORIZONTAL
                RblGrade.SelectedIndexChanged += new EventHandler(RblGrade_SelectedIndexChanged);   //GENERATE THE EVENT SELECTED INDEX CHANGED
                for (int i = 1; i <= 5; i++)
                    RblGrade.Items.Add(new ListItem(i.ToString(), i.ToString()));       //ADD THE ITEMS INTO RADIO BUTTON LIST
                btnVote.Text = Constant.strBtnTxt;                                       //SET THE BUTTON TEXT
                btnVote.Click += new EventHandler(btnVote_Click);                       //GENERATE THE CLICK EVENT FOR BUTTON
                newTableCell2.Controls.Add(lblRate);                                    //ADD LABEL TO THE TABLE CELL
                newTableRow2.Cells.Add(newTableCell2);                                  //ADD TABLE CELL TO THE TABLE ROW
                newTableCell3.Controls.Add(lblClick);                                   //ADD LABEL TO THE TABLE CELL
                newTableRow3.Cells.Add(newTableCell3);                                  //ADD TABLE CELL TO THE TABLE ROW
                newTableCell.Controls.Add(RblGrade);                                    //ADD RADIOBUTTON LIST TO THE TABLE CELL
                newTableCell1.Controls.Add(btnVote);                                    //ADD BUTTON TO THE TABLE CELL
                newTableRow.Cells.Add(newTableCell);                                    //ADD TABLE CELL TO THE TABLE ROW
                newTableRow.Cells.Add(newTableCell1);                                   //ADD TABLE CELL TO THE TABLE ROW
                newTable.Rows.Add(newTableRow2);                                        //ADD TABLE ROW TO THE TABLE 
                newTable.Rows.Add(newTableRow3);                                        //ADD TABLE ROW TO THE TABLE 
                newTable.Rows.Add(newTableRow);                                         //ADD TABLE ROW TO THE TABLE
                newTable.HorizontalAlign = HorizontalAlign.Center;                      //SET HORIZONTAL ALLIGN CENTER
                newTable.BackColor = System.Drawing.Color.Honeydew;                     //SET BACK COLOR FOR TABLE
                Controls.Add(newTable);                                                 //ADD TABLE TO THE PAGE
            }
            finally
            {
                RblGrade=null;                                                          //ASSIGN NULL TO THE OBJECT OF RADIOBUTTONLIST
                btnVote = null;                                                         //ASSIGN NULL TO THE OBJECT OF BUTTON
                newTable = null;                                                        //ASSIGN NULL TO THE OBJECT OF TABLE
                newTableRow = null;                                                     //ASSIGN NULL TO THE OBJECT OF TABLEROW
                newTableRow2 = null;                                                    //ASSIGN NULL TO THE OBJECT OF TABLEROW
                newTableRow3 = null;                                                    //ASSIGN NULL TO THE OBJECT OF TABLEROW
                newTableCell = null;                                                    //ASSIGN NULL TO THE OBJECT OF TABLECELL
                newTableCell1 = null;                                                   //ASSIGN NULL TO THE OBJECT OF TABLECELL
                newTableCell2 = null;                                                   //ASSIGN NULL TO THE OBJECT OF TABLECELL
                newTableCell3 = null;                                                   //ASSIGN NULL TO THE OBJECT OF TABLECELL
            }
        }
        #endregion CreateChildControls
        #region RblGrade_SelectedIndexChanged
        /*************************************************************************************************************
        * FUNCTION NAME                                :::                     RblGrade_SelectedIndexChanged                
        * AUTHOR NAME                                  :::                     ANKIT SHARMA
        * DATE                                         :::                     11/09/2012
        * DESCRIPTION                                  :::                     SELECTED INDEX CHANGED FOR RADIO_BUTTON_LIST
        * **********************************************************************************************************/
        protected virtual void RblGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedIndexChanged != null)                                           //CHECK IF CLICK EVENT IS NOT NULL
                SelectedIndexChanged(this, e);                                          //CALL THE CLICK EVENT
        }       
        #endregion RblGrade_SelectedIndexChanged
        #region btnVote_Click
        /*************************************************************************************************************
        * FUNCTION NAME                                :::                     btnVote_Click                
        * AUTHOR NAME                                  :::                     ANKIT SHARMA
        * DATE                                         :::                     11/09/2012
        * DESCRIPTION                                  :::                     CLICK EVENT FOR BUTTON
        * **********************************************************************************************************/
        protected virtual void btnVote_Click(object sender, EventArgs e)
        {
            if (Click != null)                                                  //CHECK IF CLICK EVENT IS NOT NULL
                Click(this,e);                                                  //CALL THE CLICK EVENT
        }
        #endregion btnVote_Click
    }
}
