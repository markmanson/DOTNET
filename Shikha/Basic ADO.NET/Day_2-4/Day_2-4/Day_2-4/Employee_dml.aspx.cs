using System;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI.WebControls;

namespace Day_2_4
{
    #region Employee_dml
    // NAME              :-  Employee_dml
    // AUTHOR NAME       :-  SHIKHA MALIK
    // DECRIPTION        :-  Class for add employee information
    // CREATED DATE      :-  29/07/2012
    public partial class Employee_dml : System.Web.UI.Page
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
                gvEmpDml.DataSource = ds.Employees;
                gvEmpDml.DataBind();                                      //Bind data
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
     protected void LbtnEDIT_Click(object sender, EventArgs e)                            //CLICK EVENT OCCUR FOR EDITING
        {
            int rdx = (((GridViewRow)(((LinkButton)(sender)).Parent.BindingContainer))).RowIndex;          //SELECTE ROW ON WHICH EVENT OCCUR
            // Row = (GridViewRow)gvEmpTer.Rows[rdx];
            int EmployeeID = int.Parse(gvEmpDml.DataKeys[rdx].Value.ToString());
            Session[Constant.strEmpid] = EmployeeID;                                                                //STORE VALUE IN SESSION
            Response.Redirect(Constant.strRedirect);                                                        //REDIRECT PAGE ON ADD_EMP.ASPX                                                       
        }

        protected void LbtnDELETE_Click(object sender, EventArgs e)
        {
            SqlCommand Cmd;                                                                              //DECLARATION OF SQL COMMAND           
            StringBuilder strB1; Common connObj = new Common();
            try
            {
                connObj.OpenConnection();
                int rdx = (((GridViewRow)(((LinkButton)(sender)).Parent.BindingContainer))).RowIndex;                    //SELECTE ROW ON WHICH EVENT OCCUR        
                int EmployeeID = Int32.Parse(gvEmpDml.DataKeys[rdx].Value.ToString());                                 //PARSE THE VALUE OF EMPLOYEE ID          
                strB1 = new StringBuilder();                                                                      //INITIALIZATION OF STRING BUILDER
                strB1.Append(Constant.strQueryEmpDelete);                                  //APPEND THE STRING BUILDER
                strB1.Append(EmployeeID);
                Cmd = new SqlCommand(strB1.ToString(), connObj.connC);                                //INITIALIZATION OF COMMAND
                Cmd.ExecuteNonQuery();                                                             //EXECUTE THE COMMAND
                lblDelete.Visible = true;                                                   //MAKING LABEL VISIBLE
                lblDelete.Text = Constant.strMsgDelete; 
                if (connObj.connC.State == System.Data.ConnectionState.Open)
                {
                    connObj.connC.Close();                                                                   //CLOSE THE CONNECTION
                }
          }
            catch (Exception)
            {
                Response.Redirect(Constant.strCatcExceptn);
            }
            finally
            {
                if (connObj.connC.State == System.Data.ConnectionState.Open)
                {
                    connObj.connC.Close();                                                                   //CLOSE THE CONNECTION
                }
                Cmd = null;
                strB1 = null;
            }
        }

        protected void LbtnAdd_Click(object sender, EventArgs e)                             //CLICK EVENT FOR ADD INFORMATION
        {
            Response.Redirect(Constant.strRedirect);                                                //REDIRECT PAGE ON ADD_EMP.ASPX 

        }
    }
    #endregion Employee_dml
}
