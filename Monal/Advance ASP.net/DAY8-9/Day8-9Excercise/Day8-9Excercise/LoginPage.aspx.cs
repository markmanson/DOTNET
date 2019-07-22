using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Threading;

namespace Day8_9ExcerobjCultureInfose
{
    /// <summary>
    /// Name:LoginPage
    /// Description:Task : 1 When the page is first time loaded it will detect the user's culture and show the above screen as per the culture. If the culture is japanese, show screen 2 and if its english show screen 1. 
    ///             Task : 2 In scren 1 If user click on 日本語(japanese) button, Screen 1 will change to Screen 2. And in screen 2 If user click on English button screen will chnge to Screen1.
    ///             Task : 3 On Clicking Submit button it will show screen 3. but welcome message will show according to the user's selected language     
    /// AuthorName:Monal shah
    /// Created Date:2010/11/23            
    /// </summary>
    public partial class LoginPage : System.Web.UI.Page
    {
        CultureInfo objCultureInfo;
        string lang;
        ResourceManager gStrings;
        DataTable dtUsers;
        Commonlogic objcl = new Commonlogic();
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description:Reset Resources According to Culture.     
        /// AuthorName:Monal shah
        /// Created Date:2010/11/23  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            TxtName.Focus();
            Page.Form.DefaultButton = BtnSubmit.UniqueID;
            if (!IsPostBack)
            {
                objCultureInfo = Thread.CurrentThread.CurrentUICulture;
                ResourceSet();
            }
        }
        #endregion
        #region ResourceSet
        /// <summary>
        /// Name:ResourceSet
        /// Description:Reset Resources According to Culture.     
        /// AuthorName:Monal shah
        /// Created Date:2010/11/23  
        /// </summary>
        private void ResourceSet()
        {
            lang = objCultureInfo.Name;
            gStrings = ResourceManager.CreateFileBasedResourceManager("Strings", Server.MapPath("Resources") +
                    Path.DirectorySeparatorChar, null);
            Session["Culture"] = lang;       
            LoginPanel.GroupingText = gStrings.GetString("LoginPanel", objCultureInfo);
            LblHeading.Text = gStrings.GetString("LblHeading", objCultureInfo);
            LblName.Text = gStrings.GetString("LblName", objCultureInfo);
            LblPwd.Text = gStrings.GetString("LblPwd", objCultureInfo);
            BtnSubmit.Text = gStrings.GetString("BtnSubmit", objCultureInfo);
            BtnCancel.Text = gStrings.GetString("BtnCancel", objCultureInfo);
            BtnLanguage.Text = gStrings.GetString("BtnLanguage", objCultureInfo);
        }
        #endregion
        #region BtnLanguage_Click
        /// <summary>
        /// Name:BtnLanguage_Click
        /// Description:Language Change According To Culture.     
        /// AuthorName:Monal shah
        /// Created Date:2010/11/23  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnLanguage_Click(object sender, EventArgs e)
        {
            LblMsg.Visible = false;
            lang = Convert.ToString(Session["Culture"]);
            if (lang == "en-US")
            {
                objCultureInfo = new CultureInfo("ja-JP");
            }
            else if (lang == "ja-JP")
            {
                objCultureInfo = new CultureInfo("en-US");
            }
            ResourceSet();
        }
        #endregion
        #region BtnSubmit_Click
        /// <summary>
        /// Name:BtnSubmit_Click
        /// Description:If User Id and password is correct then redirected to  welcome.aspx page.
        /// Author:Monal Shah
        /// created date:2010/11/22
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnSubmit_Click(object sender, EventArgs e)
        {
            lang = Convert.ToString(Session["Culture"]);
            dtUsers = new DataTable();
            if (lang == "en-US")
                lang = "English.ResourceFile";
            else if (lang == "ja-JP")
                lang = "Japanees.ResourceFile";
            try
            {
                objcl.GetSqlStmt = objcl.SelectQuery("TblLogin", "UserId", TxtName.Text, "PasswordValue", TxtPwd.Text);
                dtUsers = objcl.DataTables();
                if (dtUsers.Rows.Count > 0)
                {
                    if (dtUsers.Rows[0]["UserId"].ToString() == TxtName.Text && dtUsers.Rows[0]["PasswordValue"].ToString() == TxtPwd.Text)
                        Response.Redirect("Welcome.aspx?id=" + TxtName.Text + "," + lang, false);
                }
                else
                {
                    LblMsg.Visible = true;
                    string lang1 = Convert.ToString(Session["Culture"]);
                    gStrings = ResourceManager.CreateFileBasedResourceManager("Strings", Server.MapPath("Resources") +
                               Path.DirectorySeparatorChar, null);
                    objCultureInfo = new CultureInfo(lang1);
                    LblMsg.Text = gStrings.GetString("LblMsg", objCultureInfo);
                }
            }
            catch (Exception)
            { Response.Redirect("Error.aspx", false); }
            finally
            {
                dtUsers.Dispose();
                objcl = null;
            }
        }
        #endregion
        #region BtnCancel_Click
        /// <summary>
        /// Name:BtnCancel_Click
        /// Description:Reset Controls
        /// Author:Monal Shah
        /// created date:2010/11/22
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnCancel_Click(object sender, EventArgs e)
        {
            TxtName.Text = string.Empty;
            TxtPwd.Text = string.Empty;
        }
        #endregion
    }
}
