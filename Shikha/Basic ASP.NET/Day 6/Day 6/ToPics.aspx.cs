using System;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day_6
{
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- ToPics
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- The Class for DISPLAY INFORMATION.
    //      CREATED DATE    :- 2012/29/08
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class ToPics : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {   //DECLARATION OF VARIABLE
            LinkButton link;        
            string strValue;
            string[] VExist;
            try
            {   //RETERIEVE VALUE OF STRING ITEMSELECTED USING REQUEST OBJECT INTO OTHER STRING VARIABLE
                strValue = Request.QueryString[Constant.stritemSelected];
                if (strValue != null)
                {
                    VExist = strValue.Split(',');                            //SPLIT VALUE OF STRING BY COMMA AND STORE IN ARRAY STRING
                    for (int i = 0; i < VExist.Length; i++)                  //LOOPING FOR STRING ARRAY ITEM
                    {
                        pnlTopic.Controls.Add(new LiteralControl("<br />"));
                        pnlTopic.Controls.Add(new LiteralControl(Constant.strdiv));  //ADD LITERAL CONTROL IN PANEL
                        link = new LinkButton();                                    //INITIALIZE LINK BUTTON
                        link.ID = Constant.strlnk + i;                              //ID OF LINKBUTTON
                        if (i % 2 == 0)                                             //CONDITION FOR ASSIGN VALUE OF STRING ARRAY INTO LINK
                        {
                            link.Text = VExist[i];                                //ASSIGN VALUE OF ITH POSITION IN LINK TEXT
                            link.PostBackUrl = VExist[i + 1];                    //ASSIGN VALUE OF ITH POSITION IN LINK.POSTBACKURL
                        }
                        pnlTopic.Controls.Add(link);                              //ADD LINK IN TO PANEL
                        pnlTopic.Controls.Add(new LiteralControl(Constant.strdiv1));
                        pnlTopic.Controls.Add(new LiteralControl("<br />"));
                    }
                }
           }
            catch (Exception ex)
            {
             Response.Redirect(Constant.strErrorPage);             //REDIRECT TO ERROR PAGE
            }
            finally
            {
                strValue = null;                                   //REALLOCATE MEMORY
                link = null;
            }
        }
    }
}
