using System;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI.WebControls;

namespace Day_2_4
{
    #region DefaultLinkEmp
    // NAME              :-  DefaultLinkEmp
    // AUTHOR NAME       :-  SHIKHA MALIK
    // DECRIPTION        :-  Class for add employee information
    // CREATED DATE      :-  29/07/2012
    public partial class DefaultLinkEmp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)                            //FUNCTION PAGE_LOAD 
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
                strBl.Append(Constant.strBuil8);
                strBl.Append(Constant.strBui24);
                strBl.Append(Constant.strBui25);
                strBl.Append(Constant.strBuil4);
                strBl.Append(Constant.strBui26);
                strBl.Append(Constant.strBui23);
                strBl.Append(Constant.strBui22);
                strBl.Append(Constant.strBui21);
                strBl.Append(Constant.strBui27);
                strBl.Append(Constant.strBui28);
                strBl.Append(Constant.strBui23);
                strcons = strBl.ToString();                           //store all string into a string
                adapDA = new SqlDataAdapter(strcons, connObj.connC);  //pass connection and query into data adapter
                adapDA.Fill(ds, Constant.strBuil9);                   //fill dataset from employee table
                gvEmpTer.DataSource = ds.EmployeeTerritories;
                gvEmpTer.DataBind();                                      //Bind data
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
        protected void LbtnEmployeeName_Click(object sender, EventArgs e)                       //CLICK EVENT ON LINK BUTTON
        {
           int rdx = (((GridViewRow)(((LinkButton)(sender)).Parent.BindingContainer))).RowIndex;    //TAKE ROW VALUE ON WHICH EVENT OCCUR
           // Row = (GridViewRow)gvEmpTer.Rows[rdx];
            int EmployeeID = Int32.Parse(gvEmpTer.DataKeys[rdx].Value.ToString());
            Session[Constant.strempid]= EmployeeID;                                                           //STORE VALUE IN SESSION
            Response.Redirect(Constant.strRedirectEmpTer);                                          //REDIRECT
        }     
    }
    #endregion DefaultLinkEmp
}
