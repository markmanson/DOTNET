using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Day_1_2
{
    #region WebUserCntrlTable
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- WebUserCntrlTable
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- THE CLASS FOR CONTROL FOR EMPLOYEE TABLE AND DEPARTMENT TABLE SHOW IN GRIDVIEW.
    //      CREATED DATE    :- 2012/12/09
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class WebUserCntrlTable : System.Web.UI.UserControl
    {
        #region Page_Load
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- Page_Load
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- THE METHOD FOR SHOWDATA AND MAKE GRIDVIEW VISIBLE TRUE.
        //      CREATED DATE    :- 2012/12/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        Common objCommon;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ShowData();                                          //CALL METHOD
                gvdEmp.Visible = true;                               //SHOW THE GRIDVIEW                                           
            }
        }
        #endregion Page_Load
        #region ShowData()
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- ShowData()
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- THE METHOD FOR SHOW EMPLOYEE TABLE AND DEPATMENT TABLE AND BIND IN GRIDVIEW .
        //      CREATED DATE    :- 2012/12/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        void ShowData()
        {
            SqlDataAdapter objAdapDA; DataSet ds; string strQuery;  // declaration of object
            try
            {
                objCommon = new Common();
                objCommon.OpenConnection();                             //open connection from common class object
                ds = new DataSet();                               //create object of typed data set
                strQuery = Constant.strControlstring;
                objAdapDA = new SqlDataAdapter(strQuery, objCommon.connC);             //pass connection and query into data adapter
                objAdapDA.Fill(ds);                                               //fill dataset from employee table
                gvdEmp.DataSource = ds;
                gvdEmp.DataBind();                                      //Bind data
            }
            catch (Exception)
            {
                Response.Redirect(Constant.strERRPAGE);          //throw exception on error page
            }
            finally                                                 //reallocate memory
            {
                objCommon.CloseConnection();
                objCommon = null;
                objAdapDA = null;
                strQuery = null;
            }
        }
        #endregion ShowData()
    }
    #endregion WebUserCntrlTable
}