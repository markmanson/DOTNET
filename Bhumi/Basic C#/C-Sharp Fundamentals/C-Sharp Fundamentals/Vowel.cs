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
    /// Class Name:Vowel
    /// Description://Accept an alphabet from the user and print out if it's a vowel or a consonant
    /// Author:
    /// Created On:21/5/2015
    /// </summary>
    /// 
    class Vowel
    {
        #region "Find vowel"
        ConstantMessage objconst; //object creation
        /// <summary>
        ///Method Name:FindVowel
        /// Description://check that entered character is vowel or not
        /// Author:bhumi
        /// Created On:21/5/2015
        /// </summary>
        public void FindVowel()
        {            
                try
                {
                    objconst = new ConstantMessage();
                    Console.WriteLine(objconst.strChar);
                    char ch =Convert.ToChar(Console.ReadLine());
                    if (ch == 'A' || ch == 'a' || ch == 'E' || ch == 'e' || ch == 'I' || ch == 'i' || ch == 'O' || ch == 'o' || ch == 'U' || ch == 'u')
                    {
                        Console.WriteLine(objconst.strVowel);
                    }
                    else
                    {
                        Console.WriteLine(objconst.strconsonant);
                    }                  
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
