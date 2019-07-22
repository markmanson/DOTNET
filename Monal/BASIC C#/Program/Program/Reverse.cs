using System;

namespace Program
{
    /*--------------------------------------------------------------------------------------------------------------------
          Name:Reverse.cs
          Author:Monal Shah
          Description:"this program Accept an array of numbers from the user and print it in reverse 
                       (note:class is used for accepting an array as input and returns an array as output)."
            Example:Accept the number from user
                    10
                    15
                    2   
                    8
                    Then output will be
                    "Reversed value"
                    8
                    2
                    15
                    10
          CreatedDate: 2010/09/06 by Monal Shah
  -------------------------------------------------------------------------------------------------------------------
  */
    class Reverse
    {
        /*---------------------------------------------------------------------------------------------------------------
         Name:ReverseNumber 
         Paramametres:0
         Description:This method accepts the number from the user 
                     and then it is displayed in reversed Order.
                     

         Author:Monal Shah
         CreatedDate: 2010/09/06 by Monal Shah
     ---------------------------------------------------------------------------------------------------------------
     */
        public void ReverseNumber()
        {
            /*
           [Date]:2010/09/09 
           [Author Name]:Monal Shah
           Description:Add try catch and finally Block in code
          */
            try
            {
                Console.WriteLine("Please Enter Total number value you want:");
                int intNum = System.Convert.ToInt32(Console.ReadLine()); //intNum is the variable name of the integer datatype.it is used for accepting input from the user from console.
                int[] intArrnum = new int[intNum];//intArrnum is the variable name of the integer datatype size with intNum.
                for (int intI = 0; intI < intArrnum.Length; intI++)
                {
                    Console.WriteLine("Please Eneter Array Value " + intI);//here user enter the array value till the intArrnum length
                    intArrnum[intI] = System.Convert.ToInt32(Console.ReadLine());//accepting value from the console
                }
                Console.WriteLine("Reveresed value");
                /*
                    [Date]:2010/09/09 
                    [Author Name]:Monal Shah
                    Description:Modify the code user reverse method for reversing array value.
                */
                Array.Reverse(intArrnum);//Reverse method is used for reversing the array value
                for (int intJ = 0; intJ < intArrnum.Length; intJ++)
                {
                    Console.WriteLine(intArrnum[intJ]);//Print the value in Reversed order
                }
                Console.ReadLine();
            }
            catch (Exception ExException)
            {
                Console.WriteLine("ERROR:" + ExException.Message);//exception
            }
        }
    }
}
