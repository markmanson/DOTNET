using System;
using System.IO;

namespace Program
{
    /*-------------------------------------------------------------------------------------------------------------------
   Name:TextFile.cs
   Author:Monal Shah
   Description:Create a text file and write 5 lines to it.
   CreatedDate: 2010/09/06 by Monal Shah
   -------------------------------------------------------------------------------------------------------------------
   */
    class TextFile
    {
        #region TxtFile
        /// <summary>
        /// Name:Txtfile
        /// Author:Monal shah
        ///Description:Write 5 lines into file
        /// CreatedDate:2010/09/10
        /// </summary>
        public void TxtFile()
        {
            FileStream FsRead;
            StreamWriter streamWriter;
            string strValue;
            const int intNum=5;
            const string strPath = "D:\\Monal\\FileWrite.txt";
            try
            {
                Console.WriteLine("Please Enter 5 value");
               
                    FsRead = File.Create(strPath);
                    FsRead.Close();
                    if (File.Exists(strPath))
                    {
                        Console.WriteLine("File is created successfully");
                    }

                        streamWriter = new StreamWriter(strPath);
                        for (int intI = 0; intI < intNum; intI++)
                        {
                            strValue = Console.ReadLine();
                            streamWriter.WriteLine(strValue);
                        }
                        streamWriter.Close();
                    
            }
            catch (FileNotFoundException exFileNotFound)
            {
                Console.WriteLine("File Not found"+exFileNotFound.Message);
                Console.ReadLine();
              
            }
            catch (IOException exIO)
            {
                Console.WriteLine("Input Output Exception"+exIO.Message);
                Console.ReadLine();
             

            }
            catch (UnauthorizedAccessException exUnAuthorizedException)
            {
                Console.WriteLine("Input Output Exception"+exUnAuthorizedException.Message);
                Console.ReadLine();
               
            }
            finally
            {
                FsRead = null;
                streamWriter = null;
                strValue = null;
            }
        }
        #endregion
    }
}
