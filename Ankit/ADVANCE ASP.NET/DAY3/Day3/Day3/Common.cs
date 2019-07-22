using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
namespace Day3
{
    #region Common
    /*************************************************************************************************************
     * CLASS NAME                                   :::                     Common                
     * AUTHOR NAME                                  :::                     ANKIT SHARMA
     * DATE                                         :::                     07/09/2012
     * DESCRIPTION                                  :::                     TO MAKE THE COMMON FUNCTIONS WHICH ARE REQUIRED IN APPLICATION 
     * **********************************************************************************************************/
    public class Common
    {
        //DECLARATION OF CONNECTION STRING ***************************************************************************************
        public SqlConnection Connect = new SqlConnection(ConfigurationManager.ConnectionStrings["SQLConnection"].ConnectionString);
        #region Open_Con
        /*************************************************************************************************************
         * FUNCTION NAME                                :::                     Open_Con                
         * AUTHOR NAME                                  :::                     ANKIT SHARMA
         * DATE                                         :::                     07/09/2012
         * DESCRIPTION                                  :::                     TO OPEN THE SQL CONNECTION
         * **********************************************************************************************************/
        public void Open_Con()
        {
            if (Connect.State == System.Data.ConnectionState.Closed)            //CHECK IF SQL CONNECTION IS CLOSED
                Connect.Open();                                                 //OPEN THE SQL CONNECTION
        }
        #endregion Open_Con
        #region Close_Con
        /*************************************************************************************************************
         * FUNCTION NAME                                :::                     Close_Con                
         * AUTHOR NAME                                  :::                     ANKIT SHARMA
         * DATE                                         :::                     07/09/2012
         * DESCRIPTION                                  :::                     TO CLOSE THE SQL CONNECTION
         * **********************************************************************************************************/
        public void Close_Con()
        {
            if (Connect.State == System.Data.ConnectionState.Open)              //CHECK IF SQL CONNECTON IS OPEN
                Connect.Close();                                                //CLOSING THE SQL CONNECTION
        }
        #endregion Close_Con
        #region btnSubmit_Click
        /*************************************************************************************************************
         * FUNCTION NAME                                :::                     METHOD LOG                
         * AUTHOR NAME                                  :::                     ANKIT SHARMA
         * DATE                                         :::                     07/09/2012
         * DESCRIPTION                                  :::                     TO CHECK WHEATHER THE INFORMATION ENTERED
                                                                                 BY USER ARE CORRECT OR NOT
         * **********************************************************************************************************/
        public ArrayList Log(string User,string Pass)
        {
            bool boolAuth = false;
            string strPassword;                                                                 //DECLARATION OF A STRING VARIABLE
            ArrayList arrlstMyList = new ArrayList();                                           //DECLARATION OF THE OBJECT OF AN ARRAYLIST
            string strAuth;                                                                     //DECLARATION OF A STRING VARIABLE
            if (Cmpr_User(User))                                                                //CALL THE FUNCTION CMPR_USER
            {
                strPassword = Return_Pass(User);                                                //CALL THE FUNCTION RETURN_PASS
                if (Pass == strPassword)                                                        //IF TXTPASS.TEXT AND STRPASSWORD ARE EQUAL
                {
                    strAuth= Constant.strWelcome;                                               //ASSIGN STRAUTH THE MESSEGE "WELCOME"
                    boolAuth = true;                                                            //SET BOOLAUTH TRUE
                }
                else
                    strAuth=Constant.strPassInval;                                              //ASSIGN STRAUTH MESSEGE "PASSWORD IS NOT VALID"
            }
            else
                strAuth = Constant.strUserInval;                                                //ASSIGN STRAUTH MESSEGE "USERNAME IS NOT VALID"
            arrlstMyList.Add(strAuth);                                                          //ADD STRING TO ARRAYLIST 
            arrlstMyList.Add(boolAuth);                                                         //ADD BOOLAUTH TO ARRAYLIST
            return arrlstMyList;                                                                //RETURN ARRAYLIST
        }
        #endregion BtnSubmit_Click
        #region Return_Pass
        /*************************************************************************************************************
         * FUNCTION NAME                                :::                     Return_Pass                
         * AUTHOR NAME                                  :::                     ANKIT SHARMA
         * DATE                                         :::                     07/09/2012
         * DESCRIPTION                                  :::                     TO RETURN THE PASSWORD WHERE USER NAME IS GIVEN
         *                                                                      (USING TABLE DETAILS)
         * **********************************************************************************************************/
        public string Return_Pass(string UserName)
        {
            SqlDataAdapter adpt;                                                            //DECLARATION OF OBJECT OF SQL DATA ADAPTER
            DataTable Dt;                                                                   //DECLARATION OF OBJECT OF DATA TABLE
            try
            {
                Dt = new DataTable();                                                       //INITIALIZATION OF OBJECT OF 
                Open_Con();                                                                 //OPEN THE SQL CONNECTION
                adpt = new SqlDataAdapter(Constant.strSelPassWhr + UserName + Constant.strQuote, Connect);
                adpt.Fill(Dt);                                                              //FILLING THE DATA TABLE BY SQL DATA ADAPTER
                Close_Con();                                                                //CLOSE THE SQL CONNECTION 
            }
            finally
            {
                Close_Con();                                                                //CLOSING THE SQL CONNECTION
                adpt = null;                                                                //AASIGN NULL TO THE OBJECT OF SQL DATA ADAPTER
            }
            return (String)Dt.Rows[0][0];                                                   //RETURN THE VALUE OF DATA TABLE               
        }
        #endregion Return_Pass
        #region Cmpr_Pass
        /*************************************************************************************************************
         * FUNCTION NAME                                :::                     Cmpr_User                
         * AUTHOR NAME                                  :::                     ANKIT SHARMA
         * DATE                                         :::                     07/09/2012
         * DESCRIPTION                                  :::                     TO COMPARE THE USER
         * **********************************************************************************************************/
        public bool Cmpr_User(string User)
        {
            string[] strArr = new string[5];                                    //DECLARATION OF STRING TYPE ARRAY
            SqlDataAdapter adpt;                                                //DECLARATION OF THE OBJECT OF SQL DATA ADAPTER
            DataTable Dt;                                                       //DECLARATION OF THE OBJECT OF DATATBLE
            int intFlag = 0;                                                    //INITIALIZATION OF INTEGER TYPE VARIABLE
            try
            {
                Dt = new DataTable();                                           //INITIALIZATION OF OBJECT OF DATATABLE
                Open_Con();                                                     //CALL THE FUNCTION TO OPEN THE SQL CONNECTION 
                adpt = new SqlDataAdapter(Constant.strSelUser, Connect);        //INITIALIZATION OF OBJECT OF SQL DATA ADAPTER
                adpt.Fill(Dt);                                                  //FILLING THE DATA INTO DATATABLE
                Close_Con();                                                    //CLOSING THE SQL CONNECTION
                for (int i = 0; i < Dt.Rows.Count; i++)
                {
                    strArr[i] = (String)Dt.Rows[i][0];                          //STORE THE DATATABLE INTO STRING TYPE ARRAY
                }
                for (int i = 0; i < strArr.Length; i++)
                {
                    if (User == strArr[i])                                      //CHECK IF TXTNAME.TEXT EQUALS TO STRARR
                        intFlag++;                                              //INCREMENT IN THE FLAG
                }
                if (intFlag == 0)                                               //IF FLAG IS 0
                    return false;                                               //RETURN FALSE
                else                                                            //IF FLAG IS NOT O 
                    return true;                                                //RETURN TRUE
            }
            finally
            {
                Close_Con();                                                    //CLOSING THE SQL CONNECTION 
                Dt = null;                                                      //ASSIGN NULL TO THE OBJECT OF DATA TABLE
                adpt = null;                                                    //ASSIGN NULL TO SQL DATA ADAPTER
                strArr = null;                                                  //ASSIGN NULL TO STRING ARRAY
            }
        }
        #endregion Cmpr_User
    }
    #endregion Common
}
