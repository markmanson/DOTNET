using System;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI.WebControls;

namespace Day5_9
{
    #region Customer
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- Customer
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- The Class Allow user to display Record of Customers With DML Operation
    //      CREATED DATE    :- 2012/08/06
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class Customer : System.Web.UI.Page
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
                strBl.Append(Constant.strCustomers);
                strcons = strBl.ToString();                           //store all string into a string
                adapDA = new SqlDataAdapter(strcons, connObj.connC);  //pass connection and query into data adapter
                adapDA.Fill(ds,"Customers");                   //fill dataset from employee table
                gvCustomerDml.DataSource = ds.Customers;
                gvCustomerDml.DataBind();                                      //Bind data
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

        protected void LbtnEDIT_Click(object sender, EventArgs e)
        {
            int rdx = (((GridViewRow)(((LinkButton)(sender)).Parent.BindingContainer))).RowIndex;          //SELECTE ROW ON WHICH EVENT OCCUR
            // Row = (GridViewRow)gvEmpTer.Rows[rdx];
            string CustomerID = (gvCustomerDml.DataKeys[rdx].Value.ToString());
            Session["cusID"] = CustomerID;                                                                //STORE VALUE IN SESSION
            Response.Redirect(Constant.strAddCustomer);   
        }

        protected void LbtnDELETE_Click(object sender, EventArgs e)
        {
            SqlCommand Cmd;                                                                              //DECLARATION OF SQL COMMAND           
            StringBuilder strB1; Common connObj = new Common();
            try
            {
                connObj.OpenConnection();
                int rdx = (((GridViewRow)(((LinkButton)(sender)).Parent.BindingContainer))).RowIndex;                    //SELECTE ROW ON WHICH EVENT OCCUR        
                string CustomerID = (gvCustomerDml.DataKeys[rdx].Value.ToString());                         //PARSE THE VALUE OF EMPLOYEE ID          
                strB1 = new StringBuilder();                                                                      //INITIALIZATION OF STRING BUILDER
                strB1.Append(Constant.strQueryCustDelete);                                  //APPEND THE STRING BUILDER
                strB1.Append("'" + CustomerID + "'");
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
                Response.Redirect(Constant.strCustomer);
            }

        }

        protected void LbtnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect(Constant.strAddCustomer); 
        }
    }
    #endregion Customer
}
