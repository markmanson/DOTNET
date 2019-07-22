using System;
using System.Data.SqlClient;
using System.Text;

namespace Day_2_4
{
    #region EmployeeTerritories
    // NAME              :-  EmployeeTerritories
    // AUTHOR NAME       :-  SHIKHA MALIK
    // DECRIPTION        :-  Class for add employee information
    // CREATED DATE      :-  30/07/2012
    public partial class EmployeeTerritories : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataAdapter adapDA; DataSetEmp ds; StringBuilder strBl; string strcons;  // declaration of object
            Common connObj = new Common();
            try
            {
                   connObj.OpenConnection();                             //open connection from common class object
                    ds = new DataSetEmp();                               //create object of typed data set
                    //  DataSetEmp ds1 = (DataSetEmp)Session[Constant.strBuil6];    // reterive session
                    strBl = new StringBuilder();                          //Create object of string builder class       
                   if (Session[Constant.strempid] != null)
                    {
                        string stre = Session[Constant.strempid].ToString();
                        int EmployeeID = Int32.Parse(stre);
                        strBl.Append(Constant.strQueryEmpTerr);
                        strBl.Append(stre);
                   }
                    else
                    {
                       strBl.Append(Constant.strBuil1);                      //Append string                            
                       strBl.Append(Constant.strBuil2);                      //Append string
                       strBl.Append(Constant.strBuil3);
                       strBl.Append(Constant.strBuil8);
                    }

                    strcons = strBl.ToString();                           //store all string into a string
                    adapDA = new SqlDataAdapter(strcons, connObj.connC);  //pass connection and query into data adapter
                    adapDA.Fill(ds,Constant.strBuil9);                   //fill dataset from employee table
                    gvEmpTer.DataSource = ds.EmployeeTerritories;
                    gvEmpTer.DataBind();                                      //Bind data
                    if (gvEmpTer.Rows.Count == 0)
                    {
                        LblMsgET.Visible = true;
                        LblMsgET.Text = Constant.strNotFound;
                    }
                }
            
            catch (Exception ex)
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
    #endregion EmployeeTerritories
}
