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
    /// Class Name:SearchArray
    /// Description://Create an array of integers Accept a number from the user, and print if this number exists in the array or not.
    /// Author:
    /// Created On:21/5/2015
    /// </summary>    
    class SearchArray
    {
        #region Search the elements from Array
        ConstantMessage objconst;//object creation        
        /// <summary>
        ///Method Name:SearchFunction
        /// Description://Searching operation from array
        /// Author:bhumi
        /// Created On:21/5/2015
        /// </summary>
        public void SearchFunction()
        {
            try
            {
                objconst = new ConstantMessage();
                int array_size,num;
                int flag = 0;// flag variable                
                int[] array1;
                // Array
                //Input from the user for array size
                Console.WriteLine(objconst.strarraysize);
                array_size = Convert.ToInt32(Console.ReadLine());
                array1 = new int[array_size];
                Console.WriteLine(objconst.strinput);
                for (int i = 0; i < array1.Length; i++)
                {
                    array1[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("==============================================");
                //Serching number from arra1 
                Console.WriteLine(objconst.strelement);
                num = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] == num)
                    {
                        flag = 1;//reset the flag
                    }
                }
                if (flag == 1)
                {
                    Console.WriteLine(num + objconst.strexist);
                }
                else
                {
                    Console.WriteLine(num + objconst.strnotexist);
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
