using System;
namespace ConsoleApplication3
{
    #region ReviseArray
    //Name                      : ReviseArray
    //Auther                    : Ankit Sharma
    //Created Date              : 27/06/2012
    //Description               : To find how many times a number exists in an array
    class ReviseArray
    {
        Common objcommon;                                                                       //Declaring an object of class common
        #region search
        //*************************************** Function to search a number in array  *************************************************
        public void search()
        {
            int[] arrSa;                                                                         //Declaring an array
            int intNum, intCnt = 0;                                                                 
            try
            {
                objcommon = new Common();                                                               //Initializing object of class common
                Console.WriteLine(Constant.strSizeArray);
                int intsize = int.Parse(Console.ReadLine());                                            //Getting the size of array from user
                arrSa = new int[intsize];                                                            //Initialization of array
                Console.WriteLine("Please enter " + intsize + " numbers:-");
                arrSa = objcommon.Getarray(intsize);                                                 //To enter the elements of array by user                
                Console.WriteLine(Constant.strMsgArray);
                objcommon.ShowArray(arrSa);                                                           //Display the array entered by user
                Console.WriteLine(Constant.strSearch);
                intNum = int.Parse(Console.ReadLine());                                                 //To input the number  to search in array
                for (int i = 0; i < arrSa.Length; i++)
                {
                    if (arrSa[i] == intNum)                                                          //Check if number exists in array
                    {
                        intCnt++;
                    }

                }
                if (intCnt > 0)
                {
                    Console.WriteLine("The number you entered is occured " + intCnt + " times in array");   //Display how many times a n number exists in array
                }
                else
                {
                    Console.WriteLine(Constant.strNotSearch);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally 
            {
                objcommon = null;
            }
        }
        #endregion search
    }
    #endregion ReviseArray
}
