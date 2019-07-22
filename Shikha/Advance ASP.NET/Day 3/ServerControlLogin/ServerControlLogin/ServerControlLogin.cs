using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerControlLogin
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:ServerControl1 runat=server></{0}:ServerControl1>")]
    public class ServerControlLogin : WebControl,INamingContainer
    {
        private Panel pnl;
        public Label LblMsg, lblUserName, lblPassword, lblLogin, LblError;
        public TextBox txtUserName, txtPassword, txtName;
        private RequiredFieldValidator validator2;
        private RequiredFieldValidator validator3;
        public Button btnSubmit;
        private Table objTable;
        private TableRow frow, srow, trow, hrow;
        private TableCell hfcell, ffcell, fscell, sfcell, sscell, tfcell, tscell;
        public event EventHandler Submit;
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
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
        protected override void CreateChildControls()
        {
            try
            {
                pnl = new Panel();
                pnl.Width = Unit.Percentage(60);
                objTable = new Table();
                objTable.Width = Unit.Pixel(300);
                objTable.Height = Unit.Pixel(200);
                objTable.BorderColor = System.Drawing.Color.Black;     //GIVING BORDER COLOR TO TABLE
                objTable.BackColor = System.Drawing.Color.Gray;
                objTable.BorderWidth = 2;                                  //SET THE BORDER-WIDTH OF TABLE
                objTable.HorizontalAlign = HorizontalAlign.Center;
                txtUserName = new TextBox();
                txtUserName.ID = "txtfield";
                txtPassword = new TextBox();
                txtPassword.ID = "txtPass";
                txtName = new TextBox();
                validator2 = new RequiredFieldValidator();
                validator3 = new RequiredFieldValidator();
                lblUserName = new Label();
                lblPassword = new Label();
                lblLogin = new Label();
                LblMsg = new Label();
                LblMsg.BackColor = System.Drawing.Color.Khaki;
                LblMsg.ForeColor = System.Drawing.Color.Blue;
                LblError = new Label();
                btnSubmit = new Button();
                btnSubmit.Text = "Submit";
                btnSubmit.Click += new EventHandler(btnSubmit_Click);
                lblUserName.Text = "User Name";
                lblPassword.Text = "Password";
                lblLogin.Text = "Login Here";
                lblLogin.Font.Bold = true;
                lblLogin.Font.Name = "Verdana"; ;
                lblLogin.Font.Size = 10;

                hrow = new TableRow();
                frow = new TableRow();
                srow = new TableRow();
                trow = new TableRow();

                hfcell = new TableCell();
                ffcell = new TableCell();
                fscell = new TableCell();
                sfcell = new TableCell();
                sscell = new TableCell();
                tfcell = new TableCell();
                tscell = new TableCell();

                hfcell.ColumnSpan = 2;

                hfcell.Controls.Add(lblLogin);
                ffcell.Controls.Add(lblUserName);
                fscell.Controls.Add(txtUserName);

                sfcell.Controls.Add(lblPassword);
                sscell.Controls.Add(txtPassword);

                tfcell.Controls.Add(btnSubmit);
                LblError.Visible = false;
                tscell.Controls.Add(LblError);

                hrow.Controls.Add(hfcell);
                frow.Controls.Add(ffcell);
                frow.Controls.Add(fscell);

                srow.Controls.Add(sfcell);
                srow.Controls.Add(sscell);

                trow.Controls.Add(tfcell);
                trow.Controls.Add(tscell);
                objTable.Controls.Add(hrow);
                objTable.Controls.Add(frow);
                objTable.Controls.Add(srow);
                objTable.Controls.Add(trow);
                LblMsg.Visible = false;
                pnl.Controls.Add(LblMsg);
                this.Controls.Add(pnl);
                validator2.ControlToValidate = txtUserName.ID + "";
                validator2.ID = "validator2";
                validator2.Text = "* 1.)Please enter UserName ";
                validator2.ErrorMessage = "* 1.)Please enter UserName ";
                validator2.EnableClientScript = false;
                pnl.Controls.Add(validator2);
                validator3.ControlToValidate = txtPassword.ID + "";
                validator3.ID = "validator3";
                validator3.Text = "* 2.)Please enter Password";
                validator3.ErrorMessage = "* 2.)Please enter Password";
                validator3.EnableClientScript = false;
                pnl.Controls.Add(validator3);
                pnl.Controls.Add(objTable);
                this.Controls.Add(pnl);
            }
          
            finally
            {
                objTable=null;
                frow = null; srow = null; trow = null; hrow = null;
                hfcell = null; ffcell = null; fscell = null;

            }
        }
        //protected override void RenderContents(HtmlTextWriter output)
        //{
        //    output.Write(Text);
        //}
        protected virtual void btnSubmit_Click(object sender, EventArgs e)
        {

            Submit(this, e);

        }
    }
}
