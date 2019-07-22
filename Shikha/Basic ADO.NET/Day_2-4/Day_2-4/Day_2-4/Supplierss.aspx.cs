using System;
using System.Collections;

namespace Day_2_4
{
    // NAME              :-  Supplierss
    // AUTHOR NAME       :-  SHIKHA MALIK
    // DECRIPTION        :-  Class for add supplier information
    // CREATED DATE      :-  31/07/2012
    public partial class Supplierss : System.Web.UI.Page
    {
        SupplierService objsupplier;                                            //DECLARATION OF OBJECT OF CLASS SUPPLIER SERVICE
        ArrayList lstSupp;                                                     //DECLARATION OF ARRAYLIST
        #region Page_Load

        protected void Page_Load(object sender, EventArgs e)                //FUNCTION PAGE_LOAD
        {
            if (!IsPostBack)
            {
                try
                {
                    lstSupp = new ArrayList();                                      //INITIALIZATION OF ARRAYLIST
                    objsupplier = new SupplierService();                            //INITIALIZATION OF OBJECT OF SUPPLIERSERVICE
                    lstSupp = objsupplier.GetSuppliers();                           //CALL THE FUNCTION GETSUPPLIER OF CLASS 
                    gvSuppliers.DataSource = lstSupp;                               //ASSIGN ARRAYLIST TO GRIDVIEW
                    gvSuppliers.DataBind();                                         //BIND THE DATA IN GRIDVIEW
                    if (gvSuppliers.Rows.Count == 0)                                //CHECK IF GRIDVIEW HAS DATA
                    {
                        lblError.Visible = true;                                    
                        lblError.Text = Constant.strNotFound;                          //ASSIGN MESSEGE TO LABLE.TEXT
                    }
                }
                catch (Exception)                                                   //CATCH EXCEPTION 
                {
                    Response.Redirect(Constant.strCatcExceptn);                                
                }
                finally
                {
                    objsupplier = null;                                             //DESTROYING THE OBJECT OF SUPPLIERSERVICE
                    lstSupp = null;                                                 //ASSIGN NULL TO ARRAYLIST
                }
            }
        }
        #endregion Page_Load
    }
}
