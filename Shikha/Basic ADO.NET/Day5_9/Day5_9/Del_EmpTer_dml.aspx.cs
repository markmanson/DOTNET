using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day5_9
{
    #region Del_EmpTer_dml
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- Del_EmpTer_dml
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- The Class Allow user to add or update Record of Employee 
    //      CREATED DATE    :- 2012/08/06
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class Del_EmpTer_dml : System.Web.UI.Page
    {
        ListBox myListBox; Common connObj;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindGrid();
            }
                

        }

        public void BindGrid()
        {
            SqlDataAdapter adapDA; DataSetEmp ds; StringBuilder strBl; string strcons;  // declaration of object
            connObj = new Common();
            
            try
            {

                connObj.OpenConnection();                             //open connection from common class object
                ds = new DataSetEmp();                               //create object of typed data set
                DataSetEmp ds1 = (DataSetEmp)Session[Constant.strBuil6];    // reterive session
                strBl = new StringBuilder();                          //Create object of string builder class       
                strBl.Append(Constant.strBuil1);                      //Append string                            
                // strBl.Append(Constant.strBuil2);                      //Append string
                strBl.Append(Constant.strEmp_ID);
                strBl.Append(Constant.strLastnm);
                strBl.Append(Constant.strFrstnm);
                strBl.Append(Constant.strETitle);
                strBl.Append(Constant.strttlcur);
                strBl.Append(Constant.strBrthdate);
                strBl.Append(Constant.strHaredate);
                strBl.Append(Constant.strEAddress);
                strBl.Append(Constant.strECity);
                strBl.Append(Constant.strERegion);
                strBl.Append(Constant.strEPostlCode);
                strBl.Append(Constant.strECountry);
                strBl.Append(Constant.strEHmphn);
                strBl.Append(Constant.strEExtensn);
                strBl.Append(Constant.strENotes);
                strBl.Append(Constant.strEReportsTo);
                strBl.Append(Constant.strBuil3);
                strBl.Append(Constant.strBuil4);
                //strBl.Append(Constant.strBuil3);
                //strBl.Append(Constant.strBuil4);
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
      

        protected void chkSelect_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkAll = (CheckBox)gvEmpTer.HeaderRow.FindControl(Constant.strchkSelectAll);
            foreach (GridViewRow Row in gvEmpTer.Rows)
            {
                if (chkAll.Checked == true)                                  //CHECK IF CHECKBOX IS CHECKED OR NOT
                {
                    chkAll.Checked = false;                                  //CHANGE IT TO UNCHECKED
                }
            }

        }

        protected void chkSelectAll_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chkAll = ((CheckBox)gvEmpTer.HeaderRow.FindControl(Constant.strchkSelectAll));
            if (chkAll.Checked == true)
            {
                foreach (GridViewRow row in gvEmpTer.Rows)
                {
                    CheckBox chkSel = ((CheckBox)row.FindControl(Constant.strchkSelect)); //FINDING THE CHECK ITEM IN CHECKBOX IN EACH ROW OF GERIDVIEW
                    chkSel.Checked = true;
                }
            }
            else
            {
                foreach (GridViewRow row in gvEmpTer.Rows)
                {
                    CheckBox chkSel = ((CheckBox)row.FindControl(Constant.strchkSelect));
                    chkSel.Checked = false;
                }
            }

        }
        protected void gvEmpTer_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            SqlDataAdapter adapDA; StringBuilder strBl; string strCmd;  // declaration of object
            Common connObj;
            DataTable dtEmpT;
            // connObj.OpenConnection(); // Create New Sql Conn 
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
                    //connObj = null;
                    dtEmpT = null; strBl = null;
                    strCmd = null;
                }

            }

        }
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            ArrayList myArr;
            string strID = "";
            CheckBox chkDelete;
            int intID;
         
         try
         {
             myArr = new ArrayList();
             //Loop through GridView rows to find checked rows 
             for (int i = 0; i < gvEmpTer.Rows.Count; i++)
             {
                 chkDelete = (CheckBox)gvEmpTer.Rows[i].Cells[0].FindControl(Constant.strchkSelect);
                   
                 if (chkDelete != null)
                 {
                     if (chkDelete.Checked)
                     {
                         intID = Convert.ToInt32(gvEmpTer.DataKeys[i].Value);
                       // strID = gvEmpTer.Rows[i].Cells[1].Text;
                         strID = intID.ToString();
                         myArr.Add(strID);
                     }
                 }
             }
             if (myArr.Count == 0)
             {

                 lblDelete.Text = Constant.strPlsDelete;
                 lblDelete.Visible = true;

             }
             else
             {

                 DeleteMultipleRecords(myArr);         //Call the method to Delete records 
                 BindGrid();
             }
         }

         catch (Exception ex)
         {
             if (connObj.connC.State == System.Data.ConnectionState.Open)//if SqlConnection is not null then set object to null
             { connObj.connC.Close(); }//}connection close

             Response.Redirect(Constant.strCatcExceptn);                         
         }
         finally
         {
             myArr = null;
             chkDelete = null;
         }

           
        }
       
        /// This is to Delete multiple records in gridview
       private void DeleteMultipleRecords(ArrayList myArr)
                                   
        {
            connObj = new Common();
           // conn = new SqlConnection(objCon.strConn); // Create New Sql Conn  
            SqlCommand objSqlCommand = new SqlCommand();
          StringBuilder strB1 = new StringBuilder();
            SqlTransaction transaction;
            connObj = new Common();
            connObj.OpenConnection();
            transaction = connObj.connC.BeginTransaction();
            objSqlCommand.Connection = connObj.connC; 
            objSqlCommand.Transaction = transaction;                    //Define trasection   
            string IDs = "";
            foreach (string id in myArr)
            {
                IDs += id.ToString() + ",";
            }
            try
            {
                string strIDs =
                 IDs.Substring(0, IDs.LastIndexOf(","));
                //string strSql = "Delete from Employees WHERE EmployeeID in (" + strIDs + ")";
                strB1.Append(Constant.strqryDelete);
               // strB1.Append(" E ");
                strB1.Append(Constant.strBuil3);
                strB1.Append(Constant.strBuil4);
                strB1.Append(Constant.strBui20);
                strB1.Append(Constant.strEmpID2);
                strB1.Append(Constant.strIN);
                strB1.Append(" (" + strIDs + ") ");
                strB1.Append(Constant.strSemicolon);
                strB1.Append(Constant.strqryDelete);
               // strB1.Append(" EmployeeTerritories  ");
                strB1.Append(Constant.strBuil3);
                strB1.Append(Constant.strBuil8);
                strB1.Append(Constant.strBui20);
                strB1.Append(Constant.strEmpID2);
                strB1.Append(Constant.strIN);
                strB1.Append(" (" + strIDs + ") ");
              
                  objSqlCommand.CommandType = CommandType.Text;
                  objSqlCommand.CommandText = strB1.ToString();        //query put in SqlCommand
                  objSqlCommand.Connection = connObj.connC;
                if (connObj.connC.State == System.Data.ConnectionState.Closed)
                    connObj.OpenConnection();
                int i = objSqlCommand.ExecuteNonQuery();
                if (i > 0)
                {
                    lblDelete.Text = Constant.strDelete;
                    lblDelete.Visible = true;

                }
                transaction.Commit();
                if (connObj.connC.State == System.Data.ConnectionState.Open)
                {
                    connObj.connC.Close();                                                                   //CLOSE THE CONNECTION
                }
         }
           catch (SqlException ex)
            {
                transaction.Rollback();                        //if Trasection is not Successful then return back
                Response.Redirect(Constant.strCatcExceptn);
            }
            finally
            {
                connObj.CloseConnection();
                strB1 = null;
            }
        }

       protected void LbtnAdd_Click(object sender, EventArgs e)
       {
           Response.Redirect(Constant.strAddEmpterritory);

       }

       protected void LbtnEDIT_Click(object sender, EventArgs e)
       {
           int rdx = (((GridViewRow)(((LinkButton)(sender)).Parent.BindingContainer))).RowIndex;          //SELECTE ROW ON WHICH EVENT OCCUR
           // Row = (GridViewRow)gvEmpTer.Rows[rdx];
           int EmployeeID = int.Parse(gvEmpTer.DataKeys[rdx].Value.ToString());
           Session[Constant.strEmpid] = EmployeeID;                                                                //STORE VALUE IN SESSION
           Response.Redirect(Constant.strAddEmpterritory); 

       }
    }
    #endregion Del_EmpTer_dml
}

   
