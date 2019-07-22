using System;

namespace Basic_C_Sharp
{
    #region
    //NAME          :- ReverseSort
    //AUTHOR        :- SHIKHA MALIK
    //DESCRIPTION   :- sort in assending order input array  
    //CREATED DATE  :- 16/07/2012
    class ReverseSort
    {
        //NAME          :- ReverseSort
        //AUTHOR        :- SHIKHA MALIK
        //DESCRIPTION   :-  sort in assending order input array  
        //CREATED DATE  :- 16/07/2012
        public void RevS()
        {
            int intN ,intI; int[] arrS;                                     // declare variable
            try
            {
                Console.WriteLine("Enter  number size");             // enter size of array        
                intN = int.Parse(Console.ReadLine());                   // Convert in integer

                 arrS = new int[intN];                        
                for (intI = 0; intI < intN; intI++)                          // for entering the number according size of array
                {
                    Console.WriteLine("Enter a number " + (intI + 1));   // Enter number one by one
                    arrS[intI] = int.Parse(Console.ReadLine());          
                }
                Console.WriteLine(" now array is: ");                     // display array
                for (intI = 0; intI < arrS.Length; intI++)
                {
                    Console.WriteLine(arrS[intI]);
                }
                Console.WriteLine();

                Array.Sort(arrS);                                         // use sort method of system array class for sorting array
                Console.WriteLine(" array after Sorting ");
                foreach (int a in arrS)
                    Console.WriteLine("" + a);
                Console.ReadLine();
            }
            catch (Exception ex)                                  // use for throw exception
            {
                System.Console.WriteLine(ex.Message);
            }
            finally
            {
                arrS = null;                                 // free memory
            }

        }
    }
    #endregion
}

                

         

               
