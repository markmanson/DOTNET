using System;
using System.Linq;
using System.Web.UI.WebControls;
using System.Data.Linq;
using System.Configuration;
using System.Data;
/// <summary>
/// NamespaceName:ASP_Day7_8
/// Description: Basic ASP.Net study
/// Author: Bhumi
/// Created On:25/6/2015
/// </summary>
namespace ASP_Day7_8
{
    /// <summary>
    /// Class Name:Employee_6
    /// Description:Sorting in Gridview
    /// Author:Bhumi
    /// Created On:25/6/2015
    /// </summary>
    public partial class Emp_Details7 : System.Web.UI.Page
    {
        DataTable dt_emp;
        ConstantMessages objconstant;
        DataContext Dtcontext;
        Table<EmployeeDetail> Emptbl;
        DataRow row;
        PagedDataSource pgd;
        string SortColumn;
        string SortParameter;
        #region Page Load
        /// <summary>
        /// Method Name:Page_Load
        /// Description:Default Binding of DataControls
        /// Author:Bhumi
        /// Created On:25/6/2015
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CurrentPageIndex = 0;//Set Default Value of Property
                ShowData();
            }
        }
        #endregion
        #region Binding Data In DataControls
        /// <summary>
        /// Method Name:ShowData
        /// Description:Datasource & Databinding with Control and set the Paging Feature code
        /// Author:Bhumi
        /// Created On:25/6/2015
        /// </summary>
        public void ShowData()
        {
            try
            {
                //Datacontext from LINQ Class
                Dtcontext = new DataContext(ConfigurationManager.ConnectionStrings["LINQ_ConnectionString"].ConnectionString);
                //Table from LINQ Class
                Emptbl = Dtcontext.GetTable<EmployeeDetail>();
                if (Emptbl == null)
                {
                    LblEmpty.Visible = true;//No Records 
                }
                else
                {
                    if (SortColumn == null || SortColumn == "--SELECT--")
                    {
                        dt_emp = new DataTable();
                        dt_emp.Columns.Add("Name");
                        dt_emp.Columns.Add("Address");
                        dt_emp.Columns.Add("Email");
                        dt_emp.Columns.Add("Salary");
                        var queryDefault = from i in Emptbl
                                           select new { i.Name, i.Address, i.Email, i.Salary };
                        foreach (var rowObj in queryDefault)
                        {
                            row = dt_emp.NewRow();
                            dt_emp.Rows.Add(rowObj.Name, rowObj.Address, rowObj.Email, rowObj.Salary);
                        }
                    }
                    else
                    {
                        if (SortColumn == "Name")
                        {
                            dt_emp = new DataTable();
                            dt_emp.Columns.Add("Name");
                            dt_emp.Columns.Add("Address");
                            dt_emp.Columns.Add("Email");
                            dt_emp.Columns.Add("Salary");
                            string SortVar = SortColumn;
                            var querySort = from i in Emptbl
                                            orderby i.Name ascending
                                            select new { i.Name, i.Address, i.Email, i.Salary };
                            // Create a table from the query.
                            foreach (var rowObj in querySort)
                            {
                                row = dt_emp.NewRow();
                                dt_emp.Rows.Add(rowObj.Name, rowObj.Address, rowObj.Email, rowObj.Salary);
                            }
                        }
                        if (SortColumn == "Address")
                        {
                            dt_emp = new DataTable();
                            dt_emp.Columns.Add("Name");
                            dt_emp.Columns.Add("Address");
                            dt_emp.Columns.Add("Email");
                            dt_emp.Columns.Add("Salary");
                            string SortVar = SortColumn;
                            var querySort = from i in Emptbl
                                            orderby i.Address ascending
                                            select new { i.Name, i.Address, i.Email, i.Salary };
                            // Create a table from the query.
                            foreach (var rowObj in querySort)
                            {
                                row = dt_emp.NewRow();
                                dt_emp.Rows.Add(rowObj.Name, rowObj.Address, rowObj.Email, rowObj.Salary);
                            }
                        }
                        if (SortColumn == "Email")
                        {
                            dt_emp = new DataTable();
                            dt_emp.Columns.Add("Name");
                            dt_emp.Columns.Add("Address");
                            dt_emp.Columns.Add("Email");
                            dt_emp.Columns.Add("Salary");
                            string SortVar = SortColumn;
                            var querySort = from i in Emptbl
                                            orderby i.Email ascending
                                            select new { i.Name, i.Address, i.Email, i.Salary };
                            // Create a table from the query.
                            foreach (var rowObj in querySort)
                            {
                                row = dt_emp.NewRow();
                                dt_emp.Rows.Add(rowObj.Name, rowObj.Address, rowObj.Email, rowObj.Salary);
                            }
                        }
                        if (SortColumn == "Salary")
                        {
                            dt_emp = new DataTable();
                            dt_emp.Columns.Add("Name");
                            dt_emp.Columns.Add("Address");
                            dt_emp.Columns.Add("Email");
                            dt_emp.Columns.Add("Salary");
                            string SortVar = SortColumn;
                            var querySort = from i in Emptbl
                                            orderby i.Salary ascending
                                            select new { i.Name, i.Address, i.Email, i.Salary };
                            // Create a table from the query.
                            foreach (var rowObj in querySort)
                            {
                                row = dt_emp.NewRow();
                                dt_emp.Rows.Add(rowObj.Name, rowObj.Address, rowObj.Email, rowObj.Salary);
                            }
                        }                        
                    }                    
                    //Code for Paging Facility For Data controls
                    pgd = new PagedDataSource();
                    //Datasource for page
                    pgd.DataSource = dt_emp.DefaultView;
                    pgd.CurrentPageIndex = CurrentPageIndex;//Assign Current Page Index
                    pgd.AllowPaging = true;
                    pgd.PageSize = 5;
                    //Enable Disable & Visible or not for Next Pre Buttons
                    LBtnNext.Enabled = !(pgd.IsLastPage);
                    if (!(pgd.IsLastPage))
                    {
                        LBtnNext.Visible = true;
                    }
                    if (pgd.IsFirstPage)
                    {
                        LBtnPre.Visible = false;
                    }                    
                    LBtnPre.Enabled = !(pgd.IsFirstPage);
                    if (!(pgd.IsFirstPage))
                    {
                        LBtnPre.Visible = true;
                    }
                    if (pgd.IsLastPage)
                    {
                        LBtnNext.Visible = false;
                    }
                    //Label Text for Total and Current Page
                    LblCurrent.Text = (CurrentPageIndex + 1).ToString();
                    LblTotal.Text = (pgd.PageCount).ToString();
                    //Databinding
                    RptEmpDetails.DataSource = pgd;
                    RptEmpDetails.DataBind();
                    DlEmpDetails.DataSource = pgd;
                    DlEmpDetails.DataBind();
                }                                
            }
            catch (Exception)
            {
                objconstant = new ConstantMessages();
                Response.Redirect(objconstant.strErrorPage);
            }
            finally
            {
                dt_emp = null;
                objconstant = null;
                Emptbl = null;
                row = null;
                pgd = null;
            }
        }
        #endregion
        #region Property For Getting Current Page Index
        /// <summary>
        /// Property Name:CurrentPageIndex
        /// Description:set & get Property Value after Increment or decrement
        /// Author:Bhumi
        /// Created On:25/6/2015
        /// </summary>
        public int CurrentPageIndex
        {
            //Set & Get Property after Decrement Or increment
            get
            {
                if (ViewState["pg"] == null)
                    return 0;
                else
                    return Convert.ToInt16(ViewState["pg"]);
            }
            set
            {
                ViewState["pg"] = value;
            }
        }
        #endregion
        #region Display Records Button Click event
        /// <summary>
        /// Method Name:BtnRecords_Click
        /// Description:Display Records After Sorting Parameter Selected by User
        /// Author:Bhumi
        /// Created On:25/6/2015
        /// </summary>
        protected void BtnRecords_Click(object sender, EventArgs e)
        {
            try
            {
                //Sorting According to Dropdownlist Selection
                //Datacontext from LINQ Class
                Dtcontext = new DataContext(ConfigurationManager.ConnectionStrings["LINQ_ConnectionString"].ConnectionString);
                //Table from LINQ Class
                Emptbl = Dtcontext.GetTable<EmployeeDetail>();
                //Store the value of Sorting Parameter Selected by User using Dropdownlist
                SortParameter = ddlSort.SelectedItem.Text;
                if (SortParameter == "Name")
                {
                    SortColumn = SortParameter;
                    ShowData();
                }
                else if (SortParameter == "Address")
                {
                    SortColumn = SortParameter;
                    ShowData();
                }
                else if (SortParameter == "Email")
                {
                    SortColumn = SortParameter;
                    ShowData();
                }
                else if (SortParameter == "Salary")
                {
                    SortColumn = SortParameter;
                    ShowData();
                }
                else
                {
                    objconstant = new ConstantMessages();
                    ClientScript.RegisterStartupScript(this.GetType(), "msgbox", "alert('" + objconstant.stralertSortBy + "');", true);
                }
            }
            catch (Exception)
            {
                objconstant = new ConstantMessages();
                Response.Redirect(objconstant.strErrorPage);
            }
            finally
            {
                dt_emp = null;
                objconstant = null;
                Emptbl = null;
                row = null;                
            }            
        }
        #endregion
        #region Paging Forward Direction
        /// <summary>
        /// Method Name:LBtnNext_Click
        /// Description:increment CurrentPageIndex Property 1 jump to Next page
        /// Author:Bhumi
        /// Created On:25/6/2015
        /// </summary>
        protected void LBtnNext_Click(object sender, EventArgs e)
        {
            CurrentPageIndex++;//Increment Property Value By 1 
            SortColumn = ddlSort.SelectedItem.Text;               
            ShowData();
        }
        #endregion
        #region Paging Backward Direction
        /// <summary>
        /// Method Name:LBtnPre_Click
        /// Description:Decrement CurrentPageIndex Property 1 jump to Previous page
        /// Author:Bhumi
        /// Created On:25/6/2015
        /// </summary>
        protected void LBtnPre_Click(object sender, EventArgs e)
        {
            CurrentPageIndex--;//Decrement Property Value By 1
            SortColumn = ddlSort.SelectedItem.Text;
            ShowData();
        }
        #endregion
    }
}