using System;
using System.IO;
namespace ConsoleApplication3
{
    #region Showfile
    //Name                      : Showfile
    //Auther                    : Ankit Sharma
    //Created Date              : 04/07/2012
    //Description               : To show the contents of file 
    class Showfile
    {
        #region show
        //Function to show the contents of file***************************************************
        public void show()
        {
            try
            {
                using (StreamReader sr = File.OpenText(@"D:\DotNetSkillup\Source Code\Ankit\C_Sharp Fundamentals\ConsoleApplication3\Ankit.txt"))      //To create a file named MyTest.txt
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)                     //To display all lines
                    {
                        Console.WriteLine(s);                               //Show the contents on console line by line
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);                               //Display error messege if any exception is occured
            }
        }
        #endregion show
    }
    #endregion Showfile
}
