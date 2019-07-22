using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Web.UI.WebControls;
// ---------------------------------------------------------------------------------------------------------------------------------------------
//      NAME            :- Day_7_8
//      AUTHOR NAME     :- Shikha Malik
//      DESCRIPTION     :- The Namespace For bind Data in Repeater and DataList and sort.
//      CREATED DATE    :- 2012/03/09
//----------------------------------------------------------------------------------------------------------------------------------------------

namespace Day_7_8
{
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- Exersice07
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- The Class For bind Data in Repeater and DataList and sort.
    //      CREATED DATE    :- 2012/03/09
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class Exersice07 : System.Web.UI.Page
    {
        Common objCommon;  
        public static string strSort = string.Empty;                        //INITIALIZATION OF STATIC STRING
        public static string strOrder = string.Empty;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      METHOD NAME     :- BindData
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- The METHOD For bind Data in Repeater and DataList and sort.
        //      CREATED DATE    :- 2012/03/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        #region BindData
        public void BindData()                                          //BIND DATA METHOD FOR BINDING DATA IN TO REPEATER
        {
            DataTable dt;                                               //DECLARATION OF OBJECTS
            ArrayList arrlstPages;
            StringBuilder strbuilB1;
            DataView dv;
            SqlDataAdapter objSadp;
            try
            {
                dv = new DataView();                                  //INITIALIZATION OF OBJECT
                dt = new DataTable();
                objCommon = new Common();
                objCommon.OpenConnection();                             //open connection from common class object
                strbuilB1 = new StringBuilder();                    //INITIALIZATION OF OBJECT OF STRING BUILDER
                strbuilB1.Append(Constant.strSELECTEMP);               //APPEND THE STRING BUILDER
                if (Session[Constant.strSORT] != null)                          //CHECK IF SESSION IS NOT NULL
                {
                    strbuilB1.Append(Constant.strORDERBY);                 //APPENDING THE STRINGBUILDER
                    strbuilB1.Append(Session[Constant.strSORT].ToString());  //APPENDING THE STRINGBUILDER
                    strbuilB1.Append(Constant.strBLANK);
                    if (strSort == Session[Constant.strSORT].ToString())    //CHECK IF STRSORT IS EQUAL TO SESSION 
                    {
                        if (strOrder == Constant.strASCC)                      //CHECK IF SORTOREDR IS EQUAL TO ASC
                        {
                            strbuilB1.Append(Constant.strDESCC);              //APPENDING THE STRINGBUILDER
                            strOrder = Constant.strDESCC;                      //SET SORTORDER DESC
                        }
                        else
                        {
                            strbuilB1.Append(Constant.strASCC);               //APPENDING THE STRINGBUILDER
                            strOrder = Constant.strASCC;                       //SET SORTOREDR ASC
                        }
                    }
                    else
                    {
                        if (strOrder == Constant.strASCC)                      //CHECK IF SORTOREDR IS EQUAL TO ASC  
                        {
                            strbuilB1.Append(Constant.strDESCC);              //APPENDING THE STRINGBUILDER 
                            strOrder = Constant.strDESCC;                      //SET SORTORDER DESC
                        }
                        else
                        {
                            strbuilB1.Append(Constant.strASCC);               //APPENDING THE STRINGBUILDER
                            strOrder = Constant.strASCC;                       //SET SORTORDER ASC
                        }
                    }
                    strSort = Session[Constant.strSORT].ToString();           //ASSIGN SESSION TO STRSORT
                    Session[Constant.strSORT] = null;                         //ASSIGN NULL TO SESSION
                }
                objSadp = new SqlDataAdapter(strbuilB1.ToString(), objCommon.connC);
                objSadp.Fill(dt);
                dv = new DataView(dt);
                objPageDataSource.DataSource = dv;
                objPageDataSource.AllowPaging = true;
                objPageDataSource.PageSize = 5;
                objPageDataSource.CurrentPageIndex = CurrentPage;
                ViewState[Constant.strTOTALPAGES] = objPageDataSource.PageCount;
                this.lblCurrentPage.Text = Constant.strPAGE + (CurrentPage + 1) + " of " + objPageDataSource.PageCount;
                this.lnkPrev.Enabled = !objPageDataSource.IsFirstPage;
                this.lnkNext.Enabled = !objPageDataSource.IsLastPage;
                this.lnkFirst.Enabled = !objPageDataSource.IsFirstPage;
                this.lnkLast.Enabled = !objPageDataSource.IsLastPage;
                if (objPageDataSource.PageCount > 1)                          //IF PGITEM HAS SOME PAGES
                {
                    rptEmp.Visible = true;                          //MAKE REPEATER VISIBLE
                    arrlstPages = new ArrayList();                  //INITIALIZATION OF THE OBJECT OF ARRAYLIST
                    for (int i = 0; i < objPageDataSource.PageCount; i++)
                    {
                        arrlstPages.Add((i + 1).ToString());        //ADD PAGE NUMBER TO THE ARRAYLIST
                    }
                    rptPages.DataSource = arrlstPages;              //SET DATASOURCE OF RPTPAGES TO ARRAYLIST
                    rptPages.DataBind();                            //BIND THE DATA INTO REPEATER

                }
                else                                                //IF THERE IS NO PAGE
                    rptPages.Visible = false;                       //MAKE REPEATER INVISIBLE
                    rptEmp.DataSource = objPageDataSource;                        //SET DATASOURCE OF REAPEATER TO PGITEMS
                    rptEmp.DataBind();                                  //BIND THE DATA INTO REPEATER
                    dtEmp.Visible = true;
                    dtEmp.DataSource = objPageDataSource;                         //SET DATASOURCE OF REAPEATER TO PGITEMS
                    dtEmp.DataBind();                                   //BIND THE DATA INTO REPEATER
            }
            catch(Exception ex)
            {
                Response.Redirect(Constant.strERRORPAGE);

            }

            finally
            {
                objCommon.CloseConnection();                               //CLOSE THE SQL CONNECTION 
                dt=null;
                arrlstPages=null;
                strbuilB1 = null;
                dv=null;
                objSadp=null;
            }

        }
        #endregion BindData
       
      #region PagedDataSource
      PagedDataSource objPageDataSource = new PagedDataSource();
      #endregion PagedDataSource
      // ---------------------------------------------------------------------------------------------------------------------------------------------
      //      METHOD NAME     :-  rptPages_ItemCommand
      //      AUTHOR NAME     :- Shikha Malik
      //      DESCRIPTION     :- EVENT FOR REPEAT DATA.
      //      CREATED DATE    :- 2012/03/09
      //----------------------------------------------------------------------------------------------------------------------------------------------
      protected void rptPages_ItemCommand(object source, RepeaterCommandEventArgs e)
      {
          CurrentPage = Convert.ToInt32(e.CommandArgument) - 1;        //ASSIGN CURRENT PAGE TO PAGENUMBER
          BindData();                                                 //CALL THE METHOD BIND DATA
      }
      //Properties of Paging for next,first ,last,previous
      #region Private Properties
      private int CurrentPage
      {
          get
          {
              object objPage = ViewState[Constant.strCURRENTPAGING];
              int _CurrentPage = 0;
              if (objPage == null)
              {
                  _CurrentPage = 0;
              }
              else
              {
                  _CurrentPage = (int)objPage;
              }
              return _CurrentPage;
          }
          set { ViewState[Constant.strCURRENTPAGING] = value; }
      }
      private int fistIndex
      {
          get
          {
              int _FirstIndex = 0;
              if (ViewState[Constant.strFIRSTINDEX] == null)
              {
                  _FirstIndex = 0;
              }
              else
              {
                  _FirstIndex = Convert.ToInt32(ViewState[Constant.strFIRSTINDEX]);
              }
              return _FirstIndex;
          }
          set { ViewState[Constant.strFIRSTINDEX] = value; }
      }
      private int lastIndex
      {
          get
          {
              int _LastIndex = 0;
              if (ViewState[Constant.strLASTINDEX] == null)
              {
                  _LastIndex = 0;
              }
              else
              {
                  _LastIndex = Convert.ToInt32(ViewState[Constant.strLASTINDEX]);
              }
              return _LastIndex;
          }
          set { ViewState[Constant.strLASTINDEX] = value; }
      }
      #endregion  Private Properties

      //Events of Paging
      #region "Custom Paging"
      // ---------------------------------------------------------------------------------------------------------------------------------------------
      //      METHOD NAME     :- lnkFirst_Click
      //      AUTHOR NAME     :- Shikha Malik
      //      DESCRIPTION     :- CLICK EVENT FOR First PAGE DATA.
      //      CREATED DATE    :- 2012/03/09
      //----------------------------------------------------------------------------------------------------------------------------------------------
      protected void lnkFirst_Click(object sender, EventArgs e)
      {
          CurrentPage = 0;
          if (ddlSortBy.SelectedValue == Constant.strNONE)                        //CHRCK IF SELECTED VALUE IN DROP DOWN LIST IS NONE
          {
              Session[Constant.strSORT] = null;                                 //ASSIGN NULL TO SESSION 
          }
          else                                                        //IF SELECTED VALUE IN DROP DOWN LIST IS NOT NONE
          {
              Session[Constant.strSORT] = ddlSortBy.SelectedValue;                //ASSIGN THE SELECTED VALUE TO SESSION 
          }
         
              this.BindData();
          
      }
      // ---------------------------------------------------------------------------------------------------------------------------------------------
      //      METHOD NAME     :- lnkPrev_Click
      //      AUTHOR NAME     :- Shikha Malik
      //      DESCRIPTION     :- CLICK EVENT FOR Prev PAGE DATA.
      //      CREATED DATE    :- 2012/03/09
      //----------------------------------------------------------------------------------------------------------------------------------------------
      protected void lnkPrev_Click(object sender, EventArgs e)
      {
          CurrentPage -= 1;
          if (ddlSortBy.SelectedValue == Constant.strNONE)                        //CHRCK IF SELECTED VALUE IN DROP DOWN LIST IS NONE
          {
              Session[Constant.strSORT] = null;                                 //ASSIGN NULL TO SESSION 
          }
          else                                                        //IF SELECTED VALUE IN DROP DOWN LIST IS NOT NONE
          {
              Session[Constant.strSORT] = ddlSortBy.SelectedValue;                //ASSIGN THE SELECTED VALUE TO SESSION 
          }
         
          this.BindData();
      }
      // ---------------------------------------------------------------------------------------------------------------------------------------------
      //      METHOD NAME     :- lnkNext_Click
      //      AUTHOR NAME     :- Shikha Malik
      //      DESCRIPTION     :- CLICK EVENT FOR Next PAGE DATA.
      //      CREATED DATE    :- 2012/03/09
      //----------------------------------------------------------------------------------------------------------------------------------------------
      protected void lnkNext_Click(object sender, EventArgs e)
      {
          CurrentPage += 1;
          if (ddlSortBy.SelectedValue == Constant.strNONE)                        //CHRCK IF SELECTED VALUE IN DROP DOWN LIST IS NONE
          {
              Session[Constant.strSORT] = null;                                 //ASSIGN NULL TO SESSION 
          }
          else                                                        //IF SELECTED VALUE IN DROP DOWN LIST IS NOT NONE
          {
              Session[Constant.strSORT] = ddlSortBy.SelectedValue;                //ASSIGN THE SELECTED VALUE TO SESSION 
          }
         
          this.BindData();
      }
      // ---------------------------------------------------------------------------------------------------------------------------------------------
      //      METHOD NAME     :- lnkLast_Click
      //      AUTHOR NAME     :- Shikha Malik
      //      DESCRIPTION     :- CLICK EVENT FOR LAST PAGE DATA.
      //      CREATED DATE    :- 2012/03/09
      //----------------------------------------------------------------------------------------------------------------------------------------------
      protected void lnkLast_Click(object sender, EventArgs e)
      {
          CurrentPage = (Convert.ToInt32(ViewState[Constant.strTOTALPAGES]) - 1);
          if (ddlSortBy.SelectedValue == Constant.strNONE)                        //CHRCK IF SELECTED VALUE IN DROP DOWN LIST IS NONE
          {
              Session[Constant.strSORT] = null;                                 //ASSIGN NULL TO SESSION 
          }
          else                                                        //IF SELECTED VALUE IN DROP DOWN LIST IS NOT NONE
          {
              Session[Constant.strSORT] = ddlSortBy.SelectedValue;                //ASSIGN THE SELECTED VALUE TO SESSION 
          }
         
          this.BindData();
      }
      #endregion "Custom Paging"
      // ---------------------------------------------------------------------------------------------------------------------------------------------
      //      METHOD NAME     :- DisplayRecords_Click
      //      AUTHOR NAME     :- Shikha Malik
      //      DESCRIPTION     :- CLICK EVENT FOR bind Data in Repeater and DataList and sort.
      //      CREATED DATE    :- 2012/03/09
      //----------------------------------------------------------------------------------------------------------------------------------------------
      #region DisplayRecords
      protected void DisplayRecords_Click(object sender, EventArgs e)
      {
          if (ddlSortBy.SelectedValue == Constant.strNONE)                        //CHRCK IF SELECTED VALUE IN DROP DOWN LIST IS NONE
          {
              Session[Constant.strSORT] = null;                                 //ASSIGN NULL TO SESSION 
          }
          else                                                        //IF SELECTED VALUE IN DROP DOWN LIST IS NOT NONE
          {
              Session[Constant.strSORT] = ddlSortBy.SelectedValue;                //ASSIGN THE SELECTED VALUE TO SESSION 
          }
          rptEmp.Visible = true;                                      //MAKE REPEATER VISIBLE
          dtEmp.Visible = true;                                       //MAKE DATALIST VISIBLE
          BindData();
      }
      #endregion DisplayRecords
    }
}
