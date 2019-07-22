using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI.WebControls;
namespace Day7_8
{
    #region _Default 
    /*************************************************************************************************************
       CLASS NAME                         ::::                    _Default
       AUTHOR                             ::::                    ANKIT
       DATE                               ::::                    18-07-2012
       DESCRIPTION                        ::::                    TO MAKE A CLASS FOR GRIDVIEW
      ************************************************************************************************************/
    public partial class _Default : System.Web.UI.Page
    {
        //DECLARATION OF ENUM DATATYPE FOR SORTING THE DATA
        public enum SortOrder
        {
            Ascending = 0,
            Descending = 1
        }
        private SortOrder currentSortOrder;                             //DECLARATION OF THE OBJECT OF SORTORDER
        private string currentSortColumn;                               //DECLARATION OF THE STRING
        Common objcommon = new Common();                                //DECLARATION OF THE OBJECT OF CLASS COMMON
        #region Page_Load
       /*************************************************************************************************************
       FUNCTION NAME                      ::::                    Page_Load
       AUTHOR                             ::::                    ANKIT
       DATE                               ::::                    18-07-2012
       DESCRIPTION                        ::::                    TO MAKE A PAGE_LOAD EVENT
      ************************************************************************************************************/
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
                this.currentSortOrder = (SortOrder)ViewState[Constant.strSortOrder];          //ASSIGN THE VALUE TO CURRENT SORT ORDER
                this.currentSortColumn = ViewState[Constant.strSortCol].ToString();           //ASSIGN THE VALUE TO CURRENT SORT COLUMN
            }
        }
        #endregion Page_Load   
        protected void Page_PreRender(object sender, EventArgs e)
        {
            ViewState[Constant.strSortOrder] = currentSortOrder;                              //ASSIGN THE VALUE TO VIEW STATE
            ViewState[Constant.strSortCol] = currentSortColumn;                               //ASSIGN THE VALUE TO VIEW STATE
            PosPic(gvEmp, currentSortOrder, currentSortColumn);                               //CALL THE FUNCTION TO PLACE THE IMAGE
        }
        #region BindData
        /*************************************************************************************************************
      FUNCTION NAME                      ::::                    BINDDATA
      AUTHOR                             ::::                    ANKIT
      DATE                               ::::                    18-07-2012
      DESCRIPTION                        ::::                    TO MAKE A METHOD FOR BINDING THE GRIDVIEW EVENT
     ************************************************************************************************************/
        public void BindData()
        {
            StringBuilder strBuild;                                                            //DECLARATION FOR OBJECT OF STRING BUILDER
            DataSet dsEmp;                                                                     //DECLARATION FOR OBJECT OF DATASET
            SqlDataAdapter adpt;                                                               //DECLARATION FOR OBJECT OF SQLDATAADOPTER         
            try
            {
                dsEmp = new DataSet();                                                         //INITIALIZATION OF DATASET
                //INITIALIZATION OF SQLCONNECTION ********************************************************************************
                objcommon.Con_Open();                                                          //CALL THE FUNCTION TO OPEN THE DATABASE
                strBuild = new StringBuilder();                                                //INITIALIZATION OF STRING BUILDER
                strBuild.Append(Constant.strSelEmp);                                           //APPENDING THE STRING BUILDER    
                if (Session[Constant.strSort] != null)                                         //CHECK IF SESSION IS NOT NULL
                {
                    if (currentSortOrder == SortOrder.Ascending)                               //CHECK WHETHER DATA IS IN ASCENDING ORDER
                    {
                        strBuild.Append(Constant.strOrdrBy + Session[Constant.strSort].ToString() + Constant.strSpace + Constant.strAsc);      //GRIDVIEW SORTED IN ASCENDING ORDER
                    }
                    else
                    {
                        strBuild.Append(Constant.strOrdrBy + Session[Constant.strSort].ToString() + Constant.strSpace + Constant.strDesc);     //GRIDVIEW SORTED IN DESCENDING ORDER
                    }
                    Session[Constant.strSort] = null;                                           //ASSIGN NULL TO SESSION
                }
                adpt = new SqlDataAdapter(strBuild.ToString(), objcommon.Connect);              //INITIALIZING THE SQL DATA ADAPTER
                adpt.Fill(dsEmp);                                                               //FILL THE DATASET 
                gvEmp.DataSource = dsEmp;                                                       //TO SEND THE CONTENT OF TABLE INTO GRIDVIEW
                gvEmp.DataBind();                                                               //TO BIND THE DATA OF TABLE INTO GRIDVIEW
                objcommon.Con_Close();                                                          //CALL THE FUNCTION TO CLOSE THE DATABASE
                if (gvEmp.Rows.Count == 0)                                                      //CHECK IF GRIDVIEW HAS SOME ROW 
                {
                    lblNodata.Text = Constant.strErrMsg;                                        //SHOW MESSEGE IF THERE IS NO ROW IN DATAGRID VIEW
                    lblNodata.Visible = true;
                }
            }
            catch                                                                               //CHECK IF ANY EXCEPTION IS OCCURED
            {
                Response.Redirect(Constant.strRed);                                             //REDIRECT TO ERROR.ASPX
            }
            finally
            {
                strBuild=null;                                                            //ASSIGN NULL TO THE OBJECT OF STRING BUILDER
                dsEmp = null;                                                             //ASSIGN NULL TO THE OBJECT OF DATASET
                adpt = null;                                                              //ASSIGN NULL TO THE OBJECT OF SQLDATAADOPTER
            }
        }
        #endregion BindData
        #region gvEmp_PageIndexChanging
        /*************************************************************************************************************
       FUNCTION NAME                      ::::                    GVEMP_PAGEINDEXCHANGING
       AUTHOR                             ::::                    ANKIT
       DATE                               ::::                    18-07-2012
       DESCRIPTION                        ::::                    EVENT FOR CHANGING THE PAGE INDEX OF GRIDVIEW
      ************************************************************************************************************/
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
                Response.Redirect(Constant.strRed);                                                 //REDIRECT TO ERROR.ASPX
            }
        }
        #endregion gvEmp_PageIndexChanging
        #region gvEmp_Sorted
        /*************************************************************************************************************
       FUNCTION NAME                      ::::                    GVEMP_SORTED
       AUTHOR                             ::::                    ANKIT
       DATE                               ::::                    18-07-2012
       DESCRIPTION                        ::::                    EVENT SORTING THE GRIDVIEW
      ************************************************************************************************************/
        protected void gvEmp_Sorted(object sender, EventArgs e)
        {
            try
            {
                if (sender is LinkButton)                                                           //CHECK IF REQUEST IS SENT BY LINK BUTTON
                {
                    LinkButton linkButton = (LinkButton)sender;                                     //ASSIGN THE SENDER TO LINKBUTTON AFTER PARSING
                    string newSortColumn = linkButton.CommandArgument;                              //ASSIGN THE COMMAND ARGUMENT TO THE STRING
                    Session[Constant.strSort] = newSortColumn;                                      //ASSIGN THE VALUE OF STRING TO SESSION 
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
                Response.Redirect(Constant.strRed);                                                 //REDIRECT TO ERROR.ASPX
            }
        }
        #endregion gvEmp_Sorted
        #region PosPic
        /*************************************************************************************************************
       FUNCTION NAME                      ::::                    POSTPIC
       AUTHOR                             ::::                    ANKIT
       DATE                               ::::                    18-07-2012
       DESCRIPTION                        ::::                    METHOD FOR PLACING THE PIC ACCORDING TO ORDER OF SORTING
      ************************************************************************************************************/
        private void PosPic(GridView gridView, SortOrder currentSortOrder, string currentSortColumn)
        {
            try
            {
                if ((gridView.Rows.Count == 0) || (string.IsNullOrEmpty(currentSortColumn)))            //CHECK IF GRIDVIEW HAS SOME DATA
                    return;                                                                             //EXIT
                Image imgArrow = new Image();                                                           //INITIALIZATOIN OF THE IMAGE
                if (currentSortOrder == SortOrder.Ascending)                                            //CHECK IF DATA IS SORTED IN ASCENDING ORDER
                    imgArrow.ImageUrl = Constant.strUpImg;                                              //SHOW THE UP ARROW IMAGE
                else                                                                                    //IF DATA IS SORTED IN DESCENDING ORDER
                    imgArrow.ImageUrl = Constant.strDwnImg;                                             //SHOW THE IMAGE OF DOWN ARROW
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
                Response.Redirect(Constant.strRed);                                                     //REDIRECT TO ERROR.ASPX
            }
        }
        #endregion PosPic
    }
    #endregion _Default
}
