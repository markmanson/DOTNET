using System;
namespace ConsoleApplication3
{
     #region Vowel
    //Name                      : Vowel
    //Auther                    : Ankit Sharma
    //Created Date              : 27/06/2012
    //Description               : To check whether a character input by the user is vowel or not   
    class Vowel
    {
        #region check
        //Function to check whether the character input by the user is vowel or not        
        public void check()
        {
            char chrv;
            string strtemp;
            try
            {
                Console.WriteLine(Constant.strEnterVowel);
                strtemp = Console.ReadLine();                          //Getting a character from user   
                if (strtemp.Length < 2)
                {
                    chrv = char.Parse(strtemp);
                    if (char.IsLetter(chrv))
                    {
                        if (chrv == 'a' || chrv == 'A' || chrv == 'e' || chrv == 'E' || chrv == 'i' || chrv == 'I' || chrv == 'o' || chrv == 'O' || chrv == 'u' || chrv == 'U')
                        {
                            Console.WriteLine(Constant.strVowel);                    //Display if character is vowel 
                        }
                        else
                        {
                            Console.WriteLine(Constant.strConsonent);                //Display if character is not vowel
                        }
                    }
                    else
                    {
                        Console.WriteLine(Constant.strSorryVowel);                  //Display sorry messege if user did not enter a character 
                    }
                }
                else
                {
                    Console.WriteLine(Constant.strMsgSrr);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                strtemp = null;
            }
        }
        #endregion check
    }
    #endregion Vowel
}

