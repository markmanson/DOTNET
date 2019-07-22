using System;
namespace ConsoleApplication3
{
    #region SortArray
    //Name                      : SortArray
    //Auther                    : Ankit Sharma
    //Created Date              : 27/06/2012
    //Description               : To sort an array in ascending order
    class SortArray
    {
        Common objcommon;
        public int[] arrsort;   
        #region sortarr
        //Function to sort the array in ascending order
        public int[] sortarr(int[] arrsort)
        {
            int intsize;
            try
            {
                objcommon = new Common();
                Console.WriteLine(Constant.strSizeArray);                                           //Asking about the size of array to user     
                intsize = int.Parse(Console.ReadLine());                                            //Getting the size of array from user
                arrsort = new int[intsize];                                                          //Initialising the array
                Console.WriteLine("Please enter " + intsize + " number:-");
                arrsort = objcommon.Getarray(intsize);                                               //Getting the numbers to add in array from user         
                Console.WriteLine(Constant.strMsgArray);
                objcommon.ShowArray(arrsort);                                                        //Display the array entered by the user
                Array.Reverse(arrsort);                                                              //Reverse the array
                Console.WriteLine(Constant.strMsgArrrev);                                            // Display the messege Reverse of array is
                objcommon.ShowArray(arrsort);               
                for (int i = 0; i < arrsort.Length; i++)
                {
                    for (int j = i + 1; j < intsize; j++)
                    {
                        if (arrsort[i] > arrsort[j])                                            //Making comparison between elements of array
                        {
                            int inttemp;                                                        //Temporary variable for swaping the values
                            inttemp = arrsort[i];
                            arrsort[i] = arrsort[j];
                            arrsort[j] = inttemp;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }                                                                          
            finally
            {
                objcommon=null;
            }
            return arrsort;                                                                      //Return the sorted array   
        }
        #endregion sortarr
    }
    #endregion SortArray
}
