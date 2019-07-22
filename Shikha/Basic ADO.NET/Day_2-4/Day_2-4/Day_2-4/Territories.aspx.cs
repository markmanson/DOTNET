using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Day_2_4
{
    #region Territories
    // NAME              :- Territories
    // AUTHOR NAME       :-  SHIKHA MALIK
    // DECRIPTION        :-  Class for open connection and bind data
    // CREATED DATE      :-  27/07/2012
    public partial class Territories : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dtSql; SqlDataAdapter adapDA; StringBuilder strBl; string strcons;
            Common connObj = new Common();                                 //declaration of objects
           try
            {
                DataSetEmp ds = new DataSetEmp();      
                Session[Constant.strBuil6] = ds;      //Store dataset into session
                connObj.OpenConnection();             //open connection
                dtSql = new DataTable();              //create data table
                strBl = new StringBuilder();          //create string builder object
                strBl.Append(Constant.strBuil1);       //Append string
                strBl.Append(Constant.strBuil2);
                strBl.Append(Constant.strBuil3);
                strBl.Append(Constant.strBuil7);
                strcons = strBl.ToString();
                adapDA = new SqlDataAdapter(strcons, connObj.connC);       //  Pass the connection to a Data adapter object
                adapDA.Fill(dtSql);                                                        // fill Data from table   
                gvS.DataSource = dtSql;
                gvS.DataBind();                                              //Bind data
                if (gvS.Rows.Count == 0)
                {
                    LblMsgT.Visible = true;
                    LblMsgT.Text = Constant.strNotFound;
                }
               
            }
            catch (Exception)
            {
                Response.Redirect(Constant.strCatcExceptn);              //throw Exception
            }
            finally                                                      //Reallocate memory
            {
                connObj.CloseConnection();
                connObj = null;
                adapDA = null;
            }

        }
    }
    #endregion Territories
}
