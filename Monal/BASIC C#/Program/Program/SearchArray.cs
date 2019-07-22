using System;

namespace Program
{

    /*--------------------------------------------------------------------------------------------------------------------
           Name:SearchArray.cs
           Author:Monal Shah
           Description:"This program Create an array of integers and add any 5 numbers from 1 to 10 to the array. 
                        Accept a number from the user, and print if this number exists in the array or not."

           CreatedDate: 2010/09/06 by Monal Shah
   -------------------------------------------------------------------------------------------------------------------
   */

    class SearchArray
    {
        /*---------------------------------------------------------------------------------------------------------------
         Name:SearchingArrayValue
         Paramametres:0
         Description:This method is search the elements from the array.
                     and describing the number is into the array or not and Print if the number is exixsts 
                     othervise Print it is not exists in the array.

         Author:Monal Shah
         CreatedDate: 2010/09/06 by Monal Shah
     ---------------------------------------------------------------------------------------------------------------
     */
        public void SearchingArrayValue()
        {
            /*
            [Date]:2010/09/09 
            [Author Name]:Monal Shah
            Description:Add try catch and finally Block in code
           */
            try
            {
                int[] intArrnum = { 4, 5, 8, 2, 10 }; //intArrnum is the variable name of the integer datatype size with 5.
                int intNum = System.Convert.ToInt32(Console.ReadLine()); //intNum is the variable name of the integer datatype.it is used for accepting input from the user from console.
                bool bolFlag = false;//bolFlag is the variable of boolean datatype.
                /*
                    Description:Modify the code search is done by the binarysearch menthod of array
                    [Date]:2010/09/09 
                    [Author Name]:Monal Shah
                    
                */
                Array.BinarySearch(intArrnum, intNum);//BinarySearchMethod is used for searching element from array
                for (int intI = 0; intI < intArrnum.Length; intI++)
                {
                    /* here in below code if the intNum is equal to the one of element of the array then bolFlag become true.*/
                    if (intNum.Equals(intArrnum[intI]))
                    {
                        bolFlag = true;//bolFlag become true.
                    }
                }
                /*if bolFlag is true then it displays the number is already in array 
                  else it is displays the entered number is not in array.*/
                if (bolFlag)
                {
                    Console.WriteLine("This number is already in array");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("This number is not in array");
                    Console.ReadLine();
                }
            }
            catch (Exception ExException)
            {
                Console.WriteLine("ERROR:" + ExException.Message);//exception
            }
        }
    }
}
