using System;
using System.Data;
using System.Data.SqlClient;

namespace Day1
{
    #region _Default
    // NAME              :- _Default
    // AUTHOR NAME       :-  SHIKHA MALIK
    // DECRIPTION        :-  Class for open connection and bind data
    // CREATED DATE      :-  25/07/2012
    public partial class _Default : System.Web.UI.Page
    {
        // SqlConnection conn = new SqlConnection(
        //"Data Source=UNIAD01;Initial Catalog=Northwind_Shikha;User ID=sa;Password=sa");    //*1st assignment
     protected void Page_Load(object sender, EventArgs e)
        {
              DataTable dtSql; SqlDataAdapter adapDA;  Common connObj = new Common();
        try
            {
                dtSql = new DataTable();                                                 
                connObj.OpenConnection();                                                 //Create object of class 
                adapDA = new SqlDataAdapter(Constant.strQueryEmp, connObj.connC);       //  Pass the connection to a Data adapter object
                adapDA.Fill(dtSql);                                                        // fill Data from table   
                gvS.DataSource = dtSql;
                gvS.DataBind();                    //Bind data
                if (gvS.Rows.Count == 0)
                {
                    LblMsg.Visible = true;
                    LblMsg.Text =Constant.strNotFound;
                }
             }
            catch (Exception)
            {
                Response.Redirect(Constant.strCatcExceptn);
            }
            finally
            {
                connObj.CloseConnection();
                dtSql = null; connObj = null;
                adapDA = null;
            }

        }
    }
    #endregion _Default
}
          
             





            
    


       