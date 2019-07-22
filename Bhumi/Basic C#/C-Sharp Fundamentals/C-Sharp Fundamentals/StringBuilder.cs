using System.Text;
using System;
/// <summary>
///NameSpace:CSharp
/// Description://Fundamental study programs of C#
/// Author:bhumi
/// Created On:25/5/2015
/// </summary>
namespace CSharp
{
    /// <summary>
    /// Class Name:StringBuilder_Str
    /// Description://Accept an amount from user.  Print the amount in words using a StringBuilder class
    /// Author:
    /// Created On:25/5/2015
    /// </summary>
    /// 
    class StringBuilder_Str 
    {
        #region String Builder Class
        ///<summary>
        ///Method Name:NumbersToWords
        /// Description://Method for convertion amount in number to word using stringbuilder class
        /// Author:bhumi
        /// Created On:21/5/2015
        /// </summary>                                                       
        public string NumbersToWords(int inputNumber)
        {            
                int inputNo = inputNumber;
                if (inputNo == 0)
                    return "Zero";
                int[] numbers = new int[4];
                int first = 0;
                int u, h, t;
                StringBuilder sb = new StringBuilder();
                //input less than 0
                if (inputNo < 0)
                {
                    sb.Append("Minus ");
                    inputNo = -inputNo;
                }
                //required words
                string[] words0 = {"" ,"One ", "Two ", "Three ", "Four ",
            "Five " ,"Six ", "Seven ", "Eight ", "Nine "};
                string[] words1 = {"Ten ", "Eleven ", "Twelve ", "Thirteen ", "Fourteen ",
            "Fifteen ","Sixteen ","Seventeen ","Eighteen ", "Nineteen "};
                string[] words2 = {"Twenty ", "Thirty ", "Forty ", "Fifty ", "Sixty ",
            "Seventy ","Eighty ", "Ninety "};
                string[] words3 = { "Thousand ", "Lakh ", "Crore " };
                //formulas for convertion
                numbers[0] = inputNo % 1000; // units
                numbers[1] = inputNo / 1000;
                numbers[2] = inputNo / 100000;
                numbers[1] = numbers[1] - 100 * numbers[2]; // thousands
                numbers[3] = inputNo / 10000000; // crores
                numbers[2] = numbers[2] - 100 * numbers[3]; // lakhs
                for (int i = 3; i > 0; i--)
                {
                    if (numbers[i] != 0)
                    {
                        first = i;
                        break;
                    }
                }
                for (int i = first; i >= 0; i--)
                {
                    if (numbers[i] == 0)
                        continue;
                    //concatenation
                    u = numbers[i] % 10; // ones
                    t = numbers[i] / 10;
                    h = numbers[i] / 100; // hundreds
                    t = t - 10 * h; // tens
                    if (h > 0) sb.Append(words0[h] + "Hundred ");
                    if (u > 0 || t > 0)
                    {
                        if (h > 0 || i == 0) sb.Append("and ");
                        if (t == 0)
                            sb.Append(words0[u]);
                        else if (t == 1)
                            sb.Append(words1[u]);
                        else
                            sb.Append(words2[t - 2] + words0[u]);
                    }
                    if (i != 0) sb.Append(words3[i - 1]);
                }
                return sb.ToString();
            }                           
        #endregion
    }
}
