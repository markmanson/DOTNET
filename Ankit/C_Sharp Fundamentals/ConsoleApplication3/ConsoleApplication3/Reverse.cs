using System;
namespace ConsoleApplication3
{
    #region Reverse
    //Name                      : ReverseArray
    //Auther                    : Ankit Sharma
    //Created Date              : 27/06/2012
    //Description               : To disply the reverse of an array
    class Reverse
    {
        public int [] arrRev ;    
        int intSize;
        Common objcommon ;                                                                              //Declaring the object for class common      
        #region rvrsarray
        //*******************************************Function to reverse the array*********************************************************************
        public int [] rvrsarray(int [] arrRev)
        {
            try
            {
                objcommon=new Common ();                                                                   //Initializing object of class common
                Console.WriteLine(Constant.strSizeArray);
                intSize = int.Parse(Console.ReadLine());                                                    //To get the size of array by user
                arrRev = new int[intSize];                                                               //Initializing the array
                Console.WriteLine("Please enter " + intSize + " numbers to add to array");
                arrRev = objcommon.Getarray(intSize);
                Console.WriteLine(Constant.strMsgArray);
                objcommon.ShowArray(arrRev);
                Array.Reverse(arrRev);                                                                 //To reverse the array                                                                                                        
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }            
           finally
           {
              objcommon = null;                                                                         //Destroying the object of class common               
           }
            return arrRev;                                                                              //Return array 
        }
        #endregion rvrsarray
    }
    #endregion Reverse
}
