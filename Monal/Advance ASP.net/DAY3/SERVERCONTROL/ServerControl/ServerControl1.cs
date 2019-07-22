using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerControl
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:ServerControl runat=server></{0}:ServerControl>")]
    public class ServerControl : WebControl, INamingContainer
    {
        private Panel pnl;
        private Label LblMsg, LblUserId, LblUserPwd, LblLogin;     
        private TextBox txtLoginId, txtPwd;    
        private Button BtnSubmit;    
        private Table objTable;
        private TableRow objTableRow;
        private TableCell objTableCell;
        public event EventHandler Click;
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]

        #region Message
        /// <summary>
        /// Name:Message
        /// Description:It is Label and message is display in this label.
        /// Author:Monal Shah
        /// Created Date:2010/11/9
        /// </summary>
        public string Message
        {
            get
            {
                EnsureChildControls();
                return LblMsg.Text;
            }
            set
            {
                EnsureChildControls();
                LblMsg.Text = value;
            }
        }
        #endregion        

        #region txtLoginID
        /// <summary>
        /// Name:txtLoginID
        /// Description:It is Textbox and get set textbox value.
        /// Author:Monal Shah
        /// Created Date:2010/11/9
        /// </summary>
        public string txtLoginID
        {
            get
            {
                EnsureChildControls();
                return txtLoginId.Text;
            }
            set
            {
                EnsureChildControls();
                txtLoginId.Text = value;
            }
        }
        #endregion

        #region txtPassword
        /// <summary>
        /// Name:txtPassword
        /// Description:It is Textbox and get set textbox value.
        /// Author:Monal Shah
        /// Created Date:2010/11/9
        /// </summary>
        public string txtPassword
        {
            get
            {
                EnsureChildControls();
                return txtPwd.Text;
            }
            set
            {
                EnsureChildControls();
                txtPwd.Text = value;
            }
        }
        #endregion        

        #region CreateChildControls
        /// <summary>
        /// Name:CreateChildControls
        /// Description:Create controls and add into page.
        /// Author:Monal Shah
        /// Created Date:2010/11/9
        /// </summary>
        protected override void CreateChildControls()
        {
            try
            {
                pnl = new Panel();
                pnl.GroupingText = "Login Form";
                pnl.CssClass = "panel";

                LblMsg = new Label();
                LblMsg.CssClass = "lblControl";
                LblMsg.Font.Bold = true;
                this.pnl.Controls.Add(LblMsg);

                objTable = new Table();
                objTable.CssClass = "Dynamictable";

                objTableRow = new TableRow();
                objTableCell = new TableCell();
                objTableRow.CssClass = "Bodytd";
                objTableCell.CssClass = "Bodytd";
                LblLogin = new Label();
                LblLogin.ID = this.ID + "_LblLoginID";
                LblLogin.Width = this.Width;
                LblLogin.Text = "Login";
                LblLogin.Font.Bold = true;
                LblLogin.Font.Underline = true;
                LblLogin.CssClass = "lblMsg";

                objTableCell.ColumnSpan = 2;
                objTableCell.Attributes.Add("Align", "Center");
                this.objTableCell.Controls.Add(LblLogin);
                this.objTableRow.Cells.Add(objTableCell);
                this.objTable.Rows.Add(objTableRow);

                objTableRow = new TableRow();
                objTableCell = new TableCell();
                objTableRow.CssClass = "Bodytd";
                objTableCell.CssClass = "Bodytd";
                LblUserId = new Label();
                LblUserId.ID = this.ID + "_LblUserId";
                LblUserId.Text = "USER  ID :";
                LblUserId.Font.Bold = true;
                LblUserId.CssClass = "lblControl";
                this.objTableCell.Controls.Add(LblUserId);
                this.objTableRow.Cells.Add(objTableCell);

                objTableCell = new TableCell();
                objTableCell.CssClass = "Bodytd";
                txtLoginId = new TextBox();
                txtLoginId.ID = this.ID + "_LoginID";
                txtLoginId.Width = Unit.Pixel(140);
                this.objTableCell.Controls.Add(txtLoginId);
                this.objTableRow.Cells.Add(objTableCell);
                this.objTable.Rows.Add(objTableRow);

                objTableRow = new TableRow();
                objTableCell = new TableCell();
                objTableRow.CssClass = "Bodytd";
                objTableCell.CssClass = "Bodytd";
                LblUserPwd = new Label();
                LblUserPwd.ID = this.ID + "_LblUserpwd";
                LblUserPwd.Text = "PASSWORD:";
                LblUserPwd.Font.Bold = true;
                LblUserPwd.CssClass = "lblControl";
                this.objTableCell.Controls.Add(LblUserPwd);
                this.objTableRow.Cells.Add(objTableCell);

                objTableCell = new TableCell();
                objTableCell.CssClass = "Bodytd";
                txtPwd = new TextBox();
                txtPwd.ID = this.ID + "_Pwd";
                txtPwd.TextMode = TextBoxMode.Password;
                txtPwd.Width = Unit.Pixel(140);
                this.objTableCell.Controls.Add(txtPwd);
                this.objTableRow.Cells.Add(objTableCell);
                this.objTable.Rows.Add(objTableRow);

                objTableRow = new TableRow();
                objTableCell = new TableCell();
                objTableRow.CssClass = "Bodytd";
                objTableCell.CssClass = "Bodytd";
                BtnSubmit = new Button();
                BtnSubmit.ID = this.ID + "_btnSubmit";
                BtnSubmit.Text = "Submit";
                BtnSubmit.Width = Unit.Pixel(100);
                BtnSubmit.Click += new EventHandler(BtnSubmit_Click);
                objTableCell.ColumnSpan = 2;
                objTableCell.Attributes.Add("Align", "Center");
                this.objTableCell.Controls.Add(BtnSubmit);
                this.objTableRow.Cells.Add(objTableCell);
                this.objTable.Rows.Add(objTableRow);
                this.pnl.Controls.Add(objTable);
                this.Controls.Add(pnl);
            }           
            finally
            {
                objTableCell = null;
                objTableRow = null;
                objTable = null;
            }
        }
        #endregion

        #region BtnSubmit_Click
        /// <summary>
        /// Name:BtnSubmit_Click
        /// Description:Handle Click Event
        /// Author:Monal Shah
        /// Created Date:2010/11/9
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void BtnSubmit_Click(object sender, EventArgs e)
        {
            Click(this, e);
        }
        #endregion        
    }
}
