using System;
namespace ConsoleApplication3
{
    //Name                      : Systemdetails
    //Auther                    : Ankit Sharma
    //Created Date              : 28/06/2012
    //Description               : To display currently logged in Windows username, home directory and the OS name
    class Systemdetail
    {
       public void getdetails()
        {
         string sData=string.Empty;
        //Get Current User Name of Windows Operating System
         sData=Environment.UserName;
         Console.WriteLine("User name is :-"+sData);        
        //Get Version of Windows Operating System
         sData=Environment.OSVersion.VersionString;
         Console.WriteLine("User Operating System is :-" + sData);
        //Get Current Working Directory(Folder)
         sData=Environment.CurrentDirectory;
         Console.WriteLine("User CurrentDirectory is :-" + sData);
        }
    }
}
