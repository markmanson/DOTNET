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
    /// Class Name:ReviseArray
    /// Description:// Add various numbers from 1 to 10 to the array.  
                    ///Accept a number,print if the number exists and how many times it appears in the array.
    /// Author:bhumi
    /// Created On:19/5/2015
    /// </summary>   
    class ReviseArray
    {
        #region Existance checking and counting of elements
        ConstantMessage objconst;//object creation        
        ///Method Name:CountFunction
        /// Description://Searching operation from array
        /// Author:bhumi
        /// Created On:21/5/2015
        /// </summary>        
        public void CountFunction()
        {
            try
            {
                int array_size,flag = 0;// flag variable
                int count = 0;//count variable;
                int[] array1;
                objconst = new ConstantMessage();
                Console.WriteLine(objconst.strarraysize);
                array_size = Convert.ToInt32(Console.ReadLine());
                array1 = new int[array_size];
                Console.WriteLine(objconst.strinputbetween);
                for (int i = 0; i < array1.Length; i++)
                {
                    array1[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("==============================================");
                //Serching number from arra1 
                Console.WriteLine(objconst.strelement);
                int num = Convert.ToInt32(Console.ReadLine());                
                for (int i = 0; i < array1.Length; i++)
                {
                    if (array1[i] == num)
                    {
                        flag = 1;//reset the flag
                        count++;
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
                Console.WriteLine("==============================================");
                //check the occurrence of number in array
                if (count > 0)
                {
                    Console.WriteLine(num + "\tappear\t" + count + "\tTimes in Array");
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
