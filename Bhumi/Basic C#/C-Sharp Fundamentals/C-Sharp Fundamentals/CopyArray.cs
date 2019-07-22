using System;
/// <summary>
///NameSpace:CSharp
/// Description://Fundamental study programs of C#
/// Author:bhumi
/// Created On:21/5/2015
/// </summary>
/// 
namespace CSharp
{
    /// <summary>
    /// Class Name:CopyArray
    /// Description://copy the elements from the first array to the odd positions and 
                    ///from the second array into the even positions in the third array.
    /// Author:bhumi
    /// Created On:21/5/2015
    /// </summary>
    /// 
    class CopyArray
    {
        #region Create array Using Two Other Arrays
        ConstantMessage objconst;//object creation        
        ///<summary>
        ///Method Name:ThreeArray
        /// Description://create one array,input of this array will be from other two arrays.
        /// Author:bhumi
        /// Created On:21/5/2015
        /// </summary>        
        public void ThreeArray()
        {
            try
            {
                objconst = new ConstantMessage();                
                //Initialization
                int[] array1 = new int[5];
                int[] array2 = new int[5];
                double[] array3 = new double[10];
                //First Array
                Console.WriteLine(objconst.strinput);
                for (int i = 0; i < array1.Length; i++)
                {
                    array1[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("==============================================");
                //Second Array
                Console.WriteLine(objconst.strinput);
                for (int i = 0; i < array1.Length; i++)
                {
                    array2[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("==============================================");
                //Third Array
                Console.WriteLine(objconst.strcombine);
                int i1 = 0;
                for (int j = 0; j < 10; j++)
                {
                    if (j % 2 == 0)
                    {
                        //Second array at even position of third array
                        array3[j] = array2[i1];
                        i1 = i1 + 1;
                    }
                    else
                    {
                    }
                }
                int i2 = 0;
                for (int j = 0; j < 10; j++)
                {
                    if (j % 2 == 0)
                    {
                    }
                    else
                    {
                        //First array at odd position of third array
                        array3[j] = array1[i2];
                        i2 = i2 + 1;
                    }
                }
                //output of third array
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine(array3[i]);
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
