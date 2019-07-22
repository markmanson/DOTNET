using System;
using System.Diagnostics;
namespace ConsoleApplication3
{
    #region OpenNotepad
    //Name                      : OpenNotepad
    //Auther                    : Ankit Sharma
    //Created Date              : 28/06/2012
    //Description               : To open Notepad using c# console application
    class OpenNotepad
    {
        #region open
        //**********************************************   FUNCTION TO OPEN NOTEPAD BY USING C SHARP    *****************************************
        public void open()
        {
            ProcessStartInfo startInfo;                                                 //Declaring the object for ProcessStartInfo
            try
            {
                startInfo = new ProcessStartInfo("Notepad.exe");                        //Open Notepad
                // Process.Start(startInfo);
                startInfo.Arguments = "Ankit.txt";                                       //Open file named Text.txt
                Process.Start(startInfo);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);                                             //Display messege if any error occured                             
            }
            finally
            {
                startInfo = null;                                                        //Destroying the object of ProcessStartInfo
            }
        }
        #endregion open
    }
    #endregion OpenNotepad
}
