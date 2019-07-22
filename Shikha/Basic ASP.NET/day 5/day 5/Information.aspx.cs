using System;

namespace day_5
{
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- Information
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- The Class for DISPLAY INFORMATION.
    //      CREATED DATE    :- 2012/27/08
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class Information : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string strValue;                                               //DECLARATION OF VARIABLE
            Info objInfo1;
            try
            {
                objInfo1 = new Info();                                      //INITIALIZE OBJECT OF INFO CLASS
                objInfo1 = (Info)Session[Constant.strSessionName];            //RETERIVE VALUE FROM SESSION
                lblName.Text = objInfo1.Name;                                 //STORE ON LABEL
                lblEmail.Text = objInfo1.Email;
                lblDob.Text = objInfo1.Dob;
                lblsex.Text = objInfo1.Sex;
                lblPassword.Text = objInfo1.Password;
                lblMerrird.Text = objInfo1.Married;
                //lblLanguage.Text = objInfo1.Language;
                strValue = objInfo1.Language;                               //ASSIGN VALUE INTO STRVALUE
                lblLanguage.Text = strValue;
            }
        
        catch(Exception ex)
        {
            Response.Redirect(Constant.strErrorPage);
        }

       finally
       {
           strValue = null;
           objInfo1 = null;
       }
    }
    }

}
