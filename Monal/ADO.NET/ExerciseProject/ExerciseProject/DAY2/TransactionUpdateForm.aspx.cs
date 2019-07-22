using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using ExerciseProject.Class_File;

namespace ExerciseProject.DAY2
{
    /// <summary>
    ///Name:TransactionUpdateForm.aspx
    ///Description:Implement the Update data using sqltransaction in the gridview control for employees,
    ///              using the Typed Dataset.
    ///Author:monal shah
    ///Created Date:2010/09/23
    /// </summary>
    public partial class TransactionUpdateForm : System.Web.UI.Page
    {
        EmployeesDataset objEmpDataSet = new EmployeesDataset();//object of the typed dataset is created
        Commonlogic objCl = new Commonlogic();//object of the commonlogic is created
        DataTable objDTable = new DataTable();
        EmployeeInsert objEmp = new EmployeeInsert();
        SqlConnection objCon=new SqlConnection();
        SqlCommand objCmd;
        SqlTransaction objTransaction;
        SqlDataAdapter objAdp;
        SqlCommandBuilder objSqlBuilder;
        StringBuilder objSelect;    
        #region Page_Load
        /// <summary>
        ///Name:Page_Load
        ///Description:Fetch data from table and display in form and after that update the value of table's row.
        ///Author:monal shah
        ///Created Date:2010/09/23
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                string strTable = "Employees";
                int intIdValue = SessionMethod.CurrentSession.EmployeeID;
                try
                {
                    if (intIdValue != 0)
                    {
                        btnSubmit.Text = "Update";
                        objSelect = new StringBuilder();
                        objSelect.Append("SELECT ");
                        objSelect.Append("EmployeeID");
                        objSelect.Append(",");
                        objSelect.Append("TitleOfCourtesy");
                        objSelect.Append(",");
                        objSelect.Append("FirstName");
                        objSelect.Append(",");
                        objSelect.Append("LastName");
                        objSelect.Append(",");
                        objSelect.Append("Title");
                        objSelect.Append(",");
                        objSelect.Append("Convert(varchar,BirthDate,111) As BirthDate");
                        objSelect.Append(",");
                        objSelect.Append("Convert(varchar,HireDate,111) As HireDate");
                        objSelect.Append(",");
                        objSelect.Append("Address");
                        objSelect.Append(",");
                        objSelect.Append("City");
                        objSelect.Append(",");
                        objSelect.Append("Region");
                        objSelect.Append(",");
                        objSelect.Append("PostalCode");
                        objSelect.Append(",");
                        objSelect.Append("Country");
                        objSelect.Append(",");
                        objSelect.Append("HomePhone");
                        objSelect.Append(",");
                        objSelect.Append("Extension");
                        objSelect.Append(",");
                        objSelect.Append("ReportsTo");
                        objSelect.Append(",");
                        objSelect.Append("Notes");
                        objSelect.Append(",");
                        objSelect.Append("PhotoPath ");
                        objSelect.Append("From Employees ");
                        objSelect.Append("Where EmployeeID=");
                        objSelect.Append("'");
                        objSelect.Append(intIdValue);
                        objSelect.Append("'");
                        string strQuery = objSelect.ToString();
                        //string strQuery = "Select EmployeeID,LastName,FirstName," +
                        //                    "TitleOfCourtesy, Title,BirthDate," +
                        //                    "HireDate,Address, City, Region," +
                        //                    "PostalCode, Country, HomePhone," +
                        //                    "Extension, Photo, ReportsTo, Notes," +
                        //                    "PhotoPath FROM Employees where " +
                        //                    "EmployeeID='" + intIdValue + "'";
                        objEmpDataSet = objCl.EmpDataSet(strQuery, strTable);
                        //if datatable contains more than 0 value then the data
                        //will be fetch frm the table and display in form
                        if (objEmpDataSet.Tables[0].Rows.Count > 0)
                        {
                            DdlSalutation.Enabled = false;
                            TxtBdate.Enabled = false;
                            BtnCal1.Enabled = false;
                            TxtLname.Text = objEmpDataSet.Tables[0].Rows[0]["LastName"].ToString();
                            TxtFname.Text = objEmpDataSet.Tables[0].Rows[0]["FirstName"].ToString();
                            TxtTitle.Text = objEmpDataSet.Tables[0].Rows[0]["Title"].ToString();
                            DdlSalutation.SelectedItem.Text = objEmpDataSet.Tables[0].Rows[0]["TitleOfCourtesy"].ToString();
                            TxtBdate.Text = objEmpDataSet.Tables[0].Rows[0]["BirthDate"].ToString();
                            TxtHDate.Text = objEmpDataSet.Tables[0].Rows[0]["HireDate"].ToString();
                            TxtAddress.Text = objEmpDataSet.Tables[0].Rows[0]["Address"].ToString();
                            TxtCity.Text = objEmpDataSet.Tables[0].Rows[0]["City"].ToString();
                            TxtRegion.Text = objEmpDataSet.Tables[0].Rows[0]["Region"].ToString();
                            TxtPostalCode.Text = objEmpDataSet.Tables[0].Rows[0]["PostalCode"].ToString();
                            TxtCountry.Text = objEmpDataSet.Tables[0].Rows[0]["Country"].ToString();
                            TxtHomePhone.Text = objEmpDataSet.Tables[0].Rows[0]["HomePhone"].ToString();
                            TxtExtension.Text = objEmpDataSet.Tables[0].Rows[0]["Extension"].ToString();
                            TxtNotes.Text = objEmpDataSet.Tables[0].Rows[0]["Notes"].ToString();
                            TxtReportsTo.Text = objEmpDataSet.Tables[0].Rows[0]["ReportsTo"].ToString();
                        }

                    }
                }
                catch (Exception)
                {
                    Response.Redirect("Error.aspx", false);
                }
            }

        }
        #endregion
        #region btnSubmit_Click
        /// <summary>
        ///Name:btnSubmit_Click
        ///Description:In below code update the table row.
        ///Author:monal shah
        ///Created Date:2010/09/23
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            objCon.ConnectionString = Commonlogic.GetConnectionString;
           
            try
            {
             
                 int intIdValue = SessionMethod.CurrentSession.EmployeeID;//get the session value
                 if (intIdValue != 0)
                 {
                     string strQuery = "Select * from Employees";
                     objCmd = new SqlCommand();
                     if (objCon.State == ConnectionState.Closed)
                     {
                         objCon.Open();
                     }
                     objTransaction = objCon.BeginTransaction(IsolationLevel.ReadCommitted);
                     objCmd.Connection = objCon;
                     objCmd.CommandType = CommandType.Text;
                     objCmd.CommandText = strQuery;
                     objCmd.Transaction = objTransaction;
                     objAdp = new SqlDataAdapter(objCmd);
                     objAdp.MissingSchemaAction = MissingSchemaAction.AddWithKey;
                     objSqlBuilder = new SqlCommandBuilder(objAdp);
                     objAdp.Fill(objEmpDataSet, "Employees");
                     DataRow objRow = objEmpDataSet.Tables["Employees"].Rows.Find(intIdValue);
                     objRow["LastName"] = TxtLname.Text;
                     objRow["FirstName"] = TxtFname.Text;
                     objRow["Title"] = TxtTitle.Text;
                     objRow["HireDate"] = System.Convert.ToDateTime(TxtHDate.Text);
                     objRow["Address"] = TxtAddress.Text;
                     objRow["City"] = TxtCity.Text;
                     objRow["Region"] = TxtRegion.Text;
                     objRow["PostalCode"] = TxtPostalCode.Text;
                     objRow["Country"] = TxtCountry.Text;
                     objRow["HomePhone"] = TxtHomePhone.Text;
                     objRow["Extension"] = TxtExtension.Text;
                     objRow["Notes"] = TxtNotes.Text;
                     objRow["ReportsTo"] = Convert.ToInt32(TxtReportsTo.Text);
                     objAdp.Update(objEmpDataSet, "Employees");
                     objTransaction.Commit();
                     Response.Redirect("TransactionUpdate.aspx", false);
                 }
             }
             catch (Exception)
             {
                 objTransaction.Rollback();
                 Response.Redirect("Error.aspx",false);
             }
             finally
             {
                 objTransaction = null;
                 objCl = null;
                 objCmd.Dispose();
                 objAdp.Dispose();
                 objDTable = null;
                 objCon.Close();
             }
                                
            

        }
        #endregion
        #region Cal2_SelectionChanged
        /// <summary>
        ///Name:Cal2_SelectionChanged
        ///Description:In below code get the date value from the calender and assign to the textbox
        ///Author:monal shah
        ///Created Date:2010/09/23
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Cal2_SelectionChanged(object sender, EventArgs e)
        {
            TxtHDate.Text = Cal2.SelectedDate.Date.ToString();
            Cal2.Visible = false;
        }
        #endregion
        #region Cal1_SelectionChanged
        /// <summary>
        ///Name:Cal1_SelectionChanged
        ///Description:In below code get the date value from the calender and assign to the textbox
        ///Author:monal shah
        ///Created Date:2010/09/23
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Cal1_SelectionChanged(object sender, EventArgs e)
        {
            TxtBdate.Text = Cal1.SelectedDate.Date.ToString();
            Cal1.Visible = false;
        }
        #endregion
        #region BtnCal1_Click
        /// <summary>
        ///Name:BtnCal1_Click
        ///Description:In below code calender is visible
        ///Author:monal shah
        ///Created Date:2010/09/23
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnCal1_Click(object sender, EventArgs e)
        {
            Cal1.Visible = true;
        }
        #endregion
        #region BtnCal2_Click
        /// <summary>
        ///Name:BtnCal2_Click
        ///Description:In below code calender is visible
        ///Author:monal shah
        ///Created Date:2010/09/23
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnCal2_Click(object sender, EventArgs e)
        {
            Cal2.Visible = true;
        }
        #endregion
        #region btnReset_Click
        /// <summary>
        /// Name:btnReset_Click
        /// Description:Here in below code all the controls are Reset 
        /// Author:Monal Shah
        /// Created Date:2010/09/23
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnReset_Click(object sender, EventArgs e)
        {
            TxtLname.Text = "";
            TxtFname.Text = "";
            TxtTitle.Text = "";
            DdlSalutation.SelectedValue = "Select";
            TxtBdate.Text = "";
            TxtHDate.Text = "";
            TxtAddress.Text = "";
            TxtCity.Text = "";
            TxtRegion.Text = "";
            TxtPostalCode.Text = "";
            TxtCountry.Text = "";
            TxtHomePhone.Text = "";
            TxtExtension.Text = "";
            TxtNotes.Text = "";
            TxtReportsTo.Text = "";
        }
        #endregion
    }
}
