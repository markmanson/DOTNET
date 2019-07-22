using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI.WebControls;

namespace Day5_9
{
    #region EmployeeTerritories
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- EmployeeTerritories
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- The Class Allow user to add or update Record of employees and territories
    //      CREATED DATE    :- 2012/08/07
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class EmployeeTerritories : System.Web.UI.Page
    {
        ListBox myListBox;
        protected void Page_Load(object sender, EventArgs e)
        {
            ShowData();
           
        }
        public void ShowData()
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
                gvEmpTer.DataSource = ds.Employees;
                gvEmpTer.DataBind();                                      //Bind data
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
        protected void gvEmpTer_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            SqlDataAdapter adapDA; StringBuilder strBl; string strCmd;  // declaration of object
            Common connObj;
            DataTable dtEmpT;
         if (e.Row.RowType == DataControlRowType.DataRow)
            {
           try
                {
                    connObj = new Common();
                    connObj.OpenConnection();
                    myListBox = (ListBox)e.Row.FindControl(Constant.strLstTerritoryDescrip);
                    string strList = myListBox.ToString();
                    dtEmpT = new DataTable();
                    strBl = new StringBuilder();
                    int EmployeeID = int.Parse(gvEmpTer.DataKeys[e.Row.RowIndex].Value.ToString());
                    strBl.Append(Constant.strBuil1);
                    strBl.Append(Constant.strDistnctdister);
                    strBl.Append(Constant.strBuil3);
                    strBl.Append(Constant.strTer_T);
                    strBl.Append(Constant.strTer_Emp);
                    strBl.Append(Constant.strBui20);
                    strBl.Append(Constant.strTerIdET);
                    strBl.Append(Constant.strand);
                    strBl.Append(Constant.strETid);
                    strBl.Append(Constant.strBui22);
                    strBl.Append(EmployeeID);
                   strCmd = strBl.ToString();
                   adapDA = new SqlDataAdapter(strCmd, connObj.connC); // Create Data Adapeter
                   adapDA.Fill(dtEmpT);

                    if (dtEmpT.Rows.Count > 0)
                    {
                         myListBox.DataSource = dtEmpT;
                         myListBox.DataBind();
                    }

                }
                catch (Exception ex)
                {
                    Response.Redirect(Constant.strCatcExceptn);
                }
                finally
                {
                }

            }
        }

        protected void LbtnEDIT_Click(object sender, EventArgs e)
        {
            int rdx = (((GridViewRow)(((LinkButton)(sender)).Parent.BindingContainer))).RowIndex;          //SELECTE ROW ON WHICH EVENT OCCUR
            // Row = (GridViewRow)gvEmpTer.Rows[rdx];
            int EmployeeID = int.Parse(gvEmpTer.DataKeys[rdx].Value.ToString());
            Session[Constant.strEmpid] = EmployeeID;                                                                //STORE VALUE IN SESSION
            Response.Redirect(Constant.strAddEmpterritory); 

        }

        protected void LbtnDELETE_Click(object sender, EventArgs e)
        {

            SqlCommand Cmd;                                                                              //DECLARATION OF SQL COMMAND           
            StringBuilder strB1; Common connObj = new Common();
            try
            {
                connObj.OpenConnection();
                int rdx = (((GridViewRow)(((LinkButton)(sender)).Parent.BindingContainer))).RowIndex;                    //SELECTE ROW ON WHICH EVENT OCCUR        
                int EmployeeID = Int32.Parse(gvEmpTer.DataKeys[rdx].Value.ToString());                                 //PARSE THE VALUE OF EMPLOYEE ID          
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
                ShowData();                                                       //call method for rebind data after delete
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
                Response.Redirect(Constant.strRedirectEmpTer); 
            }

        }

        protected void LbtnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect(Constant.strAddEmpterritory);

        }


    }
    #endregion EmployeeTerritories
}

        

    

