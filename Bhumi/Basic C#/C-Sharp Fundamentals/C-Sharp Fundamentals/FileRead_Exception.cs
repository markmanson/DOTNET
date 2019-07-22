using System;
using System.IO;
/// <summary>
///NameSpace:CSharp
/// Description://Fundamental study programs of C#
/// Author:bhumi
/// Created On:22/5/2015
/// </summary>
/// 
namespace CSharp
{
    /// <summary>
    /// Class Name:FileRead_Exception
    /// Description://File Reading and Exception Handling
    /// Author:Bhumi
    /// Created On:22/5/2015
    /// </summary>
    /// 
    class FileRead_Exception
    {
        #region Read File and handling Exception
        ConstantMessage objconst;//object creation                                
        /// <summary>
        ///Method Name:FileReadException
        /// Description://Reading the text from file and Handle Exception while generate 
        /// Author:bhumi
        /// Created On:22/5/2015
        /// </summary>
        public void FileReadException()
        {
            try
            {
                string filename;
                string[] lines;
                objconst = new ConstantMessage();
                // Read each line of the file into a string array. Each element 
                // of the array is one line of the file.
                Console.WriteLine(objconst.strfilename);
                filename = Console.ReadLine();
                lines = System.IO.File.ReadAllLines(@"D:\" + filename + ".txt");
                //check file Existance
                Console.WriteLine(File.Exists(@"D:\" + filename + ".txt") ? objconst.strfileexist : objconst.strfilenotexist);
                //Check file text is null or not
                if (new FileInfo(@"D:\" + filename + ".txt").Length == 0)
                {
                    Console.WriteLine(objconst.strfilenull);
                }
                else
                {
                    // Display the file contents by using a foreach loop.
                    System.Console.WriteLine(objconst.strfilecontent);
                    foreach (string line in lines)
                    {
                        // Use a tab to indent each line of the file.
                        Console.WriteLine("\t" + line);
                    }
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
