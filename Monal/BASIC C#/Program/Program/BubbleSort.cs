using System;

namespace Program
{
    /*--------------------------------------------------------------------------------------------------------------------
         Name:BubbleSort.cs
         Author:Monal Shah
         Description:"Accept number from the user.
                      code for Bubblesorting".
       
         CreatedDate: 2010/09/09 by Monal Shah
 -------------------------------------------------------------------------------------------------------------------
 */
    class BubbleSort
    {
        #region BubbleSorting
        /// <summary>
        /// Name:BubbleSorting
        /// parametres:0
        /// Description:Create the bubble sort an array 
        /// Author:Monal shah
        /// CreatedDate:2010/09/09
        /// </summary>
        public void BubbleSorting()
        {
            try
            {
                bool bolSwap = true;//boolean variable bolSwap;
                int intK = 0;//intK is variable name of integer datatype
                int intTemp;//intTemp is variable name of integer datatype
                Console.WriteLine("Please Enter Total number value you want:");
                int intNum = System.Convert.ToInt32(Console.ReadLine()); //intNum is the variable name of the integer datatype.it is used for accepting input from the user from console.
                int[] intArrnum = new int[intNum]; //intArrnum is the variable name of the integer datatype size with intNum.
                for (int intI = 0; intI < intArrnum.Length; intI++)
                {
                    Console.WriteLine("Please Eneter Array Value " + intI);//here user enter the array value till the intArrnum length
                    intArrnum[intI] = System.Convert.ToInt32(Console.ReadLine());//accepting value from the console
                }
                while (bolSwap)
                {
                    bolSwap = false;
                    intK++; //incremnt intK
                    for (int intI = 0; intI < intArrnum.Length - intK; intI++)
                    {
                        /*
                         * If intArrnum[intI] is greater than intArrnum[intI+1] then swpping is done.
                         * intArrnum[intI] value swap into intTemp
                         * intArrnum[intI+1] value swap into intArrnum[intI]
                         * intTemp value swap into intArrnum[intI+1]
                         */
                        if (intArrnum[intI] > intArrnum[intI + 1])
                        {
                            intTemp = intArrnum[intI];
                            intArrnum[intI] = intArrnum[intI + 1];
                            intArrnum[intI + 1] = intTemp;
                            bolSwap = true;
                        }
                    }
                }
                for (int intJ = 0; intJ < intArrnum.Length; intJ++)
                {
                    Console.WriteLine(intArrnum[intJ]);//Print the value in sorting 
                }
                Console.ReadLine();
            }
            catch(Exception exException)
            {
                Console.WriteLine("Error:"+exException.Message);
            }
        }
        
        #endregion

    }
}
