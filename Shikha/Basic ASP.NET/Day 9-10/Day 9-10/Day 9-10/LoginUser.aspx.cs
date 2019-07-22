using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace Day_9_10
{
    #region LoginUser
    // ---------------------------------------------------------------------------------------------------------------------------------------------
    //      NAME            :- LoginUser
    //      AUTHOR NAME     :- Shikha Malik
    //      DESCRIPTION     :- The Class For Show Login Details on web Page.
    //      CREATED DATE    :- 2012/06/09
    //----------------------------------------------------------------------------------------------------------------------------------------------
    public partial class LoginUser : System.Web.UI.Page
    {
        #region Page_Load
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- Page_Load
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- On Page_Load Set focus.
        //      CREATED DATE    :- 2012/06/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        Common objCommon;
        protected void Page_Load(object sender, EventArgs e)
        {
            txtName.Focus();
        }
        #endregion Page_Load
        #region btnSubmit_Click
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- btnSubmit_Click
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- On Submit Click Match user name and password from database.
        //      CREATED DATE    :- 2012/06/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string strPassword;                                                             //DECLARATION OF A STRING VARIABLE
            if (Cmpr_User())                                                                //CALL THE FUNCTION CMPR_USER
            {
                strPassword = Return_Pass();                                                //CALL THE FUNCTION RETURN_PASS
                strPassword = strPassword.Trim();
                txtPass.Text = txtPass.Text.Trim();
                if (txtPass.Text == strPassword)                                            //IF TXTPASS.TEXT AND STRPASSWORD ARE EQUAL
                {
                    Session[Constant.strLOGINDETAILS] = txtName.Text + Constant.strBLANK + strPassword + Constant.strBLANK;         //STORE THE LOGIN DETAILS INTO SESSION 
                }
                else
                {
                    Session[Constant.strLOGINDETAILS] = null;                               //ASSIGN NULL TO SESSION
                }
            }
            else
            {
                Session[Constant.strLOGINDETAILS] = null;                                   //ASSIGN NULL TO SESSION
            }
            if (Session[Constant.strLOGINDETAILS] != null)                                  //CHECK IF SESSION IS NOT NULL
            {
                Response.Redirect(Constant.strSECUREPAGE);                                           //REDIRECT TO SECURE.ASPX
            }
            else
            {
                 ClientScript.RegisterStartupScript(Page.GetType(), Constant.strVALIDATION, Constant.strJAVASCRIPT);                                                                      //REDIRECT TO DEFAULT.ASPX
            }
        }
    #endregion btnSubmit_Click
        #region Password
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- Return_Pass()
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- Return_pass Method Return Password if enter password math with database password
        //      CREATED DATE    :- 2012/06/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        public string Return_Pass()
        {
            SqlDataAdapter objAdpt;                                                            //DECLARATION OF OBJECT OF SQL DATA ADAPTER
            DataTable Dt;                                                                   //DECLARATION OF OBJECT OF DATA TABLE
            try
            {
                objCommon = new Common();                                                   //INITIALIZATION OF THE OBJECT OF CLASS COMMON
                Dt = new DataTable();                                                       //INITIALIZATION OF OBJECT OF 
                objCommon.OpenConnection();                                                                 //OPEN THE SQL CONNECTION
                objAdpt = new SqlDataAdapter(Constant.strSELECTPASS + txtName.Text + Constant.strQUOTE, objCommon.connC);
                objAdpt.Fill(Dt);                                                              //FILLING THE DATA TABLE BY SQL DATA ADAPTER
                
                return (String)Dt.Rows[0][0];                                               //RETURN THE VALUE OF DATA TABLE                
            }
            catch (Exception)                                                              //IF EXCEPTION IS OCCURED
            {
                return null;                                                                //RETURN NULL 
            }
            finally
            {
                objCommon.CloseConnection();                   //CLOSE THE SQL CONNECTION 
            }
        }
        #endregion Password
        #region UserName
        // ---------------------------------------------------------------------------------------------------------------------------------------------
        //      NAME            :- Cmpr_User()
        //      AUTHOR NAME     :- Shikha Malik
        //      DESCRIPTION     :- Cmpr_User return User name if it matc with database user name
        //      CREATED DATE    :- 2012/06/09
        //----------------------------------------------------------------------------------------------------------------------------------------------
        public bool Cmpr_User()
        {
                                                              //DECLARATION OF OBJECT OF CLASS COMMON
            string[] strArr = new string[5];                                    //DECLARATION OF STRING TYPE ARRAY
            SqlDataAdapter objAdpt;                                                //DECLARATION OF THE OBJECT OF SQL DATA ADAPTER
            DataTable Dt;                                                       //DECLARATION OF THE OBJECT OF DATATBLE
            int intFlag = 0;                                                          //INITIALIZATION OF INTEGER TYPE VARIABLE
            try
            {
                objCommon = new Common();                                       //INITIALIZATION OF OBJECT OF CLASS COMMON
                Dt = new DataTable();                                           //INITIALIZATION OF OBJECT OF DATATABLE
                objCommon.OpenConnection();                                           //CALL THE FUNCTION TO OPEN THE SQL CONNECTION 
                objAdpt = new SqlDataAdapter(Constant.strSELUSER, objCommon.connC);       //INITIALIZATION OF OBJECT OF SQL DATA ADAPTER
                objAdpt.Fill(Dt);                                                  //FILLING THE DATA INTO DATATABLE
                                                                      
                for (int i = 0; i < Dt.Rows.Count; i++)
                {
                    strArr[i] = (String)Dt.Rows[i][0];                          //STORE THE DATATABLE INTO STRING TYPE ARRAY
                    strArr[i] = strArr[i].Trim();
                   
                }
                for (int i = 0; i < strArr.Length; i++)
                {
                    txtName.Text = txtName.Text.Trim();
                    if (txtName.Text == strArr[i])                              //CHECK IF TXTNAME.TEXT EQUALS TO STRARR
                        intFlag++;                                              //INCREMENT IN THE FLAG
                }
                if (intFlag == 0)
                    return false;                                                   //RETURN FALSE
                else
                    return true;
            }
            catch                                                               //IF EXCEPTION OCCURES
            {
                Response.Redirect(Constant.strERRORPAGE);                                //REDIRECT TO ERROR.ASPX
                return false;                                                   //RETURN FALSE
            }
            finally
            {
                objCommon.CloseConnection();                         //CLOSING THE SQL CONNECTION
                objCommon = null;                                               //ASSIGN NULL TO THE OBJECT OF CLASS COMMON
                Dt = null;                                                      //ASSIGN NULL TO THE OBJECT OF DATA TABLE
                objAdpt = null;                                                    //ASSIGN NULL TO SQL DATA ADAPTER
                strArr = null;                                                  //ASSIGN NULL TO STRING ARRAY
            }
        }
        #endregion UserName
    }
    #endregion LoginUser
}
