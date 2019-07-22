using System;
/// <summary>
///NameSpace:ADO_Day2_4
/// Description://ADO.Net Day2 to Day4
/// Author:bhumi
/// Created On:29/5/2015
/// </summary>
namespace ADO_Day2_4
{
    /// <summary>
    /// Class Name:Default
    /// Description: Gridview & session dataset
    /// author:bhumi
    /// </summary>
    public partial class Default : System.Web.UI.Page
    {        
        Employees_TypedDataSetTableAdapters.EmployeesTableAdapter adapter;
        Employees_TypedDataSet dataset; 
        ConstantMessages objconstmsg;
        #region PageLoad Event
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
                //Typed Dataset & its TableAdapter
                dataset = new Employees_TypedDataSet();
                adapter = new Employees_TypedDataSetTableAdapters.EmployeesTableAdapter();
                //fill the daset with specific table
                adapter.Fill(dataset.Employees);                                
                //display data in gridview
                Session["Dataset_session"] = dataset.Employees;
                gvEmployees.DataSource = Session["Dataset_session"];
                gvEmployees.DataBind();
            }
            catch (Exception)
            {
                objconstmsg = new ConstantMessages();        
                Response.Redirect(objconstmsg.strerrorpage);
            }
            finally
            {
                adapter = null;
                dataset = null;
            }
        }
        #endregion
    }
}