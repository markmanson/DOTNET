using System;
using System.Collections;
using System.Text;

using System.Web.UI.WebControls;
namespace day_5
{
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- _Default
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- The Class for DISPLAY INFORMATION.
    //      CREATED DATE    :- 2012/27/08
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
             // string dateString = DateTime.Today.ToString();
                RangeValidator1.MinimumValue = new DateTime(1600, 01, 01).ToString(Constant.strdate);
                RangeValidator1.MaximumValue = DateTime.Now.ToString(Constant.strdate);
      }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            StringBuilder txtValue1;                   //DECLARATION OF VARIABLE
            ArrayList ListArray;
            Info objInfo;
            try
            {
                
                txtValue1 = new StringBuilder();          //INITIALIZATION STRING AND ARRAYLIST
                ListArray = new ArrayList();
                for (int i = 0; i <= lstLanguage.Items.Count - 1; i++)         //LOOPING FOR LISTBOX ITEMS
                {
                    if (lstLanguage.Items[i].Selected)                       //CHECK CONDITION FOR SELECTED ITEM
                    {
                        // add to arraylist
                        ListArray.Add(lstLanguage.Items[i].Value);             //ADD SELECTED ITEN INTO ARRAYLIST
                    }
                }
             foreach (object obj in ListArray)                              // now add each item in the ArrayList to the string builder
                {
                    txtValue1.Append(obj.ToString());
                    txtValue1.Append(",");
                }
                txtValue1 = txtValue1.Remove(txtValue1.ToString().LastIndexOf(","), 1);         //REMOVE COMMA FROM STRING AT LAST INDEX
                objInfo = new Info();                                                         //INITIALIZE OBJECT OF INFO CLASS
                objInfo.Name = txtName.Text;                                                 // NAME FROM INFO CLASS
                objInfo.Sex = txtSex.Text;                                                    // SEX FROM INFO CLASS
                objInfo.Dob = txtDob.Text;                                                   // DOB FROM INFO CLASS
                objInfo.Password = txtPassword.Text;                                        //PASSWORD FROM INFO CLASS
                objInfo.Email = txtEmail.Text;                                             // EMAIL FROM INFO CLASS
                objInfo.FaxNumber = txtFaxNumber.Text;                                     //FAXNUMBER FROM INFO CLASS  
                objInfo.Married = ddlMarried.SelectedValue.ToString();                     // SELECTED VALUE FROM INFO CLASS
                objInfo.Language = txtValue1.ToString();                                  
                Session[Constant.strSessionName] = objInfo;                              //STORE ALL INFORMATION IN SESSION
                Response.Redirect(Constant.strInformationPage,false);                            //REDIRECT TO INFORMATION.ASPX PAGE
            }

          catch (Exception ex)
            {                                                                          //REDIRECT TO ERROR PAGE
                Response.Redirect(Constant.strErrorPage);
            }
            finally
            {
                txtValue1 = null;                                                 //REALLOCATE MEMORY
                ListArray = null;
            }
        }
    }
}
