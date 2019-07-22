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
    /// Class Name:Sort
    /// Description://Modify the Reverse code so the program will print the numbers sorted in ascending order.
    /// Author:
    /// Created On:19/5/2015
    /// </summary>
    /// 
    class Sort
    {
        #region Sorting of Array
        ConstantMessage objconst;//object creation
        //Modify the Reverse code so the program will print the numbers sorted in ascending order.
        /// <summary>
        ///Method Name:ArraySort
        /// Description://Array reverse & sort Operation
        /// Author:bhumi
        /// Created On:21/5/2015
        /// </summary>
        public void ArraySort()
        {
            try
            {
                int Array_Size;
                int[] array1;
                objconst = new ConstantMessage();                
                //Input from the user
                Console.WriteLine(objconst.strarraysize);
                Array_Size = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(objconst.strinput);
                array1 = new int[Array_Size];
                for (int i = 0; i < array1.Length; i++)
                {
                    array1[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("==============================================");
                //Display the Array
                Console.WriteLine(objconst.strarrayelement);
                for (int i = 0; i < array1.Length; i++)
                {
                    Console.WriteLine(array1[i]);
                }
                Console.WriteLine("==============================================");
                //Array sorted in ascending order
                Console.WriteLine(objconst.strascend);
                Array.Sort(array1);
                for (int i = 0; i < array1.Length; i++)
                {
                    Console.WriteLine(array1[i]);
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
