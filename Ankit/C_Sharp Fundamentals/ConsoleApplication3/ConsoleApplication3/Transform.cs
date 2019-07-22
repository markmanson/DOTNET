using System;
namespace ConsoleApplication3
{
    //NAME                      : TRANSFORM
    //AUTHER                    : ANKIT SHARMA
    //CREATED DATE              : 03/07/2012
    //Description               : TO TRANSFORM THE MATRIX   
    class Transform
    {
        Common objcommon;
        //FUNCTION TO TRANSPOSE A MATRIX *****************************************************************************************
        public void transform()
        {
            objcommon = new Common();
            int [ , ]arrTrans;                                                          //DECLARATION OF ARRAY
            int[,] arrRes;                                                              //DECLARATION OF ARRAY
            int intRow;                                                                 //DECLARATION OF AN INT VARIABLE 
            int intCol;                                                                 //DECLARATION OF AN INT VARIABLE
            try
            {
                Console.WriteLine(Constant.strSizeArray + "( Row)");                    //DISPLAY MESSEGE TO ENTER THE ROW SIZE OF MATRIX
                intRow = int.Parse(Console.ReadLine());                                 //TAKING THE ROW SIZE FROM USER
                Console.WriteLine(Constant.strSizeArray + "( col)");                    //DISPLAY MESSEGE TO ENTER THE COULMN SIZE OF MATRIX
                intCol = int.Parse(Console.ReadLine());                                 //TAKING THE COULMN SIZE OF MATRIX FROM USER
                arrTrans = new int[intRow, intCol];                                     //INITIALIZING AN ARRAY TO STORE THE MATRIX ENTER BY USER
                arrRes = new int[intCol, intRow];                                       //INITIALIZING AN ARRAY TO STORE THE TRANSPOSE OF THE MATRIX ENTER BY USER
                Console.WriteLine(Constant.strMsgEnterArr);                             //DISPLAY A MESSEGE TO ENTER THE MATRIX BY USER                
                for (int i = 0; i < intRow; i++)
                {
                    Console.WriteLine("Enter " + (i+1) + " row:-");                     //DISPLAY MESSEGE TO ENTER THE ELEMENTS OF MATRIX ROW-WISE
                    for (int j = 0; j < intCol; j++)
                    {
                        arrTrans[i, j] = int.Parse(Console.ReadLine());                 //TAKING THE ELEMENTS OF MATRIX BY USER
                    }
                }
                Console.WriteLine(Constant.strMsgMat);                                  //MESSEGE TO DISPLAY MATRIX ENTERED BY USER               
                objcommon.ShowMat(arrTrans, intRow, intCol);                            //CALL THE FUNCTION OF COMMON CLASS FOR DISPLAY THE MATRIX
                for (int i = 0; i < intCol; i++)
                {
                    for (int j = 0; j < intRow; j++)
                    {
                         arrRes[i,j]=arrTrans[j, i];                                    //TRANSPOSE OF THE MATRIX AND SAVE IT INTO arrRes
                    }                    
                }
                Console.WriteLine(Constant.strMsgTra);                                  //DISPLAY MESSEGE TO SHOW THE TRANSPOSE OF THE MATRIX
                objcommon.ShowMat(arrRes, intCol, intRow);                              //CALL THE FUNCTION OF COMMON CLASS FOR DISPLAY THE MATRIX
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);                                           //DISPLAY MESSEGE IF ANY ERROR IS OCCURED
            }
            finally
            {
                objcommon = null;                                                       //DESTROYING THE OBJECT OF CLASS COMMON
                arrTrans = null;                                                        //MAKE ARRAY NULL
                arrRes = null;                                                          //MAKE ARRAY NULL
            }
        }
    }
}
