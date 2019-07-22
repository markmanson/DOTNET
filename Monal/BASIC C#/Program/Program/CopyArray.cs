using System;

namespace Program
{
    /*-------------------------------------------------------------------------------------------------------------------
 Name:CopyArray.cs
 Author:Monal Shah
 Description:"Create an array of 5 integers and add five integer numbers to it.
              Create another array of 5 single values and add five single numbers to it.
              Create a third array of double values which can take 10 elements.
              code to copy the elements from the first array to the odd positions in the third array.
              code to copy the elements from the second array into the even positions in the third array."

 CreatedDate: 2010/09/06 by Monal Shah
 -------------------------------------------------------------------------------------------------------------------
 */
    class CopyArray
    {

        /*---------------------------------------------------------------------------------------------------------------
          Name:CopyAryElement 
          Paramametres:0
          Description:This method is copy the elements from the first array to the odd positions in the third array.
                      and copy the elements from the second array into the even positions in the third array.

          Author:Monal Shah
          CreatedDate: 2010/09/06 by Monal Shah
      ---------------------------------------------------------------------------------------------------------------
      */
        public void CopyAryElement()
        {
            /*
             [Date]:2010/09/09 
             [Author Name]:Monal Shah
             Description:Add try catch and finally Block in code
            */
            try
            {
                int[] intArrnum = new int[5]; //intArrnum is the variable for integer Array size of 5.
                for (int intI = 0; intI < intArrnum.Length; intI++)
                {
                    Console.WriteLine("Please Eneter Array Value " + intI);
                    intArrnum[intI] = Convert.ToInt32(Console.ReadLine()); //here value is converted into integer
                }
                float[] fltArrnum2 = new float[5];//fltArrnum2 is the variable for integer Array size of 5.
                for (int intI = 0; intI < fltArrnum2.Length; intI++)
                {
                    Console.WriteLine("Please Eneter Array Value " + intI);
                    fltArrnum2[intI] = Convert.ToSingle(Console.ReadLine());//here value is converted into single
                }
                double[] dblNum3 = new double[10];//dblNum3 is the variable for double Array size of 10.
                int intCount = 2;
                for (int intI = 0; intI < intArrnum.Length; intI++)
                {
                    dblNum3[intCount * intI] = intArrnum[intI]; //copy the elements from the first array to the odd positions in the third array
                    dblNum3[(intCount * intI) + 1] = fltArrnum2[intI];//copy the elements from the second array into the even positions in the third array.
                }
                Console.WriteLine("\nDouble element array\n");
                foreach (double dblD in dblNum3)
                {
                    Console.WriteLine(dblD); //here the value of copied array will be displayed
                }
                Console.ReadLine();
            }
            catch (Exception ExException)
            {
                Console.WriteLine("ERROR:"+ExException.Message);//throw exception
            }
        }
    }
}
