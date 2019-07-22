using System;

namespace Program
{
    /*--------------------------------------------------------------------------------------------------------------------
           Name:ReviseArray.cs
           Author:Monal Shah
           Description:"This program is used for describing the how many times number will be appeared into the array which is size of 30.
                        Accept a number from the user.
                        The code should print if the number exists and how many times it appears in the array."

           CreatedDate: 2010/09/06 by Monal Shah
   -------------------------------------------------------------------------------------------------------------------
   */
    class ReviseArray
    {
        /*---------------------------------------------------------------------------------------------------------------
          Name:ReviseArray 
          Paramametres:0
          Description:This method is revise the elements from the array.
                      and describing the number how many times display into the array and Print if the number is exixsts 
                      othervise Print it is not exists in the array.

          Author:Monal Shah
          CreatedDate: 2010/09/06 by Monal Shah
      ---------------------------------------------------------------------------------------------------------------
      */
        public void ReviseArrayValue()
        {
            /*
           [Date]:2010/09/09 
           [Author Name]:Monal Shah
           Description:Add try catch and finally Block in code
          */
            try
            {
                int intCount = 0;  //intCount is the variable of integer datatype.it is used for counting number how many times it is displayed in array.
                int[] intArrnum = { 1, 0, 3, 5, 8, 10, 2, 6, 7, 9, 1, 0, 3, 0,
                                    5, 8, 7, 8, 9, 10, 10, 6, 5, 0, 3, 2, 1, 8,
                                    9, 10 };//intArrnum is the variable of integer array with size of 30.
                int intNum = System.Convert.ToInt32(Console.ReadLine()); //intNum is varible of datatype integer and it is used for accepting the user value from the console.
                bool bolFlag = false;//bolFlag is the variable of boolean datatype.
                for (int intI = 0; intI < intArrnum.Length; intI++)
                {
                    /* here in below code if the intNum is equal to the one of element of the array then bolFlag become true and intCount is increased.*/
                    if (intNum == intArrnum[intI])
                    {
                        bolFlag = true;//bolFlag become true.
                        intCount++;//intCount is increased.
                    }
                }
                /*if bolFlag is true then it displays the number is already in array and number is revise for how many times
                  else it is displays the entered number is not in array.
                 */
                if (bolFlag)
                {
                    Console.WriteLine("This number is already in array revised "
                                        + intCount + " times");
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
