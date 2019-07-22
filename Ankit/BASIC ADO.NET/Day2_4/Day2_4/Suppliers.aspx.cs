using System;
using System.Collections;
namespace Day2_4
{
    /*******************************************************************************************************************
         NAME                               ::::                    SUPPLIER
         AUTHOR                             ::::                    ANKIT
         DATE                               ::::                    17-07-2012
         DESCRIPTION                        ::::                    TO DEFINE ALL THE CONSTANT VARIABLES
        *****************************************************************************************************************/
    #region Suppliers
    public partial class Suppliers : System.Web.UI.Page
    {        
        SupplierService objsupplier;                                            //DECLARATION OF OBJECT OF CLASS SUPPLIER SERVICE
        ArrayList lstSupp ;                                                     //DECLARATION OF ARRAYLIST
        #region Page_Load
        //FUNCTION PAGE_LOAD  ******************************************************************************************************
        protected void Page_Load(object sender, EventArgs e)
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
                        lblError.Visible = true;                                    //SHOW LABLE NAMED LBLERROR
                        lblError.Text = Constant.strSorry;                          //ASSIGN MESSEGE TO LABLE.TEXT
                    }
                }
                catch (Exception)                                                   //CATCH EXCEPTION IF ANY
                {
                    Response.Redirect("Error.aspx");                                //REDIRECT TO ERROR.ASPX IF AN EXCEPTION IS OCCURED 
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
#endregion Suppliers
}
