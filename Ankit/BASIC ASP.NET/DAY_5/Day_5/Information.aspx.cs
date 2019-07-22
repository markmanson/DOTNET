using System;

namespace Day_5
{
    #region Information
    /*************************************************************************************************************
    * CLASS NAME                                   :::                     INFORMATION                
    * AUTHOR NAME                                  :::                     ANKIT SHARMA
    * DATE                                         :::                     13/08/2012
    * DESCRIPTION                                  :::                     TO SHOW THE DETAILS OF USER ENTERED IN PAGE DEFAULT
    * **********************************************************************************************************/
    public partial class Information : System.Web.UI.Page
    {
        #region page_Load
        /*************************************************************************************************************
            * FUNCTION NAME                                :::                     PAGE_LOAD                
            * AUTHOR NAME                                  :::                     ANKIT SHARMA
            * DATE                                         :::                     13/08/2012
            * DESCRIPTION                                  :::                     PAGE_LOAD EVENT 
            * **********************************************************************************************************/
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Information"] != null)                                 //CHECK IF SESSION IS NULL OR NOT
            {
                Common objcommon ;                                              //DECLARATION FOR THE OBJECT OF CLASS COMMON
                try
                {
                    objcommon = new Common();                                  //INITIALIZATION OF THE OBJECT OF CLASS COMMON
                    objcommon = (Common)Session["Information"];                //ASSIGN THE VALUE OF SESSION TO OBJECT OF CLASS COMMON AFTER PARSING
                    lblNme.Text = objcommon.Name;                              //ASSIGN THE NAME TO TEXTBOX
                    lblSx.Text = objcommon.Sex;                                //ASSIGN THE SEX TO TEXTBOX
                    lblMail.Text = objcommon.Email;                            //ASSIGN THE EMAIL TO TEXTBOX
                    lblDB.Text = objcommon.DOB;                                //ASSIGN THE DOB TO TEXTBOX
                    lblPsWrd.Text=objcommon.Password;                          //ASSIGN THE PASSWORD TO TEXTBOX
                    lblFx.Text = objcommon.Fax;                                //ASSIGN THE FAX TO TEXTBOX
                    lblMrrid.Text=objcommon.Married;                           //ASSIGN THE MARRIED TO TEXTBOX
                    lblLng.Text=objcommon.Lang;                                //ASSIGN THE LANGUAGE TO TEXTBOX
                }
                catch (Exception)                                              //CHECK IF ANY EXCEPTION IS OCCURRED
                {
                    Response.Redirect("Error.aspx");                           //REDIRECT TO ERROR.ASPX
                }
                finally
                {
                    objcommon = null;                                          //ASSIGN NULL TO OBJECT OF CLASS COMMON
                }

            }
        }
        #endregion Page_Load
    }
    #endregion Information
}
