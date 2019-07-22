using System;
/// <summary>
///NameSpace:CSharp
/// Description://Fundamental study programs of C#
/// Author:bhumi
/// Created On:21/5/2015
/// </summary>
namespace CSharp
{
    /// <summary>
    /// Class Name:Array_Transformation
    /// Description://Create a 2-D array with 4 rows and 7 columns.  Write code to transform this array 
    /// Author:
    /// Created On:20/5/2015
    /// </summary>
    ///     
    class Array_Transformation
    {
        #region Transformation of Array
        ConstantMessage objconst;//object creation                                
        ///<summary>
        ///Method Name:Trasform
        /// Description://Transformation operation on array
        /// </summary>                                
        public void Trasform()
        {
            objconst = new ConstantMessage();            
            try
            {
                //Defining Array
                int[,] twoD_array = new int[4, 7];                                
                int row_size, colm_size;
                Console.WriteLine(objconst.strarraytransform);
                //user defined rows
                Console.WriteLine(objconst.strrow);
                row_size = Convert.ToInt32(Console.ReadLine());
                //user defined columns
                Console.WriteLine(objconst.strcolumn);
                colm_size = Convert.ToInt32(Console.ReadLine());
                //Insert the elements in array
                Console.WriteLine(objconst.strdatainsert);
                for (int i = 0; i < row_size; i++)
                {
                    for (int j = 0; j < colm_size; j++)
                    {
                        twoD_array[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine("==============================================");
                }
                Console.WriteLine(objconst.strmainarray);
                //print the original Array  
                for (int i = 0; i < row_size; i++)
                {
                    for (int j = 0; j < colm_size; j++)
                    {
                        Console.Write(twoD_array[i, j] + "\t");
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine("==============================================");
                Console.WriteLine(objconst.strtransform_array);
                //print the Transformed Array  
                for (int i = 0; i < colm_size; i++)
                {
                    for (int j = 0; j < row_size; j++)
                    {
                        Console.Write(twoD_array[j, i] + "\t");
                    }
                    Console.WriteLine("\n");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                objconst = null;
            }
        }
        #endregion
    }
}
