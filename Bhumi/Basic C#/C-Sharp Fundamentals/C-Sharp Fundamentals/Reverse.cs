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
    /// Class Name:ArrayReverse
    /// Description://Accept an array of numbers from the user and print it in reverse                  
    /// Author:
    /// Created On:19/5/2015
    /// </summary>    
    class Reverse
    {
        #region Reverse Array
        ConstantMessage objconst;//object creation        
        /// <summary>
        ///MethodName:ArrayReverse
        /// Description://Find the reverse form of entered Array
        /// Author:bhumi
        /// Created On:21/5/2015
        /// </summary>        
        public void ArrayReverse()
        {
            try
            {
                int Array_Size;
                string[] array1;
                objconst = new ConstantMessage();
                Console.WriteLine(objconst.strarraysize);
                Array_Size=Convert.ToInt32(Console.ReadLine());
                //Input from the user
                Console.WriteLine(objconst.strarray);
                array1 = new string[Array_Size];
                for (int i = 0; i < array1.Length; i++)
                {
                    array1[i] = Console.ReadLine();
                }
                Console.WriteLine("==============================================");
                //Display the Array
                Console.WriteLine(objconst.strarrayelement);
                for (int i = 0; i < array1.Length; i++)
                {
                    Console.WriteLine(array1[i]);
                }
                Console.WriteLine("==============================================");
                //Array in Reverse form
                Console.WriteLine(objconst.strrev);
                for (int i = array1.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(array1[i]);
                }
                Console.ReadKey();
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
