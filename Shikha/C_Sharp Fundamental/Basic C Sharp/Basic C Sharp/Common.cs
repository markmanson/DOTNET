using System;

namespace Basic_C_Sharp
{
    #region
    // NAME              :-  Common
    // AUTHOR NAME       :-  SHIKHA MALIK
    // DECRIPTION        :-  Common class whic contain common declaration of array. 
    // CREATED DATE      :-  12/07/2012
 public class Common
    {
       public int[] GetArray(int intN)
        {
            int intI; int[] arrA;
            //Console.WriteLine("Enter Size of array");                    // Display message    
            //intN = int.Parse(Console.ReadLine());                        // read value of intN
            arrA = new int[intN];
            for (intI = 0; intI < intN; intI++)                                   // for enter the number in array upto size for initialize
            {
                Console.WriteLine("Enter a number");                    // dintIsplay message
                arrA[intI] = int.Parse(Console.ReadLine());                    // store the enter number in each iteration
            }
            return arrA;
        }
    public void  ShowArray(int [] arrA)
     {
            Console.WriteLine(" now array is: ");                       //Display message
            foreach (int Ele in arrA)                          //  array upto length  
            {
                Console.WriteLine(Ele);                               // show array 
            }

        }

    }
    #endregion
}
