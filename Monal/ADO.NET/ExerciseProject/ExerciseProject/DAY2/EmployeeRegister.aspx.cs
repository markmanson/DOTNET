using System;
using System.Data;
using System.Text;
using ExerciseProject.Class_File;

namespace ExerciseProject
{
    ///Summary
    /// Name:EmployeeRegister.aspx
    /// Description:In this page insert and update delete the record of the employees table
    /// Author:Monal Shah
    /// Created Date:2010/09/20
    /// summary
    public partial class EmployeeRegister : System.Web.UI.Page
    {
       
        EmployeesDataset objEmpDataSet = new EmployeesDataset();//object of the typed dataset is created
        Commonlogic objCl = new Commonlogic();//object of the commonlogic is created
        DataTable objDTable = new DataTable();//object of the datatable
        EmployeeInsert objEmp = new EmployeeInsert();//object of the employeeInsert
        StringBuilder objSelect;
        #region Page_Load
        /// <summary> 
        /// Name:Page_Load
        /// Description:Here in below code fetch data from employees table and disaplay in textbox.
        /// Author:Monal Shah
        /// Created Date:2010/09/21
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
                    }
                    else
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
                        objSelect.Append("LastName");// As Name");
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
                        objSelect.Append("Where ");
                        objSelect.Append("EmployeeId");
                        objSelect.Append("=");
                        objSelect.Append("'");
                        objSelect.Append(intIdValue);
                        objSelect.Append("'");
                        string strQuery = objSelect.ToString();
                        objCl.GetSqlStmt = strQuery;
                        objDTable = objCl.DataTables();
                        if (objDTable.Rows.Count > 0)
                        {
                            DdlSalutation.Enabled = false;
                            TxtBdate.Enabled = false;
                            BtnCal1.Enabled = false;
                            TxtLname.Text = objDTable.Rows[0]["LastName"].ToString();
                            TxtFname.Text = objDTable.Rows[0]["FirstName"].ToString();
                            TxtTitle.Text = objDTable.Rows[0]["Title"].ToString();
                            DdlSalutation.SelectedItem.Text = objDTable.Rows[0]["TitleOfCourtesy"].ToString();
                            TxtBdate.Text = objDTable.Rows[0]["BirthDate"].ToString();
                            TxtHDate.Text = objDTable.Rows[0]["HireDate"].ToString();
                            TxtAddress.Text = objDTable.Rows[0]["Address"].ToString();
                            TxtCity.Text = objDTable.Rows[0]["City"].ToString();
                            TxtRegion.Text = objDTable.Rows[0]["Region"].ToString();
                            TxtPostalCode.Text = objDTable.Rows[0]["PostalCode"].ToString();
                            TxtCountry.Text = objDTable.Rows[0]["Country"].ToString();
                            TxtHomePhone.Text = objDTable.Rows[0]["HomePhone"].ToString();
                            TxtExtension.Text = objDTable.Rows[0]["Extension"].ToString();
                            TxtNotes.Text = objDTable.Rows[0]["Notes"].ToString();
                            TxtReportsTo.Text = objDTable.Rows[0]["ReportsTo"].ToString();
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
        /// Name:btnSubmit_Click
        /// Description:Here in below code update row and also insert row 
        /// Author:Monal Shah
        /// Created Date:2010/09/21
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
                        objEmp.LName = TxtLname.Text;
                        objEmp.FName = TxtFname.Text;
                        objEmp.Title = TxtTitle.Text;
                        objEmp.Salutation = DdlSalutation.SelectedItem.Value;
                        objEmp.BirthDate = TxtBdate.Text;
                        objEmp.HireDate = TxtHDate.Text;
                        objEmp.Address = TxtAddress.Text;
                        objEmp.City = TxtCity.Text;
                        objEmp.Region = TxtRegion.Text;
                        objEmp.PostalCode = TxtPostalCode.Text;
                        objEmp.Country = TxtCountry.Text;
                        objEmp.Homephone = TxtHomePhone.Text;
                        objEmp.Extension = TxtExtension.Text;
                        objEmp.Notes = TxtNotes.Text;
                        objEmp.ReportsTo = Convert.ToInt32(TxtReportsTo.Text);
                        objEmp.InsertEmployee().ToString();
                        Response.Redirect("DMLoperationInEmployee.aspx", false);
                    }
                    else
                    {
                        objEmp.EmpID = intIdValue;
                        objEmp.LName = TxtLname.Text;
                        objEmp.FName = TxtFname.Text;
                        objEmp.Title = TxtTitle.Text;
                        objEmp.Salutation = DdlSalutation.SelectedItem.Value;
                        objEmp.HireDate =TxtHDate.Text;
                        objEmp.Address = TxtAddress.Text;
                        objEmp.City = TxtCity.Text;
                        objEmp.Region = TxtRegion.Text;
                        objEmp.PostalCode = TxtPostalCode.Text;
                        objEmp.Country = TxtCountry.Text;
                        objEmp.Homephone = TxtHomePhone.Text;
                        objEmp.Extension = TxtExtension.Text;
                        objEmp.Notes = TxtNotes.Text;
                        objEmp.ReportsTo = Convert.ToInt32(TxtReportsTo.Text);
                        objEmp.UpdateEmployee().ToString();
                        Response.Redirect("DMLoperationInEmployee.aspx",false);
                    }
                }
                catch (Exception)
                {
                    Response.Redirect("Error.aspx",false);
                }
           
        }
        #endregion
        #region btnReset_Click
        /// <summary>
        /// Name:btnReset_Click
        /// Description:Here in below code all the controls are Reset 
        /// Author:Monal Shah
        /// Created Date:2010/09/21
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
        #region BtnCal1_Click
        /// <summary>
        /// Name:BtnCal1_Click
        /// Description:Calender is visible
        /// Author:Monal Shah
        /// Created Date:2010/09/21
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
        /// Created Date:2010/09/21
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
        /// Created Date:2010/09/21
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
        /// Created Date:2010/09/21
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
