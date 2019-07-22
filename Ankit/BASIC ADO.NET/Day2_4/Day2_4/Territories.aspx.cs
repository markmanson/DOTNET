using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
namespace Day2_4
{
    #region Territories
    /*************************************************************************************************************
       NAME                               ::::                    Territories
       AUTHOR                             ::::                    ANKIT
       DATE                               ::::                    13-07-2012
       DESCRIPTION                        ::::                    TO MAKE A CLASS Territories
      ************************************************************************************************************/
    public partial class Territories : System.Web.UI.Page
    {
        Common objCommon = new Common();                                                 //INITIALIZATION OF OBJECT OF CLASS COMMON
        #region Page_Load
        //FUNCTION PAGE_LOAD  *************************************************************************************************
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {               
                StringBuilder strBuild;                                                 //DECLARATION FOR OBJECT OF STRING BUILDER
                SqlCommand Cmd;                                                         //DECLARATION FOR OBJECT OF SQLCOMMAND
                SqlDataReader Rdr;                                                      //DECLARATION FOR OBJECT OF SQLDATAREADER
                try
                {              
                    objCommon.Connect.Open();                                                     //OPEN THE DATABASE
                    strBuild = new StringBuilder();                                     //INITIALIZATION OF STRING BUILDER
                    strBuild.Append(Constant.strSel);                                //APPENDING THE STRING BUILDER
                    strBuild.Append(Constant.strAll);                                   //APPENDING THE STRING BUILDER
                    strBuild.Append(Constant.strFrom);                                  //APPENDING THE STRING BUILDER
                    strBuild.Append(Constant.strTerr);                                   //APPENDING THE STRING BUILDER
                    Cmd = new SqlCommand(Convert.ToString(strBuild), objCommon.Connect);          //INITIALIZATION OF SQL COMMAND 
                    Rdr = Cmd.ExecuteReader();                                          //TO EXECUTE THE COMMAND
                    gdvTerritories.DataSource = Rdr;                                       //TO SEND THE CONTENT OF TABLE INTO GRIDVIEW
                    gdvTerritories.DataBind();                                             //TO BIND THE DATA OF TABLE INTO GRIDVIEW
                    if (objCommon.Connect.State == System.Data.ConnectionState.Open)
                    {
                        objCommon.Connect.Close();                                                    //TO CLOSE THE DATABASE
                    }
                    if (gdvTerritories.Rows.Count == 0)
                    {
                        lblError.Visible = true;
                        lblError.Text = Constant.strSorry;
                    }
                }
                catch (Exception)
                {
                    Response.Redirect("Error.aspx");                                    //REDIRECT TO ERROR.ASPX IF ANY ERROR IS OCCURED
                }
                finally
                {
                    if (objCommon.Connect.State == System.Data.ConnectionState.Open)
                    {
                        objCommon.Connect.Close();                                                                   //CLOSE THE CONNECTION
                    }                 
                    strBuild = null;                                                     //DESTROYING THE OBJECT OF STRING BUILDER
                    Cmd = null;                                                          //DESTROYING THE OBJECT OF SQLCOMMAND
                    Rdr = null;                                                          //DESTROYING THE OBJECT OF SQLDATAREADER
                }
            }
        }
        #endregion Page_Load
    }
    #endregion Territories
}
