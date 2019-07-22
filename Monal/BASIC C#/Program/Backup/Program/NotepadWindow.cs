using System;
using System.Diagnostics;

namespace Program
{
    /*-------------------------------------------------------------------------------------------------------------------
  Name:NotepadWindow.cs
  Author:Monal Shah
  Description:This Program Open the Notepad application in windows.
  CreatedDate: 2010/09/06 by Monal Shah
  -------------------------------------------------------------------------------------------------------------------
  */
    class NotepadWindow
    {
        /*---------------------------------------------------------------------------------------------------------------
          Name:NpWindow 
          Paramametres:0
          Description:This method is open the notepad application.
          Author:Monal Shah
          CreatedDate: 2010/09/06 by Monal Shah
      ---------------------------------------------------------------------------------------------------------------
      */
        public void NpWindow()
        {
            /*
            [Date]:2010/09/09 
            [Author Name]:Monal Shah
            Description:Add try catch and finally Block in code
                        And add const string variable
           */
            const string strValueNp = "Notepad.exe";//here constant string datatype is used
            Process objP = null;
            try
            {
                objP = new Process(); //memory allocation of p object of Process Method
                objP.StartInfo.FileName = strValueNp; //getting filename Notepade.exe 
                objP.Start(); //here the process will be start
                objP.WaitForExit(); //here waiting for exit for application
            }
            catch (Exception ExException)
            {
                Console.WriteLine("ERROR:"+ExException.Message);//throw exception
            }
            finally
            {
                objP = null;
            }
         }
    }
}
