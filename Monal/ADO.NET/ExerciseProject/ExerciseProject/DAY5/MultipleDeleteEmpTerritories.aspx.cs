﻿using System;
using System.Collections.Specialized;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI.WebControls;
using ExerciseProject.Class_File;

namespace ExerciseProject.Day5
{
    /// <summary>
        /// Name:MultipleDeleteEmpTerritories.aspx
        /// Description:"Add a page EmployeeTerritories.aspx to the project. 
        ///             Add a gridview control to the page and bind it to the EmployeeTerritories table of the typed dataset.
        ///             And perform add/update/delete"
        /// Author:Monal Shah
        /// Created Date:2010/10/05
        /// </summary>
    public partial class MultipleDeleteEmpTerritories : System.Web.UI.Page
    {
         Commonlogic objCl = new Commonlogic();//object of the commonlogic is created
        DataTable objDTable = new DataTable();
        EmployeeTerritories objEmpTerritories = new EmployeeTerritories();
        StringBuilder objSelect,objQuery;
        ConstantMessage objConstant=new ConstantMessage();
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description:"Add a gridview control to the page and bind it to the EmployeeTerritories table of the typed dataset"
        /// Author:Monal Shah
        /// Created Date:2010/10/05
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!IsPostBack)
            {
                LblErrorMessage.Visible= false;
                LnkAddNewUser.Visible = true;
                BindGrid();
            }
        }
        #endregion
        #region BindGrid
        /// <summary>
        /// Name:BindGrid
        /// Description:"Add a gridview control to the page and bind it to the EmployeeTerritories table of the typed dataset"
        /// Author:Monal Shah
        /// Created Date:2010/10/05
        /// </summary>
        public void BindGrid()
        {
            try
            {
                objSelect = new StringBuilder();
                objSelect.Append("SELECT ");
                objSelect.Append("EmployeeID");
                objSelect.Append(",");
                objSelect.Append("TitleOfCourtesy+' '+FirstName+' '+LastName As Name");
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
                objSelect.Append("From Employees");
               

                objCl.GetSqlStmt = objSelect.ToString();// "SELECT EmployeeID, TitleOfCourtesy + ' ' + FirstName + ' ' + LastName AS Name, Title,BirthDate,HireDate,Address,City,Region,PostalCode,Country,HomePhone,Extension,Notes,ReportsTo,PhotoPath from Employees";   //Territories.TerritoryDescription FROM Employees INNER JOIN EmployeeTerritories ON Employees.EmployeeID = EmployeeTerritories.EmployeeID INNER JOIN Territories ON EmployeeTerritories.TerritoryID = Territories.TerritoryID where Employees.EmployeeID='1'";
                objDTable = objCl.DataTables();
                if (objDTable.Rows.Count > 0)
                {
                    LblErrorMessage.Visible = false;
                    LnkAddNewUser.Visible = true;
                    this.GrdEmpTerritories.DataSource = objDTable;
                    this.GrdEmpTerritories.DataBind();//here binding data to gridview             

                   
                }
                else
                {
                    LblErrorMessage.Visible = true;
                    LblErrorMessage.Text = objConstant.NoTableRecordFound;
                    LnkAddNewUser.Visible = false;
                    BtnSelectAllCheckBox.Visible=false;
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
        #region HeaderCheckChanged
       /// <summary>
        /// Name:HeaderCheckChanged
        /// Description:"If header is checked then all checkbox of grid is checked"
        /// Author:Monal Shah
        /// Created Date:2010/10/06
        /// </summary>
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        protected void HeaderCheckChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)GrdEmpTerritories.HeaderRow.FindControl("ChkHeader");
            if (chk != null)
            {
                foreach (GridViewRow row in GrdEmpTerritories.Rows)
                {
                    CheckBox chkDelete = (CheckBox)row.FindControl("ChkChildValue");
                    if (chk.Checked == true)
                    {
                        chkDelete.Checked = true;

                    }

                    else
                    {
                        chkDelete.Checked = false;
                    }

                }
            }
        }
        #endregion
        #region ChildCheckChanged
        /// <summary>
        /// Name:ChildCheckChanged
        /// Description:"If child is checked then Header checkbox of grid is unchecked"
        /// Author:Monal Shah
        /// Created Date:2010/10/06
        /// </summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void ChildCheckChanged(object sender, EventArgs e)
        {
         
                foreach (GridViewRow row in GrdEmpTerritories.Rows)
                {
                    
                    CheckBox chkDelete = (CheckBox)row.FindControl("ChkChildValue");
                    if (chkDelete.Checked == true)
                    {
                        CheckBox chk = (CheckBox)GrdEmpTerritories.HeaderRow.FindControl("ChkHeader");
                        chk.Checked = false;

                    }

                   
                }
            
        }
        #endregion
        #region LnkEdit_Click
        /// <summary>
        /// Name:LnkEdit
        /// Description:in below code Linkbutton id value get stores the id value in session and page will be redirected.  
        /// Author:monal shah
        /// Created Date:2010/10/05
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        protected void LnkEdit_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow gvr = ((GridViewRow)((LinkButton)sender).Parent.Parent);//here Linkbutton value find
                string idValue = GrdEmpTerritories.DataKeys[gvr.RowIndex].Value.ToString();//here id value of clicked linkbutton will be gat
                if (idValue != null)
                {
                    SessionMethod.CurrentSession.EmployeeID = Convert.ToInt32(idValue);//store the id in session
                    Response.Redirect("EmployeeTerritoriesRegister.aspx", false);
                }
                else
                {
                    LblErrorMessage.Visible = true;
                    LblErrorMessage.Text = objConstant.NoIdValueFoundInControl;
                    LnkAddNewUser.Visible = false;
                }
                
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx", false);
            }

        }
        #endregion
        #region LnkDelete_Click
        /// <summary>
        /// Name:LnkDelete
        /// Description:In Below code get Id value of clicked linkbutton from gridview
        ///             Delete that particular row. 
        /// Author:monal shah
        /// Created Date:2010/10/05
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        protected void LnkDelete_Click(object sender, EventArgs e)
        {
            try
            {
                GridViewRow gvr = ((GridViewRow)((LinkButton)sender).Parent.Parent);//here Linkbutton value find
                string idValue = GrdEmpTerritories.DataKeys[gvr.RowIndex].Value.ToString();//here id value of clicked linkbutton will be gat
                if (idValue != null)
                {  
                    objEmpTerritories.EmpID = Convert.ToInt32(idValue);//set employee id value
                    objEmpTerritories.DeleteEmployeeTerritories().ToString();//Call method DeleteEmployee 
                    BindGrid();//Call bindgrid method
                }
                else
                {
                    LblErrorMessage.Visible = true;
                    LblErrorMessage.Text = objConstant.NoIdValueFoundInControl;
                    LnkAddNewUser.Visible = false;
                }
              
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx", false);
            }
        }
        #endregion
        #region LnkAddNewUser_Click
        /// <summary>
        /// Name:LnkAddNewUser
        /// Description:Redirect Page for new user
        /// Author:monal shah
        /// Created Date:2010/10/05
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        protected void LnkAddNewUser_Click(object sender, EventArgs e)
        {
            if (SessionMethod.CurrentSession.EmployeeID != 0)
            {
                SessionMethod.CurrentSession.EmployeeID = 0;
                Response.Redirect("EmployeeTerritoriesRegister.aspx", false);

            }
            else
            {
                Response.Redirect("EmployeeTerritoriesRegister.aspx", false);
            }
        }
        #endregion
        #region GrdEmpTerritories_RowDataBound
        /// <summary>
        /// Name:GrdEmpTerritories_RowDataBound
        /// Description:Bind the listbox
        /// Author:monal shah
        /// Created Date:2010/10/05
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>


        protected void GrdEmpTerritories_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            LblErrorMessage.Visible = false;
            LnkAddNewUser.Visible = true;
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string strEmployeeID = GrdEmpTerritories.DataKeys[e.Row.RowIndex].Values[0].ToString();
                ListBox LstListBox = (ListBox)e.Row.FindControl("LstTerritoryDescription");
                DataTable objDt = new DataTable();
                try
                {
                    objQuery = new StringBuilder();
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
                    objQuery.Append(strEmployeeID);
                    objQuery.Append("'");
                    objQuery.Append(")");

                    string strQuery = objQuery.ToString();
                    SqlDataAdapter adpapter = new SqlDataAdapter(strQuery, Commonlogic.GetConnectionString);
                    adpapter.Fill(objDt);
                    if (objDt.Rows.Count == 0)
                    {
                        LblErrorMessage.Visible = true;
                        LblErrorMessage.Text = objConstant.NoTableRecordFound;//"Datatable Does Not Contain Any Row";
                        LnkAddNewUser.Visible = false;

                    }
                    else
                    {
                        LnkAddNewUser.Visible = true;
                        LblErrorMessage.Visible = false;
                        LstListBox.DataSource = objDt;
                        LstListBox.DataBind();
                    }
                }
                catch (Exception)
                {
                    Response.Redirect("Error.aspx");
                }
                finally
                {
                    objDTable = null;
                    objDt = null;
                    objCl = null;
                    objQuery = null;
                }

            }

        }
        #endregion

        protected void GrdEmpTerritories_RowEditing(object sender, GridViewEditEventArgs e)
        {

        }

        #region BtnSelectAllCheckBox_Click
        /// <summary>
        /// Name:BtnSelectAllCheckBox_Click
        /// Description:Delete Selected records
        /// Author:monal shah
        /// Created Date:2010/10/05
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void BtnSelectAllCheckBox_Click(object sender, EventArgs e)
        {
            bool bolflag = false;
            int intIvalue = 0;
            string idValue = string.Empty;

            StringCollection sc = new StringCollection();
            try
            {
                foreach (GridViewRow row in GrdEmpTerritories.Rows)
                {

                    CheckBox chkDelete = (CheckBox)GrdEmpTerritories.HeaderRow.FindControl("ChkHeader");

                    if (chkDelete.Checked)
                    {
                        CheckBox chkChildDelete = (CheckBox)row.FindControl("ChkChildValue");
                        if (chkChildDelete != null)
                        {
                            if (chkChildDelete.Checked)
                            {
                                bolflag = true;
                            }
                        }
                        if (bolflag)
                        {
                            idValue = GrdEmpTerritories.DataKeys[row.RowIndex].Values[0].ToString();//[row.RowIndex].Value.ToString();
                            bolflag = false;
                            sc.Add(idValue);
                            intIvalue++;
                        }

                    }
                    else
                    {
                        CheckBox chkChildDelete = (CheckBox)row.FindControl("ChkChildValue");
                        if (chkChildDelete != null)
                        {
                            if (chkChildDelete.Checked)
                            {
                                bolflag = true;
                            }
                        }
                        if (bolflag)
                        {

                            idValue = GrdEmpTerritories.DataKeys[row.RowIndex].Values[0].ToString();//[row.RowIndex].Value.ToString();
                            bolflag = false;
                            sc.Add(idValue);
                            intIvalue++;
                        }

                    }
                }


                if (intIvalue > 0)
                {

                    objEmpTerritories.DeleteMultipleRecords(sc);//Call method DeleteMultipleRecords                  
                    Response.Redirect("MultipleDeleteEmpTerritories.aspx", false);
                }

            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
            finally
            {
                sc = null;
            }
        }
       
        #endregion



    }
}
