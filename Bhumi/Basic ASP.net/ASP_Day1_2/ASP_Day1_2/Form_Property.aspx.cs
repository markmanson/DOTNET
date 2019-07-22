using System;
/// <summary>
/// NamespaceName:ASP_Day1_2
/// Description:Webform controls and their states
/// Author: Bhumi
/// Created On:16/6/2015
/// </summary>   
namespace ASP_Day1_2
{
    public partial class Form_Property : System.Web.UI.Page
    {
        #region Page Load Event
        /// <summary>
        /// EventName:Page_Load
        /// Description: At page load Declare the session Variable
        /// Author:Bhumi
        /// Created On:16/6/2015
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                Session["SubmitClick"] = 0;
                LblCounter.Text = Session["SubmitClick"].ToString();
                LblCounter1.Text = Application["PageClick"].ToString();
            }
        }
        #endregion
        #region Submit Button Click Event
        /// <summary>
        /// Method Name:BtnSubmit_Click
        /// Description: On button click store the session value and display in other textbox
        /// Author:Bhumi
        /// Created On:16/6/2015
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            ConstantMessages objconstant;
            Class1_DefaultForm objclass1;//object declaration
            try
            {
                Session["sessionName"] = TxtName.Text;//store value of name in session variable                 
                // Increment counter session variable.
                Session["SubmitClick"] = (int)Session["SubmitClick"] + 1;
                LblCounter.Text = Session["SubmitClick"].ToString();

                //Number Of counter page visited
                LblCounter1.Text = Application["PageClick"].ToString();

                objclass1 = new Class1_DefaultForm();
                objclass1.Name = Session["sessionName"].ToString();//Use of Class Property
                TxtPropertyValue.Text = objclass1.Name;//Store Property Value
            }
            catch (Exception)
            {
                objconstant = new ConstantMessages();
                Response.Redirect(objconstant.strerrorpage);
            }
            finally
            {
                objconstant = null;
                objclass1 = null;
            }
        }
        #endregion
    }
}