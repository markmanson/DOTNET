using System;
namespace ConsoleApplication3
{
    #region CopyArray
    //Name                      : CopyArray
    //Auther                    : Ankit Sharma
    //Created Date              : 28/06/2012
    //Description               : To find how many times a number exists in an array
    class CopyArray
    {        
        Common objcommon;                                                                           //Declaring the object for common
        #region cpyarr
        //*********************************************** Function to copy two array in a single array************************************************
        public void cpyarr()
        {
            int[] arrcpy1 ;                                                                   //Declaratoin of an int type array 
            int[] arrcpy2 ;                                                                 //Declaratoin of an int type array
            int[] arrcpy3 ;                                                                //Declaratoin of an int type array
            int intcount1;
            int intcount2;
            try
            {
                objcommon = new Common();                                                                 //Initializing of object of class common
                arrcpy1 = new int[5];                                                                    //Initialization of an int type array 
                arrcpy2 = new int[5];                                                                    //Initialization of an int type array 
                arrcpy3 = new int[10];                                                                   //Initialization of an int type array 
                Console.WriteLine(Constant.strInputArrayInt5);
                arrcpy1 = objcommon.Getarray(5);                                                      //CALLING THE FUNCTION OF CLASS COMMON TO INPUT AN ARRAY                
                Console.WriteLine(Constant.strInputArrayInt5);
                arrcpy2 = objcommon.Getarray(5);                                                     // CALLING THE FUNCTION OF CLASS COMMON TO INPUT AN ARRAY          
                Console.WriteLine(Constant.strMsgArray);
                objcommon.ShowArray(arrcpy1);
                Console.WriteLine(Constant.strMsgArray);
                objcommon.ShowArray(arrcpy2);
                intcount1 = 0;
                intcount2 = 0;
                for (int i = 0; i < 10; i++)
                {
                    if (i % 2 != 0)                                                         //Check if position is even
                    {
                        arrcpy3[i] = arrcpy2[intcount1];
                        intcount1++;
                    }
                    else
                    {                                                                       //If position is odd
                        arrcpy3[i] = arrcpy1[intcount2];
                        intcount2++;
                    }
                }
                Console.WriteLine(Constant.strMsgFinalArray);
                objcommon.ShowArray(arrcpy3);                                                //Display the final Array                                                                 
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                objcommon = null;
                arrcpy1 = null;
                arrcpy2 = null;
                arrcpy3 = null;
            }
        }
        #endregion cpyarr
    }
    #endregion CopyArray
}
