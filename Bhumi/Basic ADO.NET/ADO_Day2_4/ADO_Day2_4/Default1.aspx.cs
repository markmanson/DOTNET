using System;
namespace ADO_Day2_4
{    
    /// <summary>
    /// Class Name:Default1
    /// Description: Gridview & session dataset
    /// author:bhumi
    /// </summary>
    public partial class Default1 : System.Web.UI.Page
    {
        Employees_TypedDataSetTableAdapters.EmployeesTableAdapter adapter;
        Employees_TypedDataSet dataset;
        ConstantMessages objconstmsg;
        #region Page Load Event
        /// <summary>
        /// Method Name: Page_Load
        /// Description:Concept of session dataset & Binding with GridView
        /// Author:bhumi
        /// created On:2/6/2015
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                objconstmsg = new ConstantMessages();                            
                dataset = new Employees_TypedDataSet();
                adapter = new Employees_TypedDataSetTableAdapters.EmployeesTableAdapter();
                adapter.Fill(dataset.Employees);
                //display data in gridview
                Session["Dataset_session"] = dataset.Employees;
                gvEmployees.DataSource = Session["Dataset_session"];
                gvEmployees.DataBind();
            }
            catch (Exception)
            {                
                Response.Redirect(objconstmsg.strerrorpage);
            }
            finally
            {
                dataset = null;
            }
        }
        #endregion
    }
}