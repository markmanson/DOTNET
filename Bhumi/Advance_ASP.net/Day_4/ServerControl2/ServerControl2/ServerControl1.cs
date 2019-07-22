using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
/// <summary>
/// NamespaceName:ServerControl2
/// Description: Asp with Composite Rendered Custom Control
/// Author: Bhumi
/// Created On:8/7/2015
/// </summary>
namespace ServerControl2
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:RenderControl runat=server></{0}:RenderControl>")]
    public class RenderControl : CompositeControl
    {
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]

        private Label LblHeader;
        private Label LblRd1;
        private Label LblRd2;
        private Label LblRd3;
        private Label LblRd4;
        private Label LblRd5;
        protected Button BtnSubmit;
        private RadioButton RdBtn1;
        private RadioButton RdBtn2;
        private RadioButton RdBtn3;
        private RadioButton RdBtn4;
        private RadioButton RdBtn5;
        private static readonly object EventSubmitKey =
            new object();
        private static readonly object EventCheckedKey =
            new object();
        #region Event Handler For RadioButtons
        public event EventHandler CheckedChanged
        {
            add
            {
                Events.AddHandler(EventCheckedKey, value);
            } 
            remove
            {
                Events.RemoveHandler(EventCheckedKey, value);
            }           
        }
        #endregion
        #region Create Event To Perform Handler
        // The method that raises the CheckedChange event. 
        protected virtual void OnCheckedChange(EventArgs e)
        {
            EventHandler CheckedHandler =
                (EventHandler)Events[EventCheckedKey];
            if (CheckedHandler != null)
            {
                CheckedHandler(this, e);
            }
        }
        #endregion
        #region Call the OnCheckedChange Event
        // Handles the CheckedChange event of the RadioButton and raises 
        // the OnCheckedChange event. 
        private void Radio_Click(object source, EventArgs e)
        {
            OnCheckedChange(EventArgs.Empty);
        }
        #endregion        
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
        #region Create All Controls
        protected override void CreateChildControls()
        {
            base.CreateChildControls();

            LblHeader = new Label();
            LblHeader.Text = "Rate This Article (5 is Highest) :<br><br>";            
            RdBtn1 = new RadioButton();
            RdBtn1.GroupName = "Gp1";
            RdBtn1.AutoPostBack = true;
            RdBtn1.CheckedChanged
                += new EventHandler(Radio_Click);
            LblRd1 = new Label();
            LblRd1.Text = "1";
            RdBtn2 = new RadioButton();
            RdBtn2.GroupName = "Gp1";
            RdBtn2.AutoPostBack = true;
            RdBtn2.CheckedChanged
                += new EventHandler(Radio_Click);
            LblRd2 = new Label();
            LblRd2.Text = "2";
            RdBtn3 = new RadioButton();
            RdBtn3.GroupName = "Gp1";
            RdBtn3.AutoPostBack = true;
            RdBtn3.CheckedChanged
                += new EventHandler(Radio_Click);
            LblRd3 = new Label();
            LblRd3.Text = "3";
            RdBtn4 = new RadioButton();
            RdBtn4.GroupName = "Gp1";
            RdBtn4.AutoPostBack = true;
            RdBtn4.CheckedChanged
                += new EventHandler(Radio_Click);
            LblRd4 = new Label();
            LblRd4.Text = "4";
            RdBtn5 = new RadioButton();
            RdBtn5.GroupName = "Gp1";
            RdBtn5.AutoPostBack = true;
            RdBtn5.CheckedChanged
                += new EventHandler(Radio_Click);
            LblRd5 = new Label();
            LblRd5.Text = "5    ";
            BtnSubmit = new Button();
            BtnSubmit.ID = "BtnSubmt";
            BtnSubmit.Text = "Cast Your Vote";
            BtnSubmit.Width = 150;
            
            BtnSubmit.Click
                += new EventHandler(_button_Click);
            BtnSubmit.BackColor = Color.Beige;
            
            Controls.Add(LblHeader);
            Controls.Add(RdBtn1);
            Controls.Add(LblRd1);
            Controls.Add(RdBtn2);
            Controls.Add(LblRd2);
            Controls.Add(RdBtn3);
            Controls.Add(LblRd3);
            Controls.Add(RdBtn4);
            Controls.Add(LblRd4);
            Controls.Add(RdBtn5);
            Controls.Add(LblRd5);
            Controls.Add(BtnSubmit);

        }
        #endregion
    }
}
