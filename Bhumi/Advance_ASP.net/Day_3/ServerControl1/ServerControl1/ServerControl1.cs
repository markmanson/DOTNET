using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
/// <summary>
/// NamespaceName:ServerControl1
/// Description:Composite Custom Control using Server Control
/// Author: Bhumi
/// Created On:7/7/2015
/// </summary>
namespace ServerControl1
{
    [DefaultEvent("Submit")]
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:LoginCotrol runat=server></{0}:LoginCotrol>")]
    public class LoginCotrol : CompositeControl
    {
        protected Table TblLogin = new Table();
        TableRow tRow;
        TableCell tCell;
        public Label LblHeader = new Label();
        protected Label LblUserName = new Label();
        protected Label LblPassword = new Label();

        public TextBox TxtUserName = new TextBox();
        protected TextBox TxtPassword = new TextBox();
        
        protected Button BtnSubmit = new Button();

        private RequiredFieldValidator UserNameValidator;
        private RequiredFieldValidator PasswordValidator;

        private static readonly object EventSubmitKey =
            new object();

        [
        Bindable(true),
        Category("Appearance"),
        DefaultValue("")
        ]
        #region Error Messages for Validator
        public string NameErrorMessage
        {
            get
            {
                EnsureChildControls();
                return UserNameValidator.ErrorMessage;
            }
            set
            {
                EnsureChildControls();
                UserNameValidator.ErrorMessage = value;
                UserNameValidator.ToolTip = value;
            }
        }
        #endregion
        [
        Bindable(true),
        Category("Appearance"),
        DefaultValue("")
        ]
        #region Error Messages for Validator
        public string PswrdErrorMessage
        {
            get
            {
                EnsureChildControls();
                return PasswordValidator.ErrorMessage;
            }
            set
            {
                EnsureChildControls();
                PasswordValidator.ErrorMessage = value;
                PasswordValidator.ToolTip = value;
            }
        }
        #endregion
        // The Submit event.
        [
        Category("Action"),
        Description("Raised when the user clicks the button.")
        ]
        #region EventHandler
        public event EventHandler Submit
        {
            add
            {
                Events.AddHandler(EventSubmitKey, value);
            }
            remove
            {
                Events.RemoveHandler(EventSubmitKey, value);
            }
        }
        #endregion
        #region Create Event To Perform Handler
        // The method that raises the Submit event. 
        protected virtual void OnSubmit(EventArgs e)
        {
            EventHandler SubmitHandler =
                (EventHandler)Events[EventSubmitKey];
            if (SubmitHandler != null)
            {
                SubmitHandler(this, e);
            }
        }
        #endregion
        #region Call the Onsubmit Event 
        // Handles the Click event of the Button and raises 
        // the Submit event. 
        private void _button_Click(object source, EventArgs e)
        {
            OnSubmit(EventArgs.Empty);
        }
        #endregion
        #region RecreateChildControls Method
        protected override void RecreateChildControls()
        {
            EnsureChildControls();
        }
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public string UserNameText
        {
            get
            {
                EnsureChildControls();
                return TxtUserName.Text;
            }

            set
            {
                EnsureChildControls();
                TxtUserName.Text = value;
            }
        }
        public string PassWordText
        {
            get
            {
                EnsureChildControls();
                return TxtPassword.Text;
            }

            set
            {
                EnsureChildControls();
                TxtPassword.Text = value;
            }
        }
        public string LblHeaderText
        {
            get
            {
                EnsureChildControls();
                return LblHeader.Text;
            }

            set
            {
                EnsureChildControls();
                LblHeader.Text = value;
            }
        }
        #endregion
        #region CreateChildControls Method
        protected override void CreateChildControls()
        {
            base.CreateChildControls();

            tRow = new TableRow();
            TblLogin.Rows.Add(tRow);
            tCell = new TableCell();
            tRow.Cells.Add(tCell);//ADD Cell
            tCell = new TableCell();
            tRow.Cells.Add(tCell);//ADD Cell                                    
            tCell.Controls.Add(LblHeader);

            tRow = new TableRow();
            TblLogin.Rows.Add(tRow);
            tCell = new TableCell();
            tRow.Cells.Add(tCell);//ADD Cell

            tRow = new TableRow();
            TblLogin.Rows.Add(tRow);
            tCell = new TableCell();
            tRow.Cells.Add(tCell);//ADD Cell
            LblUserName.Text = "UserName:";
            tCell.Controls.Add(LblUserName);
            tCell = new TableCell();
            tRow.Cells.Add(tCell);//ADD Cell
            TxtUserName.ID = "Txt1";           
            tCell.Controls.Add(TxtUserName);            
            UserNameValidator = new RequiredFieldValidator();
            UserNameValidator.ID = "RfvUseName";
            UserNameValidator.ControlToValidate = TxtUserName.ID;
            UserNameValidator.Text = " Enter UserName";
            UserNameValidator.ForeColor = Color.Red;
            UserNameValidator.Display = ValidatorDisplay.Static;
            tCell.Controls.Add(UserNameValidator);

            tRow = new TableRow();
            TblLogin.Rows.Add(tRow);
            tCell = new TableCell();
            tRow.Cells.Add(tCell);//ADD Cell
            LblPassword.Text = "Password:";
            tCell.Controls.Add(LblPassword);
            tCell = new TableCell();
            tRow.Cells.Add(tCell);//ADD Cell
            TxtPassword.ID = "Txt2";
            TxtPassword.TextMode = TextBoxMode.Password;
            tCell.Controls.Add(TxtPassword);
            tRow.Cells.Add(tCell);//ADD Cell
            PasswordValidator = new RequiredFieldValidator();
            PasswordValidator.ID = "RfvPassword";
            PasswordValidator.ControlToValidate = TxtPassword.ID;
            PasswordValidator.Text = " Enter Password";
            PasswordValidator.ForeColor = Color.Red;
            PasswordValidator.Display = ValidatorDisplay.Static;
            tCell.Controls.Add(PasswordValidator);

            tRow = new TableRow();
            TblLogin.Rows.Add(tRow);
            tRow = new TableRow();
            TblLogin.Rows.Add(tRow);
            tRow = new TableRow();
            TblLogin.Rows.Add(tRow);
            tRow = new TableRow();
            TblLogin.Rows.Add(tRow);
            tRow = new TableRow();
            TblLogin.Rows.Add(tRow);
            tCell = new TableCell();
            tRow.Cells.Add(tCell);//ADD Cell
            tCell = new TableCell();
            tRow.Cells.Add(tCell);//ADD Cell
            BtnSubmit.ID = "BtnSubmt";
            BtnSubmit.Text = "Submit";
            BtnSubmit.Width = 100;
            BtnSubmit.Click
                += new EventHandler(_button_Click);
            BtnSubmit.BackColor = Color.Beige;
            tCell.Controls.Add(BtnSubmit);        
            this.Controls.Add(TblLogin);
        }
        #endregion
    }
}
