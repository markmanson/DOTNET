using System;
using System.Collections;

namespace ExerciseProject.DAY2
{
    /// <summary>
    /// Name:Supplier
    /// Description:All the supplier values are fetch from the Supplier table and bind grid with arraylist 
    /// Author:Monal Shah
    /// Created date:2010/09/24
    /// </summary>
    public partial class Supplier : System.Web.UI.Page
    {
        SupplierServices objsupplierServices = new SupplierServices();
        ArrayList objAryList = new ArrayList();

        #region Page_Load
        /// <summary>
        /// Name:Page_load
        /// Description:All the supplier values are fetch from the Supplier table and bind grid with arraylist 
        /// Author:Monal Shah
        /// Created date:2010/09/24
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid();//Call Bindgrid function
            }
        }
        #endregion
        #region BindGrid
        /// <summary>
        /// Name:Bindgrid
        /// Description:Bind Grid with employee details 
        /// Author:monal shah
        /// Created Date:2010/09/23
        /// </summary>
        public void BindGrid()
        {
            try
            {
                objAryList = objsupplierServices.Getsuppliers();//call the getsuppliers method of class Supplierservices
                this.GrdSupplier.DataSource = objAryList;
                this.GrdSupplier.DataBind();//Binding grid
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx", false);
            }
            finally
            {
                objAryList = null;
            }
        }
        #endregion
    }
}
