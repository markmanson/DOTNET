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
    /// Class Name:FindSwitchVowel
    /// Description://Modify the above code to use switch-case construct
    /// Author:
    /// Created On:21/5/2015
    /// </summary>
    /// 
    class SwichVowel
    {
        #region FindVowelUsing Switch
        ConstantMessage objconst;//object creation
        /// <summary>
        ///MethodName:FindSwitchVowel
        /// Description://check that entered character is vowel or not using switch case
        /// Author:bhumi
        /// Created On:21/5/2015
        /// </summary>
        /// 
        public void FindSwitchVowel()
        {
            //Modify the above code to use switch-case construct
            try
            {
                objconst = new ConstantMessage();
                Console.WriteLine(objconst.strChar);
                char ch = Convert.ToChar(Console.ReadLine());//get the character from user
                switch (ch)
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
                        Console.WriteLine(objconst.strVowel);
                        Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine(objconst.strconsonant);
                        break;
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
