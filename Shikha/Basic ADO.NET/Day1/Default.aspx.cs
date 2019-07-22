using System;
using System.Configuration;
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
           // SqlConnection connSql = new SqlConnection(ConfigurationManager.ConnectionStrings[Constant.strConnStr].ConnectionString);
            try
            {
                dtSql = new DataTable();
                //connSql.Open();                                                            // Open the connection
                connObj.OpenConnection();
                adapDA = new SqlDataAdapter(Constant.strQueryEmp, connObj.connC);       //  Pass the connection to a Data adapter object
                adapDA.Fill(dtSql);                                                        // fill Data from table   
                gvS.DataSource = dtSql;                                          
                gvS.DataBind();                                                      //Bind data 
            }
            catch (Exception)
            {
                Response.Redirect(Constant.strCatcExceptn);
            }
            finally
            {
                connObj.CloseConnection();
               
            }

        }
    }
    #endregion _Default
}
          
             





             //SqlDataAdapter da = new SqlDataAdapter(query, "NorthwindConnectionString");
             //try
             //{

             //    cn.Open();         // Open the connection


             //    SqlCommand cmd = new SqlCommand("select * from Employees", cn);  //  Pass the connection to a command object



             //    //rdr = cmd.ExecuteReader();           // get query results



             //    //while (rdr.Read())
             //    //{
             //    //    Console.WriteLine(rdr[0]);       // print the EmployeeID of each record
             //    //}
             //}
             //finally
             //{
             //    // close the reader
             //    if (rdr != null)
             //    {
             //        rdr.Close();
             //    }

             //    //  Close the connection
             //    if (cn != null)
             //    {
             //        cn.Close();
             //    }


             //}
        
    


       