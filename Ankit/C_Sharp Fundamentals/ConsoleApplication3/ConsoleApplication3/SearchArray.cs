using System;
namespace ConsoleApplication3
{
    #region SearchArray
    //Name                      : SearchArray
    //Auther                    : Ankit Sharma
    //Created Date              : 27/06/2012
    //Description               : To check whether a number exists in an array or not
    class SearchArray
    {
        Common objcommon ;                                                                  //Declaring an object of class common
        #region search
        //*********************Function to get an array from user and check whether a number is exists in array or not******************
        public void search()
        {
            objcommon = new Common();                                                           //Initializing object of class common
            int[] arrSa;
            int intNum, intCnt, intSize;
            try
            {
                intCnt = 0;
                Console.WriteLine(Constant.strSizeArray + "(You can not enter more than 5):-");
                intSize = int.Parse(Console.ReadLine());                                                //To get the size of array entered by user
                if (intSize > 5)
                {
                    Console.WriteLine(Constant.strNotSize);
                }
                else
                {
                    arrSa = new int[intSize];                                                            //Initialization of array
                    Console.WriteLine("Please enter " + intSize + " numbers:-");
                    arrSa = objcommon.Getarray(intSize);                                                  //Getting the numbers by user entered to add to array                                                   
                    Console.WriteLine(Constant.strMsgArray);
                    objcommon.ShowArray(arrSa);                                                           //Display the array entered by the user
                    Console.WriteLine(Constant.strSearch);
                    intNum = int.Parse(Console.ReadLine());                                               //To input the number user wants to searh in array
                    for (int i = 0; i < arrSa.Length; i++)
                    {
                        if (arrSa[i] == intNum)                                                          //To compare whether the number exists in array
                        {
                            intCnt++;
                        }
                    }
                    if (intCnt != 0)
                    {
                        Console.WriteLine(Constant.strYesSearch);                     //Display the messege if number exists in array
                    }
                    else
                    {
                        Console.WriteLine(Constant.strNotSearch);                  ////Display the messege if number exists in array
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                objcommon = null;                                                  //Destroy the object of class common.cs
                arrSa = null;                                                      //Destroy array named arrSa
            }
        }
        #endregion search
    }
    #endregion SearchArray
}

                