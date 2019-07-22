using System;
using System.IO;

namespace Basic_C_Sharp
{
    #region
    //NAME          :- ReadTextFile
    //AUTHOR        :- SHIKHA MALIK
    //DESCRIPTION   :- Show text of file 
    //CREATED DATE  :- 18/07/2012 

    class ReadTextFile
    {
        //NAME          :- ReadText
        //AUTHOR        :- SHIKHA MALIK
        //DESCRIPTION   :- Show text of file 
        //CREATED DATE  :- 18/07/2012 

        public void ReadText()
        {
            try
            {
                using (StreamReader sr = File.OpenText(@"D:\DotNetSkillUp_VSS\Source Code\Shikha.txt"))
                {
                    string strSrf = "";
                    while ((strSrf = sr.ReadLine()) != null)                    //To display all lines
                    {
                        Console.WriteLine(strSrf);                                //Show the contents on console line by line
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);                               //Display error messege if any exception is occured
            }
        }
    }
    #endregion
}
