using System;

namespace Program
{
    /*-------------------------------------------------------------------------------------------------------------------
   Name:SwitchVowel.cs
   Author:Monal Shah
   Description:This Program is identify the character which is either Vowel Or consonant with the help of switchcase.
   CreatedDate: 2010/09/06 by Monal Shah
   -------------------------------------------------------------------------------------------------------------------
   */

    class SwichVowel
    {
        /*---------------------------------------------------------------------------------------------------------------
           Name:SwitchCase 
           Paramametres:0
           Description:This method is used for identifying the entered character is vowel or consonant throgh the switch case.
           Author:Monal Shah
           CreatedDate: 2010/09/06 by Monal Shah
       ---------------------------------------------------------------------------------------------------------------
       */
        public void SwitchCase()
        {
            /*
            [Date]:2010/09/09 
            [Author Name]:Monal Shah
            Description:Add try catch and finally Block in code
           */
            try
            {
                Console.WriteLine("Please enter alphabate");
                string strEnterCaseValue = Console.ReadLine(); //strEnterCaseValue is the variable of strind Datatype

                /*
                 Here in below code length of string will be compared if it is 1 then and only then
                 it goes to another condition for comparision otherwise it goes to the else condition of the if statement.*/
                if (strEnterCaseValue.Length == 1)
                {
                    /*
                     If Case 'a' then output is "It is Vowel"
                     If Case 'i' then output is "It is Vowel"
                     If Case 'o' then output is "It is Vowel"
                     If Case 'e' then output is "It is Vowel"
                     If Case 'u' then output is "It is Vowel"
                     Otherwise the output is "It is Consonant"
                     */
                    switch (strEnterCaseValue)
                    {
                        case "a":
                            Console.WriteLine("It is vowel");
                            Console.ReadLine();
                            break;
                        case "e":
                            Console.WriteLine("It is vowel");
                            Console.ReadLine();
                            break;
                        case "i":
                            Console.WriteLine("It is vowel");
                            Console.ReadLine();
                            break;
                        case "o":
                            Console.WriteLine("It is vowel");
                            Console.ReadLine();
                            break;
                        case "u":
                            Console.WriteLine("It is vowel");
                            Console.ReadLine();
                            break;
                        default:
                            Console.WriteLine("It is consonant");
                            Console.ReadLine();
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Please enter only one character");
                    Console.ReadLine();
                }
            }
            catch (Exception ExException)
            {
                Console.WriteLine("ERROR:" + ExException.Message);//exception
            }
        }
    }
}

