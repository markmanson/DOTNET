using System;

namespace Basic_C_Sharp
{
    #region
    //NAME          :- SWITCHVOWEL
    //AUTHOR        :- SHIKHA MALIK
    //DESCRIPTION   :- Enter Alphabet is vowel or consonent     
    //CREATED DATE  :- 12/07/2012

    class SwitchVowel
    {
        //NAME          :- Switchvl
        //AUTHOR        :- SHIKHA MALIK
        //DESCRIPTION   :- Enter Alphabet is vowel or consonent     
        //CREATED DATE  :- 12/07/2012

        public  void Switchvl()                                    
        {
            string strSv;                                             // Declare string
            try
            {
                Console.WriteLine(Constant.strEntrC);              // Gather information of input
                strSv = Console.ReadLine();                           // Read value of character
                switch (strSv)                                       // switch case for print vowel character
                {
                    case "a":
                    case "A":
                    case "e":
                    case "E":
                    case "i":
                    case "I":
                    case "o":
                    case "O":
                    case "u":
                    case "U":
                        Console.WriteLine(Constant.strMsgVl + strSv);       // input  character is vowel
                        break;                                               // character is vowel then exit from switch case
                    default:
                        Console.WriteLine(Constant.strMsgNvl + strSv);     //  input character is consotent
                        break;                                                 // character is consotent then  exit from switch case
                }
            }
            catch (Exception ex)                                                // Use for throw the exception
            {
                System.Console.WriteLine(ex.Message);
            }
            finally                                                         // use for free memory
            {
                 strSv = null;                                                 // free memory of string
            }
        }
    }
    #endregion
}
