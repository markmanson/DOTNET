using System;

namespace Program
{
    /*-------------------------------------------------------------------------------------------------------------------
   Name:WindowsUser.cs
   Author:Monal Shah
   Description:This Program is Display the currently Logged in user,Hme directory and OS version.
   CreatedDate: 2010/09/06 by Monal Shah
   -------------------------------------------------------------------------------------------------------------------
   */
    class WindowsUser
    {
        /*---------------------------------------------------------------------------------------------------------------
          Name:WinUser 
          Paramametres:0
          Description:This method is used Displaying the currently Logged in user,Hme directory and OS version.
          Author:Monal Shah
          CreatedDate: 2010/09/06 by Monal Shah
      ---------------------------------------------------------------------------------------------------------------
      */
        public void WinUser()
        {
            /*
            [Date]:2010/09/09 
            [Author Name]:Monal Shah
            Description:Add try catch and finally Block in code
           */
                Console.WriteLine("Logged In User:");
                Console.WriteLine(System.Environment.UserName); //the currently Logged in username will be displayed.
                Console.WriteLine("Home Directory:");
                Console.WriteLine(System.Environment.CurrentDirectory); //the currently working Home Directory will be displayed.
                Console.WriteLine("OS name:");
                Console.WriteLine(System.Environment.OSVersion);//the OS Version will be displayed.
                Console.ReadLine();
         }
    }
}
