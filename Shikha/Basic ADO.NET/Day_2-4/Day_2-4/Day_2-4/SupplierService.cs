using System;
using System.Collections;
using System.Data.SqlClient;
using System.Text;

namespace Day_2_4
{
     #region SupplierService
    public class SupplierService
    {
         #region GetSupplier

        public ArrayList GetSuppliers()                              //FUNCTION GETSUPPLIER WITH RETURN TYPE AN ARRAYLIST 
        {
            ArrayList arrlstSupplier ;                              //DECLARATION OF AN ARRAYLIST
            SupplierInfo objSupp;                                   //DECLARATION OF OBJECT OF CLASS SUPPLIERINFO
            Common connObj;
            StringBuilder strB1;                                 //DECLARATION STRING BUILDER
            SqlDataReader Reader;                                   //DECLARATION OF SQL DATA READER
            SqlCommand Cmd;                                         //DECLARATION OF SQL COMMAND
            string strcons;
            try
            {

                connObj = new Common();                                                   //INITIALIZATION OF SQL CONNECTION
                connObj.OpenConnection();                                                                //OPEN CONNECTION 
                strB1 = new StringBuilder();                                            
                strB1.Append(Constant.strBuil1);                                           //APPEND THE STRING BUILEDR
                strB1.Append(Constant.strBuil2);                             
                strB1.Append(Constant.strBuil3);                                          
                strB1.Append(Constant.strBuiSup);                                          
                arrlstSupplier = new ArrayList();                                           //INITIALIZATION OF ARRAY LIST
                strcons = strB1.ToString();
                Cmd = new SqlCommand(strcons, connObj.connC);                              //INITIALIZATION OF SQL COMMAND
                Reader = Cmd.ExecuteReader();                                               //INITIALIZATION OF READER
                if (Reader.HasRows)                                                         //IF READER IS NOT EMPTY
                {
                    while (Reader.Read())                                                   //IF READER IS REAING DATA
                    {
                        objSupp = new SupplierInfo();                                       //INITIALIZATION OF OBJECT OF SUPPLIERINFO                        
                        objSupp.SuppID = Reader.GetInt32(0);                                //ASSIGN THE DATA OF READER(0) TO PROPERTY
                        objSupp.CmpnyNme = Reader.GetString(1);                             //ASSIGN THE DATA OF READER(1) TO PROPERTY
                        objSupp.ContctNme = Reader.GetString(2);                            //ASSIGN THE DATA OF READER(2) TO PROPERTY
                        objSupp.CntctTitle = Reader.GetString(3);                           //ASSIGN THE DATA OF READER(3) TO PROPERTY
                        objSupp.Address = Reader.GetString(4);                              //ASSIGN THE DATA OF READER(4) TO PROPERTY
                        objSupp.City = Reader.GetString(5);                                 //ASSIGN THE DATA OF READER(5) TO PROPERTY
                        if (Reader.IsDBNull(6))                                             //CHECK IF DATA IS NULL 
                        {
                            objSupp.Region = "";                                            //ASSIGN EMPTY STRING TO PROPERTY
                        }
                        else                                                                //IF DATA IS NOT NULL
                        {
                            objSupp.Region = Reader.GetString(6);                           //ASSIGN THE DATA OF READER(6) TO PROPERTY
                        }
                        objSupp.PstlCd = Reader.GetString(7);                               //ASSIGN THE DATA OF READER(7) TO PROPERTY
                        objSupp.Cntry = Reader.GetString(8);                                //ASSIGN THE DATA OF READER(8) TO PROPERTY
                        objSupp.Phn = Reader.GetString(9);                                  //ASSIGN THE DATA OF READER(9) TO PROPERTY
                        if (Reader.IsDBNull(10))                                            //CHECK IF DATA IS NULL
                        {
                            objSupp.Fx = "";                                                //ASSIGN EMPTY STRING TO PROPERTY
                        }
                        else                                                                //IF DATA IS NOT NULL
                        {
                            objSupp.Fx = Reader.GetString(10);                              //ASSIGN THE DATA OF READER(10) TO PROPERTY
                        }
                        if (Reader.IsDBNull(11))                                            //CHECK IF DATA IS NULL
                        {
                            objSupp.HmPg = "";                                              //ASSIGN EMPTY STRING TO PROPERTY
                        }
                        else                                                                //IF DATA IS NOT NULL
                        {
                            objSupp.HmPg = Reader.GetString(11);                            //ASSIGN THE DATA OF READER(11) TO PROPERTY
                        }
                        arrlstSupplier.Add(objSupp);                                        //ADD ITEM TO ARRAYLIST
                                              
                    }
                    Reader.Close();                                                         //CLOSE THE DATA READER                  
                }
                return arrlstSupplier;                                                      //RETURN ARRAYLIST
            }
            catch (Exception )                                                              //CHECK FOR EXCEPTION 
            {
                return null;                                                                //RETURN NULL IF EXCEPTION 
            }
            finally
            {
               
                objSupp=null;                                                               //DESTROYING OF OBJECT OF CLASS SUPPLIERINFO
                connObj = null;                                                             //DESTROYING OF OBJECT OF SQL CONNECTION 
                strB1 = null;                                                            //DESTROYING STRING BUILDER
                Reader = null;                                                              //DESTROYING OF SQL DATA READER
                Cmd = null;                                                                 //DESTROYING OF SQL COMMAND
            }
        }
        #endregion GetSupplier
    }
    #endregion SupplierService
    }

