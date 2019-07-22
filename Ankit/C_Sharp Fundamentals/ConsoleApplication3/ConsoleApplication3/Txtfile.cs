using System;
using System.IO;
namespace ConsoleApplication3
{
    #region Txtfile
    //Name                      : Txtfile
    //Auther                    : Ankit Sharma
    //Created Date              : 03/07/2012
    //Description               : To write five lines into a file 
    class Txtfile
    {
        #region file
        /* ********************************* Function for Create And Write in text file ************************************/
        public void file()
        {
           // Common objcmn;
            string[] strTxt;
            int intSize;
            StreamWriter sw;
            try
            {
                Console.WriteLine(Constant.strMsgLine);                                                 // Getting the input for number of lines
                intSize = int.Parse(Console.ReadLine());                                          //Getting the input in variable num
                strTxt = new string[intSize];
                string path = @"D:\DotNetSkillup\Source Code\Ankit\C_Sharp Fundamentals\ConsoleApplication3\Ankit.txt";
                for (int i = 0; i < intSize; i++)                                              //Looping for reading the num of lines
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
                        for (int i = 0; i < intSize; i++)                                    //Looping for lines have to enter
                        {
                            sw.WriteLine(strTxt[i]);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);                                                       //Display messege if any error is occured
            }
            finally
            {
                //objcmn = null;                                                                       //destroying the object
            }
        }
        #endregion filee
    }
    #endregion Txtfile
}
