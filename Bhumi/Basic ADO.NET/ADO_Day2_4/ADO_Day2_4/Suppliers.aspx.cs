using System;
using System.Collections;
namespace ADO_Day2_4
{
   
    /// <summary>
    /// Class Name:Suppliers
    /// Description:Display the values of properties of class in gridview using arraylist
    /// Author:bhumi
    /// </summary>
    public partial class Suppliers : System.Web.UI.Page
    {
        SupplierServices objsupplierservices;
        ArrayList arraylist;
        ConstantMessages objconstmsg;
        // datatable;
        #region Class Properties,Arraylist & Gridview
        /// <summary>
        /// Event Name:Page Load
        /// Description:databinding using class Properties
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                objsupplierservices = new SupplierServices();
                //give the return value(Arraylist) of Getsupplier Method to Datasource of Gridview
                arraylist=objsupplierservices.GetSuppliers();
                gnSuppliers.DataSource = arraylist;
                gnSuppliers.DataBind();//Bind data
            }
            catch (Exception)
            {
                objconstmsg = new ConstantMessages();
                Server.Transfer(objconstmsg.strerrorpage);
            }
            finally
            {
                objsupplierservices = null;
            }
        }
        #endregion
        #region PageIndex Change
        protected void GridView1_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            gnSuppliers.PageIndex = e.NewPageIndex;
            gnSuppliers.DataSource = arraylist;
            gnSuppliers.DataBind();//Bind data
        }
        #endregion

    }
}