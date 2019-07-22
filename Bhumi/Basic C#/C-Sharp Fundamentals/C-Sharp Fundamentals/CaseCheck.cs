using System;
/// <summary>
///NameSpace:CSharp
/// Description://Fundamental study programs of C#
/// Author:bhumi
/// Created On:21/5/2015
/// </summary>
///
namespace CSharp
{
    /// <summary>
    /// Class Name:CaseCheck
    /// Description://Accept any number of alphabets and digits from the user and separate them
    /// Author:
    /// Created On:18/5/2015
    /// </summary>
    /// 
    class CaseCheck
    {
        #region separation of Characters & Digits
        ConstantMessage objconst;//object creation
        /// <summary>
        ///MethodName:CountChar
        /// Description://count uppercase lowercase & digits from input string
        /// Author:bhumi
        /// Created On:21/5/2015
        /// </summary>        
        public void CountChar()
        {
            try
            {
                objconst = new ConstantMessage();                
                //Declaring integers to be used 
                int countedWords = 0;
                int cap_count = 0;
                int lower_count = 0;
                int digit = 0;
                Console.WriteLine(objconst.strstring);
                string inputString = Console.ReadLine();
                //counts words
                countedWords = inputString.Split(' ').Length;
                foreach (char c in inputString)
                {
                    //if is upper case add to cap_count
                    if (Char.IsUpper(c))
                        cap_count++;
                    //if char is a punctuation or white space ignore it else 
                    // add as lower case
                    else if (!char.IsPunctuation(c) && !char.IsWhiteSpace(c) && !char.IsDigit(c))
                        lower_count++;
                    //find the digits
                    else if (Char.IsDigit(c))
                    {
                        digit++;
                    }
                }
                //display results.
                Console.WriteLine(objconst.strletter + (cap_count + lower_count));
                Console.WriteLine(objconst.strupper + cap_count);
                Console.WriteLine(objconst.strlower + lower_count);
                Console.WriteLine(objconst.strdigit + digit);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                objconst = null;
            }
        }
        #endregion
    }
}
