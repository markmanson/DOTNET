using System;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Data;
/// <summary>
/// NamespaceName:ADV_ASP_Day3
/// Description: Asp with Composite Custom Control
/// Author: Bhumi
/// Created On:7/7/2015
/// </summary>
namespace ADV_ASP_Day3
{
    /// <summary>
    /// Class Name:Default_Login
    /// Description:Use of Custom Control in WebForm
    /// Author:Bhumi
    /// Created On:7/7/2015
    /// </summary>
    public partial class Default_Login : System.Web.UI.Page
    {
        ConstantMessages objconst;
        CommonFunction objcommon;
        #region Page Load
        protected void Page_Load(object sender, EventArgs e)
        {            
        }
        #endregion
        #region Submit Click
        /// <summary>
        /// Method Name:Submit_Click
        /// Description:Use of Custom Control Onclick Method in WebForm & using This Check the Authentication of User While Login
        /// Author:Bhumi
        /// Created On:7/7/2015
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Submit_Click(object sender, EventArgs e)
        {            
            object UserName_Password_Exist;
            StringBuilder strBrSelectQuery;
            try
            {
                objcommon = new CommonFunction();
                //Existance in Employees_Temp Table
                strBrSelectQuery = new StringBuilder("SELECT FirstName,LastName ");
                strBrSelectQuery.Append(" FROM Employees_Temp");
                strBrSelectQuery.Append(" WHERE FirstName='" + LoginCotrol1.UserNameText + "' COLLATE Latin1_General_CS_AS AND LastName='" + LoginCotrol1.PassWordText + "' COLLATE Latin1_General_CS_AS ;");
                UserName_Password_Exist = objcommon.ConnectionGenerate(strBrSelectQuery.ToString());
                if (UserName_Password_Exist != null)
                {
                    objconst=new ConstantMessages();
                    LoginCotrol1.LblHeaderText = objconst.strAuthorizedUser;
                    LoginCotrol1.LblHeader.ForeColor = System.Drawing.Color.Green;                    
                }
                else
                {
                    objconst = new ConstantMessages();
                    LoginCotrol1.LblHeaderText = objconst.strUnAuthorizedUser;
                    LoginCotrol1.LblHeader.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch (Exception)
            {
                objconst = new ConstantMessages();
                Response.Redirect(objconst.strErrorPage);
            }
            finally
            {                
                objconst = null;                
                strBrSelectQuery = null;
            }
        }
        #endregion
    }
}