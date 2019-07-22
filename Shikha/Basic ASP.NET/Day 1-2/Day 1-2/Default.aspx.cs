using System;

namespace Day_1_2
{
    #region _Default
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- _Default
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- The Class for count the visitors, and entry in text box.
    //      CREATED DATE    :- 2012/20/06
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class _Default : System.Web.UI.Page
    {
        int intCounter;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                 LblCounter.Text = Application["OnlineCounter"].ToString();
            }

        }
        
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Class1 objText;                                                   //DECLARATION OF OBJECT OF CLASS
            //string value; 
            try
            {
                objText = new Class1();                                        //INITIALIZATION OF CLASS1
                
                if (txtTextBox1.Text.ToString()!=Constant.strBlank)             //CHECK CONDITION FOR TEXTBOX IF EMPTY COUNTER NOT WORK ON BUTTON CLICK
                {
                    intCounter = Convert.ToInt16(Session[Constant.strValue]);  //INITIALIZE INTCOUNTER
                    intCounter++;                                              //INCREMENT IN INTCOUNTER
                    LblCounter1.Text = intCounter.ToString();                  //STORE VALUE IN LBLTEXT
                    Session[Constant.strValue] = intCounter;                   //STORE VALUE IN SESSION
                    //value = TextBox1.Text;
                    objText.TextValue = txtTextBox1.Text;                         //STORE VALUE IN TEXTBOX USING PROPERTY
                    //TextBox2.Text = value;
                    txtTextBox2.Text = objText.TextValue;                         //STORE VALUE FROM 1 TEXTBOX TO OTHER
                    txtTextBox1.Text = string.Empty;                              //EMPTY TEXTBOX1
                }
            }
            catch (Exception)
            {
                Response.Redirect(Constant.strErrorPage);                      //REDIRECT TO ERROR PAGE
            }
            finally
            {
                objText = null;                                                //REALLOCATE THE MEMORY
              
            }
         }
    }
    #endregion _Default
}
