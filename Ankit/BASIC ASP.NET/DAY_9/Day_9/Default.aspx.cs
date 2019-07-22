using System;
using System.Data;
using System.Data.SqlClient;
namespace Day_9
{
    #region _Default
    /*************************************************************************************************************
       CLASS NAME                         ::::                    _Default
       AUTHOR                             ::::                    ANKIT
       DATE                               ::::                    22-07-2012
       DESCRIPTION                        ::::                    TO MAKE A CLASS DEFAULT PAGE
      ************************************************************************************************************/
    public partial class _Default : System.Web.UI.Page
    {
        #region Page_Load
      /*************************************************************************************************************
      FUNCTION NAME                      ::::                    Page_Load
      AUTHOR                             ::::                    ANKIT
      DATE                               ::::                    22-07-2012
      DESCRIPTION                        ::::                    TO MAKE A PAGE_LOAD EVENT
     ************************************************************************************************************/
        protected void Page_Load(object sender, EventArgs e)
        {
            txtName.Focus();                                                                //SET FOCUS TO TXTNAME
        }
        #endregion Page_Load
        #region btnSubmit_Click
        /*************************************************************************************************************
         * FUNCTION NAME                                :::                     btnSubmit_Click                
         * AUTHOR NAME                                  :::                     ANKIT SHARMA
         * DATE                                         :::                     27/08/2012
         * DESCRIPTION                                  :::                     CLICK EVENT OF BUTTON SUBMIT
         * **********************************************************************************************************/
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string strPassword;                                                             //DECLARATION OF A STRING VARIABLE
            if (Cmpr_User())                                                                //CALL THE FUNCTION CMPR_USER
            {
                strPassword = Return_Pass();                                                //CALL THE FUNCTION RETURN_PASS
                if (txtPass.Text == strPassword)                                            //IF TXTPASS.TEXT AND STRPASSWORD ARE EQUAL
                {
                    Session[Constant.strLoginDeatils] = txtName.Text + strPassword;         //STORE THE LOGIN DETAILS INTO SESSION 
                }
                else
                {
                    Session[Constant.strLoginDeatils] = null;                               //ASSIGN NULL TO SESSION
                }
            }
            else
            {
                Session[Constant.strLoginDeatils] = null;                                   //ASSIGN NULL TO SESSION
            }
            if (Session[Constant.strLoginDeatils] != null)                                  //CHECK IF SESSION IS NOT NULL
            {
                Response.Redirect(Constant.strSecure);                                           //REDIRECT TO SECURE.ASPX
            }
            else
            {
                Response.Write(Constant.strUserNotVal);
                //Response.Redirect(Constant.strDef);                                          //REDIRECT TO DEFAULT.ASPX
            }
        }
        #endregion BtnSubmit_Click
        #region Return_Pass
        /*************************************************************************************************************
         * FUNCTION NAME                                :::                     Return_Pass                
         * AUTHOR NAME                                  :::                     ANKIT SHARMA
         * DATE                                         :::                     27/08/2012
         * DESCRIPTION                                  :::                     TO RETURN THE PASSWORD
         * **********************************************************************************************************/
        public string Return_Pass()
        {
            Common objCommon;                                                               //DECLARATION OF THE OBJECT OF CLASS COMMON
            SqlDataAdapter adpt;                                                            //DECLARATION OF OBJECT OF SQL DATA ADAPTER
            DataTable Dt;                                                                   //DECLARATION OF OBJECT OF DATA TABLE
            try
            {
                objCommon = new Common();                                                   //INITIALIZATION OF THE OBJECT OF CLASS COMMON
                Dt = new DataTable();                                                       //INITIALIZATION OF OBJECT OF 
                objCommon.Open_Con();                                                                 //OPEN THE SQL CONNECTION
                adpt = new SqlDataAdapter(Constant.strSelPassWhr + txtName.Text + Constant.strQuote, objCommon.Connect);
                adpt.Fill(Dt);                                                              //FILLING THE DATA TABLE BY SQL DATA ADAPTER
                objCommon.Close_Con();                                                            //CLOSE THE SQL CONNECTION 
                return (String)Dt.Rows[0][0];                                               //RETURN THE VALUE OF DATA TABLE                
            }
            catch (Exception )                                                              //IF EXCEPTION IS OCCURED
            {
                return null;                                                                //RETURN NULL 
            }
        }
        #endregion Return_Pass
        #region Cmpr_Pass
        /*************************************************************************************************************
         * FUNCTION NAME                                :::                     Cmpr_User                
         * AUTHOR NAME                                  :::                     ANKIT SHARMA
         * DATE                                         :::                     08/08/2012
         * DESCRIPTION                                  :::                     TO COMPARE THE USER
         * **********************************************************************************************************/
        public bool Cmpr_User()
        {
            Common objCommon;                                                   //DECLARATION OF OBJECT OF CLASS COMMON
            string[] strArr = new string[5];                                    //DECLARATION OF STRING TYPE ARRAY
            SqlDataAdapter adpt;                                                //DECLARATION OF THE OBJECT OF SQL DATA ADAPTER
            DataTable Dt;                                                       //DECLARATION OF THE OBJECT OF DATATBLE
            int intFlag = 0;                                                          //INITIALIZATION OF INTEGER TYPE VARIABLE
            try
            {
                objCommon = new Common();                                       //INITIALIZATION OF OBJECT OF CLASS COMMON
                Dt = new DataTable();                                           //INITIALIZATION OF OBJECT OF DATATABLE
                objCommon.Open_Con();                                           //CALL THE FUNCTION TO OPEN THE SQL CONNECTION 
                adpt = new SqlDataAdapter(Constant.strSelUser, objCommon.Connect);       //INITIALIZATION OF OBJECT OF SQL DATA ADAPTER
                adpt.Fill(Dt);                                                  //FILLING THE DATA INTO DATATABLE
                objCommon.Close_Con();                                          //CLOSING THE SQL CONNECTION
                for (int i = 0; i < Dt.Rows.Count; i++)
                {
                    strArr[i] = (String)Dt.Rows[i][0];                          //STORE THE DATATABLE INTO STRING TYPE ARRAY
                }
                for (int i = 0; i < strArr.Length; i++)
                {
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
                Response.Redirect(Constant.strError);                                //REDIRECT TO ERROR.ASPX
                return false;                                                   //RETURN FALSE
            }
            finally
            {
                objCommon = null;                                               //ASSIGN NULL TO THE OBJECT OF CLASS COMMON
                Dt = null;                                                      //ASSIGN NULL TO THE OBJECT OF DATA TABLE
                adpt = null;                                                    //ASSIGN NULL TO SQL DATA ADAPTER
                strArr = null;                                                  //ASSIGN NULL TO STRING ARRAY
            }
        }
        #endregion Cmpr_User
    }
    #endregion _Default
}
