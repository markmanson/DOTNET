using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DAY4ServerControl
{
    [DefaultProperty("CheckUncheckRadioList")]
    [ToolboxData("<{0}:RadioServerControl runat=server></{0}:RadioServerControl>")]
    public class RadioServerControl : WebControl, INamingContainer
    {
        private Label LblRatingMsg;
        private Button BtnCastVote;
        private RadioButtonList Rbtnlst;
        private ListItem Lst;
        public event EventHandler Click;
        public event EventHandler SelectedIndexChanged;

        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        #region CheckUncheckRadioList
        /// <summary>
        /// Name:CheckUncheckRadioList
        /// Description:get set the selectedindex valu of radiobutton.
        /// Author:Monal Shah
        /// Created Date:2010/11/10
        /// </summary>
        public int CheckUncheckRadioList
        {
            get { return Rbtnlst.SelectedIndex; }
            set { Rbtnlst.SelectedIndex = value; }
        }
        #endregion
        #region CreateChildControls
        /// <summary>
        /// Name:CreateChildControls
        /// Description:Create controls and add into page.
        /// Author:Monal Shah
        /// Created Date:2010/11/10
        /// </summary>
        protected override void CreateChildControls()
        {
            LblRatingMsg = new Label();
            LblRatingMsg.CssClass = "lblControl";
            LblRatingMsg.Text = "Rate This Article(5 Is Highest)";
            LblRatingMsg.Font.Bold = true;
            this.Controls.Add(LblRatingMsg);

            Rbtnlst = new RadioButtonList();
            Rbtnlst.AutoPostBack = true;
            Rbtnlst.RepeatDirection = RepeatDirection.Horizontal;
            Rbtnlst.SelectedIndexChanged += new EventHandler(Rbtnlst_SelectedIndexChanged);
            for (int intI = 0; intI < 5; intI++)
            {
                Lst = new ListItem(Convert.ToString(intI + 1), Convert.ToString(intI + 1));
                Rbtnlst.Items.Add(Lst);
            }
            this.Controls.Add(Rbtnlst);

            BtnCastVote = new Button();
            BtnCastVote.ID = this.ID + "_btnCastVote";
            BtnCastVote.Text = "Cast Your Vote";
            BtnCastVote.Width = Unit.Pixel(100);
            BtnCastVote.Click += new EventHandler(BtnCastVote_Click);
            this.Controls.Add(BtnCastVote);
        }
        #endregion
        #region Rbtnlst_SelectedIndexChanged
        /// <summary>
        /// Name:Rbtnlst_SelectedIndexChanged
        /// Description:call event.
        /// Author:Monal Shah
        /// Created Date:2010/11/10
        /// </summary>
        void Rbtnlst_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIndexChanged(this, e);
        }
        #endregion
        #region BtnCastVote_Click
        /// <summary>
        /// Name:BtnCastVote_Click
        /// Description:call event.
        /// Author:Monal Shah
        /// Created Date:2010/11/10
        /// </summary>
        void BtnCastVote_Click(object sender, EventArgs e)
        {
            Click(this, e);
        }
        #endregion
        #region RenderContents
        /// <summary>
        /// Name:RenderContents
        /// Description:Render all Controls
        /// Author:Monal Shah
        /// Created Date:2010/11/10
        /// <param name="sender"></param>
        /// </summary>
        /// <param name="output"></param>
        protected override void RenderContents(HtmlTextWriter output)
        {
            output.RenderBeginTag(HtmlTextWriterTag.Table);

            output.RenderBeginTag(HtmlTextWriterTag.Tr);
            output.RenderBeginTag(HtmlTextWriterTag.Td);
            output.RenderBeginTag(HtmlTextWriterTag.Center);
            LblRatingMsg.RenderControl(output);
            output.RenderEndTag();    // td           
            output.RenderEndTag(); //tr

            output.RenderBeginTag(HtmlTextWriterTag.Tr);
            output.RenderBeginTag(HtmlTextWriterTag.Td);
            Rbtnlst.RenderControl(output);
            output.RenderEndTag();    // td

            output.RenderBeginTag(HtmlTextWriterTag.Td);
            BtnCastVote.RenderControl(output);
            output.RenderEndTag();    // td
            output.RenderEndTag(); //tr

            output.RenderEndTag();    // table
        }
        #endregion

    }
}
