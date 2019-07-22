using System;

namespace Program
{
    /*--------------------------------------------------------------------------------------------------------------------
         Name:TransformMatrix.cs
         Author:Monal Shah
         Description:"Create a 2-D array with 4 rows and 7 columns.  
                       Write code to transform this array (i.e. to convert rows into columns and columns into rows).
                       Print the original array and the transformed array."
        
         CreatedDate: 2010/09/06 by Monal Shah
 -------------------------------------------------------------------------------------------------------------------
 */
    class TransformMatrix
    {
        #region TransformRowToColumn
        /// <summary>
        /// Name:TransformRowToColumn
        /// parametres:0
        /// Description:Create the Matrix and transform the original matrix by row to column and column to row
        /// Author:Monal shah
        /// CreatedDate:2010/09/09
        /// </summary>
        public void TransformRowToColumn()
        {
            try
            {
                Console.WriteLine("Matrix");
                Console.WriteLine("Please enter the number of rows:");
                int intNumRow = System.Convert.ToInt32(Console.ReadLine());//Read the total number of row from the console which is enterd by the user
                Console.WriteLine("Please enter the number of rows:");
                int intNumCol = System.Convert.ToInt32(Console.ReadLine());//Read the total number of column from the console which is enterd by the user
                int[,] intMatrix1 = new int[intNumRow, intNumCol];//intMatrix1 is declared with  intNumRow,intNumCol
                int[,] intTransform = new int[intNumRow, intNumCol];//intTransform is declared with  intNumRow,intNumCol
                for (int intI = 0; intI < intNumRow; intI++)
                {
                    for (int intJ = 0; intJ < intNumCol; intJ++)
                    {
                        Console.WriteLine("Please Enter Array Value of row "
                                            + intI + "and column " + intJ);//here user enter the array value till the intNumRow and intNumcol length
                        intMatrix1[intI, intJ] =Convert.ToInt32(Console.ReadLine());//accepting value from the console
                    }
                }
                Console.WriteLine("Original Matrix");
                for (int intI = 0; intI < intNumRow; intI++)
                {
                    for (int intJ = 0; intJ < intNumCol; intJ++)
                    {
                        Console.Write("\t" + intMatrix1[intI, intJ] + "\t");//here user enter the array value till the intNumRow and intNumcol length
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("Transform Matrix");

                for (int intI = 0; intI < intNumRow; intI++)
                {
                    for (int intJ = 0; intJ < intNumCol; intJ++)
                    {
                        intTransform[intJ, intI] = intMatrix1[intI, intJ];//transform matrix
                    }
                }
                for (int intI = 0; intI < intNumRow; intI++)
                {
                    for (int intJ = 0; intJ < intNumCol; intJ++)
                    {
                        Console.Write("\t" + intTransform[intI, intJ] + "\t");//print transformed matrix
                    }
                    Console.WriteLine();
                }
            }
            catch (Exception ExException)
            {
                Console.WriteLine("ERROR:" + ExException.Message);//exception
            }
        #endregion
        }
    }
}
