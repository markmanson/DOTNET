using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;

namespace ADO.NET
{
    #region _Default
    /*************************************************************************************************************
         NAME                               ::::                    _DEFAULT
         AUTHOR                             ::::                    ANKIT
         DATE                               ::::                    11-07-2012
         DESCRIPTION                        ::::                    DEFAULT PAGE
        ************************************************************************************************************/
    public partial class _Default : System.Web.UI.Page
    {       
        #region Page_Load 
        //CONNECTION STRING ******************************************************************************************
       // public const string conn = "Data Source=UNIAD01;Initial Catalog=Northwind_Ankit;User ID=sa;Password=sa";
        protected void Page_Load(object sender, EventArgs e)
        {            
            SqlConnection Connect;                                                  //DECLARATION FOR OBJECT OF  SQL CONNECTION
            StringBuilder strBuild;                                                 //DECLARATION FOR OBJECT OF STRING BUILDER
            SqlCommand Cmd;                                                         //DECLARATION FOR OBJECT OF SQLCOMMAND
            SqlDataReader Rdr;                                                      //DECLARATION FOR OBJECT OF SQLDATAREADER            
            try
            {
                // Connect = new SqlConnection(conn);
                // string con=ConfigurationSettings.AppSettings;//("MyConnection");            
                Connect = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString);
                Connect.Open();                                                     //OPEN THE DATABASE
                strBuild = new StringBuilder();                                     //INITIALIZATION OF STRING BUILDER
                strBuild.Append(Constant.strSelect);                                //APPENDING THE STRING BUILDER
                strBuild.Append(Constant.strAllEmp);                                //APPENDING THE STRING BUILDER
                strBuild.Append(Constant.strFrom);                                  //APPENDING THE STRING BUILDER
                strBuild.Append(Constant.strEmp);                                   //APPENDING THE STRING BUILDER                
                Cmd = new SqlCommand(Convert.ToString(strBuild), Connect);          //INITIALIZATION OF SQL COMMAND 
                Rdr = Cmd.ExecuteReader();                                          //TO EXECUTE THE COMMAND
                gdvEmployee.DataSource = Rdr;                                       //TO SEND THE CONTENT OF TABLE INTO GRIDVIEW
                gdvEmployee.DataBind();                                             //TO BIND THE DATA OF TABLE INTO GRIDVIEW
                Connect.Close();                                                    //TO CLOSE THE DATABASE
                if (gdvEmployee.Rows.Count == 0)
                {
                    LblError.Text = Constant.strErr;
                    LblError.Visible = true;
                }
                if (Rdr==null )
                {
                    Rdr.Close();
                }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");                                    //REDIRECT TO ERROR.ASPX IF ANY ERROR IS OCCURED
            }
            finally
            {
                Connect=null;                                                       //DESTROYING THE OBJECT OF  SQL CONNECTION
                strBuild=null ;                                                     //DESTROYING THE OBJECT OF STRING BUILDER
                Cmd=null ;                                                          //DESTROYING THE OBJECT OF SQLCOMMAND
                Rdr=null ;                                                          //DESTROYING THE OBJECT OF SQLDATAREADER
            }
        }
        #endregion Page_Load
    }
    #endregion _Default
}

