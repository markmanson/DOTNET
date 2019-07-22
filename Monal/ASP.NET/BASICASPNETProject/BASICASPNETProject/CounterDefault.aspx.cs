using System;

namespace BASICASPNETProject
{
       
    /// <summary>
    /// Name:CounterDefault.aspx
    /// Description:"Task 1:After entring the data in Txt1 
    ///             when user click on Submit button store the value of Txt1 
    ///             in session object and display it in Txt2 when page does its round trip from the server."
    ///             "Task 2 : After clicking on Submit button display the number of clicks for particular session in LblCounter."
    ///             "Task 3 : Display the count for the number of persons visited this application in LblCounter1.
    /// Author:Monal Shah
    /// CreatedDate:2010/10/11
    /// </summary>
    public partial class CounterDefault : System.Web.UI.Page
    {
        CounterDefaultValue ObjGetValue = new CounterDefaultValue();
        ConstantMessage objConst = new ConstantMessage();
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description:How many User Visited this application that is displayed
        /// CreatedDate:2010/10/11
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            string strVisitedUser =objConst.ApplicatioCounter+":"+Application.Get("User").ToString();
            LblCounter2.Text = strVisitedUser;
            LblCounter1.Visible = false;
            LblErrorMessage.Visible = false;
        }
        #endregion
        #region BtnSubmit_Click
        /// <summary>
        /// Name:BtnSubmit_Click
        /// Description:Task 1:"After entring the data in Txt1 
        ///             when user click on Submit button store the value of Txt1 
        ///             in session object and display it in Txt2 when page does its round trip from the server."
        ///             "Task 2 : After clicking on Submit button display the number of clicks for particular session in LblCounter."
        /// Author:Monal Shah
        /// CreatedDate:2010/10/11
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                ObjGetValue.Name = TxtName.Text.ToString();
                TxtSession.Text = ObjGetValue.Name;
                LblCounter1.Visible = true;
                if (TxtName.Text != "")
                {
                    if (Session["Count"] == null)
                    {
                        Session["Count"] = 1;
                        LblCounter1.Text =objConst.Sessioncounter+" "+Convert.ToString(Session["Count"]);
                        

                    }
                    else if (Session["Count"] != null)
                    {
                        Session["Count"] = Convert.ToInt32(Session["Count"]) + 1;
                        LblCounter1.Text = objConst.Sessioncounter + " " + Convert.ToString(Session["Count"]);

                    }
                }
                else
                {
                    LblErrorMessage.Visible = true;
                    LblErrorMessage.Text=objConst.EnterName;
                    LblCounter1.Visible = false;
                }
                TxtName.Text = string.Empty;
                
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
           
        }
        #endregion
    }
}
