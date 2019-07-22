using System;
using System.ComponentModel;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace ServerControlRateArticle
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:ServerControl1 runat=server></{0}:ServerControl1>")]
    public class ServerControlRateArticle : WebControl,INamingContainer
    {
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]

        public RadioButtonList RblRate;                                               //DECLARATION OF THE OBJECT OF RADIOBUTTONLIST
        Button btnVote;                                                         //DECLARATION OF THE OBJECT OF BUTTON
        public Label lblRateArt;                                        //DECLARATION OF LABEL
        Table objTable;                                                         //DECLARATION OF THE OBJECT OF TABLE
        TableRow tr1, tr2, tr3;                                                    //DECLARATION OF THE OBJECT OF TABLEROW
        TableCell tc, tc1, tc2, tc3;                                                    //DECLARATION OF THE OBJECT OF TABLECELL
        public event EventHandler Click;                                        //DECLARATION OF EVENT CLICK
        public event EventHandler SelectedIndexChanged;                         //DECLARATION OF EVENT SELECTED INDEX CHANGED
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
                objTable = new Table();                                                 //INITIALIZATION OF THE OBJECT OF TABLE
                objTable.Width = Unit.Pixel(400);
                objTable.Height = Unit.Pixel(50);
                tr1= new TableRow();                                           //INITIALIZATION OF THE OBJECT OF TABLEROW
                tr2 = new TableRow();                                          
                tr3 = new TableRow();                                          
                tc = new TableCell();                                        //INITIALIZATION OF THE OBJECT OF TABLECELL
                tc1 = new TableCell();                                       
                tc2= new TableCell();                                        
                tc3= new TableCell();                                       
                lblRateArt = new Label();
                lblRateArt.ForeColor = System.Drawing.Color.Black;
              //lblRateArt.Font = new FontSize(FontUnit.Small);
                RblRate = new RadioButtonList();                                       //INITIALIZATION OF THE OBJECT OF RADIOBUTTONLIST
                btnVote = new Button();                                                 //INITIALIZATION OF THE OBJECT OF BUTTON
                RblRate.AutoPostBack = true;                                           //SET AUTO POST BACK TRUE
                RblRate.RepeatDirection = RepeatDirection.Horizontal;                  //SET REPEAT DIRECTION HORIZONTAL
                RblRate.SelectedIndexChanged += new EventHandler(RblRate_SelectedIndexChanged);   //GENERATE THE EVENT SELECTED INDEX CHANGED
                for (int i = 1; i <= 5; i++)
                {
                    RblRate.Items.Add(new ListItem(i.ToString(), i.ToString()));                  //ADD THE ITEMS INTO RADIO BUTTON LIST
                }   
                btnVote.Text = "Cast your vote";                                       //SET THE BUTTON TEXT
                btnVote.Click += new EventHandler(btnVote_Click);                       //GENERATE THE CLICK EVENT FOR BUTTON
                tc2.Controls.Add(lblRateArt);
                tr2.Controls.Add(tc2);
                tc.Controls.Add(RblRate);                                                //ADD RADIOBUTTON LIST TO TABLE CELL
                tc1.Controls.Add(btnVote);                                               //ADD BUTTON TO TABLE CELL
                tr1.Cells.Add(tc);                                                   //ADD TABLE CELL TO TABLE ROW
                tr1.Cells.Add(tc1);                                            //ADD TABLE CELL TO TABLE ROW
                objTable.Rows.Add(tr2);                                                  //ADD TABLE ROW TO TABLE 
                objTable.Rows.Add(tr3);                                        //ADD TABLE ROW TO TABLE 
                objTable.Rows.Add(tr1);                                                   //ADD TABLE ROW TO TABLE
                objTable.HorizontalAlign = HorizontalAlign.Center;                      //SET HORIZONTAL ALLIGN CENTER
                objTable.BackColor = System.Drawing.Color.Maroon;                     
                Controls.Add(objTable);                                                 //ADD TABLE TO THE PAGE
            }
            finally
            {                                                    //REALLOCATE MEMORY
                btnVote = null;                                                       
                objTable = null;                                                        
                tr1 = null;                                                    
                tr2 = null;                                                    
                tc2 = null;
                tr3= null;                                                   
                tc = null;                                                   
                tc1 = null;                                                  
                tc3 = null;                                                   
            }
        }
        //protected override void RenderContents(HtmlTextWriter output)
        //{
        //    output.Write(Text);
        //}

        protected virtual void RblRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectedIndexChanged != null)                                           //CHECK CONDITION FOR CLICK EVENT IS NOT NULL
                SelectedIndexChanged(this, e);                                          //CALL THE CLICK EVENT
        }

        protected virtual void btnVote_Click(object sender, EventArgs e)
        {
            if (Click != null)                                                  //CHECK CONDITION FOR CLICK EVENT IS NOT NULL
                Click(this, e);                                                  //CALL THE CLICK EVENT
        }

    }
}
