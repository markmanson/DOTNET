using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Day_12_13
{
    #region Default

    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- _Default
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- The Class Used for export data into excel file
    //      CREATED DATE    :- 2012/10/31
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class _Default : System.Web.UI.Page
    {
        #region Page_Load
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- Page_Load
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- The Method used for bind data into gridview
        //      CREATED DATE    :- 2012/10/31
        //----------------------------------------------------------------------------------------------------------------------------------------------
        DataSet objDS;
        protected void Page_Load(object sender, EventArgs e)
        {
            BindData();
        }
        #endregion Page_Load
        #region BindData
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- BindData()
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- The Function Used for get data from Database table and bind into gridview
        //      CREATED DATE    :- 2012/10/31
        //----------------------------------------------------------------------------------------------------------------------------------------------
        public void BindData()
        {
            SqlDataAdapter adapDA;  StringBuilder strBl; string strcons;  // declaration of object
            Common connObj = new Common();
            try
            {
                connObj.OpenConnection();                             //open connection from common class object
                objDS = new DataSet();                               //create object of typed data set
                strBl = new StringBuilder();                          //Create object of string builder class       
                strBl.Append(Constant.strSELECT);                      //Append string                            
                strBl.Append(Constant.strCOULMN);                      //Append string
                strBl.Append(Constant.strTABLE);
                strcons = strBl.ToString();                           //store all string into a string
                adapDA = new SqlDataAdapter(strcons, connObj.connC);  //pass connection and query into data adapter
                adapDA.Fill(objDS);                   //fill dataset from employee table
                gvEmp.DataSource = objDS;
                gvEmp.DataBind();                                      //Bind data
            }
            catch 
            {
                Response.Redirect(Constant.strERRPAGE);          //throw exception on error page
            }
            finally                                                 //reallocate memory
            {
                connObj.CloseConnection();
                connObj = null;
                adapDA = null; strcons = null;
            }
        }
        #endregion BindData
        #region ExportData
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- btnExport_Click
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- The function Used for export data in to excel file
        //      CREATED DATE    :- 2012/10/31
        //----------------------------------------------------------------------------------------------------------------------------------------------
        protected void btnExport_Click(object sender, EventArgs e)        //CLICK EVENT FOR EXPORT DATA IN TO EXCEL FILE
          {
           ExportFunction(Constant.strATTACHMENT, Constant.strTYPE);      //CALL EXPORT FUNCTION FOR EXPORT DATA IN TO EXCEL FILE
          }
        #endregion ExportData
        #region ExportFunction
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- ExportFunction
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- The Export function write data in to excel file
        //      CREATED DATE    :- 2012/10/31
        //----------------------------------------------------------------------------------------------------------------------------------------------
     private void ExportFunction(string header, string contentType)          //EXPOERT FUNCTION FOR EXPORT DATA IN TO EXCEL
        {
            GridView objGVEXCEL;                                            //DECLARATION OF OBJECT OF VARIABLES
            StringWriter objSW;
            HtmlTextWriter objHW;
            try
            {
                Response.Clear();                                          //SET RESPONSE CLEAR
                Response.Buffer = true;                                    //SET BUFFER TRUE
                Response.AddHeader(Constant.strCONTNTDES, header);         // ADD HEADER VALUE
                Response.Charset = Constant.strBLANK;                      //FOR BLANK SPACE
                Response.ContentType = contentType;                        //CONTENT TYPE IS EXCEL FILE
                objGVEXCEL = new GridView();                               //INTIALIZE GRIDVIEW
                objSW = new StringWriter();                                //INTIALIZE STRINGWRITER
                objHW = new HtmlTextWriter(objSW);                         //PASS THE OBJECT OF STRING WRITER INTO HYPER TEXT WRITER
                objGVEXCEL.AllowPaging = false;                                    //SET ALLOWPAGING FALSE
                objGVEXCEL.DataSource = objDS;                                                //Assign the dataset value to the gridview with datasource
                objGVEXCEL.DataBind();                                       //BIND DATA IN TO GRIDVIEW
                objGVEXCEL.HeaderRow.Style.Add(Constant.strBAKCOLOR, Constant.strHDRCOLOR);   //SET COLORS OF GRIDVIEW
                for (int i = 0; i < objGVEXCEL.HeaderRow.Cells.Count; i++)
                {
                    objGVEXCEL.HeaderRow.Cells[i].Style.Add(Constant.strBAKCOLOR, Constant.strORANGECOLOR);
                    objGVEXCEL.HeaderRow.Cells[i].Style.Add(Constant.strCOLOR, Constant.strCELLSCOLOR);
                }
                objGVEXCEL.RenderControl(objHW);                         //PASS THE OBJECT OF HTML TEXT INTO GRIDVIEW RENDER CONTROL
                Response.Output.Write(objSW.ToString());                 //SHOW OUTPUT
                //Response.End();
                Response.Flush();
                Response.Close();
            }
            catch(Exception ex)
            {
                Response.Redirect(Constant.strERRPAGE);          //throw exception on error page
            }
            finally
            {                                                      //FREE THE MEMORY OF VARIABLES
                objGVEXCEL = null;
                objHW = null;
                objSW = null;
            }
        }
        #endregion ExportFunction
    }
    #endregion Default
}


