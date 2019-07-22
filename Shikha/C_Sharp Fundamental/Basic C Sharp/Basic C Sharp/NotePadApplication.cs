using System.Diagnostics;
using System;

namespace Basic_C_Sharp
{
    #region
    //NAME          :- NotePadApplication
    //AUTHOR        :- SHIKHA MALIK
    //DESCRIPTION   :- OPEN NOTEPAD APPLICATION  
    //CREATED DATE  :- 13/07/2012
    class NotePadApplication
    {
        //NAME          :- Notepad
        //AUTHOR        :- SHIKHA MALIK
        //DESCRIPTION   :- OPEN NOTEPAD APPLICATION  
        //CREATED DATE  :- 13/07/2012
        public void Notepad()
        {
            Process objNotepd = new Process();                                    //Create object of Process class
            try
            {
                  objNotepd.StartInfo.FileName = "objNotepd.exe";          //get or set the properties and application to start
                  objNotepd.StartInfo.Arguments = "ProcessStart.cs";      //get or set the Commandline argument to use when application to start
                  objNotepd.Start();                                     //Start the process resources that is specified by the System.Diagnostics
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);    // throw exception
            }
            finally
            {
                objNotepd = null;
            }
        
        }
    }
    #endregion
}
