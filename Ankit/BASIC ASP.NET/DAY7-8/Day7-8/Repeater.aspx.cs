using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI.WebControls;

namespace Day7_8
{
    #region Repeater
    /*************************************************************************************************************
       CLASS NAME                         ::::                    REPEATER
       AUTHOR                             ::::                    ANKIT
       DATE                               ::::                    19-07-2012
       DESCRIPTION                        ::::                    TO MAKE A CLASS FOR REPEATER
      ************************************************************************************************************/
    public partial class Repeater : System.Web.UI.Page
    {
        Common objcommon = new Common();                            //INITIALIZATION OF OBJECT OF CLASS COMMON
        public static string strSort = string.Empty;                //INITIALIZATION OF STATIC STRING
        public static string strOrder = string.Empty;               //INITIALIZATION OF A STATIC STRING
        #region Page_Load
      /*************************************************************************************************************
      FUNCTION NAME                      ::::                    Page_Load
      AUTHOR                             ::::                    ANKIT
      DATE                               ::::                    19-07-2012
      DESCRIPTION                        ::::                    TO MAKE A PAGE_LOAD EVENT
     ************************************************************************************************************/
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        #endregion Page_Load
        #region BindData
        /*************************************************************************************************************
        FUNCTION NAME                      ::::                    BindData
        AUTHOR                             ::::                    ANKIT
        DATE                               ::::                    19-07-2012
        DESCRIPTION                        ::::                    TO MAKE A METHOD TO BIND THE REPEATER AND DATALIST AS WELL 
        ************************************************************************************************************/
        public void BindData()
        {
            StringBuilder strbuild1;                                //DECLARATION OF OBJECT OF STRING BUILDER
            DataTable dt;                                           //DECLARATION OF OBJECT OF DATATABLE
            SqlDataAdapter adpt;                                    //DECLARATION OF OBJECT OF SQL DATA ADAPTER
            PagedDataSource pgitems;                                //DECLARATION OF OBJECT OF PAGEDDATASOURCE
            DataView dv;                                            //DECLARATION OF OBJECT OF DATAVIEW
            ArrayList arrlstPages;                                  //DECLARATION OF OBJECT OF ARRAYLIST
            try
            {
                strbuild1 = new StringBuilder();                    //INITIALIZATION OF OBJECT OF STRING BUILDER
                strbuild1.Append(Constant.strSelEmp);               //APPEND THE STRING BUILDER
                if (Session[Constant.strSort] != null)              //CHECK IF SESSION IS NOT NULL
                {
                    strbuild1.Append(Constant.strOrdrBy);                 //APPENDING THE STRINGBUILDER
                    strbuild1.Append(Session[Constant.strSort].ToString()); //APPENDING THE STRINGBUILDER
                    strbuild1.Append(Constant.strSpace);
                    if (strSort == Session[Constant.strSort].ToString())    //CHECK IF STRSORT IS EQUAL TO SESSION 
                    {
                        if (strOrder ==Constant.strAsc)                      //CHECK IF SORTOREDR IS EQUAL TO ASC
                        {
                            strbuild1.Append(Constant.strDesc);              //APPENDING THE STRINGBUILDER
                            strOrder = Constant.strDesc;                      //SET SORTORDER DESC
                        }
                        else
                        {
                            strbuild1.Append(Constant.strAsc);               //APPENDING THE STRINGBUILDER
                            strOrder = Constant.strAsc;                       //SET SORTOREDR ASC
                        }
                    }
                    else
                    {
                        if (strOrder == Constant.strAsc)                      //CHECK IF SORTOREDR IS EQUAL TO ASC  
                        {
                            strbuild1.Append(Constant.strDesc);              //APPENDING THE STRINGBUILDER 
                            strOrder = Constant.strDesc;                      //SET SORTORDER DESC
                        }
                        else
                        {
                            strbuild1.Append(Constant.strAsc);               //APPENDING THE STRINGBUILDER
                            strOrder = Constant.strAsc;                       //SET SORTORDER ASC
                        }
                    }
                    strSort = Session[Constant.strSort].ToString();           //ASSIGN SESSION TO STRSORT
                    Session[Constant.strSort] = null;                         //ASSIGN NULL TO SESSION
                }
                objcommon.Con_Open();                               //OPEN THE SQL CONNECTION 
                dt = new DataTable();                               //INITIALIZATION OF THE OBJECT OF DATATABLE
                adpt = new SqlDataAdapter(strbuild1.ToString(), objcommon.Connect);
                adpt.Fill(dt);                                      //FILL THE DATA INTO DATA TABLE
                pgitems = new PagedDataSource();                    //INITIALIZATION OF THE OBJECT OF PAGED DATA SOURCE
                dv = new DataView(dt);                              //INITIALIZATION OF THE OBJECT OF DATAVIEW
                pgitems.DataSource = dv;                            //SET DATASOURCE OF PAGEDINDEX TO DATAVIEW
                pgitems.AllowPaging = true;                         //ALLOW PAGING 
                pgitems.PageSize = 5;                               //SET PAGE SIZE 5
                pgitems.CurrentPageIndex = PageNumber;              //ASSIGN THE PROPERTY PAGENUMBER TO CURRENT PAGE INDEX
                lblCrnt.Visible = true;                             //MAKE LABEL VISIBLE
                lblCrnt.Text = Constant.strCrntPg + (PageNumber+1) + Constant.strOf + pgitems.PageCount; //CHANGE THE TEXT OF LABEL
                ButtonEnable(pgitems);                              //CALLING THE FUNCTION BUTTONENABLE
                if (pgitems.PageCount > 1)                          //IF PGITEM HAS SOME PAGES
                {
                    rptEmp.Visible = true;                          //MAKE REPEATER VISIBLE
                    arrlstPages = new ArrayList();                  //INITIALIZATION OF THE OBJECT OF ARRAYLIST
                    for (int i = 0; i < pgitems.PageCount; i++)
                    {
                        arrlstPages.Add((i + 1).ToString());        //ADD PAGE NUMBER TO THE ARRAYLIST
                    }
                    rptPages.DataSource = arrlstPages;              //SET DATASOURCE OF RPTPAGES TO ARRAYLIST
                    rptPages.DataBind();                            //BIND THE DATA INTO REPEATER
                }
                else                                                //IF THERE IS NO PAGE
                    rptPages.Visible = false;                       //MAKE REPEATER INVISIBLE
                rptEmp.DataSource = pgitems;                        //SET DATASOURCE OF REAPEATER TO PGITEMS
                rptEmp.DataBind();                                  //BIND THE DATA INTO REPEATER
                dtEmp.DataSource = pgitems;                         //SET DATASOURCE OF REAPEATER TO PGITEMS
                dtEmp.DataBind();                                   //BIND THE DATA INTO REPEATER
                objcommon.Con_Close();                              //CLOSE THE SQL CONNECTION 
            }
            catch
            {
                Response.Redirect(Constant.strRed);                 //REDIRECT TO ERROR.ASPX IF ANY EXCEPTION IS OCCURED
            }
            finally
            {
                objcommon.Con_Close();                              //CLOSE THE SQL CONNECTION 
                strbuild1=null;                                     //ASSIGN NULL TO THE OBJECT OF STRINBUILDER
                dt = null;                                          //ASSIGN NULL TO THE OBJECT OF DATATABLE
                adpt = null;                                        //ASSIGN NULL TO THE OBJECT OF SQL DATA ADAPTER
                pgitems = null;                                     //ASSIGN NULL TO THE OBJECT OF PAGED DATA SOURCE
                dv = null;                                          //ASSIGN NULL TO THE OBJECT OF DATA VIEW
                arrlstPages = null;                                 //ASSIGN NULL TO THE OBJECT OF ARRAY LIST
            }
        }
        #endregion BindData
        #region PageNumber
        /*************************************************************************************************************
        FUNCTION NAME                      ::::                    PageNumber
        AUTHOR                             ::::                    ANKIT
        DATE                               ::::                    19-07-2012
        DESCRIPTION                        ::::                    TO CHANGING THE PAGE INDEX  
        ************************************************************************************************************/
        public int PageNumber
	    {
	        get
            {
	            if (ViewState[Constant.strPgNum] != null)                    //CHECK IF PAGE NUMBER IS NOT NULL
	                return Convert.ToInt32(ViewState[Constant.strPgNum]);    //RETURN PAGE INDEX AFTER CONVERTING INTO INTEGER
	            else                                                    //ELSE
	                return 0;                                           //RETURN 0
	        }
	        set
	        {
	            ViewState[Constant.strPgNum] = value;                        //ASSIGN VALUE TO PAGE 
	        }
        }
        #endregion PageNumber
        #region btnDisplay_Click
        /*************************************************************************************************************
        FUNCTION NAME                      ::::                    btnDisplay_Click
        AUTHOR                             ::::                    ANKIT
        DATE                               ::::                    19-07-2012
        DESCRIPTION                        ::::                    CLICK EVENT OF DISPLAY BUTTON  
        ************************************************************************************************************/
        protected void btnDisplay_Click(object sender, EventArgs e)
        {
            if (ddlSort.SelectedValue == Constant.strNone)                        //CHRCK IF SELECTED VALUE IN DROP DOWN LIST IS NONE
            {
                Session[Constant.strSort] = null;                                 //ASSIGN NULL TO SESSION 
            }
            else                                                        //IF SELECTED VALUE IN DROP DOWN LIST IS NOT NONE
            {
                Session[Constant.strSort] = ddlSort.SelectedValue;                //ASSIGN THE SELECTED VALUE TO SESSION 
            }
            rptEmp.Visible = true;                                      //MAKE REPEATER VISIBLE
            dtEmp.Visible = true;                                       //MAKE REPEATER VISIBLE
            BindData();                                                 //CALL THE METHOD BIND DATA
        }
        #endregion btnDisplay_click
        #region rptPages_ItemCommand
        /*************************************************************************************************************
        FUNCTION NAME                      ::::                    rptPages_ItemCommand
        AUTHOR                             ::::                    ANKIT
        DATE                               ::::                    19-07-2012
        DESCRIPTION                        ::::                    ITEMCOMMAND EVENT OF REPEATER  
        ************************************************************************************************************/
        protected void rptPages_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            PageNumber = Convert.ToInt32(e.CommandArgument) - 1;        //ASSIGN CURRENT PAGE TO PAGENUMBER
            BindData();                                                 //CALL THE METHOD BIND DATA
        }
        #endregion rptPages_ItemCommand
        #region btnLast_Click
        /*************************************************************************************************************
        FUNCTION NAME                      ::::                    btnLast_Click
        AUTHOR                             ::::                    ANKIT
        DATE                               ::::                    19-07-2012
        DESCRIPTION                        ::::                    CLICK EVENT OF LAST BUTTON  
        ************************************************************************************************************/
        protected void btnLast_Click(object sender, EventArgs e)
        {
            if (PageNumber < 4)                                     //CHECK IF PAGE IS NOT LAST                                  
            {
                PageNumber = 4;                                     //ASSIGN LAST TO PAGENUMBER
                BindData();                                         //CALL THE FUNCTION BINDDATA
            }
        }
        #endregion btnLast_Click
        #region btnFrst_Click
        /*************************************************************************************************************
        FUNCTION NAME                      ::::                    btnFrst_Click
        AUTHOR                             ::::                    ANKIT
        DATE                               ::::                    19-07-2012
        DESCRIPTION                        ::::                    CLICK EVENT OF FIRST BUTTON  
        ************************************************************************************************************/
        protected void btnFrst_Click(object sender, EventArgs e)
        {
            if (PageNumber > 0)                                  //CHECK IF PAGE IS NOT FIRST
            {
                PageNumber = 0;                                  //ASSIGN FIRST TO PAGENUMBER
                BindData();                                      //CALL THE FUNCTION BINDDATA
            }
        }
        #endregion btnFrst_Click
        #region btnPrev_Click
        /*************************************************************************************************************
        FUNCTION NAME                      ::::                    btnPrev_Click
        AUTHOR                             ::::                    ANKIT
        DATE                               ::::                    19-07-2012
        DESCRIPTION                        ::::                    CLICK EVENT OF PREV BUTTON  
        ************************************************************************************************************/
        protected void btnPrev_Click(object sender, EventArgs e)
        {
            if (PageNumber > 0)                                     //CHECK IF PAGE IS NOT FIRST
            {
                PageNumber--;                                       //DECRESE THE PAGENUMBER
                BindData();                                         //CALL THE FUNCTION BINDDATA
            }
        }
        #endregion btnPrev_Click
        #region btnNext_Click
        /*************************************************************************************************************
        FUNCTION NAME                      ::::                    btnNext_Click
        AUTHOR                             ::::                    ANKIT
        DATE                               ::::                    19-07-2012
        DESCRIPTION                        ::::                    CLICK EVENT OF NEXT BUTTON  
        ************************************************************************************************************/
        protected void btnNext_Click(object sender, EventArgs e)
        {
            if (PageNumber < 4)                                     //CHECK IF PAGE IS NOT LAST
            {
                PageNumber++;                                       //INCRESE THE PAGENUMBER
                BindData();                                         //CALL THE FUNCTION BINDDATA
            }
        }
        #endregion btnNext_Click
        #region ButtonEnable
        /*************************************************************************************************************
        FUNCTION NAME                      ::::                    ButtonEnable
        AUTHOR                             ::::                    ANKIT
        DATE                               ::::                    19-07-2012
        DESCRIPTION                        ::::                    TO ENABLE OR DISABLE THE BUTTONS  
        ************************************************************************************************************/
        void ButtonEnable(PagedDataSource pgitems)
        {
            btnFrst.Visible = true;                                 //SET VISIBLE TRUE FOR BUTTON FRST
            btnPrev.Visible = true;                                 //SET VISIBLE TRUE FOR BUTTON PREV
            btnNext.Visible = true;                                 //SET VISIBLE TRUE FOR BUTTON NEXT
            btnLast.Visible = true;                                 //SET VISIBLE TRUE FOR BUTTON LAST            
            switch (pgitems.CurrentPageIndex)                       //SWITCH STATEMENT 
            {
                case 0:                                             //CASE IF PAGEINDEX IS 0
                    btnFrst.Enabled = false;                        //SET ENABLE FALSE FOR BUTTON FRST
                    btnPrev.Enabled = false;                        //SET ENABLE FALSE FOR BUTTON PREV
                    btnNext.Enabled = true;                         //SET ENABLE TRUE FOR BUTTON NEXT
                    btnLast.Enabled = true;                         //SET ENABLE TRUE FOR BUTTON LAST
                    break;
                case 1:                                             //ALL
                case 2:                                                 //OTHER
                case 3:                                                         //CASES
                    btnFrst.Enabled = true;                         //SET ENABLE FALSE FOR BUTTON FRST
                    btnPrev.Enabled = true;                         //SET ENABLE TRUE FOR BUTTON PREV
                    btnNext.Enabled = true;                         //SET ENABLE TRUE FOR BUTTON NEXT
                    btnLast.Enabled = true;                         //SET ENABLE TRUE FOR BUTTON LAST
                    break;
                case 4:                                             //CASE IF PAGEINDEX IS 4
                    btnFrst.Enabled = true;                         //SET ENABLE TRUE FOR BUTTON FRST
                    btnPrev.Enabled = true;                         //SET ENABLE TRUE FOR BUTTON PREV
                    btnLast.Enabled = false;                        //SET ENABLE FALSE FOR BUTTON LAST
                    btnNext.Enabled = false;                        //SET ENABLE FALSE FOR BUTTON NEXT
                    break;
            }
        }
        #endregion ButtonEnable
    }
    #endregion Repeater
}
