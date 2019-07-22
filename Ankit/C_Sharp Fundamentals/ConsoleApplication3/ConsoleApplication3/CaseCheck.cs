using System;
namespace ConsoleApplication3
{
    #region CaseCheck

    //Name                      : CaseCheck
    //Auther                    : Ankit Sharma
    //Created Date              : 27/06/2012
    //Description               : To check whether the character input by user is a digit or lower case or upper case
    class CaseCheck
    {
        #region checkcase
        //Function to check the numbers of digits , upper case letters and lower case letters in a string entered by user***************************
        public void checkcase()
        {
            string strcc;
            int intDig,intUpper,intLower,intSymbol,intPunc;
            try
            {
                intDig = 0;
                intUpper = 0;
                intLower = 0;
                intSymbol = 0;
                intPunc = 0;
                Console.WriteLine(Constant.strInputStr);
                strcc = Console.ReadLine();                                      //Getting string entered by user
                foreach (char chrcc in strcc)
                {
                    if (Char.IsDigit(chrcc))                                    //To check whether the character is digit
                    {
                        intDig++;

                    }
                    else if (Char.IsLower(chrcc))                               //To check whether the character is Lower case character
                    {
                        intLower++;

                    }
                    else if (Char.IsUpper(chrcc))                               //To check whether the character is upper case character
                    {
                        intUpper++;
                    }
                    else if (char.IsSymbol(chrcc))
                    {
                        intSymbol++;
                    }
                    else if (char.IsPunctuation(chrcc))
                    {
                        intPunc++;
                    }
                }
                //Display the  numbers of digits , lower case characters and upper case characters exists in string
                Console.WriteLine("Characters in Lower case are:- " + intLower);
                Console.WriteLine("Characters in Upper case are:- " + intUpper);
                Console.WriteLine("Digits  are:- " + intDig);
                Console.WriteLine("Symbols are :-" + intSymbol);
                Console.WriteLine("Punctuation marks are :-" + intPunc);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        #endregion checkcase
    }
    #endregion CaseCheck
}
