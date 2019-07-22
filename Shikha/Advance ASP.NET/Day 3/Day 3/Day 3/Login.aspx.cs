using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Day_3
{
    #region _Default
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- _Default
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- THE CLASS FOR LOGIN TABLE USING DATABASE.
    //      CREATED DATE    :- 2012/17/09
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class _Default : System.Web.UI.Page
    {
        #region submitClick
        Common objCommon;
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- btnSubmit_Click
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- CLICK EVENT FOR SUBMIT INFORMATION AND CHECK FROM DATABASE.
        //      CREATED DATE    :- 2012/17/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
       protected void btnSubmit_Click(object sender, EventArgs e)
        {                                                             //DECLARATION OF OBJECTS
            SqlDataAdapter objAdapDA;
            StringBuilder objSb; DataTable dt;
            string strQuery;
            LgnFrm.LblMsg.Visible = false;
            try
            {
                objCommon = new Common();                       //CREATE OBJECT OF COMMON CLASS
                objCommon.OpenConnection();                     //OPEN CONNECTION 
               if(LgnFrm.txtUserName.Text != Constant.strBLANK && LgnFrm.txtPassword.Text != Constant.strBLANK) //CHEK CONDITION FOR EMPTY TEXTBOX OR NOT IF NOT THEN CHECK FROM DATABASE
                {
                    objSb = new StringBuilder();                   //CREATE OBJECT FOE STRINGBUILDER CLASS
                    dt = new DataTable();                          //CREATE OBJECT FOE DATA TABLE
                    objSb.Append(Constant.strSELUSRNAME);          //APPEND STRING
                    objSb.Append(Constant.strQUOT + LgnFrm.txtUserName.Text + Constant.strQUOT);
                    objSb.Append(Constant.strPASSWORD);
                    objSb.Append(Constant.strQUOT + LgnFrm.txtPassword.Text + Constant.strQUOT);
                    strQuery = objSb.ToString();
                    objAdapDA = new SqlDataAdapter(strQuery, objCommon.connC);             //pass connection and query into data adapter
                    objAdapDA.Fill(dt);                                     //FILL DATA TABLE               
                    if (dt.Rows.Count==0)                                  //data NOT THEN UNAUTHORISEDD USER                                
                    {
                        LgnFrm.LblMsg.Visible = true;
                        LgnFrm.LblMsg.Text =Constant.strUNAUTHORIZEDUSER;
                    }
                    else
                    {
                        LgnFrm.LblMsg.Visible = true;
                        LgnFrm.LblMsg.Text = Constant.strAUTHORIZEDUSER;      //AUTHORIZED USER
                    }
               }
            }
            catch 
            {
             Response.Redirect(Constant.strERRORPAGE);           //THROW EXCEPTION
            }
            finally
            {                                                         //REALLOCATE MEMORY
                objCommon.CloseConnection();
                objCommon = null;
                dt = null;
                objSb = null; objAdapDA = null;
            }
        }
        #endregion submitClick
    }
    #endregion _Default
}
