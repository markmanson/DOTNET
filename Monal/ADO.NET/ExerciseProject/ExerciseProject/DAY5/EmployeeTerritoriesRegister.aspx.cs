using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using ExerciseProject.Class_File;
using System.Web.UI.WebControls;

namespace ExerciseProject.Day5
{
    ///Summary
    /// Name:EmployeeTerritoriesRegister.aspx
    /// Description:In this page insert and update delete the record of the employeeterritories
    /// table and also with validation
    /// Author:Monal Shah
    /// Created Date:2010/10/4
    /// summary
    public partial class EmployeeTerritoriesRegister : System.Web.UI.Page
    {
        Commonlogic objCl = new Commonlogic();//object of the commonlogic is created
        DataTable objDTable = new DataTable();//object of the datatable     
        EmployeeTerritories objEmpTerritories = new EmployeeTerritories();//object of the employeeInsert
        StringBuilder objSelect, sbInsertValue, sbInsertValueEmployee, objQuery, sbDeleteValue;
        string[] aryLstBoxValue;
        ListBox lstValue;
        ConstantMessage objConstant = new ConstantMessage();
        #region Page_Load
        /// <summary> 
        /// Name:Page_Load
        /// Description:Here in below code fetch data from employee territories table and disaplay in textbox.
        /// Author:Monal Shah
        /// Created Date:2010/10/4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
           
                if (!IsPostBack)
                {   
                    try
                    {
                        int intIdValue = SessionMethod.CurrentSession.EmployeeID;//fetch id value from session
                        //if id valueis '0'then btnSubmit.Text = "Insert" else  btnSubmit.Text = "Update"; 
                        //and setch data from table and display in textbox 

                        if (intIdValue == 0)
                        {
                            btnSubmit.Text = "Insert";
                            BindListBox();
                        }
                        else
                        {
                            btnSubmit.Text = "Update";
                            objSelect = new StringBuilder();
                            objSelect.Append("SELECT ");
                            objSelect.Append("EMP.EmployeeID");
                            objSelect.Append(",");
                            objSelect.Append("EMP.TitleOfCourtesy");
                            objSelect.Append(",");
                            objSelect.Append("EMP.FirstName");
                            objSelect.Append(",");
                            objSelect.Append("EMP.LastName");// As Name");
                            objSelect.Append(",");
                            objSelect.Append("EMP.Title");
                            objSelect.Append(",");
                            objSelect.Append("Convert(varchar,EMP.BirthDate,111) As BirthDate");
                            objSelect.Append(",");
                            objSelect.Append("Convert(varchar,EMP.HireDate,111) As HireDate");
                            objSelect.Append(",");
                            objSelect.Append("EMP.Address");
                            objSelect.Append(",");
                            objSelect.Append("EMP.City");
                            objSelect.Append(",");
                            objSelect.Append("EMP.Region");
                            objSelect.Append(",");
                            objSelect.Append("EMP.PostalCode");
                            objSelect.Append(",");
                            objSelect.Append("EMP.Country");
                            objSelect.Append(",");
                            objSelect.Append("EMP.HomePhone");
                            objSelect.Append(",");
                            objSelect.Append("EMP.Extension");
                            objSelect.Append(",");
                            objSelect.Append("EMP.ReportsTo");
                            objSelect.Append(",");
                            objSelect.Append("EMP.Notes");
                            objSelect.Append(",");
                            objSelect.Append("EMP.PhotoPath ");
                            objSelect.Append("From Employees EMP");
                            objSelect.Append(" Where ");
                            objSelect.Append("EMP.EmployeeId");
                            objSelect.Append("=");
                            objSelect.Append("'");
                            objSelect.Append(intIdValue);
                            objSelect.Append("'");

                            objCl.GetSqlStmt = objSelect.ToString();
                            objDTable = objCl.DataTables();

                            if (objDTable.Rows.Count > 0)
                            {
                                DdlSalutation.Enabled = false;
                                TxtBdate.Enabled = false;
                                BtnCal1.Enabled = false;
                                TxtLname.Text = Convert.ToString(objDTable.Rows[0]["LastName"]);
                                TxtFname.Text = Convert.ToString(objDTable.Rows[0]["FirstName"]);
                                TxtTitle.Text = Convert.ToString(objDTable.Rows[0]["Title"]);
                                DdlSalutation.SelectedItem.Text = Convert.ToString(objDTable.Rows[0]["TitleOfCourtesy"]);
                                TxtBdate.Text = Convert.ToString(objDTable.Rows[0]["BirthDate"]);
                                TxtHDate.Text = Convert.ToString(objDTable.Rows[0]["HireDate"]);
                                TxtAddress.Text = Convert.ToString(objDTable.Rows[0]["Address"]);
                                TxtCity.Text = Convert.ToString(objDTable.Rows[0]["City"]);
                                TxtRegion.Text = Convert.ToString(objDTable.Rows[0]["Region"]);
                                TxtPostalCode.Text = Convert.ToString(objDTable.Rows[0]["PostalCode"]);
                                TxtCountry.Text = Convert.ToString(objDTable.Rows[0]["Country"]);
                                TxtHomePhone.Text = Convert.ToString(objDTable.Rows[0]["HomePhone"]);
                                TxtExtension.Text = Convert.ToString(objDTable.Rows[0]["Extension"]);
                                TxtNotes.Text = Convert.ToString(objDTable.Rows[0]["Notes"]);
                                TxtReportsTo.Text = Convert.ToString(objDTable.Rows[0]["ReportsTo"]);
                               
                                BindListBox();

                            }
                            else
                            {
                                LblErrorMessage.Text = objConstant.NoTableRecordFound;// "Datatable Does Not Contain Any Row";
                                


                            }
                        }
                    }
                    catch (Exception)
                    {
                        Response.Redirect("Error.aspx", false);
                    }
                    finally
                    {
                        objCl = null;
                        objDTable = null;
                        objSelect = null;
                    }
                }
            
        }
        #endregion

        #region BindListBox
        /// <summary>
        /// Name:BindListBox
        /// Description:"Add a gridview control to the page and bind it to the EmployeeTerritories table"
        /// Author:Monal Shah
        /// Created Date:2010/10/04
        /// </summary>
        public void BindListBox()
        {
            ValueOfListBox();
                try
                {

                    int intIdValue = SessionMethod.CurrentSession.EmployeeID;//fetch id value from session
                        //if id valueis '0'then btnSubmit.Text = "Insert" else  btnSubmit.Text = "Update"; 
                        //and setch data from table and display in textbox 
                                      
                        objSelect = new StringBuilder();
                        objSelect.Append("Select ");
                        objSelect.Append("DISTINCT ");
                        objSelect.Append("TerritoryDescription ");
                        objSelect.Append("From ");
                        objSelect.Append("Territories");
                        objCl.GetSqlStmt = objSelect.ToString();
                        objDTable = objCl.DataTables();
                        if (objDTable.Rows.Count == 0)
                        {
                            LblErrorMessage.Text = objConstant.NoTableRecordFound;// "Datatable Does Not Contain Any Row";

                        }
                        else
                        {
                            LblErrorMessage.Visible = false;
                            LstListBox.DataSource = objDTable;
                            LstListBox.DataBind();
                            for (int i = 0; i < LstListBox.Items.Count; i++)
                            {
                                for (int j = 0; j < lstValue.Items.Count; j++)
                                {
                                    if (LstListBox.Items[i].Equals(lstValue.Items[j]))
                                    {
                                        LstListBox.Items[i].Selected = true;
                                    }
                                }
                            }
                        }
                 
                    
                }
                catch (Exception)
                {
                    Response.Redirect("Error.aspx");
                }
                finally
                {
                    objSelect = null;
                    objDTable = null;
                    objCl = null;
                 
                }
           
        }
        #endregion
        public void ValueOfListBox()
        {
            int intIdValue = SessionMethod.CurrentSession.EmployeeID;//fetch id value from session
            DataTable objDt = new DataTable();
            lstValue = new ListBox();
            lstValue.DataTextField = "TerritoryDescription";
            try
            {
                StringBuilder objQuery = new StringBuilder();
                objQuery.Append("Select ");
                objQuery.Append("TerritoryDescription ");
                objQuery.Append("From ");
                objQuery.Append("Territories ");
                objQuery.Append("where ");
                objQuery.Append("TerritoryID ");
                objQuery.Append("IN ");
                objQuery.Append("(");
                objQuery.Append("Select ");
                objQuery.Append("TerritoryID ");
                objQuery.Append("From ");
                objQuery.Append("EmployeeTerritories ");
                objQuery.Append("where ");
                objQuery.Append("EmployeeID");
                objQuery.Append("=");
                objQuery.Append("'");
                objQuery.Append(intIdValue);
                objQuery.Append("'");
                objQuery.Append(")");

                string strQuery = objQuery.ToString();
                SqlDataAdapter adpapter = new SqlDataAdapter(strQuery, Commonlogic.GetConnectionString);
                adpapter.Fill(objDt);
                if (objDt.Rows.Count == 0)
                {
                    LblErrorMessage.Text = objConstant.NoTableRecordFound;// "Datatable Does Not Contain Any Row";

                    //Response.Write(LblErrorMessage.Text);
                }
                else
                {
                    LblErrorMessage.Visible = false;
                    lstValue.DataSource = objDt;
                    lstValue.DataBind();
                    

                }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
         
           
        }

        
        #region btnSubmit_Click
        /// <summary>
        /// Name:btnSubmit_Click
        /// Description:Here in below code update row and also insert row 
        /// Author:Monal Shah
        /// Created Date:2010/10/4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
    
        protected void btnSubmit_Click(object sender, EventArgs e)
        { 
            int intIdValue = SessionMethod.CurrentSession.EmployeeID;
            try
            {
                if (intIdValue == 0)
                {

                    objEmpTerritories.LName = TxtLname.Text;
                    objEmpTerritories.FName = TxtFname.Text;
                    objEmpTerritories.Title = TxtTitle.Text;
                    if (DdlSalutation.SelectedIndex != 0)
                    {
                        objEmpTerritories.Salutation = DdlSalutation.SelectedItem.Value;
                    }
                    else
                    {
                        objEmpTerritories.Salutation = null;
                    }
                    objEmpTerritories.BirthDate = TxtBdate.Text;
                    objEmpTerritories.HireDate = TxtHDate.Text;
                    objEmpTerritories.Address = TxtAddress.Text;
                    objEmpTerritories.City = TxtCity.Text;
                    objEmpTerritories.Region = TxtRegion.Text;
                    objEmpTerritories.PostalCode = TxtPostalCode.Text;
                    objEmpTerritories.Country = TxtCountry.Text;
                    objEmpTerritories.Homephone = TxtHomePhone.Text;
                    objEmpTerritories.Extension = TxtExtension.Text;
                    objEmpTerritories.Notes = TxtNotes.Text;
                    if (TxtReportsTo.Text != "")
                    {
                        objEmpTerritories.ReportsTo = Convert.ToInt32(TxtReportsTo.Text);
                    }
                    else
                    {
                        objEmpTerritories.ReportsTo = Convert.ToInt32(null);
                    }
                    objEmpTerritories.InsertEmployeeTerritories().ToString();

                    for (int i = 0; i < LstListBox.Items.Count; i++)// in LstListBox.Items)
                    {
                        if (LstListBox.Items[i].Selected)
                        {
                            sbInsertValueEmployee = new StringBuilder();
                            sbInsertValueEmployee.Append("Select ");
                            sbInsertValueEmployee.Append("TOP ");
                            sbInsertValueEmployee.Append("1");
                            sbInsertValueEmployee.Append(" EmployeeID ");
                            sbInsertValueEmployee.Append("From ");
                            sbInsertValueEmployee.Append("Employees");
                            sbInsertValueEmployee.Append(" Order By");
                            sbInsertValueEmployee.Append(" EmployeeID ");
                            sbInsertValueEmployee.Append("DESC ");
                            objCl.GetSqlStmt = sbInsertValueEmployee.ToString();
                            objDTable = objCl.DataTables();
                            //string strquery = sbInsertValueEmployee.ToString();
                            //SqlDataAdapter adp = new SqlDataAdapter(strquery, Commonlogic.GetConnectionString);
                            //adp.Fill(dt);
                            if (objDTable.Rows.Count > 0)
                            {
                                objEmpTerritories.EmpID = Convert.ToInt32(objDTable.Rows[0]["EmployeeID"]);
                            }
                            else
                            {
                                LblErrorMessage.Text = objConstant.NoTableRecordFound;// "Datatable Does Not Contain Any Row";

                            }
                        }
                    }
                    ListBoxValues(objEmpTerritories.EmpID);
                    Response.Redirect("EmployeeTerritoriesGrid.aspx", false);
                }
                else
                {
                    objEmpTerritories.EmpID = intIdValue;
                    objEmpTerritories.LName = TxtLname.Text;
                    objEmpTerritories.FName = TxtFname.Text;
                    objEmpTerritories.Title = TxtTitle.Text;
                    objEmpTerritories.Salutation = DdlSalutation.SelectedItem.Value;
                    objEmpTerritories.HireDate = TxtHDate.Text;
                    objEmpTerritories.Address = TxtAddress.Text;
                    objEmpTerritories.City = TxtCity.Text;
                    objEmpTerritories.Region = TxtRegion.Text;
                    objEmpTerritories.PostalCode = TxtPostalCode.Text;
                    objEmpTerritories.Country = TxtCountry.Text;
                    objEmpTerritories.Homephone = TxtHomePhone.Text;
                    objEmpTerritories.Extension = TxtExtension.Text;
                    objEmpTerritories.Notes = TxtNotes.Text;
                    objEmpTerritories.ReportsTo = Convert.ToInt32(TxtReportsTo.Text);

                    sbDeleteValue = new StringBuilder();
                    sbDeleteValue.Append("DELETE ");
                    sbDeleteValue.Append("FROM ");
                    sbDeleteValue.Append("EmployeeTerritories ");
                    sbDeleteValue.Append("WHERE ");
                    sbDeleteValue.Append("EmployeeID");
                    sbDeleteValue.Append("=");
                    sbDeleteValue.Append("'");
                    sbDeleteValue.Append(intIdValue);
                    sbDeleteValue.Append("'");

                    objCl.GetSqlStmt = sbDeleteValue.ToString();//"Delete from EmployeeTerritories where EmployeeID='" + intIdValue + "'";
                    objCl.TransactionExecuteNonQuery();


                    ListBoxValues(intIdValue);

                    objEmpTerritories.UpdateEmployeeTerritories().ToString();
                    Response.Redirect("EmployeeTerritoriesGrid.aspx", false);

                }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx", false);
            }
            finally
            {
                objCl = null;
                sbInsertValue = null;
                sbInsertValueEmployee = null;
                aryLstBoxValue = null;
                objEmpTerritories = null;
            }

        }
        #endregion
        #region ListBoxValues
       /// <summary>
        /// Name:ListBoxValues
        /// Description:Fill the listbox with selected values andinsert into employeeterritories table
        /// Author:Monal Shah
        /// Created Date:2010/10/4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
       /// </summary>
       /// <param name="intId"></param>
    
        public void ListBoxValues(int intId)
        {
           // int intIdValue = SessionMethod.CurrentSession.EmployeeID;//fetch id value from session
            aryLstBoxValue = new string[LstListBox.Items.Count];
            for (int i = 0; i < LstListBox.Items.Count; i++)// in LstListBox.Items)
            {
                if (LstListBox.Items[i].Selected)
                {
                    objQuery = new StringBuilder();
                    objQuery.Append("Select ");
                    objQuery.Append("TerritoryID ");
                    objQuery.Append("From ");
                    objQuery.Append("Territories ");
                    objQuery.Append("where ");
                    objQuery.Append("TerritoryDescription");
                    objQuery.Append("=");
                    objQuery.Append("'");
                    objQuery.Append(LstListBox.Items[i].Text);
                    objQuery.Append("'");

                   string s = objQuery.ToString();//"Select TerritoryID from Territories where TerritoryDescription ='" + LstListBox.Items[i].Text + "'";
                   SqlDataAdapter adp = new SqlDataAdapter(s, Commonlogic.GetConnectionString);
                    objDTable = new DataTable();
                    adp.Fill(objDTable);
                    //objDTable = objCl.DataTables();
                    if (objDTable.Rows.Count > 0)
                    {
                        for (int j = 0; j < objDTable.Rows.Count; j++)
                        {
                            aryLstBoxValue[i] = objDTable.Rows[j]["TerritoryID"].ToString();
                        }
                    }
                    else
                    {
                        LblErrorMessage.Text = objConstant.NoTableRecordFound;// "Datatable Does Not Contain Any Row";

                    }
                       
                }
            }
            for (int i = 0; i < LstListBox.Items.Count; i++)
            {
                if (aryLstBoxValue[i] != null)
                {
                    sbInsertValue = new StringBuilder();
                    sbInsertValue.Append("Insert ");
                    sbInsertValue.Append("Into ");
                    sbInsertValue.Append("EmployeeTerritories ");
                    sbInsertValue.Append("values");
                    sbInsertValue.Append("(");
                    sbInsertValue.Append("'");
                    sbInsertValue.Append(intId);
                    sbInsertValue.Append("'");
                    sbInsertValue.Append(",");
                    sbInsertValue.Append("'");
                    sbInsertValue.Append(aryLstBoxValue[i]);
                    sbInsertValue.Append("'");
                    sbInsertValue.Append(")");
                    objCl.GetSqlStmt = sbInsertValue.ToString();
                    objCl.ExecuteNonQuery();
                }
            }
        }
        #endregion
        #region btnReset_Click
        /// <summary>
        /// Name:btnReset_Click
        /// Description:Here in below code all the controls are Reset 
        /// Author:Monal Shah
        /// Created Date:2010/10/4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnReset_Click(object sender, EventArgs e)
        {
            TxtLname.Text = "";
            TxtFname.Text = "";
            TxtTitle.Text = "";
            DdlSalutation.Enabled = true;
            DdlSalutation.SelectedItem.Text = "Select";
            TxtBdate.Text = "";
            Cal1.Visible = false;
            Cal2.Visible = false;
            BtnCal1.Enabled = true;
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
            for (int intI = 0; intI < LstListBox.Items.Count; intI++)
            {
                LstListBox.Items[intI].Selected = false;
            }
           
        }
        #endregion
        #region BtnCal1_Click
        /// <summary>
        /// Name:BtnCal1_Click
        /// Description:Calender is visible
        /// Author:Monal Shah
        /// Created Date:2010/10/4
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
        /// Name:BtnCal2_Click
        /// Description:Calender is visible
        /// Author:Monal Shah
        /// Created Date:2010/09/30
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnCal2_Click(object sender, EventArgs e)
        {
            Cal2.Visible = true;
        }
        #endregion
        #region Cal1_SelectionChanged
        /// <summary>
        /// Name:Cal1_SelectionChanged
        /// Description:Here in below code date and time value fetch 
        /// Author:Monal Shah
        /// Created Date:2010/10/4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Cal1_SelectionChanged(object sender, EventArgs e)
        {
            TxtBdate.Text = Cal1.SelectedDate.Date.ToString();
            Cal1.Visible = false;
        }
        #endregion
        #region Cal2_SelectionChanged
        /// <summary>
        /// Name:Cal2_SelectionChanged
        /// Description:Here in below code date and time value fetch 
        /// Author:Monal Shah
        /// Created Date:2010/10/4
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Cal2_SelectionChanged(object sender, EventArgs e)
        {
            TxtHDate.Text = Cal2.SelectedDate.Date.ToString();
            Cal2.Visible = false;
        }
        #endregion
    }
}
