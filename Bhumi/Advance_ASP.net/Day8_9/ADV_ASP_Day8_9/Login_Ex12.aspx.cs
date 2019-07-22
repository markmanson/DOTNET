using System;
using System.Resources;
using System.Text;
/// <summary>
/// Namespace Name:ADV_ASP_Day8_9
/// Description: Globalization and Localization in ASP.Net
/// Author:Bhumi
/// Created On:16/7/2015
/// </summary>
namespace ADV_ASP_Day8_9
{
    /// <summary>
    /// Class Name:Login_Ex12
    /// Description: Login Form In Two languages[English & Japanese]
    /// Author:Bhumi
    /// Created On:17/7/2015
    /// </summary>        
    public partial class Login_Ex12 : System.Web.UI.Page
    {
        CommonFunction objcommon;
        ConstantMessages objconst;
        ResourceManager EnStrings;
        ResourceManager JaStrings;
        #region Page Load
        /// <summary>
        /// Method Name:Page_Load
        /// Description: Identify Culture of your System and Set Related Login Page
        /// Author:Bhumi
        /// Created On:17/7/2015     
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string sLang, sLang1;
                //Get The Culture Info
                sLang = System.Threading.Thread.CurrentThread.CurrentCulture.EnglishName;
                sLang1 = sLang.Substring(0, 2);
                if (sLang1 == "En")
                {
                    BtnLanguage.Text = "日本語";
                    GetEnglish();//Mehod Call
                }
                else if (sLang1 == "Ja")
                {
                    BtnLanguage.Text = "English";
                    GetJapanese();//Method Call
                }
                else
                {
                    BtnLanguage.Text = "日本語";
                    GetEnglish();//Mehod Call
                }
            }            
        }
        #endregion
        #region Click Event Of Language[English / 日本語 ]
        /// <summary>
        /// Method Name:BtnLanguage_Click
        /// Description: Change Language and Set Related Login Page & its Controls
        /// Author:Bhumi
        /// Created On:17/7/2015     
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        protected void BtnLanguage_Click(object sender, EventArgs e)
        {
            LblInvalid.Visible = false;
            if (BtnLanguage.Text == "日本語")
            {
                GetJapanese();                                    
            }
            else if (BtnLanguage.Text == "English")
            {
                GetEnglish();                               
            }
        }
        #endregion
        #region Get the Values In English
        /// <summary>
        /// Method Name:GetEnglish
        /// Description:Set English Language of Login Page & its Controls
        /// Author:Bhumi
        /// Created On:17/7/2015     
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>                
        public void GetEnglish()
        {
            EnStrings = new ResourceManager("ADV_ASP_Day8_9.JapaneseToEnglish", typeof(JapaneseToEnglish).Assembly);
            try
            {
                LblHeader.Text = EnStrings.GetString("Header1");
                LblInvalid.Text = EnStrings.GetString("LblInvalid");
                LblLoginID.Text = EnStrings.GetString("LblLoginID");
                LblPassword.Text = EnStrings.GetString("LblPassword");
                RfvName.ErrorMessage = EnStrings.GetString("RfvName");
                RfvPassword.ErrorMessage = EnStrings.GetString("RfvPassword");
                BtnSubmit.Text = EnStrings.GetString("BtnSubmit");
                BtnCancel.Text = EnStrings.GetString("BtnCancel");
                BtnLanguage.Text = EnStrings.GetString("BtnLanguage");
            }
            catch (Exception)
            {
                objconst = new ConstantMessages();
                Response.Redirect(objconst.strErrorPage);
            }
            finally
            {
                EnStrings = null;
                objconst = null;
            }
        }
        #endregion
        #region Get the Values In Japanese
        /// <summary>
        /// Method Name:GetEnglish
        /// Description:Set Japanese Language of Login Page & its Controls
        /// Author:Bhumi
        /// Created On:17/7/2015     
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>                        
        public void GetJapanese()
        {
            JaStrings = new ResourceManager("ADV_ASP_Day8_9.EnglishToJapanese", typeof(EnglishToJapanese).Assembly);
            try
            {
                LblHeader.Text = JaStrings.GetString("Header1");
                LblInvalid.Text = JaStrings.GetString("LblInvalid");
                LblLoginID.Text = JaStrings.GetString("LblLoginID");
                LblPassword.Text = JaStrings.GetString("LblPassword");
                RfvName.ErrorMessage = JaStrings.GetString("RfvName");
                RfvPassword.ErrorMessage = JaStrings.GetString("RfvPassword");
                BtnSubmit.Text = JaStrings.GetString("BtnSubmit");
                BtnCancel.Text = JaStrings.GetString("BtnCancel");
                BtnLanguage.Text = JaStrings.GetString("BtnLanguage");
            }
            catch (Exception)
            {
                objconst = new ConstantMessages();
                Response.Redirect(objconst.strErrorPage);
            }
            finally
            {
                JaStrings = null;
                objconst = null;
            }             
        }
        #endregion
        #region Submit Button Click
        /// <summary>
        /// Method Name:BtnSubmit_Click
        /// Description: Redirection to the welcome page for authenticate user
        /// Author:Bhumi
        /// Created On:16/7/2015        
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            StringBuilder strBrSelectQuery;
            object UserName_Password_Exist;        
            try
            {
                objcommon = new CommonFunction();
                //Existance in Employees_Temp Table
                strBrSelectQuery = new StringBuilder("SELECT FirstName,LastName ");
                strBrSelectQuery.Append(" FROM Employees_Temp");
                strBrSelectQuery.Append(" WHERE FirstName='" + TxtLoginID.Text + "' COLLATE Latin1_General_CS_AS AND LastName='" + TxtPassword.Text + "' COLLATE Latin1_General_CS_AS ;");
                UserName_Password_Exist = objcommon.ConnectionGenerate(strBrSelectQuery.ToString());
                if (UserName_Password_Exist != null)
                {
                    Session["LoginID"] = TxtLoginID.Text;
                    Session["Language"] = BtnSubmit.Text;
                    objconst = new ConstantMessages();
                    Response.Redirect(objconst.strWelComePage, false);//redirection
                }
                else
                {
                    LblInvalid.Visible = true;
                }
            }
            catch (Exception)
            {
                objconst = new ConstantMessages();
                Response.Redirect(objconst.strErrorPage);
            }
            finally
            {
                strBrSelectQuery = null;
                objcommon = null;
                objconst = null;
            }
        }
        #endregion
        #region Cancel Button Click Event
        //Cause Validation False Remove text From Control
        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            TxtLoginID.Text = "";
            TxtPassword.Text = "";
            LblInvalid.Visible = false;
        }
        #endregion
    }
}