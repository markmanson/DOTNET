using System;
using System.Text;
using ExerciseProject.Class_File;

namespace ExerciseProject.DAY2
{
    /// <summary>
    /// Name:Default.aspx
    /// Description:""Add a typed dataset to the application and add the Employees and EmployeeTerritories tables to it.
    ///               Add code to populate this dataset when the Default.aspx page loads and store the dataset in session.
    ///               Bind the Employees table to the datagridview on the Default.aspx table."
    /// Author:Monal Shah
    /// Created Date:2010/09/21
    /// </summary>
    public partial class Default : System.Web.UI.Page
    {

        EmployeesDataset objEmpDataSet = new EmployeesDataset();//object of the typed dataset is created
        Commonlogic objCl = new Commonlogic();//object of the commonlogic is created
        StringBuilder objSelect;
        #region Page_Load
        /// <summary>
        /// Name:Page_Load
        /// Description:"Add code to fetch data from the Employees table and show it on the page in a datagridview.and store the typed dataset into session."
        /// Author:Monal Shah
        /// Created Date:2010/09/21
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    string strTable = "Employees";
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
                    string strQuery = objSelect.ToString();
                    objEmpDataSet = objCl.EmpDataSet(strQuery, strTable);//here EmpDataSet method is called with the table name
                    SessionMethod.CurrentSession.StoreTypedDataSet = objEmpDataSet;
                    // Session["DataSetSession"] = objEmpDataSet;//stores the dataset into session
                    this.GrdEmployee.DataSource = objEmpDataSet;
                    this.GrdEmployee.DataBind();//here binding data to gridview

                }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx",false);
              //  Response.Write("ERROR:" + exException.Message);
            }
            finally
            {
                objEmpDataSet = null;
                objCl = null;
            }
        }
        #endregion


    }
}
