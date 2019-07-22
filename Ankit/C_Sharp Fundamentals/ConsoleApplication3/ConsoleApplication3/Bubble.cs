using System;
namespace ConsoleApplication3
{
    #region Bubble
    //Name                      : Bubble
    //Auther                    : Ankit Sharma
    //Created Date              : 03/07/2012
    //Description               : To sort an array by bubble sort  
    class Bubble
    {
        #region bubblesort
        public void bubblesort()
        {            
            Common objcommon;                                                           //Declaring an object for class common
            int []arrBubble;                                                            //Declaring an array  
            int intSize;
            try
            {
                objcommon = new Common();                                               //Initializing the object of common
                Console.WriteLine(Constant.strSizeArray);
                intSize = int.Parse(Console.ReadLine());                                //Getting the size of array from user
                arrBubble = new int[intSize];                                           //Initializing the array 
                Console.WriteLine(Constant.strMsgEnterArr);
                arrBubble = objcommon.Getarray(intSize);                                //Calling the function from class common for input array
                Console.WriteLine(Constant.strMsgArray);
                objcommon.ShowArray(arrBubble);
                for (int i = 0; i < intSize; i++)
                {
                    int temp;                                                           //Declaring a temporary variable for swapping
                    for (int j = i + 1; j < intSize; j++)
                    {
                        if (arrBubble[i] > arrBubble[j])
                        {
                            temp = arrBubble[i];                                        //Bubble sort
                            arrBubble[i] = arrBubble[j];
                            arrBubble[j] = temp;
                        }
                    }
                }
                Console.WriteLine(Constant.strMsgArrasc);
                objcommon.ShowArray(arrBubble);                                         //Calling the function of class common to display array
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);                                           //Display messege if Exception occured
            }
            finally 
            {
                objcommon = null;                                                       //Destroying the object of class common
                arrBubble = null;                                                       //Deallocate the array 
            }
        }
        #endregion bubblesort
    }
    #endregion Bubble
}
