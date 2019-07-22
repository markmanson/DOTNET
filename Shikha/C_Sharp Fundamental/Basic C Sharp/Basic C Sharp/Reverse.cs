using System;

namespace Basic_C_Sharp
{
    #region
    //NAME          :- Reverse
    //AUTHOR        :- SHIKHA MALIK
    //DESCRIPTION   :-  REVERSE ARRAY
    //CREATED DATE  :- 12/07/2012
    class Reverse
    {
        //NAME          :-  Rev
        //AUTHOR        :- SHIKHA MALIK
        //DESCRIPTION   :- REVERSE ARRAY  
        //CREATED DATE  :- 12/07/2012
        public void Rev()
        {
            int intN; int[] arrA; Common objCommon;
            //declaration of variable
            try
            {
                objCommon = new Common();
                Console.WriteLine(Constant.strArrSz);      //display message
                intN = int.Parse(Console.ReadLine());             //read value
                arrA = new int[intN];
                arrA = objCommon.GetArray(intN);
                objCommon.ShowArray(arrA);   
               
                //for (intI = 0; intI < intN; intI++)                         //initialize array
                //{
                //    Console.WriteLine("Enter a number");
                //    arrA[intI] =int.Parse(Console.ReadLine());
                //}
                //Console.WriteLine(" now array is: "); // display array
                //for (intI = 0; intI < arrA.Length; intI++)
                //{
                //    Console.WriteLine(arrA[intI]);
                //}
                Console.WriteLine();
               
                Array.Reverse(arrA);                             // use Reverse method for reverse array
                Console.WriteLine(Constant.strArrRev);     // display message
                foreach(int a in arrA)
                    Console.WriteLine(""+a);

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);         // throw exception
            }
            finally
            {
                arrA = null;                                     // reallocate the memory

            }

        }
    }
    #endregion
}
