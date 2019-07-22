using System;

namespace Program
{
    /*--------------------------------------------------------------------------------------------------------------------
         Name:CaseCheck.cs
         Author:Monal Shah
         Description:"Accept any number of alphabets and digits from the user.
                      Print out the number of lowercase letters, uppercase letters and digits."
         Example:12MONal
                Output:Digit:2
                       UpperLetter:3
                       LowerLetter:2 
         CreatedDate: 2010/09/06 by Monal Shah
 -------------------------------------------------------------------------------------------------------------------
 */
    class CaseCheck
    {
        /*---------------------------------------------------------------------------------------------------------------
        Name:CaseCheckLettersDigit
        Paramametres:0
        Description:This method accepts the digit,Upeercaseletter and lowercase letters from the user 
                    and then it is calculate how many digit,Upper Letters and lower letters user had entered.
                     

        Author:Monal Shah
        CreatedDate: 2010/09/06 by Monal Shah
    ---------------------------------------------------------------------------------------------------------------
    */
        public void CaseCheckLettersDigit()
        {
            /*
           [Date]:2010/09/09 
           [Author Name]:Monal Shah
           Description:Add try catch and finally Block in code
          */
            CommonLogic objCL = new CommonLogic();//objCL is object of the CommonLogic Class
            string strChnDig;
            char[] chrCh;
            const int intIdi = 0, IntUp = 1, intLo = 2;
            try
            {
                Console.WriteLine("Please write any no. of caharacters and digits: ");               
                strChnDig = Console.ReadLine();//strChnDig is the variable name of string datatype.It is used for accepting  data from Console.
                chrCh = strChnDig.ToCharArray();//chrCh is the variable name of char array and ToCharArray Copies the character in this instances to a unicode character array.   
                int intDigit = objCL.CheckDigitAndCharacters(chrCh, intIdi);//CheckDigit is method of class commonlogic and here digit is checked if it is in input
                int intUpper = objCL.CheckDigitAndCharacters(chrCh, IntUp);//CheckUpperLetter is method of class commonlogic and here Upper Letter is checked if it is in input
                int intLower = objCL.CheckDigitAndCharacters(chrCh, intLo);//CheckLowerLetter is method of class commonlogic and here Lower Letter is checked if it is in input 
                Console.WriteLine("Total digits:" + intDigit);//Total digits will be displayed
                Console.WriteLine("Total Upper Letters:" + intUpper);//Total upperletter will be displayed
                Console.WriteLine("Total Lower Letters:" + intLower);//Total upperletter will be displayed
                Console.ReadLine();
            }
            catch (Exception ExException)
            {
                Console.WriteLine("Error:" + ExException.Message); ;// exception
            }
            finally
            {
                chrCh = null;
                strChnDig = null;
                objCL = null;
            }
        }
        
    }
}
