using System;
using System.ComponentModel;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace ServerControlLogin
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:ServerControl1 runat=server></{0}:ServerControl1>")]
    public class ServerControl1 : WebControl,INamingContainer
    {
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        Label lblid;                                                            //DECLARATION OF THE OBJECT OF LABEL                                                   
        Label lblPass;                                                          //DECLARATION OF THE OBJECT OF LABEL 
        Label lblError;                                                         //DECLARATION OF THE OBJECT OF LABEL 
        Label lblHeader;                                                        //DECLARATION OF THE OBJECT OF LABEL 
        TextBox txtId;                                                          //DECLARATION OF THE OBJECT OF TEXTBOX 
        TextBox txtPass;                                                        //DECLARATION OF THE OBJECT OF TEXTBOX 
        Button btnSubmit;                                                       //DECLARATION OF THE OBJECT OF BUTTON 
        Table newTable;                                                         //INITIALIZATION OF THE OBJECT OF TABLE
        TableHeaderRow newTableHeaderRow;                                       //INITIALIZATION OF THE OBJECT OF TABLEHEADERROW
        TableHeaderRow newTableHeaderRow1;                                      //INITIALIZATION OF THE OBJECT OF TABLEHEADERROW
        TableRow newTableRow1;                                                  //INITIALIZATION OF THE OBJECT OF TABLEROW
        TableRow newTableRow;                                                   //INITIALIZATION OF THE OBJECT OF TABLEROW
        TableRow newTableRow2;                                                  //INITIALIZATION OF THE OBJECT OF TABLEROW
        TableHeaderCell newTableHeaderCell;                                     //INITIALIZATION OF THE OBJECT OF TABLEHEADERCELL
        TableHeaderCell newTableHeaderCell1;                                    //INITIALIZATION OF THE OBJECT OF TABLEHEADERCELL
        TableCell newTableCell;                                                 //INITIALIZATION OF THE OBJECT OF TABLECELL
        TableCell newTableCell1;                                                //INITIALIZATION OF THE OBJECT OF TABLECELL
        TableCell newTAbleCell2;                                                //INITIALIZATION OF THE OBJECT OF TABLECELL
        TableCell newTableCell3;                                                //INITIALIZATION OF THE OBJECT OF TABLECELL
        TableCell newTableCell4;                                                //INITIALIZATION OF THE OBJECT OF TABLECELL
        public event EventHandler Click;                                        //INITIALIZATION OF THE OBJECT OF EVENTHANDLER
        #region CreateChildControls
        /*************************************************************************************************************
        * FUNCTION NAME                                :::                     CreateChildControls                
        * AUTHOR NAME                                  :::                     ANKIT SHARMA
        * DATE                                         :::                     07/09/2012
        * DESCRIPTION                                  :::                     TO CREATE THE LOGIN FORM
        * **********************************************************************************************************/
        protected override void CreateChildControls()
        {
        
            lblid = new Label();                                            //INITIALIZATION OF THE OBJECT OF LABEL                                                   
            lblHeader = new Label();                                        //INITIALIZATION OF THE OBJECT OF LABEL   
            lblPass = new Label();                                          //INITIALIZATION OF THE OBJECT OF LABEL
            lblError = new Label();                                         //INITIALIZATION OF THE OBJECT OF LABEL
            txtId = new TextBox();                                          //INITIALIZATION OF THE OBJECT OF TEXTBOX
            txtPass = new TextBox();                                        //INITIALIZATION OF THE OBJECT OF TEXTBOX
            btnSubmit = new Button();                                       //INITIALIZATION OF THE OBJECT OF BUTTON
            newTable = new Table();                                         //INITIALIZATION OF THE OBJECT OF TABLE
            newTableHeaderRow = new TableHeaderRow();                       //INITIALIZATION OF THE OBJECT OF TABLEHEADERROW   
            newTableHeaderRow1 = new TableHeaderRow();                      //INITIALIZATION OF THE OBJECT OF TABLEHEADERROW   
            newTableRow = new TableRow();                                   //INITIALIZATION OF THE OBJECT OF TABLEROW
            newTableRow1 = new TableRow();                                  //INITIALIZATION OF THE OBJECT OF TABLEROW
            newTableRow2 = new TableRow();                                  //INITIALIZATION OF THE OBJECT OF TABLEROW
            newTableHeaderCell = new TableHeaderCell();                     //INITIALIZATION OF THE OBJECT OF TABLEHEADERCELL
            newTableHeaderCell1 = new TableHeaderCell();                    //INITIALIZATION OF THE OBJECT OF TABLEHEADERCELL
            newTableCell = new TableCell();                                 //INITIALIZATION OF THE OBJECT OF TABLECELL
            newTableCell1 = new TableCell();                                //INITIALIZATION OF THE OBJECT OF TABLECELL
            newTAbleCell2 = new TableCell();                                //INITIALIZATION OF THE OBJECT OF TABLECELL
            newTableCell3 = new TableCell();                                //INITIALIZATION OF THE OBJECT OF TABLECELL
            newTableCell4 = new TableCell();                                //INITIALIZATION OF THE OBJECT OF TABLECELL
            lblHeader.Text = Constant.strHeaderText;                        //SET  THE TEXT PROPERT OF LBLHEADER
            lblHeader.Width = 200;                                          //SET THE WIDTH OF LBLHEADER
            newTableHeaderCell1.HorizontalAlign = HorizontalAlign.Center;   //SET HORIZONTAL ALIGN CENTER
            newTableHeaderCell1.ColumnSpan = 2;                             //SET COLUMNSPAN 2
            newTableHeaderCell1.Controls.Add(lblHeader);                    //ADD lblheader TO TABLECELL
            newTableHeaderRow1.Cells.Add(newTableHeaderCell1);              //ADD HEADERCELL TO ROW
            newTable.Rows.Add(newTableHeaderRow1);                          //ADD TABLEHEADERROW TO TABLE
            lblError.Width = 200;                                           //SET THE WIDTH OF LBLERROR
            newTableHeaderCell.HorizontalAlign = HorizontalAlign.Center;    //SET HORIZONTAL ALIGN CENTER
            newTableHeaderCell.ColumnSpan = 2;                              //SET COLUMNSPAN 2
            newTableHeaderCell.Controls.Add(lblError);                      //ADD LBLERROR TO TABLECELL
            newTableHeaderRow.Cells.Add(newTableHeaderCell);                //ADD TABLECELL TO TABLE ROW
            lblid.Text = Constant.strUserText;                                        //SET ID FOR LBLID
            lblid.Width = 100;                                              //SET THE WIDTH OF LABEL
            lblid.Font.Bold = true;                                         //SET FONT BOLD 
            newTableCell.Controls.Add(lblid);                               //ADD LBLID TO TABLE CELL
            newTableRow.Cells.Add(newTableCell);                            //ADD TABLE CELL TO TABLE ROW
            txtId.Width = 100;                                              //SET THE WIDTH OF TXTID
            newTableCell1.Controls.Add(txtId);                              //ADD TXTID TO TABLECELL
            newTableRow.Cells.Add(newTableCell1);                           //ADD TABLECELL TO TABLE ROW
            lblPass.Width = 100;                                            //SET THE WIDTH OF LBLPASS
            lblPass.Font.Bold = true;                                       //SET FONT BOLD
            lblPass.Text = Constant.strPassText;                                      //SET LXLPASS.TEXT= PASSWORD 
            newTAbleCell2.Controls.Add(lblPass);                            //ADD LBLPASS TO TABLE CELL
            txtPass.Width = 100;                                            //SET TXTPASS WIDTH
            txtPass.TextMode = TextBoxMode.Password;                        //SET TEXTMODE =PASSWORD
            newTableCell3.Controls.Add(txtPass);                            //ADD TXTPASS TO TABLE CELL
            newTableRow1.Cells.Add(newTAbleCell2);                          //ADD TABLECELL TO TABLE ROW
            newTableRow1.Cells.Add(newTableCell3);                          //ADD TABLECELL TO TABLE ROW
            btnSubmit.Text = Constant.strSubmitText;                                      //SET THE TEXT PROPERTY OF BTNSUBMIT
            btnSubmit.Width = 100;                                          //SET WIDTH OF BTNSUBMIT
            btnSubmit.Click += new EventHandler(btnSubmit_Click);           //GENRATE EVENT HANDLER FOR BTNSUBMIT
            newTableCell4.ColumnSpan = 2;                                   //SET COLUMNSPAN 2
            newTableCell4.HorizontalAlign = HorizontalAlign.Center;         //SET HORIZONTAL ALIGN CENTER
            newTableCell4.Controls.Add(btnSubmit);                          //ADD BUTTON TO TABLE CELL
            newTableRow2.Cells.Add(newTableCell4);                          //ADD TABLECELL TO TABLE ROW
            newTable.Rows.Add(newTableHeaderRow);                           //ADD TABLEROW TO TABLE
            newTable.Rows.Add(newTableRow);                                 //ADD TABLEROW TO TABLE
            newTable.Rows.Add(newTableRow1);                                //ADD TABLEROW TO TABLE
            newTable.Rows.Add(newTableRow2);                                //ADD TABLEROW TO TABLE
            newTable.HorizontalAlign = HorizontalAlign.Center;              //SET HORIZONTAL ALIGN CENTER FOR TABLE
            newTable.BackColor=Color.Honeydew;                              //SET BACK COLOR FOR TABLE
            newTable.BorderColor = Color.Black;                             //SET BOREDRCOLOR FOR TABLE
            newTable.BorderWidth = 2;                                       //SET BORDER-WIDTH FOR TABLE
            Controls.Add(newTable);                                         //ADD TABLE TO THE PAGE
        }
        #endregion CreateChildControls
        #region btnSubmit_Click
        protected virtual void btnSubmit_Click(object sender, EventArgs e)
        {
            OnClick(EventArgs.Empty);                                           //FIRE THE EVENT 
        }
        #endregion btnSubmit_Click
        #region OnClick
        protected virtual void OnClick(EventArgs e)
        {
            if (Click != null)
                Click(this, e);                                                 //FIRE THE EVENT
        }
        #endregion OnClick
        /*********************************************PROPERTY FOR TEXT ATTRIBUTE OF LABLE ERROR ********************************************/
        public string lblText
        {
            get
            {
                EnsureChildControls();                                          //MAKE SURE THAT LABEL IS EXIXT
                return lblError.Text;                                           //SET THE VALUE OF LABEL.TEXT
            }
            set
            {
                EnsureChildControls();                                          //MAKE SURE THAT LABEL IS EXIXT
                lblError.Text = value;                                          //SET THE VALUE OF LABEL.TEXT
            }
        }
        /*********************************************PROPERTY FOR COLOR ATTRIBUTE OF LABLE ERROR  ********************************************/
        public Color lblColor
        {
            get
            {
                EnsureChildControls();                                          //MAKE SURE THAT LABEL IS EXIXT
                return lblError.ForeColor;                                      //RETURN FORECOLOR
            }
            set
            {
                EnsureChildControls();                                          //MAKE SURE THAT LABEL IS EXIXT
                lblError.ForeColor = value;                                     //SET THE VALUE OF FORECOLOR
            }   
        }
        /*********************************************PROPERTY FOR TEXT ATTRIBUTE OF TEXTBOX USER ID  ********************************************/
        public string txtId_Text
        {
            get
            {
                EnsureChildControls();                                          //MAKE SURE THAT TEXTBOX IS EXIXT
                return txtId.Text;                                              //RETURN TEXTBOX.TEXT
            }
            set
            {
                EnsureChildControls();                                          //MAKE SURE THAT LABEL IS EXIXT
                txtId.Text = value;                                             //SET THE VALUE OF TEXTBOX.TEXT
            }
        }
        /*********************************************PROPERTY FOR TEXT ATTRIBUTE OF TEXTBOX PASSWORD  ********************************************/
        public string txtPass_Text
        {
            get
            {
                EnsureChildControls();                                          //MAKE SURE THAT LABEL IS EXIXT
                return txtPass.Text;                                            //RETURN TEXTBOX.TEXT 
            }
            set
            {
                EnsureChildControls();                                          //MAKE SURE THAT LABEL IS EXIXT
                txtPass.Text = value;                                           //SET THE VALUE OF TEXTBOX.TEXT
            }
        }
    }
}
