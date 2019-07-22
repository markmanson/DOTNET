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
/// Created On:24/6/2015
/// </summary>
namespace ASP_Day7_8
{
    /// <summary>
    /// Class Name:Employee_6
    /// Description:Sorting in Gridview
    /// Author:Bhumi
    /// Created On:24/6/2015
    /// </summary>            
    public partial class Employee_6 : System.Web.UI.Page
    {
        DataTable dt_emp = new DataTable();        
        ConstantMessages objconstant;
        DataContext Dtcontext;
        Table<EmployeeDetail> Emptbl;
        DataRow row;
        int columnIndex = 0;
        string _sortDirection;              
        #region Page Load
        /// <summary>
        /// Method Name:Page_Load
        /// Description:Sorting in Gridview using header row
        /// Author:Bhumi
        /// Created On:24/6/2015        
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (ViewState["Employeetable"] == null)
                {
                    //Datacontext from LINQ Class
                    Dtcontext = new DataContext(ConfigurationManager.ConnectionStrings["LINQ_ConnectionString"].ConnectionString);
                    //Table from LINQ Class
                    Emptbl = Dtcontext.GetTable<EmployeeDetail>();
                    
                    dt_emp.Columns.Add("Name");
                    dt_emp.Columns.Add("Address");
                    dt_emp.Columns.Add("Email");
                    dt_emp.Columns.Add("Salary",typeof(decimal));
                    var query = from i in Emptbl                                
                                select new { i.Name, i.Address, i.Email, i.Salary };
                    // Create a table from the query.
                    foreach (var rowObj in query)
                    {
                        row = dt_emp.NewRow();
                        dt_emp.Rows.Add(rowObj.Name, rowObj.Address, rowObj.Email, rowObj.Salary);
                    }
                    //Datasource and binding to Gridview
                    if (dt_emp == null)
                    {
                        LblEmpty.Visible = true;
                    }
                    else
                    {
                        gvEmployeeDetails.DataSource = dt_emp;
                        gvEmployeeDetails.DataBind();
                        ViewState["Employeetable"] = dt_emp;
                    }
                }                
            }
            catch (Exception)
            {
                objconstant = new ConstantMessages();
                Response.Redirect(objconstant.strErrorPage);
            }
            finally
            {
                objconstant = null;
            }
         }
        #endregion        
        #region Paging in Gridview
        /// <summary>
        /// Method Name:gvEmployeeDetails_PageIndexChanging
        /// Description: Index Change of Page in Gridview
        /// Author:Bhumi
        /// Created On:24/6/2015                
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvEmployeeDetails_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {            
            if (ViewState["SearchSort"] == null)
            {
                gvEmployeeDetails.DataSource = ViewState["Employeetable"];
                gvEmployeeDetails.PageIndex = e.NewPageIndex;
                gvEmployeeDetails.DataBind(); //bind data
            }
            else
            {
                DataTable SearchDT = ((DataTable)ViewState["Employeetable"]);
                SearchDT.DefaultView.Sort = ViewState["SearchSort"].ToString() + " " + ViewState["SortDirection"].ToString();
                gvEmployeeDetails.DataSource = SearchDT;
                gvEmployeeDetails.PageIndex = e.NewPageIndex;
                gvEmployeeDetails.DataBind(); //bind data                
                if (ViewState["SortDirection"].ToString() == "ASC")
                {
                    _sortDirection = "ASC";
                    sortImage.ImageUrl = "~/Images/Downarrow.png";
                }
                if (ViewState["SortDirection"].ToString() == "DESC")
                {
                    _sortDirection = "DESC";
                    sortImage.ImageUrl = "~/Images/uparrow.png";
                }            
                foreach (DataControlFieldHeaderCell headerCell in gvEmployeeDetails.HeaderRow.Cells)
                {
                    if (headerCell.ContainingField.SortExpression == ViewState["SearchSort"].ToString())
                    {
                        columnIndex = gvEmployeeDetails.HeaderRow.Cells.GetCellIndex(headerCell);
                    }
                }
                gvEmployeeDetails.HeaderRow.Cells[columnIndex].Controls.Add(sortImage);//ADD Image on Header Cell  
            }            
        }
        #endregion        
        #region Sort Gridview
        /// <summary>
        /// Method Name:gvEmployeeDetails_Sorting
        /// Description:Sorting in Gridview
        /// Author:Bhumi
        /// Created On:24/6/2015                         
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void gvEmployeeDetails_Sorting(object sender, GridViewSortEventArgs e)
        {
            try
            {                
                string SortDireaction = ViewState["_sortDirection"] as string;//Store Sorting Operation in Viewstate
                SetSortDirection(SortDireaction);//Call Method
                if (ViewState["Employeetable"] != null)
                {
                    //Sort the data.
                    dt_emp = ((DataTable)ViewState["Employeetable"]);
                    dt_emp.DefaultView.Sort = e.SortExpression + " " + _sortDirection;
                    gvEmployeeDetails.DataSource = dt_emp;
                    gvEmployeeDetails.DataBind();
                    SortDireaction = _sortDirection;
                    ViewState["_sortDirection"] = SortDireaction;
                    //Checking the HeaderRow Cells where to put sorting image
                    foreach (DataControlFieldHeaderCell headerCell in gvEmployeeDetails.HeaderRow.Cells)
                    {
                        if (headerCell.ContainingField.SortExpression == e.SortExpression)
                        {
                            columnIndex = gvEmployeeDetails.HeaderRow.Cells.GetCellIndex(headerCell);
                        }
                    }
                    gvEmployeeDetails.HeaderRow.Cells[columnIndex].Controls.Add(sortImage);//ADD Image on Header Cell                       
                    string sortExpression = e.SortExpression;
                    ViewState["SearchSort"] = sortExpression;
                    ViewState["SortDirection"] = _sortDirection;
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
            }
        }
        #endregion
        #region SortDirection Checking
        /// <summary>
        /// Method Name:SetSortDirection
        /// Description:Check the SortDirection ans Select the Image
        /// Author:Bhumi
        /// Created On:24/6/2015                         
        /// </summary>
        Image sortImage = new Image();
        protected void SetSortDirection(string sortDirection)
        {
            if (sortDirection == "ASC")
            {
                _sortDirection = "DESC";
                sortImage.ImageUrl = "~/Images/uparrow.png";
            }
            else
            {
                _sortDirection = "ASC";
                sortImage.ImageUrl = "~/Images/Downarrow.png";
            }            
        }
        #endregion
    }
}