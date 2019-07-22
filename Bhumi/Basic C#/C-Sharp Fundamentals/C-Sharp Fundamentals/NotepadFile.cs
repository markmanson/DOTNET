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
    /// Description://Write code to open the Notepad application in Windows
    /// Author:
    /// Created On:19/5/2015
    /// </summary>
    /// 
    class NotepadFile
    {
        #region Open Notepad file
        ConstantMessage objconst;//object creation                        
        //Write code to open the Notepad application in Windows
        ///<summary>
        ///Method Name:OpenFile
        /// Description://open notepade file using console application
        /// Author:bhumi
        /// Created On:21/5/2015
        /// </summary>                        
        public void OpenFile()
        {
            try
            {
                string filenm;
                objconst = new ConstantMessage();                
                //Get the file name from use
                Console.WriteLine(objconst.strfilename);
                filenm = Console.ReadLine();
                System.Diagnostics.Process.Start("notepad.exe", "D://" + filenm + ".txt");
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
