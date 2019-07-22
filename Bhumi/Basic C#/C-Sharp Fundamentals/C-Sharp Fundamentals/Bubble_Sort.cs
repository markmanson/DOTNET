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
    /// Class Name:Bubble_Sort
    /// Description://write code to bubble-sort the array.
    /// Author:bhumi
    /// Created On:20/5/2015
    /// </summary>
    /// 
    class Bubble_Sort
    {
        #region BubbleSort
        ConstantMessage objconst;//object creation                                        
        ///<summary>
        ///Method Name:BubbleSort
        /// Description:Sorting array using bubblesort
        /// Author:bhumi
        /// Created On:21/5/2015
        /// </summary>                                
        public void BubbleSort()
        {
            objconst = new ConstantMessage();
            try
            {
                int Arry_Size, temp;
                int[] array;
                //Input from the user
                Console.WriteLine(objconst.strarraysize);
                Arry_Size = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(objconst.strinput);
                array = new int[Arry_Size];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("==============================================");
                //Display the Array
                Console.WriteLine(objconst.strarrayelement);
                for (int i = 0; i < array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
                Console.WriteLine("==============================================");
                //Bubble Sort                
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - 1; j++)
                    {
                        if (array[j] > array[j + 1])
                        {
                            temp = array[j + 1];
                            array[j + 1] = array[j];
                            array[j] = temp;
                        }
                    }
                }
                //print the sorted array
                Console.WriteLine(objconst.strsort);
                foreach (int a in array)
                    Console.Write(a + " ");
                Console.WriteLine();
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
