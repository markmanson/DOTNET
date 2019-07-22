using System;

namespace Program
{
    /*-------------------------------------------------------------------------------------------------------------------
    Name:Vowel.cs
    Author:Monal Shah
    Description:This Program is identify the character which is either Vowel Or consonant.
    CreatedDate: 2010/09/06 by Monal Shah
    -------------------------------------------------------------------------------------------------------------------
    */

    class Vowel
    {
        /*---------------------------------------------------------------------------------------------------------------
            Name:VowelCharacter 
            Paramametres:0
            Description:This method is used for identifying the entered character is vowel or consonant.
            Author:Monal Shah
            CreatedDate: 2010/09/06 by Monal Shah
        ---------------------------------------------------------------------------------------------------------------
        */ 

        public void VowelCharacter()
        {
            /*
            [Date]:2010/09/09 
            [Author Name]:Monal Shah
            Description:Add try catch and finally Block in code
           */
            try
            {
                Console.WriteLine("Please enter alphabate");
                string strVowel = Console.ReadLine(); //str is the varible of type string
                /*Here in below code length of string will be compared if it is 1 then and only then
                 it goes to another condition for comparision otherwise it goes to the else condition of the if statement.*/             
                if (strVowel.Length == 1)
                {
                    /*
                     Here the alphabate value chaeck if alphabate value is matched then it displays "It is Vowel".
                     Else it displays "It is consonant".*/
                    if (strVowel.Equals("a") ||
                        strVowel.Equals("e") ||
                        strVowel.Equals("i") || 
                        strVowel.Equals("o") ||
                        strVowel.Equals("u"))
                    {
                        Console.WriteLine("it is vowel");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("it is consonant");
                        Console.ReadLine();
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
