using System;
using System.Data.SqlClient;
using System.Text;
namespace Day_2_4
{
    #region _Defaul
    // NAME              :- _Default
    // AUTHOR NAME       :-  SHIKHA MALIK
    // DECRIPTION        :-  Class for display employee information using typed dataset
    // CREATED DATE      :-  27/07/2012
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapDA; DataSetEmp ds; StringBuilder strBl; string strcons;  // declaration of object
            Common connObj = new Common();
        try
            {
                connObj.OpenConnection();                             //open connection from common class object
                 ds = new DataSetEmp();                               //create object of typed data set
                DataSetEmp ds1 = (DataSetEmp)Session[Constant.strBuil6];    // reterive session
                strBl = new StringBuilder();                          //Create object of string builder class       
                strBl.Append(Constant.strBuil1);                      //Append string                            
                strBl.Append(Constant.strBuil2);                      //Append string
                strBl.Append(Constant.strBuil3);
                strBl.Append(Constant.strBuil4);
                strcons = strBl.ToString();                           //store all string into a string
                adapDA = new SqlDataAdapter(strcons, connObj.connC);  //pass connection and query into data adapter
                adapDA.Fill(ds, Constant.strBuil5);                   //fill dataset from employee table
                gvEmp.DataSource = ds.Employees;                   
                gvEmp.DataBind();                                      //Bind data
                if (gvEmp.Rows.Count == 0)
                {
                    LblMsg.Visible = true;
                    LblMsg.Text = Constant.strNotFound;
                }
             }
            catch (Exception)
            {
                Response.Redirect(Constant.strCatcExceptn);          //throw exception on error page
            }
            finally                                                 //reallocate memory
            {
                connObj.CloseConnection();
                 connObj = null;
                 adapDA = null; strcons = null;
            }

        }

    }
    #endregion
}

