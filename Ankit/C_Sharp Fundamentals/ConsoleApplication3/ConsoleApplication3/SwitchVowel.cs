using System;
namespace ConsoleApplication3
{
    #region Switch
    //Name                      : SwitchVowel
    //Auther                    : Ankit Sharma
    //Created Date              : 27/06/2012
    //Description               : To check whether a character input by user is a vowel or not by the help of switch
    class SwitchVowel
    {
        #region CheckVowelSwitch
        //Function to check whether the character entered by user is vowel or not by the help of switch case
        public void checkVowelSwitch()
        {
            char chrvs;
            string strtemp;
            try
            {
                Console.WriteLine(Constant.strEnterVowel);
                strtemp = Console.ReadLine();                                   //Getting the character by user
                if (strtemp.Length < 2)
                {
                    chrvs = char.Parse(strtemp);
                    switch (chrvs)                                                  //To check whether the character is vowel or not
                    {
                        case 'a':
                        case 'A':
                        case 'e':
                        case 'E':
                        case 'i':
                        case 'I':
                        case 'o':
                        case 'O':
                        case 'u':
                        case 'U':
                            Console.WriteLine("Character is Vowel");
                            break;
                        default:
                            Console.WriteLine("Character is Consonent");
                            break;
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
        #endregion CheckVowelSwitch
    }
    #endregion SwitchVowel
}
