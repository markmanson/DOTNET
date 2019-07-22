using System;
using System.IO;

namespace Program
{
    /*-------------------------------------------------------------------------------------------------------------------
         Name:ReadTextFile.cs
        Author:Monal Shah
        Description:This Program is Read the contents from the file 
        CreatedDate: 2010/09/10 by Monal Shah
 -------------------------------------------------------------------------------------------------------------------
 */
    class ReadTextfile
    {
        #region ReadFile
        /// <summary>
        /// Name:ReadFile
        /// Author:Monal shah
        /// Description:Read the contents from the file 
        /// CreatedDate:2010/09/10
        /// </summary>
        public void ReadFile()
        {
            string strPath = "";
            StreamReader strRead;
            string strText;
            try
            {
                strPath = "D:\\Monal\\FileWrite.txt";
                using (strRead = new StreamReader(strPath))
                {
                    /*Read the contents till the writable data*/
                    while ((strText = strRead.ReadLine()) != null)
                    {
                        Console.WriteLine(strText);
                    }
                }
            }
            catch (FileNotFoundException exFileNotFound)
            {
                Console.WriteLine("File Not found" + exFileNotFound.Message);
                Console.ReadLine();

            }
            catch (IOException exIO)
            {
                Console.WriteLine("Input Output Exception" + exIO.Message);
                Console.ReadLine();


            }
            catch (UnauthorizedAccessException exUnAuthorizedException)
            {
                Console.WriteLine("Input Output Exception" + exUnAuthorizedException.Message);
                Console.ReadLine();

            }
            finally
            {
                strText = null;
                strRead = null;
                strPath = null;
            }
        }
        #endregion
    }
}
