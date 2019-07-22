using System;
using System.IO;

namespace Basic_C_Sharp
{
    #region
    //NAME          :- TextFile
    //AUTHOR        :- SHIKHA MALIK
    //DESCRIPTION   :- Create File text of file 
    //CREATED DATE  :- 18/07/2012 

    class TextFile
    {
        //NAME          :- TextFileM
        //AUTHOR        :- SHIKHA MALIK
        //DESCRIPTION   :- Create File text of file 
        //CREATED DATE  :- 18/07/2012 

        public void TextFileM()
        {
            string[] strTxt;
            int intSize;
            StreamWriter sw;
            try
            {
                Console.WriteLine(Constant.strEntrLine);                                                 // Getting the input for number of lines
                intSize = int.Parse(Console.ReadLine());                                          //Getting the input in variable num
                strTxt = new string[intSize];
                string path = @"D:\DotNetSkillUp_VSS\Source Code\Shikha.txt";
                for (int i = 0; i < intSize; i++)                                              //Loop for reading the num of lines
                {
                    strTxt[i] = Console.ReadLine();                                            //getting it in the strtext
                }
                if (!File.Exists(path))                                                      //condition if file not exits
                {
                    using (sw = File.AppendText(path))                                       //wtite in the file
                    {
                        for (int i = 0; i < intSize; i++)                                     //For getting the size of lines which hav to enter
                        {
                            sw.WriteLine(strTxt[i]);
                        }
                    }
                }
                else
                {
                    using (sw = File.AppendText(path))                                        //If file exits then append it
                    {
                        for (int i = 0; i < intSize; i++)                                    //Loop for lines have to enter
                        {
                            sw.WriteLine(strTxt[i]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                                                       //Throw exception
            }
            finally
            {
                sw = null;
                strTxt = null;
            }
 
        }
    }
    #endregion
}

