using System;

namespace Day_5
{
    #region _Default
    /*************************************************************************************************************
    * CLASS NAME                                   :::                     _Default                
    * AUTHOR NAME                                  :::                     ANKIT SHARMA
    * DATE                                         :::                     13/08/2012
    * DESCRIPTION                                  :::                     TO VALIDATE THE LOGIN PAGE 
    * **********************************************************************************************************/
    public partial class _Default : System.Web.UI.Page
    {
        #region Page_Load
    /*************************************************************************************************************
    * FUNCTION NAME                                :::                     PAGE_LOAD                
    * AUTHOR NAME                                  :::                     ANKIT SHARMA
    * DATE                                         :::                     13/08/2012
    * DESCRIPTION                                  :::                     FUNCTION PAGE LOAD 
    * **********************************************************************************************************/
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txtName.Focus();                                                                //SET FOCUS TO NAME                
                string strCurrectDate = (string)DateTime.Now.ToShortDateString();               //ASSIGN TODAY'S DATE TO A STRING
                if (txtDOB.Text != null)                                                        //IF TXTDOB.TEXT CONTAINS SOME VALUE
                {
                    CmpvDOB.ValueToCompare = strCurrectDate.ToString();                         //COMPARISON OF DATES
                }
            }
            
        }
        #endregion Page_Load
        #region btnSubmit_Click
        /*************************************************************************************************************
    * FUNCTION NAME                                :::                     BTNSUBMIT_CLICK                
    * AUTHOR NAME                                  :::                     ANKIT SHARMA
    * DATE                                         :::                     13/08/2012
    * DESCRIPTION                                  :::                     FUNCTION BTNSUBMIT_CLICK
    * **********************************************************************************************************/
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Common objCommon;                                                   //DECLARATION OF OBJECT OF CLASS COMMON
            try
            {               
                objCommon = new Common();                                       //INITIALIZATION OF OBJECT OF CLASS COMMON
                objCommon.Name = txtName.Text;                                  //ASSIGN NAME TO PROPERTY
                objCommon.Sex = txtSex.Text;                                    //ASSIGN SEX TO PROPERTY
                objCommon.Email = txtEmail.Text;                                //ASSIGN EMAIL TO PROPERTY
                objCommon.DOB = txtDOB.Text;                                    //ASSIGN DATE OF BIRTH TO PROPERTY
                objCommon.Password = txtPass.Text;                              //ASSIGN PASSWORD TO PROPERTY
                objCommon.Fax = txtFax.Text;                                    //ASSIGN FAX TO PROPERTY
                objCommon.Married = ddlMarried.SelectedValue;                   //ASSIGN SELECTED VALUE OF MARRIED TO PROPERTY
                for (int i = 0; i < 6; i++)
                {
                    objCommon.Lang = lstLang.SelectedValue;                     //ASSIGN SELECTED VALUES OF LANGUAGE TO PROPERTY
                }
                Session["Information"] = objCommon;                             //ASSIGN OBJECT TO SESSION
                Response.Redirect("Information.aspx",false);                    //REDIRECT TO INFORMATION.ASPX
            }
            catch (Exception)                                                   //IF EXCEPTION OCCURRED
            {
                Response.Redirect("Error.aspx");                                //REDIRECT TO ERROR.ASPX
            }
            finally
            {
                objCommon = null;                                               //ASSIGN NULL TO THE OBJECT OF CLASS COMMON
            }
        }
        #endregion btnSubmit_Click 
    }
    #endregion _Default
}
