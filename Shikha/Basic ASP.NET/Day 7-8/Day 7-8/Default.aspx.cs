using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI.WebControls;

namespace Day_7_8
{
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- _Default
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- The Class For bind Data and sort   .
    //      CREATED DATE    :- 2012/02/09
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class _Default : System.Web.UI.Page
    {
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- SortOrder
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- SORT ORDER PROPERTY.
        //      CREATED DATE    :- 2012/02/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        public enum SortOrder
        {
            Ascending = 0,
            Descending = 1
        }
        private SortOrder currentSortOrder;                             //DECLARATION OF THE OBJECT OF SORTORDER
        private string currentSortColumn;                               //DECLARATION OF THE STRING
        Common objcommon;                              //DECLARATION OF THE OBJECT OF CLASS COMMON
        #region Page_Load

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)                                                        //CHECK IF POSTBACK
            {
                currentSortOrder = SortOrder.Ascending;                             //ASSIGN THE VALUE TO CURRENTSORTORDER
                currentSortColumn = string.Empty;                                   //INITIALIZE THE STRING
                BindData();                                                         //CALL THE FUNCTION BINDDATA()
            }
            else
            {
                this.currentSortOrder = (SortOrder)ViewState[Constant.strSORTORDER];          //ASSIGN THE VALUE TO CURRENT SORT ORDER
                this.currentSortColumn = ViewState[Constant.strSORTCOL].ToString();           //ASSIGN THE VALUE TO CURRENT SORT COLUMN
            }
        }
        #endregion Page_Load
        protected void Page_PreRender(object sender, EventArgs e)
        {
            ViewState[Constant.strSORTORDER] = currentSortOrder;                              //ASSIGN THE VALUE TO VIEW STATE
            ViewState[Constant.strSORTCOL] = currentSortColumn;                               //ASSIGN THE VALUE TO VIEW STATE
            PosPic(gvEmp, currentSortOrder, currentSortColumn);                               //CALL THE FUNCTION TO PLACE THE IMAGE
        }
        #region BindData
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- BindData
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- METHOD FOR BIND DATA.
        //      CREATED DATE    :- 2012/02/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        public void BindData()
        {
            StringBuilder strBuild;                                                            //DECLARATION FOR OBJECT OF STRING BUILDER
            DataSet dsEmp;                                                                     //DECLARATION FOR OBJECT OF DATASET
            SqlDataAdapter objAdpt;                                                               //DECLARATION FOR OBJECT OF SQLDATAADOPTER         
            try
            {
                objcommon = new Common();  
                dsEmp = new DataSet();                                                         //INITIALIZATION OF DATASET
                //INITIALIZATION OF SQLCONNECTION ********************************************************************************
                objcommon.OpenConnection();                                                          //CALL THE FUNCTION TO OPEN THE DATABASE
                strBuild = new StringBuilder();                                                //INITIALIZATION OF STRING BUILDER
                strBuild.Append(Constant.strSELECTEMP);                                           //APPENDING THE STRING BUILDER    
                if (Session[Constant.strSORT] != null)                                         //CHECK IF SESSION IS NOT NULL
                {
                    if (currentSortOrder == SortOrder.Ascending)                               //CHECK WHETHER DATA IS IN ASCENDING ORDER
                    {
                        strBuild.Append(Constant.strORDERBY + Session[Constant.strSORT].ToString() +Constant.strBLANK + Constant.strASCC);      //GRIDVIEW SORTED IN ASCENDING ORDER
                    }
                    else
                    {
                        strBuild.Append(Constant.strORDERBY + Session[Constant.strSORT].ToString() + Constant.strBLANK + Constant.strDESCC);     //GRIDVIEW SORTED IN DESCENDING ORDER
                    }
                    Session[Constant.strSORT] = null;                                           //ASSIGN NULL TO SESSION
                }
                objAdpt = new SqlDataAdapter(strBuild.ToString(), objcommon.connC);              //INITIALIZING THE SQL DATA ADAPTER
                objAdpt.Fill(dsEmp);                                                               //FILL THE DATASET 
                gvEmp.DataSource = dsEmp;                                                       //TO SEND THE CONTENT OF TABLE INTO GRIDVIEW
                gvEmp.DataBind();                                                               //TO BIND THE DATA OF TABLE INTO GRIDVIEW
                                                                         //CALL THE FUNCTION TO CLOSE THE DATABASE
                if (gvEmp.Rows.Count == 0)                                                      //CHECK IF GRIDVIEW HAS SOME ROW 
                {
                    lblFound.Text = Constant.strDATAFOUND;                   //SHOW MESSEGE IF THERE IS NO ROW IN DATAGRID VIEW
                    lblFound.Visible = true;
                }
            }
            catch                                                                               //CHECK IF ANY EXCEPTION IS OCCURED
            {
                Response.Redirect(Constant.strERRORPAGE);                                             //REDIRECT TO ERROR.ASPX
            }
            finally
            {
                objcommon.CloseConnection(); 
                strBuild = null;                                                            //ASSIGN NULL TO THE OBJECT OF STRING BUILDER
                dsEmp = null;                                                             //ASSIGN NULL TO THE OBJECT OF DATASET
                objAdpt = null;                                                              //ASSIGN NULL TO THE OBJECT OF SQLDATAADOPTER
            }
        }
        #endregion BindData
        #region gvEmp_PageIndexChanging
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- gvEmp_PageIndexChanging
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- EVENT FOR PAGEINDEX.
        //      CREATED DATE    :- 2012/02/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        protected void gvEmp_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                gvEmp.PageIndex = e.NewPageIndex;                                                   //ASSIGN THE VALUE OF SELECTED PAGE TO PAGEUNDEX OF GRIDVIEW
                BindData();                                                                         //CALL THE METHOD BINDDATA
                gvEmp.SelectedIndex = -1;                                                           //AGAIN SET THE DEFAULT VALUE TO SELECTED INDEX OF GRIDVIEW
            }
            catch
            {
                Response.Redirect(Constant.strERRORPAGE);                                                 //REDIRECT TO ERROR.ASPX
            }
        }
        #endregion gvEmp_PageIndexChanging
        #region gvEmp_Sorted
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- gvEmp_Sorted
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- METHOD FOR SORT GRIDVIEW.
        //      CREATED DATE    :- 2012/02/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        protected void gvEmp_Sorted(object sender, EventArgs e)
        {
            try
            {
                if (sender is LinkButton)                                                           //CHECK IF REQUEST IS SENT BY LINK BUTTON
                {
                    LinkButton linkButton = (LinkButton)sender;                                     //ASSIGN THE SENDER TO LINKBUTTON AFTER PARSING
                    string newSortColumn = linkButton.CommandArgument;                              //ASSIGN THE COMMAND ARGUMENT TO THE STRING
                    Session[Constant.strSORT] = newSortColumn;                                      //ASSIGN THE VALUE OF STRING TO SESSION 
                    if (currentSortColumn == newSortColumn)                                         //CHECK IF THE NEW SORTING REQUEST IS EQUAL TO PREVIOS
                    {
                        if (currentSortOrder == SortOrder.Ascending)                                //CHECK IF THE DATA WAS SORTED ASCENDING
                            currentSortOrder = SortOrder.Descending;                                //SORT DATA DESCENDING
                        else
                            currentSortOrder = SortOrder.Ascending;                                 //SORT DATA ASCENDING
                    }
                    else
                    {
                        currentSortOrder = SortOrder.Ascending;                                     //ASSIGN ASCENDING TO CURRENT SORT ORDER
                        currentSortColumn = newSortColumn;                                          //ASSIGN THE REQUESTED COLUMN NAME TO CURRENT SORT COLUMN
                    }
                    gvEmp.SelectedIndex = -1;                                                       //SET DEFAULT FOR SELECTED INDEX OF GRIDVIEW
                    BindData();                                                                     //CALL THE FUNCTION BINDDATA
                }
            }
            catch
            {
                Response.Redirect(Constant.strERRORPAGE);                                                 //REDIRECT TO ERROR.ASPX
            }
        }
        #endregion gvEmp_Sorted
        #region PosPic
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- PosPic
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- METHOD FOR IMAGE CREATE ON ACCORDING TO ORDER.
        //      CREATED DATE    :- 2012/02/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        private void PosPic(GridView gridView, SortOrder currentSortOrder, string currentSortColumn)
        {
            try
            {
                if ((gridView.Rows.Count == 0) || (string.IsNullOrEmpty(currentSortColumn)))            //CHECK IF GRIDVIEW HAS SOME DATA
                    return;                                                                             //EXIT
                Image imgArrow = new Image();                                                           //INITIALIZATOIN OF THE IMAGE
                if (currentSortOrder == SortOrder.Ascending)                                            //CHECK IF DATA IS SORTED IN ASCENDING ORDER
                    imgArrow.ImageUrl = Constant.strUPIMAGE;                                              //SHOW THE UP ARROW IMAGE
                else                                                                                    //IF DATA IS SORTED IN DESCENDING ORDER
                    imgArrow.ImageUrl = Constant.strDOWNIMAGE;                                             //SHOW THE IMAGE OF DOWN ARROW
                for (int x = 0; x < gridView.Columns.Count; x++)                                        //ITERATION UNTILL GRIDVIEW HAS COLUMN
                {
                    if (string.Compare(currentSortColumn, gridView.Columns[x].SortExpression, true) == 0)   //COMPARE THE SORT COLUMN AND GRIDVIEW COULMN
                    {
                        gridView.HeaderRow.Cells[x].Controls.Add(imgArrow);                             //ADD IMAGE TO THE HEADER COLUMN 
                        break;                                                                          //BREAK FROM LOOP
                    }
                }
            }
            catch
            {
                Response.Redirect(Constant.strERRORPAGE);                                                     //REDIRECT TO ERROR.ASPX
            }
        }
        #endregion PosPic
    }
}
