using System;

namespace Basic_C_Sharp
{
    #region
    //NAME          :- ReviseArray
    //AUTHOR        :- SHIKHA MALIK
    //DESCRIPTION   :- ENTER ELEMENT EXIST AND PRINT PRINT HOW MANY TIMES
    //CREATED DATE  :- 12/07/2012
    class ReviseArray
    {    //NAME          :- ReviseArray
        //AUTHOR        :- SHIKHA MALIK
        //DESCRIPTION   :- ENTER ELEMENT EXIST AND PRINT PRINT HOW MANY TIMES
        //CREATED DATE  :- 12/07/2012
    
        public void Rarray()
        {
            int intI, intX, intCount = 0,  intN; // declaration of  variable
            string strR="";
            int[] arrA; Common objCommon;                                    // declaration of array

            try
            {
                objCommon = new Common();
                Console.WriteLine(Constant.strArrSz);          // display message     
                intN = int.Parse(Console.ReadLine());             // convert into integer
                arrA = new int[intN];
                arrA = objCommon.GetArray(intN);
                Console.WriteLine(Constant.strEleSrch);       // enter element which is cheah is exist or not  
                intX = int.Parse(Console.ReadLine());              // read value of element  
                for (intI = 0; intI < intN; intI++)                         // use for loop up to size of array
                {
                    if (arrA[intI] == intX)                            // cheak with each index value of array
                    {
                        strR = "intX";                              // element exist in array
                        intCount++;                                // intCount exist element
                    }
                   else
                    {
                        strR =Constant.strSrchNt;           // Element not found        
                    }
                }
                Console.WriteLine(Constant.strSrchExst + "  " + intCount);     // display the value of exist element and number of times
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);                 // throw exception
            }
            finally
            {
                strR = null;
                arrA = null;
                objCommon = null;                 // reallocate the memory
            }
        }
    }
    #endregion
}

          

