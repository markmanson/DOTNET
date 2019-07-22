using System;

namespace Basic_C_Sharp
{
    #region
    //NAME          :- WindowName
    //AUTHOR        :- SHIKHA MALIK
    //DESCRIPTION   :- CURRENTLY LOGGED IN WINDOW USERNAME ,HOME DIRECTORY, OS NAME
    //CREATED DATE  :- 13/07/2012
    class WindowName
    {
        //NAME          :- WinName
        //AUTHOR        :- SHIKHA MALIK
        //DESCRIPTION   :- CURRENTLY LOGGED IN WINDOW USERNAME ,HOME DIRECTORY, OS NAME
        //CREATED DATE  :- 13/07/2012
        public void WinName()
        {
                string strData = string.Empty;
            try
            {
                strData = Environment.UserName;             //Get Current User Name of Windows Operating System
                Console.WriteLine("user name" + strData);
                strData = Environment.UserDomainName;
                Console.WriteLine("Domain  name" + strData);       //Get Domain Name of the System
                strData = Environment.SystemDirectory;
                Console.WriteLine("Directory name" + strData);     //Get System Directory
                strData = Environment.OSVersion.VersionString;         //Get Version of Windows Operating System
                Console.WriteLine("Osversion name" + strData);
            }
            catch (Exception ex)
            {
                System.Console.WriteLine(ex.Message);    // throw exception
            }
        
        }
    }
    #endregion
}
