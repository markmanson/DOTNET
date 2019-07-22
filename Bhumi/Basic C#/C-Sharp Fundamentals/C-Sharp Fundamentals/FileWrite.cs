using System;
using System.IO;
/// <summary>
///NameSpace:CSharp
/// Description://Fundamental study programs of C#
/// Author:bhumi
/// Created On:21/5/2015
/// </summary>
namespace CSharp
{
    /// <summary>
    /// Class Name:FileWrite
    /// Description:Create a text file and write 5 lines to it.
    /// Author:Bhumi
    /// Created On:21/5/2015
    /// </summary>
    ///    
    class FileWrite
    {
        ///<summary>
        ///Method Name:WriteToFile       
        /// </summary>  
        /// 
        #region file writing
        ConstantMessage objconst;//object creation
        public void WriteToFile()
        {
            try
            {

                objconst = new ConstantMessage();
                int counter = 0;
                //Create the file
                string path = @"D:\MyFile.txt", line;//Specific Path
                TextWriter tw = new StreamWriter(path);
                //5 lines will be written in file
                while (counter < 5)
                {
                    Console.WriteLine(objconst.strfilewrite);
                    line = Console.ReadLine();
                    tw.WriteLine(line);
                    counter++;
                }
                tw.Close();
                System.Console.WriteLine("There were {0} lines.", counter);
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
    }
    #endregion
}
