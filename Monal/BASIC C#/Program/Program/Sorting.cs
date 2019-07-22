using System;

namespace Program
{
    /*--------------------------------------------------------------------------------------------------------------------
         Name:Sorting.cs
         Author:Monal Shah
         Description:"The program will print the numbers sorted in ascending order.
                      Accept the number from the user."
            Example:Accept the number from user
                    10
                    15
                    2   
                    8
                    Then output will be
                    2
                    8
                    10
                    15

         CreatedDate: 2010/09/06 by Monal Shah
 -------------------------------------------------------------------------------------------------------------------
 */
    class Sorting
    {
        /*---------------------------------------------------------------------------------------------------------------
        Name:SortValue
        Paramametres:0
        Description:This method is sorting the number which is enterd by user.
                    first number will be accepted from user.
                    then the ascending number will be displayed.
                       

        Author:Monal Shah
        CreatedDate: 2010/09/06 by Monal Shah
    ---------------------------------------------------------------------------------------------------------------
    */
        public void SortValue()
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
                int[] intArrnum = new int[intNum]; //intArrnum is the variable name of the integer datatype size with intNum.
                for (int intI = 0; intI < intArrnum.Length; intI++)
                {
                    Console.WriteLine("Please Eneter Array Value " + intI);//here user enter the array value till the intArrnum length
                    intArrnum[intI] = System.Convert.ToInt32(Console.ReadLine());//accepting value from the console
                }
                /*
                    Description:Modify the code Removing Array.sort from the for loop 
                    [Date]:2010/09/09 
                    [Author Name]:Monal Shah
                 */
                Array.Sort(intArrnum);//here the intArrnum value sorted in ascending order throgh the sort method 
                for (int intJ = 0; intJ < intArrnum.Length; intJ++)
                {
                    Console.WriteLine(intArrnum[intJ]);//[intJ]);//Print the value in ascending order
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
