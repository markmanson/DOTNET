using System;
using System.Data;
using System.Text;
using ExerciseProject.Class_File;

namespace ExerciseProject.Day5
{
    public partial class CustomerRegister : System.Web.UI.Page
    {
        Commonlogic objCl = new Commonlogic();//object of the commonlogic is created
        DataTable objDTable = new DataTable();//object of the datatable
        Customer objCustomer = new Customer();//object of the employeeInsert
        StringBuilder objSelect;
        ConstantMessage objConstant = new ConstantMessage();
        #region Page_Load
        /// <summary> 
        /// Name:Page_Load
        /// Description:Here in below code fetch data from Customers table and disaplay in textbox.
        /// Author:Monal Shah
        /// Created Date:2010/09/30
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            
             if (!IsPostBack)
            {
                LblErrorMessage.Visible = false;
                try
                {
                    string strIdValue = SessionMethod.CurrentSession.CustomerID;//fetch id value from session
                    //if id valueis '0'then btnSubmit.Text = "Insert" else  btnSubmit.Text = "Update"; 
                    //and setch data from table and display in textbox 
                    if (strIdValue == null)
                    {
                        btnSubmit.Text = "Insert";
                    }
                    else
                    {
                        btnSubmit.Text = "Update";
                        objSelect = new StringBuilder();
                        objSelect.Append("SELECT ");
                        objSelect.Append("CustomerID");
                        objSelect.Append(",");
                        objSelect.Append("CompanyName");
                        objSelect.Append(",");
                        objSelect.Append("ContactName");
                        objSelect.Append(",");
                        objSelect.Append("ContactTitle");
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
                        objSelect.Append("Phone");
                        objSelect.Append(",");
                        objSelect.Append("Fax ");
                        objSelect.Append("From Customers ");
                        objSelect.Append("Where ");
                        objSelect.Append("CustomerID=");
                        objSelect.Append("'");
                        objSelect.Append(strIdValue);
                        objSelect.Append("'");
                        objCl.GetSqlStmt = objSelect.ToString();
                        objDTable = objCl.DataTables();
                        if (objDTable.Rows.Count > 0)
                        {
                            TxtCompanyName.Text = objDTable.Rows[0]["CompanyName"].ToString();
                            TxtContactName.Text = objDTable.Rows[0]["ContactName"].ToString();
                            TxtContactTitle.Text = objDTable.Rows[0]["ContactTitle"].ToString();
                            TxtAddress.Text = objDTable.Rows[0]["Address"].ToString();
                            TxtCity.Text = objDTable.Rows[0]["City"].ToString();
                            TxtRegion.Text = objDTable.Rows[0]["Region"].ToString();
                            TxtPostalCode.Text = objDTable.Rows[0]["PostalCode"].ToString();
                            TxtCountry.Text = objDTable.Rows[0]["Country"].ToString();
                            TxtPhone.Text = objDTable.Rows[0]["Phone"].ToString();
                            TxtFax.Text = objDTable.Rows[0]["Fax"].ToString();
                        }
                        else
                        {
                            LblErrorMessage.Visible = true;
                            LblErrorMessage.Text = objConstant.NoTableRecordFound;// "Datatable Does Not Contain Any Row";
                            pnlPanelTable.Visible = false;                       
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
        /// Created Date:2010/09/30
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string strIdValue = SessionMethod.CurrentSession.CustomerID;
            try
            {
                if (strIdValue == null)
                {
                    objCustomer.CompanyName = TxtCompanyName.Text;
                    objCustomer.ContactName = TxtContactName.Text;
                    objCustomer.ContactTitle = TxtContactTitle.Text;
                    objCustomer.Address = TxtAddress.Text;
                    objCustomer.City = TxtCity.Text;
                    objCustomer.Region = TxtRegion.Text;
                    objCustomer.PostalCode = TxtPostalCode.Text;
                    objCustomer.Country = TxtCountry.Text;
                    objCustomer.phone = TxtPhone.Text;
                    objCustomer.Fax = TxtFax.Text;
                    objCustomer.CustomerID = objCustomer.CompanyName.Substring(0,5).ToUpper();
                    objCustomer.InsertCustomer().ToString();
                    Response.Redirect("CustomerGrid.aspx", false);
                }
                else
                {
                    objCustomer.CustomerID = strIdValue;
                    objCustomer.CompanyName = TxtCompanyName.Text;
                    objCustomer.ContactName = TxtContactName.Text;
                    objCustomer.ContactTitle = TxtContactTitle.Text;
                    objCustomer.Address = TxtAddress.Text;
                    objCustomer.City = TxtCity.Text;
                    objCustomer.Region = TxtRegion.Text;
                    objCustomer.PostalCode = TxtPostalCode.Text;
                    objCustomer.Country = TxtCountry.Text;
                    objCustomer.phone = TxtPhone.Text;
                    objCustomer.Fax = TxtFax.Text;

                    objCustomer.UpdateCustomer().ToString();
                    Response.Redirect("CustomerGrid.aspx", false);
                }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx", false);
            }
            finally
            {
                strIdValue = "";
            }

        }
        #endregion
        #region btnReset_Click
        /// <summary>
        /// Name:btnReset_Click
        /// Description:Here in below code all the controls are Reset 
        /// Author:Monal Shah
        /// Created Date:2010/09/30
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnReset_Click(object sender, EventArgs e)
        {
            TxtCompanyName.Text = "";
            TxtContactName.Text = "";
            TxtContactTitle.Text = "";
            TxtAddress.Text = "";
            TxtCity.Text = "";
            TxtRegion.Text = "";
            TxtPostalCode.Text = "";
            TxtCountry.Text = "";
            TxtPhone.Text = "";
            TxtFax.Text = "";
        }
        #endregion

    }
}
